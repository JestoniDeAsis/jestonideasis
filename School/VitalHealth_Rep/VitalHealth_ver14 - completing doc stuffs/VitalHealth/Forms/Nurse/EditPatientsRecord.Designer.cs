namespace VitalHealth.Forms.Nurse
{
    partial class EditPatientsRecord
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

        private void label1_Click(object sender, EventArgs e)
        {
            // Put code you want to run when label1 is clicked
        }

        private void roundedComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Put code you want to run when label1 is clicked
        }

        private void label8_Click(object sender, EventArgs e)
        {
            // Put code you want to run when label1 is clicked
        }



        private void InitializeComponent()
        {
            label2 = new Label();
            label1 = new Label();
            roundedPanel1 = new VitalHealth.CustomControls.RoundedPanel();
            txtB_reason = new RoundedMultilineTextBox();
            txtB_weight = new RoundedTextBox();
            txtB_heartRate = new RoundedTextBox();
            txtB_temperature = new RoundedTextBox();
            dtP_birthday = new VitalHealth.CustomControls.RoundedDateTimePicker();
            txtB_bloodPressure = new RoundedTextBox();
            txtB_contactNumber = new RoundedTextBox();
            label7 = new Label();
            cmbB_sex = new RoundedComboBox();
            txtB_age = new RoundedTextBox();
            label6 = new Label();
            cmbB_suffix = new RoundedComboBox();
            txtB_lastname = new RoundedTextBox();
            txtB_middlename = new RoundedTextBox();
            label3 = new Label();
            txtB_contactNumberOfContactPerson = new RoundedTextBox();
            txtB_firstname = new RoundedTextBox();
            txtB_relationship = new RoundedTextBox();
            txtB_contactPersonName = new RoundedTextBox();
            label8 = new Label();
            panel3 = new Panel();
            bttn_update = new RoundedButton();
            panel2 = new Panel();
            btn_back = new PictureBox();
            panel1 = new Panel();
            roundedPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btn_back).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Zona Pro Bold", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(694, 114);
            label2.Name = "label2";
            label2.Size = new Size(360, 38);
            label2.TabIndex = 7;
            label2.Text = "Edit Patient's Form";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.WindowFrame;
            label1.Location = new Point(694, 164);
            label1.Name = "label1";
            label1.Size = new Size(387, 25);
            label1.TabIndex = 8;
            label1.Text = "Modify patient checkup information.";
            label1.Click += label1_Click;
            // 
            // roundedPanel1
            // 
            roundedPanel1.BackColor = Color.White;
            roundedPanel1.BorderRadius = 30;
            roundedPanel1.Controls.Add(txtB_reason);
            roundedPanel1.Controls.Add(txtB_weight);
            roundedPanel1.Controls.Add(txtB_heartRate);
            roundedPanel1.Controls.Add(txtB_temperature);
            roundedPanel1.Controls.Add(dtP_birthday);
            roundedPanel1.Controls.Add(txtB_bloodPressure);
            roundedPanel1.Controls.Add(txtB_contactNumber);
            roundedPanel1.Controls.Add(label7);
            roundedPanel1.Controls.Add(cmbB_sex);
            roundedPanel1.Controls.Add(txtB_age);
            roundedPanel1.Controls.Add(label6);
            roundedPanel1.Controls.Add(cmbB_suffix);
            roundedPanel1.Controls.Add(txtB_lastname);
            roundedPanel1.Controls.Add(txtB_middlename);
            roundedPanel1.Controls.Add(label3);
            roundedPanel1.Controls.Add(txtB_contactNumberOfContactPerson);
            roundedPanel1.Controls.Add(txtB_firstname);
            roundedPanel1.Controls.Add(txtB_relationship);
            roundedPanel1.Controls.Add(txtB_contactPersonName);
            roundedPanel1.Controls.Add(label8);
            roundedPanel1.Location = new Point(694, 260);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Size = new Size(1145, 581);
            roundedPanel1.TabIndex = 9;
            // 
            // txtB_reason
            // 
            txtB_reason.BaseColor = Color.White;
            txtB_reason.BorderColor = Color.FromArgb(200, 200, 200);
            txtB_reason.FocusBorderColor = Color.FromArgb(100, 100, 100);
            txtB_reason.HoverBorderColor = Color.FromArgb(170, 170, 170);
            txtB_reason.Location = new Point(42, 453);
            txtB_reason.Name = "txtB_reason";
            txtB_reason.Size = new Size(528, 86);
            txtB_reason.TabIndex = 39;
            txtB_reason.TextColor = Color.Black;
            txtB_reason.TextPadding = new Padding(14, 12, 14, 12);
            // 
            // txtB_weight
            // 
            txtB_weight.BackColor = Color.White;
            txtB_weight.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtB_weight.Location = new Point(843, 499);
            txtB_weight.Name = "txtB_weight";
            txtB_weight.PlaceholderText = "*Weight";
            txtB_weight.Size = new Size(265, 40);
            txtB_weight.TabIndex = 38;
            txtB_weight.Theme = ControlTheme.Light;
            // 
            // txtB_heartRate
            // 
            txtB_heartRate.BackColor = Color.White;
            txtB_heartRate.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtB_heartRate.Location = new Point(843, 453);
            txtB_heartRate.Name = "txtB_heartRate";
            txtB_heartRate.PlaceholderText = "*Heart Rate";
            txtB_heartRate.Size = new Size(265, 40);
            txtB_heartRate.TabIndex = 37;
            txtB_heartRate.Theme = ControlTheme.Light;
            // 
            // txtB_temperature
            // 
            txtB_temperature.BackColor = Color.White;
            txtB_temperature.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtB_temperature.Location = new Point(589, 499);
            txtB_temperature.Name = "txtB_temperature";
            txtB_temperature.PlaceholderText = "*Temperature";
            txtB_temperature.Size = new Size(248, 40);
            txtB_temperature.TabIndex = 36;
            txtB_temperature.Theme = ControlTheme.Light;
            // 
            // dtP_birthday
            // 
            dtP_birthday.BackColor = Color.White;
            dtP_birthday.BorderColor = Color.Gray;
            dtP_birthday.BorderRadius = 20;
            dtP_birthday.Location = new Point(196, 138);
            dtP_birthday.Name = "dtP_birthday";
            dtP_birthday.Size = new Size(275, 40);
            dtP_birthday.TabIndex = 19;
            dtP_birthday.Value = new DateTime(2026, 3, 16, 18, 36, 52, 148);
            // 
            // txtB_bloodPressure
            // 
            txtB_bloodPressure.BackColor = Color.White;
            txtB_bloodPressure.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtB_bloodPressure.Location = new Point(589, 453);
            txtB_bloodPressure.Name = "txtB_bloodPressure";
            txtB_bloodPressure.PlaceholderText = "*Blood Pressure";
            txtB_bloodPressure.Size = new Size(248, 40);
            txtB_bloodPressure.TabIndex = 35;
            txtB_bloodPressure.Theme = ControlTheme.Light;
            // 
            // txtB_contactNumber
            // 
            txtB_contactNumber.BackColor = Color.White;
            txtB_contactNumber.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtB_contactNumber.Location = new Point(727, 138);
            txtB_contactNumber.Name = "txtB_contactNumber";
            txtB_contactNumber.PlaceholderText = "*Contact Number (+63)";
            txtB_contactNumber.Size = new Size(271, 40);
            txtB_contactNumber.TabIndex = 18;
            txtB_contactNumber.Theme = ControlTheme.Light;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(589, 409);
            label7.Name = "label7";
            label7.Size = new Size(425, 20);
            label7.TabIndex = 34;
            label7.Text = "Vital Signs_________________________________";
            // 
            // cmbB_sex
            // 
            cmbB_sex.BackColor = Color.White;
            cmbB_sex.DrawMode = DrawMode.OwnerDrawFixed;
            cmbB_sex.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbB_sex.Font = new Font("Poppins", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbB_sex.ForeColor = Color.Black;
            cmbB_sex.FormattingEnabled = true;
            cmbB_sex.IntegralHeight = false;
            cmbB_sex.Items.AddRange(new object[] { "Male", "Female" });
            cmbB_sex.Location = new Point(477, 139);
            cmbB_sex.Name = "cmbB_sex";
            cmbB_sex.PlaceholderText = "*Sex";
            cmbB_sex.Size = new Size(244, 37);
            cmbB_sex.TabIndex = 17;
            cmbB_sex.Theme = ControlTheme.Light;
            // 
            // txtB_age
            // 
            txtB_age.BackColor = Color.White;
            txtB_age.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtB_age.Location = new Point(37, 139);
            txtB_age.Name = "txtB_age";
            txtB_age.PlaceholderText = "*Age";
            txtB_age.Size = new Size(153, 40);
            txtB_age.TabIndex = 16;
            txtB_age.Theme = ControlTheme.Light;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(42, 409);
            label6.Name = "label6";
            label6.Size = new Size(443, 20);
            label6.TabIndex = 32;
            label6.Text = "Reason for Checkup___________________________";
            // 
            // cmbB_suffix
            // 
            cmbB_suffix.BackColor = Color.White;
            cmbB_suffix.DrawMode = DrawMode.OwnerDrawFixed;
            cmbB_suffix.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbB_suffix.Font = new Font("Poppins", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbB_suffix.ForeColor = Color.Black;
            cmbB_suffix.FormattingEnabled = true;
            cmbB_suffix.IntegralHeight = false;
            cmbB_suffix.Items.AddRange(new object[] { "N/A", "Jr. (Junior)", "Sr. (Senior)", "I", "II", "III", "IV", "V", "VI", "VII", "VIII" });
            cmbB_suffix.Location = new Point(904, 89);
            cmbB_suffix.Name = "cmbB_suffix";
            cmbB_suffix.PlaceholderText = "*Suffix";
            cmbB_suffix.Size = new Size(211, 37);
            cmbB_suffix.TabIndex = 14;
            cmbB_suffix.Theme = ControlTheme.Light;
            cmbB_suffix.SelectedIndexChanged += roundedComboBox1_SelectedIndexChanged;
            // 
            // txtB_lastname
            // 
            txtB_lastname.BackColor = Color.White;
            txtB_lastname.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtB_lastname.Location = new Point(37, 88);
            txtB_lastname.Name = "txtB_lastname";
            txtB_lastname.PlaceholderText = "*Last Name";
            txtB_lastname.Size = new Size(323, 40);
            txtB_lastname.TabIndex = 12;
            txtB_lastname.Theme = ControlTheme.Light;
            // 
            // txtB_middlename
            // 
            txtB_middlename.BackColor = Color.White;
            txtB_middlename.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtB_middlename.Location = new Point(649, 88);
            txtB_middlename.Name = "txtB_middlename";
            txtB_middlename.PlaceholderText = "*Middle Name";
            txtB_middlename.Size = new Size(249, 40);
            txtB_middlename.TabIndex = 13;
            txtB_middlename.Theme = ControlTheme.Light;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(37, 38);
            label3.Name = "label3";
            label3.Size = new Size(857, 20);
            label3.TabIndex = 1;
            label3.Text = "Patient Details_________________________________________________________________________";
            // 
            // txtB_contactNumberOfContactPerson
            // 
            txtB_contactNumberOfContactPerson.BackColor = Color.White;
            txtB_contactNumberOfContactPerson.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtB_contactNumberOfContactPerson.Location = new Point(739, 295);
            txtB_contactNumberOfContactPerson.Name = "txtB_contactNumberOfContactPerson";
            txtB_contactNumberOfContactPerson.PlaceholderText = "*Contact Number (+63)";
            txtB_contactNumberOfContactPerson.Size = new Size(271, 40);
            txtB_contactNumberOfContactPerson.TabIndex = 27;
            txtB_contactNumberOfContactPerson.Theme = ControlTheme.Light;
            // 
            // txtB_firstname
            // 
            txtB_firstname.BackColor = Color.White;
            txtB_firstname.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtB_firstname.Location = new Point(366, 88);
            txtB_firstname.Name = "txtB_firstname";
            txtB_firstname.PlaceholderText = "*First Name";
            txtB_firstname.Size = new Size(277, 40);
            txtB_firstname.TabIndex = 12;
            txtB_firstname.Theme = ControlTheme.Light;
            // 
            // txtB_relationship
            // 
            txtB_relationship.BackColor = Color.White;
            txtB_relationship.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtB_relationship.Location = new Point(390, 295);
            txtB_relationship.Name = "txtB_relationship";
            txtB_relationship.PlaceholderText = "*Relationship";
            txtB_relationship.Size = new Size(343, 40);
            txtB_relationship.TabIndex = 26;
            txtB_relationship.Theme = ControlTheme.Light;
            // 
            // txtB_contactPersonName
            // 
            txtB_contactPersonName.BackColor = Color.White;
            txtB_contactPersonName.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtB_contactPersonName.Location = new Point(41, 295);
            txtB_contactPersonName.Name = "txtB_contactPersonName";
            txtB_contactPersonName.PlaceholderText = "*Name of Contact Person";
            txtB_contactPersonName.Size = new Size(343, 40);
            txtB_contactPersonName.TabIndex = 25;
            txtB_contactPersonName.Theme = ControlTheme.Light;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(41, 253);
            label8.Name = "label8";
            label8.Size = new Size(856, 20);
            label8.TabIndex = 24;
            label8.Text = "Emergency Contact_____________________________________________________________________";
            label8.Click += label8_Click;
            // 
            // panel3
            // 
            panel3.BackgroundImage = Properties.Resources.VitalHealth_Logo;
            panel3.BackgroundImageLayout = ImageLayout.Zoom;
            panel3.Location = new Point(1757, 31);
            panel3.Name = "panel3";
            panel3.Size = new Size(106, 100);
            panel3.TabIndex = 11;
            // 
            // bttn_update
            // 
            bttn_update.BackColor = Color.FromArgb(37, 147, 65);
            bttn_update.FlatAppearance.BorderSize = 0;
            bttn_update.FlatStyle = FlatStyle.Flat;
            bttn_update.Font = new Font("Zona Pro Bold", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bttn_update.ForeColor = Color.White;
            bttn_update.Location = new Point(1120, 945);
            bttn_update.Name = "bttn_update";
            bttn_update.Size = new Size(443, 57);
            bttn_update.TabIndex = 9;
            bttn_update.Text = "UPDATE";
            bttn_update.UseVisualStyleBackColor = false;
            bttn_update.Click += bttn_update_Click;
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
            // btn_back
            // 
            btn_back.BackColor = Color.Transparent;
            btn_back.Cursor = Cursors.Hand;
            btn_back.ErrorImage = null;
            btn_back.Image = Properties.Resources.back_icon;
            btn_back.Location = new Point(39, 39);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(53, 53);
            btn_back.SizeMode = PictureBoxSizeMode.StretchImage;
            btn_back.TabIndex = 2;
            btn_back.TabStop = false;
            btn_back.Click += btn_back_Click;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.background_gradient_blue;
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Controls.Add(btn_back);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(1, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(620, 1080);
            panel1.TabIndex = 0;
            // 
            // EditPatientsRecord
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(229, 231, 231);
            ClientSize = new Size(1386, 788);
            Controls.Add(bttn_update);
            Controls.Add(panel3);
            Controls.Add(roundedPanel1);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EditPatientsRecord";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Form1";
            Load += EditPatientsRecord_Load;
            roundedPanel1.ResumeLayout(false);
            roundedPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btn_back).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label1;
        private CustomControls.RoundedPanel roundedPanel1;
        private Panel panel3;
        private Label label3;
        private RoundedTextBox txtB_lastname;
        private RoundedComboBox cmbB_suffix;
        private RoundedTextBox txtB_middlename;
        private RoundedTextBox txtB_firstname;
        private CustomControls.RoundedDateTimePicker dtP_birthday;
        private RoundedTextBox txtB_contactNumber;
        private RoundedComboBox cmbB_sex;
        private RoundedTextBox txtB_age;
        private RoundedTextBox txtB_temperature;
        private RoundedTextBox txtB_bloodPressure;
        private Label label7;
        private Label label6;
        private RoundedTextBox txtB_contactNumberOfContactPerson;
        private RoundedTextBox txtB_relationship;
        private RoundedTextBox txtB_contactPersonName;
        private Label label8;
        private RoundedTextBox txtB_weight;
        private RoundedTextBox txtB_heartRate;
        private RoundedButton bttn_update;
        private Panel panel2;
        private PictureBox btn_back;
        private Panel panel1;
        private RoundedMultilineTextBox txtB_reason;
    }
}