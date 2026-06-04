namespace VitalHealth.Forms.Nurse
{
    partial class EditNurseProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditNurseProfile));
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            backNursePage = new PictureBox();
            roundedPanel1 = new VitalHealth.CustomControls.RoundedPanel();
            btn_changePassword = new Label();
            txtB_contanctNum = new RoundedTextBox();
            label11 = new Label();
            rcmbBox_suffix = new RoundedComboBox();
            txtB_middlename = new RoundedTextBox();
            txtB_firstname = new RoundedTextBox();
            txtB_lastname = new RoundedTextBox();
            label9 = new Label();
            updateButton = new RoundedButton();
            label8 = new Label();
            label6 = new Label();
            lbl_username = new Label();
            label13 = new Label();
            lbl_employeeID = new Label();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)backNursePage).BeginInit();
            roundedPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(backNursePage);
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(560, 1081);
            panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.nurse_edit_icon;
            pictureBox2.Location = new Point(-139, 104);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(826, 673);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // backNursePage
            // 
            backNursePage.BackColor = Color.Transparent;
            backNursePage.Image = Properties.Resources.back_icon;
            backNursePage.Location = new Point(27, 34);
            backNursePage.Name = "backNursePage";
            backNursePage.Size = new Size(72, 64);
            backNursePage.SizeMode = PictureBoxSizeMode.StretchImage;
            backNursePage.TabIndex = 0;
            backNursePage.TabStop = false;
            backNursePage.Click += backNursePage_Click;
            // 
            // roundedPanel1
            // 
            roundedPanel1.BackColor = Color.White;
            roundedPanel1.BorderRadius = 30;
            roundedPanel1.Controls.Add(btn_changePassword);
            roundedPanel1.Controls.Add(txtB_contanctNum);
            roundedPanel1.Controls.Add(label11);
            roundedPanel1.Controls.Add(rcmbBox_suffix);
            roundedPanel1.Controls.Add(txtB_middlename);
            roundedPanel1.Controls.Add(txtB_firstname);
            roundedPanel1.Controls.Add(txtB_lastname);
            roundedPanel1.Controls.Add(label9);
            roundedPanel1.Controls.Add(updateButton);
            roundedPanel1.Controls.Add(label8);
            roundedPanel1.Controls.Add(label6);
            roundedPanel1.Controls.Add(lbl_username);
            roundedPanel1.Controls.Add(label13);
            roundedPanel1.Controls.Add(lbl_employeeID);
            roundedPanel1.Controls.Add(label3);
            roundedPanel1.Location = new Point(630, 168);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Size = new Size(1175, 769);
            roundedPanel1.TabIndex = 1;
            // 
            // btn_changePassword
            // 
            btn_changePassword.AutoSize = true;
            btn_changePassword.BackColor = Color.Transparent;
            btn_changePassword.Cursor = Cursors.Hand;
            btn_changePassword.Font = new Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_changePassword.ForeColor = Color.FromArgb(4, 80, 140);
            btn_changePassword.Location = new Point(167, 486);
            btn_changePassword.Name = "btn_changePassword";
            btn_changePassword.Size = new Size(146, 26);
            btn_changePassword.TabIndex = 118;
            btn_changePassword.Text = "Change Password";
            btn_changePassword.TextAlign = ContentAlignment.MiddleCenter;
            btn_changePassword.UseCompatibleTextRendering = true;
            btn_changePassword.Click += btn_changePassword_Click;
            // 
            // txtB_contanctNum
            // 
            txtB_contanctNum.BackColor = Color.Transparent;
            txtB_contanctNum.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtB_contanctNum.Location = new Point(404, 400);
            txtB_contanctNum.Name = "txtB_contanctNum";
            txtB_contanctNum.PlaceholderText = "*Contact Number (+63)";
            txtB_contanctNum.Size = new Size(368, 40);
            txtB_contanctNum.TabIndex = 117;
            txtB_contanctNum.Theme = ControlTheme.Light;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold);
            label11.Location = new Point(152, 404);
            label11.Name = "label11";
            label11.Size = new Size(185, 26);
            label11.TabIndex = 116;
            label11.Text = "Contact Number";
            // 
            // rcmbBox_suffix
            // 
            rcmbBox_suffix.BackColor = Color.White;
            rcmbBox_suffix.DrawMode = DrawMode.OwnerDrawFixed;
            rcmbBox_suffix.DropDownStyle = ComboBoxStyle.DropDownList;
            rcmbBox_suffix.Font = new Font("Poppins", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rcmbBox_suffix.ForeColor = Color.Black;
            rcmbBox_suffix.FormattingEnabled = true;
            rcmbBox_suffix.IntegralHeight = false;
            rcmbBox_suffix.Items.AddRange(new object[] { "", "Jr. (Junior)", "Sr. (Senior)", "I", "II", "III", "IV", "V", "VI", "VII", "VIII" });
            rcmbBox_suffix.Location = new Point(675, 333);
            rcmbBox_suffix.Name = "rcmbBox_suffix";
            rcmbBox_suffix.PlaceholderText = "*Suffix";
            rcmbBox_suffix.Size = new Size(211, 37);
            rcmbBox_suffix.TabIndex = 115;
            rcmbBox_suffix.Theme = ControlTheme.Light;
            // 
            // txtB_middlename
            // 
            txtB_middlename.BackColor = Color.Transparent;
            txtB_middlename.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtB_middlename.Location = new Point(414, 330);
            txtB_middlename.Name = "txtB_middlename";
            txtB_middlename.PlaceholderText = "Middle name";
            txtB_middlename.Size = new Size(255, 40);
            txtB_middlename.TabIndex = 114;
            txtB_middlename.Theme = ControlTheme.Light;
            // 
            // txtB_firstname
            // 
            txtB_firstname.BackColor = Color.Transparent;
            txtB_firstname.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtB_firstname.Location = new Point(675, 284);
            txtB_firstname.Name = "txtB_firstname";
            txtB_firstname.PlaceholderText = "*First name";
            txtB_firstname.Size = new Size(256, 40);
            txtB_firstname.TabIndex = 113;
            txtB_firstname.Theme = ControlTheme.Light;
            // 
            // txtB_lastname
            // 
            txtB_lastname.BackColor = Color.Transparent;
            txtB_lastname.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtB_lastname.Location = new Point(414, 284);
            txtB_lastname.Name = "txtB_lastname";
            txtB_lastname.PlaceholderText = "*Last name";
            txtB_lastname.Size = new Size(256, 40);
            txtB_lastname.TabIndex = 112;
            txtB_lastname.Theme = ControlTheme.Light;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold);
            label9.Location = new Point(152, 284);
            label9.Name = "label9";
            label9.Size = new Size(121, 26);
            label9.TabIndex = 111;
            label9.Text = "Full Name";
            // 
            // updateButton
            // 
            updateButton.BackColor = Color.FromArgb(5, 137, 38);
            updateButton.FlatAppearance.BorderSize = 0;
            updateButton.FlatStyle = FlatStyle.Flat;
            updateButton.Font = new Font("Zona Pro Bold", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            updateButton.ForeColor = Color.White;
            updateButton.Location = new Point(515, 588);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(200, 45);
            updateButton.TabIndex = 110;
            updateButton.Text = "UPDATE";
            updateButton.UseVisualStyleBackColor = false;
            updateButton.Click += updateButton_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Zona Pro Bold", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.LightGray;
            label8.ImageAlign = ContentAlignment.MiddleRight;
            label8.Location = new Point(85, 223);
            label8.Name = "label8";
            label8.Size = new Size(516, 21);
            label8.TabIndex = 101;
            label8.Text = "______________________________________________";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Zona Pro Bold", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.ImageAlign = ContentAlignment.MiddleRight;
            label6.Location = new Point(153, 144);
            label6.Name = "label6";
            label6.Size = new Size(120, 23);
            label6.TabIndex = 99;
            label6.Text = "Username";
            // 
            // lbl_username
            // 
            lbl_username.AutoSize = true;
            lbl_username.Font = new Font("Zona Pro Bold", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_username.ForeColor = Color.DimGray;
            lbl_username.ImageAlign = ContentAlignment.MiddleRight;
            lbl_username.Location = new Point(406, 146);
            lbl_username.Name = "lbl_username";
            lbl_username.Size = new Size(110, 21);
            lbl_username.TabIndex = 100;
            lbl_username.Text = "Username";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Zona Pro Bold", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.Black;
            label13.ImageAlign = ContentAlignment.MiddleRight;
            label13.Location = new Point(153, 105);
            label13.Name = "label13";
            label13.Size = new Size(145, 23);
            label13.TabIndex = 95;
            label13.Text = "Employee ID";
            // 
            // lbl_employeeID
            // 
            lbl_employeeID.AutoSize = true;
            lbl_employeeID.Font = new Font("Zona Pro Bold", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_employeeID.ForeColor = Color.DimGray;
            lbl_employeeID.ImageAlign = ContentAlignment.MiddleRight;
            lbl_employeeID.Location = new Point(406, 107);
            lbl_employeeID.Name = "lbl_employeeID";
            lbl_employeeID.Size = new Size(97, 21);
            lbl_employeeID.TabIndex = 96;
            lbl_employeeID.Text = "123123-N";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Zona Pro Bold", 23.9999962F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(164, 35);
            label3.Name = "label3";
            label3.Size = new Size(360, 35);
            label3.TabIndex = 12;
            label3.Text = "Personal Information";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.WindowFrame;
            label1.Location = new Point(604, 103);
            label1.Name = "label1";
            label1.Size = new Size(369, 25);
            label1.TabIndex = 10;
            label1.Text = "Update your personal information.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Zona Pro Bold", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(601, 60);
            label2.Name = "label2";
            label2.Size = new Size(215, 38);
            label2.TabIndex = 9;
            label2.Text = "Edit Profile";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.VitalHealth_Logo;
            pictureBox1.Location = new Point(1262, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(83, 83);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // EditNurseProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(229, 231, 231);
            ClientSize = new Size(1920, 1080);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(roundedPanel1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EditNurseProfile";
            Text = "Form1";
            Load += EditNurseProfile_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)backNursePage).EndInit();
            roundedPanel1.ResumeLayout(false);
            roundedPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox backNursePage;
        private PictureBox pictureBox2;
        private CustomControls.RoundedPanel roundedPanel1;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label13;
        private Label lbl_employeeID;
        private Label label6;
        private Label lbl_username;
        private Label label8;
        private RoundedButton updateButton;
        private RoundedComboBox rcmbBox_suffix;
        private RoundedTextBox txtB_middlename;
        private RoundedTextBox txtB_firstname;
        private RoundedTextBox txtB_lastname;
        private Label label9;
        private Label btn_changePassword;
        private RoundedTextBox txtB_contanctNum;
        private Label label11;
    }
}