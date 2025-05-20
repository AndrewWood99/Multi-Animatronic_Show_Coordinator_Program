using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Pololu.Usc;
using Pololu.UsbWrapper;
using System.Threading;
using Microsoft.VisualBasic;
using System.Linq;
using System.Drawing.Text;
using System.Security.Cryptography;
using WMPLib;
using System.IO;
using static System.Windows.Forms.LinkLabel;
using System.Reflection;
using System.Runtime.Remoting.Contexts;
using System.Diagnostics.Contracts;
using System.Runtime.InteropServices;
using AxWMPLib;

namespace Droid_Show_Program
{
    public partial class FrontPage : Form
    {
        

        public FrontPage()
        {
            InitializeComponent();

            string strExeFilePath = System.Reflection.Assembly.GetExecutingAssembly().Location;
            strExeFilePath = strExeFilePath.Substring(0, strExeFilePath.Length - 22);
            if (!File.Exists(strExeFilePath + '\\' + "Droid_List.txt"))
            {
                StreamWriter sw = new StreamWriter(strExeFilePath + '\\' + "Droid_List.txt");
                sw.WriteLine("00000001 Initial");
                sw.Close();
            }
            

            string test = RuntimeInformation.FrameworkDescription;
            Console.WriteLine(test);
        }

        private System.Media.SoundPlayer player = null;
        private Usc usc = null;
        private Form VideoWindow = new VideoPage();

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Check for Connected Devices
            var device_list = Usc.getConnectedDevices();

            if (device_list.Count == 0)
            {
                ConnectedMaestrosListView.Items.Clear();
            }

            if (device_list.Count != ConnectedMaestrosListView.Items.Count)
            {
                TabReset();

                // First check if new Device to add
                for (int i = 0; i < device_list.Count; i++)
                {
                    bool flag = false;
                    for (int j = 0; j < ConnectedMaestrosListView.Items.Count; j++)
                    {
                        if (device_list[i].serialNumber == ConnectedMaestrosListView.Items[j].SubItems[0].Text)
                        {
                            flag = true;
                        }
                    }

                    if (flag == false)
                    {
                        ConnectedMaestrosListView.Items.Add(device_list[i].serialNumber);
                        
                    }
                }

                

                // Next Check of disconnected Devices need to be removed
                for (int i = 0; i < ConnectedMaestrosListView.Items.Count; i++)
                {
                    bool flag = false;
                    for (int j = 0; j < device_list.Count; j++)
                    {
                        if (device_list[j].serialNumber == ConnectedMaestrosListView.Items[i].SubItems[0].Text)
                        {
                            flag = true;
                        }
                    }

                    if (flag == false)
                    {
                        ConnectedMaestrosListView.Items[i].Remove();
                    }
                }

                // Finally update Names
                string strExeFilePath = System.Reflection.Assembly.GetExecutingAssembly().Location;
                strExeFilePath = strExeFilePath.Substring(0, strExeFilePath.Length - 22);
                StreamReader sr = new StreamReader(strExeFilePath + '\\' + "Droid_List.txt");
                
                string Line = sr.ReadLine();
                string MaestroNumber = null;
                string DroidName = null;



                while (Line != null)
                {
                    MaestroNumber = Line.Substring(0, 8);

                    DroidName = Line.Substring(9, Line.Length - 9);

                    for (int j = 0; j < ConnectedMaestrosListView.Items.Count; j++)
                    {
                        if (ConnectedMaestrosListView.Items[j].SubItems[0].Text == MaestroNumber && ConnectedMaestrosListView.Items[j].SubItems.Count == 1)
                        {
                            ConnectedMaestrosListView.Items[j].Remove();
                            j--;
                            string[] row = { MaestroNumber, DroidName };
                            var ListViewItem = new ListViewItem(row);
                            ConnectedMaestrosListView.Items.Add(ListViewItem);
                        }
                    }
                    
                    Line = sr.ReadLine();
                }
                sr.Close();

                // Then Update Dropdown
                Check_Droid_Names();

                if (ConnectedMaestrosListView.Items.Count >= 1)
                {
                    routineBuilderGroup1.MaestroID = ConnectedMaestrosListView.Items[0].SubItems[0].Text;
                    if(ConnectedMaestrosListView.Items[0].SubItems.Count == 2)
                    {
                        routineBuilderGroup1.MaestroName = ConnectedMaestrosListView.Items[0].SubItems[1].Text;
                    }
                    
                }
                if (ConnectedMaestrosListView.Items.Count >= 2)
                {
                    routineBuilderGroup2.MaestroID = ConnectedMaestrosListView.Items[1].SubItems[0].Text;
                    if (ConnectedMaestrosListView.Items[1].SubItems.Count == 2)
                    {
                        routineBuilderGroup1.MaestroName = ConnectedMaestrosListView.Items[1].SubItems[1].Text;
                    }
                }
                if (ConnectedMaestrosListView.Items.Count >= 3)
                {
                    routineBuilderGroup3.MaestroID = ConnectedMaestrosListView.Items[2].SubItems[0].Text;
                    if (ConnectedMaestrosListView.Items[2].SubItems.Count == 2)
                    {
                        routineBuilderGroup1.MaestroName = ConnectedMaestrosListView.Items[2].SubItems[1].Text;
                    }
                }
                if (ConnectedMaestrosListView.Items.Count >= 4)
                {
                    routineBuilderGroup4.MaestroID = ConnectedMaestrosListView.Items[3].SubItems[0].Text;
                    if (ConnectedMaestrosListView.Items[3].SubItems.Count == 2)
                    {
                        routineBuilderGroup1.MaestroName = ConnectedMaestrosListView.Items[3].SubItems[1].Text;
                    }
                }
                if (ConnectedMaestrosListView.Items.Count >= 5)
                {
                    routineBuilderGroup5.MaestroID = ConnectedMaestrosListView.Items[4].SubItems[0].Text;
                    if (ConnectedMaestrosListView.Items[4].SubItems.Count == 2)
                    {
                        routineBuilderGroup1.MaestroName = ConnectedMaestrosListView.Items[4].SubItems[1].Text;
                    }
                }
                if (ConnectedMaestrosListView.Items.Count >= 6)
                {
                    routineBuilderGroup6.MaestroID = ConnectedMaestrosListView.Items[5].SubItems[0].Text;
                    if (ConnectedMaestrosListView.Items[5].SubItems.Count == 2)
                    {
                        routineBuilderGroup1.MaestroName = ConnectedMaestrosListView.Items[5].SubItems[1].Text;
                    }
                }
                if (ConnectedMaestrosListView.Items.Count >= 7)
                {
                    routineBuilderGroup7.MaestroID = ConnectedMaestrosListView.Items[6].SubItems[0].Text;
                    if (ConnectedMaestrosListView.Items[6].SubItems.Count == 2)
                    {
                        routineBuilderGroup1.MaestroName = ConnectedMaestrosListView.Items[6].SubItems[1].Text;
                    }
                }
                if (ConnectedMaestrosListView.Items.Count >= 8)
                {
                    routineBuilderGroup8.MaestroID = ConnectedMaestrosListView.Items[7].SubItems[0].Text;
                    if (ConnectedMaestrosListView.Items[7].SubItems.Count == 2)
                    {
                        routineBuilderGroup1.MaestroName = ConnectedMaestrosListView.Items[7].SubItems[1].Text;
                    }
                }
                if (ConnectedMaestrosListView.Items.Count >= 9)
                {
                    routineBuilderGroup9.MaestroID = ConnectedMaestrosListView.Items[8].SubItems[0].Text;
                    if (ConnectedMaestrosListView.Items[8].SubItems.Count == 2)
                    {
                        routineBuilderGroup1.MaestroName = ConnectedMaestrosListView.Items[8].SubItems[1].Text;
                    }
                }
                if (ConnectedMaestrosListView.Items.Count >= 10)
                {
                    routineBuilderGroup10.MaestroID = ConnectedMaestrosListView.Items[9].SubItems[0].Text;
                    if (ConnectedMaestrosListView.Items[9].SubItems.Count == 2)
                    {
                        routineBuilderGroup1.MaestroName = ConnectedMaestrosListView.Items[9].SubItems[1].Text;
                    }
                }


            }

            
        }

        private void Check_Droid_Names()
        {
            // Clear names from tab
            for (int i = 0; i < RoutineTabControl.TabPages.Count; i++)
            {
                RoutineTabControl.TabPages[i].Text = "Slot " + (i + 1);
                
            }

            // Dropdown for run single sequence
            // Also update tab names
            RunSingleSequenceComboBox.Items.Clear();
            for (int i = 0; i < ConnectedMaestrosListView.Items.Count; i++)
            {
                if (ConnectedMaestrosListView.Items[i].SubItems.Count == 2)
                {
                    RunSingleSequenceComboBox.Items.Add(ConnectedMaestrosListView.Items[i].SubItems[1].Text);
                    RoutineTabControl.TabPages[i].Text = ConnectedMaestrosListView.Items[i].SubItems[1].Text;
                    RoutineTabControl.Controls[i].Enabled = true;
                }
                else
                {
                    RunSingleSequenceComboBox.Items.Add(ConnectedMaestrosListView.Items[i].SubItems[0].Text);
                    RoutineTabControl.TabPages[i].Text = ConnectedMaestrosListView.Items[i].SubItems[0].Text;
                    RoutineTabControl.Controls[i].Enabled = true;
                }
            }
            RunSingleSequenceComboBox.Text = "";
        }

        private void Run_Full_Show(object sender, EventArgs e)
        {
            
            // Button is in Run Full SHow state
            if (RunFullShowButton.Text == "Run Full Show")
            {
                // Change button text/color and change page enabled's appropriatly
                RunFullShowButton.Text = "STOP SHOW";
                RunFullShowButton.BackColor = System.Drawing.Color.Red;
                groupBox1.Enabled = false;
                RenameSelectedMaestroButton.Enabled = false;
                ConnectedMaestrosListView.Enabled = false;
                RoutineTabControl.Enabled = false;

                // If VideoWindow is open and ready, play video from the start
                if (VideoWindow.Visible == true && VideoPage.VideoPageInstance.axWindowsMediaPlayer1.currentMedia != null)
                {
                    VideoPage.VideoPageInstance.axWindowsMediaPlayer1.Ctlcontrols.currentPosition = 0;
                    VideoPage.VideoPageInstance.axWindowsMediaPlayer1.Ctlcontrols.play();
                }
            }
            
            // If button is in STOP SHOW state
            else if (RunFullShowButton.Text == "STOP SHOW")
            {
                // Change button text/color and change page enabled's appropriatly
                RunFullShowButton.Text = "Run Full Show";
                RunFullShowButton.BackColor = System.Drawing.Color.FromArgb(0, 255, 255, 255);
                groupBox1.Enabled = true;
                RenameSelectedMaestroButton.Enabled = true;
                ConnectedMaestrosListView.Enabled = true;
                RoutineTabControl.Enabled = true;

                // If VideoWindow is open & ready, pause the video
                if (VideoWindow.Visible == true && VideoPage.VideoPageInstance.axWindowsMediaPlayer1.currentMedia != null)
                {
                    VideoPage.VideoPageInstance.axWindowsMediaPlayer1.Ctlcontrols.pause();
                }
            }

            // Activate the RunRoutine function for all 10 droid pains
            if (ConnectedMaestrosListView.Items.Count >= 1 && routineBuilderGroup1.RoutineListView.Items.Count != 0)
            {
                routineBuilderGroup1.RunRoutineButton_Click(new object(), new EventArgs());
            }
            if (ConnectedMaestrosListView.Items.Count >= 2 && routineBuilderGroup2.RoutineListView.Items.Count != 0)
            {
                routineBuilderGroup2.RunRoutineButton_Click(new object(), new EventArgs());
            }
            if (ConnectedMaestrosListView.Items.Count >= 3 && routineBuilderGroup3.RoutineListView.Items.Count != 0)
            {
                routineBuilderGroup3.RunRoutineButton_Click(new object(), new EventArgs());
            }
            if (ConnectedMaestrosListView.Items.Count >= 4 && routineBuilderGroup4.RoutineListView.Items.Count != 0)
            {
                routineBuilderGroup4.RunRoutineButton_Click(new object(), new EventArgs());
            }
            if (ConnectedMaestrosListView.Items.Count >= 5 && routineBuilderGroup5.RoutineListView.Items.Count != 0)
            {
                routineBuilderGroup5.RunRoutineButton_Click(new object(), new EventArgs());
            }
            if (ConnectedMaestrosListView.Items.Count >= 6 && routineBuilderGroup6.RoutineListView.Items.Count != 0)
            {
                routineBuilderGroup6.RunRoutineButton_Click(new object(), new EventArgs());
            }
            if (ConnectedMaestrosListView.Items.Count >= 7 && routineBuilderGroup7.RoutineListView.Items.Count != 0)
            {
                routineBuilderGroup7.RunRoutineButton_Click(new object(), new EventArgs());
            }
            if (ConnectedMaestrosListView.Items.Count >= 8 && routineBuilderGroup8.RoutineListView.Items.Count != 0)
            {
                routineBuilderGroup8.RunRoutineButton_Click(new object(), new EventArgs());
            }
            if (ConnectedMaestrosListView.Items.Count >= 9 && routineBuilderGroup9.RoutineListView.Items.Count != 0)
            {
                routineBuilderGroup9.RunRoutineButton_Click(new object(), new EventArgs());
            }
            if (ConnectedMaestrosListView.Items.Count >= 10 && routineBuilderGroup10.RoutineListView.Items.Count != 0)
            {
                routineBuilderGroup10.RunRoutineButton_Click(new object(), new EventArgs());
            }
        }
         
        private void RunSingleSequenceButton_Click(object sender, EventArgs e)
        {
            var device_list = Usc.getConnectedDevices();
            string device = "";
            

            // If Sequence was activated, it must be stopped
            if (RunSingleSequenceButton.Text == "Stop")
            {
                if (player != null)
                {
                    player.Stop();
                }
                if (usc != null)
                {
                    usc.reinitialize();
                    usc.Dispose();  // Disconnect
                }
                
                RunSingleSequenceButton.Text = "Run Single Sequence";
                RunSingleSequenceButton.BackColor = System.Drawing.Color.FromArgb(0,255,255,255);
                RoutineTabControl.Enabled = true;
                RenameSelectedMaestroButton.Enabled = true;
                ConnectedMaestrosListView.Enabled = true;
                RunFullShowButton.Enabled = true;
                RunSingleSequenceComboBox.Enabled = true;
                RunSingleSequenceNumeric.Enabled = true;
                RunSingleSequenceBrowseButton.Enabled = true;

            }
            else
            {
                // Only run if a Maestro has been selected or if Audio file is available
                if (RunSingleSequenceComboBox.SelectedItem != null)
                {
                    // First Get the maestro number we are using
                    // If combobox has maestro number
                    if (RunSingleSequenceComboBox.SelectedItem.ToString().All(Char.IsDigit) && RunSingleSequenceComboBox.Text.Length == 8)
                    {
                        device = RunSingleSequenceComboBox.SelectedItem.ToString();
                    }
                    // Else ComboBox has a set droid name
                    else
                    {
                        for (int i = 0; i < device_list.Count; i++)
                        {
                            if (ConnectedMaestrosListView.Items[i].SubItems.Count == 2)
                            {
                                if (RunSingleSequenceComboBox.SelectedItem.ToString() == ConnectedMaestrosListView.Items[i].SubItems[1].Text)
                                {
                                    device = ConnectedMaestrosListView.Items[i].SubItems[0].Text;
                                }
                            }
                        }
                    }

                    // Then get the sequence number we want to run
                    byte sequence = Convert.ToByte(RunSingleSequenceNumeric.Value);

                    
                    try
                    {
                        // Finally set Maestro to run sequence
                        foreach (DeviceListItem d in Usc.getConnectedDevices())
                        {
                            if (d.serialNumber == device)
                            {
                                usc = new Usc(d);
                                usc.restartScriptAtSubroutine(sequence);
                                usc.setScriptDone(0);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Disconnect Maestro from other software!\n(Probably Pololu Maestro Control Center)", "Maestro Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    
                    

                    // Finally, change button to STOP button
                    RunSingleSequenceButton.Text = "Stop";
                    RunSingleSequenceButton.BackColor = System.Drawing.Color.Red;
                    RoutineTabControl.Enabled = false;
                    RenameSelectedMaestroButton.Enabled = false;
                    ConnectedMaestrosListView.Enabled = false;
                    RunFullShowButton.Enabled = false;
                    RunSingleSequenceComboBox.Enabled = false;
                    RunSingleSequenceNumeric.Enabled = false;
                    RunSingleSequenceBrowseButton.Enabled = false;
                }
                // If there is an audio file, play it
                if (RunSingleRoutineAudioTextBox.Text != "")
                {
                    player.Play();

                    // Finally, change button to STOP button
                    RunSingleSequenceButton.Text = "Stop";
                    RunSingleSequenceButton.BackColor = System.Drawing.Color.Red;
                    RoutineTabControl.Enabled = false;
                    RenameSelectedMaestroButton.Enabled = false;
                    ConnectedMaestrosListView.Enabled = false;
                    RunFullShowButton.Enabled = false;
                    RunSingleSequenceComboBox.Enabled = false;
                    RunSingleSequenceNumeric.Enabled = false;
                    RunSingleSequenceBrowseButton.Enabled = false;
                }

                
            }
        }

        private void RenameSelectedMaestroButton_Click(object sender, EventArgs e)
        {
            
            // Set the name of selected maestro from list
            if (ConnectedMaestrosListView.SelectedItems.Count == 1)
            {
                // Warn about changing tabs
                DialogResult dialogResult = MessageBox.Show("Renaming a Droid reorders and resets all Routine tabs!\nDo you wish to continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.Yes)
                {
                    string Content = Interaction.InputBox("Name of Droid:", "Droid Name", "");

                    if (Content != "" && Content != null)
                    {
                        int Index = ConnectedMaestrosListView.Items.IndexOf(ConnectedMaestrosListView.SelectedItems[0]);
                        string[] row = { ConnectedMaestrosListView.Items[Index].Text, Content };
                        var ListViewItem = new ListViewItem(row);
                        ConnectedMaestrosListView.Items[Index].Remove();
                        ConnectedMaestrosListView.Items.Add(ListViewItem);

                        TabReset();

                        // Then Update Dropdown
                        Check_Droid_Names();

                        
                            
                        // Finally check if Droid name and Maestro pair exists in Droid Data
                        string strExeFilePath = System.Reflection.Assembly.GetExecutingAssembly().Location;
                        strExeFilePath = strExeFilePath.Substring(0, strExeFilePath.Length - 22);
                        

                        StreamReader sr = new StreamReader(strExeFilePath + '\\' + "Droid_List.txt");
                        StreamWriter sw = new StreamWriter(strExeFilePath + '\\' + "TempFile.txt");

                        string Line = sr.ReadLine();
                        string MaestroNumber = null;
                        string DroidName = null;
                        bool replaced = false;


                        while (Line != null)
                        {
                            MaestroNumber = Line.Substring(0, 8);

                            DroidName = Line.Substring(9, Line.Length - 9);

                            if (ConnectedMaestrosListView.Items[ConnectedMaestrosListView.Items.Count - 1].Text != MaestroNumber)
                            {
                                sw.WriteLine(Line);
                            }
                            else
                            {
                                sw.WriteLine(ConnectedMaestrosListView.Items[ConnectedMaestrosListView.Items.Count-1].SubItems[0].Text + " " + ConnectedMaestrosListView.Items[ConnectedMaestrosListView.Items.Count-1].SubItems[1].Text);
                                replaced = true;
                            }
                            
                            
                            Line = sr.ReadLine();
                        }

                        if (replaced == false)
                        {
                            sw.WriteLine(ConnectedMaestrosListView.Items[ConnectedMaestrosListView.Items.Count-1].SubItems[0].Text + " " + ConnectedMaestrosListView.Items[ConnectedMaestrosListView.Items.Count-1].SubItems[1].Text);
                        }

                        sr.Close();
                        sw.Close();

                        File.Delete(strExeFilePath + '\\' + "Droid_List.txt");
                        File.Move(strExeFilePath + '\\' + "TempFile.txt", strExeFilePath + '\\' + "Droid_List.txt");
                        File.Delete(strExeFilePath + '\\' + "TempFile.txt");
                    }
                }

                
            }
            else
            {
                MessageBox.Show("Select a Maestro to Rename", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

        private void RunSingleRoutineBrowseButton_Click(object sender, EventArgs e)
        {
            RunSingleRoutineAudioTextBox.Text = "";

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
                    RunSingleRoutineAudioTextBox.Text = ofd.FileName;
                    player = new System.Media.SoundPlayer(RunSingleRoutineAudioTextBox.Text);
                }
                else
                {
                    MessageBox.Show("Not a .wav file type!", "Input Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void TabReset()
        {
            // Clear All Tabs
            routineBuilderGroup1.RoutineListView.Items.Clear();
            routineBuilderGroup2.RoutineListView.Items.Clear();
            routineBuilderGroup3.RoutineListView.Items.Clear();
            routineBuilderGroup4.RoutineListView.Items.Clear();
            routineBuilderGroup5.RoutineListView.Items.Clear();
            routineBuilderGroup6.RoutineListView.Items.Clear();
            routineBuilderGroup7.RoutineListView.Items.Clear();
            routineBuilderGroup8.RoutineListView.Items.Clear();
            routineBuilderGroup9.RoutineListView.Items.Clear();
            routineBuilderGroup10.RoutineListView.Items.Clear();

            // Disable All Tabs
            foreach (Control ctl in RoutineTabControl.Controls)
            {
                ctl.Enabled = false;
            }
        }

        private void OpenVideoWindowButton_Click(object sender, EventArgs e)
        {
            if (VideoWindow.IsDisposed)
            {
                VideoWindow = new VideoPage();
            }
            else
            {
                VideoWindow.Show();
            }
        }

        private void SaveCurrentShowButton_Click(object sender, EventArgs e)
        {
            //Create a SAVE file browser
            SaveFileDialog sfd = new SaveFileDialog();
            // In the correct Initial directory
            string InitialDirectory = System.Reflection.Assembly.GetExecutingAssembly().Location;
            InitialDirectory = InitialDirectory.Substring(0, InitialDirectory.Length - 81);
            InitialDirectory = InitialDirectory + "Shows";
            sfd.InitialDirectory = InitialDirectory;
            // Then title and show the file browser
            sfd.Title = "Save Show";
            sfd.Filter = "Text Files (*.txt)|*.txt";
            sfd.DefaultExt = "txt";
            sfd.AddExtension = true;

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (var tw = new StreamWriter(sfd.FileName))
                {
                    // Activate the RunRoutine function for all 10 droid pains
                    if (ConnectedMaestrosListView.Items.Count >= 1 && routineBuilderGroup1.RoutineListView.Items.Count != 0)
                    {
                        tw.Write(routineBuilderGroup1.MaestroName + ";");
                        tw.Write(routineBuilderGroup1.MaestroID + ";");
                        if(routineBuilderGroup1.LoadedRoutineTextBox.Text == "*new routine*")
                        {
                            routineBuilderGroup1.SaveCurrentRoutineButton_Click(null,null);
                        }
                        tw.WriteLine(routineBuilderGroup1.LoadedRoutineTextBox.Text);
                    }
                    if (ConnectedMaestrosListView.Items.Count >= 2 && routineBuilderGroup2.RoutineListView.Items.Count != 0)
                    {
                        tw.Write(routineBuilderGroup2.MaestroName + ";");
                        tw.Write(routineBuilderGroup2.MaestroID + ";");
                        if (routineBuilderGroup2.LoadedRoutineTextBox.Text == "*new routine*")
                        {
                            routineBuilderGroup2.SaveCurrentRoutineButton_Click(null, null);
                        }
                        tw.WriteLine(routineBuilderGroup2.LoadedRoutineTextBox.Text);
                    }
                    if (ConnectedMaestrosListView.Items.Count >= 3 && routineBuilderGroup3.RoutineListView.Items.Count != 0)
                    {
                        tw.Write(routineBuilderGroup3.MaestroName + ";");
                        tw.Write(routineBuilderGroup3.MaestroID + ";");
                        if (routineBuilderGroup3.LoadedRoutineTextBox.Text == "*new routine*")
                        {
                            routineBuilderGroup3.SaveCurrentRoutineButton_Click(null, null);
                        }
                        tw.WriteLine(routineBuilderGroup3.LoadedRoutineTextBox.Text);
                    }
                    if (ConnectedMaestrosListView.Items.Count >= 4 && routineBuilderGroup4.RoutineListView.Items.Count != 0)
                    {
                        tw.Write(routineBuilderGroup4.MaestroName + ";");
                        tw.Write(routineBuilderGroup4.MaestroID + ";");
                        if (routineBuilderGroup4.LoadedRoutineTextBox.Text == "*new routine*")
                        {
                            routineBuilderGroup4.SaveCurrentRoutineButton_Click(null, null);
                        }
                        tw.WriteLine(routineBuilderGroup4.LoadedRoutineTextBox.Text);
                    }
                    if (ConnectedMaestrosListView.Items.Count >= 5 && routineBuilderGroup5.RoutineListView.Items.Count != 0)
                    {
                        tw.Write(routineBuilderGroup5.MaestroName + ";");
                        tw.Write(routineBuilderGroup5.MaestroID + ";");
                        if (routineBuilderGroup5.LoadedRoutineTextBox.Text == "*new routine*")
                        {
                            routineBuilderGroup5.SaveCurrentRoutineButton_Click(null, null);
                        }
                        tw.WriteLine(routineBuilderGroup5.LoadedRoutineTextBox.Text);
                    }
                    if (ConnectedMaestrosListView.Items.Count >= 6 && routineBuilderGroup6.RoutineListView.Items.Count != 0)
                    {
                        tw.Write(routineBuilderGroup6.MaestroName + ";");
                        tw.Write(routineBuilderGroup6.MaestroID + ";");
                        if (routineBuilderGroup6.LoadedRoutineTextBox.Text == "*new routine*")
                        {
                            routineBuilderGroup6.SaveCurrentRoutineButton_Click(null, null);
                        }
                        tw.WriteLine(routineBuilderGroup6.LoadedRoutineTextBox.Text);
                    }
                    if (ConnectedMaestrosListView.Items.Count >= 7 && routineBuilderGroup7.RoutineListView.Items.Count != 0)
                    {
                        tw.Write(routineBuilderGroup7.MaestroName + ";");
                        tw.Write(routineBuilderGroup7.MaestroID + ";");
                        if (routineBuilderGroup7.LoadedRoutineTextBox.Text == "*new routine*")
                        {
                            routineBuilderGroup7.SaveCurrentRoutineButton_Click(null, null);
                        }
                        tw.WriteLine(routineBuilderGroup7.LoadedRoutineTextBox.Text);
                    }
                    if (ConnectedMaestrosListView.Items.Count >= 8 && routineBuilderGroup8.RoutineListView.Items.Count != 0)
                    {
                        tw.Write(routineBuilderGroup8.MaestroName + ";");
                        tw.Write(routineBuilderGroup8.MaestroID + ";");
                        if (routineBuilderGroup8.LoadedRoutineTextBox.Text == "*new routine*")
                        {
                            routineBuilderGroup8.SaveCurrentRoutineButton_Click(null, null);
                        }
                        tw.WriteLine(routineBuilderGroup8.LoadedRoutineTextBox.Text);
                    }
                    if (ConnectedMaestrosListView.Items.Count >= 9 && routineBuilderGroup9.RoutineListView.Items.Count != 0)
                    {
                        tw.Write(routineBuilderGroup9.MaestroName + ";");
                        tw.Write(routineBuilderGroup9.MaestroID + ";");
                        if (routineBuilderGroup9.LoadedRoutineTextBox.Text == "*new routine*")
                        {
                            routineBuilderGroup9.SaveCurrentRoutineButton_Click(null, null);
                        }
                        tw.WriteLine(routineBuilderGroup9.LoadedRoutineTextBox.Text);
                    }
                    if (ConnectedMaestrosListView.Items.Count >= 10 && routineBuilderGroup10.RoutineListView.Items.Count != 0)
                    {
                        tw.Write(routineBuilderGroup10.MaestroName + ";");
                        tw.Write(routineBuilderGroup10.MaestroID + ";");
                        if (routineBuilderGroup10.LoadedRoutineTextBox.Text == "*new routine*")
                        {
                            routineBuilderGroup10.SaveCurrentRoutineButton_Click(null, null);
                        }
                        tw.WriteLine(routineBuilderGroup10.LoadedRoutineTextBox.Text);
                    }
                }        
            }
        }

        private void LoadShowButton_Click(object sender, EventArgs e)
        {
            // Open a File browser
            OpenFileDialog ofd = new OpenFileDialog();
            // In the correct Initial directory
            string InitialDirectory = System.Reflection.Assembly.GetExecutingAssembly().Location;
            InitialDirectory = InitialDirectory.Substring(0, InitialDirectory.Length - 81);
            InitialDirectory = InitialDirectory + "Shows";
            ofd.InitialDirectory = InitialDirectory;
            // Then title and show the file browser
            ofd.Title = "Load Show";
            ofd.Filter = "Text Files (*.txt)|*.txt";
            ofd.ShowDialog();

            // Check if File was selected
            if (ofd.FileName != "")
            {
                // Create file reader
                StreamReader sr = new StreamReader(ofd.FileName);

                // Read Each Line
                string Line = sr.ReadLine();
                while (Line != null)
                {
                    // Extract name, ID, and routine name data from line
                    string[] data = Line.Split(';');
                    string M_name = data[0];
                    string M_ID = data[1];
                    string RoutineName = data[2];

                    if (routineBuilderGroup1.MaestroID.Equals(M_ID) && routineBuilderGroup1.MaestroName.Equals(M_name))
                    {
                        routineBuilderGroup1.LoadRoutineFromShow(RoutineName);
                    }
                    if (routineBuilderGroup2.MaestroID.Equals(M_ID) && routineBuilderGroup2.MaestroName.Equals(M_name))
                    {
                        routineBuilderGroup2.LoadRoutineFromShow(RoutineName);
                    }
                    if (routineBuilderGroup3.MaestroID.Equals(M_ID) && routineBuilderGroup3.MaestroName.Equals(M_name))
                    {
                        routineBuilderGroup3.LoadRoutineFromShow(RoutineName);
                    }
                    if (routineBuilderGroup4.MaestroID.Equals(M_ID) && routineBuilderGroup4.MaestroName.Equals(M_name))
                    {
                        routineBuilderGroup4.LoadRoutineFromShow(RoutineName);
                    }
                    if (routineBuilderGroup5.MaestroID.Equals(M_ID) && routineBuilderGroup5.MaestroName.Equals(M_name))
                    {
                        routineBuilderGroup5.LoadRoutineFromShow(RoutineName);
                    }
                    if (routineBuilderGroup6.MaestroID.Equals(M_ID) && routineBuilderGroup6.MaestroName.Equals(M_name))
                    {
                        routineBuilderGroup6.LoadRoutineFromShow(RoutineName);
                    }
                    if (routineBuilderGroup7.MaestroID.Equals(M_ID) && routineBuilderGroup7.MaestroName.Equals(M_name))
                    {
                        routineBuilderGroup7.LoadRoutineFromShow(RoutineName);
                    }
                    if (routineBuilderGroup8.MaestroID.Equals(M_ID) && routineBuilderGroup8.MaestroName.Equals(M_name))
                    {
                        routineBuilderGroup8.LoadRoutineFromShow(RoutineName);
                    }
                    if (routineBuilderGroup9.MaestroID.Equals(M_ID) && routineBuilderGroup9.MaestroName.Equals(M_name))
                    {
                        routineBuilderGroup9.LoadRoutineFromShow(RoutineName);
                    }
                    if (routineBuilderGroup10.MaestroID.Equals(M_ID) && routineBuilderGroup10.MaestroName.Equals(M_name))
                    {
                        routineBuilderGroup10.LoadRoutineFromShow(RoutineName);
                    }

                    // read the next line
                    Line = sr.ReadLine();
                }

            }
        }
    }
}
