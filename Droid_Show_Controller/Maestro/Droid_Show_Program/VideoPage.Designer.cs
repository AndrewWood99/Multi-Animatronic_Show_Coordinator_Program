namespace Droid_Show_Program
{
    partial class VideoPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VideoPage));
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.LoadVideoButton = new System.Windows.Forms.Button();
            this.FullScreenButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(12, 12);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(416, 239);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            // 
            // LoadVideoButton
            // 
            this.LoadVideoButton.Location = new System.Drawing.Point(12, 257);
            this.LoadVideoButton.Name = "LoadVideoButton";
            this.LoadVideoButton.Size = new System.Drawing.Size(189, 40);
            this.LoadVideoButton.TabIndex = 1;
            this.LoadVideoButton.Text = "Load Video";
            this.LoadVideoButton.UseVisualStyleBackColor = true;
            this.LoadVideoButton.Click += new System.EventHandler(this.LoadVideoButton_Click);
            // 
            // FullScreenButton
            // 
            this.FullScreenButton.Enabled = false;
            this.FullScreenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FullScreenButton.Location = new System.Drawing.Point(207, 257);
            this.FullScreenButton.Name = "FullScreenButton";
            this.FullScreenButton.Size = new System.Drawing.Size(221, 40);
            this.FullScreenButton.TabIndex = 2;
            this.FullScreenButton.Text = "Full Screen";
            this.FullScreenButton.UseVisualStyleBackColor = true;
            this.FullScreenButton.Click += new System.EventHandler(this.FullScreenButton_Click);
            // 
            // VideoPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 309);
            this.Controls.Add(this.FullScreenButton);
            this.Controls.Add(this.LoadVideoButton);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Name = "VideoPage";
            this.Text = "Video Window";
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button LoadVideoButton;
        private System.Windows.Forms.Button FullScreenButton;
        public AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}