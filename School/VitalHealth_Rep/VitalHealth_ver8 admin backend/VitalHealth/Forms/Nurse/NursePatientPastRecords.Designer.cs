namespace VitalHealth.Forms.Nurse
{
    partial class NursePatientPastRecords
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NursePatientPastRecords));
            panel1 = new Panel();
            btn_schedAndFee = new Button();
            btn_missedCheckups = new Button();
            button3 = new Button();
            btn_pastRecords = new Button();
            btn_logout = new Button();
            btn_editProfile = new Button();
            btn_todaysPatient = new Button();
            btn_checkupForm = new Button();
            LblNurse = new Label();
            lbl_nurseLastName = new Label();
            label1 = new Label();
            panel2 = new Panel();
            roundedDataGridView1 = new VitalHealth.CustomControls.RoundedDataGridView();
            roundedTextBox1 = new RoundedTextBox();
            roundedButton1 = new RoundedButton();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            viewRecordButton = new RoundedButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btn_schedAndFee);
            panel1.Controls.Add(btn_missedCheckups);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(btn_pastRecords);
            panel1.Controls.Add(btn_logout);
            panel1.Controls.Add(btn_editProfile);
            panel1.Controls.Add(btn_todaysPatient);
            panel1.Controls.Add(btn_checkupForm);
            panel1.Controls.Add(LblNurse);
            panel1.Controls.Add(lbl_nurseLastName);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(368, 1080);
            panel1.TabIndex = 0;
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
            btn_schedAndFee.TabIndex = 20;
            btn_schedAndFee.Text = "Schedule and Fee";
            btn_schedAndFee.TextAlign = ContentAlignment.MiddleLeft;
            btn_schedAndFee.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_schedAndFee.UseVisualStyleBackColor = false;
            btn_schedAndFee.Click += btn_schedAndFee_Click_1;
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
            btn_missedCheckups.TabIndex = 19;
            btn_missedCheckups.Text = "Missed Checkups";
            btn_missedCheckups.TextAlign = ContentAlignment.MiddleLeft;
            btn_missedCheckups.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_missedCheckups.UseVisualStyleBackColor = false;
            btn_missedCheckups.Click += btn_missedCheckups_Click;
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
            button3.TabIndex = 18;
            button3.Text = "Patient History";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.TextImageRelation = TextImageRelation.ImageBeforeText;
            button3.UseVisualStyleBackColor = false;
            // 
            // btn_pastRecords
            // 
            btn_pastRecords.BackColor = Color.DarkGray;
            btn_pastRecords.FlatAppearance.BorderSize = 0;
            btn_pastRecords.FlatStyle = FlatStyle.Flat;
            btn_pastRecords.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            btn_pastRecords.Image = Properties.Resources.PastRecordsIcon;
            btn_pastRecords.Location = new Point(0, 340);
            btn_pastRecords.Margin = new Padding(3, 2, 3, 2);
            btn_pastRecords.Name = "btn_pastRecords";
            btn_pastRecords.Padding = new Padding(13, 0, 0, 0);
            btn_pastRecords.Size = new Size(366, 67);
            btn_pastRecords.TabIndex = 17;
            btn_pastRecords.Text = "Past Records";
            btn_pastRecords.TextAlign = ContentAlignment.MiddleLeft;
            btn_pastRecords.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_pastRecords.UseVisualStyleBackColor = false;
            // 
            // btn_logout
            // 
            btn_logout.BackColor = Color.White;
            btn_logout.FlatAppearance.BorderSize = 0;
            btn_logout.FlatStyle = FlatStyle.Flat;
            btn_logout.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            btn_logout.Image = (Image)resources.GetObject("btn_logout.Image");
            btn_logout.ImageAlign = ContentAlignment.MiddleLeft;
            btn_logout.Location = new Point(1, 1012);
            btn_logout.Margin = new Padding(3, 2, 3, 2);
            btn_logout.Name = "btn_logout";
            btn_logout.Padding = new Padding(31, 0, 0, 0);
            btn_logout.Size = new Size(367, 67);
            btn_logout.TabIndex = 15;
            btn_logout.Text = " Logout";
            btn_logout.TextAlign = ContentAlignment.MiddleLeft;
            btn_logout.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_logout.UseVisualStyleBackColor = false;
            btn_logout.Click += btn_logout_Click;
            // 
            // btn_editProfile
            // 
            btn_editProfile.BackColor = Color.White;
            btn_editProfile.FlatAppearance.BorderSize = 0;
            btn_editProfile.FlatStyle = FlatStyle.Flat;
            btn_editProfile.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            btn_editProfile.Image = (Image)resources.GetObject("btn_editProfile.Image");
            btn_editProfile.ImageAlign = ContentAlignment.MiddleLeft;
            btn_editProfile.Location = new Point(1, 940);
            btn_editProfile.Margin = new Padding(3, 2, 3, 2);
            btn_editProfile.Name = "btn_editProfile";
            btn_editProfile.Padding = new Padding(31, 0, 0, 0);
            btn_editProfile.Size = new Size(367, 67);
            btn_editProfile.TabIndex = 14;
            btn_editProfile.Text = " Edit Profile";
            btn_editProfile.TextAlign = ContentAlignment.MiddleLeft;
            btn_editProfile.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_editProfile.UseVisualStyleBackColor = false;
            btn_editProfile.Click += btn_editProfile_Click;
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
            btn_todaysPatient.Size = new Size(367, 67);
            btn_todaysPatient.TabIndex = 9;
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
            btn_checkupForm.Size = new Size(368, 67);
            btn_checkupForm.TabIndex = 8;
            btn_checkupForm.Text = "Patient Checkup Form";
            btn_checkupForm.TextAlign = ContentAlignment.MiddleLeft;
            btn_checkupForm.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_checkupForm.UseVisualStyleBackColor = false;
            btn_checkupForm.Click += btn_checkupForm_Click;
            // 
            // LblNurse
            // 
            LblNurse.AutoSize = true;
            LblNurse.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblNurse.ForeColor = Color.FromArgb(26, 117, 159);
            LblNurse.Location = new Point(111, 61);
            LblNurse.Name = "LblNurse";
            LblNurse.Size = new Size(52, 25);
            LblNurse.TabIndex = 7;
            LblNurse.Text = "Nurse";
            // 
            // lbl_nurseLastName
            // 
            lbl_nurseLastName.AutoSize = true;
            lbl_nurseLastName.Font = new Font("Zona Pro Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_nurseLastName.Location = new Point(182, 38);
            lbl_nurseLastName.Name = "lbl_nurseLastName";
            lbl_nurseLastName.Size = new Size(116, 24);
            lbl_nurseLastName.TabIndex = 6;
            lbl_nurseLastName.Text = "lastname";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Zona Pro Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(111, 38);
            label1.Name = "label1";
            label1.Size = new Size(73, 24);
            label1.TabIndex = 4;
            label1.Text = "Hello,";
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
            panel2.TabIndex = 5;
            // 
            // roundedDataGridView1
            // 
            roundedDataGridView1.BackColor = Color.White;
            roundedDataGridView1.BorderColor = Color.Gray;
            roundedDataGridView1.BorderRadius = 20;
            roundedDataGridView1.BorderThickness = 2;
            roundedDataGridView1.Location = new Point(427, 250);
            roundedDataGridView1.Name = "roundedDataGridView1";
            roundedDataGridView1.Size = new Size(887, 416);
            roundedDataGridView1.TabIndex = 16;
            // 
            // roundedTextBox1
            // 
            roundedTextBox1.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roundedTextBox1.Location = new Point(427, 169);
            roundedTextBox1.Name = "roundedTextBox1";
            roundedTextBox1.PlaceholderText = "Search Patient's Name/Queuing Number";
            roundedTextBox1.Size = new Size(379, 54);
            roundedTextBox1.TabIndex = 15;
            roundedTextBox1.Theme = ControlTheme.Light;
            // 
            // roundedButton1
            // 
            roundedButton1.BackColor = Color.FromArgb(22, 138, 173);
            roundedButton1.FlatAppearance.BorderSize = 0;
            roundedButton1.FlatStyle = FlatStyle.Flat;
            roundedButton1.Font = new Font("Zona Pro Bold", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roundedButton1.ForeColor = Color.White;
            roundedButton1.Location = new Point(814, 169);
            roundedButton1.Name = "roundedButton1";
            roundedButton1.Size = new Size(126, 54);
            roundedButton1.TabIndex = 14;
            roundedButton1.Text = "Search";
            roundedButton1.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.WindowFrame;
            label3.Location = new Point(427, 91);
            label3.Name = "label3";
            label3.Size = new Size(421, 25);
            label3.TabIndex = 18;
            label3.Text = "Displays past patient checkup records.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Zona Pro Bold", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(424, 44);
            label2.Name = "label2";
            label2.Size = new Size(252, 38);
            label2.TabIndex = 17;
            label2.Text = "Past Records";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Zona Pro Bold", 15.7499981F);
            label4.Location = new Point(843, 682);
            label4.Name = "label4";
            label4.Size = new Size(23, 23);
            label4.TabIndex = 19;
            label4.Text = "3";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Zona Pro Bold", 15.7499981F);
            label5.Location = new Point(873, 682);
            label5.Name = "label5";
            label5.Size = new Size(24, 23);
            label5.TabIndex = 20;
            label5.Text = "4";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Zona Pro Bold", 15.7499981F);
            label6.Location = new Point(903, 682);
            label6.Name = "label6";
            label6.Size = new Size(23, 23);
            label6.TabIndex = 21;
            label6.Text = "5";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Zona Pro Bold", 15.7499981F);
            label7.Location = new Point(813, 682);
            label7.Name = "label7";
            label7.Size = new Size(23, 23);
            label7.TabIndex = 22;
            label7.Text = "2";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Zona Pro Bold", 15.7499981F);
            label8.Location = new Point(783, 682);
            label8.Name = "label8";
            label8.Size = new Size(19, 23);
            label8.TabIndex = 23;
            label8.Text = "1";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(743, 676);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(33, 33);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(934, 676);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(33, 33);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 25;
            pictureBox2.TabStop = false;
            // 
            // viewRecordButton
            // 
            viewRecordButton.BackColor = Color.FromArgb(74, 214, 109);
            viewRecordButton.FlatAppearance.BorderSize = 0;
            viewRecordButton.FlatStyle = FlatStyle.Flat;
            viewRecordButton.Font = new Font("Zona Pro Bold", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            viewRecordButton.ForeColor = Color.White;
            viewRecordButton.Location = new Point(1114, 676);
            viewRecordButton.Name = "viewRecordButton";
            viewRecordButton.Size = new Size(200, 50);
            viewRecordButton.TabIndex = 26;
            viewRecordButton.Text = "VIEW RECORD";
            viewRecordButton.UseVisualStyleBackColor = false;
            // 
            // NursePatientPastRecords
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(229, 231, 231);
            ClientSize = new Size(1920, 1080);
            ControlBox = false;
            Controls.Add(viewRecordButton);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(roundedDataGridView1);
            Controls.Add(roundedTextBox1);
            Controls.Add(roundedButton1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "NursePatientPastRecords";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Form1";
            Load += PatientPastRecords_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label LblNurse;
        private Label lbl_nurseLastName;
        private Label label1;
        private Panel panel2;
        private Button btn_checkupForm;
        private Button btn_todaysPatient;
        private CustomControls.RoundedDataGridView roundedDataGridView1;
        private RoundedTextBox roundedTextBox1;
        private RoundedButton roundedButton1;
        private Label label3;
        private Label label2;
        private Button btn_logout;
        private Button btn_editProfile;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private RoundedButton viewRecordButton;
        private Button btn_pastRecords;
        private Button button3;
        private Button btn_missedCheckups;
        private Button btn_schedAndFee;
    }
}