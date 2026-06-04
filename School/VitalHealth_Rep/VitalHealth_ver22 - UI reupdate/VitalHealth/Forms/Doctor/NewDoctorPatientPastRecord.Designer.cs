namespace VitalHealth.Forms.Nurse
{
    partial class NewDoctorPatientPastRecord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewDoctorPatientPastRecord));
            pastRecordDataGrid = new VitalHealth.CustomControls.RoundedDataGridView();
            searchTxtBox = new RoundedTextBox();
            searchButton = new RoundedButton();
            label3 = new Label();
            label2 = new Label();
            page3DG = new Label();
            page4DG = new Label();
            page5DG = new Label();
            page2DG = new Label();
            page1DG = new Label();
            backArrowDG = new PictureBox();
            nextArrowDG = new PictureBox();
            viewRecordButton = new RoundedButton();
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
            ((System.ComponentModel.ISupportInitialize)backArrowDG).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nextArrowDG).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pastRecordDataGrid
            // 
            pastRecordDataGrid.BackColor = Color.White;
            pastRecordDataGrid.BorderColor = Color.Gray;
            pastRecordDataGrid.BorderRadius = 20;
            pastRecordDataGrid.BorderThickness = 2;
            pastRecordDataGrid.Location = new Point(427, 250);
            pastRecordDataGrid.Name = "pastRecordDataGrid";
            pastRecordDataGrid.Size = new Size(1401, 724);
            pastRecordDataGrid.TabIndex = 16;
            // 
            // searchTxtBox
            // 
            searchTxtBox.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchTxtBox.Location = new Point(427, 169);
            searchTxtBox.Name = "searchTxtBox";
            searchTxtBox.PlaceholderText = "Search Patient's Name/Queuing Number";
            searchTxtBox.Size = new Size(379, 54);
            searchTxtBox.TabIndex = 15;
            searchTxtBox.Theme = ControlTheme.Light;
            // 
            // searchButton
            // 
            searchButton.BackColor = Color.FromArgb(22, 138, 173);
            searchButton.FlatAppearance.BorderSize = 0;
            searchButton.FlatStyle = FlatStyle.Flat;
            searchButton.Font = new Font("Zona Pro Bold", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchButton.ForeColor = Color.White;
            searchButton.Location = new Point(814, 169);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(126, 54);
            searchButton.TabIndex = 14;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = false;
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
            // page3DG
            // 
            page3DG.AutoSize = true;
            page3DG.Font = new Font("Zona Pro Bold", 15.7499981F);
            page3DG.Location = new Point(1073, 1000);
            page3DG.Name = "page3DG";
            page3DG.Size = new Size(23, 23);
            page3DG.TabIndex = 19;
            page3DG.Text = "3";
            // 
            // page4DG
            // 
            page4DG.AutoSize = true;
            page4DG.Font = new Font("Zona Pro Bold", 15.7499981F);
            page4DG.Location = new Point(1103, 1000);
            page4DG.Name = "page4DG";
            page4DG.Size = new Size(24, 23);
            page4DG.TabIndex = 20;
            page4DG.Text = "4";
            // 
            // page5DG
            // 
            page5DG.AutoSize = true;
            page5DG.Font = new Font("Zona Pro Bold", 15.7499981F);
            page5DG.Location = new Point(1133, 1000);
            page5DG.Name = "page5DG";
            page5DG.Size = new Size(23, 23);
            page5DG.TabIndex = 21;
            page5DG.Text = "5";
            // 
            // page2DG
            // 
            page2DG.AutoSize = true;
            page2DG.Font = new Font("Zona Pro Bold", 15.7499981F);
            page2DG.Location = new Point(1043, 1000);
            page2DG.Name = "page2DG";
            page2DG.Size = new Size(23, 23);
            page2DG.TabIndex = 22;
            page2DG.Text = "2";
            // 
            // page1DG
            // 
            page1DG.AutoSize = true;
            page1DG.Font = new Font("Zona Pro Bold", 15.7499981F);
            page1DG.Location = new Point(1013, 1000);
            page1DG.Name = "page1DG";
            page1DG.Size = new Size(19, 23);
            page1DG.TabIndex = 23;
            page1DG.Text = "1";
            // 
            // backArrowDG
            // 
            backArrowDG.Image = Properties.Resources.backArrowDG;
            backArrowDG.Location = new Point(973, 994);
            backArrowDG.Name = "backArrowDG";
            backArrowDG.Size = new Size(33, 33);
            backArrowDG.SizeMode = PictureBoxSizeMode.StretchImage;
            backArrowDG.TabIndex = 24;
            backArrowDG.TabStop = false;
            // 
            // nextArrowDG
            // 
            nextArrowDG.Image = Properties.Resources.nextArrowDG;
            nextArrowDG.Location = new Point(1164, 994);
            nextArrowDG.Name = "nextArrowDG";
            nextArrowDG.Size = new Size(33, 33);
            nextArrowDG.SizeMode = PictureBoxSizeMode.StretchImage;
            nextArrowDG.TabIndex = 25;
            nextArrowDG.TabStop = false;
            // 
            // viewRecordButton
            // 
            viewRecordButton.BackColor = Color.FromArgb(74, 214, 109);
            viewRecordButton.FlatAppearance.BorderSize = 0;
            viewRecordButton.FlatStyle = FlatStyle.Flat;
            viewRecordButton.Font = new Font("Zona Pro Bold", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            viewRecordButton.ForeColor = Color.White;
            viewRecordButton.Location = new Point(1596, 986);
            viewRecordButton.Name = "viewRecordButton";
            viewRecordButton.Size = new Size(200, 50);
            viewRecordButton.TabIndex = 26;
            viewRecordButton.Text = "VIEW RECORD";
            viewRecordButton.UseVisualStyleBackColor = false;
            viewRecordButton.Click += viewRecordButton_Click;
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
            panel1.TabIndex = 27;
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
            // NewDoctorPatientPastRecord
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(229, 231, 231);
            ClientSize = new Size(1920, 1080);
            ControlBox = false;
            Controls.Add(panel1);
            Controls.Add(viewRecordButton);
            Controls.Add(nextArrowDG);
            Controls.Add(backArrowDG);
            Controls.Add(page1DG);
            Controls.Add(page2DG);
            Controls.Add(page5DG);
            Controls.Add(page4DG);
            Controls.Add(page3DG);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pastRecordDataGrid);
            Controls.Add(searchTxtBox);
            Controls.Add(searchButton);
            FormBorderStyle = FormBorderStyle.None;
            Name = "NewDoctorPatientPastRecord";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Form1";
            Load += PatientPastRecords_Load;
            ((System.ComponentModel.ISupportInitialize)backArrowDG).EndInit();
            ((System.ComponentModel.ISupportInitialize)nextArrowDG).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private CustomControls.RoundedDataGridView pastRecordDataGrid;
        private RoundedTextBox searchTxtBox;
        private RoundedButton searchButton;
        private Label label3;
        private Label label2;
        private Label page3DG;
        private Label page4DG;
        private Label page5DG;
        private Label page2DG;
        private Label page1DG;
        private PictureBox backArrowDG;
        private PictureBox nextArrowDG;
        private RoundedButton viewRecordButton;
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
    }
}