namespace Droid_Show_Program
{
    partial class FrontPage
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrontPage));
            this.Tick = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.RunSingleSequenceNumeric = new System.Windows.Forms.NumericUpDown();
            this.RoutineTabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.routineBuilderGroup1 = new Droid_Show_Program.RoutineBuilderGroup();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.routineBuilderGroup2 = new Droid_Show_Program.RoutineBuilderGroup();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.routineBuilderGroup3 = new Droid_Show_Program.RoutineBuilderGroup();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.routineBuilderGroup4 = new Droid_Show_Program.RoutineBuilderGroup();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.routineBuilderGroup5 = new Droid_Show_Program.RoutineBuilderGroup();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.routineBuilderGroup6 = new Droid_Show_Program.RoutineBuilderGroup();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.routineBuilderGroup7 = new Droid_Show_Program.RoutineBuilderGroup();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.routineBuilderGroup8 = new Droid_Show_Program.RoutineBuilderGroup();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.routineBuilderGroup9 = new Droid_Show_Program.RoutineBuilderGroup();
            this.tabPage10 = new System.Windows.Forms.TabPage();
            this.routineBuilderGroup10 = new Droid_Show_Program.RoutineBuilderGroup();
            this.RenameSelectedMaestroButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RunSingleSequenceBrowseButton = new System.Windows.Forms.Button();
            this.RunSingleRoutineAudioTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.RunSingleSequenceButton = new System.Windows.Forms.Button();
            this.RunSingleSequenceComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RunFullShowButton = new System.Windows.Forms.Button();
            this.ConnectedMaestrosListView = new System.Windows.Forms.ListView();
            this.MaestroID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DroidName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OpenVideoWindowButton = new System.Windows.Forms.Button();
            this.SaveCurrentShowButton = new System.Windows.Forms.Button();
            this.LoadShowButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.RunSingleSequenceNumeric)).BeginInit();
            this.RoutineTabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.tabPage8.SuspendLayout();
            this.tabPage9.SuspendLayout();
            this.tabPage10.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tick
            // 
            this.Tick.Enabled = true;
            this.Tick.Interval = 1000;
            this.Tick.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Connected Maestros:";
            // 
            // RunSingleSequenceNumeric
            // 
            this.RunSingleSequenceNumeric.Location = new System.Drawing.Point(172, 33);
            this.RunSingleSequenceNumeric.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.RunSingleSequenceNumeric.Name = "RunSingleSequenceNumeric";
            this.RunSingleSequenceNumeric.Size = new System.Drawing.Size(36, 20);
            this.RunSingleSequenceNumeric.TabIndex = 2;
            // 
            // RoutineTabControl
            // 
            this.RoutineTabControl.Controls.Add(this.tabPage1);
            this.RoutineTabControl.Controls.Add(this.tabPage2);
            this.RoutineTabControl.Controls.Add(this.tabPage3);
            this.RoutineTabControl.Controls.Add(this.tabPage4);
            this.RoutineTabControl.Controls.Add(this.tabPage5);
            this.RoutineTabControl.Controls.Add(this.tabPage6);
            this.RoutineTabControl.Controls.Add(this.tabPage7);
            this.RoutineTabControl.Controls.Add(this.tabPage8);
            this.RoutineTabControl.Controls.Add(this.tabPage9);
            this.RoutineTabControl.Controls.Add(this.tabPage10);
            this.RoutineTabControl.Location = new System.Drawing.Point(235, 12);
            this.RoutineTabControl.Name = "RoutineTabControl";
            this.RoutineTabControl.SelectedIndex = 0;
            this.RoutineTabControl.Size = new System.Drawing.Size(553, 359);
            this.RoutineTabControl.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.routineBuilderGroup1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(545, 333);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // routineBuilderGroup1
            // 
            this.routineBuilderGroup1.Location = new System.Drawing.Point(0, 0);
            this.routineBuilderGroup1.MaestroID = "";
            this.routineBuilderGroup1.MaestroName = "";
            this.routineBuilderGroup1.Name = "routineBuilderGroup1";
            this.routineBuilderGroup1.Size = new System.Drawing.Size(545, 331);
            this.routineBuilderGroup1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.routineBuilderGroup2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(545, 333);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // routineBuilderGroup2
            // 
            this.routineBuilderGroup2.Location = new System.Drawing.Point(0, 0);
            this.routineBuilderGroup2.MaestroID = "";
            this.routineBuilderGroup2.MaestroName = "";
            this.routineBuilderGroup2.Name = "routineBuilderGroup2";
            this.routineBuilderGroup2.Size = new System.Drawing.Size(545, 331);
            this.routineBuilderGroup2.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.routineBuilderGroup3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(545, 333);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // routineBuilderGroup3
            // 
            this.routineBuilderGroup3.Location = new System.Drawing.Point(0, 0);
            this.routineBuilderGroup3.MaestroID = "";
            this.routineBuilderGroup3.MaestroName = "";
            this.routineBuilderGroup3.Name = "routineBuilderGroup3";
            this.routineBuilderGroup3.Size = new System.Drawing.Size(545, 331);
            this.routineBuilderGroup3.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.routineBuilderGroup4);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(545, 333);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // routineBuilderGroup4
            // 
            this.routineBuilderGroup4.Location = new System.Drawing.Point(0, 0);
            this.routineBuilderGroup4.MaestroID = "";
            this.routineBuilderGroup4.MaestroName = "";
            this.routineBuilderGroup4.Name = "routineBuilderGroup4";
            this.routineBuilderGroup4.Size = new System.Drawing.Size(545, 331);
            this.routineBuilderGroup4.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.routineBuilderGroup5);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(545, 333);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "tabPage5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // routineBuilderGroup5
            // 
            this.routineBuilderGroup5.Location = new System.Drawing.Point(0, 0);
            this.routineBuilderGroup5.MaestroID = "";
            this.routineBuilderGroup5.MaestroName = "";
            this.routineBuilderGroup5.Name = "routineBuilderGroup5";
            this.routineBuilderGroup5.Size = new System.Drawing.Size(545, 331);
            this.routineBuilderGroup5.TabIndex = 0;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.routineBuilderGroup6);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(545, 333);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "tabPage6";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // routineBuilderGroup6
            // 
            this.routineBuilderGroup6.Location = new System.Drawing.Point(0, 0);
            this.routineBuilderGroup6.MaestroID = "";
            this.routineBuilderGroup6.MaestroName = "";
            this.routineBuilderGroup6.Name = "routineBuilderGroup6";
            this.routineBuilderGroup6.Size = new System.Drawing.Size(545, 331);
            this.routineBuilderGroup6.TabIndex = 0;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.routineBuilderGroup7);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(545, 333);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "tabPage7";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // routineBuilderGroup7
            // 
            this.routineBuilderGroup7.Location = new System.Drawing.Point(0, 0);
            this.routineBuilderGroup7.MaestroID = "";
            this.routineBuilderGroup7.MaestroName = "";
            this.routineBuilderGroup7.Name = "routineBuilderGroup7";
            this.routineBuilderGroup7.Size = new System.Drawing.Size(545, 331);
            this.routineBuilderGroup7.TabIndex = 0;
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.routineBuilderGroup8);
            this.tabPage8.Location = new System.Drawing.Point(4, 22);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(545, 333);
            this.tabPage8.TabIndex = 7;
            this.tabPage8.Text = "tabPage8";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // routineBuilderGroup8
            // 
            this.routineBuilderGroup8.Location = new System.Drawing.Point(0, 0);
            this.routineBuilderGroup8.MaestroID = "";
            this.routineBuilderGroup8.MaestroName = "";
            this.routineBuilderGroup8.Name = "routineBuilderGroup8";
            this.routineBuilderGroup8.Size = new System.Drawing.Size(545, 331);
            this.routineBuilderGroup8.TabIndex = 0;
            // 
            // tabPage9
            // 
            this.tabPage9.Controls.Add(this.routineBuilderGroup9);
            this.tabPage9.Location = new System.Drawing.Point(4, 22);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage9.Size = new System.Drawing.Size(545, 333);
            this.tabPage9.TabIndex = 8;
            this.tabPage9.Text = "tabPage9";
            this.tabPage9.UseVisualStyleBackColor = true;
            // 
            // routineBuilderGroup9
            // 
            this.routineBuilderGroup9.Location = new System.Drawing.Point(0, 0);
            this.routineBuilderGroup9.MaestroID = "";
            this.routineBuilderGroup9.MaestroName = "";
            this.routineBuilderGroup9.Name = "routineBuilderGroup9";
            this.routineBuilderGroup9.Size = new System.Drawing.Size(545, 331);
            this.routineBuilderGroup9.TabIndex = 0;
            // 
            // tabPage10
            // 
            this.tabPage10.Controls.Add(this.routineBuilderGroup10);
            this.tabPage10.Location = new System.Drawing.Point(4, 22);
            this.tabPage10.Name = "tabPage10";
            this.tabPage10.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage10.Size = new System.Drawing.Size(545, 333);
            this.tabPage10.TabIndex = 9;
            this.tabPage10.Text = "tabPage10";
            this.tabPage10.UseVisualStyleBackColor = true;
            // 
            // routineBuilderGroup10
            // 
            this.routineBuilderGroup10.Location = new System.Drawing.Point(0, 0);
            this.routineBuilderGroup10.MaestroID = "";
            this.routineBuilderGroup10.MaestroName = "";
            this.routineBuilderGroup10.Name = "routineBuilderGroup10";
            this.routineBuilderGroup10.Size = new System.Drawing.Size(545, 331);
            this.routineBuilderGroup10.TabIndex = 0;
            // 
            // RenameSelectedMaestroButton
            // 
            this.RenameSelectedMaestroButton.Location = new System.Drawing.Point(15, 139);
            this.RenameSelectedMaestroButton.Name = "RenameSelectedMaestroButton";
            this.RenameSelectedMaestroButton.Size = new System.Drawing.Size(214, 23);
            this.RenameSelectedMaestroButton.TabIndex = 4;
            this.RenameSelectedMaestroButton.Text = "Rename Selected Maestro";
            this.RenameSelectedMaestroButton.UseVisualStyleBackColor = true;
            this.RenameSelectedMaestroButton.Click += new System.EventHandler(this.RenameSelectedMaestroButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.RunSingleSequenceBrowseButton);
            this.groupBox1.Controls.Add(this.RunSingleRoutineAudioTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.RunSingleSequenceButton);
            this.groupBox1.Controls.Add(this.RunSingleSequenceComboBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.RunSingleSequenceNumeric);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(15, 171);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(214, 128);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Run Single Sequence";
            // 
            // RunSingleSequenceBrowseButton
            // 
            this.RunSingleSequenceBrowseButton.Location = new System.Drawing.Point(152, 70);
            this.RunSingleSequenceBrowseButton.Name = "RunSingleSequenceBrowseButton";
            this.RunSingleSequenceBrowseButton.Size = new System.Drawing.Size(56, 23);
            this.RunSingleSequenceBrowseButton.TabIndex = 9;
            this.RunSingleSequenceBrowseButton.Text = "Browse";
            this.RunSingleSequenceBrowseButton.UseVisualStyleBackColor = true;
            this.RunSingleSequenceBrowseButton.Click += new System.EventHandler(this.RunSingleRoutineBrowseButton_Click);
            // 
            // RunSingleRoutineAudioTextBox
            // 
            this.RunSingleRoutineAudioTextBox.Location = new System.Drawing.Point(6, 72);
            this.RunSingleRoutineAudioTextBox.Name = "RunSingleRoutineAudioTextBox";
            this.RunSingleRoutineAudioTextBox.ReadOnly = true;
            this.RunSingleRoutineAudioTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RunSingleRoutineAudioTextBox.Size = new System.Drawing.Size(140, 20);
            this.RunSingleRoutineAudioTextBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Play Audio File:";
            // 
            // RunSingleSequenceButton
            // 
            this.RunSingleSequenceButton.Location = new System.Drawing.Point(6, 96);
            this.RunSingleSequenceButton.Name = "RunSingleSequenceButton";
            this.RunSingleSequenceButton.Size = new System.Drawing.Size(202, 23);
            this.RunSingleSequenceButton.TabIndex = 6;
            this.RunSingleSequenceButton.Text = "Run Single Sequence";
            this.RunSingleSequenceButton.UseVisualStyleBackColor = true;
            this.RunSingleSequenceButton.Click += new System.EventHandler(this.RunSingleSequenceButton_Click);
            // 
            // RunSingleSequenceComboBox
            // 
            this.RunSingleSequenceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RunSingleSequenceComboBox.FormattingEnabled = true;
            this.RunSingleSequenceComboBox.Location = new System.Drawing.Point(6, 32);
            this.RunSingleSequenceComboBox.Name = "RunSingleSequenceComboBox";
            this.RunSingleSequenceComboBox.Size = new System.Drawing.Size(160, 21);
            this.RunSingleSequenceComboBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(169, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Seq #:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Droid Name:";
            // 
            // RunFullShowButton
            // 
            this.RunFullShowButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RunFullShowButton.Location = new System.Drawing.Point(15, 334);
            this.RunFullShowButton.Name = "RunFullShowButton";
            this.RunFullShowButton.Size = new System.Drawing.Size(214, 62);
            this.RunFullShowButton.TabIndex = 6;
            this.RunFullShowButton.Text = "Run Full Show";
            this.RunFullShowButton.UseVisualStyleBackColor = true;
            this.RunFullShowButton.Click += new System.EventHandler(this.Run_Full_Show);
            // 
            // ConnectedMaestrosListView
            // 
            this.ConnectedMaestrosListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MaestroID,
            this.DroidName});
            this.ConnectedMaestrosListView.FullRowSelect = true;
            this.ConnectedMaestrosListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ConnectedMaestrosListView.HideSelection = false;
            this.ConnectedMaestrosListView.LabelWrap = false;
            this.ConnectedMaestrosListView.Location = new System.Drawing.Point(15, 25);
            this.ConnectedMaestrosListView.MultiSelect = false;
            this.ConnectedMaestrosListView.Name = "ConnectedMaestrosListView";
            this.ConnectedMaestrosListView.Size = new System.Drawing.Size(214, 108);
            this.ConnectedMaestrosListView.TabIndex = 7;
            this.ConnectedMaestrosListView.UseCompatibleStateImageBehavior = false;
            this.ConnectedMaestrosListView.View = System.Windows.Forms.View.Details;
            // 
            // MaestroID
            // 
            this.MaestroID.Text = "Maestro ID";
            this.MaestroID.Width = 70;
            // 
            // DroidName
            // 
            this.DroidName.Text = "Droid Name";
            this.DroidName.Width = 120;
            // 
            // OpenVideoWindowButton
            // 
            this.OpenVideoWindowButton.Location = new System.Drawing.Point(15, 305);
            this.OpenVideoWindowButton.Name = "OpenVideoWindowButton";
            this.OpenVideoWindowButton.Size = new System.Drawing.Size(214, 23);
            this.OpenVideoWindowButton.TabIndex = 8;
            this.OpenVideoWindowButton.Text = "Open Video Window";
            this.OpenVideoWindowButton.UseVisualStyleBackColor = true;
            this.OpenVideoWindowButton.Click += new System.EventHandler(this.OpenVideoWindowButton_Click);
            // 
            // SaveCurrentShowButton
            // 
            this.SaveCurrentShowButton.Location = new System.Drawing.Point(671, 373);
            this.SaveCurrentShowButton.Name = "SaveCurrentShowButton";
            this.SaveCurrentShowButton.Size = new System.Drawing.Size(113, 23);
            this.SaveCurrentShowButton.TabIndex = 9;
            this.SaveCurrentShowButton.Text = "Save Current Show";
            this.SaveCurrentShowButton.UseVisualStyleBackColor = true;
            this.SaveCurrentShowButton.Click += new System.EventHandler(this.SaveCurrentShowButton_Click);
            // 
            // LoadShowButton
            // 
            this.LoadShowButton.Location = new System.Drawing.Point(235, 373);
            this.LoadShowButton.Name = "LoadShowButton";
            this.LoadShowButton.Size = new System.Drawing.Size(75, 23);
            this.LoadShowButton.TabIndex = 10;
            this.LoadShowButton.Text = "Load Show";
            this.LoadShowButton.UseVisualStyleBackColor = true;
            this.LoadShowButton.Click += new System.EventHandler(this.LoadShowButton_Click);
            // 
            // FrontPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 402);
            this.Controls.Add(this.LoadShowButton);
            this.Controls.Add(this.SaveCurrentShowButton);
            this.Controls.Add(this.OpenVideoWindowButton);
            this.Controls.Add(this.ConnectedMaestrosListView);
            this.Controls.Add(this.RunFullShowButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.RenameSelectedMaestroButton);
            this.Controls.Add(this.RoutineTabControl);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrontPage";
            this.Text = "Droid Show Program V1.0";
            ((System.ComponentModel.ISupportInitialize)(this.RunSingleSequenceNumeric)).EndInit();
            this.RoutineTabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.tabPage7.ResumeLayout(false);
            this.tabPage8.ResumeLayout(false);
            this.tabPage9.ResumeLayout(false);
            this.tabPage10.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer Tick;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown RunSingleSequenceNumeric;
        private System.Windows.Forms.Button RenameSelectedMaestroButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button RunSingleSequenceButton;
        private System.Windows.Forms.ComboBox RunSingleSequenceComboBox;
        private System.Windows.Forms.Button RunFullShowButton;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TabPage tabPage8;
        private RoutineBuilderGroup routineBuilderGroup1;
        private RoutineBuilderGroup routineBuilderGroup2;
        private System.Windows.Forms.ListView ConnectedMaestrosListView;
        private System.Windows.Forms.ColumnHeader MaestroID;
        private System.Windows.Forms.ColumnHeader DroidName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox RunSingleRoutineAudioTextBox;
        private System.Windows.Forms.Button RunSingleSequenceBrowseButton;
        private System.Windows.Forms.TabPage tabPage9;
        private System.Windows.Forms.TabPage tabPage10;
        private RoutineBuilderGroup routineBuilderGroup3;
        private RoutineBuilderGroup routineBuilderGroup4;
        private RoutineBuilderGroup routineBuilderGroup5;
        private RoutineBuilderGroup routineBuilderGroup6;
        private RoutineBuilderGroup routineBuilderGroup7;
        private RoutineBuilderGroup routineBuilderGroup8;
        private RoutineBuilderGroup routineBuilderGroup9;
        private RoutineBuilderGroup routineBuilderGroup10;
        public System.Windows.Forms.TabControl RoutineTabControl;
        private System.Windows.Forms.Button OpenVideoWindowButton;
        private System.Windows.Forms.Button SaveCurrentShowButton;
        private System.Windows.Forms.Button LoadShowButton;
    }
}

