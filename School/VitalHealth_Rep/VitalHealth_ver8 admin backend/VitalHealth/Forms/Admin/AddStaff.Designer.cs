namespace VitalHealth.Forms.Admin
{
    partial class AddStaff
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
            label3 = new Label();
            label2 = new Label();
            roundedPanel1 = new VitalHealth.CustomControls.RoundedPanel();
            btnCancel = new RoundedButton();
            btnRegister = new RoundedButton();
            txtConfirmPassword = new RoundedTextBox();
            txtContactNumber = new RoundedTextBox();
            txtPassword = new RoundedTextBox();
            tctUsername = new RoundedTextBox();
            label6 = new Label();
            cmbSpecialization = new RoundedComboBox();
            cmbWorkingHours = new RoundedComboBox();
            rdbDoctor = new SquareRadioButton();
            rdbNurse = new SquareRadioButton();
            label5 = new Label();
            cnbSuffix = new RoundedComboBox();
            txtMI = new RoundedTextBox();
            tctFirstname = new RoundedTextBox();
            txtLastname = new RoundedTextBox();
            label4 = new Label();
            pnlSideBar = new Panel();
            btn_logout = new Button();
            btnSchedNFee = new Button();
            btnPatientsRec = new Button();
            btnManageStaff = new Button();
            btnSalesDashboard = new Button();
            LblAdmin = new Label();
            lbl_adminLastName = new Label();
            label1 = new Label();
            panel2 = new Panel();
            roundedPanel1.SuspendLayout();
            pnlSideBar.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.WindowFrame;
            label3.Location = new Point(426, 86);
            label3.Name = "label3";
            label3.Size = new Size(569, 25);
            label3.TabIndex = 12;
            label3.Text = "Automatically approve staffs by adding them yourself";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Zona Pro Bold", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(426, 46);
            label2.Name = "label2";
            label2.Size = new Size(190, 38);
            label2.TabIndex = 11;
            label2.Text = "Add Staff";
            // 
            // roundedPanel1
            // 
            roundedPanel1.BackColor = Color.White;
            roundedPanel1.BorderRadius = 30;
            roundedPanel1.Controls.Add(btnCancel);
            roundedPanel1.Controls.Add(btnRegister);
            roundedPanel1.Controls.Add(txtConfirmPassword);
            roundedPanel1.Controls.Add(txtContactNumber);
            roundedPanel1.Controls.Add(txtPassword);
            roundedPanel1.Controls.Add(tctUsername);
            roundedPanel1.Controls.Add(label6);
            roundedPanel1.Controls.Add(cmbSpecialization);
            roundedPanel1.Controls.Add(cmbWorkingHours);
            roundedPanel1.Controls.Add(rdbDoctor);
            roundedPanel1.Controls.Add(rdbNurse);
            roundedPanel1.Controls.Add(label5);
            roundedPanel1.Controls.Add(cnbSuffix);
            roundedPanel1.Controls.Add(txtMI);
            roundedPanel1.Controls.Add(tctFirstname);
            roundedPanel1.Controls.Add(txtLastname);
            roundedPanel1.Controls.Add(label4);
            roundedPanel1.Location = new Point(426, 177);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Size = new Size(1430, 804);
            roundedPanel1.TabIndex = 13;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(242, 37, 40);
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Zona Pro Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(737, 664);
            btnCancel.Name = "btnCancel";
            btnCancel.RightToLeft = RightToLeft.No;
            btnCancel.Size = new Size(420, 75);
            btnCancel.TabIndex = 32;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(26, 117, 159);
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Zona Pro Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(293, 664);
            btnRegister.Name = "btnRegister";
            btnRegister.RightToLeft = RightToLeft.No;
            btnRegister.Size = new Size(420, 75);
            btnRegister.TabIndex = 31;
            btnRegister.Text = "REGISTER";
            btnRegister.UseVisualStyleBackColor = false;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Font = new Font("Poppins", 12F);
            txtConfirmPassword.Location = new Point(454, 518);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PlaceholderText = "   Confirm Password";
            txtConfirmPassword.Size = new Size(365, 40);
            txtConfirmPassword.TabIndex = 28;
            // 
            // txtContactNumber
            // 
            txtContactNumber.Font = new Font("Poppins", 12F);
            txtContactNumber.Location = new Point(46, 518);
            txtContactNumber.Name = "txtContactNumber";
            txtContactNumber.PlaceholderText = "   Contact Number (+63)";
            txtContactNumber.Size = new Size(365, 40);
            txtContactNumber.TabIndex = 27;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Poppins", 12F);
            txtPassword.Location = new Point(454, 440);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "   Password";
            txtPassword.Size = new Size(365, 40);
            txtPassword.TabIndex = 26;
            // 
            // tctUsername
            // 
            tctUsername.Font = new Font("Poppins", 12F);
            tctUsername.Location = new Point(46, 440);
            tctUsername.Name = "tctUsername";
            tctUsername.PlaceholderText = "   Username";
            tctUsername.Size = new Size(365, 40);
            tctUsername.TabIndex = 25;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Poppins", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(48, 370);
            label6.Name = "label6";
            label6.Size = new Size(1325, 37);
            label6.TabIndex = 24;
            label6.Text = "Contact and Login Credentials__________________________________________________________________";
            // 
            // cmbSpecialization
            // 
            cmbSpecialization.BackColor = Color.FromArgb(41, 41, 41);
            cmbSpecialization.DrawMode = DrawMode.OwnerDrawFixed;
            cmbSpecialization.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSpecialization.Font = new Font("Poppins", 12.75F);
            cmbSpecialization.ForeColor = Color.White;
            cmbSpecialization.FormattingEnabled = true;
            cmbSpecialization.IntegralHeight = false;
            cmbSpecialization.Location = new Point(861, 290);
            cmbSpecialization.Name = "cmbSpecialization";
            cmbSpecialization.PlaceholderText = "If Doctor, which specialization";
            cmbSpecialization.Size = new Size(504, 34);
            cmbSpecialization.TabIndex = 23;
            // 
            // cmbWorkingHours
            // 
            cmbWorkingHours.BackColor = Color.FromArgb(41, 41, 41);
            cmbWorkingHours.DrawMode = DrawMode.OwnerDrawFixed;
            cmbWorkingHours.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbWorkingHours.Font = new Font("Poppins", 12.75F);
            cmbWorkingHours.ForeColor = Color.White;
            cmbWorkingHours.FormattingEnabled = true;
            cmbWorkingHours.IntegralHeight = false;
            cmbWorkingHours.Location = new Point(454, 290);
            cmbWorkingHours.Name = "cmbWorkingHours";
            cmbWorkingHours.PlaceholderText = "Working Hours";
            cmbWorkingHours.Size = new Size(365, 34);
            cmbWorkingHours.TabIndex = 22;
            // 
            // rdbDoctor
            // 
            rdbDoctor.Font = new Font("Poppins", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdbDoctor.Label = "Doctor";
            rdbDoctor.Location = new Point(286, 295);
            rdbDoctor.Name = "rdbDoctor";
            rdbDoctor.Size = new Size(150, 28);
            rdbDoctor.TabIndex = 21;
            // 
            // rdbNurse
            // 
            rdbNurse.Font = new Font("Poppins", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdbNurse.Label = "Nurse";
            rdbNurse.Location = new Point(105, 295);
            rdbNurse.Name = "rdbNurse";
            rdbNurse.Size = new Size(150, 28);
            rdbNurse.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Poppins", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(46, 220);
            label5.Name = "label5";
            label5.Size = new Size(1335, 37);
            label5.TabIndex = 19;
            label5.Text = "Position and Working Hours_____________________________________________________________________";
            // 
            // cnbSuffix
            // 
            cnbSuffix.BackColor = Color.FromArgb(41, 41, 41);
            cnbSuffix.DrawMode = DrawMode.OwnerDrawFixed;
            cnbSuffix.DropDownStyle = ComboBoxStyle.DropDownList;
            cnbSuffix.Font = new Font("Poppins", 12.75F);
            cnbSuffix.ForeColor = Color.White;
            cnbSuffix.FormattingEnabled = true;
            cnbSuffix.IntegralHeight = false;
            cnbSuffix.Location = new Point(1071, 122);
            cnbSuffix.Name = "cnbSuffix";
            cnbSuffix.PlaceholderText = "Suffix";
            cnbSuffix.Size = new Size(294, 34);
            cnbSuffix.TabIndex = 18;
            // 
            // txtMI
            // 
            txtMI.Font = new Font("Poppins", 12F);
            txtMI.Location = new Point(861, 120);
            txtMI.Name = "txtMI";
            txtMI.PlaceholderText = "   M.I";
            txtMI.Size = new Size(170, 40);
            txtMI.TabIndex = 17;
            // 
            // tctFirstname
            // 
            tctFirstname.Font = new Font("Poppins", 12F);
            tctFirstname.Location = new Point(454, 120);
            tctFirstname.Name = "tctFirstname";
            tctFirstname.PlaceholderText = "   First Name";
            tctFirstname.Size = new Size(365, 40);
            tctFirstname.TabIndex = 16;
            // 
            // txtLastname
            // 
            txtLastname.Font = new Font("Poppins", 12F);
            txtLastname.ForeColor = Color.White;
            txtLastname.Location = new Point(46, 120);
            txtLastname.Name = "txtLastname";
            txtLastname.PlaceholderText = "   Lastname";
            txtLastname.Size = new Size(365, 40);
            txtLastname.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poppins", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(46, 50);
            label4.Name = "label4";
            label4.Size = new Size(1328, 37);
            label4.TabIndex = 13;
            label4.Text = "Fullname_________________________________________________________________________________";
            // 
            // pnlSideBar
            // 
            pnlSideBar.BackColor = Color.White;
            pnlSideBar.Controls.Add(btn_logout);
            pnlSideBar.Controls.Add(btnSchedNFee);
            pnlSideBar.Controls.Add(btnPatientsRec);
            pnlSideBar.Controls.Add(btnManageStaff);
            pnlSideBar.Controls.Add(btnSalesDashboard);
            pnlSideBar.Controls.Add(LblAdmin);
            pnlSideBar.Controls.Add(lbl_adminLastName);
            pnlSideBar.Controls.Add(label1);
            pnlSideBar.Controls.Add(panel2);
            pnlSideBar.Dock = DockStyle.Left;
            pnlSideBar.Location = new Point(0, 0);
            pnlSideBar.Name = "pnlSideBar";
            pnlSideBar.Padding = new Padding(20, 0, 0, 0);
            pnlSideBar.Size = new Size(368, 1080);
            pnlSideBar.TabIndex = 31;
            // 
            // btn_logout
            // 
            btn_logout.BackColor = Color.White;
            btn_logout.FlatAppearance.BorderSize = 0;
            btn_logout.FlatStyle = FlatStyle.Flat;
            btn_logout.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_logout.ForeColor = Color.Black;
            btn_logout.Image = Properties.Resources.LogoutButtonIcon;
            btn_logout.Location = new Point(1, 1010);
            btn_logout.Margin = new Padding(3, 2, 3, 2);
            btn_logout.Name = "btn_logout";
            btn_logout.Size = new Size(366, 67);
            btn_logout.TabIndex = 11;
            btn_logout.Text = "Logout";
            btn_logout.TextAlign = ContentAlignment.MiddleLeft;
            btn_logout.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_logout.UseVisualStyleBackColor = false;
            btn_logout.Click += btn_logout_Click;
            // 
            // btnSchedNFee
            // 
            btnSchedNFee.BackColor = Color.White;
            btnSchedNFee.FlatAppearance.BorderSize = 0;
            btnSchedNFee.FlatStyle = FlatStyle.Flat;
            btnSchedNFee.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            btnSchedNFee.ForeColor = Color.Black;
            btnSchedNFee.Image = Properties.Resources.ScheduleAndFeeIcon;
            btnSchedNFee.Location = new Point(0, 340);
            btnSchedNFee.Margin = new Padding(3, 2, 3, 2);
            btnSchedNFee.Name = "btnSchedNFee";
            btnSchedNFee.Padding = new Padding(20, 0, 0, 0);
            btnSchedNFee.Size = new Size(366, 67);
            btnSchedNFee.TabIndex = 10;
            btnSchedNFee.Text = "Shedule and Fee";
            btnSchedNFee.TextAlign = ContentAlignment.MiddleLeft;
            btnSchedNFee.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSchedNFee.UseVisualStyleBackColor = false;
            btnSchedNFee.Click += btnSchedNFee_Click;
            // 
            // btnPatientsRec
            // 
            btnPatientsRec.BackColor = Color.White;
            btnPatientsRec.FlatAppearance.BorderSize = 0;
            btnPatientsRec.FlatStyle = FlatStyle.Flat;
            btnPatientsRec.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            btnPatientsRec.ForeColor = Color.Black;
            btnPatientsRec.Image = Properties.Resources.patients_records_icon;
            btnPatientsRec.Location = new Point(1, 270);
            btnPatientsRec.Margin = new Padding(3, 2, 3, 2);
            btnPatientsRec.Name = "btnPatientsRec";
            btnPatientsRec.Padding = new Padding(17, 0, 0, 0);
            btnPatientsRec.Size = new Size(366, 67);
            btnPatientsRec.TabIndex = 9;
            btnPatientsRec.Text = "Patients Record";
            btnPatientsRec.TextAlign = ContentAlignment.MiddleLeft;
            btnPatientsRec.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPatientsRec.UseVisualStyleBackColor = false;
            btnPatientsRec.Click += btnPatientsRec_Click_1;
            // 
            // btnManageStaff
            // 
            btnManageStaff.BackColor = Color.DarkGray;
            btnManageStaff.FlatAppearance.BorderSize = 0;
            btnManageStaff.FlatStyle = FlatStyle.Flat;
            btnManageStaff.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            btnManageStaff.ForeColor = Color.Black;
            btnManageStaff.Image = Properties.Resources.staff_icon;
            btnManageStaff.Location = new Point(1, 199);
            btnManageStaff.Margin = new Padding(3, 2, 3, 2);
            btnManageStaff.Name = "btnManageStaff";
            btnManageStaff.Padding = new Padding(10, 0, 0, 0);
            btnManageStaff.Size = new Size(366, 67);
            btnManageStaff.TabIndex = 8;
            btnManageStaff.Text = "Manage Staff";
            btnManageStaff.TextAlign = ContentAlignment.MiddleLeft;
            btnManageStaff.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnManageStaff.UseVisualStyleBackColor = false;
            btnManageStaff.Click += btnManageStaff_Click;
            // 
            // btnSalesDashboard
            // 
            btnSalesDashboard.BackColor = Color.White;
            btnSalesDashboard.FlatAppearance.BorderSize = 0;
            btnSalesDashboard.FlatStyle = FlatStyle.Flat;
            btnSalesDashboard.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            btnSalesDashboard.ForeColor = Color.Black;
            btnSalesDashboard.Image = Properties.Resources.sales_perf_icon;
            btnSalesDashboard.Location = new Point(1, 130);
            btnSalesDashboard.Margin = new Padding(3, 2, 3, 2);
            btnSalesDashboard.Name = "btnSalesDashboard";
            btnSalesDashboard.Padding = new Padding(20, 0, 0, 0);
            btnSalesDashboard.Size = new Size(366, 67);
            btnSalesDashboard.TabIndex = 7;
            btnSalesDashboard.Text = "Sales Dashboard\r\n";
            btnSalesDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnSalesDashboard.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSalesDashboard.UseVisualStyleBackColor = false;
            btnSalesDashboard.Click += btnSalesDashboard_Click;
            // 
            // LblAdmin
            // 
            LblAdmin.AutoSize = true;
            LblAdmin.Font = new Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblAdmin.ForeColor = Color.FromArgb(26, 117, 159);
            LblAdmin.Location = new Point(131, 68);
            LblAdmin.Name = "LblAdmin";
            LblAdmin.Size = new Size(61, 26);
            LblAdmin.TabIndex = 6;
            LblAdmin.Text = "Admin";
            // 
            // lbl_adminLastName
            // 
            lbl_adminLastName.AutoSize = true;
            lbl_adminLastName.Font = new Font("Poppins", 17.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_adminLastName.ForeColor = Color.Black;
            lbl_adminLastName.Location = new Point(202, 38);
            lbl_adminLastName.Name = "lbl_adminLastName";
            lbl_adminLastName.Size = new Size(128, 40);
            lbl_adminLastName.TabIndex = 5;
            lbl_adminLastName.Text = "lastname";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 17.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(74, 214, 109);
            label1.Location = new Point(131, 38);
            label1.Name = "label1";
            label1.Size = new Size(79, 40);
            label1.TabIndex = 4;
            label1.Text = "Hello,";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BackgroundImage = Properties.Resources.VitalHealth_Logo;
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Location = new Point(31, 27);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(75, 75);
            panel2.TabIndex = 2;
            // 
            // AddStaff
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1920, 1080);
            ControlBox = false;
            Controls.Add(pnlSideBar);
            Controls.Add(roundedPanel1);
            Controls.Add(label3);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddStaff";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Form1";
            Load += AddStaff_Load;
            roundedPanel1.ResumeLayout(false);
            roundedPanel1.PerformLayout();
            pnlSideBar.ResumeLayout(false);
            pnlSideBar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private Label label2;
        private CustomControls.RoundedPanel roundedPanel1;
        private RoundedTextBox txtMI;
        private RoundedTextBox tctFirstname;
        private RoundedTextBox txtLastname;
        private Label label4;
        private Label label5;
        private RoundedComboBox cnbSuffix;
        private SquareRadioButton rdbDoctor;
        private SquareRadioButton rdbNurse;
        private Label label6;
        private RoundedComboBox cmbSpecialization;
        private RoundedComboBox cmbWorkingHours;
        private RoundedTextBox txtPassword;
        private RoundedTextBox tctUsername;
        private RoundedTextBox txtConfirmPassword;
        private RoundedTextBox txtContactNumber;
        private RoundedButton btnCancel;
        private RoundedButton btnRegister;
        private Panel pnlSideBar;
        private Button btn_logout;
        private Button btnSchedNFee;
        private Button btnPatientsRec;
        private Button btnManageStaff;
        private Button btnSalesDashboard;
        private Label LblAdmin;
        private Label lbl_adminLastName;
        private Label label1;
        private Panel panel2;
    }
}