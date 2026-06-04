namespace VitalHealth.Forms.Nurse
{
    partial class MissedCheckups
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
            panel1 = new Panel();
            btn_editProfile = new Button();
            btn_logout = new Button();
            btn_todaysPatient = new Button();
            btn_checkupForm = new Button();
            LblDoc = new Label();
            lbl_nurseLastName = new Label();
            label1 = new Label();
            button3 = new Button();
            btn_pastRecords = new Button();
            btn_missedCheckups = new Button();
            btn_schedAndFee = new Button();
            panel2 = new Panel();
            label2 = new Label();
            label3 = new Label();
            roundedTextBox1 = new RoundedTextBox();
            roundedButton1 = new RoundedButton();
            roundedDataGridView1 = new VitalHealth.CustomControls.RoundedDataGridView();
            roundedButton2 = new RoundedButton();
            roundedButton3 = new RoundedButton();
            panel1.SuspendLayout();
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
            panel1.Controls.Add(button3);
            panel1.Controls.Add(btn_pastRecords);
            panel1.Controls.Add(btn_missedCheckups);
            panel1.Controls.Add(btn_schedAndFee);
            panel1.Controls.Add(panel2);
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
            btn_todaysPatient.BackColor = Color.White;
            btn_todaysPatient.FlatAppearance.BorderSize = 0;
            btn_todaysPatient.FlatStyle = FlatStyle.Flat;
            btn_todaysPatient.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            btn_todaysPatient.Image = Properties.Resources.TodaysPatientsIcon;
            btn_todaysPatient.ImageAlign = ContentAlignment.MiddleLeft;
            btn_todaysPatient.Location = new Point(-1, 199);
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
            LblDoc.Size = new Size(59, 25);
            LblDoc.TabIndex = 3;
            LblDoc.Text = "Doctor";
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
            btn_missedCheckups.BackColor = Color.DarkGray;
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
            // 
            // btn_schedAndFee
            // 
            btn_schedAndFee.BackColor = Color.White;
            btn_schedAndFee.FlatAppearance.BorderSize = 0;
            btn_schedAndFee.FlatStyle = FlatStyle.Flat;
            btn_schedAndFee.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            btn_schedAndFee.Image = Properties.Resources.ScheduleAndFeeIcon;
            btn_schedAndFee.Location = new Point(0, 482);
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
            label2.TabIndex = 7;
            label2.Text = "Checkup Form";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.WindowFrame;
            label3.Location = new Point(424, 93);
            label3.Name = "label3";
            label3.Size = new Size(387, 25);
            label3.TabIndex = 9;
            label3.Text = "Modify patient checkup information.";
            // 
            // roundedTextBox1
            // 
            roundedTextBox1.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roundedTextBox1.Location = new Point(424, 171);
            roundedTextBox1.Name = "roundedTextBox1";
            roundedTextBox1.PlaceholderText = "Search Patient's Name/Queuing Number";
            roundedTextBox1.Size = new Size(379, 54);
            roundedTextBox1.TabIndex = 12;
            roundedTextBox1.Theme = ControlTheme.Light;
            // 
            // roundedButton1
            // 
            roundedButton1.BackColor = Color.FromArgb(22, 138, 173);
            roundedButton1.FlatAppearance.BorderSize = 0;
            roundedButton1.FlatStyle = FlatStyle.Flat;
            roundedButton1.Font = new Font("Zona Pro Bold", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roundedButton1.ForeColor = Color.White;
            roundedButton1.Location = new Point(811, 171);
            roundedButton1.Name = "roundedButton1";
            roundedButton1.Size = new Size(126, 54);
            roundedButton1.TabIndex = 11;
            roundedButton1.Text = "Search";
            roundedButton1.UseVisualStyleBackColor = false;
            // 
            // roundedDataGridView1
            // 
            roundedDataGridView1.BackColor = Color.White;
            roundedDataGridView1.BorderColor = Color.Gray;
            roundedDataGridView1.BorderRadius = 20;
            roundedDataGridView1.BorderThickness = 2;
            roundedDataGridView1.Location = new Point(424, 246);
            roundedDataGridView1.Name = "roundedDataGridView1";
            roundedDataGridView1.Size = new Size(1449, 612);
            roundedDataGridView1.TabIndex = 13;
            // 
            // roundedButton2
            // 
            roundedButton2.BackColor = Color.FromArgb(22, 138, 173);
            roundedButton2.FlatAppearance.BorderSize = 0;
            roundedButton2.FlatStyle = FlatStyle.Flat;
            roundedButton2.Font = new Font("Zona Pro Bold", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roundedButton2.ForeColor = Color.Wheat;
            roundedButton2.Location = new Point(1257, 962);
            roundedButton2.Name = "roundedButton2";
            roundedButton2.Size = new Size(305, 57);
            roundedButton2.TabIndex = 14;
            roundedButton2.Text = "RESTORE";
            roundedButton2.UseVisualStyleBackColor = false;
            // 
            // roundedButton3
            // 
            roundedButton3.BackColor = Color.FromArgb(74, 214, 109);
            roundedButton3.FlatAppearance.BorderSize = 0;
            roundedButton3.FlatStyle = FlatStyle.Flat;
            roundedButton3.Font = new Font("Zona Pro Bold", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roundedButton3.ForeColor = Color.Wheat;
            roundedButton3.Location = new Point(1568, 962);
            roundedButton3.Name = "roundedButton3";
            roundedButton3.Size = new Size(305, 57);
            roundedButton3.TabIndex = 15;
            roundedButton3.Text = "VIEW RECORD";
            roundedButton3.UseVisualStyleBackColor = false;
            // 
            // MissedCheckups
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1920, 1080);
            Controls.Add(roundedButton3);
            Controls.Add(roundedButton2);
            Controls.Add(roundedDataGridView1);
            Controls.Add(roundedTextBox1);
            Controls.Add(roundedButton1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MissedCheckups";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Form1";
            Load += MissedCheckups_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private Button button3;
        private Button btn_pastRecords;
        private Button btn_missedCheckups;
        private Button btn_schedAndFee;
        private Panel panel2;
        private Label label2;
        private Label label3;
        private RoundedTextBox roundedTextBox1;
        private RoundedButton roundedButton1;
        private CustomControls.RoundedDataGridView roundedDataGridView1;
        private RoundedButton roundedButton2;
        private RoundedButton roundedButton3;
    }
}