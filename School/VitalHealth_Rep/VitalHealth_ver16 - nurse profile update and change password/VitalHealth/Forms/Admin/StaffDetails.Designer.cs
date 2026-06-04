namespace VitalHealth.Forms.Admin
{
    partial class ViewInfo
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
            panel1 = new Panel();
            btnBack = new PictureBox();
            lblFullname = new Label();
            label4 = new Label();
            label1 = new Label();
            lblEmployeeID = new Label();
            label5 = new Label();
            lblRole = new Label();
            lblSpecialization = new Label();
            label8 = new Label();
            cmbWorkingHours = new RoundedComboBox();
            lblStatus = new Label();
            label10 = new Label();
            label12 = new Label();
            lblUsername = new Label();
            lblContactNumber = new Label();
            label14 = new Label();
            picReject = new PictureBox();
            picAccept = new PictureBox();
            btnReject = new RoundedButton();
            btnAccept2 = new RoundedButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnBack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picReject).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picAccept).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(45, 198, 83);
            panel1.Controls.Add(btnBack);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(58, 406);
            panel1.TabIndex = 0;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Transparent;
            btnBack.BackgroundImageLayout = ImageLayout.Zoom;
            btnBack.Cursor = Cursors.Hand;
            btnBack.Image = Properties.Resources.back_icon;
            btnBack.Location = new Point(17, 22);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(23, 27);
            btnBack.SizeMode = PictureBoxSizeMode.StretchImage;
            btnBack.TabIndex = 36;
            btnBack.TabStop = false;
            // 
            // lblFullname
            // 
            lblFullname.BackColor = Color.Transparent;
            lblFullname.Font = new Font("Zona Pro Bold", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFullname.ForeColor = Color.Black;
            lblFullname.Location = new Point(110, 68);
            lblFullname.Name = "lblFullname";
            lblFullname.Size = new Size(343, 38);
            lblFullname.TabIndex = 16;
            lblFullname.Text = "Full Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(110, 45);
            label4.Name = "label4";
            label4.Size = new Size(60, 28);
            label4.TabIndex = 15;
            label4.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Poppins", 11.25F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(110, 148);
            label1.Name = "label1";
            label1.Size = new Size(107, 26);
            label1.TabIndex = 17;
            label1.Text = "Employee I.D";
            // 
            // lblEmployeeID
            // 
            lblEmployeeID.AutoSize = true;
            lblEmployeeID.BackColor = Color.Transparent;
            lblEmployeeID.Font = new Font("Zona Pro Bold", 15.7499981F);
            lblEmployeeID.ForeColor = Color.Black;
            lblEmployeeID.Location = new Point(115, 171);
            lblEmployeeID.Name = "lblEmployeeID";
            lblEmployeeID.Size = new Size(150, 23);
            lblEmployeeID.TabIndex = 18;
            lblEmployeeID.Text = "Employee I.D";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Poppins", 11.25F);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(110, 204);
            label5.Name = "label5";
            label5.Size = new Size(44, 26);
            label5.TabIndex = 19;
            label5.Text = "Role";
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.BackColor = Color.Transparent;
            lblRole.Font = new Font("Zona Pro Bold", 15.7499981F);
            lblRole.ForeColor = Color.Black;
            lblRole.Location = new Point(115, 227);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(58, 23);
            lblRole.TabIndex = 20;
            lblRole.Text = "Role";
            // 
            // lblSpecialization
            // 
            lblSpecialization.AutoSize = true;
            lblSpecialization.BackColor = Color.Transparent;
            lblSpecialization.Font = new Font("Zona Pro Bold", 15.7499981F);
            lblSpecialization.ForeColor = Color.Black;
            lblSpecialization.Location = new Point(115, 285);
            lblSpecialization.Name = "lblSpecialization";
            lblSpecialization.Size = new Size(163, 23);
            lblSpecialization.TabIndex = 22;
            lblSpecialization.Text = "Specialization";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Poppins", 11.25F);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(110, 262);
            label8.Name = "label8";
            label8.Size = new Size(117, 26);
            label8.TabIndex = 21;
            label8.Text = "Specialization";
            // 
            // cmbWorkingHours
            // 
            cmbWorkingHours.BackColor = Color.FromArgb(41, 41, 41);
            cmbWorkingHours.DrawMode = DrawMode.OwnerDrawFixed;
            cmbWorkingHours.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbWorkingHours.Font = new Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbWorkingHours.ForeColor = Color.White;
            cmbWorkingHours.FormattingEnabled = true;
            cmbWorkingHours.IntegralHeight = false;
            cmbWorkingHours.Items.AddRange(new object[] { "8:00 am - 12:00 pm", "1:00 pm - 5:00 pm" });
            cmbWorkingHours.Location = new Point(326, 156);
            cmbWorkingHours.Name = "cmbWorkingHours";
            cmbWorkingHours.PlaceholderText = "Select Working Hours";
            cmbWorkingHours.Size = new Size(209, 31);
            cmbWorkingHours.TabIndex = 23;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.BackColor = Color.Transparent;
            lblStatus.Font = new Font("Zona Pro Bold", 15.7499981F);
            lblStatus.ForeColor = Color.Black;
            lblStatus.Location = new Point(326, 227);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(80, 23);
            lblStatus.TabIndex = 25;
            lblStatus.Text = "Status";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Poppins", 11.25F);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(321, 204);
            label10.Name = "label10";
            label10.Size = new Size(59, 26);
            label10.TabIndex = 24;
            label10.Text = "Status";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Poppins", 11.25F);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(581, 148);
            label12.Name = "label12";
            label12.Size = new Size(89, 26);
            label12.TabIndex = 26;
            label12.Text = "Username";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.BackColor = Color.Transparent;
            lblUsername.Font = new Font("Zona Pro Bold", 15.7499981F);
            lblUsername.ForeColor = Color.Black;
            lblUsername.Location = new Point(586, 171);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(120, 23);
            lblUsername.TabIndex = 27;
            lblUsername.Text = "Username";
            // 
            // lblContactNumber
            // 
            lblContactNumber.AutoSize = true;
            lblContactNumber.BackColor = Color.Transparent;
            lblContactNumber.Font = new Font("Zona Pro Bold", 15.7499981F);
            lblContactNumber.ForeColor = Color.Black;
            lblContactNumber.Location = new Point(586, 227);
            lblContactNumber.Name = "lblContactNumber";
            lblContactNumber.Size = new Size(190, 23);
            lblContactNumber.TabIndex = 29;
            lblContactNumber.Text = "Contact Number";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.Font = new Font("Poppins", 11.25F);
            label14.ForeColor = Color.Black;
            label14.Location = new Point(581, 204);
            label14.Name = "label14";
            label14.Size = new Size(138, 26);
            label14.TabIndex = 28;
            label14.Text = "Contact Number";
            // 
            // picReject
            // 
            picReject.BackColor = Color.FromArgb(190, 138, 34);
            picReject.Image = Properties.Resources.reject_icon;
            picReject.Location = new Point(706, 324);
            picReject.Name = "picReject";
            picReject.Size = new Size(30, 30);
            picReject.SizeMode = PictureBoxSizeMode.StretchImage;
            picReject.TabIndex = 37;
            picReject.TabStop = false;
            // 
            // picAccept
            // 
            picAccept.BackColor = Color.FromArgb(37, 147, 65);
            picAccept.Image = Properties.Resources.approve_icon;
            picAccept.Location = new Point(507, 324);
            picAccept.Name = "picAccept";
            picAccept.Size = new Size(38, 30);
            picAccept.SizeMode = PictureBoxSizeMode.StretchImage;
            picAccept.TabIndex = 36;
            picAccept.TabStop = false;
            // 
            // btnReject
            // 
            btnReject.BackColor = Color.FromArgb(190, 138, 34);
            btnReject.FlatAppearance.BorderSize = 0;
            btnReject.FlatStyle = FlatStyle.Flat;
            btnReject.Font = new Font("Poppins", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReject.ForeColor = Color.White;
            btnReject.Location = new Point(631, 319);
            btnReject.Name = "btnReject";
            btnReject.RightToLeft = RightToLeft.No;
            btnReject.Size = new Size(177, 39);
            btnReject.TabIndex = 35;
            btnReject.UseVisualStyleBackColor = false;
            // 
            // btnAccept2
            // 
            btnAccept2.BackColor = Color.FromArgb(37, 147, 65);
            btnAccept2.FlatAppearance.BorderSize = 0;
            btnAccept2.FlatStyle = FlatStyle.Flat;
            btnAccept2.Font = new Font("Poppins", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAccept2.ForeColor = Color.White;
            btnAccept2.Location = new Point(438, 319);
            btnAccept2.Name = "btnAccept2";
            btnAccept2.RightToLeft = RightToLeft.No;
            btnAccept2.Size = new Size(177, 39);
            btnAccept2.TabIndex = 38;
            btnAccept2.UseVisualStyleBackColor = false;
            // 
            // ViewInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.AdminCardbg1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(875, 406);
            ControlBox = false;
            Controls.Add(picReject);
            Controls.Add(picAccept);
            Controls.Add(btnReject);
            Controls.Add(lblContactNumber);
            Controls.Add(label14);
            Controls.Add(lblUsername);
            Controls.Add(label12);
            Controls.Add(lblStatus);
            Controls.Add(label10);
            Controls.Add(cmbWorkingHours);
            Controls.Add(lblSpecialization);
            Controls.Add(label8);
            Controls.Add(lblRole);
            Controls.Add(label5);
            Controls.Add(lblEmployeeID);
            Controls.Add(label1);
            Controls.Add(lblFullname);
            Controls.Add(label4);
            Controls.Add(panel1);
            Controls.Add(btnAccept2);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewInfo";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Form1";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnBack).EndInit();
            ((System.ComponentModel.ISupportInitialize)picReject).EndInit();
            ((System.ComponentModel.ISupportInitialize)picAccept).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lblFullname;
        private Label label4;
        private Label label1;
        private Label lblEmployeeID;
        private Label label5;
        private Label lblRole;
        private Label lblSpecialization;
        private Label label8;
        private RoundedComboBox cmbWorkingHours;
        private Label lblStatus;
        private Label label10;
        private Label label12;
        private Label lblUsername;
        private Label lblContactNumber;
        private Label label14;
        private RoundedButton btnReject;
        private RoundedButton btnAccept;
        private PictureBox btnBack;
        private PictureBox picReject;
        private PictureBox picAccept;
        private RoundedButton roundedButton2;
        private RoundedButton btnAccept2;
    }
}