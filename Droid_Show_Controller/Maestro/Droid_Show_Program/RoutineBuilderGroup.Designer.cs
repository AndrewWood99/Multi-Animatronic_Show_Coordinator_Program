namespace Droid_Show_Program
{
    partial class RoutineBuilderGroup
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.LoadRoutineButton = new System.Windows.Forms.Button();
            this.LoadedRoutineTextBox = new System.Windows.Forms.TextBox();
            this.OpenRoutineFile = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.AddSequenceGroupBox = new System.Windows.Forms.GroupBox();
            this.AddSequenceButton = new System.Windows.Forms.Button();
            this.BrowseAudioFileButton = new System.Windows.Forms.Button();
            this.SetNoSeqCheckBox = new System.Windows.Forms.CheckBox();
            this.SetAudioFileTextBox = new System.Windows.Forms.TextBox();
            this.SetSequenceNumeric = new System.Windows.Forms.NumericUpDown();
            this.SetTimeStartNumeric = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RoutineListView = new System.Windows.Forms.ListView();
            this.TimeStart = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SequenceNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PlayAudioFile = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RunRoutineButton = new System.Windows.Forms.Button();
            this.DeleteSelectedSequenceButton = new System.Windows.Forms.Button();
            this.SaveCurrentRoutineButton = new System.Windows.Forms.Button();
            this.RunTimer = new System.Windows.Forms.Timer(this.components);
            this.LoopCheckBox = new System.Windows.Forms.CheckBox();
            this.AddSequenceGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SetSequenceNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SetTimeStartNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // LoadRoutineButton
            // 
            this.LoadRoutineButton.Location = new System.Drawing.Point(3, 3);
            this.LoadRoutineButton.Name = "LoadRoutineButton";
            this.LoadRoutineButton.Size = new System.Drawing.Size(94, 23);
            this.LoadRoutineButton.TabIndex = 0;
            this.LoadRoutineButton.Text = "Load Routine";
            this.LoadRoutineButton.UseVisualStyleBackColor = true;
            this.LoadRoutineButton.Click += new System.EventHandler(this.LoadRoutineButton_Click);
            // 
            // LoadedRoutineTextBox
            // 
            this.LoadedRoutineTextBox.Location = new System.Drawing.Point(195, 5);
            this.LoadedRoutineTextBox.Name = "LoadedRoutineTextBox";
            this.LoadedRoutineTextBox.ReadOnly = true;
            this.LoadedRoutineTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LoadedRoutineTextBox.Size = new System.Drawing.Size(346, 20);
            this.LoadedRoutineTextBox.TabIndex = 2;
            // 
            // OpenRoutineFile
            // 
            this.OpenRoutineFile.FileName = "OpenRoutineFile";
            this.OpenRoutineFile.Title = "Open Routine File";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Loaded Routine:";
            // 
            // AddSequenceGroupBox
            // 
            this.AddSequenceGroupBox.Controls.Add(this.AddSequenceButton);
            this.AddSequenceGroupBox.Controls.Add(this.BrowseAudioFileButton);
            this.AddSequenceGroupBox.Controls.Add(this.SetNoSeqCheckBox);
            this.AddSequenceGroupBox.Controls.Add(this.SetAudioFileTextBox);
            this.AddSequenceGroupBox.Controls.Add(this.SetSequenceNumeric);
            this.AddSequenceGroupBox.Controls.Add(this.SetTimeStartNumeric);
            this.AddSequenceGroupBox.Controls.Add(this.label4);
            this.AddSequenceGroupBox.Controls.Add(this.label3);
            this.AddSequenceGroupBox.Controls.Add(this.label2);
            this.AddSequenceGroupBox.Location = new System.Drawing.Point(3, 32);
            this.AddSequenceGroupBox.Name = "AddSequenceGroupBox";
            this.AddSequenceGroupBox.Size = new System.Drawing.Size(538, 62);
            this.AddSequenceGroupBox.TabIndex = 4;
            this.AddSequenceGroupBox.TabStop = false;
            this.AddSequenceGroupBox.Text = "Add Sequence";
            // 
            // AddSequenceButton
            // 
            this.AddSequenceButton.Location = new System.Drawing.Point(490, 16);
            this.AddSequenceButton.Name = "AddSequenceButton";
            this.AddSequenceButton.Size = new System.Drawing.Size(42, 37);
            this.AddSequenceButton.TabIndex = 8;
            this.AddSequenceButton.Text = "ADD";
            this.AddSequenceButton.UseVisualStyleBackColor = true;
            this.AddSequenceButton.Click += new System.EventHandler(this.AddSequenceButton_Click);
            // 
            // BrowseAudioFileButton
            // 
            this.BrowseAudioFileButton.Location = new System.Drawing.Point(433, 30);
            this.BrowseAudioFileButton.Name = "BrowseAudioFileButton";
            this.BrowseAudioFileButton.Size = new System.Drawing.Size(51, 23);
            this.BrowseAudioFileButton.TabIndex = 7;
            this.BrowseAudioFileButton.Text = "Browse";
            this.BrowseAudioFileButton.UseVisualStyleBackColor = true;
            this.BrowseAudioFileButton.Click += new System.EventHandler(this.BrowseAudioFileButton_Click);
            // 
            // SetNoSeqCheckBox
            // 
            this.SetNoSeqCheckBox.AutoSize = true;
            this.SetNoSeqCheckBox.Location = new System.Drawing.Point(140, 33);
            this.SetNoSeqCheckBox.Name = "SetNoSeqCheckBox";
            this.SetNoSeqCheckBox.Size = new System.Drawing.Size(68, 17);
            this.SetNoSeqCheckBox.TabIndex = 6;
            this.SetNoSeqCheckBox.Text = "No Seq?";
            this.SetNoSeqCheckBox.UseVisualStyleBackColor = true;
            this.SetNoSeqCheckBox.CheckedChanged += new System.EventHandler(this.SetNoSeqCheckBox_CheckedChanged);
            // 
            // SetAudioFileTextBox
            // 
            this.SetAudioFileTextBox.Location = new System.Drawing.Point(214, 32);
            this.SetAudioFileTextBox.Name = "SetAudioFileTextBox";
            this.SetAudioFileTextBox.ReadOnly = true;
            this.SetAudioFileTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SetAudioFileTextBox.Size = new System.Drawing.Size(213, 20);
            this.SetAudioFileTextBox.TabIndex = 5;
            // 
            // SetSequenceNumeric
            // 
            this.SetSequenceNumeric.Location = new System.Drawing.Point(97, 32);
            this.SetSequenceNumeric.Name = "SetSequenceNumeric";
            this.SetSequenceNumeric.Size = new System.Drawing.Size(37, 20);
            this.SetSequenceNumeric.TabIndex = 4;
            // 
            // SetTimeStartNumeric
            // 
            this.SetTimeStartNumeric.DecimalPlaces = 1;
            this.SetTimeStartNumeric.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.SetTimeStartNumeric.Location = new System.Drawing.Point(9, 32);
            this.SetTimeStartNumeric.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.SetTimeStartNumeric.Name = "SetTimeStartNumeric";
            this.SetTimeStartNumeric.Size = new System.Drawing.Size(82, 20);
            this.SetTimeStartNumeric.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(211, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Play Audio File";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Seq #";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Time Start (sec)";
            // 
            // RoutineListView
            // 
            this.RoutineListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TimeStart,
            this.SequenceNum,
            this.PlayAudioFile});
            this.RoutineListView.FullRowSelect = true;
            this.RoutineListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.RoutineListView.HideSelection = false;
            this.RoutineListView.LabelWrap = false;
            this.RoutineListView.Location = new System.Drawing.Point(3, 100);
            this.RoutineListView.MultiSelect = false;
            this.RoutineListView.Name = "RoutineListView";
            this.RoutineListView.Size = new System.Drawing.Size(538, 200);
            this.RoutineListView.TabIndex = 5;
            this.RoutineListView.UseCompatibleStateImageBehavior = false;
            this.RoutineListView.View = System.Windows.Forms.View.Details;
            // 
            // TimeStart
            // 
            this.TimeStart.Text = "Time Start (sec)";
            this.TimeStart.Width = 94;
            // 
            // SequenceNum
            // 
            this.SequenceNum.Text = "Seq #";
            this.SequenceNum.Width = 44;
            // 
            // PlayAudioFile
            // 
            this.PlayAudioFile.Text = "Play Audio File";
            this.PlayAudioFile.Width = 370;
            // 
            // RunRoutineButton
            // 
            this.RunRoutineButton.Location = new System.Drawing.Point(3, 305);
            this.RunRoutineButton.Name = "RunRoutineButton";
            this.RunRoutineButton.Size = new System.Drawing.Size(150, 23);
            this.RunRoutineButton.TabIndex = 6;
            this.RunRoutineButton.Text = "Run Current Routine";
            this.RunRoutineButton.UseVisualStyleBackColor = true;
            this.RunRoutineButton.Click += new System.EventHandler(this.RunRoutineButton_Click);
            // 
            // DeleteSelectedSequenceButton
            // 
            this.DeleteSelectedSequenceButton.Location = new System.Drawing.Point(235, 305);
            this.DeleteSelectedSequenceButton.Name = "DeleteSelectedSequenceButton";
            this.DeleteSelectedSequenceButton.Size = new System.Drawing.Size(150, 23);
            this.DeleteSelectedSequenceButton.TabIndex = 7;
            this.DeleteSelectedSequenceButton.Text = "Delete Selected Sequence";
            this.DeleteSelectedSequenceButton.UseVisualStyleBackColor = true;
            this.DeleteSelectedSequenceButton.Click += new System.EventHandler(this.DeleteSelectedSequenceButton_Click);
            // 
            // SaveCurrentRoutineButton
            // 
            this.SaveCurrentRoutineButton.Location = new System.Drawing.Point(391, 305);
            this.SaveCurrentRoutineButton.Name = "SaveCurrentRoutineButton";
            this.SaveCurrentRoutineButton.Size = new System.Drawing.Size(150, 23);
            this.SaveCurrentRoutineButton.TabIndex = 8;
            this.SaveCurrentRoutineButton.Text = "Save Current Routine";
            this.SaveCurrentRoutineButton.UseVisualStyleBackColor = true;
            this.SaveCurrentRoutineButton.Click += new System.EventHandler(this.SaveCurrentRoutineButton_Click);
            // 
            // RunTimer
            // 
            this.RunTimer.Tick += new System.EventHandler(this.RunTimer_Tick);
            // 
            // LoopCheckBox
            // 
            this.LoopCheckBox.AutoSize = true;
            this.LoopCheckBox.Location = new System.Drawing.Point(161, 309);
            this.LoopCheckBox.Name = "LoopCheckBox";
            this.LoopCheckBox.Size = new System.Drawing.Size(50, 17);
            this.LoopCheckBox.TabIndex = 9;
            this.LoopCheckBox.Text = "Loop";
            this.LoopCheckBox.UseVisualStyleBackColor = true;
            // 
            // RoutineBuilderGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LoopCheckBox);
            this.Controls.Add(this.SaveCurrentRoutineButton);
            this.Controls.Add(this.DeleteSelectedSequenceButton);
            this.Controls.Add(this.RunRoutineButton);
            this.Controls.Add(this.RoutineListView);
            this.Controls.Add(this.AddSequenceGroupBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LoadedRoutineTextBox);
            this.Controls.Add(this.LoadRoutineButton);
            this.Name = "RoutineBuilderGroup";
            this.Size = new System.Drawing.Size(545, 331);
            this.AddSequenceGroupBox.ResumeLayout(false);
            this.AddSequenceGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SetSequenceNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SetTimeStartNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoadRoutineButton;
        private System.Windows.Forms.OpenFileDialog OpenRoutineFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox AddSequenceGroupBox;
        private System.Windows.Forms.NumericUpDown SetTimeStartNumeric;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SetAudioFileTextBox;
        private System.Windows.Forms.CheckBox SetNoSeqCheckBox;
        private System.Windows.Forms.Button AddSequenceButton;
        private System.Windows.Forms.Button BrowseAudioFileButton;
        private System.Windows.Forms.NumericUpDown SetSequenceNumeric;
        public System.Windows.Forms.ListView RoutineListView;
        private System.Windows.Forms.Button DeleteSelectedSequenceButton;
        public System.Windows.Forms.ColumnHeader TimeStart;
        public System.Windows.Forms.ColumnHeader SequenceNum;
        public System.Windows.Forms.ColumnHeader PlayAudioFile;
        private System.Windows.Forms.Button SaveCurrentRoutineButton;
        private System.Windows.Forms.Timer RunTimer;
        public System.Windows.Forms.Button RunRoutineButton;
        public System.Windows.Forms.TextBox LoadedRoutineTextBox;
        private System.Windows.Forms.CheckBox LoopCheckBox;
    }
}
