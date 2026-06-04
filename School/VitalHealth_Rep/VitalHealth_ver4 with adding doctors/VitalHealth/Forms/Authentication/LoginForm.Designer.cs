namespace VitalHealth.Forms.Authentication
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            pnl_login = new Panel();
            btn_registerHere = new Label();
            lbl_noAccount = new Label();
            btn_login = new RoundedButton();
            txtB_username = new RoundedTextBox();
            btn_showPassword = new PictureBox();
            txtB_password = new RoundedTextBox();
            lbl_p = new Label();
            lbl_h1 = new Label();
            picB_vitalHealthBanner = new PictureBox();
            btn_back = new PictureBox();
            pnl_login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btn_showPassword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picB_vitalHealthBanner).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_back).BeginInit();
            SuspendLayout();
            // 
            // pnl_login
            // 
            pnl_login.BackColor = Color.White;
            pnl_login.Controls.Add(btn_registerHere);
            pnl_login.Controls.Add(lbl_noAccount);
            pnl_login.Controls.Add(btn_login);
            pnl_login.Controls.Add(txtB_username);
            pnl_login.Controls.Add(btn_showPassword);
            pnl_login.Controls.Add(txtB_password);
            pnl_login.Controls.Add(lbl_p);
            pnl_login.Controls.Add(lbl_h1);
            pnl_login.Controls.Add(picB_vitalHealthBanner);
            pnl_login.Dock = DockStyle.Right;
            pnl_login.Location = new Point(928, 0);
            pnl_login.Name = "pnl_login";
            pnl_login.Size = new Size(992, 1080);
            pnl_login.TabIndex = 0;
            // 
            // btn_registerHere
            // 
            btn_registerHere.AutoSize = true;
            btn_registerHere.BackColor = Color.Transparent;
            btn_registerHere.Cursor = Cursors.Hand;
            btn_registerHere.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_registerHere.ForeColor = Color.FromArgb(4, 80, 140);
            btn_registerHere.Location = new Point(692, 609);
            btn_registerHere.Name = "btn_registerHere";
            btn_registerHere.Size = new Size(93, 23);
            btn_registerHere.TabIndex = 11;
            btn_registerHere.Text = "Register here";
            btn_registerHere.TextAlign = ContentAlignment.MiddleCenter;
            btn_registerHere.UseCompatibleTextRendering = true;
            btn_registerHere.Click += btn_registerHere_Click;
            // 
            // lbl_noAccount
            // 
            lbl_noAccount.AutoSize = true;
            lbl_noAccount.BackColor = Color.Transparent;
            lbl_noAccount.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_noAccount.Location = new Point(275, 609);
            lbl_noAccount.Name = "lbl_noAccount";
            lbl_noAccount.Size = new Size(188, 23);
            lbl_noAccount.TabIndex = 10;
            lbl_noAccount.Text = "Don’t have an account yet?";
            lbl_noAccount.TextAlign = ContentAlignment.MiddleCenter;
            lbl_noAccount.UseCompatibleTextRendering = true;
            // 
            // btn_login
            // 
            btn_login.BackColor = Color.FromArgb(26, 117, 159);
            btn_login.Cursor = Cursors.Hand;
            btn_login.FlatAppearance.BorderSize = 0;
            btn_login.FlatStyle = FlatStyle.Flat;
            btn_login.Font = new Font("Zona Pro Bold", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_login.ForeColor = Color.White;
            btn_login.Location = new Point(275, 552);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(510, 54);
            btn_login.TabIndex = 3;
            btn_login.Text = "LOGIN";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // txtB_username
            // 
            txtB_username.BackColor = Color.Transparent;
            txtB_username.Font = new Font("Poppins", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtB_username.ForeColor = Color.White;
            txtB_username.Location = new Point(275, 368);
            txtB_username.Margin = new Padding(0);
            txtB_username.Name = "txtB_username";
            txtB_username.PlaceholderText = "Username";
            txtB_username.RightToLeft = RightToLeft.No;
            txtB_username.Size = new Size(510, 54);
            txtB_username.TabIndex = 1;
            txtB_username.TextPadding = new Padding(30, 0, 30, 0);
            // 
            // btn_showPassword
            // 
            btn_showPassword.BackColor = Color.Transparent;
            btn_showPassword.Cursor = Cursors.Hand;
            btn_showPassword.Image = Properties.Resources.hidden_icon;
            btn_showPassword.Location = new Point(737, 454);
            btn_showPassword.Name = "btn_showPassword";
            btn_showPassword.Size = new Size(32, 32);
            btn_showPassword.SizeMode = PictureBoxSizeMode.StretchImage;
            btn_showPassword.TabIndex = 2;
            btn_showPassword.TabStop = false;
            btn_showPassword.Click += btn_showPassword_Click;
            // 
            // txtB_password
            // 
            txtB_password.BackColor = Color.Transparent;
            txtB_password.Font = new Font("Poppins", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtB_password.ForeColor = Color.White;
            txtB_password.Location = new Point(275, 444);
            txtB_password.Name = "txtB_password";
            txtB_password.Padding = new Padding(30, 5, 20, 5);
            txtB_password.PlaceholderText = "Password";
            txtB_password.RightToLeft = RightToLeft.No;
            txtB_password.Size = new Size(510, 54);
            txtB_password.TabIndex = 2;
            txtB_password.TextPadding = new Padding(30, 0, 60, 0);
            txtB_password.UseSystemPasswordChar = true;
            // 
            // lbl_p
            // 
            lbl_p.AutoSize = true;
            lbl_p.BackColor = Color.Transparent;
            lbl_p.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_p.Location = new Point(412, 307);
            lbl_p.Name = "lbl_p";
            lbl_p.Size = new Size(217, 23);
            lbl_p.TabIndex = 5;
            lbl_p.Text = "Enter the necessary credentials:";
            lbl_p.TextAlign = ContentAlignment.MiddleCenter;
            lbl_p.UseCompatibleTextRendering = true;
            // 
            // lbl_h1
            // 
            lbl_h1.AutoSize = true;
            lbl_h1.BackColor = Color.Transparent;
            lbl_h1.Font = new Font("Zona Pro Bold", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_h1.Location = new Point(313, 256);
            lbl_h1.Name = "lbl_h1";
            lbl_h1.Size = new Size(447, 40);
            lbl_h1.TabIndex = 1;
            lbl_h1.Text = "Login to your account.";
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
            // btn_back
            // 
            btn_back.Cursor = Cursors.Hand;
            btn_back.Image = (Image)resources.GetObject("btn_back.Image");
            btn_back.Location = new Point(53, 43);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(53, 53);
            btn_back.SizeMode = PictureBoxSizeMode.StretchImage;
            btn_back.TabIndex = 1;
            btn_back.TabStop = false;
            btn_back.Click += btn_back_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(74, 214, 109);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1920, 1080);
            ControlBox = false;
            Controls.Add(btn_back);
            Controls.Add(pnl_login);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "LoginForm";
            pnl_login.ResumeLayout(false);
            pnl_login.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btn_showPassword).EndInit();
            ((System.ComponentModel.ISupportInitialize)picB_vitalHealthBanner).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_back).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnl_login;
        private PictureBox picB_vitalHealthBanner;
        private Label lbl_h1;
        private Label lbl_p;
        private PictureBox btn_back;
        private RoundedTextBox txtB_username;
        private RoundedTextBox txtB_password;
        private RoundedButton btn_login;
        private PictureBox btn_showPassword;
        private Label lbl_noAccount;
        private Label btn_registerHere;
    }
}