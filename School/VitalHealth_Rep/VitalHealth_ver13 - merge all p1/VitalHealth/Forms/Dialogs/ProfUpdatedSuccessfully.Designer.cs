namespace VitalHealth.Forms.Dialogs
{
    partial class ProfUpdatedSuccessfully
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
            btn_ok = new RoundedButton();
            lbl_message = new Label();
            picB_messageIcon = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picB_messageIcon).BeginInit();
            SuspendLayout();
            // 
            // btn_ok
            // 
            btn_ok.BackColor = Color.FromArgb(26, 117, 159);
            btn_ok.Cursor = Cursors.Hand;
            btn_ok.FlatAppearance.BorderSize = 0;
            btn_ok.FlatStyle = FlatStyle.Flat;
            btn_ok.Font = new Font("Zona Pro Bold", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_ok.ForeColor = Color.White;
            btn_ok.Location = new Point(381, 143);
            btn_ok.Name = "btn_ok";
            btn_ok.Size = new Size(75, 37);
            btn_ok.TabIndex = 14;
            btn_ok.Text = "OK";
            btn_ok.UseVisualStyleBackColor = false;
            btn_ok.Click += btn_ok_Click;
            // 
            // lbl_message
            // 
            lbl_message.AutoSize = true;
            lbl_message.BackColor = Color.Transparent;
            lbl_message.Font = new Font("Poppins", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_message.Location = new Point(153, 75);
            lbl_message.Name = "lbl_message";
            lbl_message.Size = new Size(286, 32);
            lbl_message.TabIndex = 13;
            lbl_message.Text = "Profile updated successfully!";
            lbl_message.TextAlign = ContentAlignment.MiddleCenter;
            lbl_message.UseCompatibleTextRendering = true;
            // 
            // picB_messageIcon
            // 
            picB_messageIcon.Image = Properties.Resources.check_icon;
            picB_messageIcon.Location = new Point(46, 45);
            picB_messageIcon.Name = "picB_messageIcon";
            picB_messageIcon.Size = new Size(95, 90);
            picB_messageIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            picB_messageIcon.TabIndex = 12;
            picB_messageIcon.TabStop = false;
            // 
            // ProfUpdatedSuccessfully
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 201);
            Controls.Add(btn_ok);
            Controls.Add(lbl_message);
            Controls.Add(picB_messageIcon);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ProfUpdatedSuccessfully";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)picB_messageIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RoundedButton btn_ok;
        private Label lbl_message;
        private PictureBox picB_messageIcon;
    }
}