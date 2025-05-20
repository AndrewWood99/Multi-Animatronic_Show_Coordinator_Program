using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Droid_Show_Program
{
    public partial class VideoPage : Form
    {
        public static VideoPage VideoPageInstance;

        public VideoPage()
        {
            InitializeComponent();

            VideoPageInstance = this;
        }

        private void LoadVideoButton_Click(object sender, EventArgs e)
        {
            // Open a File browser
            OpenFileDialog ofd = new OpenFileDialog();
            // In the correct Initial directory
            string InitialDirectory = System.Reflection.Assembly.GetExecutingAssembly().Location;
            InitialDirectory = InitialDirectory.Substring(0, InitialDirectory.Length - 81);
            InitialDirectory = InitialDirectory + "Video_Files";
            ofd.InitialDirectory = InitialDirectory;
            // Then title and show the file browser
            ofd.Title = "Load Video File";
            ofd.ShowDialog();

            // Check if File was selected, and id file is an MP4
            if (ofd.FileName != "")
            {
                string fileExt = System.IO.Path.GetExtension(ofd.FileName);

                // If Correct File Type
                if (fileExt == ".mp4")
                {
                    // Load the file to the player
                    string f = ofd.FileName;
                    axWindowsMediaPlayer1.URL = f;

                    // Enable the Fullscreen Button
                    FullScreenButton.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Not a .mp4 file type!", "Input Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void FullScreenButton_Click(object sender, EventArgs e)
        {
            try
            {
                axWindowsMediaPlayer1.fullScreen = true;
            }
            catch
            {
                MessageBox.Show("No Video Loaded!", "Process Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
