namespace VitalHealth.Forms.Doctor
{
    partial class DoctorEditProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorEditProfile));
            panel3 = new Panel();
            roundedPanel1 = new VitalHealth.CustomControls.RoundedPanel();
            txtB_contanctNum = new RoundedTextBox();
            rcmbBox_suffix = new RoundedComboBox();
            txtB_middlename = new RoundedTextBox();
            txtB_firstname = new RoundedTextBox();
            txtB_lastname = new RoundedTextBox();
            label11 = new Label();
            label10 = new Label();
            lbl_username = new Label();
            label8 = new Label();
            lbl_specialization = new Label();
            label6 = new Label();
            lbl_employeeID = new Label();
            label4 = new Label();
            btn_update = new RoundedButton();
            label3 = new Label();
            panel1 = new Panel();
            btn_back = new PictureBox();
            panel2 = new Panel();
            label1 = new Label();
            label2 = new Label();
            roundedPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btn_back).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackgroundImage = Properties.Resources.VitalHealth_Logo;
            panel3.BackgroundImageLayout = ImageLayout.Zoom;
            panel3.Location = new Point(1535, 26);
            panel3.Name = "panel3";
            panel3.Size = new Size(106, 100);
            panel3.TabIndex = 17;
            // 
            // roundedPanel1
            // 
            roundedPanel1.BackColor = Color.White;
            roundedPanel1.BorderRadius = 30;
            roundedPanel1.Controls.Add(txtB_contanctNum);
            roundedPanel1.Controls.Add(rcmbBox_suffix);
            roundedPanel1.Controls.Add(txtB_middlename);
            roundedPanel1.Controls.Add(txtB_firstname);
            roundedPanel1.Controls.Add(txtB_lastname);
            roundedPanel1.Controls.Add(label11);
            roundedPanel1.Controls.Add(label10);
            roundedPanel1.Controls.Add(lbl_username);
            roundedPanel1.Controls.Add(label8);
            roundedPanel1.Controls.Add(lbl_specialization);
            roundedPanel1.Controls.Add(label6);
            roundedPanel1.Controls.Add(lbl_employeeID);
            roundedPanel1.Controls.Add(label4);
            roundedPanel1.Controls.Add(btn_update);
            roundedPanel1.Controls.Add(label3);
            roundedPanel1.Location = new Point(684, 150);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Size = new Size(932, 600);
            roundedPanel1.TabIndex = 16;
            // 
            // txtB_contanctNum
            // 
            txtB_contanctNum.BackColor = Color.Transparent;
            txtB_contanctNum.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtB_contanctNum.Location = new Point(326, 324);
            txtB_contanctNum.Name = "txtB_contanctNum";
            txtB_contanctNum.PlaceholderText = "*Contact Number (+63)";
            txtB_contanctNum.Size = new Size(368, 40);
            txtB_contanctNum.TabIndex = 56;
            txtB_contanctNum.Theme = ControlTheme.Light;
            // 
            // rcmbBox_suffix
            // 
            rcmbBox_suffix.BackColor = Color.White;
            rcmbBox_suffix.DrawMode = DrawMode.OwnerDrawFixed;
            rcmbBox_suffix.DropDownStyle = ComboBoxStyle.DropDownList;
            rcmbBox_suffix.Font = new Font("Poppins", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rcmbBox_suffix.ForeColor = Color.Black;
            rcmbBox_suffix.FormattingEnabled = true;
            rcmbBox_suffix.IntegralHeight = false;
            rcmbBox_suffix.Items.AddRange(new object[] { "", "Jr. (Junior)", "Sr. (Senior)", "I", "II", "III", "IV", "V", "VI", "VII", "VIII" });
            rcmbBox_suffix.Location = new Point(587, 263);
            rcmbBox_suffix.Name = "rcmbBox_suffix";
            rcmbBox_suffix.PlaceholderText = "*Suffix";
            rcmbBox_suffix.Size = new Size(211, 37);
            rcmbBox_suffix.TabIndex = 55;
            rcmbBox_suffix.Theme = ControlTheme.Light;
            // 
            // txtB_middlename
            // 
            txtB_middlename.BackColor = Color.Transparent;
            txtB_middlename.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtB_middlename.Location = new Point(326, 260);
            txtB_middlename.Name = "txtB_middlename";
            txtB_middlename.PlaceholderText = "Middle name";
            txtB_middlename.Size = new Size(255, 40);
            txtB_middlename.TabIndex = 54;
            txtB_middlename.Theme = ControlTheme.Light;
            // 
            // txtB_firstname
            // 
            txtB_firstname.BackColor = Color.Transparent;
            txtB_firstname.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtB_firstname.Location = new Point(587, 214);
            txtB_firstname.Name = "txtB_firstname";
            txtB_firstname.PlaceholderText = "*First name";
            txtB_firstname.Size = new Size(256, 40);
            txtB_firstname.TabIndex = 53;
            txtB_firstname.Theme = ControlTheme.Light;
            // 
            // txtB_lastname
            // 
            txtB_lastname.BackColor = Color.Transparent;
            txtB_lastname.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtB_lastname.Location = new Point(326, 214);
            txtB_lastname.Name = "txtB_lastname";
            txtB_lastname.PlaceholderText = "*Last name";
            txtB_lastname.Size = new Size(256, 40);
            txtB_lastname.TabIndex = 52;
            txtB_lastname.Theme = ControlTheme.Light;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold);
            label11.Location = new Point(74, 328);
            label11.Name = "label11";
            label11.Size = new Size(185, 26);
            label11.TabIndex = 48;
            label11.Text = "Contact Number";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold);
            label10.Location = new Point(74, 218);
            label10.Name = "label10";
            label10.Size = new Size(121, 26);
            label10.TabIndex = 47;
            label10.Text = "Full Name";
            // 
            // lbl_username
            // 
            lbl_username.AutoSize = true;
            lbl_username.BackColor = Color.Transparent;
            lbl_username.Font = new Font("Poppins", 16.2F);
            lbl_username.Location = new Point(326, 156);
            lbl_username.Name = "lbl_username";
            lbl_username.Size = new Size(108, 36);
            lbl_username.TabIndex = 46;
            lbl_username.Text = "Doctor.01";
            lbl_username.TextAlign = ContentAlignment.MiddleCenter;
            lbl_username.UseCompatibleTextRendering = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold);
            label8.Location = new Point(74, 156);
            label8.Name = "label8";
            label8.Size = new Size(121, 26);
            label8.TabIndex = 45;
            label8.Text = "Username";
            // 
            // lbl_specialization
            // 
            lbl_specialization.AutoSize = true;
            lbl_specialization.BackColor = Color.Transparent;
            lbl_specialization.Font = new Font("Poppins", 16.2F);
            lbl_specialization.Location = new Point(326, 111);
            lbl_specialization.Name = "lbl_specialization";
            lbl_specialization.Size = new Size(140, 36);
            lbl_specialization.TabIndex = 44;
            lbl_specialization.Text = "Pediatrician";
            lbl_specialization.TextAlign = ContentAlignment.MiddleCenter;
            lbl_specialization.UseCompatibleTextRendering = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold);
            label6.Location = new Point(74, 111);
            label6.Name = "label6";
            label6.Size = new Size(161, 26);
            label6.TabIndex = 43;
            label6.Text = "Specialization";
            // 
            // lbl_employeeID
            // 
            lbl_employeeID.AutoSize = true;
            lbl_employeeID.BackColor = Color.Transparent;
            lbl_employeeID.Font = new Font("Poppins", 16.2F);
            lbl_employeeID.Location = new Point(326, 64);
            lbl_employeeID.Name = "lbl_employeeID";
            lbl_employeeID.Size = new Size(115, 36);
            lbl_employeeID.TabIndex = 42;
            lbl_employeeID.Text = "2132132-D";
            lbl_employeeID.TextAlign = ContentAlignment.MiddleCenter;
            lbl_employeeID.UseCompatibleTextRendering = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold);
            label4.Location = new Point(74, 64);
            label4.Name = "label4";
            label4.Size = new Size(149, 26);
            label4.TabIndex = 41;
            label4.Text = "Employee ID";
            // 
            // btn_update
            // 
            btn_update.BackColor = Color.FromArgb(5, 137, 38);
            btn_update.Cursor = Cursors.Hand;
            btn_update.FlatAppearance.BorderSize = 0;
            btn_update.FlatStyle = FlatStyle.Flat;
            btn_update.Font = new Font("Zona Pro Bold", 16F);
            btn_update.ForeColor = Color.White;
            btn_update.Location = new Point(326, 512);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(277, 54);
            btn_update.TabIndex = 32;
            btn_update.Text = "UPDATE";
            btn_update.UseVisualStyleBackColor = false;
            btn_update.Click += btn_update_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold);
            label3.Location = new Point(37, 22);
            label3.Name = "label3";
            label3.Size = new Size(233, 26);
            label3.TabIndex = 1;
            label3.Text = "Personal Information";
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.background_gradient_blue;
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Controls.Add(btn_back);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(-2, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(620, 1080);
            panel1.TabIndex = 12;
            // 
            // btn_back
            // 
            btn_back.BackColor = Color.Transparent;
            btn_back.Cursor = Cursors.Hand;
            btn_back.Image = (Image)resources.GetObject("btn_back.Image");
            btn_back.Location = new Point(25, 14);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(53, 53);
            btn_back.SizeMode = PictureBoxSizeMode.StretchImage;
            btn_back.TabIndex = 18;
            btn_back.TabStop = false;
            btn_back.Click += btn_back_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.BackgroundImage = Properties.Resources.EditPatientFormIcon;
            panel2.BackgroundImageLayout = ImageLayout.Zoom;
            panel2.Location = new Point(-56, 183);
            panel2.Name = "panel2";
            panel2.Size = new Size(721, 914);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Zona Pro Bold", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(684, 33);
            label1.Name = "label1";
            label1.Size = new Size(215, 38);
            label1.TabIndex = 13;
            label1.Text = "Edit Profile";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            label2.ForeColor = SystemColors.WindowFrame;
            label2.Location = new Point(684, 83);
            label2.Name = "label2";
            label2.Size = new Size(400, 29);
            label2.TabIndex = 14;
            label2.Text = "Update your personal Information";
            // 
            // DoctorEditProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1920, 1080);
            Controls.Add(roundedPanel1);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "DoctorEditProfile";
            StartPosition = FormStartPosition.CenterParent;
            Text = "EditProfile";
            Load += DoctorEditProfile_Load;
            roundedPanel1.ResumeLayout(false);
            roundedPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btn_back).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel3;
        private CustomControls.RoundedPanel roundedPanel1;
        private Label label3;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Label label2;
        private RoundedButton btn_update;
        private Label label4;
        private Label lbl_employeeID;
        private Label lbl_username;
        private Label label8;
        private Label lbl_specialization;
        private Label label6;
        private Label label11;
        private Label label10;
        private RoundedTextBox txtB_middlename;
        private RoundedTextBox txtB_firstname;
        private RoundedTextBox txtB_lastname;
        private RoundedTextBox txtB_contanctNum;
        private RoundedComboBox rcmbBox_suffix;
        private PictureBox btn_back;
    }
}