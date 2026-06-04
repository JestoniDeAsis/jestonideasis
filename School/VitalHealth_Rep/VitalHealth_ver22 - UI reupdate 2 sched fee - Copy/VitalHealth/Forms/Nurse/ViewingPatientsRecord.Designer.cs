namespace VitalHealth.Forms.Nurse
{
    partial class ViewingPatientsRecord
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            backPatientHistory = new PictureBox();
            panel2 = new Panel();
            doctorConsultationBtn = new Button();
            panel1 = new Panel();
            reasonTxtBox = new RoundedMultilineTextBox();
            weightTxtBox = new RoundedTextBox();
            label24 = new Label();
            tempTxtBox = new RoundedTextBox();
            label25 = new Label();
            label23 = new Label();
            heartRateTxtBox = new RoundedTextBox();
            label22 = new Label();
            bloodPressureTxtBox = new RoundedTextBox();
            specialtyTxtBox = new RoundedTextBox();
            assignDocTxtBox = new RoundedTextBox();
            patientTypeTxtBox = new RoundedTextBox();
            arrivalTxtBox = new RoundedTextBox();
            chckupDateTxtBox = new RoundedTextBox();
            label26 = new Label();
            label27 = new Label();
            label21 = new Label();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            label20 = new Label();
            label16 = new Label();
            emergContactTxtBox = new RoundedTextBox();
            label14 = new Label();
            emergRelationTxtBox = new RoundedTextBox();
            label13 = new Label();
            patientNameLbl = new Label();
            label12 = new Label();
            emergNameTxtBox = new RoundedTextBox();
            patientContactTxtBox = new RoundedTextBox();
            birthDateTxtBox = new RoundedTextBox();
            sexTxtBox = new RoundedTextBox();
            ageTxtBox = new RoundedTextBox();
            label15 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label4 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)backPatientHistory).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.WindowFrame;
            label3.Location = new Point(643, 83);
            label3.Name = "label3";
            label3.Size = new Size(666, 25);
            label3.TabIndex = 18;
            label3.Text = "Shows the patient’s checkup record and doctor’s consultation.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Zona Pro Bold", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(826, 45);
            label2.Name = "label2";
            label2.Size = new Size(312, 38);
            label2.TabIndex = 17;
            label2.Text = "Patient’s Record";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(50, 50, 50);
            flowLayoutPanel1.Location = new Point(955, 162);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(10, 65);
            flowLayoutPanel1.TabIndex = 19;
            // 
            // backPatientHistory
            // 
            backPatientHistory.BackColor = Color.Transparent;
            backPatientHistory.BackgroundImageLayout = ImageLayout.Zoom;
            backPatientHistory.Cursor = Cursors.Hand;
            backPatientHistory.Image = Properties.Resources.backBlack_icon;
            backPatientHistory.Location = new Point(44, 40);
            backPatientHistory.Name = "backPatientHistory";
            backPatientHistory.Size = new Size(30, 43);
            backPatientHistory.SizeMode = PictureBoxSizeMode.StretchImage;
            backPatientHistory.TabIndex = 20;
            backPatientHistory.TabStop = false;
            backPatientHistory.Click += backPatientHistory_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.BackgroundImage = Properties.Resources.VitalHealth_Logo;
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Location = new Point(1754, 31);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(90, 90);
            panel2.TabIndex = 21;
            // 
            // doctorConsultationBtn
            // 
            doctorConsultationBtn.BackColor = Color.FromArgb(147, 234, 169);
            doctorConsultationBtn.FlatAppearance.BorderSize = 0;
            doctorConsultationBtn.FlatStyle = FlatStyle.Flat;
            doctorConsultationBtn.Font = new Font("Zona Pro Bold", 23.9999962F, FontStyle.Regular, GraphicsUnit.Point, 0);
            doctorConsultationBtn.ForeColor = Color.White;
            doctorConsultationBtn.Location = new Point(965, 162);
            doctorConsultationBtn.Margin = new Padding(3, 2, 3, 2);
            doctorConsultationBtn.Name = "doctorConsultationBtn";
            doctorConsultationBtn.Padding = new Padding(13, 0, 0, 0);
            doctorConsultationBtn.Size = new Size(955, 65);
            doctorConsultationBtn.TabIndex = 23;
            doctorConsultationBtn.Text = "DOCTOR’S CONSULTATION";
            doctorConsultationBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            doctorConsultationBtn.UseVisualStyleBackColor = false;
            doctorConsultationBtn.Click += doctorConsultationBtn_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(250, 250, 250);
            panel1.Controls.Add(reasonTxtBox);
            panel1.Controls.Add(weightTxtBox);
            panel1.Controls.Add(label24);
            panel1.Controls.Add(tempTxtBox);
            panel1.Controls.Add(label25);
            panel1.Controls.Add(label23);
            panel1.Controls.Add(heartRateTxtBox);
            panel1.Controls.Add(label22);
            panel1.Controls.Add(bloodPressureTxtBox);
            panel1.Controls.Add(specialtyTxtBox);
            panel1.Controls.Add(assignDocTxtBox);
            panel1.Controls.Add(patientTypeTxtBox);
            panel1.Controls.Add(arrivalTxtBox);
            panel1.Controls.Add(chckupDateTxtBox);
            panel1.Controls.Add(label26);
            panel1.Controls.Add(label27);
            panel1.Controls.Add(label21);
            panel1.Controls.Add(label17);
            panel1.Controls.Add(label18);
            panel1.Controls.Add(label19);
            panel1.Controls.Add(label20);
            panel1.Controls.Add(label16);
            panel1.Controls.Add(emergContactTxtBox);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(emergRelationTxtBox);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(patientNameLbl);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(emergNameTxtBox);
            panel1.Controls.Add(patientContactTxtBox);
            panel1.Controls.Add(birthDateTxtBox);
            panel1.Controls.Add(sexTxtBox);
            panel1.Controls.Add(ageTxtBox);
            panel1.Controls.Add(label15);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(0, 230);
            panel1.Name = "panel1";
            panel1.Size = new Size(1920, 849);
            panel1.TabIndex = 24;
            // 
            // reasonTxtBox
            // 
            reasonTxtBox.BaseColor = Color.White;
            reasonTxtBox.BorderColor = Color.FromArgb(200, 200, 200);
            reasonTxtBox.FocusBorderColor = Color.FromArgb(100, 100, 100);
            reasonTxtBox.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            reasonTxtBox.HoverBorderColor = Color.FromArgb(170, 170, 170);
            reasonTxtBox.Location = new Point(63, 604);
            reasonTxtBox.Name = "reasonTxtBox";
            reasonTxtBox.ReadOnly = true;
            reasonTxtBox.Size = new Size(610, 100);
            reasonTxtBox.TabIndex = 75;
            reasonTxtBox.TextColor = Color.Black;
            reasonTxtBox.TextPadding = new Padding(14, 12, 14, 12);
            // 
            // weightTxtBox
            // 
            weightTxtBox.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            weightTxtBox.Location = new Point(1101, 516);
            weightTxtBox.Name = "weightTxtBox";
            weightTxtBox.Size = new Size(216, 40);
            weightTxtBox.TabIndex = 74;
            weightTxtBox.Theme = ControlTheme.Light;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Zona Pro Bold", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label24.ForeColor = Color.Black;
            label24.ImageAlign = ContentAlignment.MiddleRight;
            label24.Location = new Point(1000, 524);
            label24.Name = "label24";
            label24.Size = new Size(92, 23);
            label24.TabIndex = 73;
            label24.Text = "Weight:";
            // 
            // tempTxtBox
            // 
            tempTxtBox.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tempTxtBox.Location = new Point(1161, 465);
            tempTxtBox.Name = "tempTxtBox";
            tempTxtBox.Size = new Size(218, 40);
            tempTxtBox.TabIndex = 72;
            tempTxtBox.Theme = ControlTheme.Light;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Zona Pro Bold", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label25.ForeColor = Color.Black;
            label25.ImageAlign = ContentAlignment.MiddleRight;
            label25.Location = new Point(1000, 473);
            label25.Name = "label25";
            label25.Size = new Size(154, 23);
            label25.TabIndex = 71;
            label25.Text = "Temperature:";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Zona Pro Bold", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label23.ForeColor = Color.Black;
            label23.ImageAlign = ContentAlignment.MiddleRight;
            label23.Location = new Point(63, 572);
            label23.Name = "label23";
            label23.Size = new Size(234, 23);
            label23.TabIndex = 69;
            label23.Text = "Reason for Checkup:";
            // 
            // heartRateTxtBox
            // 
            heartRateTxtBox.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            heartRateTxtBox.Location = new Point(1140, 413);
            heartRateTxtBox.Name = "heartRateTxtBox";
            heartRateTxtBox.Size = new Size(214, 40);
            heartRateTxtBox.TabIndex = 68;
            heartRateTxtBox.Theme = ControlTheme.Light;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Zona Pro Bold", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label22.ForeColor = Color.Black;
            label22.ImageAlign = ContentAlignment.MiddleRight;
            label22.Location = new Point(1000, 421);
            label22.Name = "label22";
            label22.Size = new Size(134, 23);
            label22.TabIndex = 67;
            label22.Text = "Heart Rate:";
            // 
            // bloodPressureTxtBox
            // 
            bloodPressureTxtBox.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bloodPressureTxtBox.Location = new Point(1183, 362);
            bloodPressureTxtBox.Name = "bloodPressureTxtBox";
            bloodPressureTxtBox.Size = new Size(218, 40);
            bloodPressureTxtBox.TabIndex = 66;
            bloodPressureTxtBox.Theme = ControlTheme.Light;
            // 
            // specialtyTxtBox
            // 
            specialtyTxtBox.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            specialtyTxtBox.Location = new Point(1139, 281);
            specialtyTxtBox.Name = "specialtyTxtBox";
            specialtyTxtBox.Size = new Size(336, 40);
            specialtyTxtBox.TabIndex = 65;
            specialtyTxtBox.Theme = ControlTheme.Light;
            // 
            // assignDocTxtBox
            // 
            assignDocTxtBox.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            assignDocTxtBox.Location = new Point(1191, 232);
            assignDocTxtBox.Name = "assignDocTxtBox";
            assignDocTxtBox.Size = new Size(284, 40);
            assignDocTxtBox.TabIndex = 64;
            assignDocTxtBox.Theme = ControlTheme.Light;
            // 
            // patientTypeTxtBox
            // 
            patientTypeTxtBox.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            patientTypeTxtBox.Location = new Point(1150, 183);
            patientTypeTxtBox.Name = "patientTypeTxtBox";
            patientTypeTxtBox.Size = new Size(325, 40);
            patientTypeTxtBox.TabIndex = 63;
            patientTypeTxtBox.Theme = ControlTheme.Light;
            // 
            // arrivalTxtBox
            // 
            arrivalTxtBox.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            arrivalTxtBox.Location = new Point(1145, 135);
            arrivalTxtBox.Name = "arrivalTxtBox";
            arrivalTxtBox.Size = new Size(150, 40);
            arrivalTxtBox.TabIndex = 62;
            arrivalTxtBox.Theme = ControlTheme.Light;
            // 
            // chckupDateTxtBox
            // 
            chckupDateTxtBox.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chckupDateTxtBox.Location = new Point(1074, 85);
            chckupDateTxtBox.Name = "chckupDateTxtBox";
            chckupDateTxtBox.Size = new Size(221, 40);
            chckupDateTxtBox.TabIndex = 61;
            chckupDateTxtBox.Theme = ControlTheme.Light;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Zona Pro Bold", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label26.ForeColor = Color.Black;
            label26.ImageAlign = ContentAlignment.MiddleRight;
            label26.Location = new Point(999, 373);
            label26.Name = "label26";
            label26.Size = new Size(178, 23);
            label26.TabIndex = 60;
            label26.Text = "Blood Pressure:";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label27.ForeColor = SystemColors.WindowFrame;
            label27.ImageAlign = ContentAlignment.MiddleRight;
            label27.Location = new Point(973, 338);
            label27.Name = "label27";
            label27.Size = new Size(108, 24);
            label27.TabIndex = 59;
            label27.Text = "Vital Signs";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Zona Pro Bold", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label21.ForeColor = Color.Black;
            label21.ImageAlign = ContentAlignment.TopLeft;
            label21.Location = new Point(991, 287);
            label21.Name = "label21";
            label21.Size = new Size(142, 23);
            label21.TabIndex = 58;
            label21.Text = "Specialty in:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Zona Pro Bold", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label17.ForeColor = Color.Black;
            label17.ImageAlign = ContentAlignment.TopLeft;
            label17.Location = new Point(991, 194);
            label17.Name = "label17";
            label17.Size = new Size(153, 23);
            label17.TabIndex = 57;
            label17.Text = "Patient Type:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Zona Pro Bold", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label18.ForeColor = Color.Black;
            label18.ImageAlign = ContentAlignment.TopLeft;
            label18.Location = new Point(991, 147);
            label18.Name = "label18";
            label18.Size = new Size(148, 23);
            label18.TabIndex = 56;
            label18.Text = "Arrival Time:";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Zona Pro Bold", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label19.ForeColor = Color.Black;
            label19.ImageAlign = ContentAlignment.TopLeft;
            label19.Location = new Point(991, 242);
            label19.Name = "label19";
            label19.Size = new Size(194, 23);
            label19.TabIndex = 55;
            label19.Text = "Assigned Doctor:";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Zona Pro Bold", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label20.ForeColor = Color.Black;
            label20.ImageAlign = ContentAlignment.MiddleRight;
            label20.Location = new Point(991, 97);
            label20.Name = "label20";
            label20.Size = new Size(67, 23);
            label20.TabIndex = 54;
            label20.Text = "Date:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.ForeColor = SystemColors.WindowFrame;
            label16.ImageAlign = ContentAlignment.MiddleRight;
            label16.Location = new Point(965, 44);
            label16.Name = "label16";
            label16.Size = new Size(161, 24);
            label16.TabIndex = 53;
            label16.Text = "Checkup Details";
            // 
            // emergContactTxtBox
            // 
            emergContactTxtBox.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emergContactTxtBox.Location = new Point(263, 495);
            emergContactTxtBox.Name = "emergContactTxtBox";
            emergContactTxtBox.Size = new Size(232, 40);
            emergContactTxtBox.TabIndex = 51;
            emergContactTxtBox.Theme = ControlTheme.Light;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Zona Pro Bold", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.Black;
            label14.ImageAlign = ContentAlignment.MiddleRight;
            label14.Location = new Point(65, 502);
            label14.Name = "label14";
            label14.Size = new Size(195, 23);
            label14.TabIndex = 50;
            label14.Text = "Contact Number:";
            // 
            // emergRelationTxtBox
            // 
            emergRelationTxtBox.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emergRelationTxtBox.Location = new Point(218, 433);
            emergRelationTxtBox.Name = "emergRelationTxtBox";
            emergRelationTxtBox.Size = new Size(277, 40);
            emergRelationTxtBox.TabIndex = 49;
            emergRelationTxtBox.Theme = ControlTheme.Light;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Zona Pro Bold", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.Black;
            label13.ImageAlign = ContentAlignment.MiddleRight;
            label13.Location = new Point(65, 440);
            label13.Name = "label13";
            label13.Size = new Size(149, 23);
            label13.TabIndex = 48;
            label13.Text = "Relationship:";
            // 
            // patientNameLbl
            // 
            patientNameLbl.AutoSize = true;
            patientNameLbl.Font = new Font("Zona Pro Bold", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            patientNameLbl.Location = new Point(42, 79);
            patientNameLbl.Name = "patientNameLbl";
            patientNameLbl.Size = new Size(347, 38);
            patientNameLbl.TabIndex = 34;
            patientNameLbl.Text = "Patient's Fullname";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Zona Pro Bold", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(42, 98);
            label12.Name = "label12";
            label12.Size = new Size(731, 38);
            label12.TabIndex = 47;
            label12.Text = "__________________________________";
            // 
            // emergNameTxtBox
            // 
            emergNameTxtBox.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emergNameTxtBox.Location = new Point(150, 372);
            emergNameTxtBox.Name = "emergNameTxtBox";
            emergNameTxtBox.Size = new Size(345, 40);
            emergNameTxtBox.TabIndex = 46;
            emergNameTxtBox.Theme = ControlTheme.Light;
            // 
            // patientContactTxtBox
            // 
            patientContactTxtBox.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            patientContactTxtBox.Location = new Point(553, 255);
            patientContactTxtBox.Name = "patientContactTxtBox";
            patientContactTxtBox.Size = new Size(183, 40);
            patientContactTxtBox.TabIndex = 45;
            patientContactTxtBox.Theme = ControlTheme.Light;
            // 
            // birthDateTxtBox
            // 
            birthDateTxtBox.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            birthDateTxtBox.Location = new Point(513, 204);
            birthDateTxtBox.Name = "birthDateTxtBox";
            birthDateTxtBox.Size = new Size(223, 40);
            birthDateTxtBox.TabIndex = 44;
            birthDateTxtBox.Theme = ControlTheme.Light;
            // 
            // sexTxtBox
            // 
            sexTxtBox.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sexTxtBox.Location = new Point(126, 255);
            sexTxtBox.Name = "sexTxtBox";
            sexTxtBox.Size = new Size(150, 40);
            sexTxtBox.TabIndex = 43;
            sexTxtBox.Theme = ControlTheme.Light;
            // 
            // ageTxtBox
            // 
            ageTxtBox.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ageTxtBox.Location = new Point(126, 204);
            ageTxtBox.Name = "ageTxtBox";
            ageTxtBox.Size = new Size(150, 40);
            ageTxtBox.TabIndex = 42;
            ageTxtBox.Theme = ControlTheme.Light;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Zona Pro Bold", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.Black;
            label15.ImageAlign = ContentAlignment.MiddleRight;
            label15.Location = new Point(65, 381);
            label15.Name = "label15";
            label15.Size = new Size(79, 23);
            label15.TabIndex = 41;
            label15.Text = "Name:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = SystemColors.WindowFrame;
            label11.ImageAlign = ContentAlignment.MiddleRight;
            label11.Location = new Point(54, 334);
            label11.Name = "label11";
            label11.Size = new Size(193, 24);
            label11.TabIndex = 40;
            label11.Text = "Emergency Contact";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Zona Pro Bold", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Black;
            label10.ImageAlign = ContentAlignment.TopLeft;
            label10.Location = new Point(352, 263);
            label10.Name = "label10";
            label10.Size = new Size(195, 23);
            label10.TabIndex = 39;
            label10.Text = "Contact Number:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Zona Pro Bold", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Black;
            label9.ImageAlign = ContentAlignment.TopLeft;
            label9.Location = new Point(63, 263);
            label9.Name = "label9";
            label9.Size = new Size(53, 23);
            label9.TabIndex = 38;
            label9.Text = "Sex:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Zona Pro Bold", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Black;
            label8.ImageAlign = ContentAlignment.TopLeft;
            label8.Location = new Point(352, 213);
            label8.Name = "label8";
            label8.Size = new Size(155, 23);
            label8.TabIndex = 37;
            label8.Text = "Date of Birth:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Zona Pro Bold", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.ImageAlign = ContentAlignment.MiddleRight;
            label7.Location = new Point(63, 213);
            label7.Name = "label7";
            label7.Size = new Size(57, 23);
            label7.TabIndex = 36;
            label7.Text = "Age:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.WindowFrame;
            label6.ImageAlign = ContentAlignment.MiddleRight;
            label6.Location = new Point(54, 168);
            label6.Name = "label6";
            label6.Size = new Size(201, 24);
            label6.TabIndex = 35;
            label6.Text = "Personal Information";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Gray;
            label4.ImageAlign = ContentAlignment.MiddleRight;
            label4.Location = new Point(42, 44);
            label4.Name = "label4";
            label4.Size = new Size(149, 24);
            label4.TabIndex = 33;
            label4.Text = "Patient's Name";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(37, 147, 65);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Zona Pro Bold", 23.9999962F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(0, 162);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Padding = new Padding(13, 0, 0, 0);
            button1.Size = new Size(955, 65);
            button1.TabIndex = 25;
            button1.Text = "PATIENT’S DETAILS";
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = false;
            // 
            // ViewingPatientsRecord
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(229, 231, 231);
            ClientSize = new Size(1920, 1080);
            Controls.Add(button1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(doctorConsultationBtn);
            Controls.Add(panel2);
            Controls.Add(backPatientHistory);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewingPatientsRecord";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)backPatientHistory).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        private Label label3;
        private Label label2;
        private FlowLayoutPanel flowLayoutPanel1;
        private PictureBox backPatientHistory;
        private Panel panel2;
        private Button doctorConsultationBtn;
        private Panel panel1;
        private RoundedTextBox emergNameTxtBox;
        private RoundedTextBox patientContactTxtBox;
        private RoundedTextBox birthDateTxtBox;
        private RoundedTextBox sexTxtBox;
        private RoundedTextBox ageTxtBox;
        private Label label15;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label patientNameLbl;
        private Label label4;
        private Label label12;
        private RoundedTextBox emergContactTxtBox;
        private Label label14;
        private RoundedTextBox emergRelationTxtBox;
        private Label label13;
        private RoundedTextBox bloodPressureTxtBox;
        private RoundedTextBox specialtyTxtBox;
        private RoundedTextBox assignDocTxtBox;
        private RoundedTextBox patientTypeTxtBox;
        private RoundedTextBox arrivalTxtBox;
        private RoundedTextBox chckupDateTxtBox;
        private Label label26;
        private Label label27;
        private Label label21;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label label20;
        private Label label16;
        private Label label23;
        private RoundedTextBox heartRateTxtBox;
        private Label label22;
        private RoundedTextBox weightTxtBox;
        private Label label24;
        private RoundedTextBox tempTxtBox;
        private Label label25;
        private RoundedMultilineTextBox reasonTxtBox;
        private Button button1;
    }
}