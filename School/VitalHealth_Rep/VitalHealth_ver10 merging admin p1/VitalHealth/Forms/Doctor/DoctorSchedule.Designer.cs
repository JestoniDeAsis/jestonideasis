namespace VitalHealth.Forms.Doctor
{
    partial class DoctorSchedule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorSchedule));
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
            label3 = new Label();
            panel3 = new Panel();
            label4 = new Label();
            panel4 = new Panel();
            label5 = new Label();
            roundedDataGridView1 = new VitalHealth.CustomControls.RoundedDataGridView();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
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
            panel1.TabIndex = 4;
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
            btn_patientRecord.BackColor = Color.White;
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
            btn_patientRecord.Click += btn_patientRecord_Click;
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
            btn_scheduleAndFee.BackColor = Color.DarkGray;
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
            label2.Location = new Point(420, 47);
            label2.Name = "label2";
            label2.Size = new Size(337, 38);
            label2.TabIndex = 10;
            label2.Text = "Schedule and Fee";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Zona Pro Bold", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonShadow;
            label3.Location = new Point(428, 90);
            label3.Name = "label3";
            label3.Size = new Size(709, 42);
            label3.TabIndex = 11;
            label3.Text = "Displays the daily schedule of the doctors and checkup fee in the clinic\r\n\r\n";
            // 
            // panel3
            // 
            panel3.BackColor = Color.ForestGreen;
            panel3.Controls.Add(label4);
            panel3.Location = new Point(428, 137);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 55);
            panel3.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(24, 15);
            label4.Name = "label4";
            label4.Size = new Size(155, 24);
            label4.TabIndex = 0;
            label4.Text = "CLINIC DAYS:";
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(label5);
            panel4.Location = new Point(627, 138);
            panel4.Name = "panel4";
            panel4.Size = new Size(264, 55);
            panel4.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(11, 15);
            label5.Name = "label5";
            label5.Size = new Size(238, 24);
            label5.TabIndex = 1;
            label5.Text = "MONDAY - SATURDAY";
            // 
            // roundedDataGridView1
            // 
            roundedDataGridView1.BackColor = Color.White;
            roundedDataGridView1.BorderColor = Color.Gray;
            roundedDataGridView1.BorderRadius = 20;
            roundedDataGridView1.BorderThickness = 2;
            roundedDataGridView1.Location = new Point(420, 228);
            roundedDataGridView1.Name = "roundedDataGridView1";
            roundedDataGridView1.Size = new Size(1449, 741);
            roundedDataGridView1.TabIndex = 14;
            // 
            // DoctorSchedule
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1920, 1080);
            ControlBox = false;
            Controls.Add(roundedDataGridView1);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DoctorSchedule";
            StartPosition = FormStartPosition.CenterParent;
            Text = "DoctorSchedule";
            Load += DoctorSchedule_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
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
        private Label label3;
        private Panel panel3;
        private Label label4;
        private Panel panel4;
        private Label label5;
        private CustomControls.RoundedDataGridView roundedDataGridView1;
    }
}