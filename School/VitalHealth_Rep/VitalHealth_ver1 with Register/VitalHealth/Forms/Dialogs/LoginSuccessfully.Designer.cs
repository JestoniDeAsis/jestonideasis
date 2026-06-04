namespace VitalHealth.Forms.Dialogs
{
    partial class LoginSuccessfully
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
            picB_messageIcon = new PictureBox();
            lbl_message = new Label();
            btn_ok = new RoundedButton();
            ((System.ComponentModel.ISupportInitialize)picB_messageIcon).BeginInit();
            SuspendLayout();
            // 
            // picB_messageIcon
            // 
            picB_messageIcon.Cursor = Cursors.Hand;
            picB_messageIcon.Image = Properties.Resources.check_icon;
            picB_messageIcon.Location = new Point(88, 54);
            picB_messageIcon.Name = "picB_messageIcon";
            picB_messageIcon.Size = new Size(95, 90);
            picB_messageIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            picB_messageIcon.TabIndex = 3;
            picB_messageIcon.TabStop = false;
            // 
            // lbl_message
            // 
            lbl_message.AutoSize = true;
            lbl_message.BackColor = Color.Transparent;
            lbl_message.Font = new Font("Poppins", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_message.Location = new Point(189, 84);
            lbl_message.Name = "lbl_message";
            lbl_message.Size = new Size(188, 32);
            lbl_message.TabIndex = 7;
            lbl_message.Text = "Login successfully!";
            lbl_message.TextAlign = ContentAlignment.MiddleCenter;
            lbl_message.UseCompatibleTextRendering = true;
            // 
            // btn_ok
            // 
            btn_ok.BackColor = Color.FromArgb(26, 117, 159);
            btn_ok.Cursor = Cursors.Hand;
            btn_ok.FlatAppearance.BorderSize = 0;
            btn_ok.FlatStyle = FlatStyle.Flat;
            btn_ok.Font = new Font("Zona Pro Bold", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_ok.ForeColor = Color.White;
            btn_ok.Location = new Point(397, 152);
            btn_ok.Name = "btn_ok";
            btn_ok.Size = new Size(75, 37);
            btn_ok.TabIndex = 11;
            btn_ok.Text = "OK";
            btn_ok.UseVisualStyleBackColor = false;
            btn_ok.Click += btn_ok_Click;
            // 
            // LoginSuccessfully
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 201);
            ControlBox = false;
            Controls.Add(btn_ok);
            Controls.Add(lbl_message);
            Controls.Add(picB_messageIcon);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginSuccessfully";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "LoginSuccessfully";
            ((System.ComponentModel.ISupportInitialize)picB_messageIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picB_messageIcon;
        private Label lbl_message;
        private RoundedButton btn_ok;
    }
}