using System.Reflection.Metadata;

namespace VitalHealth.Forms.Nurse
{
    partial class TodaysPatients
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

        private void InitializeComponent()
        {
            panel1 = new Panel();
            btn_editProfile = new Button();
            btn_logout = new Button();
            btn_todaysPatient = new Button();
            btn_checkupForm = new Button();
            LblDoc = new Label();
            lbl_nurseLastName = new Label();
            label1 = new Label();
            btn_patientHistory = new Button();
            btn_pastRecords = new Button();
            btn_schedAndFee = new Button();
            panel2 = new Panel();
            btn_missedCheckups = new Button();
            label2 = new Label();
            lbl_patientsInLine = new Label();
            bttn_Search = new RoundedButton();
            txtB_searchBar = new RoundedTextBox();
            cmbB_filterSpecialty = new RoundedComboBox();
            dtgView_todaysPatients = new VitalHealth.CustomControls.RoundedDataGridView();
            bttn_callQueuingNumber = new RoundedButton();
            bttn_markIn = new RoundedButton();
            bttn_edit = new RoundedButton();
            bttn_cancel = new RoundedButton();
            bttn_reload = new RoundedButton();
            bttn_paid = new RoundedButton();
            nextArrowDG = new PictureBox();
            backArrowDG = new PictureBox();
            page1DG = new Label();
            page2DG = new Label();
            page5DG = new Label();
            page4DG = new Label();
            page3DG = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nextArrowDG).BeginInit();
            ((System.ComponentModel.ISupportInitialize)backArrowDG).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btn_editProfile);
            panel1.Controls.Add(btn_logout);
            panel1.Controls.Add(btn_todaysPatient);
            panel1.Controls.Add(btn_checkupForm);
            panel1.Controls.Add(LblDoc);
            panel1.Controls.Add(lbl_nurseLastName);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btn_patientHistory);
            panel1.Controls.Add(btn_pastRecords);
            panel1.Controls.Add(btn_schedAndFee);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(btn_missedCheckups);
            panel1.Location = new Point(0, -1);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(368, 1080);
            panel1.TabIndex = 1;
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
            btn_todaysPatient.BackColor = Color.DarkGray;
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
            // 
            // btn_checkupForm
            // 
            btn_checkupForm.BackColor = Color.White;
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
            btn_checkupForm.Click += btn_checkupForm_Click;
            // 
            // LblDoc
            // 
            LblDoc.AutoSize = true;
            LblDoc.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblDoc.ForeColor = Color.FromArgb(26, 117, 159);
            LblDoc.Location = new Point(111, 61);
            LblDoc.Name = "LblDoc";
            LblDoc.Size = new Size(52, 25);
            LblDoc.TabIndex = 3;
            LblDoc.Text = "Nurse";
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
            // 
            // btn_patientHistory
            // 
            btn_patientHistory.BackColor = Color.White;
            btn_patientHistory.FlatAppearance.BorderSize = 0;
            btn_patientHistory.FlatStyle = FlatStyle.Flat;
            btn_patientHistory.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            btn_patientHistory.Image = Properties.Resources.PatientHistoryIcon;
            btn_patientHistory.ImageAlign = ContentAlignment.MiddleLeft;
            btn_patientHistory.Location = new Point(0, 270);
            btn_patientHistory.Margin = new Padding(3, 2, 3, 2);
            btn_patientHistory.Name = "btn_patientHistory";
            btn_patientHistory.Padding = new Padding(26, 0, 0, 0);
            btn_patientHistory.RightToLeft = RightToLeft.No;
            btn_patientHistory.Size = new Size(366, 67);
            btn_patientHistory.TabIndex = 2;
            btn_patientHistory.Text = "Patient History             ";
            btn_patientHistory.TextAlign = ContentAlignment.MiddleLeft;
            btn_patientHistory.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_patientHistory.UseVisualStyleBackColor = false;
            btn_patientHistory.Click += button3_Click;
            // 
            // btn_pastRecords
            // 
            btn_pastRecords.BackColor = Color.White;
            btn_pastRecords.FlatAppearance.BorderSize = 0;
            btn_pastRecords.FlatStyle = FlatStyle.Flat;
            btn_pastRecords.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            btn_pastRecords.Image = Properties.Resources.PastRecordsIcon;
            btn_pastRecords.Location = new Point(0, 341);
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
            // btn_schedAndFee
            // 
            btn_schedAndFee.BackColor = Color.White;
            btn_schedAndFee.FlatAppearance.BorderSize = 0;
            btn_schedAndFee.FlatStyle = FlatStyle.Flat;
            btn_schedAndFee.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            btn_schedAndFee.Image = Properties.Resources.ScheduleAndFeeIcon;
            btn_schedAndFee.Location = new Point(-4, 341);
            btn_schedAndFee.Margin = new Padding(3, 2, 3, 2);
            btn_schedAndFee.Name = "btn_schedAndFee";
            btn_schedAndFee.Size = new Size(372, 67);
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
            // btn_missedCheckups
            // 
            btn_missedCheckups.BackColor = Color.White;
            btn_missedCheckups.FlatAppearance.BorderSize = 0;
            btn_missedCheckups.FlatStyle = FlatStyle.Flat;
            btn_missedCheckups.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            btn_missedCheckups.Image = Properties.Resources.MissedCheckupsIcon;
            btn_missedCheckups.Location = new Point(0, 412);
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Zona Pro Bold", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(424, 46);
            label2.Name = "label2";
            label2.Size = new Size(302, 38);
            label2.TabIndex = 7;
            label2.Text = "Patients in Line:";
            label2.Click += label2_Click;
            // 
            // lbl_patientsInLine
            // 
            lbl_patientsInLine.AutoSize = true;
            lbl_patientsInLine.Font = new Font("Zona Pro Bold", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_patientsInLine.ForeColor = Color.FromArgb(22, 138, 173);
            lbl_patientsInLine.Location = new Point(732, 45);
            lbl_patientsInLine.Name = "lbl_patientsInLine";
            lbl_patientsInLine.Size = new Size(71, 38);
            lbl_patientsInLine.TabIndex = 8;
            lbl_patientsInLine.Text = "NN";
            // 
            // bttn_Search
            // 
            bttn_Search.BackColor = Color.FromArgb(22, 138, 173);
            bttn_Search.FlatAppearance.BorderSize = 0;
            bttn_Search.FlatStyle = FlatStyle.Flat;
            bttn_Search.Font = new Font("Zona Pro Bold", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bttn_Search.ForeColor = Color.White;
            bttn_Search.Location = new Point(811, 108);
            bttn_Search.Name = "bttn_Search";
            bttn_Search.Size = new Size(126, 54);
            bttn_Search.TabIndex = 9;
            bttn_Search.Text = "Search";
            bttn_Search.UseVisualStyleBackColor = false;
            // 
            // txtB_searchBar
            // 
            txtB_searchBar.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtB_searchBar.Location = new Point(424, 108);
            txtB_searchBar.Name = "txtB_searchBar";
            txtB_searchBar.PlaceholderText = "Search Patient's Name";
            txtB_searchBar.Size = new Size(379, 54);
            txtB_searchBar.TabIndex = 10;
            txtB_searchBar.Theme = ControlTheme.Light;
            txtB_searchBar.Load += txtB_searchBar_Load;
            // 
            // cmbB_filterSpecialty
            // 
            cmbB_filterSpecialty.BackColor = Color.White;
            cmbB_filterSpecialty.DrawMode = DrawMode.OwnerDrawFixed;
            cmbB_filterSpecialty.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbB_filterSpecialty.Font = new Font("Poppins", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbB_filterSpecialty.ForeColor = Color.Black;
            cmbB_filterSpecialty.FormattingEnabled = true;
            cmbB_filterSpecialty.IntegralHeight = false;
            cmbB_filterSpecialty.Items.AddRange(new object[] { "General Medicine", "Pediatrics", "OB-Gyne", "Internal Medicine", "Orthopedics", "Dermatology" });
            cmbB_filterSpecialty.Location = new Point(1557, 123);
            cmbB_filterSpecialty.Name = "cmbB_filterSpecialty";
            cmbB_filterSpecialty.PlaceholderText = "Filter by Specialist";
            cmbB_filterSpecialty.Size = new Size(316, 40);
            cmbB_filterSpecialty.TabIndex = 11;
            cmbB_filterSpecialty.Theme = ControlTheme.Light;
            cmbB_filterSpecialty.SelectedIndexChanged += cmbB_filterSpecialty_SelectedIndexChanged;
            // 
            // dtgView_todaysPatients
            // 
            dtgView_todaysPatients.BackColor = Color.White;
            dtgView_todaysPatients.BorderColor = Color.Gray;
            dtgView_todaysPatients.BorderRadius = 20;
            dtgView_todaysPatients.BorderThickness = 2;
            dtgView_todaysPatients.Font = new Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtgView_todaysPatients.Location = new Point(424, 225);
            dtgView_todaysPatients.Name = "dtgView_todaysPatients";
            dtgView_todaysPatients.Size = new Size(1449, 469);
            dtgView_todaysPatients.TabIndex = 12;
            dtgView_todaysPatients.Load += roundedDataGridView_Load;
            // 
            // bttn_callQueuingNumber
            // 
            bttn_callQueuingNumber.BackColor = Color.FromArgb(30, 136, 229);
            bttn_callQueuingNumber.FlatAppearance.BorderSize = 0;
            bttn_callQueuingNumber.FlatStyle = FlatStyle.Flat;
            bttn_callQueuingNumber.Font = new Font("Zona Pro Bold", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bttn_callQueuingNumber.ForeColor = Color.White;
            bttn_callQueuingNumber.Location = new Point(418, 836);
            bttn_callQueuingNumber.Name = "bttn_callQueuingNumber";
            bttn_callQueuingNumber.Size = new Size(443, 57);
            bttn_callQueuingNumber.TabIndex = 13;
            bttn_callQueuingNumber.Text = "CALL QUEUING NUMBER";
            bttn_callQueuingNumber.UseVisualStyleBackColor = false;
            bttn_callQueuingNumber.Click += bttn_callQueuingNumber_Click;
            // 
            // bttn_markIn
            // 
            bttn_markIn.BackColor = Color.FromArgb(150, 182, 224);
            bttn_markIn.FlatAppearance.BorderSize = 0;
            bttn_markIn.FlatStyle = FlatStyle.Flat;
            bttn_markIn.Font = new Font("Zona Pro Bold", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bttn_markIn.ForeColor = Color.White;
            bttn_markIn.Location = new Point(867, 836);
            bttn_markIn.Name = "bttn_markIn";
            bttn_markIn.Size = new Size(242, 57);
            bttn_markIn.TabIndex = 14;
            bttn_markIn.Text = "MARK IN";
            bttn_markIn.UseVisualStyleBackColor = false;
            bttn_markIn.Visible = false;
            bttn_markIn.Click += bttn_markIn_Click;
            // 
            // bttn_edit
            // 
            bttn_edit.BackColor = Color.FromArgb(229, 163, 56);
            bttn_edit.FlatAppearance.BorderSize = 0;
            bttn_edit.FlatStyle = FlatStyle.Flat;
            bttn_edit.Font = new Font("Zona Pro Bold", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bttn_edit.ForeColor = Color.White;
            bttn_edit.Location = new Point(1377, 836);
            bttn_edit.Name = "bttn_edit";
            bttn_edit.Size = new Size(242, 57);
            bttn_edit.TabIndex = 15;
            bttn_edit.Text = "EDIT";
            bttn_edit.UseVisualStyleBackColor = false;
            bttn_edit.Click += bttn_edit_Click;
            // 
            // bttn_cancel
            // 
            bttn_cancel.BackColor = Color.FromArgb(211, 47, 47);
            bttn_cancel.FlatAppearance.BorderSize = 0;
            bttn_cancel.FlatStyle = FlatStyle.Flat;
            bttn_cancel.Font = new Font("Zona Pro Bold", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bttn_cancel.ForeColor = Color.White;
            bttn_cancel.Location = new Point(1625, 836);
            bttn_cancel.Name = "bttn_cancel";
            bttn_cancel.Size = new Size(242, 57);
            bttn_cancel.TabIndex = 16;
            bttn_cancel.Text = "CANCEL";
            bttn_cancel.UseVisualStyleBackColor = false;
            bttn_cancel.Visible = false;
            bttn_cancel.Click += bttn_cancel_Click;
            // 
            // bttn_reload
            // 
            bttn_reload.BackColor = Color.FromArgb(115, 185, 206);
            bttn_reload.FlatAppearance.BorderSize = 0;
            bttn_reload.FlatStyle = FlatStyle.Flat;
            bttn_reload.Font = new Font("Zona Pro Bold", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bttn_reload.ForeColor = Color.Black;
            bttn_reload.Location = new Point(943, 108);
            bttn_reload.Name = "bttn_reload";
            bttn_reload.Size = new Size(138, 55);
            bttn_reload.TabIndex = 17;
            bttn_reload.Text = "Reload";
            bttn_reload.UseVisualStyleBackColor = false;
            bttn_reload.Click += roundedButton1_Click;
            // 
            // bttn_paid
            // 
            bttn_paid.BackColor = Color.Green;
            bttn_paid.FlatAppearance.BorderSize = 0;
            bttn_paid.FlatStyle = FlatStyle.Flat;
            bttn_paid.Font = new Font("Zona Pro Bold", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bttn_paid.ForeColor = Color.White;
            bttn_paid.Location = new Point(1115, 836);
            bttn_paid.Name = "bttn_paid";
            bttn_paid.Size = new Size(256, 57);
            bttn_paid.TabIndex = 18;
            bttn_paid.Text = "PAID";
            bttn_paid.UseVisualStyleBackColor = false;
            bttn_paid.Click += bttn_paid_Click;
            // 
            // nextArrowDG
            // 
            nextArrowDG.Image = Properties.Resources.nextArrowDG;
            nextArrowDG.Location = new Point(1292, 724);
            nextArrowDG.Name = "nextArrowDG";
            nextArrowDG.Size = new Size(33, 33);
            nextArrowDG.SizeMode = PictureBoxSizeMode.StretchImage;
            nextArrowDG.TabIndex = 32;
            nextArrowDG.TabStop = false;
            // 
            // backArrowDG
            // 
            backArrowDG.Image = Properties.Resources.backArrowDG;
            backArrowDG.Location = new Point(1101, 724);
            backArrowDG.Name = "backArrowDG";
            backArrowDG.Size = new Size(33, 33);
            backArrowDG.SizeMode = PictureBoxSizeMode.StretchImage;
            backArrowDG.TabIndex = 31;
            backArrowDG.TabStop = false;
            // 
            // page1DG
            // 
            page1DG.AutoSize = true;
            page1DG.Font = new Font("Zona Pro Bold", 15.7499981F);
            page1DG.Location = new Point(1141, 730);
            page1DG.Name = "page1DG";
            page1DG.Size = new Size(19, 23);
            page1DG.TabIndex = 30;
            page1DG.Text = "1";
            // 
            // page2DG
            // 
            page2DG.AutoSize = true;
            page2DG.Font = new Font("Zona Pro Bold", 15.7499981F);
            page2DG.Location = new Point(1171, 730);
            page2DG.Name = "page2DG";
            page2DG.Size = new Size(23, 23);
            page2DG.TabIndex = 29;
            page2DG.Text = "2";
            // 
            // page5DG
            // 
            page5DG.AutoSize = true;
            page5DG.Font = new Font("Zona Pro Bold", 15.7499981F);
            page5DG.Location = new Point(1261, 730);
            page5DG.Name = "page5DG";
            page5DG.Size = new Size(23, 23);
            page5DG.TabIndex = 28;
            page5DG.Text = "5";
            // 
            // page4DG
            // 
            page4DG.AutoSize = true;
            page4DG.Font = new Font("Zona Pro Bold", 15.7499981F);
            page4DG.Location = new Point(1231, 730);
            page4DG.Name = "page4DG";
            page4DG.Size = new Size(24, 23);
            page4DG.TabIndex = 27;
            page4DG.Text = "4";
            // 
            // page3DG
            // 
            page3DG.AutoSize = true;
            page3DG.Font = new Font("Zona Pro Bold", 15.7499981F);
            page3DG.Location = new Point(1201, 730);
            page3DG.Name = "page3DG";
            page3DG.Size = new Size(23, 23);
            page3DG.TabIndex = 26;
            page3DG.Text = "3";
            // 
            // TodaysPatients
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1920, 1080);
            Controls.Add(nextArrowDG);
            Controls.Add(backArrowDG);
            Controls.Add(page1DG);
            Controls.Add(page2DG);
            Controls.Add(page5DG);
            Controls.Add(page4DG);
            Controls.Add(page3DG);
            Controls.Add(bttn_paid);
            Controls.Add(bttn_reload);
            Controls.Add(bttn_cancel);
            Controls.Add(bttn_edit);
            Controls.Add(bttn_markIn);
            Controls.Add(bttn_callQueuingNumber);
            Controls.Add(dtgView_todaysPatients);
            Controls.Add(cmbB_filterSpecialty);
            Controls.Add(txtB_searchBar);
            Controls.Add(bttn_Search);
            Controls.Add(lbl_patientsInLine);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TodaysPatients";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Form1";
            Load += TodaysPatients_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nextArrowDG).EndInit();
            ((System.ComponentModel.ISupportInitialize)backArrowDG).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btn_editProfile;
        private Button btn_logout;
        private Button btn_todaysPatient;
        private Button btn_checkupForm;
        private Label LblDoc;
        private Label lbl_nurseLastName;
        private Label label1;
        private Button btn_patientHistory;
        private Button btn_pastRecords;
        private Button btn_missedCheckups;
        private Button btn_schedAndFee;
        private Panel panel2;
        private Label label2;
        private Label lbl_patientsInLine;
        private RoundedButton bttn_Search;
        private RoundedTextBox txtB_searchBar;
        private RoundedComboBox cmbB_filterSpecialty;
        private CustomControls.RoundedDataGridView dtgView_todaysPatients;
        private RoundedButton bttn_callQueuingNumber;
        private RoundedButton bttn_markIn;
        private RoundedButton bttn_edit;
        private RoundedButton bttn_cancel;
        private RoundedButton bttn_reload;
        private RoundedButton bttn_paid;
        private PictureBox nextArrowDG;
        private PictureBox backArrowDG;
        private Label page1DG;
        private Label page2DG;
        private Label page5DG;
        private Label page4DG;
        private Label page3DG;
    }
}