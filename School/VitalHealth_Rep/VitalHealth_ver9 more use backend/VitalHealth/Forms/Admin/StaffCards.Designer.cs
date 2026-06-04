namespace VitalHealth.Forms.Admin
{
    partial class StaffCards
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
        private void StaffCards_Load(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label4 = new Label();
            lblFullname = new Label();
            label1 = new Label();
            lblRole = new Label();
            label5 = new Label();
            lblSpecialization = new Label();
            label7 = new Label();
            lblStatus = new Label();
            btnAccept = new RoundedButton();
            btnReject = new RoundedButton();
            btnViewInfo = new PictureBox();
            picAccept = new PictureBox();
            picReject = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)btnViewInfo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picAccept).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picReject).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Poppins", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(14, 20);
            label4.Name = "label4";
            label4.Size = new Size(42, 19);
            label4.TabIndex = 13;
            label4.Text = "Name";
            label4.Click += label4_Click;
            // 
            // lblFullname
            // 
            lblFullname.BackColor = Color.Transparent;
            lblFullname.Font = new Font("Zona Pro Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFullname.ForeColor = Color.Black;
            lblFullname.Location = new Point(14, 39);
            lblFullname.Name = "lblFullname";
            lblFullname.Size = new Size(343, 84);
            lblFullname.TabIndex = 14;
            lblFullname.Text = "Full Name";
            lblFullname.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Poppins", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(14, 123);
            label1.Name = "label1";
            label1.Size = new Size(33, 19);
            label1.TabIndex = 15;
            label1.Text = "Role";
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.BackColor = Color.Transparent;
            lblRole.Font = new Font("Zona Pro Bold", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRole.ForeColor = Color.Black;
            lblRole.Location = new Point(14, 142);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(44, 17);
            lblRole.TabIndex = 16;
            lblRole.Text = "Role";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Poppins", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(14, 175);
            label5.Name = "label5";
            label5.Size = new Size(85, 19);
            label5.TabIndex = 17;
            label5.Text = "Specialization";
            // 
            // lblSpecialization
            // 
            lblSpecialization.AutoSize = true;
            lblSpecialization.BackColor = Color.Transparent;
            lblSpecialization.Font = new Font("Zona Pro Bold", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSpecialization.ForeColor = Color.Black;
            lblSpecialization.Location = new Point(14, 194);
            lblSpecialization.Name = "lblSpecialization";
            lblSpecialization.Size = new Size(123, 17);
            lblSpecialization.TabIndex = 18;
            lblSpecialization.Text = "Specialization";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Poppins", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(14, 229);
            label7.Name = "label7";
            label7.Size = new Size(43, 19);
            label7.TabIndex = 19;
            label7.Text = "Status";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.BackColor = Color.Transparent;
            lblStatus.Font = new Font("Zona Pro Bold", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStatus.ForeColor = Color.Black;
            lblStatus.Location = new Point(14, 248);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(61, 17);
            lblStatus.TabIndex = 20;
            lblStatus.Text = "Status";
            // 
            // btnAccept
            // 
            btnAccept.BackColor = Color.FromArgb(37, 147, 65);
            btnAccept.FlatAppearance.BorderSize = 0;
            btnAccept.FlatStyle = FlatStyle.Flat;
            btnAccept.Font = new Font("Poppins", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAccept.ForeColor = Color.White;
            btnAccept.Image = Properties.Resources.approve_icon;
            btnAccept.Location = new Point(23, 323);
            btnAccept.Name = "btnAccept";
            btnAccept.RightToLeft = RightToLeft.No;
            btnAccept.Size = new Size(186, 46);
            btnAccept.TabIndex = 29;
            btnAccept.UseVisualStyleBackColor = false;
            // 
            // btnReject
            // 
            btnReject.BackColor = Color.FromArgb(190, 138, 34);
            btnReject.FlatAppearance.BorderSize = 0;
            btnReject.FlatStyle = FlatStyle.Flat;
            btnReject.Font = new Font("Poppins", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReject.ForeColor = Color.White;
            btnReject.Location = new Point(220, 323);
            btnReject.Name = "btnReject";
            btnReject.RightToLeft = RightToLeft.No;
            btnReject.Size = new Size(186, 46);
            btnReject.TabIndex = 30;
            btnReject.UseVisualStyleBackColor = false;
            // 
            // btnViewInfo
            // 
            btnViewInfo.BackColor = Color.Transparent;
            btnViewInfo.Image = Properties.Resources.info_icon;
            btnViewInfo.Location = new Point(381, 20);
            btnViewInfo.Name = "btnViewInfo";
            btnViewInfo.Size = new Size(25, 25);
            btnViewInfo.SizeMode = PictureBoxSizeMode.StretchImage;
            btnViewInfo.TabIndex = 31;
            btnViewInfo.TabStop = false;
            // 
            // picAccept
            // 
            picAccept.BackColor = Color.FromArgb(37, 147, 65);
            picAccept.Image = Properties.Resources.approve_icon;
            picAccept.Location = new Point(96, 328);
            picAccept.Name = "picAccept";
            picAccept.Size = new Size(47, 37);
            picAccept.SizeMode = PictureBoxSizeMode.StretchImage;
            picAccept.TabIndex = 32;
            picAccept.TabStop = false;
            // 
            // picReject
            // 
            picReject.BackColor = Color.FromArgb(190, 138, 34);
            picReject.Image = Properties.Resources.reject_icon;
            picReject.Location = new Point(295, 328);
            picReject.Name = "picReject";
            picReject.Size = new Size(39, 37);
            picReject.SizeMode = PictureBoxSizeMode.StretchImage;
            picReject.TabIndex = 33;
            picReject.TabStop = false;
            // 
            // StaffCards
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.AdminCardbg2;
            Controls.Add(picReject);
            Controls.Add(picAccept);
            Controls.Add(btnViewInfo);
            Controls.Add(btnReject);
            Controls.Add(btnAccept);
            Controls.Add(lblStatus);
            Controls.Add(label7);
            Controls.Add(lblSpecialization);
            Controls.Add(label5);
            Controls.Add(lblRole);
            Controls.Add(label1);
            Controls.Add(lblFullname);
            Controls.Add(label4);
            Name = "StaffCards";
            Size = new Size(433, 413);
            Load += StaffCards_Load;
            ((System.ComponentModel.ISupportInitialize)btnViewInfo).EndInit();
            ((System.ComponentModel.ISupportInitialize)picAccept).EndInit();
            ((System.ComponentModel.ISupportInitialize)picReject).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label lblFullname;
        private Label label1;
        private Label lblRole;
        private Label label5;
        private Label lblSpecialization;
        private Label label7;
        private Label lblStatus;
        private RoundedButton btnAccept;
        private RoundedButton btnReject;
        private PictureBox btnViewInfo;
        private PictureBox picAccept;
        private PictureBox picReject;
    }
}
