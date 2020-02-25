namespace a2
{
    partial class Form1
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
            this.TFS = new System.Windows.Forms.Button();
            this.BP = new System.Windows.Forms.Button();
            this.AR = new System.Windows.Forms.Button();
            this.RR = new System.Windows.Forms.Button();
            this.Person_listbox = new System.Windows.Forms.ListBox();
            this.Output_rtbox = new System.Windows.Forms.RichTextBox();
            this.Residence_listbox = new System.Windows.Forms.ListBox();
            this.Communities_box = new System.Windows.Forms.GroupBox();
            this.Sycamore_button = new System.Windows.Forms.RadioButton();
            this.DeKalb_button = new System.Windows.Forms.RadioButton();
            this.ANR_box = new System.Windows.Forms.GroupBox();
            this.Residence_comboBox = new System.Windows.Forms.ComboBox();
            this.Birthday_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Occupation_textBox = new System.Windows.Forms.TextBox();
            this.Name_textBox = new System.Windows.Forms.TextBox();
            this.Residence_label = new System.Windows.Forms.Label();
            this.Birthday_label = new System.Windows.Forms.Label();
            this.Occupation_label = new System.Windows.Forms.Label();
            this.Name_label = new System.Windows.Forms.Label();
            this.AddNR_button = new System.Windows.Forms.Button();
            this.Output_label = new System.Windows.Forms.Label();
            this.AddP_button = new System.Windows.Forms.Button();
            this.SA_label = new System.Windows.Forms.Label();
            this.Apt_label = new System.Windows.Forms.Label();
            this.SF_label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AP_box = new System.Windows.Forms.GroupBox();
            this.Floors_NUD = new System.Windows.Forms.NumericUpDown();
            this.Baths_NUD = new System.Windows.Forms.NumericUpDown();
            this.Bedrooms_NUD = new System.Windows.Forms.NumericUpDown();
            this.Squarefootage_NUD = new System.Windows.Forms.NumericUpDown();
            this.Attached_checkbox = new System.Windows.Forms.CheckBox();
            this.Garage_checkbox = new System.Windows.Forms.CheckBox();
            this.Apartment_textBox = new System.Windows.Forms.TextBox();
            this.StreetAddr_textBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Person_label = new System.Windows.Forms.Label();
            this.ResidenceFS_label = new System.Windows.Forms.Label();
            this.Communities_box.SuspendLayout();
            this.ANR_box.SuspendLayout();
            this.AP_box.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Floors_NUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Baths_NUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bedrooms_NUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Squarefootage_NUD)).BeginInit();
            this.SuspendLayout();
            // 
            // TFS
            // 
            this.TFS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TFS.Cursor = System.Windows.Forms.Cursors.Default;
            this.TFS.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TFS.Location = new System.Drawing.Point(406, 14);
            this.TFS.Name = "TFS";
            this.TFS.Size = new System.Drawing.Size(189, 47);
            this.TFS.TabIndex = 0;
            this.TFS.Text = "Toggle For-Sale";
            this.TFS.UseVisualStyleBackColor = false;
            this.TFS.Click += new System.EventHandler(this.ToggleForSale_Click);
            // 
            // BP
            // 
            this.BP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BP.Cursor = System.Windows.Forms.Cursors.Default;
            this.BP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BP.Location = new System.Drawing.Point(217, 14);
            this.BP.Name = "BP";
            this.BP.Size = new System.Drawing.Size(183, 47);
            this.BP.TabIndex = 1;
            this.BP.Text = "Buy Property";
            this.BP.UseVisualStyleBackColor = false;
            this.BP.Click += new System.EventHandler(this.BuyProperty_Click);
            // 
            // AR
            // 
            this.AR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.AR.Cursor = System.Windows.Forms.Cursors.Default;
            this.AR.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AR.Location = new System.Drawing.Point(217, 63);
            this.AR.Name = "AR";
            this.AR.Size = new System.Drawing.Size(183, 43);
            this.AR.TabIndex = 2;
            this.AR.Text = "Add Resident";
            this.AR.UseVisualStyleBackColor = false;
            this.AR.Click += new System.EventHandler(this.AddResident_Click);
            // 
            // RR
            // 
            this.RR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.RR.Cursor = System.Windows.Forms.Cursors.Default;
            this.RR.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RR.Location = new System.Drawing.Point(406, 63);
            this.RR.Name = "RR";
            this.RR.Size = new System.Drawing.Size(189, 43);
            this.RR.TabIndex = 3;
            this.RR.Text = "Remove Resident";
            this.RR.UseVisualStyleBackColor = false;
            this.RR.Click += new System.EventHandler(this.RemoveResident_Click);
            // 
            // Person_listbox
            // 
            this.Person_listbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Person_listbox.FormattingEnabled = true;
            this.Person_listbox.Location = new System.Drawing.Point(608, 37);
            this.Person_listbox.Name = "Person_listbox";
            this.Person_listbox.Size = new System.Drawing.Size(171, 368);
            this.Person_listbox.TabIndex = 4;
            this.Person_listbox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Person_listbox_MouseClick);
            // 
            // Output_rtbox
            // 
            this.Output_rtbox.Cursor = System.Windows.Forms.Cursors.Default;
            this.Output_rtbox.Location = new System.Drawing.Point(21, 474);
            this.Output_rtbox.Name = "Output_rtbox";
            this.Output_rtbox.ReadOnly = true;
            this.Output_rtbox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.Output_rtbox.Size = new System.Drawing.Size(988, 116);
            this.Output_rtbox.TabIndex = 5;
            this.Output_rtbox.Text = "";
            // 
            // Residence_listbox
            // 
            this.Residence_listbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Residence_listbox.FormattingEnabled = true;
            this.Residence_listbox.Location = new System.Drawing.Point(785, 37);
            this.Residence_listbox.Name = "Residence_listbox";
            this.Residence_listbox.Size = new System.Drawing.Size(224, 368);
            this.Residence_listbox.TabIndex = 6;
            this.Residence_listbox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Residence_listbox_MouseClick);
            this.Residence_listbox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Residence_listbox_MouseClick);
            // 
            // Communities_box
            // 
            this.Communities_box.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Communities_box.Controls.Add(this.Sycamore_button);
            this.Communities_box.Controls.Add(this.DeKalb_button);
            this.Communities_box.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Communities_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Communities_box.Location = new System.Drawing.Point(25, 14);
            this.Communities_box.Name = "Communities_box";
            this.Communities_box.Size = new System.Drawing.Size(169, 92);
            this.Communities_box.TabIndex = 7;
            this.Communities_box.TabStop = false;
            this.Communities_box.Text = "Communities";
            // 
            // Sycamore_button
            // 
            this.Sycamore_button.AutoSize = true;
            this.Sycamore_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sycamore_button.Location = new System.Drawing.Point(7, 48);
            this.Sycamore_button.Name = "Sycamore_button";
            this.Sycamore_button.Size = new System.Drawing.Size(94, 22);
            this.Sycamore_button.TabIndex = 1;
            this.Sycamore_button.Tag = "99998";
            this.Sycamore_button.Text = "Sycamore";
            this.Sycamore_button.UseVisualStyleBackColor = true;
            this.Sycamore_button.CheckedChanged += new System.EventHandler(this.Community_button_CheckedChanged);
            // 
            // DeKalb_button
            // 
            this.DeKalb_button.AutoSize = true;
            this.DeKalb_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeKalb_button.Location = new System.Drawing.Point(6, 25);
            this.DeKalb_button.Name = "DeKalb_button";
            this.DeKalb_button.Size = new System.Drawing.Size(72, 22);
            this.DeKalb_button.TabIndex = 0;
            this.DeKalb_button.Tag = "99999";
            this.DeKalb_button.Text = "Dekalb";
            this.DeKalb_button.UseVisualStyleBackColor = true;
            this.DeKalb_button.CheckedChanged += new System.EventHandler(this.Community_button_CheckedChanged);
            // 
            // ANR_box
            // 
            this.ANR_box.Controls.Add(this.Residence_comboBox);
            this.ANR_box.Controls.Add(this.Birthday_dateTimePicker);
            this.ANR_box.Controls.Add(this.Occupation_textBox);
            this.ANR_box.Controls.Add(this.Name_textBox);
            this.ANR_box.Controls.Add(this.Residence_label);
            this.ANR_box.Controls.Add(this.Birthday_label);
            this.ANR_box.Controls.Add(this.Occupation_label);
            this.ANR_box.Controls.Add(this.Name_label);
            this.ANR_box.Controls.Add(this.AddNR_button);
            this.ANR_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ANR_box.Location = new System.Drawing.Point(12, 112);
            this.ANR_box.Name = "ANR_box";
            this.ANR_box.Size = new System.Drawing.Size(280, 311);
            this.ANR_box.TabIndex = 8;
            this.ANR_box.TabStop = false;
            this.ANR_box.Text = "Add New Resident";
            // 
            // Residence_comboBox
            // 
            this.Residence_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Residence_comboBox.FormattingEnabled = true;
            this.Residence_comboBox.Location = new System.Drawing.Point(19, 230);
            this.Residence_comboBox.Name = "Residence_comboBox";
            this.Residence_comboBox.Size = new System.Drawing.Size(237, 23);
            this.Residence_comboBox.TabIndex = 13;
            // 
            // Birthday_dateTimePicker
            // 
            this.Birthday_dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Birthday_dateTimePicker.Location = new System.Drawing.Point(20, 166);
            this.Birthday_dateTimePicker.MaxDate = new System.DateTime(2020, 2, 7, 17, 3, 14, 0);
            this.Birthday_dateTimePicker.Name = "Birthday_dateTimePicker";
            this.Birthday_dateTimePicker.Size = new System.Drawing.Size(236, 22);
            this.Birthday_dateTimePicker.TabIndex = 8;
            this.Birthday_dateTimePicker.Value = new System.DateTime(2020, 2, 7, 0, 0, 0, 0);
            // 
            // Occupation_textBox
            // 
            this.Occupation_textBox.Location = new System.Drawing.Point(19, 102);
            this.Occupation_textBox.Name = "Occupation_textBox";
            this.Occupation_textBox.Size = new System.Drawing.Size(237, 26);
            this.Occupation_textBox.TabIndex = 6;
            // 
            // Name_textBox
            // 
            this.Name_textBox.Location = new System.Drawing.Point(20, 56);
            this.Name_textBox.Name = "Name_textBox";
            this.Name_textBox.Size = new System.Drawing.Size(236, 26);
            this.Name_textBox.TabIndex = 5;
            // 
            // Residence_label
            // 
            this.Residence_label.AutoSize = true;
            this.Residence_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Residence_label.Location = new System.Drawing.Point(24, 209);
            this.Residence_label.Name = "Residence_label";
            this.Residence_label.Size = new System.Drawing.Size(78, 18);
            this.Residence_label.TabIndex = 4;
            this.Residence_label.Text = "Residence";
            this.Residence_label.UseWaitCursor = true;
            // 
            // Birthday_label
            // 
            this.Birthday_label.AutoSize = true;
            this.Birthday_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Birthday_label.Location = new System.Drawing.Point(21, 145);
            this.Birthday_label.Name = "Birthday_label";
            this.Birthday_label.Size = new System.Drawing.Size(61, 18);
            this.Birthday_label.TabIndex = 3;
            this.Birthday_label.Text = "Birthday";
            this.Birthday_label.UseWaitCursor = true;
            // 
            // Occupation_label
            // 
            this.Occupation_label.AutoSize = true;
            this.Occupation_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Occupation_label.Location = new System.Drawing.Point(21, 81);
            this.Occupation_label.Name = "Occupation_label";
            this.Occupation_label.Size = new System.Drawing.Size(84, 18);
            this.Occupation_label.TabIndex = 2;
            this.Occupation_label.Text = "Occupation";
            this.Occupation_label.UseWaitCursor = true;
            this.Occupation_label.Click += new System.EventHandler(this.RemoveResident_Click);
            // 
            // Name_label
            // 
            this.Name_label.AutoSize = true;
            this.Name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_label.Location = new System.Drawing.Point(21, 37);
            this.Name_label.Name = "Name_label";
            this.Name_label.Size = new System.Drawing.Size(48, 18);
            this.Name_label.TabIndex = 1;
            this.Name_label.Text = "Name";
            this.Name_label.UseWaitCursor = true;
            // 
            // AddNR_button
            // 
            this.AddNR_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.AddNR_button.Cursor = System.Windows.Forms.Cursors.Default;
            this.AddNR_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNR_button.Location = new System.Drawing.Point(205, 282);
            this.AddNR_button.Name = "AddNR_button";
            this.AddNR_button.Size = new System.Drawing.Size(75, 23);
            this.AddNR_button.TabIndex = 0;
            this.AddNR_button.Text = "Add";
            this.AddNR_button.UseVisualStyleBackColor = false;
            this.AddNR_button.Click += new System.EventHandler(this.AddNewResident_Click);
            // 
            // Output_label
            // 
            this.Output_label.AutoSize = true;
            this.Output_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Output_label.Location = new System.Drawing.Point(21, 447);
            this.Output_label.Name = "Output_label";
            this.Output_label.Size = new System.Drawing.Size(72, 24);
            this.Output_label.TabIndex = 10;
            this.Output_label.Text = "Output";
            // 
            // AddP_button
            // 
            this.AddP_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.AddP_button.Cursor = System.Windows.Forms.Cursors.Default;
            this.AddP_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddP_button.Location = new System.Drawing.Point(229, 241);
            this.AddP_button.Name = "AddP_button";
            this.AddP_button.Size = new System.Drawing.Size(75, 23);
            this.AddP_button.TabIndex = 1;
            this.AddP_button.Text = "Add";
            this.AddP_button.UseVisualStyleBackColor = false;
            this.AddP_button.Click += new System.EventHandler(this.AddProperty_Click);
            // 
            // SA_label
            // 
            this.SA_label.AutoSize = true;
            this.SA_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SA_label.Location = new System.Drawing.Point(21, 37);
            this.SA_label.Name = "SA_label";
            this.SA_label.Size = new System.Drawing.Size(105, 18);
            this.SA_label.TabIndex = 2;
            this.SA_label.Text = "Street Address";
            this.SA_label.UseWaitCursor = true;
            this.SA_label.Click += new System.EventHandler(this.RemoveResident_Click);
            // 
            // Apt_label
            // 
            this.Apt_label.AutoSize = true;
            this.Apt_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Apt_label.Location = new System.Drawing.Point(234, 36);
            this.Apt_label.Name = "Apt_label";
            this.Apt_label.Size = new System.Drawing.Size(45, 18);
            this.Apt_label.TabIndex = 3;
            this.Apt_label.Text = "Apt. #";
            this.Apt_label.UseWaitCursor = true;
            this.Apt_label.Click += new System.EventHandler(this.RemoveResident_Click);
            // 
            // SF_label
            // 
            this.SF_label.AutoSize = true;
            this.SF_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SF_label.Location = new System.Drawing.Point(18, 90);
            this.SF_label.Name = "SF_label";
            this.SF_label.Size = new System.Drawing.Size(114, 18);
            this.SF_label.TabIndex = 4;
            this.SF_label.Text = "Square Footage";
            this.SF_label.UseWaitCursor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Bedrooms";
            this.label4.UseWaitCursor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(126, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Baths";
            this.label5.UseWaitCursor = true;
            // 
            // AP_box
            // 
            this.AP_box.Controls.Add(this.Floors_NUD);
            this.AP_box.Controls.Add(this.Baths_NUD);
            this.AP_box.Controls.Add(this.Bedrooms_NUD);
            this.AP_box.Controls.Add(this.Squarefootage_NUD);
            this.AP_box.Controls.Add(this.Attached_checkbox);
            this.AP_box.Controls.Add(this.Garage_checkbox);
            this.AP_box.Controls.Add(this.Apartment_textBox);
            this.AP_box.Controls.Add(this.StreetAddr_textBox);
            this.AP_box.Controls.Add(this.label6);
            this.AP_box.Controls.Add(this.label5);
            this.AP_box.Controls.Add(this.label4);
            this.AP_box.Controls.Add(this.SF_label);
            this.AP_box.Controls.Add(this.Apt_label);
            this.AP_box.Controls.Add(this.SA_label);
            this.AP_box.Controls.Add(this.AddP_button);
            this.AP_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AP_box.Location = new System.Drawing.Point(298, 153);
            this.AP_box.Name = "AP_box";
            this.AP_box.Size = new System.Drawing.Size(304, 270);
            this.AP_box.TabIndex = 9;
            this.AP_box.TabStop = false;
            this.AP_box.Text = "Add Property";
            // 
            // Floors_NUD
            // 
            this.Floors_NUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Floors_NUD.Location = new System.Drawing.Point(216, 165);
            this.Floors_NUD.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Floors_NUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Floors_NUD.Name = "Floors_NUD";
            this.Floors_NUD.Size = new System.Drawing.Size(62, 24);
            this.Floors_NUD.TabIndex = 20;
            this.Floors_NUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Baths_NUD
            // 
            this.Baths_NUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Baths_NUD.Location = new System.Drawing.Point(129, 165);
            this.Baths_NUD.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Baths_NUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Baths_NUD.Name = "Baths_NUD";
            this.Baths_NUD.Size = new System.Drawing.Size(54, 24);
            this.Baths_NUD.TabIndex = 19;
            this.Baths_NUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Bedrooms_NUD
            // 
            this.Bedrooms_NUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bedrooms_NUD.Location = new System.Drawing.Point(21, 165);
            this.Bedrooms_NUD.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Bedrooms_NUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Bedrooms_NUD.Name = "Bedrooms_NUD";
            this.Bedrooms_NUD.Size = new System.Drawing.Size(81, 24);
            this.Bedrooms_NUD.TabIndex = 18;
            this.Bedrooms_NUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Squarefootage_NUD
            // 
            this.Squarefootage_NUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Squarefootage_NUD.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.Squarefootage_NUD.Location = new System.Drawing.Point(21, 111);
            this.Squarefootage_NUD.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.Squarefootage_NUD.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.Squarefootage_NUD.Name = "Squarefootage_NUD";
            this.Squarefootage_NUD.Size = new System.Drawing.Size(120, 24);
            this.Squarefootage_NUD.TabIndex = 17;
            this.Squarefootage_NUD.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // Attached_checkbox
            // 
            this.Attached_checkbox.AutoSize = true;
            this.Attached_checkbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Attached_checkbox.Location = new System.Drawing.Point(114, 210);
            this.Attached_checkbox.Name = "Attached_checkbox";
            this.Attached_checkbox.Size = new System.Drawing.Size(92, 22);
            this.Attached_checkbox.TabIndex = 16;
            this.Attached_checkbox.Text = "Attached?";
            this.Attached_checkbox.UseVisualStyleBackColor = true;
            this.Attached_checkbox.Visible = false;
            // 
            // Garage_checkbox
            // 
            this.Garage_checkbox.AutoSize = true;
            this.Garage_checkbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Garage_checkbox.Location = new System.Drawing.Point(24, 210);
            this.Garage_checkbox.Name = "Garage_checkbox";
            this.Garage_checkbox.Size = new System.Drawing.Size(84, 22);
            this.Garage_checkbox.TabIndex = 11;
            this.Garage_checkbox.Text = "Garage?";
            this.Garage_checkbox.UseVisualStyleBackColor = true;
            this.Garage_checkbox.CheckedChanged += new System.EventHandler(this.Garage_exists);
            this.Garage_checkbox.CheckStateChanged += new System.EventHandler(this.Garage_exists);
            // 
            // Apartment_textBox
            // 
            this.Apartment_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Apartment_textBox.Location = new System.Drawing.Point(237, 55);
            this.Apartment_textBox.Name = "Apartment_textBox";
            this.Apartment_textBox.Size = new System.Drawing.Size(41, 24);
            this.Apartment_textBox.TabIndex = 10;
            this.Apartment_textBox.TextChanged += new System.EventHandler(this.Is_apartment);
            // 
            // StreetAddr_textBox
            // 
            this.StreetAddr_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StreetAddr_textBox.Location = new System.Drawing.Point(21, 55);
            this.StreetAddr_textBox.Name = "StreetAddr_textBox";
            this.StreetAddr_textBox.Size = new System.Drawing.Size(210, 24);
            this.StreetAddr_textBox.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(213, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 18);
            this.label6.TabIndex = 7;
            this.label6.Text = "Floors";
            this.label6.UseWaitCursor = true;
            // 
            // Person_label
            // 
            this.Person_label.AutoSize = true;
            this.Person_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Person_label.Location = new System.Drawing.Point(608, 14);
            this.Person_label.Name = "Person_label";
            this.Person_label.Size = new System.Drawing.Size(65, 20);
            this.Person_label.TabIndex = 11;
            this.Person_label.Text = "Person";
            this.Person_label.Click += new System.EventHandler(this.RemoveResident_Click);
            // 
            // ResidenceFS_label
            // 
            this.ResidenceFS_label.AutoSize = true;
            this.ResidenceFS_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResidenceFS_label.Location = new System.Drawing.Point(785, 14);
            this.ResidenceFS_label.Name = "ResidenceFS_label";
            this.ResidenceFS_label.Size = new System.Drawing.Size(226, 20);
            this.ResidenceFS_label.TabIndex = 12;
            this.ResidenceFS_label.Text = "Residence ( * == For Sale )";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1017, 602);
            this.Controls.Add(this.ResidenceFS_label);
            this.Controls.Add(this.Person_label);
            this.Controls.Add(this.Output_label);
            this.Controls.Add(this.AP_box);
            this.Controls.Add(this.ANR_box);
            this.Controls.Add(this.Communities_box);
            this.Controls.Add(this.Output_rtbox);
            this.Controls.Add(this.Person_listbox);
            this.Controls.Add(this.RR);
            this.Controls.Add(this.AR);
            this.Controls.Add(this.BP);
            this.Controls.Add(this.TFS);
            this.Controls.Add(this.Residence_listbox);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Real Estate Mgmt";
            this.Communities_box.ResumeLayout(false);
            this.Communities_box.PerformLayout();
            this.ANR_box.ResumeLayout(false);
            this.ANR_box.PerformLayout();
            this.AP_box.ResumeLayout(false);
            this.AP_box.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Floors_NUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Baths_NUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bedrooms_NUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Squarefootage_NUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TFS;
        private System.Windows.Forms.Button BP;
        private System.Windows.Forms.Button AR;
        private System.Windows.Forms.Button RR;
        private System.Windows.Forms.ListBox Person_listbox;
        private System.Windows.Forms.RichTextBox Output_rtbox;
        private System.Windows.Forms.ListBox Residence_listbox;
        private System.Windows.Forms.GroupBox Communities_box;
        private System.Windows.Forms.RadioButton Sycamore_button;
        private System.Windows.Forms.RadioButton DeKalb_button;
        private System.Windows.Forms.GroupBox ANR_box;
        private System.Windows.Forms.Button AddNR_button;
        private System.Windows.Forms.Label Residence_label;
        private System.Windows.Forms.Label Birthday_label;
        private System.Windows.Forms.Label Occupation_label;
        private System.Windows.Forms.Label Name_label;
        private System.Windows.Forms.Label Output_label;
        private System.Windows.Forms.Button AddP_button;
        private System.Windows.Forms.Label SA_label;
        private System.Windows.Forms.Label Apt_label;
        private System.Windows.Forms.Label SF_label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox AP_box;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker Birthday_dateTimePicker;
        private System.Windows.Forms.TextBox Occupation_textBox;
        private System.Windows.Forms.TextBox Name_textBox;
        private System.Windows.Forms.TextBox Apartment_textBox;
        private System.Windows.Forms.TextBox StreetAddr_textBox;
        private System.Windows.Forms.CheckBox Garage_checkbox;
        private System.Windows.Forms.Label Person_label;
        private System.Windows.Forms.Label ResidenceFS_label;
        private System.Windows.Forms.ComboBox Residence_comboBox;
        private System.Windows.Forms.CheckBox Attached_checkbox;
        private System.Windows.Forms.NumericUpDown Squarefootage_NUD;
        private System.Windows.Forms.NumericUpDown Floors_NUD;
        private System.Windows.Forms.NumericUpDown Baths_NUD;
        private System.Windows.Forms.NumericUpDown Bedrooms_NUD;
    }
}

