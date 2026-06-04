namespace VitalHealth.Forms.Dialogs
{
    partial class ConfirmActionDialog
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
            btn_yes = new RoundedButton();
            lbl_message = new Label();
            picB_messageIcon = new PictureBox();
            btn_no = new RoundedButton();
            ((System.ComponentModel.ISupportInitialize)picB_messageIcon).BeginInit();
            SuspendLayout();
            // 
            // btn_yes
            // 
            btn_yes.BackColor = Color.FromArgb(26, 117, 159);
            btn_yes.Cursor = Cursors.Hand;
            btn_yes.FlatAppearance.BorderSize = 0;
            btn_yes.FlatStyle = FlatStyle.Flat;
            btn_yes.Font = new Font("Zona Pro Bold", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_yes.ForeColor = Color.White;
            btn_yes.Location = new Point(507, 202);
            btn_yes.Name = "btn_yes";
            btn_yes.Size = new Size(75, 37);
            btn_yes.TabIndex = 14;
            btn_yes.Text = "YES";
            btn_yes.UseVisualStyleBackColor = false;
            btn_yes.Click += btn_yes_Click;
            // 
            // lbl_message
            // 
            lbl_message.AutoSize = true;
            lbl_message.BackColor = Color.Transparent;
            lbl_message.Font = new Font("Poppins", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_message.Location = new Point(196, 108);
            lbl_message.Name = "lbl_message";
            lbl_message.Size = new Size(330, 32);
            lbl_message.TabIndex = 13;
            lbl_message.Text = "Are you sure you want to Logout?";
            lbl_message.TextAlign = ContentAlignment.MiddleCenter;
            lbl_message.UseCompatibleTextRendering = true;
            // 
            // picB_messageIcon
            // 
            picB_messageIcon.Cursor = Cursors.Hand;
            picB_messageIcon.Image = Properties.Resources.warning_icon;
            picB_messageIcon.Location = new Point(95, 78);
            picB_messageIcon.Name = "picB_messageIcon";
            picB_messageIcon.Size = new Size(95, 90);
            picB_messageIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            picB_messageIcon.TabIndex = 12;
            picB_messageIcon.TabStop = false;
            // 
            // btn_no
            // 
            btn_no.BackColor = Color.Brown;
            btn_no.Cursor = Cursors.Hand;
            btn_no.FlatAppearance.BorderSize = 0;
            btn_no.FlatStyle = FlatStyle.Flat;
            btn_no.Font = new Font("Zona Pro Bold", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_no.ForeColor = Color.White;
            btn_no.Location = new Point(426, 202);
            btn_no.Name = "btn_no";
            btn_no.Size = new Size(75, 37);
            btn_no.TabIndex = 15;
            btn_no.Text = "NO";
            btn_no.UseVisualStyleBackColor = false;
            btn_no.Click += btn_no_Click;
            // 
            // ConfirmActionDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(620, 270);
            ControlBox = false;
            Controls.Add(btn_no);
            Controls.Add(btn_yes);
            Controls.Add(lbl_message);
            Controls.Add(picB_messageIcon);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ConfirmActionDialog";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ConfirmActionDialog";
            ((System.ComponentModel.ISupportInitialize)picB_messageIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RoundedButton btn_yes;
        private Label lbl_message;
        private PictureBox picB_messageIcon;
        private RoundedButton btn_no;
    }
}