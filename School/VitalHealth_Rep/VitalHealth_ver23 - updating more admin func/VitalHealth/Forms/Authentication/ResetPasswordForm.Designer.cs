namespace VitalHealth.Forms.Authentication
{
    partial class ResetPasswordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResetPasswordForm));
            pnl_resetPassword = new Panel();
            lbl_passwordRules = new Label();
            btn_progress = new RoundedButton();
            btn_showConfirmPassword = new PictureBox();
            txtB_confirmPassword = new RoundedTextBox();
            btn_showNewPassword = new PictureBox();
            txtB_newPassword = new RoundedTextBox();
            lbl_setNewPass = new Label();
            btn_showSecurityAnswer = new PictureBox();
            txtB_securityAnswer = new RoundedTextBox();
            rtxtBox_securityQuestion = new RichTextBox();
            txtB_username = new RoundedTextBox();
            lbl_p = new Label();
            lbl_h1 = new Label();
            picB_vitalHealthBanner = new PictureBox();
            btn_back = new PictureBox();
            pnl_resetPassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btn_showConfirmPassword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_showNewPassword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_showSecurityAnswer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picB_vitalHealthBanner).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_back).BeginInit();
            SuspendLayout();
            // 
            // pnl_resetPassword
            // 
            pnl_resetPassword.BackColor = Color.White;
            pnl_resetPassword.Controls.Add(lbl_passwordRules);
            pnl_resetPassword.Controls.Add(btn_progress);
            pnl_resetPassword.Controls.Add(btn_showConfirmPassword);
            pnl_resetPassword.Controls.Add(txtB_confirmPassword);
            pnl_resetPassword.Controls.Add(btn_showNewPassword);
            pnl_resetPassword.Controls.Add(txtB_newPassword);
            pnl_resetPassword.Controls.Add(lbl_setNewPass);
            pnl_resetPassword.Controls.Add(btn_showSecurityAnswer);
            pnl_resetPassword.Controls.Add(txtB_securityAnswer);
            pnl_resetPassword.Controls.Add(rtxtBox_securityQuestion);
            pnl_resetPassword.Controls.Add(txtB_username);
            pnl_resetPassword.Controls.Add(lbl_p);
            pnl_resetPassword.Controls.Add(lbl_h1);
            pnl_resetPassword.Controls.Add(picB_vitalHealthBanner);
            pnl_resetPassword.Dock = DockStyle.Right;
            pnl_resetPassword.Location = new Point(912, 0);
            pnl_resetPassword.Name = "pnl_resetPassword";
            pnl_resetPassword.Size = new Size(992, 1041);
            pnl_resetPassword.TabIndex = 1;
            // 
            // lbl_passwordRules
            // 
            lbl_passwordRules.AutoSize = true;
            lbl_passwordRules.BackColor = Color.Transparent;
            lbl_passwordRules.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_passwordRules.ForeColor = Color.Red;
            lbl_passwordRules.Location = new Point(231, 762);
            lbl_passwordRules.Name = "lbl_passwordRules";
            lbl_passwordRules.Size = new Size(604, 23);
            lbl_passwordRules.TabIndex = 32;
            lbl_passwordRules.Text = "Password must be at least 8 characters with upper, lower, number, and special character.";
            lbl_passwordRules.TextAlign = ContentAlignment.MiddleCenter;
            lbl_passwordRules.UseCompatibleTextRendering = true;
            lbl_passwordRules.Visible = false;
            // 
            // btn_progress
            // 
            btn_progress.BackColor = Color.FromArgb(26, 117, 159);
            btn_progress.Cursor = Cursors.Hand;
            btn_progress.FlatAppearance.BorderSize = 0;
            btn_progress.FlatStyle = FlatStyle.Flat;
            btn_progress.Font = new Font("Zona Pro Bold", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_progress.ForeColor = Color.White;
            btn_progress.Location = new Point(275, 803);
            btn_progress.Name = "btn_progress";
            btn_progress.Size = new Size(510, 54);
            btn_progress.TabIndex = 3;
            btn_progress.Text = "FINALIZE";
            btn_progress.UseVisualStyleBackColor = false;
            btn_progress.Click += btn_progress_Click;
            // 
            // btn_showConfirmPassword
            // 
            btn_showConfirmPassword.BackColor = Color.Transparent;
            btn_showConfirmPassword.Cursor = Cursors.Hand;
            btn_showConfirmPassword.Image = Properties.Resources.hidden_icon;
            btn_showConfirmPassword.Location = new Point(737, 715);
            btn_showConfirmPassword.Name = "btn_showConfirmPassword";
            btn_showConfirmPassword.Size = new Size(32, 32);
            btn_showConfirmPassword.SizeMode = PictureBoxSizeMode.StretchImage;
            btn_showConfirmPassword.TabIndex = 10;
            btn_showConfirmPassword.TabStop = false;
            btn_showConfirmPassword.Visible = false;
            btn_showConfirmPassword.Click += btn_showConfirmPassword_Click;
            // 
            // txtB_confirmPassword
            // 
            txtB_confirmPassword.BackColor = Color.Transparent;
            txtB_confirmPassword.Font = new Font("Poppins", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtB_confirmPassword.ForeColor = Color.White;
            txtB_confirmPassword.Location = new Point(275, 705);
            txtB_confirmPassword.Name = "txtB_confirmPassword";
            txtB_confirmPassword.Padding = new Padding(30, 5, 20, 5);
            txtB_confirmPassword.PlaceholderText = "Confirm Password";
            txtB_confirmPassword.RightToLeft = RightToLeft.No;
            txtB_confirmPassword.Size = new Size(510, 54);
            txtB_confirmPassword.TabIndex = 11;
            txtB_confirmPassword.TextPadding = new Padding(30, 0, 60, 0);
            txtB_confirmPassword.UseSystemPasswordChar = true;
            txtB_confirmPassword.Visible = false;
            // 
            // btn_showNewPassword
            // 
            btn_showNewPassword.BackColor = Color.Transparent;
            btn_showNewPassword.Cursor = Cursors.Hand;
            btn_showNewPassword.Image = Properties.Resources.hidden_icon;
            btn_showNewPassword.Location = new Point(737, 644);
            btn_showNewPassword.Name = "btn_showNewPassword";
            btn_showNewPassword.Size = new Size(32, 32);
            btn_showNewPassword.SizeMode = PictureBoxSizeMode.StretchImage;
            btn_showNewPassword.TabIndex = 2;
            btn_showNewPassword.TabStop = false;
            btn_showNewPassword.Visible = false;
            btn_showNewPassword.Click += btn_showNewPassword_Click;
            // 
            // txtB_newPassword
            // 
            txtB_newPassword.BackColor = Color.Transparent;
            txtB_newPassword.Font = new Font("Poppins", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtB_newPassword.ForeColor = Color.White;
            txtB_newPassword.Location = new Point(275, 634);
            txtB_newPassword.Name = "txtB_newPassword";
            txtB_newPassword.Padding = new Padding(30, 5, 20, 5);
            txtB_newPassword.PlaceholderText = "New Password";
            txtB_newPassword.RightToLeft = RightToLeft.No;
            txtB_newPassword.Size = new Size(510, 54);
            txtB_newPassword.TabIndex = 2;
            txtB_newPassword.TextPadding = new Padding(30, 0, 60, 0);
            txtB_newPassword.UseSystemPasswordChar = true;
            txtB_newPassword.Visible = false;
            // 
            // lbl_setNewPass
            // 
            lbl_setNewPass.AutoSize = true;
            lbl_setNewPass.BackColor = Color.Transparent;
            lbl_setNewPass.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_setNewPass.Location = new Point(465, 608);
            lbl_setNewPass.Name = "lbl_setNewPass";
            lbl_setNewPass.Size = new Size(127, 23);
            lbl_setNewPass.TabIndex = 9;
            lbl_setNewPass.Text = "Set new password";
            lbl_setNewPass.TextAlign = ContentAlignment.MiddleCenter;
            lbl_setNewPass.UseCompatibleTextRendering = true;
            lbl_setNewPass.Visible = false;
            // 
            // btn_showSecurityAnswer
            // 
            btn_showSecurityAnswer.BackColor = Color.Transparent;
            btn_showSecurityAnswer.Cursor = Cursors.Hand;
            btn_showSecurityAnswer.Image = Properties.Resources.hidden_icon;
            btn_showSecurityAnswer.Location = new Point(737, 523);
            btn_showSecurityAnswer.Name = "btn_showSecurityAnswer";
            btn_showSecurityAnswer.Size = new Size(32, 32);
            btn_showSecurityAnswer.SizeMode = PictureBoxSizeMode.StretchImage;
            btn_showSecurityAnswer.TabIndex = 7;
            btn_showSecurityAnswer.TabStop = false;
            btn_showSecurityAnswer.Visible = false;
            btn_showSecurityAnswer.Click += btn_showSecurityAnswer_Click;
            // 
            // txtB_securityAnswer
            // 
            txtB_securityAnswer.BackColor = Color.Transparent;
            txtB_securityAnswer.Font = new Font("Poppins", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtB_securityAnswer.ForeColor = Color.White;
            txtB_securityAnswer.Location = new Point(275, 513);
            txtB_securityAnswer.Name = "txtB_securityAnswer";
            txtB_securityAnswer.Padding = new Padding(30, 5, 20, 5);
            txtB_securityAnswer.PlaceholderText = "Security Answer";
            txtB_securityAnswer.RightToLeft = RightToLeft.No;
            txtB_securityAnswer.Size = new Size(510, 54);
            txtB_securityAnswer.TabIndex = 8;
            txtB_securityAnswer.TextPadding = new Padding(30, 0, 60, 0);
            txtB_securityAnswer.UseSystemPasswordChar = true;
            txtB_securityAnswer.Visible = false;
            // 
            // rtxtBox_securityQuestion
            // 
            rtxtBox_securityQuestion.BorderStyle = BorderStyle.None;
            rtxtBox_securityQuestion.Enabled = false;
            rtxtBox_securityQuestion.Location = new Point(289, 434);
            rtxtBox_securityQuestion.Name = "rtxtBox_securityQuestion";
            rtxtBox_securityQuestion.Size = new Size(480, 73);
            rtxtBox_securityQuestion.TabIndex = 12;
            rtxtBox_securityQuestion.Text = "";
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
            // lbl_p
            // 
            lbl_p.AutoSize = true;
            lbl_p.BackColor = Color.Transparent;
            lbl_p.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_p.Location = new Point(412, 287);
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
            lbl_h1.Location = new Point(334, 238);
            lbl_h1.Name = "lbl_h1";
            lbl_h1.Size = new Size(392, 40);
            lbl_h1.TabIndex = 1;
            lbl_h1.Text = "Resetting Password";
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
            btn_back.TabIndex = 2;
            btn_back.TabStop = false;
            btn_back.Click += btn_back_Click;
            // 
            // ResetPasswordForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(74, 214, 109);
            BackgroundImage = Properties.Resources.caduceus_symbol_icon_bg;
            ClientSize = new Size(1904, 1041);
            ControlBox = false;
            Controls.Add(btn_back);
            Controls.Add(pnl_resetPassword);
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            Name = "ResetPasswordForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ResetPasswordForm";
            Load += ResetPasswordForm_Load;
            pnl_resetPassword.ResumeLayout(false);
            pnl_resetPassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btn_showConfirmPassword).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_showNewPassword).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_showSecurityAnswer).EndInit();
            ((System.ComponentModel.ISupportInitialize)picB_vitalHealthBanner).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_back).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnl_resetPassword;
        private RoundedButton btn_progress;
        private RoundedTextBox txtB_username;
        private PictureBox btn_showNewPassword;
        private RoundedTextBox txtB_newPassword;
        private Label lbl_p;
        private Label lbl_h1;
        private PictureBox picB_vitalHealthBanner;
        private PictureBox btn_back;
        private PictureBox btn_showSecurityAnswer;
        private RoundedTextBox txtB_securityAnswer;
        private RichTextBox rtxtBox_securityQuestion;
        private PictureBox btn_showConfirmPassword;
        private RoundedTextBox txtB_confirmPassword;
        private Label lbl_setNewPass;
        private Label lbl_passwordRules;
    }
}