namespace VitalHealth.Forms.Nurse
{
    partial class PatientsCheckUpForm
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            btn_editProfile = new Button();
            btn_logout = new Button();
            btn_todaysPatient = new Button();
            btn_checkupForm = new Button();
            lblNurse = new Label();
            lbl_nurseLastName = new Label();
            label1 = new Label();
            button3 = new Button();
            btn_pastRecords = new Button();
            btn_missedCheckups = new Button();
            btn_schedAndFee = new Button();
            panel2 = new Panel();
            label2 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            toolTip1 = new ToolTip(components);
            roundedPanel1 = new VitalHealth.CustomControls.RoundedPanel();
            txtB_reason = new RoundedMultilineTextBox();
            label9 = new Label();
            txtB_consultationFee = new RoundedTextBox();
            label8 = new Label();
            txtB_weight = new RoundedTextBox();
            txtB_heartRate = new RoundedTextBox();
            txtB_temperature = new RoundedTextBox();
            txtB_bloodPressure = new RoundedTextBox();
            label7 = new Label();
            label6 = new Label();
            cmbB_selectedDoctor = new RoundedComboBox();
            rdBttn_returningPatient = new SquareRadioButton();
            rdBttn_newPatient = new SquareRadioButton();
            label5 = new Label();
            txtB_contactNumberOfContactPerson = new RoundedTextBox();
            txtB_relationship = new RoundedTextBox();
            txtB_contactPersonName = new RoundedTextBox();
            label4 = new Label();
            dtP_dateOfBirth = new VitalHealth.CustomControls.RoundedDateTimePicker();
            txtB_contactNumber = new RoundedTextBox();
            cmbB_sex = new RoundedComboBox();
            cmbB_suffix = new RoundedComboBox();
            txtB_age = new RoundedTextBox();
            txtB_middlename = new RoundedTextBox();
            txtB_firstname = new RoundedTextBox();
            txtB_lastname = new RoundedTextBox();
            label3 = new Label();
            bttn_PrintQueuingNum = new RoundedButton();
            bttn_clearAllEntry = new RoundedButton();
            panel1.SuspendLayout();
            roundedPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btn_editProfile);
            panel1.Controls.Add(btn_logout);
            panel1.Controls.Add(btn_todaysPatient);
            panel1.Controls.Add(btn_checkupForm);
            panel1.Controls.Add(lblNurse);
            panel1.Controls.Add(lbl_nurseLastName);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(btn_pastRecords);
            panel1.Controls.Add(btn_missedCheckups);
            panel1.Controls.Add(btn_schedAndFee);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, -1);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(368, 1080);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // btn_editProfile
            // 
            btn_editProfile.BackColor = Color.White;
            btn_editProfile.FlatAppearance.BorderSize = 0;
            btn_editProfile.FlatStyle = FlatStyle.Flat;
            btn_editProfile.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            btn_editProfile.Image = Properties.Resources.EditProfileButtonIcon;
            btn_editProfile.ImageAlign = ContentAlignment.MiddleLeft;
            btn_editProfile.Location = new Point(1, 940);
            btn_editProfile.Margin = new Padding(3, 2, 3, 2);
            btn_editProfile.Name = "btn_editProfile";
            btn_editProfile.Padding = new Padding(30, 0, 0, 0);
            btn_editProfile.Size = new Size(366, 67);
            btn_editProfile.TabIndex = 7;
            btn_editProfile.Text = "Edit Profile";
            btn_editProfile.TextAlign = ContentAlignment.MiddleLeft;
            btn_editProfile.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_editProfile.UseVisualStyleBackColor = false;
            btn_editProfile.Click += btn_editProfile_Click;
            // 
            // btn_logout
            // 
            btn_logout.BackColor = Color.White;
            btn_logout.FlatAppearance.BorderSize = 0;
            btn_logout.FlatStyle = FlatStyle.Flat;
            btn_logout.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            btn_logout.Image = Properties.Resources.LogoutButtonIcon;
            btn_logout.ImageAlign = ContentAlignment.MiddleLeft;
            btn_logout.Location = new Point(1, 1012);
            btn_logout.Margin = new Padding(3, 2, 3, 2);
            btn_logout.Name = "btn_logout";
            btn_logout.Padding = new Padding(30, 0, 0, 0);
            btn_logout.Size = new Size(366, 67);
            btn_logout.TabIndex = 6;
            btn_logout.Text = "Logout";
            btn_logout.TextAlign = ContentAlignment.MiddleLeft;
            btn_logout.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_logout.UseVisualStyleBackColor = false;
            btn_logout.Click += btn_logout_Click;
            // 
            // btn_todaysPatient
            // 
            btn_todaysPatient.BackColor = Color.White;
            btn_todaysPatient.FlatAppearance.BorderSize = 0;
            btn_todaysPatient.FlatStyle = FlatStyle.Flat;
            btn_todaysPatient.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            btn_todaysPatient.Image = Properties.Resources.TodaysPatientsIcon;
            btn_todaysPatient.ImageAlign = ContentAlignment.MiddleLeft;
            btn_todaysPatient.Location = new Point(1, 199);
            btn_todaysPatient.Margin = new Padding(3, 2, 3, 2);
            btn_todaysPatient.Name = "btn_todaysPatient";
            btn_todaysPatient.Padding = new Padding(26, 0, 0, 0);
            btn_todaysPatient.Size = new Size(366, 67);
            btn_todaysPatient.TabIndex = 4;
            btn_todaysPatient.Text = "Today's Patients";
            btn_todaysPatient.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_todaysPatient.UseVisualStyleBackColor = false;
            btn_todaysPatient.Click += btn_todaysPatient_Click;
            // 
            // btn_checkupForm
            // 
            btn_checkupForm.BackColor = Color.DarkGray;
            btn_checkupForm.FlatAppearance.BorderSize = 0;
            btn_checkupForm.FlatStyle = FlatStyle.Flat;
            btn_checkupForm.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            btn_checkupForm.Image = Properties.Resources.PatientCheckupFormIcon;
            btn_checkupForm.Location = new Point(1, 130);
            btn_checkupForm.Margin = new Padding(3, 2, 3, 2);
            btn_checkupForm.Name = "btn_checkupForm";
            btn_checkupForm.Padding = new Padding(13, 0, 0, 0);
            btn_checkupForm.Size = new Size(366, 67);
            btn_checkupForm.TabIndex = 1;
            btn_checkupForm.Text = "Patient Checkup Form";
            btn_checkupForm.TextAlign = ContentAlignment.MiddleLeft;
            btn_checkupForm.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_checkupForm.UseVisualStyleBackColor = false;
            // 
            // lblNurse
            // 
            lblNurse.AutoSize = true;
            lblNurse.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNurse.ForeColor = Color.FromArgb(26, 117, 159);
            lblNurse.Location = new Point(111, 61);
            lblNurse.Name = "lblNurse";
            lblNurse.Size = new Size(52, 25);
            lblNurse.TabIndex = 3;
            lblNurse.Text = "Nurse";
            // 
            // lbl_nurseLastName
            // 
            lbl_nurseLastName.AutoSize = true;
            lbl_nurseLastName.Font = new Font("Zona Pro Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_nurseLastName.Location = new Point(182, 38);
            lbl_nurseLastName.Name = "lbl_nurseLastName";
            lbl_nurseLastName.Size = new Size(116, 24);
            lbl_nurseLastName.TabIndex = 2;
            lbl_nurseLastName.Text = "lastname";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Zona Pro Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(111, 38);
            label1.Name = "label1";
            label1.Size = new Size(73, 24);
            label1.TabIndex = 1;
            label1.Text = "Hello,";
            label1.Click += label1_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            button3.Image = Properties.Resources.PatientHistoryIcon;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(0, 270);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Padding = new Padding(26, 0, 0, 0);
            button3.RightToLeft = RightToLeft.No;
            button3.Size = new Size(366, 67);
            button3.TabIndex = 2;
            button3.Text = "Patient History";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.TextImageRelation = TextImageRelation.ImageBeforeText;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click_1;
            // 
            // btn_pastRecords
            // 
            btn_pastRecords.BackColor = Color.White;
            btn_pastRecords.FlatAppearance.BorderSize = 0;
            btn_pastRecords.FlatStyle = FlatStyle.Flat;
            btn_pastRecords.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            btn_pastRecords.Image = Properties.Resources.PastRecordsIcon;
            btn_pastRecords.Location = new Point(0, 340);
            btn_pastRecords.Margin = new Padding(3, 2, 3, 2);
            btn_pastRecords.Name = "btn_pastRecords";
            btn_pastRecords.Padding = new Padding(13, 0, 0, 0);
            btn_pastRecords.Size = new Size(366, 67);
            btn_pastRecords.TabIndex = 3;
            btn_pastRecords.Text = "Past Records";
            btn_pastRecords.TextAlign = ContentAlignment.MiddleLeft;
            btn_pastRecords.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_pastRecords.UseVisualStyleBackColor = false;
            btn_pastRecords.Click += btn_pastRecords_Click;
            // 
            // btn_missedCheckups
            // 
            btn_missedCheckups.BackColor = Color.White;
            btn_missedCheckups.FlatAppearance.BorderSize = 0;
            btn_missedCheckups.FlatStyle = FlatStyle.Flat;
            btn_missedCheckups.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            btn_missedCheckups.Image = Properties.Resources.MissedCheckupsIcon;
            btn_missedCheckups.Location = new Point(1, 411);
            btn_missedCheckups.Margin = new Padding(3, 2, 3, 2);
            btn_missedCheckups.Name = "btn_missedCheckups";
            btn_missedCheckups.Padding = new Padding(26, 0, 0, 0);
            btn_missedCheckups.Size = new Size(366, 67);
            btn_missedCheckups.TabIndex = 4;
            btn_missedCheckups.Text = "Missed Checkups";
            btn_missedCheckups.TextAlign = ContentAlignment.MiddleLeft;
            btn_missedCheckups.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_missedCheckups.UseVisualStyleBackColor = false;
            btn_missedCheckups.Click += btn_missedCheckups_Click;
            // 
            // btn_schedAndFee
            // 
            btn_schedAndFee.BackColor = Color.White;
            btn_schedAndFee.FlatAppearance.BorderSize = 0;
            btn_schedAndFee.FlatStyle = FlatStyle.Flat;
            btn_schedAndFee.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            btn_schedAndFee.Image = Properties.Resources.ScheduleAndFeeIcon;
            btn_schedAndFee.Location = new Point(0, 340);
            btn_schedAndFee.Margin = new Padding(3, 2, 3, 2);
            btn_schedAndFee.Name = "btn_schedAndFee";
            btn_schedAndFee.Size = new Size(366, 67);
            btn_schedAndFee.TabIndex = 5;
            btn_schedAndFee.Text = "Schedule and Fee";
            btn_schedAndFee.TextAlign = ContentAlignment.MiddleLeft;
            btn_schedAndFee.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_schedAndFee.UseVisualStyleBackColor = false;
            btn_schedAndFee.Click += btn_schedAndFee_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BackgroundImage = Properties.Resources.VitalHealth_Logo;
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Location = new Point(31, 27);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(75, 75);
            panel2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Zona Pro Bold", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(424, 46);
            label2.Name = "label2";
            label2.Size = new Size(278, 38);
            label2.TabIndex = 6;
            label2.Text = "Checkup Form";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // roundedPanel1
            // 
            roundedPanel1.BackColor = Color.White;
            roundedPanel1.BorderRadius = 30;
            roundedPanel1.Controls.Add(txtB_reason);
            roundedPanel1.Controls.Add(label9);
            roundedPanel1.Controls.Add(txtB_consultationFee);
            roundedPanel1.Controls.Add(label8);
            roundedPanel1.Controls.Add(txtB_weight);
            roundedPanel1.Controls.Add(txtB_heartRate);
            roundedPanel1.Controls.Add(txtB_temperature);
            roundedPanel1.Controls.Add(txtB_bloodPressure);
            roundedPanel1.Controls.Add(label7);
            roundedPanel1.Controls.Add(label6);
            roundedPanel1.Controls.Add(cmbB_selectedDoctor);
            roundedPanel1.Controls.Add(rdBttn_returningPatient);
            roundedPanel1.Controls.Add(rdBttn_newPatient);
            roundedPanel1.Controls.Add(label5);
            roundedPanel1.Controls.Add(txtB_contactNumberOfContactPerson);
            roundedPanel1.Controls.Add(txtB_relationship);
            roundedPanel1.Controls.Add(txtB_contactPersonName);
            roundedPanel1.Controls.Add(label4);
            roundedPanel1.Controls.Add(dtP_dateOfBirth);
            roundedPanel1.Controls.Add(txtB_contactNumber);
            roundedPanel1.Controls.Add(cmbB_sex);
            roundedPanel1.Controls.Add(cmbB_suffix);
            roundedPanel1.Controls.Add(txtB_age);
            roundedPanel1.Controls.Add(txtB_middlename);
            roundedPanel1.Controls.Add(txtB_firstname);
            roundedPanel1.Controls.Add(txtB_lastname);
            roundedPanel1.Controls.Add(label3);
            roundedPanel1.Location = new Point(424, 125);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Size = new Size(1443, 763);
            roundedPanel1.TabIndex = 7;
            roundedPanel1.Paint += roundedPanel1_Paint;
            // 
            // txtB_reason
            // 
            txtB_reason.BaseColor = Color.White;
            txtB_reason.BorderColor = Color.FromArgb(200, 200, 200);
            txtB_reason.FocusBorderColor = Color.FromArgb(100, 100, 100);
            txtB_reason.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtB_reason.HoverBorderColor = Color.FromArgb(170, 170, 170);
            txtB_reason.Location = new Point(33, 467);
            txtB_reason.Name = "txtB_reason";
            txtB_reason.PlaceholderText = "*Reason";
            txtB_reason.Size = new Size(631, 102);
            txtB_reason.TabIndex = 29;
            txtB_reason.TextColor = Color.Black;
            txtB_reason.TextPadding = new Padding(14, 12, 14, 12);
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(191, 123);
            label9.Name = "label9";
            label9.Size = new Size(117, 28);
            label9.TabIndex = 28;
            label9.Text = "*Date of Birth";
            // 
            // txtB_consultationFee
            // 
            txtB_consultationFee.BackColor = Color.White;
            txtB_consultationFee.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtB_consultationFee.Location = new Point(33, 627);
            txtB_consultationFee.Name = "txtB_consultationFee";
            txtB_consultationFee.Size = new Size(632, 40);
            txtB_consultationFee.TabIndex = 27;
            txtB_consultationFee.Theme = ControlTheme.Light;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(33, 587);
            label8.Name = "label8";
            label8.Size = new Size(1372, 20);
            label8.TabIndex = 26;
            label8.Text = "Walk-In/Consultation Fee____________________________________________________________________________________________________________________";
            // 
            // txtB_weight
            // 
            txtB_weight.BackColor = Color.White;
            txtB_weight.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtB_weight.Location = new Point(1071, 519);
            txtB_weight.Name = "txtB_weight";
            txtB_weight.PlaceholderText = "*Weight";
            txtB_weight.Size = new Size(348, 40);
            txtB_weight.TabIndex = 25;
            txtB_weight.Theme = ControlTheme.Light;
            // 
            // txtB_heartRate
            // 
            txtB_heartRate.BackColor = Color.White;
            txtB_heartRate.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtB_heartRate.Location = new Point(1071, 473);
            txtB_heartRate.Name = "txtB_heartRate";
            txtB_heartRate.PlaceholderText = "*Heart Rate";
            txtB_heartRate.Size = new Size(348, 40);
            txtB_heartRate.TabIndex = 24;
            txtB_heartRate.Theme = ControlTheme.Light;
            // 
            // txtB_temperature
            // 
            txtB_temperature.BackColor = Color.White;
            txtB_temperature.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtB_temperature.Location = new Point(698, 519);
            txtB_temperature.Name = "txtB_temperature";
            txtB_temperature.PlaceholderText = "*Temperature";
            txtB_temperature.Size = new Size(348, 40);
            txtB_temperature.TabIndex = 23;
            txtB_temperature.Theme = ControlTheme.Light;
            // 
            // txtB_bloodPressure
            // 
            txtB_bloodPressure.BackColor = Color.White;
            txtB_bloodPressure.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtB_bloodPressure.Location = new Point(698, 473);
            txtB_bloodPressure.Name = "txtB_bloodPressure";
            txtB_bloodPressure.PlaceholderText = "*Blood Pressure";
            txtB_bloodPressure.Size = new Size(348, 40);
            txtB_bloodPressure.TabIndex = 22;
            txtB_bloodPressure.Theme = ControlTheme.Light;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(698, 429);
            label7.Name = "label7";
            label7.Size = new Size(715, 20);
            label7.TabIndex = 21;
            label7.Text = "Vital Signs______________________________________________________________";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(31, 429);
            label6.Name = "label6";
            label6.Size = new Size(633, 20);
            label6.TabIndex = 19;
            label6.Text = "Reason for Checkup______________________________________________";
            // 
            // cmbB_selectedDoctor
            // 
            cmbB_selectedDoctor.BackColor = Color.White;
            cmbB_selectedDoctor.DrawMode = DrawMode.OwnerDrawFixed;
            cmbB_selectedDoctor.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbB_selectedDoctor.Font = new Font("Poppins", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbB_selectedDoctor.ForeColor = Color.Black;
            cmbB_selectedDoctor.FormattingEnabled = true;
            cmbB_selectedDoctor.IntegralHeight = false;
            cmbB_selectedDoctor.Location = new Point(414, 339);
            cmbB_selectedDoctor.Name = "cmbB_selectedDoctor";
            cmbB_selectedDoctor.PlaceholderText = "*Select a doctor";
            cmbB_selectedDoctor.Size = new Size(712, 37);
            cmbB_selectedDoctor.TabIndex = 18;
            cmbB_selectedDoctor.Theme = ControlTheme.Light;
            // 
            // rdBttn_returningPatient
            // 
            rdBttn_returningPatient.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdBttn_returningPatient.Label = "Returning Patient";
            rdBttn_returningPatient.Location = new Point(219, 342);
            rdBttn_returningPatient.Name = "rdBttn_returningPatient";
            rdBttn_returningPatient.Size = new Size(184, 28);
            rdBttn_returningPatient.TabIndex = 17;
            rdBttn_returningPatient.CheckedChanged += rdBttn_returningPatient_CheckedChanged;
            // 
            // rdBttn_newPatient
            // 
            rdBttn_newPatient.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdBttn_newPatient.Label = "New Patient";
            rdBttn_newPatient.Location = new Point(33, 342);
            rdBttn_newPatient.Name = "rdBttn_newPatient";
            rdBttn_newPatient.Size = new Size(150, 28);
            rdBttn_newPatient.TabIndex = 16;
            rdBttn_newPatient.CheckedChanged += rdBttn_newPatient_CheckedChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(29, 300);
            label5.Name = "label5";
            label5.Size = new Size(1390, 20);
            label5.TabIndex = 15;
            label5.Text = "Checkup Details_____________________________________________________________________________________________________________________________";
            // 
            // txtB_contactNumberOfContactPerson
            // 
            txtB_contactNumberOfContactPerson.BackColor = Color.White;
            txtB_contactNumberOfContactPerson.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtB_contactNumberOfContactPerson.Location = new Point(727, 225);
            txtB_contactNumberOfContactPerson.Name = "txtB_contactNumberOfContactPerson";
            txtB_contactNumberOfContactPerson.PlaceholderText = "*Contact Number (starts with 9)";
            txtB_contactNumberOfContactPerson.Size = new Size(408, 40);
            txtB_contactNumberOfContactPerson.TabIndex = 14;
            txtB_contactNumberOfContactPerson.Theme = ControlTheme.Light;
            txtB_contactNumberOfContactPerson.KeyPress += txtB_contactNumberOfContactPerson_KeyPress;
            // 
            // txtB_relationship
            // 
            txtB_relationship.BackColor = Color.White;
            txtB_relationship.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtB_relationship.Location = new Point(378, 225);
            txtB_relationship.Name = "txtB_relationship";
            txtB_relationship.PlaceholderText = "*Relationship";
            txtB_relationship.Size = new Size(343, 40);
            txtB_relationship.TabIndex = 13;
            txtB_relationship.Theme = ControlTheme.Light;
            // 
            // txtB_contactPersonName
            // 
            txtB_contactPersonName.BackColor = Color.White;
            txtB_contactPersonName.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtB_contactPersonName.Location = new Point(29, 225);
            txtB_contactPersonName.Name = "txtB_contactPersonName";
            txtB_contactPersonName.PlaceholderText = "*Name of Contact Person";
            txtB_contactPersonName.Size = new Size(343, 40);
            txtB_contactPersonName.TabIndex = 12;
            txtB_contactPersonName.Theme = ControlTheme.Light;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(29, 183);
            label4.Name = "label4";
            label4.Size = new Size(1396, 20);
            label4.TabIndex = 11;
            label4.Text = "Emergency Contact___________________________________________________________________________________________________________________________";
            // 
            // dtP_dateOfBirth
            // 
            dtP_dateOfBirth.BackColor = Color.White;
            dtP_dateOfBirth.BorderColor = Color.Gray;
            dtP_dateOfBirth.BorderRadius = 20;
            dtP_dateOfBirth.Location = new Point(313, 113);
            dtP_dateOfBirth.Name = "dtP_dateOfBirth";
            dtP_dateOfBirth.Size = new Size(275, 40);
            dtP_dateOfBirth.TabIndex = 10;
            dtP_dateOfBirth.Value = new DateTime(2026, 1, 1, 0, 0, 0, 0);
            dtP_dateOfBirth.ValueChanged += dtP_dateOfBirth_ValueChanged;
            // 
            // txtB_contactNumber
            // 
            txtB_contactNumber.BackColor = Color.White;
            txtB_contactNumber.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtB_contactNumber.Location = new Point(844, 115);
            txtB_contactNumber.Name = "txtB_contactNumber";
            txtB_contactNumber.PlaceholderText = "*Contact Number (starts with 9)";
            txtB_contactNumber.Size = new Size(351, 40);
            txtB_contactNumber.TabIndex = 9;
            txtB_contactNumber.Theme = ControlTheme.Light;
            txtB_contactNumber.KeyPress += txtB_contactNumber_KeyPress;
            // 
            // cmbB_sex
            // 
            cmbB_sex.BackColor = Color.White;
            cmbB_sex.DrawMode = DrawMode.OwnerDrawFixed;
            cmbB_sex.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbB_sex.Font = new Font("Poppins", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbB_sex.ForeColor = Color.Black;
            cmbB_sex.FormattingEnabled = true;
            cmbB_sex.IntegralHeight = false;
            cmbB_sex.Items.AddRange(new object[] { "Male", "Female" });
            cmbB_sex.Location = new Point(594, 116);
            cmbB_sex.Name = "cmbB_sex";
            cmbB_sex.PlaceholderText = "*Sex";
            cmbB_sex.Size = new Size(244, 37);
            cmbB_sex.TabIndex = 8;
            cmbB_sex.Theme = ControlTheme.Light;
            // 
            // cmbB_suffix
            // 
            cmbB_suffix.BackColor = Color.White;
            cmbB_suffix.DrawMode = DrawMode.OwnerDrawFixed;
            cmbB_suffix.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbB_suffix.Font = new Font("Poppins", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbB_suffix.ForeColor = Color.Black;
            cmbB_suffix.FormattingEnabled = true;
            cmbB_suffix.IntegralHeight = false;
            cmbB_suffix.Items.AddRange(new object[] { "N/A", "Jr. (Junior)", "Sr. (Senior)", "I", "II", "III", "IV", "V", "VI", "VII", "VIII" });
            cmbB_suffix.Location = new Point(951, 68);
            cmbB_suffix.Name = "cmbB_suffix";
            cmbB_suffix.PlaceholderText = "*Suffix";
            cmbB_suffix.Size = new Size(244, 37);
            cmbB_suffix.TabIndex = 5;
            cmbB_suffix.Theme = ControlTheme.Light;
            // 
            // txtB_age
            // 
            txtB_age.BackColor = Color.White;
            txtB_age.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtB_age.Location = new Point(29, 115);
            txtB_age.Name = "txtB_age";
            txtB_age.PlaceholderText = "Age";
            txtB_age.Size = new Size(153, 40);
            txtB_age.TabIndex = 4;
            txtB_age.Theme = ControlTheme.Light;
            // 
            // txtB_middlename
            // 
            txtB_middlename.BackColor = Color.White;
            txtB_middlename.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtB_middlename.Location = new Point(663, 68);
            txtB_middlename.Name = "txtB_middlename";
            txtB_middlename.PlaceholderText = "Middle Name";
            txtB_middlename.Size = new Size(271, 40);
            txtB_middlename.TabIndex = 3;
            txtB_middlename.Theme = ControlTheme.Light;
            // 
            // txtB_firstname
            // 
            txtB_firstname.BackColor = Color.White;
            txtB_firstname.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtB_firstname.Location = new Point(358, 68);
            txtB_firstname.Name = "txtB_firstname";
            txtB_firstname.PlaceholderText = "*First Name";
            txtB_firstname.Size = new Size(294, 40);
            txtB_firstname.TabIndex = 2;
            txtB_firstname.Theme = ControlTheme.Light;
            // 
            // txtB_lastname
            // 
            txtB_lastname.BackColor = Color.White;
            txtB_lastname.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtB_lastname.Location = new Point(29, 68);
            txtB_lastname.Name = "txtB_lastname";
            txtB_lastname.PlaceholderText = "*Last Name";
            txtB_lastname.Size = new Size(323, 40);
            txtB_lastname.TabIndex = 1;
            txtB_lastname.Theme = ControlTheme.Light;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(29, 26);
            label3.Name = "label3";
            label3.Size = new Size(1387, 20);
            label3.TabIndex = 0;
            label3.Text = "Patient Details______________________________________________________________________________________________________________________________";
            label3.Click += label3_Click;
            // 
            // bttn_PrintQueuingNum
            // 
            bttn_PrintQueuingNum.BackColor = Color.FromArgb(37, 147, 65);
            bttn_PrintQueuingNum.FlatAppearance.BorderSize = 0;
            bttn_PrintQueuingNum.FlatStyle = FlatStyle.Flat;
            bttn_PrintQueuingNum.Font = new Font("Zona Pro Bold", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bttn_PrintQueuingNum.ForeColor = Color.White;
            bttn_PrintQueuingNum.Location = new Point(424, 949);
            bttn_PrintQueuingNum.Name = "bttn_PrintQueuingNum";
            bttn_PrintQueuingNum.Size = new Size(443, 57);
            bttn_PrintQueuingNum.TabIndex = 8;
            bttn_PrintQueuingNum.Text = "PRINT QUEUING NUMBER";
            bttn_PrintQueuingNum.UseVisualStyleBackColor = false;
            bttn_PrintQueuingNum.Click += bttn_PrintQueuingNum_Click;
            // 
            // bttn_clearAllEntry
            // 
            bttn_clearAllEntry.BackColor = Color.FromArgb(26, 117, 159);
            bttn_clearAllEntry.FlatAppearance.BorderSize = 0;
            bttn_clearAllEntry.FlatStyle = FlatStyle.Flat;
            bttn_clearAllEntry.Font = new Font("Zona Pro Bold", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bttn_clearAllEntry.ForeColor = Color.White;
            bttn_clearAllEntry.Image = Properties.Resources.PatientHistoryIcon;
            bttn_clearAllEntry.ImageAlign = ContentAlignment.MiddleLeft;
            bttn_clearAllEntry.Location = new Point(1424, 949);
            bttn_clearAllEntry.Name = "bttn_clearAllEntry";
            bttn_clearAllEntry.Size = new Size(443, 57);
            bttn_clearAllEntry.TabIndex = 9;
            bttn_clearAllEntry.Text = "CLEAR ALL ENTRY";
            bttn_clearAllEntry.TextImageRelation = TextImageRelation.ImageBeforeText;
            bttn_clearAllEntry.UseVisualStyleBackColor = false;
            bttn_clearAllEntry.Click += bttn_clearAllEntry_Click;
            // 
            // PatientsCheckUpForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(229, 231, 231);
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1920, 1080);
            Controls.Add(bttn_clearAllEntry);
            Controls.Add(bttn_PrintQueuingNum);
            Controls.Add(roundedPanel1);
            Controls.Add(label2);
            Controls.Add(panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "PatientsCheckUpForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "PatientsCheckUpForm";
            Load += PatientsCheckUpForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            roundedPanel1.ResumeLayout(false);
            roundedPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Label lblNurse;
        private Label lbl_nurseLastName;
        private Button btn_checkupForm;
        private Button btn_todaysPatient;
        private Button button3;
        private Button btn_pastRecords;
        private Button btn_missedCheckups;
        private Button btn_schedAndFee;
        private Label label2;
        private ContextMenuStrip contextMenuStrip1;
        private ToolTip toolTip1;
        private CustomControls.RoundedPanel roundedPanel1;
        private Label label3;
        private RoundedTextBox txtB_middlename;
        private RoundedTextBox txtB_firstname;
        private RoundedTextBox txtB_lastname;
        private RoundedTextBox txtB_age;
        private RoundedComboBox cmbB_suffix;
        private RoundedComboBox cmbB_sex;
        private CustomControls.RoundedDateTimePicker dtP_dateOfBirth;
        private RoundedTextBox txtB_contactNumber;
        private Label label4;
        private Label label6;
        private RoundedComboBox cmbB_selectedDoctor;
        private SquareRadioButton rdBttn_returningPatient;
        private SquareRadioButton rdBttn_newPatient;
        private Label label5;
        private RoundedTextBox txtB_contactNumberOfContactPerson;
        private RoundedTextBox txtB_relationship;
        private RoundedTextBox txtB_weight;
        private RoundedTextBox txtB_heartRate;
        private RoundedTextBox txtB_temperature;
        private RoundedTextBox txtB_bloodPressure;
        private Label label7;
        private RoundedTextBox txtB_contactPersonName;
        private RoundedTextBox txtB_consultationFee;
        private Label label8;
        private RoundedButton bttn_PrintQueuingNum;
        private RoundedButton bttn_clearAllEntry;
        private Button btn_editProfile;
        private Button btn_logout;
        private Label label9;
        private RoundedMultilineTextBox txtB_reason;
    }
}