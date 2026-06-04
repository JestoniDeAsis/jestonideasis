namespace VitalHealth.Forms.Doctor
{
    partial class DoctorPatientPastRecord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorPatientPastRecord));
            panel1 = new Panel();
            btn_editProfile = new Button();
            btn_logout = new Button();
            btn_patientRecord = new Button();
            btn_assignedPatients = new Button();
            LblDoc = new Label();
            lbl_doctorLastName = new Label();
            label1 = new Label();
            btn_scheduleAndFee = new Button();
            panel2 = new Panel();
            label2 = new Label();
            txtBox_search = new RoundedTextBox();
            btn_search = new RoundedButton();
            pastRecordDataGrid = new VitalHealth.CustomControls.RoundedDataGridView();
            btn_viewRecord = new RoundedButton();
            panel3 = new Panel();
            label3 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btn_editProfile);
            panel1.Controls.Add(btn_logout);
            panel1.Controls.Add(btn_patientRecord);
            panel1.Controls.Add(btn_assignedPatients);
            panel1.Controls.Add(LblDoc);
            panel1.Controls.Add(lbl_doctorLastName);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btn_scheduleAndFee);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(368, 1080);
            panel1.TabIndex = 3;
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
            // btn_patientRecord
            // 
            btn_patientRecord.BackColor = Color.DarkGray;
            btn_patientRecord.FlatAppearance.BorderSize = 0;
            btn_patientRecord.FlatStyle = FlatStyle.Flat;
            btn_patientRecord.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            btn_patientRecord.Image = (Image)resources.GetObject("btn_patientRecord.Image");
            btn_patientRecord.ImageAlign = ContentAlignment.MiddleLeft;
            btn_patientRecord.Location = new Point(-1, 199);
            btn_patientRecord.Margin = new Padding(3, 2, 3, 2);
            btn_patientRecord.Name = "btn_patientRecord";
            btn_patientRecord.Padding = new Padding(26, 0, 0, 0);
            btn_patientRecord.Size = new Size(366, 67);
            btn_patientRecord.TabIndex = 4;
            btn_patientRecord.Text = "Patient's Record";
            btn_patientRecord.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_patientRecord.UseVisualStyleBackColor = false;
            // 
            // btn_assignedPatients
            // 
            btn_assignedPatients.BackColor = Color.White;
            btn_assignedPatients.FlatAppearance.BorderSize = 0;
            btn_assignedPatients.FlatStyle = FlatStyle.Flat;
            btn_assignedPatients.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            btn_assignedPatients.Image = (Image)resources.GetObject("btn_assignedPatients.Image");
            btn_assignedPatients.Location = new Point(-23, 130);
            btn_assignedPatients.Margin = new Padding(3, 2, 3, 2);
            btn_assignedPatients.Name = "btn_assignedPatients";
            btn_assignedPatients.Padding = new Padding(13, 0, 0, 0);
            btn_assignedPatients.Size = new Size(390, 67);
            btn_assignedPatients.TabIndex = 1;
            btn_assignedPatients.Text = "Assigned Patients";
            btn_assignedPatients.TextAlign = ContentAlignment.MiddleLeft;
            btn_assignedPatients.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_assignedPatients.UseVisualStyleBackColor = false;
            btn_assignedPatients.Click += btn_assignedPatients_Click;
            // 
            // LblDoc
            // 
            LblDoc.AutoSize = true;
            LblDoc.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblDoc.ForeColor = Color.FromArgb(26, 117, 159);
            LblDoc.Location = new Point(111, 61);
            LblDoc.Name = "LblDoc";
            LblDoc.Size = new Size(50, 17);
            LblDoc.TabIndex = 3;
            LblDoc.Text = "Doctor";
            // 
            // lbl_doctorLastName
            // 
            lbl_doctorLastName.AutoSize = true;
            lbl_doctorLastName.Font = new Font("Zona Pro Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_doctorLastName.Location = new Point(182, 38);
            lbl_doctorLastName.Name = "lbl_doctorLastName";
            lbl_doctorLastName.Size = new Size(116, 24);
            lbl_doctorLastName.TabIndex = 2;
            lbl_doctorLastName.Text = "lastname";
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
            // btn_scheduleAndFee
            // 
            btn_scheduleAndFee.BackColor = Color.White;
            btn_scheduleAndFee.FlatAppearance.BorderSize = 0;
            btn_scheduleAndFee.FlatStyle = FlatStyle.Flat;
            btn_scheduleAndFee.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            btn_scheduleAndFee.Image = (Image)resources.GetObject("btn_scheduleAndFee.Image");
            btn_scheduleAndFee.ImageAlign = ContentAlignment.MiddleLeft;
            btn_scheduleAndFee.Location = new Point(0, 270);
            btn_scheduleAndFee.Margin = new Padding(3, 2, 3, 2);
            btn_scheduleAndFee.Name = "btn_scheduleAndFee";
            btn_scheduleAndFee.Padding = new Padding(26, 0, 0, 0);
            btn_scheduleAndFee.RightToLeft = RightToLeft.No;
            btn_scheduleAndFee.Size = new Size(366, 67);
            btn_scheduleAndFee.TabIndex = 2;
            btn_scheduleAndFee.Text = "Schedule and Fee";
            btn_scheduleAndFee.TextAlign = ContentAlignment.MiddleLeft;
            btn_scheduleAndFee.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_scheduleAndFee.UseVisualStyleBackColor = false;
            btn_scheduleAndFee.Click += btn_scheduleAndFee_Click;
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
            label2.Location = new Point(418, 47);
            label2.Name = "label2";
            label2.Size = new Size(312, 38);
            label2.TabIndex = 9;
            label2.Text = "Patient's Record";
            // 
            // txtBox_search
            // 
            txtBox_search.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBox_search.Location = new Point(418, 134);
            txtBox_search.Name = "txtBox_search";
            txtBox_search.Size = new Size(379, 54);
            txtBox_search.TabIndex = 11;
            txtBox_search.Theme = ControlTheme.Light;
            // 
            // btn_search
            // 
            btn_search.BackColor = Color.FromArgb(22, 138, 173);
            btn_search.FlatAppearance.BorderSize = 0;
            btn_search.FlatStyle = FlatStyle.Flat;
            btn_search.Font = new Font("Zona Pro Bold", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_search.ForeColor = Color.White;
            btn_search.Location = new Point(817, 136);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(126, 54);
            btn_search.TabIndex = 12;
            btn_search.Text = "Search";
            btn_search.UseVisualStyleBackColor = false;
            btn_search.Click += btn_search_Click;
            // 
            // pastRecordDataGrid
            // 
            pastRecordDataGrid.BackColor = Color.White;
            pastRecordDataGrid.BorderColor = Color.Gray;
            pastRecordDataGrid.BorderRadius = 20;
            pastRecordDataGrid.BorderThickness = 2;
            pastRecordDataGrid.Location = new Point(419, 210);
            pastRecordDataGrid.Name = "pastRecordDataGrid";
            pastRecordDataGrid.Size = new Size(1449, 741);
            pastRecordDataGrid.TabIndex = 13;
            // 
            // btn_viewRecord
            // 
            btn_viewRecord.BackColor = Color.FromArgb(74, 214, 109);
            btn_viewRecord.FlatAppearance.BorderSize = 0;
            btn_viewRecord.FlatStyle = FlatStyle.Flat;
            btn_viewRecord.Font = new Font("Zona Pro Bold", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_viewRecord.ForeColor = Color.Wheat;
            btn_viewRecord.Location = new Point(1548, 965);
            btn_viewRecord.Name = "btn_viewRecord";
            btn_viewRecord.Size = new Size(305, 57);
            btn_viewRecord.TabIndex = 16;
            btn_viewRecord.Text = "VIEW RECORD";
            btn_viewRecord.UseVisualStyleBackColor = false;
            btn_viewRecord.Click += btn_viewRecord_Click;
            // 
            // panel3
            // 
            panel3.BackgroundImage = Properties.Resources.VitalHealth_Logo;
            panel3.BackgroundImageLayout = ImageLayout.Zoom;
            panel3.Location = new Point(1761, 27);
            panel3.Name = "panel3";
            panel3.Size = new Size(106, 100);
            panel3.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Zona Pro Bold", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonShadow;
            label3.Location = new Point(424, 88);
            label3.Name = "label3";
            label3.Size = new Size(394, 42);
            label3.TabIndex = 19;
            label3.Text = "Displays past patient checkup records.\r\n\r\n";
            // 
            // DoctorPatientPastRecord
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1920, 1080);
            ControlBox = false;
            Controls.Add(label3);
            Controls.Add(panel3);
            Controls.Add(btn_viewRecord);
            Controls.Add(pastRecordDataGrid);
            Controls.Add(btn_search);
            Controls.Add(txtBox_search);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DoctorPatientPastRecord";
            StartPosition = FormStartPosition.CenterParent;
            Text = "PatientPastRecord";
            Load += PatientPastRecord_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btn_editProfile;
        private Button btn_logout;
        private Button btn_patientRecord;
        private Button btn_assignedPatients;
        private Label LblDoc;
        private Label lbl_doctorLastName;
        private Label label1;
        private Button btn_scheduleAndFee;
        private Panel panel2;
        private Label label2;
        private RoundedTextBox txtBox_search;
        private RoundedButton btn_search;
        private CustomControls.RoundedDataGridView pastRecordDataGrid;
        private RoundedButton btn_viewRecord;
        private Panel panel3;
        private Label label3;
    }
}