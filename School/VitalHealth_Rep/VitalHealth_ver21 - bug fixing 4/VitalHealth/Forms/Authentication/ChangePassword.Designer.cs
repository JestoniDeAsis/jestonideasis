namespace VitalHealth.Forms.Authentication
{
    partial class ChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePassword));
            pnl_resetPassword = new Panel();
            lbl_passwordRules = new Label();
            btn_progress = new RoundedButton();
            btn_showConfirmPassword = new PictureBox();
            txtB_confirmPassword = new RoundedTextBox();
            btn_showNewPassword = new PictureBox();
            txtB_newPassword = new RoundedTextBox();
            lbl_setNewPass = new Label();
            btn_showCurrPassword = new PictureBox();
            txtB_currPassword = new RoundedTextBox();
            lbl_h1 = new Label();
            picB_vitalHealthBanner = new PictureBox();
            btn_back = new PictureBox();
            pnl_resetPassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btn_showConfirmPassword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_showNewPassword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_showCurrPassword).BeginInit();
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
            pnl_resetPassword.Controls.Add(btn_showCurrPassword);
            pnl_resetPassword.Controls.Add(txtB_currPassword);
            pnl_resetPassword.Controls.Add(lbl_h1);
            pnl_resetPassword.Controls.Add(picB_vitalHealthBanner);
            pnl_resetPassword.Dock = DockStyle.Right;
            pnl_resetPassword.Location = new Point(912, 0);
            pnl_resetPassword.Name = "pnl_resetPassword";
            pnl_resetPassword.Size = new Size(992, 1041);
            pnl_resetPassword.TabIndex = 2;
            // 
            // lbl_passwordRules
            // 
            lbl_passwordRules.AutoSize = true;
            lbl_passwordRules.BackColor = Color.Transparent;
            lbl_passwordRules.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_passwordRules.ForeColor = Color.Red;
            lbl_passwordRules.Location = new Point(231, 567);
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
            btn_progress.Location = new Point(275, 620);
            btn_progress.Name = "btn_progress";
            btn_progress.Size = new Size(510, 54);
            btn_progress.TabIndex = 3;
            btn_progress.Text = "CONFIRM";
            btn_progress.UseVisualStyleBackColor = false;
            btn_progress.Click += btn_progress_Click;
            // 
            // btn_showConfirmPassword
            // 
            btn_showConfirmPassword.BackColor = Color.Transparent;
            btn_showConfirmPassword.Cursor = Cursors.Hand;
            btn_showConfirmPassword.Image = Properties.Resources.hidden_icon;
            btn_showConfirmPassword.Location = new Point(737, 520);
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
            txtB_confirmPassword.Location = new Point(275, 510);
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
            btn_showNewPassword.Location = new Point(737, 449);
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
            txtB_newPassword.Location = new Point(275, 439);
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
            lbl_setNewPass.Location = new Point(465, 413);
            lbl_setNewPass.Name = "lbl_setNewPass";
            lbl_setNewPass.Size = new Size(127, 23);
            lbl_setNewPass.TabIndex = 9;
            lbl_setNewPass.Text = "Set new password";
            lbl_setNewPass.TextAlign = ContentAlignment.MiddleCenter;
            lbl_setNewPass.UseCompatibleTextRendering = true;
            lbl_setNewPass.Visible = false;
            // 
            // btn_showCurrPassword
            // 
            btn_showCurrPassword.BackColor = Color.Transparent;
            btn_showCurrPassword.Cursor = Cursors.Hand;
            btn_showCurrPassword.Image = Properties.Resources.hidden_icon;
            btn_showCurrPassword.Location = new Point(737, 328);
            btn_showCurrPassword.Name = "btn_showCurrPassword";
            btn_showCurrPassword.Size = new Size(32, 32);
            btn_showCurrPassword.SizeMode = PictureBoxSizeMode.StretchImage;
            btn_showCurrPassword.TabIndex = 7;
            btn_showCurrPassword.TabStop = false;
            btn_showCurrPassword.Click += btn_showCurrPassword_Click;
            // 
            // txtB_currPassword
            // 
            txtB_currPassword.BackColor = Color.Transparent;
            txtB_currPassword.Font = new Font("Poppins", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtB_currPassword.ForeColor = Color.White;
            txtB_currPassword.Location = new Point(275, 318);
            txtB_currPassword.Name = "txtB_currPassword";
            txtB_currPassword.Padding = new Padding(30, 5, 20, 5);
            txtB_currPassword.PlaceholderText = "Current Password";
            txtB_currPassword.RightToLeft = RightToLeft.No;
            txtB_currPassword.Size = new Size(510, 54);
            txtB_currPassword.TabIndex = 8;
            txtB_currPassword.TextPadding = new Padding(30, 0, 60, 0);
            txtB_currPassword.UseSystemPasswordChar = true;
            // 
            // lbl_h1
            // 
            lbl_h1.AutoSize = true;
            lbl_h1.BackColor = Color.Transparent;
            lbl_h1.Font = new Font("Zona Pro Bold", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_h1.Location = new Point(334, 238);
            lbl_h1.Name = "lbl_h1";
            lbl_h1.Size = new Size(395, 40);
            lbl_h1.TabIndex = 1;
            lbl_h1.Text = "Changing Password";
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
            btn_back.TabIndex = 3;
            btn_back.TabStop = false;
            btn_back.Click += btn_back_Click;
            // 
            // ChangePassword
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
            Name = "ChangePassword";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ChangePassword";
            Load += ChangePassword_Load;
            pnl_resetPassword.ResumeLayout(false);
            pnl_resetPassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btn_showConfirmPassword).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_showNewPassword).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_showCurrPassword).EndInit();
            ((System.ComponentModel.ISupportInitialize)picB_vitalHealthBanner).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_back).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnl_resetPassword;
        private Label lbl_passwordRules;
        private RoundedButton btn_progress;
        private PictureBox btn_showConfirmPassword;
        private RoundedTextBox txtB_confirmPassword;
        private PictureBox btn_showNewPassword;
        private RoundedTextBox txtB_newPassword;
        private Label lbl_setNewPass;
        private PictureBox btn_showCurrPassword;
        private RoundedTextBox txtB_currPassword;
        private Label lbl_h1;
        private PictureBox picB_vitalHealthBanner;
        private PictureBox btn_back;
    }
}