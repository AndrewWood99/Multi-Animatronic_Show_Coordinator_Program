using Pololu.UsbWrapper;
using Pololu.Usc;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using NAudio.Wave;
using System.Security.Cryptography;

namespace Droid_Show_Program
{
    public partial class RoutineBuilderGroup : UserControl
    {
        public RoutineBuilderGroup()
        {
            InitializeComponent();
        }

        private string AudioFile;
        private string SequenceNumber;
        private string StartTime;
        private string Line;
        private string[] data;

        private double timePassed = 0;
        private int sequenceNumber = 0;

        private NAudio.Wave.WaveFileReader wave = null;
        private NAudio.Wave.DirectSoundOut player = null;

        public string MaestroID { get; set; } = "";
        public string MaestroName { get; set; } = "";

        private Usc usc = null;

        private void LoadRoutineButton_Click(object sender, EventArgs e)
        {
            // Open a File browser
            OpenFileDialog ofd = new OpenFileDialog();
            // In the correct Initial directory
            string InitialDirectory = System.Reflection.Assembly.GetExecutingAssembly().Location;
            InitialDirectory = InitialDirectory.Substring(0, InitialDirectory.Length - 81);
            InitialDirectory = InitialDirectory + "Routines";
            ofd.InitialDirectory = InitialDirectory;
            // Then title and show the file browser
            ofd.Title = "Load Routine";
            ofd.Filter = "Text Files (*.txt)|*.txt";
            ofd.ShowDialog();

            // Check if File was selected, and if file is a TXT
            if (ofd.FileName != "")
            {
                string fileExt = System.IO.Path.GetExtension(ofd.FileName);

                if (fileExt != ".txt")
                {
                    MessageBox.Show("Not a .txt file type!", "Input Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    LoadedRoutineTextBox.Text = ofd.FileName;

                    RoutineListView.Items.Clear();

                    try
                    {
                        StreamReader sr = new StreamReader(ofd.FileName);

                        // Check if name and ID matches current droid
                        // Skip to the 3rd line, since lines 1 and 2 are used for Maestro Name & ID
                        Line = sr.ReadLine();
                        bool flag = false;
                        if (Line != MaestroName)
                        {
                            MessageBox.Show("This routine was last saved for the Droid named: " + Line + "!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            flag = true;
                        }
                        Line = sr.ReadLine();
                        if (Line != MaestroID && flag == false)
                        {
                            MessageBox.Show("This routine was last saved for a Droid of Maestro ID: " + Line + "!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        Line = sr.ReadLine();

                        while (Line != null)
                        {
                            data = Line.Split(';');

                            StartTime = data[1];
                            SequenceNumber = data[3];
                            AudioFile = data[5];

                            // Assign row to Routine List
                            string[] row = { StartTime, SequenceNumber, AudioFile };
                            var ListViewItem = new ListViewItem(row);
                            RoutineListView.Items.Add(ListViewItem);

                            Line = sr.ReadLine();
                        }

                        sr.Close();
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine("Exception: " + ex.Message);
                    }                    
                }
            }

            
            // NEED TO IMPLIMENT
            // Update Routine List
        }

        public void LoadRoutineFromShow(string routine)
        {
            LoadedRoutineTextBox.Text = routine;
            RoutineListView.Items.Clear();

            StreamReader sr = new StreamReader(routine);

            // Check if name and ID matches current droid
            // Skip to the 3rd line, since lines 1 and 2 are used for Maestro Name & ID
            Line = sr.ReadLine();
            Line = sr.ReadLine();
            Line = sr.ReadLine();

            while (Line != null)
            {
                data = Line.Split(';');

                StartTime = data[1];
                SequenceNumber = data[3];
                AudioFile = data[5];

                // Assign row to Routine List
                string[] row = { StartTime, SequenceNumber, AudioFile };
                var ListViewItem = new ListViewItem(row);
                RoutineListView.Items.Add(ListViewItem);

                Line = sr.ReadLine();
            }

            sr.Close();
        }

        private void AddSequenceButton_Click(object sender, EventArgs e)
        {
            // Check if there is no Sequence and no Audio file
            /*
            if (SetAudioFileTextBox.Text == "" && SetNoSeqCheckBox.Checked == true)
            {
                MessageBox.Show("No Sequence or Audio File!", "Input Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            */

            // Check if there is another Sequence starting at the same time
            // Else Set Start Time
            for (int i = 0; i < RoutineListView.Items.Count; i++)
            {
                if (SetTimeStartNumeric.Text == RoutineListView.Items[i].SubItems[0].Text)
                {
                    MessageBox.Show("Can't add a duplicate timed Sequence!", "Input Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            StartTime = SetTimeStartNumeric.Text;

            // Check if no Audio file was selected
            // Else set Audio File
            if (SetAudioFileTextBox.Text == "")
            {
                AudioFile = "n/a";
            }
            else
            {
                AudioFile = SetAudioFileTextBox.Text;
            }

            // Check if the checkbox for no Sequence is selected
            // Else Set Sequence Number
            if (SetNoSeqCheckBox.Checked == true)
            {
                SequenceNumber = "n/a";
            }
            else
            {
                SequenceNumber = SetSequenceNumeric.Text;
            }

            

            // Assign row to Routine List
            string[] row = { StartTime, SequenceNumber, AudioFile };
            var ListViewItem = new ListViewItem(row);
            RoutineListView.Items.Add(ListViewItem);

            // Reset Loaded Routine TextBox
            LoadedRoutineTextBox.Text = "*new routine*";

            // Re order Routine Listview by Start Time
            RoutineListView.ListViewItemSorter = new ListViewItemComparer(0);
        }

        private void BrowseAudioFileButton_Click(object sender, EventArgs e)
        {
            SetAudioFileTextBox.Text = "";

            // Open a File browser
            OpenFileDialog ofd = new OpenFileDialog();
            // In the correct Initial directory
            string InitialDirectory = System.Reflection.Assembly.GetExecutingAssembly().Location;
            InitialDirectory = InitialDirectory.Substring(0, InitialDirectory.Length - 81);
            InitialDirectory = InitialDirectory + "wav_files";
            ofd.InitialDirectory = InitialDirectory;
            // Then title and show the file browser
            ofd.Title = "Load Audio File";
            ofd.Filter = "wav Files (*.wav)|*.wav";
            ofd.ShowDialog();

            // Check if File was selected, and id file is an MP3
            if (ofd.FileName != "")
            {
                string fileExt = System.IO.Path.GetExtension(ofd.FileName);

                if (fileExt == ".wav")
                {
                    SetAudioFileTextBox.Text = ofd.FileName;
                }
                else
                {
                    MessageBox.Show("Not a .wav file type!", "Input Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void DeleteSelectedSequenceButton_Click(object sender, EventArgs e)
        {
            // Check if a row is selected, then remove it, and reset Saved Routine TextBox
            if (RoutineListView.SelectedItems.Count == 1)
            {
                RoutineListView.Items.Remove(RoutineListView.SelectedItems[0]);
                LoadedRoutineTextBox.Text = "*new routine*";
            }
            else
            {
                MessageBox.Show("Select a Sequence to Delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void SaveCurrentRoutineButton_Click(object sender, EventArgs e)
        {
            
            // Check of Routine List is empty, or if existing Routine was aleardy loaded
            if (RoutineListView.Items.Count == 0)
            {
                MessageBox.Show("No Routine to Save", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (LoadedRoutineTextBox.Text != "*new routine*")
            {
                MessageBox.Show("This Routine is Already Saved", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Then Save Routine List contents to TXT file
            else
            {
                //Create a SAVE file browser
                SaveFileDialog sfd = new SaveFileDialog();
                // In the correct Initial directory
                string InitialDirectory = System.Reflection.Assembly.GetExecutingAssembly().Location;
                InitialDirectory = InitialDirectory.Substring(0, InitialDirectory.Length - 81);
                InitialDirectory = InitialDirectory + "Routines";
                sfd.InitialDirectory = InitialDirectory;
                // Then title and show the file browser
                sfd.Title = "Save Routine";
                sfd.Filter = "Text Files (*.txt)|*.txt";
                sfd.DefaultExt = "txt";
                sfd.AddExtension = true;
                
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (var tw = new StreamWriter(sfd.FileName))
                    {
                        // Log the droid Name being used
                        tw.WriteLine(MaestroName);

                        // Log the droid Maestro ID being used
                        tw.WriteLine(MaestroID);

                        // Log the routine information
                        foreach (ListViewItem item in RoutineListView.Items)
                        {
                            tw.Write("StartTime;");
                            tw.Write(item.SubItems[0].Text);
                            tw.Write(";Sequence#;");
                            tw.Write(item.SubItems[1].Text);
                            tw.Write(";AudioFile;");
                            tw.WriteLine(item.SubItems[2].Text);
                        }
                    }

                    LoadedRoutineTextBox.Text = sfd.FileName;
                }
                

            }
        }

        private void SetNoSeqCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // If No Seq is checked, indicate by disabling Set Sequence Numeric
            if (SetNoSeqCheckBox.Checked == true)
            {
                SetSequenceNumeric.Enabled = false;
            }
            else
            {
                SetSequenceNumeric.Enabled = true;
            }
        }

        public void RunRoutineButton_Click(object sender, EventArgs e)
        {
            // Check if a routine exists, if not then do not start a routine
            if (RoutineListView.Items.Count == 0)
            {
                MessageBox.Show("No Routine to Run", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // If Stop button is active, end routine
            if (RunRoutineButton.Text == "STOP Running Routine")
            {
                if (player != null)
                {
                    player.Stop();
                }
                if (usc != null)
                {
                    usc.reinitialize();
                    usc.Dispose();  // Disconnect
                    usc = null;
                }
                RunRoutineButton.Text = "Run Current Routine";
                RunRoutineButton.BackColor = System.Drawing.Color.FromArgb(0, 255, 255, 255);
                EnableControl();
                RunTimer.Stop();
                timePassed = 0;
                sequenceNumber = 0;
                return;
            }


            // Set button to stop running routine
            RunRoutineButton.Text = "STOP Running Routine";
            RunRoutineButton.BackColor = System.Drawing.Color.Red;
            DisableControl();

            // Find Maestro Device number
            
            
            // Starts the Routine
            RunTimer.Start();

            

        }

        private void DisableControl()
        {
            RoutineListView.Enabled = false;
            AddSequenceButton.Enabled = false;
            BrowseAudioFileButton.Enabled = false;
            SetNoSeqCheckBox.Enabled = false;
            SetSequenceNumeric.Enabled = false;
            SetTimeStartNumeric.Enabled = false;
            LoadRoutineButton.Enabled = false;
        }

        private void EnableControl()
        {
            RoutineListView.Enabled = true;
            AddSequenceButton.Enabled = true;
            BrowseAudioFileButton.Enabled = true;
            SetNoSeqCheckBox.Enabled = true;
            SetSequenceNumeric.Enabled = true;
            SetTimeStartNumeric.Enabled = true;
            LoadRoutineButton.Enabled = true;
        }

        private void RunTimer_Tick(object sender, EventArgs e)
        {
            timePassed += 0.1;

            if (timePassed > Convert.ToDouble(RoutineListView.Items[sequenceNumber].SubItems[0].Text))
            {

                // Set Maestro to run sequence
                if (RoutineListView.Items[sequenceNumber].SubItems[1].Text != "n/a")
                {
                    byte q = Convert.ToByte(RoutineListView.Items[sequenceNumber].SubItems[1].Text);
                    try
                    {
                        foreach (DeviceListItem d in Usc.getConnectedDevices())
                        {
                            if (d.serialNumber == MaestroID)
                            {
                                if (usc == null)
                                {
                                    usc = new Usc(d);
                                }
                                usc.restartScriptAtSubroutine(q);
                                usc.setScriptDone(0);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Disconnect Maestro from other software!\n(Probably Pololu Maestro Control Center)", "Maestro Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                
                // Play Audio File
                if (RoutineListView.Items[sequenceNumber].SubItems[2].Text != "n/a")
                {
                    if (player != null)
                    {
                        player.Stop();
                    }
                    wave = new NAudio.Wave.WaveFileReader(RoutineListView.Items[sequenceNumber].SubItems[2].Text);
                    player = new NAudio.Wave.DirectSoundOut();
                    player.Init(new NAudio.Wave.WaveChannel32(wave));
                    player.Play();
                }


                // Finally Incriment sequence Number and check if routine is over
                sequenceNumber++;

                Console.WriteLine(sequenceNumber.ToString());

                if (sequenceNumber == RoutineListView.Items.Count)
                {
                    if (LoopCheckBox.Checked)
                    {
                        timePassed = 0;
                        sequenceNumber = 0;
                    }
                    else
                    {
                        RunTimer.Stop();
                        RunRoutineButton_Click(new object(), new EventArgs());
                    }
                    
                    
                }
            }
        }
    }

    // This Class Implements the manual sorting of items by columns.
    // I use this to sort the Routine List by Start Time
    class ListViewItemComparer : IComparer
    {
        private int col;
        public ListViewItemComparer()
        {
            col = 0;
        }
        public ListViewItemComparer(int column)
        {
            col = column;
        }
        public int Compare(object x, object y)
        {
            return Decimal.Compare(Convert.ToDecimal(((ListViewItem)x).SubItems[col].Text), Convert.ToDecimal(((ListViewItem)y).SubItems[col].Text));
        }
    }


}
