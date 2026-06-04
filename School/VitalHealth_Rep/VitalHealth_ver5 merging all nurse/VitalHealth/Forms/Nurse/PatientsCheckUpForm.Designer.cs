namespace VitalHealth.Forms.Nurse
{
    partial class PatientsCheckUpForm
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            button8 = new Button();
            btn_logout = new Button();
            btn_todaysPatient = new Button();
            btn_checkupForm = new Button();
            lblNurse = new Label();
            lbl_nurseLastName = new Label();
            label1 = new Label();
            button3 = new Button();
            button4 = new Button();
            btn_missedCheckups = new Button();
            button6 = new Button();
            panel2 = new Panel();
            label2 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            toolTip1 = new ToolTip(components);
            roundedPanel1 = new VitalHealth.CustomControls.RoundedPanel();
            label9 = new Label();
            roundedTextBox14 = new RoundedTextBox();
            label8 = new Label();
            roundedTextBox13 = new RoundedTextBox();
            roundedTextBox12 = new RoundedTextBox();
            roundedTextBox11 = new RoundedTextBox();
            roundedTextBox10 = new RoundedTextBox();
            label7 = new Label();
            roundedTextBox9 = new RoundedTextBox();
            label6 = new Label();
            roundedComboBox3 = new RoundedComboBox();
            squareRadioButton2 = new SquareRadioButton();
            squareRadioButton1 = new SquareRadioButton();
            label5 = new Label();
            roundedTextBox8 = new RoundedTextBox();
            roundedTextBox7 = new RoundedTextBox();
            roundedTextBox6 = new RoundedTextBox();
            label4 = new Label();
            roundedDateTimePicker1 = new VitalHealth.CustomControls.RoundedDateTimePicker();
            roundedTextBox5 = new RoundedTextBox();
            roundedComboBox2 = new RoundedComboBox();
            roundedComboBox1 = new RoundedComboBox();
            roundedTextBox4 = new RoundedTextBox();
            roundedTextBox3 = new RoundedTextBox();
            roundedTextBox2 = new RoundedTextBox();
            roundedTextBox1 = new RoundedTextBox();
            label3 = new Label();
            roundedButton1 = new RoundedButton();
            roundedButton2 = new RoundedButton();
            panel1.SuspendLayout();
            roundedPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(button8);
            panel1.Controls.Add(btn_logout);
            panel1.Controls.Add(btn_todaysPatient);
            panel1.Controls.Add(btn_checkupForm);
            panel1.Controls.Add(lblNurse);
            panel1.Controls.Add(lbl_nurseLastName);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(btn_missedCheckups);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, -1);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(368, 1080);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // button8
            // 
            button8.BackColor = Color.White;
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            button8.Image = Properties.Resources.EditProfileButtonIcon;
            button8.ImageAlign = ContentAlignment.MiddleLeft;
            button8.Location = new Point(1, 940);
            button8.Margin = new Padding(3, 2, 3, 2);
            button8.Name = "button8";
            button8.Padding = new Padding(30, 0, 0, 0);
            button8.Size = new Size(366, 67);
            button8.TabIndex = 7;
            button8.Text = "Edit Profile";
            button8.TextAlign = ContentAlignment.MiddleLeft;
            button8.TextImageRelation = TextImageRelation.ImageBeforeText;
            button8.UseVisualStyleBackColor = false;
            // 
            // btn_logout
            // 
            btn_logout.BackColor = Color.White;
            btn_logout.FlatAppearance.BorderSize = 0;
            btn_logout.FlatStyle = FlatStyle.Flat;
            btn_logout.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            btn_logout.Image = Properties.Resources.LogoutButtonIcon;
            btn_logout.ImageAlign = ContentAlignment.MiddleLeft;
            btn_logout.Location = new Point(1, 1012);
            btn_logout.Margin = new Padding(3, 2, 3, 2);
            btn_logout.Name = "btn_logout";
            btn_logout.Padding = new Padding(30, 0, 0, 0);
            btn_logout.Size = new Size(366, 67);
            btn_logout.TabIndex = 6;
            btn_logout.Text = "Logout";
            btn_logout.TextAlign = ContentAlignment.MiddleLeft;
            btn_logout.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_logout.UseVisualStyleBackColor = false;
            btn_logout.Click += btn_logout_Click;
            // 
            // btn_todaysPatient
            // 
            btn_todaysPatient.BackColor = Color.White;
            btn_todaysPatient.FlatAppearance.BorderSize = 0;
            btn_todaysPatient.FlatStyle = FlatStyle.Flat;
            btn_todaysPatient.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            btn_todaysPatient.Image = Properties.Resources.TodaysPatientsIcon;
            btn_todaysPatient.ImageAlign = ContentAlignment.MiddleLeft;
            btn_todaysPatient.Location = new Point(1, 199);
            btn_todaysPatient.Margin = new Padding(3, 2, 3, 2);
            btn_todaysPatient.Name = "btn_todaysPatient";
            btn_todaysPatient.Padding = new Padding(26, 0, 0, 0);
            btn_todaysPatient.Size = new Size(366, 67);
            btn_todaysPatient.TabIndex = 4;
            btn_todaysPatient.Text = "Today's Patients";
            btn_todaysPatient.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_todaysPatient.UseVisualStyleBackColor = false;
            btn_todaysPatient.Click += btn_todaysPatient_Click;
            // 
            // btn_checkupForm
            // 
            btn_checkupForm.BackColor = Color.DarkGray;
            btn_checkupForm.FlatAppearance.BorderSize = 0;
            btn_checkupForm.FlatStyle = FlatStyle.Flat;
            btn_checkupForm.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            btn_checkupForm.Image = Properties.Resources.PatientCheckupFormIcon;
            btn_checkupForm.Location = new Point(1, 130);
            btn_checkupForm.Margin = new Padding(3, 2, 3, 2);
            btn_checkupForm.Name = "btn_checkupForm";
            btn_checkupForm.Padding = new Padding(13, 0, 0, 0);
            btn_checkupForm.Size = new Size(366, 67);
            btn_checkupForm.TabIndex = 1;
            btn_checkupForm.Text = "Patient Checkup Form";
            btn_checkupForm.TextAlign = ContentAlignment.MiddleLeft;
            btn_checkupForm.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_checkupForm.UseVisualStyleBackColor = false;
            // 
            // lblNurse
            // 
            lblNurse.AutoSize = true;
            lblNurse.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNurse.ForeColor = Color.FromArgb(26, 117, 159);
            lblNurse.Location = new Point(111, 61);
            lblNurse.Name = "lblNurse";
            lblNurse.Size = new Size(52, 25);
            lblNurse.TabIndex = 3;
            lblNurse.Text = "Nurse";
            // 
            // lbl_nurseLastName
            // 
            lbl_nurseLastName.AutoSize = true;
            lbl_nurseLastName.Font = new Font("Zona Pro Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_nurseLastName.Location = new Point(182, 38);
            lbl_nurseLastName.Name = "lbl_nurseLastName";
            lbl_nurseLastName.Size = new Size(116, 24);
            lbl_nurseLastName.TabIndex = 2;
            lbl_nurseLastName.Text = "lastname";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Zona Pro Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(111, 38);
            label1.Name = "label1";
            label1.Size = new Size(73, 24);
            label1.TabIndex = 1;
            label1.Text = "Hello,";
            label1.Click += label1_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            button3.Image = Properties.Resources.PatientHistoryIcon;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(0, 270);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Padding = new Padding(26, 0, 0, 0);
            button3.RightToLeft = RightToLeft.No;
            button3.Size = new Size(366, 67);
            button3.TabIndex = 2;
            button3.Text = "Patient History";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.TextImageRelation = TextImageRelation.ImageBeforeText;
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.White;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            button4.Image = Properties.Resources.PastRecordsIcon;
            button4.Location = new Point(0, 340);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Padding = new Padding(13, 0, 0, 0);
            button4.Size = new Size(366, 67);
            button4.TabIndex = 3;
            button4.Text = "Past Records";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.TextImageRelation = TextImageRelation.ImageBeforeText;
            button4.UseVisualStyleBackColor = false;
            // 
            // btn_missedCheckups
            // 
            btn_missedCheckups.BackColor = Color.White;
            btn_missedCheckups.FlatAppearance.BorderSize = 0;
            btn_missedCheckups.FlatStyle = FlatStyle.Flat;
            btn_missedCheckups.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            btn_missedCheckups.Image = Properties.Resources.MissedCheckupsIcon;
            btn_missedCheckups.Location = new Point(1, 411);
            btn_missedCheckups.Margin = new Padding(3, 2, 3, 2);
            btn_missedCheckups.Name = "btn_missedCheckups";
            btn_missedCheckups.Padding = new Padding(26, 0, 0, 0);
            btn_missedCheckups.Size = new Size(366, 67);
            btn_missedCheckups.TabIndex = 4;
            btn_missedCheckups.Text = "Missed Checkups";
            btn_missedCheckups.TextAlign = ContentAlignment.MiddleLeft;
            btn_missedCheckups.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_missedCheckups.UseVisualStyleBackColor = false;
            btn_missedCheckups.Click += btn_missedCheckups_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.White;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            button6.Image = Properties.Resources.ScheduleAndFeeIcon;
            button6.Location = new Point(0, 482);
            button6.Margin = new Padding(3, 2, 3, 2);
            button6.Name = "button6";
            button6.Size = new Size(366, 67);
            button6.TabIndex = 5;
            button6.Text = "Schedule and Fee";
            button6.TextAlign = ContentAlignment.MiddleLeft;
            button6.TextImageRelation = TextImageRelation.ImageBeforeText;
            button6.UseVisualStyleBackColor = false;
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
            panel2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Zona Pro Bold", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(424, 46);
            label2.Name = "label2";
            label2.Size = new Size(278, 38);
            label2.TabIndex = 6;
            label2.Text = "Checkup Form";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // roundedPanel1
            // 
            roundedPanel1.BackColor = Color.White;
            roundedPanel1.BorderRadius = 30;
            roundedPanel1.Controls.Add(label9);
            roundedPanel1.Controls.Add(roundedTextBox14);
            roundedPanel1.Controls.Add(label8);
            roundedPanel1.Controls.Add(roundedTextBox13);
            roundedPanel1.Controls.Add(roundedTextBox12);
            roundedPanel1.Controls.Add(roundedTextBox11);
            roundedPanel1.Controls.Add(roundedTextBox10);
            roundedPanel1.Controls.Add(label7);
            roundedPanel1.Controls.Add(roundedTextBox9);
            roundedPanel1.Controls.Add(label6);
            roundedPanel1.Controls.Add(roundedComboBox3);
            roundedPanel1.Controls.Add(squareRadioButton2);
            roundedPanel1.Controls.Add(squareRadioButton1);
            roundedPanel1.Controls.Add(label5);
            roundedPanel1.Controls.Add(roundedTextBox8);
            roundedPanel1.Controls.Add(roundedTextBox7);
            roundedPanel1.Controls.Add(roundedTextBox6);
            roundedPanel1.Controls.Add(label4);
            roundedPanel1.Controls.Add(roundedDateTimePicker1);
            roundedPanel1.Controls.Add(roundedTextBox5);
            roundedPanel1.Controls.Add(roundedComboBox2);
            roundedPanel1.Controls.Add(roundedComboBox1);
            roundedPanel1.Controls.Add(roundedTextBox4);
            roundedPanel1.Controls.Add(roundedTextBox3);
            roundedPanel1.Controls.Add(roundedTextBox2);
            roundedPanel1.Controls.Add(roundedTextBox1);
            roundedPanel1.Controls.Add(label3);
            roundedPanel1.Location = new Point(424, 125);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Size = new Size(1443, 763);
            roundedPanel1.TabIndex = 7;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(194, 123);
            label9.Name = "label9";
            label9.Size = new Size(109, 28);
            label9.TabIndex = 28;
            label9.Text = "Date of Birth";
            // 
            // roundedTextBox14
            // 
            roundedTextBox14.BackColor = Color.White;
            roundedTextBox14.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roundedTextBox14.Location = new Point(33, 627);
            roundedTextBox14.Name = "roundedTextBox14";
            roundedTextBox14.Size = new Size(632, 40);
            roundedTextBox14.TabIndex = 27;
            roundedTextBox14.Theme = ControlTheme.Light;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(33, 587);
            label8.Name = "label8";
            label8.Size = new Size(1102, 20);
            label8.TabIndex = 26;
            label8.Text = "Walk-In/Consultation Fee_________________________________________________________________________________________";
            // 
            // roundedTextBox13
            // 
            roundedTextBox13.BackColor = Color.White;
            roundedTextBox13.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roundedTextBox13.Location = new Point(1071, 519);
            roundedTextBox13.Name = "roundedTextBox13";
            roundedTextBox13.PlaceholderText = "*Weight";
            roundedTextBox13.Size = new Size(348, 40);
            roundedTextBox13.TabIndex = 25;
            roundedTextBox13.Theme = ControlTheme.Light;
            // 
            // roundedTextBox12
            // 
            roundedTextBox12.BackColor = Color.White;
            roundedTextBox12.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roundedTextBox12.Location = new Point(1071, 473);
            roundedTextBox12.Name = "roundedTextBox12";
            roundedTextBox12.PlaceholderText = "*Heart Rate";
            roundedTextBox12.Size = new Size(348, 40);
            roundedTextBox12.TabIndex = 24;
            roundedTextBox12.Theme = ControlTheme.Light;
            // 
            // roundedTextBox11
            // 
            roundedTextBox11.BackColor = Color.White;
            roundedTextBox11.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roundedTextBox11.Location = new Point(698, 519);
            roundedTextBox11.Name = "roundedTextBox11";
            roundedTextBox11.PlaceholderText = "*Temperature";
            roundedTextBox11.Size = new Size(348, 40);
            roundedTextBox11.TabIndex = 23;
            roundedTextBox11.Theme = ControlTheme.Light;
            // 
            // roundedTextBox10
            // 
            roundedTextBox10.BackColor = Color.White;
            roundedTextBox10.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roundedTextBox10.Location = new Point(698, 473);
            roundedTextBox10.Name = "roundedTextBox10";
            roundedTextBox10.PlaceholderText = "*Blood Pressure";
            roundedTextBox10.Size = new Size(348, 40);
            roundedTextBox10.TabIndex = 22;
            roundedTextBox10.Theme = ControlTheme.Light;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(698, 429);
            label7.Name = "label7";
            label7.Size = new Size(575, 20);
            label7.TabIndex = 21;
            label7.Text = "Vital Signs________________________________________________";
            // 
            // roundedTextBox9
            // 
            roundedTextBox9.BackColor = Color.White;
            roundedTextBox9.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roundedTextBox9.Location = new Point(33, 473);
            roundedTextBox9.Name = "roundedTextBox9";
            roundedTextBox9.PlaceholderText = "*Reason";
            roundedTextBox9.Size = new Size(632, 40);
            roundedTextBox9.TabIndex = 20;
            roundedTextBox9.Theme = ControlTheme.Light;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(31, 429);
            label6.Name = "label6";
            label6.Size = new Size(533, 20);
            label6.TabIndex = 19;
            label6.Text = "Reason for Checkup____________________________________";
            // 
            // roundedComboBox3
            // 
            roundedComboBox3.BackColor = Color.White;
            roundedComboBox3.DrawMode = DrawMode.OwnerDrawFixed;
            roundedComboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            roundedComboBox3.Font = new Font("Poppins", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roundedComboBox3.ForeColor = Color.Black;
            roundedComboBox3.FormattingEnabled = true;
            roundedComboBox3.IntegralHeight = false;
            roundedComboBox3.Items.AddRange(new object[] { "Jr. (Junior)", "", "Sr. (Senior)", "", "I", "I", "I", "II", "I", "IV", "", "V", "", "VI", "", "VII", "", "VIII" });
            roundedComboBox3.Location = new Point(414, 339);
            roundedComboBox3.Name = "roundedComboBox3";
            roundedComboBox3.PlaceholderText = "*Selected Doctor";
            roundedComboBox3.Size = new Size(477, 37);
            roundedComboBox3.TabIndex = 18;
            roundedComboBox3.Theme = ControlTheme.Light;
            // 
            // squareRadioButton2
            // 
            squareRadioButton2.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            squareRadioButton2.Label = "Returning Patient";
            squareRadioButton2.Location = new Point(219, 342);
            squareRadioButton2.Name = "squareRadioButton2";
            squareRadioButton2.Size = new Size(184, 28);
            squareRadioButton2.TabIndex = 17;
            // 
            // squareRadioButton1
            // 
            squareRadioButton1.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            squareRadioButton1.Label = "New Patient";
            squareRadioButton1.Location = new Point(33, 342);
            squareRadioButton1.Name = "squareRadioButton1";
            squareRadioButton1.Size = new Size(150, 28);
            squareRadioButton1.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(29, 300);
            label5.Name = "label5";
            label5.Size = new Size(1100, 20);
            label5.TabIndex = 15;
            label5.Text = "Checkup Details________________________________________________________________________________________________";
            // 
            // roundedTextBox8
            // 
            roundedTextBox8.BackColor = Color.White;
            roundedTextBox8.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roundedTextBox8.Location = new Point(727, 225);
            roundedTextBox8.Name = "roundedTextBox8";
            roundedTextBox8.PlaceholderText = "*Contact Number (+63)";
            roundedTextBox8.Size = new Size(271, 40);
            roundedTextBox8.TabIndex = 14;
            roundedTextBox8.Theme = ControlTheme.Light;
            // 
            // roundedTextBox7
            // 
            roundedTextBox7.BackColor = Color.White;
            roundedTextBox7.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roundedTextBox7.Location = new Point(378, 225);
            roundedTextBox7.Name = "roundedTextBox7";
            roundedTextBox7.PlaceholderText = "*Relationship";
            roundedTextBox7.Size = new Size(343, 40);
            roundedTextBox7.TabIndex = 13;
            roundedTextBox7.Theme = ControlTheme.Light;
            // 
            // roundedTextBox6
            // 
            roundedTextBox6.BackColor = Color.White;
            roundedTextBox6.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roundedTextBox6.Location = new Point(29, 225);
            roundedTextBox6.Name = "roundedTextBox6";
            roundedTextBox6.PlaceholderText = "*Name of Contact Person";
            roundedTextBox6.Size = new Size(343, 40);
            roundedTextBox6.TabIndex = 12;
            roundedTextBox6.Theme = ControlTheme.Light;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(29, 183);
            label4.Name = "label4";
            label4.Size = new Size(1106, 20);
            label4.TabIndex = 11;
            label4.Text = "Emergency Contact______________________________________________________________________________________________";
            // 
            // roundedDateTimePicker1
            // 
            roundedDateTimePicker1.BackColor = Color.White;
            roundedDateTimePicker1.BorderColor = Color.Gray;
            roundedDateTimePicker1.BorderRadius = 20;
            roundedDateTimePicker1.Location = new Point(313, 113);
            roundedDateTimePicker1.Name = "roundedDateTimePicker1";
            roundedDateTimePicker1.Size = new Size(275, 40);
            roundedDateTimePicker1.TabIndex = 10;
            roundedDateTimePicker1.Value = new DateTime(2026, 3, 16, 18, 36, 52, 148);
            // 
            // roundedTextBox5
            // 
            roundedTextBox5.BackColor = Color.White;
            roundedTextBox5.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roundedTextBox5.Location = new Point(844, 115);
            roundedTextBox5.Name = "roundedTextBox5";
            roundedTextBox5.PlaceholderText = "*Contact Number (+63)";
            roundedTextBox5.Size = new Size(271, 40);
            roundedTextBox5.TabIndex = 9;
            roundedTextBox5.Theme = ControlTheme.Light;
            // 
            // roundedComboBox2
            // 
            roundedComboBox2.BackColor = Color.White;
            roundedComboBox2.DrawMode = DrawMode.OwnerDrawFixed;
            roundedComboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            roundedComboBox2.Font = new Font("Poppins", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roundedComboBox2.ForeColor = Color.Black;
            roundedComboBox2.FormattingEnabled = true;
            roundedComboBox2.IntegralHeight = false;
            roundedComboBox2.Items.AddRange(new object[] { "Male", "Female" });
            roundedComboBox2.Location = new Point(594, 116);
            roundedComboBox2.Name = "roundedComboBox2";
            roundedComboBox2.PlaceholderText = "*Sex";
            roundedComboBox2.Size = new Size(244, 37);
            roundedComboBox2.TabIndex = 8;
            roundedComboBox2.Theme = ControlTheme.Light;
            // 
            // roundedComboBox1
            // 
            roundedComboBox1.BackColor = Color.White;
            roundedComboBox1.DrawMode = DrawMode.OwnerDrawFixed;
            roundedComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            roundedComboBox1.Font = new Font("Poppins", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roundedComboBox1.ForeColor = Color.Black;
            roundedComboBox1.FormattingEnabled = true;
            roundedComboBox1.IntegralHeight = false;
            roundedComboBox1.Items.AddRange(new object[] { "Jr. (Junior)", "Sr. (Senior)", "I", "II", "III", "IV", "V", "VI", "VII", "VIII" });
            roundedComboBox1.Location = new Point(951, 68);
            roundedComboBox1.Name = "roundedComboBox1";
            roundedComboBox1.PlaceholderText = "*Suffix";
            roundedComboBox1.Size = new Size(244, 37);
            roundedComboBox1.TabIndex = 5;
            roundedComboBox1.Theme = ControlTheme.Light;
            // 
            // roundedTextBox4
            // 
            roundedTextBox4.BackColor = Color.White;
            roundedTextBox4.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roundedTextBox4.Location = new Point(29, 115);
            roundedTextBox4.Name = "roundedTextBox4";
            roundedTextBox4.PlaceholderText = "*Age";
            roundedTextBox4.Size = new Size(153, 40);
            roundedTextBox4.TabIndex = 4;
            roundedTextBox4.Theme = ControlTheme.Light;
            // 
            // roundedTextBox3
            // 
            roundedTextBox3.BackColor = Color.White;
            roundedTextBox3.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roundedTextBox3.Location = new Point(663, 68);
            roundedTextBox3.Name = "roundedTextBox3";
            roundedTextBox3.PlaceholderText = "*Middle Name";
            roundedTextBox3.Size = new Size(271, 40);
            roundedTextBox3.TabIndex = 3;
            roundedTextBox3.Theme = ControlTheme.Light;
            // 
            // roundedTextBox2
            // 
            roundedTextBox2.BackColor = Color.White;
            roundedTextBox2.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roundedTextBox2.Location = new Point(358, 68);
            roundedTextBox2.Name = "roundedTextBox2";
            roundedTextBox2.PlaceholderText = "*First Name";
            roundedTextBox2.Size = new Size(294, 40);
            roundedTextBox2.TabIndex = 2;
            roundedTextBox2.Theme = ControlTheme.Light;
            // 
            // roundedTextBox1
            // 
            roundedTextBox1.BackColor = Color.White;
            roundedTextBox1.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roundedTextBox1.Location = new Point(29, 68);
            roundedTextBox1.Name = "roundedTextBox1";
            roundedTextBox1.PlaceholderText = "*Last Name";
            roundedTextBox1.Size = new Size(323, 40);
            roundedTextBox1.TabIndex = 1;
            roundedTextBox1.Theme = ControlTheme.Light;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(29, 26);
            label3.Name = "label3";
            label3.Size = new Size(1097, 20);
            label3.TabIndex = 0;
            label3.Text = "Patient Details_________________________________________________________________________________________________";
            // 
            // roundedButton1
            // 
            roundedButton1.BackColor = Color.FromArgb(37, 147, 65);
            roundedButton1.FlatAppearance.BorderSize = 0;
            roundedButton1.FlatStyle = FlatStyle.Flat;
            roundedButton1.Font = new Font("Zona Pro Bold", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roundedButton1.ForeColor = Color.White;
            roundedButton1.Location = new Point(424, 949);
            roundedButton1.Name = "roundedButton1";
            roundedButton1.Size = new Size(443, 57);
            roundedButton1.TabIndex = 8;
            roundedButton1.Text = "PRINT QUEUING NUMBER";
            roundedButton1.UseVisualStyleBackColor = false;
            // 
            // roundedButton2
            // 
            roundedButton2.BackColor = Color.FromArgb(26, 117, 159);
            roundedButton2.FlatAppearance.BorderSize = 0;
            roundedButton2.FlatStyle = FlatStyle.Flat;
            roundedButton2.Font = new Font("Zona Pro Bold", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roundedButton2.ForeColor = Color.White;
            roundedButton2.Image = Properties.Resources.PatientHistoryIcon;
            roundedButton2.ImageAlign = ContentAlignment.MiddleLeft;
            roundedButton2.Location = new Point(1424, 949);
            roundedButton2.Name = "roundedButton2";
            roundedButton2.Size = new Size(443, 57);
            roundedButton2.TabIndex = 9;
            roundedButton2.Text = "CLEAR ALL ENTRY";
            roundedButton2.TextImageRelation = TextImageRelation.ImageBeforeText;
            roundedButton2.UseVisualStyleBackColor = false;
            // 
            // PatientsCheckUpForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(229, 231, 231);
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1920, 1080);
            Controls.Add(roundedButton2);
            Controls.Add(roundedButton1);
            Controls.Add(roundedPanel1);
            Controls.Add(label2);
            Controls.Add(panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "PatientsCheckUpForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "PatientsCheckUpForm";
            Load += PatientsCheckUpForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            roundedPanel1.ResumeLayout(false);
            roundedPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Label lblNurse;
        private Label lbl_nurseLastName;
        private Button btn_checkupForm;
        private Button btn_todaysPatient;
        private Button button3;
        private Button button4;
        private Button btn_missedCheckups;
        private Button button6;
        private Label label2;
        private ContextMenuStrip contextMenuStrip1;
        private ToolTip toolTip1;
        private CustomControls.RoundedPanel roundedPanel1;
        private Label label3;
        private RoundedTextBox roundedTextBox3;
        private RoundedTextBox roundedTextBox2;
        private RoundedTextBox roundedTextBox1;
        private RoundedTextBox roundedTextBox4;
        private RoundedComboBox roundedComboBox1;
        private RoundedComboBox roundedComboBox2;
        private CustomControls.RoundedDateTimePicker roundedDateTimePicker1;
        private RoundedTextBox roundedTextBox5;
        private Label label4;
        private Label label6;
        private RoundedComboBox roundedComboBox3;
        private SquareRadioButton squareRadioButton2;
        private SquareRadioButton squareRadioButton1;
        private Label label5;
        private RoundedTextBox roundedTextBox8;
        private RoundedTextBox roundedTextBox7;
        private RoundedTextBox roundedTextBox13;
        private RoundedTextBox roundedTextBox12;
        private RoundedTextBox roundedTextBox11;
        private RoundedTextBox roundedTextBox10;
        private Label label7;
        private RoundedTextBox roundedTextBox9;
        private RoundedTextBox roundedTextBox6;
        private RoundedTextBox roundedTextBox14;
        private Label label8;
        private RoundedButton roundedButton1;
        private RoundedButton roundedButton2;
        private Button button8;
        private Button btn_logout;
        private Label label9;
    }
}