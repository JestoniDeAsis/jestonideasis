namespace VitalHealth.Forms.Authentication
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            btn_back = new PictureBox();
            pnl_login = new Panel();
            cmbWorkingHours = new RoundedComboBox();
            btn_showSecurityAnswer = new PictureBox();
            lbl_exampleAnswer = new Label();
            lbl_exampleQuestion = new Label();
            txtB_securityAnswer = new RoundedTextBox();
            txtB_securityQuestion = new RoundedTextBox();
            lbl_passwordRules = new Label();
            btn_showConfirmPassword = new PictureBox();
            btn_showPassword = new PictureBox();
            txtB_confirmPassword = new RoundedTextBox();
            txtB_password = new RoundedTextBox();
            txtB_contactNumber = new RoundedTextBox();
            txtB_username = new RoundedTextBox();
            lbl_contactandLoginCredLine = new Label();
            rCmbBox_specialization = new RoundedComboBox();
            rdBtn_doctor = new SquareRadioButton();
            rdBtn_nurse = new SquareRadioButton();
            lbl_reqRadio = new Label();
            lbl_positionAndWorkingHoursLine = new Label();
            cmbBox_suffix = new RoundedComboBox();
            txtB_middlename = new RoundedTextBox();
            txtB_firstname = new RoundedTextBox();
            txtB_lastname = new RoundedTextBox();
            lbl_fullnameLine = new Label();
            btn_register = new RoundedButton();
            lbl_p = new Label();
            lbl_h1 = new Label();
            picB_vitalHealthBanner = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)btn_back).BeginInit();
            pnl_login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btn_showSecurityAnswer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_showConfirmPassword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_showPassword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picB_vitalHealthBanner).BeginInit();
            SuspendLayout();
            // 
            // btn_back
            // 
            btn_back.Cursor = Cursors.Hand;
            btn_back.Image = (Image)resources.GetObject("btn_back.Image");
            btn_back.Location = new Point(34, 28);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(53, 53);
            btn_back.SizeMode = PictureBoxSizeMode.StretchImage;
            btn_back.TabIndex = 2;
            btn_back.TabStop = false;
            btn_back.Click += btn_back_Click;
            // 
            // pnl_login
            // 
            pnl_login.BackColor = Color.White;
            pnl_login.Controls.Add(cmbWorkingHours);
            pnl_login.Controls.Add(btn_showSecurityAnswer);
            pnl_login.Controls.Add(lbl_exampleAnswer);
            pnl_login.Controls.Add(lbl_exampleQuestion);
            pnl_login.Controls.Add(txtB_securityAnswer);
            pnl_login.Controls.Add(txtB_securityQuestion);
            pnl_login.Controls.Add(lbl_passwordRules);
            pnl_login.Controls.Add(btn_showConfirmPassword);
            pnl_login.Controls.Add(btn_showPassword);
            pnl_login.Controls.Add(txtB_confirmPassword);
            pnl_login.Controls.Add(txtB_password);
            pnl_login.Controls.Add(txtB_contactNumber);
            pnl_login.Controls.Add(txtB_username);
            pnl_login.Controls.Add(lbl_contactandLoginCredLine);
            pnl_login.Controls.Add(rCmbBox_specialization);
            pnl_login.Controls.Add(rdBtn_doctor);
            pnl_login.Controls.Add(rdBtn_nurse);
            pnl_login.Controls.Add(lbl_reqRadio);
            pnl_login.Controls.Add(lbl_positionAndWorkingHoursLine);
            pnl_login.Controls.Add(cmbBox_suffix);
            pnl_login.Controls.Add(txtB_middlename);
            pnl_login.Controls.Add(txtB_firstname);
            pnl_login.Controls.Add(txtB_lastname);
            pnl_login.Controls.Add(lbl_fullnameLine);
            pnl_login.Controls.Add(btn_register);
            pnl_login.Controls.Add(lbl_p);
            pnl_login.Controls.Add(lbl_h1);
            pnl_login.Controls.Add(picB_vitalHealthBanner);
            pnl_login.Dock = DockStyle.Right;
            pnl_login.Location = new Point(928, 0);
            pnl_login.Name = "pnl_login";
            pnl_login.Size = new Size(992, 1080);
            pnl_login.TabIndex = 3;
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
            cmbWorkingHours.Location = new Point(124, 604);
            cmbWorkingHours.Name = "cmbWorkingHours";
            cmbWorkingHours.PlaceholderText = "* Working Hours";
            cmbWorkingHours.Size = new Size(365, 37);
            cmbWorkingHours.TabIndex = 37;
            // 
            // btn_showSecurityAnswer
            // 
            btn_showSecurityAnswer.BackColor = Color.Transparent;
            btn_showSecurityAnswer.Cursor = Cursors.Hand;
            btn_showSecurityAnswer.Image = Properties.Resources.hidden_icon;
            btn_showSecurityAnswer.Location = new Point(885, 850);
            btn_showSecurityAnswer.Name = "btn_showSecurityAnswer";
            btn_showSecurityAnswer.Size = new Size(32, 32);
            btn_showSecurityAnswer.SizeMode = PictureBoxSizeMode.StretchImage;
            btn_showSecurityAnswer.TabIndex = 36;
            btn_showSecurityAnswer.TabStop = false;
            btn_showSecurityAnswer.Click += btn_showSecurityAnswer_Click;
            // 
            // lbl_exampleAnswer
            // 
            lbl_exampleAnswer.AutoSize = true;
            lbl_exampleAnswer.BackColor = Color.Transparent;
            lbl_exampleAnswer.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_exampleAnswer.Location = new Point(531, 886);
            lbl_exampleAnswer.Name = "lbl_exampleAnswer";
            lbl_exampleAnswer.Size = new Size(157, 23);
            lbl_exampleAnswer.TabIndex = 35;
            lbl_exampleAnswer.Text = "Example Answer: Barky";
            lbl_exampleAnswer.TextAlign = ContentAlignment.MiddleCenter;
            lbl_exampleAnswer.UseCompatibleTextRendering = true;
            // 
            // lbl_exampleQuestion
            // 
            lbl_exampleQuestion.AutoSize = true;
            lbl_exampleQuestion.BackColor = Color.Transparent;
            lbl_exampleQuestion.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_exampleQuestion.Location = new Point(105, 886);
            lbl_exampleQuestion.Name = "lbl_exampleQuestion";
            lbl_exampleQuestion.Size = new Size(232, 23);
            lbl_exampleQuestion.TabIndex = 34;
            lbl_exampleQuestion.Text = "Example Question: First Dog name";
            lbl_exampleQuestion.TextAlign = ContentAlignment.MiddleCenter;
            lbl_exampleQuestion.UseCompatibleTextRendering = true;
            // 
            // txtB_securityAnswer
            // 
            txtB_securityAnswer.BackColor = Color.Transparent;
            txtB_securityAnswer.Font = new Font("Poppins", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtB_securityAnswer.ForeColor = Color.White;
            txtB_securityAnswer.Location = new Point(521, 846);
            txtB_securityAnswer.Margin = new Padding(0);
            txtB_securityAnswer.Name = "txtB_securityAnswer";
            txtB_securityAnswer.PlaceholderText = "* Security Answer";
            txtB_securityAnswer.RightToLeft = RightToLeft.No;
            txtB_securityAnswer.Size = new Size(410, 40);
            txtB_securityAnswer.TabIndex = 33;
            txtB_securityAnswer.TextPadding = new Padding(30, 0, 30, 0);
            txtB_securityAnswer.UseSystemPasswordChar = true;
            // 
            // txtB_securityQuestion
            // 
            txtB_securityQuestion.BackColor = Color.Transparent;
            txtB_securityQuestion.Font = new Font("Poppins", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtB_securityQuestion.ForeColor = Color.White;
            txtB_securityQuestion.Location = new Point(98, 846);
            txtB_securityQuestion.Margin = new Padding(0);
            txtB_securityQuestion.Name = "txtB_securityQuestion";
            txtB_securityQuestion.PlaceholderText = "* Security Question";
            txtB_securityQuestion.RightToLeft = RightToLeft.No;
            txtB_securityQuestion.Size = new Size(410, 40);
            txtB_securityQuestion.TabIndex = 32;
            txtB_securityQuestion.TextPadding = new Padding(30, 0, 30, 0);
            // 
            // lbl_passwordRules
            // 
            lbl_passwordRules.AutoSize = true;
            lbl_passwordRules.BackColor = Color.Transparent;
            lbl_passwordRules.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_passwordRules.ForeColor = Color.Red;
            lbl_passwordRules.Location = new Point(221, 798);
            lbl_passwordRules.Name = "lbl_passwordRules";
            lbl_passwordRules.Size = new Size(604, 23);
            lbl_passwordRules.TabIndex = 31;
            lbl_passwordRules.Text = "Password must be at least 8 characters with upper, lower, number, and special character.";
            lbl_passwordRules.TextAlign = ContentAlignment.MiddleCenter;
            lbl_passwordRules.UseCompatibleTextRendering = true;
            lbl_passwordRules.Visible = false;
            // 
            // btn_showConfirmPassword
            // 
            btn_showConfirmPassword.BackColor = Color.Transparent;
            btn_showConfirmPassword.Cursor = Cursors.Hand;
            btn_showConfirmPassword.Image = Properties.Resources.hidden_icon;
            btn_showConfirmPassword.Location = new Point(885, 757);
            btn_showConfirmPassword.Name = "btn_showConfirmPassword";
            btn_showConfirmPassword.Size = new Size(32, 32);
            btn_showConfirmPassword.SizeMode = PictureBoxSizeMode.StretchImage;
            btn_showConfirmPassword.TabIndex = 30;
            btn_showConfirmPassword.TabStop = false;
            btn_showConfirmPassword.Click += btn_showConfirmPassword_Click;
            // 
            // btn_showPassword
            // 
            btn_showPassword.BackColor = Color.Transparent;
            btn_showPassword.Cursor = Cursors.Hand;
            btn_showPassword.Image = Properties.Resources.hidden_icon;
            btn_showPassword.Location = new Point(885, 700);
            btn_showPassword.Name = "btn_showPassword";
            btn_showPassword.Size = new Size(32, 32);
            btn_showPassword.SizeMode = PictureBoxSizeMode.StretchImage;
            btn_showPassword.TabIndex = 2;
            btn_showPassword.TabStop = false;
            btn_showPassword.Click += btn_showPassword_Click;
            // 
            // txtB_confirmPassword
            // 
            txtB_confirmPassword.BackColor = Color.Transparent;
            txtB_confirmPassword.Font = new Font("Poppins", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtB_confirmPassword.ForeColor = Color.White;
            txtB_confirmPassword.Location = new Point(531, 753);
            txtB_confirmPassword.Margin = new Padding(0);
            txtB_confirmPassword.Name = "txtB_confirmPassword";
            txtB_confirmPassword.PlaceholderText = "* Confirm Password";
            txtB_confirmPassword.RightToLeft = RightToLeft.No;
            txtB_confirmPassword.Size = new Size(400, 40);
            txtB_confirmPassword.TabIndex = 29;
            txtB_confirmPassword.TextPadding = new Padding(30, 0, 60, 0);
            txtB_confirmPassword.UseSystemPasswordChar = true;
            // 
            // txtB_password
            // 
            txtB_password.BackColor = Color.Transparent;
            txtB_password.Font = new Font("Poppins", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtB_password.ForeColor = Color.White;
            txtB_password.Location = new Point(531, 696);
            txtB_password.Margin = new Padding(0);
            txtB_password.Name = "txtB_password";
            txtB_password.PlaceholderText = "* Password";
            txtB_password.RightToLeft = RightToLeft.No;
            txtB_password.Size = new Size(400, 40);
            txtB_password.TabIndex = 28;
            txtB_password.TextPadding = new Padding(30, 0, 60, 0);
            txtB_password.UseSystemPasswordChar = true;
            // 
            // txtB_contactNumber
            // 
            txtB_contactNumber.BackColor = Color.Transparent;
            txtB_contactNumber.Font = new Font("Poppins", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtB_contactNumber.ForeColor = Color.White;
            txtB_contactNumber.Location = new Point(98, 753);
            txtB_contactNumber.Margin = new Padding(0);
            txtB_contactNumber.MaxLength = 10;
            txtB_contactNumber.Name = "txtB_contactNumber";
            txtB_contactNumber.PlaceholderText = "* Contact Number (+63)";
            txtB_contactNumber.RightToLeft = RightToLeft.No;
            txtB_contactNumber.Size = new Size(400, 40);
            txtB_contactNumber.TabIndex = 27;
            txtB_contactNumber.TextPadding = new Padding(30, 0, 30, 0);
            // 
            // txtB_username
            // 
            txtB_username.BackColor = Color.Transparent;
            txtB_username.Font = new Font("Poppins", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtB_username.ForeColor = Color.White;
            txtB_username.Location = new Point(98, 696);
            txtB_username.Margin = new Padding(0);
            txtB_username.Name = "txtB_username";
            txtB_username.PlaceholderText = "* Username";
            txtB_username.RightToLeft = RightToLeft.No;
            txtB_username.Size = new Size(400, 40);
            txtB_username.TabIndex = 26;
            txtB_username.TextPadding = new Padding(30, 0, 30, 0);
            // 
            // lbl_contactandLoginCredLine
            // 
            lbl_contactandLoginCredLine.AutoSize = true;
            lbl_contactandLoginCredLine.BackColor = Color.Transparent;
            lbl_contactandLoginCredLine.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_contactandLoginCredLine.Location = new Point(88, 658);
            lbl_contactandLoginCredLine.Name = "lbl_contactandLoginCredLine";
            lbl_contactandLoginCredLine.Size = new Size(849, 28);
            lbl_contactandLoginCredLine.TabIndex = 24;
            lbl_contactandLoginCredLine.Text = "Contact and Login Credentials_________________________________________________";
            lbl_contactandLoginCredLine.TextAlign = ContentAlignment.MiddleCenter;
            lbl_contactandLoginCredLine.UseCompatibleTextRendering = true;
            // 
            // rCmbBox_specialization
            // 
            rCmbBox_specialization.BackColor = Color.FromArgb(41, 41, 41);
            rCmbBox_specialization.BorderRadius = 30;
            rCmbBox_specialization.Cursor = Cursors.Hand;
            rCmbBox_specialization.DrawMode = DrawMode.OwnerDrawFixed;
            rCmbBox_specialization.DropDownStyle = ComboBoxStyle.DropDownList;
            rCmbBox_specialization.FlatStyle = FlatStyle.Flat;
            rCmbBox_specialization.Font = new Font("Poppins", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rCmbBox_specialization.ForeColor = Color.White;
            rCmbBox_specialization.IntegralHeight = false;
            rCmbBox_specialization.Location = new Point(441, 548);
            rCmbBox_specialization.Name = "rCmbBox_specialization";
            rCmbBox_specialization.PlaceholderText = "* Specialization";
            rCmbBox_specialization.RightToLeft = RightToLeft.No;
            rCmbBox_specialization.Size = new Size(247, 37);
            rCmbBox_specialization.TabIndex = 25;
            rCmbBox_specialization.Visible = false;
            // 
            // rdBtn_doctor
            // 
            rdBtn_doctor.Font = new Font("Poppins", 14.25F);
            rdBtn_doctor.Label = "Doctor";
            rdBtn_doctor.Location = new Point(275, 555);
            rdBtn_doctor.Name = "rdBtn_doctor";
            rdBtn_doctor.Size = new Size(150, 28);
            rdBtn_doctor.TabIndex = 23;
            rdBtn_doctor.CheckedChanged += rdBtn_doctor_CheckedChanged;
            // 
            // rdBtn_nurse
            // 
            rdBtn_nurse.Checked = true;
            rdBtn_nurse.Font = new Font("Poppins", 14.25F);
            rdBtn_nurse.Label = "Nurse";
            rdBtn_nurse.Location = new Point(124, 555);
            rdBtn_nurse.Name = "rdBtn_nurse";
            rdBtn_nurse.Size = new Size(150, 28);
            rdBtn_nurse.TabIndex = 21;
            rdBtn_nurse.CheckedChanged += rdBtn_nurse_CheckedChanged;
            // 
            // lbl_reqRadio
            // 
            lbl_reqRadio.AutoSize = true;
            lbl_reqRadio.BackColor = Color.Transparent;
            lbl_reqRadio.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_reqRadio.Location = new Point(94, 555);
            lbl_reqRadio.Name = "lbl_reqRadio";
            lbl_reqRadio.Size = new Size(24, 29);
            lbl_reqRadio.TabIndex = 22;
            lbl_reqRadio.Text = "*\r\n";
            lbl_reqRadio.TextAlign = ContentAlignment.MiddleCenter;
            lbl_reqRadio.UseCompatibleTextRendering = true;
            // 
            // lbl_positionAndWorkingHoursLine
            // 
            lbl_positionAndWorkingHoursLine.AutoSize = true;
            lbl_positionAndWorkingHoursLine.BackColor = Color.Transparent;
            lbl_positionAndWorkingHoursLine.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_positionAndWorkingHoursLine.Location = new Point(87, 507);
            lbl_positionAndWorkingHoursLine.Name = "lbl_positionAndWorkingHoursLine";
            lbl_positionAndWorkingHoursLine.Size = new Size(850, 28);
            lbl_positionAndWorkingHoursLine.TabIndex = 16;
            lbl_positionAndWorkingHoursLine.Text = "Position and Working hours ___________________________________________________";
            lbl_positionAndWorkingHoursLine.TextAlign = ContentAlignment.MiddleCenter;
            lbl_positionAndWorkingHoursLine.UseCompatibleTextRendering = true;
            // 
            // cmbBox_suffix
            // 
            cmbBox_suffix.BackColor = Color.FromArgb(41, 41, 41);
            cmbBox_suffix.BorderRadius = 30;
            cmbBox_suffix.Cursor = Cursors.Hand;
            cmbBox_suffix.DrawMode = DrawMode.OwnerDrawFixed;
            cmbBox_suffix.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBox_suffix.FlatStyle = FlatStyle.Flat;
            cmbBox_suffix.Font = new Font("Poppins", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbBox_suffix.ForeColor = Color.White;
            cmbBox_suffix.IntegralHeight = false;
            cmbBox_suffix.Items.AddRange(new object[] { "N/A", "Jr. (Junior)", "Sr. (Senior)", "ll", "lll", "lV", "V", "Vl", "Vll", "Vlll" });
            cmbBox_suffix.Location = new Point(520, 432);
            cmbBox_suffix.Name = "cmbBox_suffix";
            cmbBox_suffix.PlaceholderText = "Suffix";
            cmbBox_suffix.RightToLeft = RightToLeft.No;
            cmbBox_suffix.Size = new Size(210, 37);
            cmbBox_suffix.TabIndex = 18;
            // 
            // txtB_middlename
            // 
            txtB_middlename.BackColor = Color.Transparent;
            txtB_middlename.Font = new Font("Poppins", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtB_middlename.ForeColor = Color.White;
            txtB_middlename.Location = new Point(516, 372);
            txtB_middlename.Margin = new Padding(0);
            txtB_middlename.Name = "txtB_middlename";
            txtB_middlename.PlaceholderText = "Middlename";
            txtB_middlename.RightToLeft = RightToLeft.No;
            txtB_middlename.Size = new Size(400, 40);
            txtB_middlename.TabIndex = 15;
            txtB_middlename.TextPadding = new Padding(30, 0, 30, 0);
            // 
            // txtB_firstname
            // 
            txtB_firstname.BackColor = Color.Transparent;
            txtB_firstname.Font = new Font("Poppins", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtB_firstname.ForeColor = Color.White;
            txtB_firstname.Location = new Point(97, 372);
            txtB_firstname.Margin = new Padding(0);
            txtB_firstname.Name = "txtB_firstname";
            txtB_firstname.PlaceholderText = "* Firstname";
            txtB_firstname.RightToLeft = RightToLeft.No;
            txtB_firstname.Size = new Size(410, 40);
            txtB_firstname.TabIndex = 14;
            txtB_firstname.TextPadding = new Padding(30, 0, 30, 0);
            // 
            // txtB_lastname
            // 
            txtB_lastname.BackColor = Color.Transparent;
            txtB_lastname.Font = new Font("Poppins", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtB_lastname.ForeColor = Color.White;
            txtB_lastname.Location = new Point(97, 432);
            txtB_lastname.Margin = new Padding(0);
            txtB_lastname.Name = "txtB_lastname";
            txtB_lastname.PlaceholderText = "* Lastname";
            txtB_lastname.RightToLeft = RightToLeft.No;
            txtB_lastname.Size = new Size(410, 40);
            txtB_lastname.TabIndex = 13;
            txtB_lastname.TextPadding = new Padding(30, 0, 30, 0);
            // 
            // lbl_fullnameLine
            // 
            lbl_fullnameLine.AutoSize = true;
            lbl_fullnameLine.BackColor = Color.Transparent;
            lbl_fullnameLine.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_fullnameLine.Location = new Point(87, 327);
            lbl_fullnameLine.Name = "lbl_fullnameLine";
            lbl_fullnameLine.Size = new Size(843, 28);
            lbl_fullnameLine.TabIndex = 12;
            lbl_fullnameLine.Text = "Fullname_______________________________________________________________";
            lbl_fullnameLine.TextAlign = ContentAlignment.MiddleCenter;
            lbl_fullnameLine.UseCompatibleTextRendering = true;
            // 
            // btn_register
            // 
            btn_register.BackColor = Color.FromArgb(26, 117, 159);
            btn_register.Cursor = Cursors.Hand;
            btn_register.FlatAppearance.BorderSize = 0;
            btn_register.FlatStyle = FlatStyle.Flat;
            btn_register.Font = new Font("Zona Pro Bold", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_register.ForeColor = Color.White;
            btn_register.Location = new Point(276, 956);
            btn_register.Name = "btn_register";
            btn_register.Size = new Size(510, 54);
            btn_register.TabIndex = 3;
            btn_register.Text = "REGISTER";
            btn_register.UseVisualStyleBackColor = false;
            btn_register.Click += btn_register_Click;
            // 
            // lbl_p
            // 
            lbl_p.AutoSize = true;
            lbl_p.BackColor = Color.Transparent;
            lbl_p.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_p.Location = new Point(400, 280);
            lbl_p.Name = "lbl_p";
            lbl_p.Size = new Size(268, 28);
            lbl_p.TabIndex = 5;
            lbl_p.Text = "Enter the necessary credentials:";
            lbl_p.TextAlign = ContentAlignment.MiddleCenter;
            lbl_p.UseCompatibleTextRendering = true;
            // 
            // lbl_h1
            // 
            lbl_h1.AutoSize = true;
            lbl_h1.BackColor = Color.Transparent;
            lbl_h1.Font = new Font("Zona Pro Bold", 35.9999962F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_h1.Location = new Point(275, 228);
            lbl_h1.Name = "lbl_h1";
            lbl_h1.Size = new Size(523, 52);
            lbl_h1.TabIndex = 1;
            lbl_h1.Text = "Register an Account";
            lbl_h1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // picB_vitalHealthBanner
            // 
            picB_vitalHealthBanner.Image = Properties.Resources.VitalHealth_Banner;
            picB_vitalHealthBanner.Location = new Point(353, 41);
            picB_vitalHealthBanner.Name = "picB_vitalHealthBanner";
            picB_vitalHealthBanner.Size = new Size(355, 109);
            picB_vitalHealthBanner.SizeMode = PictureBoxSizeMode.StretchImage;
            picB_vitalHealthBanner.TabIndex = 0;
            picB_vitalHealthBanner.TabStop = false;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(22, 138, 173);
            BackgroundImage = Properties.Resources.caduceus_symbol_icon_bg;
            ClientSize = new Size(1920, 1080);
            ControlBox = false;
            Controls.Add(pnl_login);
            Controls.Add(btn_back);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisterForm";
            Load += RegisterForm_Load;
            ((System.ComponentModel.ISupportInitialize)btn_back).EndInit();
            pnl_login.ResumeLayout(false);
            pnl_login.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btn_showSecurityAnswer).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_showConfirmPassword).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_showPassword).EndInit();
            ((System.ComponentModel.ISupportInitialize)picB_vitalHealthBanner).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox btn_back;
        private Panel pnl_login;
        private Label btn_registerHere;
        private Label lbl_noAccount;
        private RoundedButton btn_register;
        private RoundedTextBox txtB_username;
        private RoundedTextBox txtB_confirmPassword;
        private RoundedTextBox txtB_password;
        private RoundedTextBox txtB_contactNumber;
        private PictureBox btn_showConfirmPassword;
        private PictureBox btn_showPassword;
        private Label lbl_p;
        private Label lbl_h1;
        private PictureBox picB_vitalHealthBanner;
        private Label lbl_fullnameLine;
        private RoundedTextBox txtB_lastname;
        private RoundedTextBox txtB_middlename;
        private RoundedTextBox txtB_firstname;
        private Label lbl_positionAndWorkingHoursLine;
        private RoundedComboBox cmbBox_suffix;
        private SquareRadioButton rdBtn_nurse;
        private Label lbl_reqRadio;
        private SquareRadioButton rdBtn_doctor;
        private Label lbl_contactandLoginCredLine;
        private RoundedComboBox rCmbBox_specialization;
        private Label lbl_passwordRules;
        private RoundedTextBox txtB_securityAnswer;
        private RoundedTextBox txtB_securityQuestion;
        private Label lbl_exampleQuestion;
        private Label lbl_exampleAnswer;
        private PictureBox btn_showSecurityAnswer;
        private RoundedComboBox cmbWorkingHours;
    }
}