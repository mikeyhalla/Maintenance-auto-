namespace Maintenance
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.DiskCheckLabel = new System.Windows.Forms.Label();
            this.DiskCheckDays = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.SFCLabel = new System.Windows.Forms.Label();
            this.SFCDays = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.DISMLabel = new System.Windows.Forms.Label();
            this.DISMDays = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.ExclusionListTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.ExclusionListAdd = new System.Windows.Forms.Button();
            this.ExclusionListRemove = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.ExclusionListBox = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.helpButton = new System.Windows.Forms.Button();
            this.LoggingBox = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.TasksTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TasksDisableButton = new System.Windows.Forms.Button();
            this.TasksDisableRemove = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.TasksDisableBox = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ServicesTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ServicesManualButton = new System.Windows.Forms.Button();
            this.ServicesDisableButton = new System.Windows.Forms.Button();
            this.ServicesManualRemove = new System.Windows.Forms.Button();
            this.ServicesDisableRemove = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ServicesManualBox = new System.Windows.Forms.ComboBox();
            this.ServicesDisableBox = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PathHideBrowse = new System.Windows.Forms.Button();
            this.PathHideRemove = new System.Windows.Forms.Button();
            this.DirDelBrowse = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.DirDelRemove = new System.Windows.Forms.Button();
            this.PathHideListBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DirToDelBox = new System.Windows.Forms.ComboBox();
            this.PathFilesDelOldBrowse = new System.Windows.Forms.Button();
            this.PathFilesDelBrowse = new System.Windows.Forms.Button();
            this.PathFilesDelOldRemove = new System.Windows.Forms.Button();
            this.PathFilesDelRemove = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PathFilesDelOldBox = new System.Windows.Forms.ComboBox();
            this.PathFilesDelBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FilesHideBrowse = new System.Windows.Forms.Button();
            this.FilesDelBrowse = new System.Windows.Forms.Button();
            this.FilesHideRemove = new System.Windows.Forms.Button();
            this.FilesDelRemove = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FilesHideBox = new System.Windows.Forms.ComboBox();
            this.FilesToDelBox = new System.Windows.Forms.ComboBox();
            this.DISMForceRun = new System.Windows.Forms.CheckBox();
            this.SFCForceRun = new System.Windows.Forms.CheckBox();
            this.DiskCheckForceRun = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.groupBox6);
            this.panel1.Controls.Add(this.groupBox5);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(597, 692);
            this.panel1.TabIndex = 20;
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox6.Controls.Add(this.DiskCheckForceRun);
            this.groupBox6.Controls.Add(this.SFCForceRun);
            this.groupBox6.Controls.Add(this.DISMForceRun);
            this.groupBox6.Controls.Add(this.label18);
            this.groupBox6.Controls.Add(this.DiskCheckLabel);
            this.groupBox6.Controls.Add(this.DiskCheckDays);
            this.groupBox6.Controls.Add(this.label16);
            this.groupBox6.Controls.Add(this.SFCLabel);
            this.groupBox6.Controls.Add(this.SFCDays);
            this.groupBox6.Controls.Add(this.label14);
            this.groupBox6.Controls.Add(this.DISMLabel);
            this.groupBox6.Controls.Add(this.DISMDays);
            this.groupBox6.Location = new System.Drawing.Point(1, 567);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(594, 90);
            this.groupBox6.TabIndex = 56;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Days in between to run (0 = Disabled)";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(551, 33);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(31, 13);
            this.label18.TabIndex = 56;
            this.label18.Text = "Days";
            // 
            // DiskCheckLabel
            // 
            this.DiskCheckLabel.AutoSize = true;
            this.DiskCheckLabel.Location = new System.Drawing.Point(412, 33);
            this.DiskCheckLabel.Name = "DiskCheckLabel";
            this.DiskCheckLabel.Size = new System.Drawing.Size(62, 13);
            this.DiskCheckLabel.TabIndex = 55;
            this.DiskCheckLabel.Text = "DiskCheck:";
            // 
            // DiskCheckDays
            // 
            this.DiskCheckDays.FormattingEnabled = true;
            this.DiskCheckDays.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "0"});
            this.DiskCheckDays.Location = new System.Drawing.Point(477, 30);
            this.DiskCheckDays.Name = "DiskCheckDays";
            this.DiskCheckDays.Size = new System.Drawing.Size(68, 21);
            this.DiskCheckDays.TabIndex = 54;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(322, 33);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(31, 13);
            this.label16.TabIndex = 53;
            this.label16.Text = "Days";
            // 
            // SFCLabel
            // 
            this.SFCLabel.AutoSize = true;
            this.SFCLabel.Location = new System.Drawing.Point(215, 33);
            this.SFCLabel.Name = "SFCLabel";
            this.SFCLabel.Size = new System.Drawing.Size(30, 13);
            this.SFCLabel.TabIndex = 52;
            this.SFCLabel.Text = "SFC:";
            // 
            // SFCDays
            // 
            this.SFCDays.FormattingEnabled = true;
            this.SFCDays.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "0"});
            this.SFCDays.Location = new System.Drawing.Point(248, 30);
            this.SFCDays.Name = "SFCDays";
            this.SFCDays.Size = new System.Drawing.Size(68, 21);
            this.SFCDays.TabIndex = 51;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(129, 33);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(31, 13);
            this.label14.TabIndex = 50;
            this.label14.Text = "Days";
            // 
            // DISMLabel
            // 
            this.DISMLabel.AutoSize = true;
            this.DISMLabel.Location = new System.Drawing.Point(15, 33);
            this.DISMLabel.Name = "DISMLabel";
            this.DISMLabel.Size = new System.Drawing.Size(37, 13);
            this.DISMLabel.TabIndex = 49;
            this.DISMLabel.Text = "DISM:";
            // 
            // DISMDays
            // 
            this.DISMDays.FormattingEnabled = true;
            this.DISMDays.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "0"});
            this.DISMDays.Location = new System.Drawing.Point(55, 30);
            this.DISMDays.Name = "DISMDays";
            this.DISMDays.Size = new System.Drawing.Size(68, 21);
            this.DISMDays.TabIndex = 48;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox5.Controls.Add(this.ExclusionListTextBox);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.ExclusionListAdd);
            this.groupBox5.Controls.Add(this.ExclusionListRemove);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.ExclusionListBox);
            this.groupBox5.Location = new System.Drawing.Point(1, 470);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(594, 96);
            this.groupBox5.TabIndex = 55;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Exclude";
            // 
            // ExclusionListTextBox
            // 
            this.ExclusionListTextBox.Location = new System.Drawing.Point(160, 59);
            this.ExclusionListTextBox.Name = "ExclusionListTextBox";
            this.ExclusionListTextBox.Size = new System.Drawing.Size(246, 20);
            this.ExclusionListTextBox.TabIndex = 53;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(49, 62);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 13);
            this.label11.TabIndex = 52;
            this.label11.Text = "File/Folder Name:";
            // 
            // ExclusionListAdd
            // 
            this.ExclusionListAdd.BackColor = System.Drawing.SystemColors.Control;
            this.ExclusionListAdd.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.ExclusionListAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExclusionListAdd.Location = new System.Drawing.Point(412, 57);
            this.ExclusionListAdd.Name = "ExclusionListAdd";
            this.ExclusionListAdd.Size = new System.Drawing.Size(82, 23);
            this.ExclusionListAdd.TabIndex = 51;
            this.ExclusionListAdd.Text = "Add";
            this.ExclusionListAdd.UseVisualStyleBackColor = false;
            this.ExclusionListAdd.Click += new System.EventHandler(this.ExclusionListAdd_Click);
            // 
            // ExclusionListRemove
            // 
            this.ExclusionListRemove.BackColor = System.Drawing.SystemColors.Control;
            this.ExclusionListRemove.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.ExclusionListRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExclusionListRemove.Location = new System.Drawing.Point(412, 23);
            this.ExclusionListRemove.Name = "ExclusionListRemove";
            this.ExclusionListRemove.Size = new System.Drawing.Size(82, 23);
            this.ExclusionListRemove.TabIndex = 50;
            this.ExclusionListRemove.Text = "Remove";
            this.ExclusionListRemove.UseVisualStyleBackColor = false;
            this.ExclusionListRemove.Click += new System.EventHandler(this.ExclusionListRemove_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 27);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 13);
            this.label12.TabIndex = 49;
            this.label12.Text = "Exclusion List";
            // 
            // ExclusionListBox
            // 
            this.ExclusionListBox.FormattingEnabled = true;
            this.ExclusionListBox.Location = new System.Drawing.Point(160, 24);
            this.ExclusionListBox.Name = "ExclusionListBox";
            this.ExclusionListBox.Size = new System.Drawing.Size(246, 21);
            this.ExclusionListBox.TabIndex = 48;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.helpButton);
            this.panel2.Controls.Add(this.LoggingBox);
            this.panel2.Location = new System.Drawing.Point(0, 657);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(596, 35);
            this.panel2.TabIndex = 54;
            // 
            // HelpButton
            // 
            this.helpButton.BackColor = System.Drawing.SystemColors.Control;
            this.helpButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.helpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.helpButton.Location = new System.Drawing.Point(18, 6);
            this.helpButton.Name = "HelpButton";
            this.helpButton.Size = new System.Drawing.Size(48, 23);
            this.helpButton.TabIndex = 22;
            this.helpButton.Text = "?";
            this.helpButton.UseVisualStyleBackColor = false;
            this.helpButton.Click += new System.EventHandler(this.HelpButton_Click);
            // 
            // LoggingBox
            // 
            this.LoggingBox.AutoSize = true;
            this.LoggingBox.Location = new System.Drawing.Point(478, 9);
            this.LoggingBox.Name = "LoggingBox";
            this.LoggingBox.Size = new System.Drawing.Size(106, 17);
            this.LoggingBox.TabIndex = 20;
            this.LoggingBox.Text = "Logging Enabled";
            this.LoggingBox.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox4.Controls.Add(this.TasksTextBox);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.TasksDisableButton);
            this.groupBox4.Controls.Add(this.TasksDisableRemove);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.TasksDisableBox);
            this.groupBox4.Location = new System.Drawing.Point(1, 369);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(594, 100);
            this.groupBox4.TabIndex = 53;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Task";
            // 
            // TasksTextBox
            // 
            this.TasksTextBox.Location = new System.Drawing.Point(160, 61);
            this.TasksTextBox.Name = "TasksTextBox";
            this.TasksTextBox.Size = new System.Drawing.Size(246, 20);
            this.TasksTextBox.TabIndex = 47;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(49, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 13);
            this.label10.TabIndex = 46;
            this.label10.Text = "Task Name:";
            // 
            // TasksDisableButton
            // 
            this.TasksDisableButton.BackColor = System.Drawing.SystemColors.Control;
            this.TasksDisableButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.TasksDisableButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TasksDisableButton.Location = new System.Drawing.Point(412, 59);
            this.TasksDisableButton.Name = "TasksDisableButton";
            this.TasksDisableButton.Size = new System.Drawing.Size(82, 23);
            this.TasksDisableButton.TabIndex = 45;
            this.TasksDisableButton.Text = "Add";
            this.TasksDisableButton.UseVisualStyleBackColor = false;
            this.TasksDisableButton.Click += new System.EventHandler(this.TasksDisableButton_Click);
            // 
            // TasksDisableRemove
            // 
            this.TasksDisableRemove.BackColor = System.Drawing.SystemColors.Control;
            this.TasksDisableRemove.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.TasksDisableRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TasksDisableRemove.Location = new System.Drawing.Point(412, 25);
            this.TasksDisableRemove.Name = "TasksDisableRemove";
            this.TasksDisableRemove.Size = new System.Drawing.Size(82, 23);
            this.TasksDisableRemove.TabIndex = 44;
            this.TasksDisableRemove.Text = "Remove";
            this.TasksDisableRemove.UseVisualStyleBackColor = false;
            this.TasksDisableRemove.Click += new System.EventHandler(this.TasksDisableRemove_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 13);
            this.label8.TabIndex = 43;
            this.label8.Text = "Tasks To Disable:";
            // 
            // TasksDisableBox
            // 
            this.TasksDisableBox.FormattingEnabled = true;
            this.TasksDisableBox.Location = new System.Drawing.Point(160, 26);
            this.TasksDisableBox.Name = "TasksDisableBox";
            this.TasksDisableBox.Size = new System.Drawing.Size(246, 21);
            this.TasksDisableBox.TabIndex = 42;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Controls.Add(this.ServicesTextBox);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.ServicesManualButton);
            this.groupBox3.Controls.Add(this.ServicesDisableButton);
            this.groupBox3.Controls.Add(this.ServicesManualRemove);
            this.groupBox3.Controls.Add(this.ServicesDisableRemove);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.ServicesManualBox);
            this.groupBox3.Controls.Add(this.ServicesDisableBox);
            this.groupBox3.Location = new System.Drawing.Point(1, 241);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(594, 127);
            this.groupBox3.TabIndex = 52;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Service";
            // 
            // ServicesTextBox
            // 
            this.ServicesTextBox.Location = new System.Drawing.Point(160, 88);
            this.ServicesTextBox.Name = "ServicesTextBox";
            this.ServicesTextBox.Size = new System.Drawing.Size(246, 20);
            this.ServicesTextBox.TabIndex = 60;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(49, 91);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 59;
            this.label9.Text = "Service Name:";
            // 
            // ServicesManualButton
            // 
            this.ServicesManualButton.BackColor = System.Drawing.SystemColors.Control;
            this.ServicesManualButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.ServicesManualButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ServicesManualButton.Location = new System.Drawing.Point(500, 86);
            this.ServicesManualButton.Name = "ServicesManualButton";
            this.ServicesManualButton.Size = new System.Drawing.Size(82, 23);
            this.ServicesManualButton.TabIndex = 58;
            this.ServicesManualButton.Text = "Manual";
            this.ServicesManualButton.UseVisualStyleBackColor = false;
            this.ServicesManualButton.Click += new System.EventHandler(this.ServicesManualButton_Click);
            // 
            // ServicesDisableButton
            // 
            this.ServicesDisableButton.BackColor = System.Drawing.SystemColors.Control;
            this.ServicesDisableButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.ServicesDisableButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ServicesDisableButton.Location = new System.Drawing.Point(412, 86);
            this.ServicesDisableButton.Name = "ServicesDisableButton";
            this.ServicesDisableButton.Size = new System.Drawing.Size(82, 23);
            this.ServicesDisableButton.TabIndex = 57;
            this.ServicesDisableButton.Text = "Disabled";
            this.ServicesDisableButton.UseVisualStyleBackColor = false;
            this.ServicesDisableButton.Click += new System.EventHandler(this.ServicesDisableButton_Click);
            // 
            // ServicesManualRemove
            // 
            this.ServicesManualRemove.BackColor = System.Drawing.SystemColors.Control;
            this.ServicesManualRemove.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.ServicesManualRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ServicesManualRemove.Location = new System.Drawing.Point(412, 53);
            this.ServicesManualRemove.Name = "ServicesManualRemove";
            this.ServicesManualRemove.Size = new System.Drawing.Size(82, 23);
            this.ServicesManualRemove.TabIndex = 56;
            this.ServicesManualRemove.Text = "Remove";
            this.ServicesManualRemove.UseVisualStyleBackColor = false;
            this.ServicesManualRemove.Click += new System.EventHandler(this.ServicesManualRemove_Click);
            // 
            // ServicesDisableRemove
            // 
            this.ServicesDisableRemove.BackColor = System.Drawing.SystemColors.Control;
            this.ServicesDisableRemove.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.ServicesDisableRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ServicesDisableRemove.Location = new System.Drawing.Point(412, 22);
            this.ServicesDisableRemove.Name = "ServicesDisableRemove";
            this.ServicesDisableRemove.Size = new System.Drawing.Size(82, 23);
            this.ServicesDisableRemove.TabIndex = 55;
            this.ServicesDisableRemove.Text = "Remove";
            this.ServicesDisableRemove.UseVisualStyleBackColor = false;
            this.ServicesDisableRemove.Click += new System.EventHandler(this.ServicesDisableRemove_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 13);
            this.label7.TabIndex = 54;
            this.label7.Text = "Services To Manual:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 13);
            this.label6.TabIndex = 53;
            this.label6.Text = "Services To Disable:";
            // 
            // ServicesManualBox
            // 
            this.ServicesManualBox.FormattingEnabled = true;
            this.ServicesManualBox.Location = new System.Drawing.Point(160, 54);
            this.ServicesManualBox.Name = "ServicesManualBox";
            this.ServicesManualBox.Size = new System.Drawing.Size(246, 21);
            this.ServicesManualBox.TabIndex = 52;
            // 
            // ServicesDisableBox
            // 
            this.ServicesDisableBox.FormattingEnabled = true;
            this.ServicesDisableBox.Location = new System.Drawing.Point(160, 23);
            this.ServicesDisableBox.Name = "ServicesDisableBox";
            this.ServicesDisableBox.Size = new System.Drawing.Size(246, 21);
            this.ServicesDisableBox.TabIndex = 51;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.PathHideBrowse);
            this.groupBox2.Controls.Add(this.PathHideRemove);
            this.groupBox2.Controls.Add(this.DirDelBrowse);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.DirDelRemove);
            this.groupBox2.Controls.Add(this.PathHideListBox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.DirToDelBox);
            this.groupBox2.Controls.Add(this.PathFilesDelOldBrowse);
            this.groupBox2.Controls.Add(this.PathFilesDelBrowse);
            this.groupBox2.Controls.Add(this.PathFilesDelOldRemove);
            this.groupBox2.Controls.Add(this.PathFilesDelRemove);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.PathFilesDelOldBox);
            this.groupBox2.Controls.Add(this.PathFilesDelBox);
            this.groupBox2.Location = new System.Drawing.Point(1, 91);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(594, 149);
            this.groupBox2.TabIndex = 51;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Path";
            // 
            // PathHideBrowse
            // 
            this.PathHideBrowse.BackColor = System.Drawing.SystemColors.Control;
            this.PathHideBrowse.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.PathHideBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PathHideBrowse.Location = new System.Drawing.Point(500, 111);
            this.PathHideBrowse.Name = "PathHideBrowse";
            this.PathHideBrowse.Size = new System.Drawing.Size(82, 23);
            this.PathHideBrowse.TabIndex = 50;
            this.PathHideBrowse.Text = "Browse";
            this.PathHideBrowse.UseVisualStyleBackColor = false;
            this.PathHideBrowse.Click += new System.EventHandler(this.PathHideBrowse_Click);
            // 
            // PathHideRemove
            // 
            this.PathHideRemove.BackColor = System.Drawing.SystemColors.Control;
            this.PathHideRemove.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.PathHideRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PathHideRemove.Location = new System.Drawing.Point(412, 111);
            this.PathHideRemove.Name = "PathHideRemove";
            this.PathHideRemove.Size = new System.Drawing.Size(82, 23);
            this.PathHideRemove.TabIndex = 49;
            this.PathHideRemove.Text = "Remove";
            this.PathHideRemove.UseVisualStyleBackColor = false;
            this.PathHideRemove.Click += new System.EventHandler(this.PathHideRemove_Click);
            // 
            // DirDelBrowse
            // 
            this.DirDelBrowse.BackColor = System.Drawing.SystemColors.Control;
            this.DirDelBrowse.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.DirDelBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DirDelBrowse.Location = new System.Drawing.Point(500, 24);
            this.DirDelBrowse.Name = "DirDelBrowse";
            this.DirDelBrowse.Size = new System.Drawing.Size(82, 23);
            this.DirDelBrowse.TabIndex = 57;
            this.DirDelBrowse.Text = "Browse";
            this.DirDelBrowse.UseVisualStyleBackColor = false;
            this.DirDelBrowse.Click += new System.EventHandler(this.DirDelBrowse_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(15, 115);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(101, 13);
            this.label13.TabIndex = 48;
            this.label13.Text = "Directories To Hide:";
            // 
            // DirDelRemove
            // 
            this.DirDelRemove.BackColor = System.Drawing.SystemColors.Control;
            this.DirDelRemove.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.DirDelRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DirDelRemove.Location = new System.Drawing.Point(412, 24);
            this.DirDelRemove.Name = "DirDelRemove";
            this.DirDelRemove.Size = new System.Drawing.Size(82, 23);
            this.DirDelRemove.TabIndex = 56;
            this.DirDelRemove.Text = "Remove";
            this.DirDelRemove.UseVisualStyleBackColor = false;
            this.DirDelRemove.Click += new System.EventHandler(this.DirDelRemove_Click);
            // 
            // PathHideListBox
            // 
            this.PathHideListBox.FormattingEnabled = true;
            this.PathHideListBox.Location = new System.Drawing.Point(160, 112);
            this.PathHideListBox.Name = "PathHideListBox";
            this.PathHideListBox.Size = new System.Drawing.Size(246, 21);
            this.PathHideListBox.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 55;
            this.label1.Text = "Directories To Delete:";
            // 
            // DirToDelBox
            // 
            this.DirToDelBox.FormattingEnabled = true;
            this.DirToDelBox.Location = new System.Drawing.Point(160, 25);
            this.DirToDelBox.Name = "DirToDelBox";
            this.DirToDelBox.Size = new System.Drawing.Size(246, 21);
            this.DirToDelBox.TabIndex = 54;
            // 
            // PathFilesDelOldBrowse
            // 
            this.PathFilesDelOldBrowse.BackColor = System.Drawing.SystemColors.Control;
            this.PathFilesDelOldBrowse.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.PathFilesDelOldBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PathFilesDelOldBrowse.Location = new System.Drawing.Point(500, 82);
            this.PathFilesDelOldBrowse.Name = "PathFilesDelOldBrowse";
            this.PathFilesDelOldBrowse.Size = new System.Drawing.Size(82, 23);
            this.PathFilesDelOldBrowse.TabIndex = 53;
            this.PathFilesDelOldBrowse.Text = "Browse";
            this.PathFilesDelOldBrowse.UseVisualStyleBackColor = false;
            this.PathFilesDelOldBrowse.Click += new System.EventHandler(this.PathFilesDelOldBrowse_Click);
            // 
            // PathFilesDelBrowse
            // 
            this.PathFilesDelBrowse.BackColor = System.Drawing.SystemColors.Control;
            this.PathFilesDelBrowse.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.PathFilesDelBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PathFilesDelBrowse.Location = new System.Drawing.Point(500, 53);
            this.PathFilesDelBrowse.Name = "PathFilesDelBrowse";
            this.PathFilesDelBrowse.Size = new System.Drawing.Size(82, 23);
            this.PathFilesDelBrowse.TabIndex = 52;
            this.PathFilesDelBrowse.Text = "Browse";
            this.PathFilesDelBrowse.UseVisualStyleBackColor = false;
            this.PathFilesDelBrowse.Click += new System.EventHandler(this.PathFilesDelBrowse_Click);
            // 
            // PathFilesDelOldRemove
            // 
            this.PathFilesDelOldRemove.BackColor = System.Drawing.SystemColors.Control;
            this.PathFilesDelOldRemove.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.PathFilesDelOldRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PathFilesDelOldRemove.Location = new System.Drawing.Point(412, 82);
            this.PathFilesDelOldRemove.Name = "PathFilesDelOldRemove";
            this.PathFilesDelOldRemove.Size = new System.Drawing.Size(82, 23);
            this.PathFilesDelOldRemove.TabIndex = 51;
            this.PathFilesDelOldRemove.Text = "Remove";
            this.PathFilesDelOldRemove.UseVisualStyleBackColor = false;
            this.PathFilesDelOldRemove.Click += new System.EventHandler(this.PathFilesDelOldRemove_Click);
            // 
            // PathFilesDelRemove
            // 
            this.PathFilesDelRemove.BackColor = System.Drawing.SystemColors.Control;
            this.PathFilesDelRemove.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.PathFilesDelRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PathFilesDelRemove.Location = new System.Drawing.Point(412, 53);
            this.PathFilesDelRemove.Name = "PathFilesDelRemove";
            this.PathFilesDelRemove.Size = new System.Drawing.Size(82, 23);
            this.PathFilesDelRemove.TabIndex = 50;
            this.PathFilesDelRemove.Text = "Remove";
            this.PathFilesDelRemove.UseVisualStyleBackColor = false;
            this.PathFilesDelRemove.Click += new System.EventHandler(this.PathFilesDelRemove_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 13);
            this.label5.TabIndex = 49;
            this.label5.Text = "Path Files To Delete Older:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 48;
            this.label4.Text = "Path Files To Delete:";
            // 
            // PathFilesDelOldBox
            // 
            this.PathFilesDelOldBox.FormattingEnabled = true;
            this.PathFilesDelOldBox.Location = new System.Drawing.Point(160, 83);
            this.PathFilesDelOldBox.Name = "PathFilesDelOldBox";
            this.PathFilesDelOldBox.Size = new System.Drawing.Size(246, 21);
            this.PathFilesDelOldBox.TabIndex = 47;
            // 
            // PathFilesDelBox
            // 
            this.PathFilesDelBox.FormattingEnabled = true;
            this.PathFilesDelBox.Location = new System.Drawing.Point(160, 54);
            this.PathFilesDelBox.Name = "PathFilesDelBox";
            this.PathFilesDelBox.Size = new System.Drawing.Size(246, 21);
            this.PathFilesDelBox.TabIndex = 46;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.FilesHideBrowse);
            this.groupBox1.Controls.Add(this.FilesDelBrowse);
            this.groupBox1.Controls.Add(this.FilesHideRemove);
            this.groupBox1.Controls.Add(this.FilesDelRemove);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.FilesHideBox);
            this.groupBox1.Controls.Add(this.FilesToDelBox);
            this.groupBox1.Location = new System.Drawing.Point(1, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(594, 89);
            this.groupBox1.TabIndex = 50;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "File";
            // 
            // FilesHideBrowse
            // 
            this.FilesHideBrowse.BackColor = System.Drawing.SystemColors.Control;
            this.FilesHideBrowse.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.FilesHideBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FilesHideBrowse.Location = new System.Drawing.Point(500, 52);
            this.FilesHideBrowse.Name = "FilesHideBrowse";
            this.FilesHideBrowse.Size = new System.Drawing.Size(82, 23);
            this.FilesHideBrowse.TabIndex = 46;
            this.FilesHideBrowse.Text = "Browse";
            this.FilesHideBrowse.UseVisualStyleBackColor = false;
            this.FilesHideBrowse.Click += new System.EventHandler(this.FilesHideBrowse_Click);
            // 
            // FilesDelBrowse
            // 
            this.FilesDelBrowse.BackColor = System.Drawing.SystemColors.Control;
            this.FilesDelBrowse.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.FilesDelBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FilesDelBrowse.Location = new System.Drawing.Point(500, 23);
            this.FilesDelBrowse.Name = "FilesDelBrowse";
            this.FilesDelBrowse.Size = new System.Drawing.Size(82, 23);
            this.FilesDelBrowse.TabIndex = 45;
            this.FilesDelBrowse.Text = "Browse";
            this.FilesDelBrowse.UseVisualStyleBackColor = false;
            this.FilesDelBrowse.Click += new System.EventHandler(this.FilesDelBrowse_Click);
            // 
            // FilesHideRemove
            // 
            this.FilesHideRemove.BackColor = System.Drawing.SystemColors.Control;
            this.FilesHideRemove.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.FilesHideRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FilesHideRemove.Location = new System.Drawing.Point(412, 52);
            this.FilesHideRemove.Name = "FilesHideRemove";
            this.FilesHideRemove.Size = new System.Drawing.Size(82, 23);
            this.FilesHideRemove.TabIndex = 44;
            this.FilesHideRemove.Text = "Remove";
            this.FilesHideRemove.UseVisualStyleBackColor = false;
            this.FilesHideRemove.Click += new System.EventHandler(this.FilesHideRemove_Click);
            // 
            // FilesDelRemove
            // 
            this.FilesDelRemove.BackColor = System.Drawing.SystemColors.Control;
            this.FilesDelRemove.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.FilesDelRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FilesDelRemove.Location = new System.Drawing.Point(412, 23);
            this.FilesDelRemove.Name = "FilesDelRemove";
            this.FilesDelRemove.Size = new System.Drawing.Size(82, 23);
            this.FilesDelRemove.TabIndex = 43;
            this.FilesDelRemove.Text = "Remove";
            this.FilesDelRemove.UseVisualStyleBackColor = false;
            this.FilesDelRemove.Click += new System.EventHandler(this.FilesDelRemove_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "Files To Hide:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Files To Delete:";
            // 
            // FilesHideBox
            // 
            this.FilesHideBox.FormattingEnabled = true;
            this.FilesHideBox.Location = new System.Drawing.Point(160, 53);
            this.FilesHideBox.Name = "FilesHideBox";
            this.FilesHideBox.Size = new System.Drawing.Size(246, 21);
            this.FilesHideBox.TabIndex = 40;
            // 
            // FilesToDelBox
            // 
            this.FilesToDelBox.FormattingEnabled = true;
            this.FilesToDelBox.Location = new System.Drawing.Point(160, 24);
            this.FilesToDelBox.Name = "FilesToDelBox";
            this.FilesToDelBox.Size = new System.Drawing.Size(246, 21);
            this.FilesToDelBox.TabIndex = 39;
            // 
            // DISMForceRun
            // 
            this.DISMForceRun.AutoSize = true;
            this.DISMForceRun.Location = new System.Drawing.Point(18, 59);
            this.DISMForceRun.Name = "DISMForceRun";
            this.DISMForceRun.Size = new System.Drawing.Size(102, 17);
            this.DISMForceRun.TabIndex = 57;
            this.DISMForceRun.Text = "Run on next run";
            this.DISMForceRun.UseVisualStyleBackColor = true;
            // 
            // SFCForceRun
            // 
            this.SFCForceRun.AutoSize = true;
            this.SFCForceRun.Location = new System.Drawing.Point(218, 59);
            this.SFCForceRun.Name = "SFCForceRun";
            this.SFCForceRun.Size = new System.Drawing.Size(102, 17);
            this.SFCForceRun.TabIndex = 58;
            this.SFCForceRun.Text = "Run on next run";
            this.SFCForceRun.UseVisualStyleBackColor = true;
            // 
            // DiskCheckForceRun
            // 
            this.DiskCheckForceRun.AutoSize = true;
            this.DiskCheckForceRun.Location = new System.Drawing.Point(415, 59);
            this.DiskCheckForceRun.Name = "DiskCheckForceRun";
            this.DiskCheckForceRun.Size = new System.Drawing.Size(102, 17);
            this.DiskCheckForceRun.TabIndex = 59;
            this.DiskCheckForceRun.Text = "Run on next run";
            this.DiskCheckForceRun.UseVisualStyleBackColor = true;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(596, 694);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(612, 534);
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Maintenance Settings";
            this.panel1.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox TasksTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button TasksDisableButton;
        private System.Windows.Forms.Button TasksDisableRemove;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox TasksDisableBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox ServicesTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button ServicesManualButton;
        private System.Windows.Forms.Button ServicesDisableButton;
        private System.Windows.Forms.Button ServicesManualRemove;
        private System.Windows.Forms.Button ServicesDisableRemove;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox ServicesManualBox;
        private System.Windows.Forms.ComboBox ServicesDisableBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button DirDelBrowse;
        private System.Windows.Forms.Button DirDelRemove;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox DirToDelBox;
        private System.Windows.Forms.Button PathFilesDelOldBrowse;
        private System.Windows.Forms.Button PathFilesDelBrowse;
        private System.Windows.Forms.Button PathFilesDelOldRemove;
        private System.Windows.Forms.Button PathFilesDelRemove;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox PathFilesDelOldBox;
        private System.Windows.Forms.ComboBox PathFilesDelBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button FilesHideBrowse;
        private System.Windows.Forms.Button FilesDelBrowse;
        private System.Windows.Forms.Button FilesHideRemove;
        private System.Windows.Forms.Button FilesDelRemove;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox FilesHideBox;
        private System.Windows.Forms.ComboBox FilesToDelBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.CheckBox LoggingBox;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox ExclusionListTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button ExclusionListAdd;
        private System.Windows.Forms.Button ExclusionListRemove;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox ExclusionListBox;
        private System.Windows.Forms.Button PathHideBrowse;
        private System.Windows.Forms.Button PathHideRemove;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox PathHideListBox;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label DiskCheckLabel;
        private System.Windows.Forms.ComboBox DiskCheckDays;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label SFCLabel;
        private System.Windows.Forms.ComboBox SFCDays;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label DISMLabel;
        private System.Windows.Forms.ComboBox DISMDays;
        private System.Windows.Forms.CheckBox DiskCheckForceRun;
        private System.Windows.Forms.CheckBox SFCForceRun;
        private System.Windows.Forms.CheckBox DISMForceRun;
    }
}