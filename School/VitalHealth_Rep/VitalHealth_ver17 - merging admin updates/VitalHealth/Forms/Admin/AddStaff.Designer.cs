namespace VitalHealth.Forms.Admin
{
    partial class AddStaff
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
            label3 = new Label();
            label2 = new Label();
            roundedPanel1 = new VitalHealth.CustomControls.RoundedPanel();
            btn_showSecAnswer = new PictureBox();
            btn_showConfirmPassword = new PictureBox();
            btn_showPassword = new PictureBox();
            txtB_confirmPassword = new RoundedTextBox();
            txtB_password = new RoundedTextBox();
            lbl_exampleAnswer = new Label();
            lbl_exampleQuestion = new Label();
            txtB_securityAnswer = new RoundedTextBox();
            txtB_securityQuestion = new RoundedTextBox();
            lbl_passwordRules = new Label();
            btnCancel = new RoundedButton();
            btnRegister = new RoundedButton();
            txtContactNumber = new RoundedTextBox();
            txtUsername = new RoundedTextBox();
            label6 = new Label();
            cmbSpecialization = new RoundedComboBox();
            cmbWorkingHours = new RoundedComboBox();
            rdbDoctor = new SquareRadioButton();
            rdbNurse = new SquareRadioButton();
            label5 = new Label();
            cmbSuffix = new RoundedComboBox();
            txtMI = new RoundedTextBox();
            txtFirstname = new RoundedTextBox();
            txtLastname = new RoundedTextBox();
            label4 = new Label();
            pnlSideBar = new Panel();
            btn_logout = new Button();
            btnSchedNFee = new Button();
            btnPatientsRec = new Button();
            btnManageStaff = new Button();
            btnSalesDashboard = new Button();
            LblAdmin = new Label();
            lbl_adminLastName = new Label();
            label1 = new Label();
            panel2 = new Panel();
            roundedPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btn_showSecAnswer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_showConfirmPassword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_showPassword).BeginInit();
            pnlSideBar.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.WindowFrame;
            label3.Location = new Point(426, 86);
            label3.Name = "label3";
            label3.Size = new Size(569, 25);
            label3.TabIndex = 12;
            label3.Text = "Automatically approve staffs by adding them yourself";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Zona Pro Bold", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(426, 46);
            label2.Name = "label2";
            label2.Size = new Size(190, 38);
            label2.TabIndex = 11;
            label2.Text = "Add Staff";
            // 
            // roundedPanel1
            // 
            roundedPanel1.BackColor = Color.White;
            roundedPanel1.BorderRadius = 30;
            roundedPanel1.Controls.Add(btn_showSecAnswer);
            roundedPanel1.Controls.Add(btn_showConfirmPassword);
            roundedPanel1.Controls.Add(btn_showPassword);
            roundedPanel1.Controls.Add(txtB_confirmPassword);
            roundedPanel1.Controls.Add(txtB_password);
            roundedPanel1.Controls.Add(lbl_exampleAnswer);
            roundedPanel1.Controls.Add(lbl_exampleQuestion);
            roundedPanel1.Controls.Add(txtB_securityAnswer);
            roundedPanel1.Controls.Add(txtB_securityQuestion);
            roundedPanel1.Controls.Add(lbl_passwordRules);
            roundedPanel1.Controls.Add(btnCancel);
            roundedPanel1.Controls.Add(btnRegister);
            roundedPanel1.Controls.Add(txtContactNumber);
            roundedPanel1.Controls.Add(txtUsername);
            roundedPanel1.Controls.Add(label6);
            roundedPanel1.Controls.Add(cmbSpecialization);
            roundedPanel1.Controls.Add(cmbWorkingHours);
            roundedPanel1.Controls.Add(rdbDoctor);
            roundedPanel1.Controls.Add(rdbNurse);
            roundedPanel1.Controls.Add(label5);
            roundedPanel1.Controls.Add(cmbSuffix);
            roundedPanel1.Controls.Add(txtMI);
            roundedPanel1.Controls.Add(txtFirstname);
            roundedPanel1.Controls.Add(txtLastname);
            roundedPanel1.Controls.Add(label4);
            roundedPanel1.Location = new Point(426, 177);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Size = new Size(1430, 804);
            roundedPanel1.TabIndex = 13;
            // 
            // btn_showSecAnswer
            // 
            btn_showSecAnswer.BackColor = Color.Transparent;
            btn_showSecAnswer.Cursor = Cursors.Hand;
            btn_showSecAnswer.Image = Properties.Resources.hidden_icon;
            btn_showSecAnswer.Location = new Point(1297, 523);
            btn_showSecAnswer.Name = "btn_showSecAnswer";
            btn_showSecAnswer.Size = new Size(32, 32);
            btn_showSecAnswer.SizeMode = PictureBoxSizeMode.StretchImage;
            btn_showSecAnswer.TabIndex = 48;
            btn_showSecAnswer.TabStop = false;
            btn_showSecAnswer.Click += btn_showSecAnswer_Click;
            // 
            // btn_showConfirmPassword
            // 
            btn_showConfirmPassword.BackColor = Color.Transparent;
            btn_showConfirmPassword.Cursor = Cursors.Hand;
            btn_showConfirmPassword.Image = Properties.Resources.hidden_icon;
            btn_showConfirmPassword.Location = new Point(808, 523);
            btn_showConfirmPassword.Name = "btn_showConfirmPassword";
            btn_showConfirmPassword.Size = new Size(32, 32);
            btn_showConfirmPassword.SizeMode = PictureBoxSizeMode.StretchImage;
            btn_showConfirmPassword.TabIndex = 47;
            btn_showConfirmPassword.TabStop = false;
            btn_showConfirmPassword.Click += btn_showConfirmPassword_Click;
            // 
            // btn_showPassword
            // 
            btn_showPassword.BackColor = Color.Transparent;
            btn_showPassword.Cursor = Cursors.Hand;
            btn_showPassword.Image = Properties.Resources.hidden_icon;
            btn_showPassword.Location = new Point(808, 444);
            btn_showPassword.Name = "btn_showPassword";
            btn_showPassword.Size = new Size(32, 32);
            btn_showPassword.SizeMode = PictureBoxSizeMode.StretchImage;
            btn_showPassword.TabIndex = 44;
            btn_showPassword.TabStop = false;
            btn_showPassword.Click += btn_showPassword_Click;
            // 
            // txtB_confirmPassword
            // 
            txtB_confirmPassword.BackColor = Color.Transparent;
            txtB_confirmPassword.Font = new Font("Poppins", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtB_confirmPassword.ForeColor = Color.White;
            txtB_confirmPassword.Location = new Point(454, 519);
            txtB_confirmPassword.Margin = new Padding(0);
            txtB_confirmPassword.Name = "txtB_confirmPassword";
            txtB_confirmPassword.PlaceholderText = "* Confirm Password";
            txtB_confirmPassword.RightToLeft = RightToLeft.No;
            txtB_confirmPassword.Size = new Size(400, 40);
            txtB_confirmPassword.TabIndex = 46;
            txtB_confirmPassword.TextPadding = new Padding(30, 0, 60, 0);
            txtB_confirmPassword.UseSystemPasswordChar = true;
            // 
            // txtB_password
            // 
            txtB_password.BackColor = Color.Transparent;
            txtB_password.Font = new Font("Poppins", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtB_password.ForeColor = Color.White;
            txtB_password.Location = new Point(454, 440);
            txtB_password.Margin = new Padding(0);
            txtB_password.Name = "txtB_password";
            txtB_password.PlaceholderText = "* Password";
            txtB_password.RightToLeft = RightToLeft.No;
            txtB_password.Size = new Size(400, 40);
            txtB_password.TabIndex = 45;
            txtB_password.TextPadding = new Padding(30, 0, 60, 0);
            txtB_password.UseSystemPasswordChar = true;
            // 
            // lbl_exampleAnswer
            // 
            lbl_exampleAnswer.AutoSize = true;
            lbl_exampleAnswer.BackColor = Color.Transparent;
            lbl_exampleAnswer.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_exampleAnswer.Location = new Point(941, 558);
            lbl_exampleAnswer.Name = "lbl_exampleAnswer";
            lbl_exampleAnswer.Size = new Size(147, 20);
            lbl_exampleAnswer.TabIndex = 39;
            lbl_exampleAnswer.Text = "Example Answer: Barky";
            lbl_exampleAnswer.TextAlign = ContentAlignment.MiddleCenter;
            lbl_exampleAnswer.UseCompatibleTextRendering = true;
            lbl_exampleAnswer.Click += lbl_exampleAnswer_Click;
            // 
            // lbl_exampleQuestion
            // 
            lbl_exampleQuestion.AutoSize = true;
            lbl_exampleQuestion.BackColor = Color.Transparent;
            lbl_exampleQuestion.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_exampleQuestion.Location = new Point(938, 480);
            lbl_exampleQuestion.Name = "lbl_exampleQuestion";
            lbl_exampleQuestion.Size = new Size(213, 20);
            lbl_exampleQuestion.TabIndex = 38;
            lbl_exampleQuestion.Text = "Example Question: First Dog name";
            lbl_exampleQuestion.TextAlign = ContentAlignment.MiddleCenter;
            lbl_exampleQuestion.UseCompatibleTextRendering = true;
            // 
            // txtB_securityAnswer
            // 
            txtB_securityAnswer.BackColor = Color.Transparent;
            txtB_securityAnswer.Font = new Font("Poppins", 14.25F);
            txtB_securityAnswer.ForeColor = Color.White;
            txtB_securityAnswer.Location = new Point(931, 518);
            txtB_securityAnswer.Margin = new Padding(0);
            txtB_securityAnswer.Name = "txtB_securityAnswer";
            txtB_securityAnswer.PlaceholderText = "* Security Answer";
            txtB_securityAnswer.RightToLeft = RightToLeft.No;
            txtB_securityAnswer.Size = new Size(410, 40);
            txtB_securityAnswer.TabIndex = 37;
            txtB_securityAnswer.TextPadding = new Padding(30, 0, 30, 0);
            txtB_securityAnswer.UseSystemPasswordChar = true;
            // 
            // txtB_securityQuestion
            // 
            txtB_securityQuestion.BackColor = Color.Transparent;
            txtB_securityQuestion.Font = new Font("Poppins", 14.25F);
            txtB_securityQuestion.ForeColor = Color.White;
            txtB_securityQuestion.Location = new Point(931, 440);
            txtB_securityQuestion.Margin = new Padding(0);
            txtB_securityQuestion.Name = "txtB_securityQuestion";
            txtB_securityQuestion.PlaceholderText = "* Security Question";
            txtB_securityQuestion.RightToLeft = RightToLeft.No;
            txtB_securityQuestion.Size = new Size(410, 40);
            txtB_securityQuestion.TabIndex = 36;
            txtB_securityQuestion.TextPadding = new Padding(30, 0, 30, 0);
            // 
            // lbl_passwordRules
            // 
            lbl_passwordRules.AutoSize = true;
            lbl_passwordRules.BackColor = Color.Transparent;
            lbl_passwordRules.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_passwordRules.ForeColor = Color.Red;
            lbl_passwordRules.Location = new Point(147, 580);
            lbl_passwordRules.Name = "lbl_passwordRules";
            lbl_passwordRules.Size = new Size(604, 23);
            lbl_passwordRules.TabIndex = 34;
            lbl_passwordRules.Text = "Password must be at least 8 characters with upper, lower, number, and special character.";
            lbl_passwordRules.TextAlign = ContentAlignment.MiddleCenter;
            lbl_passwordRules.UseCompatibleTextRendering = true;
            lbl_passwordRules.Visible = false;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(242, 37, 40);
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(737, 664);
            btnCancel.Name = "btnCancel";
            btnCancel.RightToLeft = RightToLeft.No;
            btnCancel.Size = new Size(420, 75);
            btnCancel.TabIndex = 32;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(26, 117, 159);
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(293, 664);
            btnRegister.Name = "btnRegister";
            btnRegister.RightToLeft = RightToLeft.No;
            btnRegister.Size = new Size(420, 75);
            btnRegister.TabIndex = 31;
            btnRegister.Text = "REGISTER";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // txtContactNumber
            // 
            txtContactNumber.Font = new Font("Poppins", 14.25F);
            txtContactNumber.Location = new Point(46, 518);
            txtContactNumber.MaxLength = 3;
            txtContactNumber.Name = "txtContactNumber";
            txtContactNumber.PlaceholderText = "* Contact Number (+63)";
            txtContactNumber.Size = new Size(365, 40);
            txtContactNumber.TabIndex = 27;
            txtContactNumber.Load += txtContactNumber_Load;
            txtContactNumber.KeyPress += txtContactNumber_KeyPress;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Poppins", 14.25F);
            txtUsername.Location = new Point(46, 440);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "* Username";
            txtUsername.Size = new Size(365, 40);
            txtUsername.TabIndex = 25;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Poppins", 15.75F);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(105, 375);
            label6.Name = "label6";
            label6.Size = new Size(1325, 37);
            label6.TabIndex = 24;
            label6.Text = "Contact and Login Credentials__________________________________________________________________";
            // 
            // cmbSpecialization
            // 
            cmbSpecialization.BackColor = Color.FromArgb(41, 41, 41);
            cmbSpecialization.DrawMode = DrawMode.OwnerDrawFixed;
            cmbSpecialization.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSpecialization.Font = new Font("Poppins", 14.25F);
            cmbSpecialization.ForeColor = Color.White;
            cmbSpecialization.FormattingEnabled = true;
            cmbSpecialization.IntegralHeight = false;
            cmbSpecialization.Location = new Point(861, 290);
            cmbSpecialization.Name = "cmbSpecialization";
            cmbSpecialization.PlaceholderText = "* If Doctor, which specialization";
            cmbSpecialization.Size = new Size(504, 37);
            cmbSpecialization.TabIndex = 23;
            cmbSpecialization.SelectedIndexChanged += cmbSpecialization_SelectedIndexChanged;
            // 
            // cmbWorkingHours
            // 
            cmbWorkingHours.BackColor = Color.FromArgb(41, 41, 41);
            cmbWorkingHours.DrawMode = DrawMode.OwnerDrawFixed;
            cmbWorkingHours.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbWorkingHours.Font = new Font("Poppins", 14.25F);
            cmbWorkingHours.ForeColor = Color.White;
            cmbWorkingHours.FormattingEnabled = true;
            cmbWorkingHours.IntegralHeight = false;
            cmbWorkingHours.Items.AddRange(new object[] { "8:00am - 12:00pm", "1:00pm - 5:00pm" });
            cmbWorkingHours.Location = new Point(454, 290);
            cmbWorkingHours.Name = "cmbWorkingHours";
            cmbWorkingHours.PlaceholderText = "* Working Hours";
            cmbWorkingHours.Size = new Size(365, 37);
            cmbWorkingHours.TabIndex = 22;
            cmbWorkingHours.SelectedIndexChanged += cmbWorkingHours_SelectedIndexChanged;
            // 
            // rdbDoctor
            // 
            rdbDoctor.Font = new Font("Poppins", 14.25F);
            rdbDoctor.Label = "Doctor";
            rdbDoctor.Location = new Point(286, 295);
            rdbDoctor.Name = "rdbDoctor";
            rdbDoctor.Size = new Size(150, 28);
            rdbDoctor.TabIndex = 21;
            rdbDoctor.CheckedChanged += rdbDoctor_CheckedChanged;
            rdbDoctor.Load += rdbDoctor_Load_1;
            // 
            // rdbNurse
            // 
            rdbNurse.Font = new Font("Poppins", 14.25F);
            rdbNurse.Label = "Nurse";
            rdbNurse.Location = new Point(105, 295);
            rdbNurse.Name = "rdbNurse";
            rdbNurse.Size = new Size(150, 28);
            rdbNurse.TabIndex = 20;
            rdbNurse.CheckedChanged += rdbNurse_CheckedChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Poppins", 15.75F);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(46, 220);
            label5.Name = "label5";
            label5.Size = new Size(1335, 37);
            label5.TabIndex = 19;
            label5.Text = "Position and Working Hours_____________________________________________________________________";
            // 
            // cmbSuffix
            // 
            cmbSuffix.BackColor = Color.FromArgb(41, 41, 41);
            cmbSuffix.DrawMode = DrawMode.OwnerDrawFixed;
            cmbSuffix.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSuffix.Font = new Font("Poppins", 14.25F);
            cmbSuffix.ForeColor = Color.White;
            cmbSuffix.FormattingEnabled = true;
            cmbSuffix.IntegralHeight = false;
            cmbSuffix.Items.AddRange(new object[] { "Jr. (Junior)", "Sr. (Senior)", "ll", "lll", "lV", "V", "Vl", "Vll", "Vlll" });
            cmbSuffix.Location = new Point(1071, 122);
            cmbSuffix.Name = "cmbSuffix";
            cmbSuffix.PlaceholderText = "Suffix";
            cmbSuffix.Size = new Size(294, 37);
            cmbSuffix.TabIndex = 18;
            cmbSuffix.SelectedIndexChanged += cnbSuffix_SelectedIndexChanged;
            // 
            // txtMI
            // 
            txtMI.Font = new Font("Poppins", 14.25F);
            txtMI.Location = new Point(861, 120);
            txtMI.Name = "txtMI";
            txtMI.PlaceholderText = "   M.I";
            txtMI.Size = new Size(170, 40);
            txtMI.TabIndex = 17;
            // 
            // txtFirstname
            // 
            txtFirstname.Font = new Font("Poppins", 14.25F);
            txtFirstname.Location = new Point(454, 120);
            txtFirstname.Name = "txtFirstname";
            txtFirstname.PlaceholderText = "* First Name";
            txtFirstname.Size = new Size(365, 40);
            txtFirstname.TabIndex = 16;
            // 
            // txtLastname
            // 
            txtLastname.Font = new Font("Poppins", 14.25F);
            txtLastname.ForeColor = Color.White;
            txtLastname.Location = new Point(46, 120);
            txtLastname.Name = "txtLastname";
            txtLastname.PlaceholderText = "* Lastname";
            txtLastname.Size = new Size(365, 40);
            txtLastname.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poppins", 15.75F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(46, 50);
            label4.Name = "label4";
            label4.Size = new Size(1328, 37);
            label4.TabIndex = 13;
            label4.Text = "Fullname_________________________________________________________________________________";
            // 
            // pnlSideBar
            // 
            pnlSideBar.BackColor = Color.White;
            pnlSideBar.Controls.Add(btn_logout);
            pnlSideBar.Controls.Add(btnSchedNFee);
            pnlSideBar.Controls.Add(btnPatientsRec);
            pnlSideBar.Controls.Add(btnManageStaff);
            pnlSideBar.Controls.Add(btnSalesDashboard);
            pnlSideBar.Controls.Add(LblAdmin);
            pnlSideBar.Controls.Add(lbl_adminLastName);
            pnlSideBar.Controls.Add(label1);
            pnlSideBar.Controls.Add(panel2);
            pnlSideBar.Dock = DockStyle.Left;
            pnlSideBar.Location = new Point(0, 0);
            pnlSideBar.Name = "pnlSideBar";
            pnlSideBar.Padding = new Padding(20, 0, 0, 0);
            pnlSideBar.Size = new Size(368, 1080);
            pnlSideBar.TabIndex = 31;
            // 
            // btn_logout
            // 
            btn_logout.BackColor = Color.White;
            btn_logout.FlatAppearance.BorderSize = 0;
            btn_logout.FlatStyle = FlatStyle.Flat;
            btn_logout.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_logout.ForeColor = Color.Black;
            btn_logout.Image = Properties.Resources.LogoutButtonIcon;
            btn_logout.Location = new Point(1, 1010);
            btn_logout.Margin = new Padding(3, 2, 3, 2);
            btn_logout.Name = "btn_logout";
            btn_logout.Size = new Size(366, 67);
            btn_logout.TabIndex = 11;
            btn_logout.Text = "Logout";
            btn_logout.TextAlign = ContentAlignment.MiddleLeft;
            btn_logout.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_logout.UseVisualStyleBackColor = false;
            btn_logout.Click += btn_logout_Click;
            // 
            // btnSchedNFee
            // 
            btnSchedNFee.BackColor = Color.White;
            btnSchedNFee.FlatAppearance.BorderSize = 0;
            btnSchedNFee.FlatStyle = FlatStyle.Flat;
            btnSchedNFee.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            btnSchedNFee.ForeColor = Color.Black;
            btnSchedNFee.Image = Properties.Resources.ScheduleAndFeeIcon;
            btnSchedNFee.Location = new Point(0, 340);
            btnSchedNFee.Margin = new Padding(3, 2, 3, 2);
            btnSchedNFee.Name = "btnSchedNFee";
            btnSchedNFee.Padding = new Padding(20, 0, 0, 0);
            btnSchedNFee.Size = new Size(366, 67);
            btnSchedNFee.TabIndex = 10;
            btnSchedNFee.Text = "Shedule and Fee";
            btnSchedNFee.TextAlign = ContentAlignment.MiddleLeft;
            btnSchedNFee.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSchedNFee.UseVisualStyleBackColor = false;
            btnSchedNFee.Click += btnSchedNFee_Click;
            // 
            // btnPatientsRec
            // 
            btnPatientsRec.BackColor = Color.White;
            btnPatientsRec.FlatAppearance.BorderSize = 0;
            btnPatientsRec.FlatStyle = FlatStyle.Flat;
            btnPatientsRec.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            btnPatientsRec.ForeColor = Color.Black;
            btnPatientsRec.Image = Properties.Resources.patients_records_icon;
            btnPatientsRec.Location = new Point(1, 270);
            btnPatientsRec.Margin = new Padding(3, 2, 3, 2);
            btnPatientsRec.Name = "btnPatientsRec";
            btnPatientsRec.Padding = new Padding(17, 0, 0, 0);
            btnPatientsRec.Size = new Size(366, 67);
            btnPatientsRec.TabIndex = 9;
            btnPatientsRec.Text = "Patients Record";
            btnPatientsRec.TextAlign = ContentAlignment.MiddleLeft;
            btnPatientsRec.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPatientsRec.UseVisualStyleBackColor = false;
            btnPatientsRec.Click += btnPatientsRec_Click;
            // 
            // btnManageStaff
            // 
            btnManageStaff.BackColor = Color.DarkGray;
            btnManageStaff.FlatAppearance.BorderSize = 0;
            btnManageStaff.FlatStyle = FlatStyle.Flat;
            btnManageStaff.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            btnManageStaff.ForeColor = Color.Black;
            btnManageStaff.Image = Properties.Resources.staff_icon;
            btnManageStaff.Location = new Point(1, 199);
            btnManageStaff.Margin = new Padding(3, 2, 3, 2);
            btnManageStaff.Name = "btnManageStaff";
            btnManageStaff.Padding = new Padding(10, 0, 0, 0);
            btnManageStaff.Size = new Size(366, 67);
            btnManageStaff.TabIndex = 8;
            btnManageStaff.Text = "Manage Staff";
            btnManageStaff.TextAlign = ContentAlignment.MiddleLeft;
            btnManageStaff.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnManageStaff.UseVisualStyleBackColor = false;
            btnManageStaff.Click += btnManageStaff_Click_1;
            // 
            // btnSalesDashboard
            // 
            btnSalesDashboard.BackColor = Color.White;
            btnSalesDashboard.FlatAppearance.BorderSize = 0;
            btnSalesDashboard.FlatStyle = FlatStyle.Flat;
            btnSalesDashboard.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            btnSalesDashboard.ForeColor = Color.Black;
            btnSalesDashboard.Image = Properties.Resources.sales_perf_icon;
            btnSalesDashboard.Location = new Point(1, 130);
            btnSalesDashboard.Margin = new Padding(3, 2, 3, 2);
            btnSalesDashboard.Name = "btnSalesDashboard";
            btnSalesDashboard.Padding = new Padding(20, 0, 0, 0);
            btnSalesDashboard.Size = new Size(366, 67);
            btnSalesDashboard.TabIndex = 7;
            btnSalesDashboard.Text = "Sales Dashboard\r\n";
            btnSalesDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnSalesDashboard.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSalesDashboard.UseVisualStyleBackColor = false;
            btnSalesDashboard.Click += btnSalesDashboard_Click_1;
            // 
            // LblAdmin
            // 
            LblAdmin.AutoSize = true;
            LblAdmin.Font = new Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblAdmin.ForeColor = Color.FromArgb(26, 117, 159);
            LblAdmin.Location = new Point(151, 68);
            LblAdmin.Name = "LblAdmin";
            LblAdmin.Size = new Size(61, 26);
            LblAdmin.TabIndex = 6;
            LblAdmin.Text = "Admin";
            // 
            // lbl_adminLastName
            // 
            lbl_adminLastName.AutoSize = true;
            lbl_adminLastName.Font = new Font("Poppins", 17.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_adminLastName.ForeColor = Color.Black;
            lbl_adminLastName.Location = new Point(222, 38);
            lbl_adminLastName.Name = "lbl_adminLastName";
            lbl_adminLastName.Size = new Size(128, 40);
            lbl_adminLastName.TabIndex = 5;
            lbl_adminLastName.Text = "lastname";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 17.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(74, 214, 109);
            label1.Location = new Point(151, 38);
            label1.Name = "label1";
            label1.Size = new Size(79, 40);
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
            panel2.TabIndex = 2;
            // 
            // AddStaff
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1920, 1080);
            ControlBox = false;
            Controls.Add(pnlSideBar);
            Controls.Add(roundedPanel1);
            Controls.Add(label3);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddStaff";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Form1";
            Load += AddStaff_Load;
            roundedPanel1.ResumeLayout(false);
            roundedPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btn_showSecAnswer).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_showConfirmPassword).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_showPassword).EndInit();
            pnlSideBar.ResumeLayout(false);
            pnlSideBar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private Label label2;
        private CustomControls.RoundedPanel roundedPanel1;
        private RoundedTextBox txtMI;
        private RoundedTextBox txtFirstname;
        private RoundedTextBox txtLastname;
        private Label label4;
        private Label label5;
        private RoundedComboBox cmbSuffix;
        private SquareRadioButton rdbDoctor;
        private SquareRadioButton rdbNurse;
        private Label label6;
        private RoundedComboBox cmbSpecialization;
        private RoundedComboBox cmbWorkingHours;
        private RoundedTextBox txtUsername;
        private RoundedTextBox txtContactNumber;
        private RoundedButton btnCancel;
        private RoundedButton btnRegister;
        private Label lbl_passwordRules;
        private Label lbl_exampleAnswer;
        private Label lbl_exampleQuestion;
        private RoundedTextBox txtB_securityAnswer;
        private RoundedTextBox txtB_securityQuestion;
        private Panel pnlSideBar;
        private Button btn_logout;
        private Button btnSchedNFee;
        private Button btnPatientsRec;
        private Button btnManageStaff;
        private Button btnSalesDashboard;
        private Label LblAdmin;
        private Label lbl_adminLastName;
        private Label label1;
        private Panel panel2;
        private PictureBox btn_showConfirmPassword;
        private PictureBox btn_showPassword;
        private RoundedTextBox txtB_confirmPassword;
        private RoundedTextBox txtB_password;
        private PictureBox btn_showSecAnswer;
    }
}