namespace VitalHealth.Forms.Dialogs
{
    partial class saveChangesNurse
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
            noButton = new RoundedButton();
            lbl_message = new Label();
            picB_messageIcon = new PictureBox();
            yesButton = new RoundedButton();
            ((System.ComponentModel.ISupportInitialize)picB_messageIcon).BeginInit();
            SuspendLayout();
            // 
            // noButton
            // 
            noButton.BackColor = Color.FromArgb(26, 117, 159);
            noButton.Cursor = Cursors.Hand;
            noButton.FlatAppearance.BorderSize = 0;
            noButton.FlatStyle = FlatStyle.Flat;
            noButton.Font = new Font("Zona Pro Bold", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            noButton.ForeColor = Color.White;
            noButton.Location = new Point(387, 145);
            noButton.Name = "noButton";
            noButton.Size = new Size(75, 37);
            noButton.TabIndex = 14;
            noButton.Text = "NO";
            noButton.UseVisualStyleBackColor = false;
            noButton.Click += noButton_Click;
            // 
            // lbl_message
            // 
            lbl_message.AutoSize = true;
            lbl_message.BackColor = Color.Transparent;
            lbl_message.Font = new Font("Poppins", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_message.Location = new Point(140, 82);
            lbl_message.Name = "lbl_message";
            lbl_message.Size = new Size(296, 32);
            lbl_message.TabIndex = 13;
            lbl_message.Text = "Save changes to your profile?";
            lbl_message.TextAlign = ContentAlignment.MiddleCenter;
            lbl_message.UseCompatibleTextRendering = true;
            // 
            // picB_messageIcon
            // 
            picB_messageIcon.Cursor = Cursors.Hand;
            picB_messageIcon.Image = Properties.Resources.warning_icon;
            picB_messageIcon.Location = new Point(49, 57);
            picB_messageIcon.Name = "picB_messageIcon";
            picB_messageIcon.Size = new Size(85, 80);
            picB_messageIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            picB_messageIcon.TabIndex = 12;
            picB_messageIcon.TabStop = false;
            // 
            // yesButton
            // 
            yesButton.BackColor = Color.FromArgb(26, 117, 159);
            yesButton.Cursor = Cursors.Hand;
            yesButton.FlatAppearance.BorderSize = 0;
            yesButton.FlatStyle = FlatStyle.Flat;
            yesButton.Font = new Font("Zona Pro Bold", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            yesButton.ForeColor = Color.White;
            yesButton.Location = new Point(299, 145);
            yesButton.Name = "yesButton";
            yesButton.Size = new Size(75, 37);
            yesButton.TabIndex = 15;
            yesButton.Text = "YES";
            yesButton.UseVisualStyleBackColor = false;
            yesButton.Click += yesButton_Click;
            // 
            // saveChanges
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 201);
            Controls.Add(yesButton);
            Controls.Add(noButton);
            Controls.Add(lbl_message);
            Controls.Add(picB_messageIcon);
            FormBorderStyle = FormBorderStyle.None;
            Name = "saveChanges";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)picB_messageIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RoundedButton noButton;
        private Label lbl_message;
        private PictureBox picB_messageIcon;
        private RoundedButton yesButton;
    }
}