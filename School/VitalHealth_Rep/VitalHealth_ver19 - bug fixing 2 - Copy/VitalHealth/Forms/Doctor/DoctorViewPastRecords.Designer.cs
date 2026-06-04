namespace VitalHealth.Forms.Doctor
{
    partial class DoctorViewPastRecords
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorViewPastRecords));
            roundedPanel1 = new VitalHealth.CustomControls.RoundedPanel();
            lbl_weight = new Label();
            lbl_heartrate = new Label();
            lbl_temperature = new Label();
            lbl_bloodPressure = new Label();
            label1 = new Label();
            txtB_physicalExam = new RoundedTextBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            lbl_reason = new Label();
            label2 = new Label();
            btn_back = new PictureBox();
            lbl_patientData = new Label();
            roundedPanel2 = new VitalHealth.CustomControls.RoundedPanel();
            chkBox_others = new CheckBox();
            label3 = new Label();
            chkBox_ultrasound = new CheckBox();
            txtB_otherTest = new RoundedTextBox();
            chkBox_xray = new CheckBox();
            txtB_prescription = new RoundedTextBox();
            chkBox_urinalysis = new CheckBox();
            txtB_treatmentPlan = new RoundedTextBox();
            chkBox_bloodtest = new CheckBox();
            txtB_diagnosis = new RoundedTextBox();
            btn_finalize = new RoundedButton();
            txtB_followup = new RoundedTextBox();
            label19 = new Label();
            label12 = new Label();
            txtB_symptomsReport = new RoundedMultilineTextBox();
            roundedPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btn_back).BeginInit();
            roundedPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // roundedPanel1
            // 
            roundedPanel1.BackColor = Color.FromArgb(198, 240, 208);
            roundedPanel1.BorderRadius = 30;
            roundedPanel1.Controls.Add(txtB_symptomsReport);
            roundedPanel1.Controls.Add(lbl_weight);
            roundedPanel1.Controls.Add(lbl_heartrate);
            roundedPanel1.Controls.Add(lbl_temperature);
            roundedPanel1.Controls.Add(lbl_bloodPressure);
            roundedPanel1.Controls.Add(label1);
            roundedPanel1.Controls.Add(txtB_physicalExam);
            roundedPanel1.Controls.Add(label11);
            roundedPanel1.Controls.Add(label10);
            roundedPanel1.Controls.Add(label9);
            roundedPanel1.Controls.Add(label8);
            roundedPanel1.Controls.Add(label7);
            roundedPanel1.Controls.Add(label6);
            roundedPanel1.Controls.Add(label5);
            roundedPanel1.Controls.Add(lbl_reason);
            roundedPanel1.Controls.Add(label2);
            roundedPanel1.Location = new Point(139, 133);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Size = new Size(792, 904);
            roundedPanel1.TabIndex = 17;
            // 
            // lbl_weight
            // 
            lbl_weight.AutoSize = true;
            lbl_weight.Font = new Font("Poppins", 14F);
            lbl_weight.Location = new Point(309, 260);
            lbl_weight.Name = "lbl_weight";
            lbl_weight.Size = new Size(48, 34);
            lbl_weight.TabIndex = 75;
            lbl_weight.Text = ": 00";
            // 
            // lbl_heartrate
            // 
            lbl_heartrate.AutoSize = true;
            lbl_heartrate.Font = new Font("Poppins", 14F);
            lbl_heartrate.Location = new Point(309, 225);
            lbl_heartrate.Name = "lbl_heartrate";
            lbl_heartrate.Size = new Size(48, 34);
            lbl_heartrate.TabIndex = 74;
            lbl_heartrate.Text = ": 00";
            // 
            // lbl_temperature
            // 
            lbl_temperature.AutoSize = true;
            lbl_temperature.Font = new Font("Poppins", 14F);
            lbl_temperature.Location = new Point(309, 189);
            lbl_temperature.Name = "lbl_temperature";
            lbl_temperature.Size = new Size(48, 34);
            lbl_temperature.TabIndex = 73;
            lbl_temperature.Text = ": 00";
            // 
            // lbl_bloodPressure
            // 
            lbl_bloodPressure.AutoSize = true;
            lbl_bloodPressure.Font = new Font("Poppins", 14F);
            lbl_bloodPressure.Location = new Point(309, 153);
            lbl_bloodPressure.Name = "lbl_bloodPressure";
            lbl_bloodPressure.Size = new Size(93, 34);
            lbl_bloodPressure.TabIndex = 72;
            lbl_bloodPressure.Text = ": 000/00";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            label1.Location = new Point(37, 67);
            label1.Name = "label1";
            label1.Size = new Size(203, 24);
            label1.TabIndex = 67;
            label1.Text = "Reason for checkup:";
            // 
            // txtB_physicalExam
            // 
            txtB_physicalExam.BackColor = Color.Transparent;
            txtB_physicalExam.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtB_physicalExam.Location = new Point(37, 540);
            txtB_physicalExam.Name = "txtB_physicalExam";
            txtB_physicalExam.Size = new Size(710, 125);
            txtB_physicalExam.TabIndex = 66;
            txtB_physicalExam.Theme = ControlTheme.Light;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            label11.Location = new Point(37, 511);
            label11.Name = "label11";
            label11.Size = new Size(174, 24);
            label11.TabIndex = 65;
            label11.Text = "PHYSICAL EXAM";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            label10.Location = new Point(37, 346);
            label10.Name = "label10";
            label10.Size = new Size(221, 24);
            label10.TabIndex = 63;
            label10.Text = "SYMPTOMS REPORT:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Poppins", 14F);
            label9.Location = new Point(37, 259);
            label9.Name = "label9";
            label9.Size = new Size(129, 34);
            label9.TabIndex = 59;
            label9.Text = "Weight (kg)";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Poppins", 14F);
            label8.Location = new Point(37, 224);
            label8.Name = "label8";
            label8.Size = new Size(185, 34);
            label8.TabIndex = 58;
            label8.Text = "Heart Rate (bpm)";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Poppins", 14F);
            label7.Location = new Point(37, 188);
            label7.Name = "label7";
            label7.Size = new Size(186, 34);
            label7.TabIndex = 57;
            label7.Text = "Temperature (°C)";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Poppins", 14F);
            label6.Location = new Point(37, 152);
            label6.Name = "label6";
            label6.Size = new Size(244, 34);
            label6.TabIndex = 56;
            label6.Text = "Blood Pressure (mmHg)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            label5.Location = new Point(37, 114);
            label5.Name = "label5";
            label5.Size = new Size(140, 24);
            label5.TabIndex = 55;
            label5.Text = "VITAL SIGNS:";
            // 
            // lbl_reason
            // 
            lbl_reason.AutoSize = true;
            lbl_reason.BackColor = Color.Transparent;
            lbl_reason.Font = new Font("Poppins", 14F);
            lbl_reason.Location = new Point(261, 65);
            lbl_reason.Name = "lbl_reason";
            lbl_reason.Size = new Size(78, 32);
            lbl_reason.TabIndex = 42;
            lbl_reason.Text = "Reason";
            lbl_reason.TextAlign = ContentAlignment.MiddleCenter;
            lbl_reason.UseCompatibleTextRendering = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(37, 22);
            label2.Name = "label2";
            label2.Size = new Size(422, 26);
            label2.TabIndex = 1;
            label2.Text = "VITAL SIGNS AND INITIAL FINDINGS";
            // 
            // btn_back
            // 
            btn_back.BackColor = Color.FromArgb(37, 147, 65);
            btn_back.Cursor = Cursors.Hand;
            btn_back.Image = (Image)resources.GetObject("btn_back.Image");
            btn_back.Location = new Point(25, 14);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(53, 53);
            btn_back.SizeMode = PictureBoxSizeMode.StretchImage;
            btn_back.TabIndex = 11;
            btn_back.TabStop = false;
            btn_back.Click += btn_back_Click;
            // 
            // lbl_patientData
            // 
            lbl_patientData.BackColor = Color.FromArgb(37, 147, 65);
            lbl_patientData.Dock = DockStyle.Top;
            lbl_patientData.Font = new Font("Zona Pro Bold", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_patientData.ForeColor = Color.White;
            lbl_patientData.Location = new Point(0, 0);
            lbl_patientData.Name = "lbl_patientData";
            lbl_patientData.Padding = new Padding(0, 20, 0, 20);
            lbl_patientData.Size = new Size(1920, 82);
            lbl_patientData.TabIndex = 56;
            lbl_patientData.Text = "Patient's name, Age, Gender";
            lbl_patientData.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // roundedPanel2
            // 
            roundedPanel2.BackColor = Color.FromArgb(198, 240, 208);
            roundedPanel2.BorderRadius = 30;
            roundedPanel2.Controls.Add(chkBox_others);
            roundedPanel2.Controls.Add(label3);
            roundedPanel2.Controls.Add(chkBox_ultrasound);
            roundedPanel2.Controls.Add(txtB_otherTest);
            roundedPanel2.Controls.Add(chkBox_xray);
            roundedPanel2.Controls.Add(txtB_prescription);
            roundedPanel2.Controls.Add(chkBox_urinalysis);
            roundedPanel2.Controls.Add(txtB_treatmentPlan);
            roundedPanel2.Controls.Add(chkBox_bloodtest);
            roundedPanel2.Controls.Add(txtB_diagnosis);
            roundedPanel2.Controls.Add(btn_finalize);
            roundedPanel2.Controls.Add(txtB_followup);
            roundedPanel2.Controls.Add(label19);
            roundedPanel2.Controls.Add(label12);
            roundedPanel2.Location = new Point(1011, 132);
            roundedPanel2.Name = "roundedPanel2";
            roundedPanel2.Size = new Size(792, 905);
            roundedPanel2.TabIndex = 70;
            // 
            // chkBox_others
            // 
            chkBox_others.AutoSize = true;
            chkBox_others.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkBox_others.Location = new Point(205, 260);
            chkBox_others.Name = "chkBox_others";
            chkBox_others.Size = new Size(84, 32);
            chkBox_others.TabIndex = 97;
            chkBox_others.Text = "Others";
            chkBox_others.UseVisualStyleBackColor = true;
            chkBox_others.CheckStateChanged += chkBox_others_CheckStateChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(37, 214);
            label3.Name = "label3";
            label3.Size = new Size(370, 26);
            label3.TabIndex = 86;
            label3.Text = "LABOLATORY TEST REQUESTS";
            // 
            // chkBox_ultrasound
            // 
            chkBox_ultrasound.AutoSize = true;
            chkBox_ultrasound.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkBox_ultrasound.Location = new Point(46, 374);
            chkBox_ultrasound.Name = "chkBox_ultrasound";
            chkBox_ultrasound.Size = new Size(118, 32);
            chkBox_ultrasound.TabIndex = 96;
            chkBox_ultrasound.Text = "Ultrasound";
            chkBox_ultrasound.UseVisualStyleBackColor = true;
            // 
            // txtB_otherTest
            // 
            txtB_otherTest.BackColor = Color.Transparent;
            txtB_otherTest.Enabled = false;
            txtB_otherTest.Font = new Font("Poppins", 14F);
            txtB_otherTest.Location = new Point(205, 291);
            txtB_otherTest.Name = "txtB_otherTest";
            txtB_otherTest.Size = new Size(284, 39);
            txtB_otherTest.TabIndex = 85;
            txtB_otherTest.Theme = ControlTheme.Light;
            // 
            // chkBox_xray
            // 
            chkBox_xray.AutoSize = true;
            chkBox_xray.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkBox_xray.Location = new Point(46, 336);
            chkBox_xray.Name = "chkBox_xray";
            chkBox_xray.Size = new Size(80, 32);
            chkBox_xray.TabIndex = 95;
            chkBox_xray.Text = "X-Ray";
            chkBox_xray.UseVisualStyleBackColor = true;
            // 
            // txtB_prescription
            // 
            txtB_prescription.BackColor = Color.Transparent;
            txtB_prescription.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtB_prescription.Location = new Point(37, 148);
            txtB_prescription.Name = "txtB_prescription";
            txtB_prescription.PlaceholderText = "*Prescription";
            txtB_prescription.Size = new Size(710, 40);
            txtB_prescription.TabIndex = 74;
            txtB_prescription.Theme = ControlTheme.Light;
            // 
            // chkBox_urinalysis
            // 
            chkBox_urinalysis.AutoSize = true;
            chkBox_urinalysis.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkBox_urinalysis.Location = new Point(46, 298);
            chkBox_urinalysis.Name = "chkBox_urinalysis";
            chkBox_urinalysis.Size = new Size(106, 32);
            chkBox_urinalysis.TabIndex = 94;
            chkBox_urinalysis.Text = "Urinalysis";
            chkBox_urinalysis.UseVisualStyleBackColor = true;
            // 
            // txtB_treatmentPlan
            // 
            txtB_treatmentPlan.BackColor = Color.Transparent;
            txtB_treatmentPlan.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtB_treatmentPlan.Location = new Point(37, 102);
            txtB_treatmentPlan.Name = "txtB_treatmentPlan";
            txtB_treatmentPlan.PlaceholderText = "*Treatment Plan";
            txtB_treatmentPlan.Size = new Size(710, 40);
            txtB_treatmentPlan.TabIndex = 73;
            txtB_treatmentPlan.Theme = ControlTheme.Light;
            // 
            // chkBox_bloodtest
            // 
            chkBox_bloodtest.AutoSize = true;
            chkBox_bloodtest.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkBox_bloodtest.Location = new Point(46, 260);
            chkBox_bloodtest.Name = "chkBox_bloodtest";
            chkBox_bloodtest.Size = new Size(113, 32);
            chkBox_bloodtest.TabIndex = 93;
            chkBox_bloodtest.Text = "Blood Test";
            chkBox_bloodtest.UseVisualStyleBackColor = true;
            // 
            // txtB_diagnosis
            // 
            txtB_diagnosis.BackColor = Color.Transparent;
            txtB_diagnosis.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtB_diagnosis.Location = new Point(37, 56);
            txtB_diagnosis.Name = "txtB_diagnosis";
            txtB_diagnosis.PlaceholderText = "*Diagnosis";
            txtB_diagnosis.Size = new Size(710, 40);
            txtB_diagnosis.TabIndex = 71;
            txtB_diagnosis.Theme = ControlTheme.Light;
            // 
            // btn_finalize
            // 
            btn_finalize.BackColor = Color.FromArgb(5, 137, 38);
            btn_finalize.Cursor = Cursors.Hand;
            btn_finalize.FlatAppearance.BorderSize = 0;
            btn_finalize.FlatStyle = FlatStyle.Flat;
            btn_finalize.Font = new Font("Zona Pro Bold", 16F);
            btn_finalize.ForeColor = Color.White;
            btn_finalize.Location = new Point(147, 732);
            btn_finalize.Name = "btn_finalize";
            btn_finalize.Size = new Size(514, 54);
            btn_finalize.TabIndex = 68;
            btn_finalize.Text = "COMPLETE CONSULTATION";
            btn_finalize.UseVisualStyleBackColor = false;
            btn_finalize.Click += btn_finalize_Click;
            // 
            // txtB_followup
            // 
            txtB_followup.BackColor = Color.Transparent;
            txtB_followup.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtB_followup.Location = new Point(37, 463);
            txtB_followup.Name = "txtB_followup";
            txtB_followup.Size = new Size(710, 125);
            txtB_followup.TabIndex = 66;
            txtB_followup.Theme = ControlTheme.Light;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            label19.Location = new Point(37, 434);
            label19.Name = "label19";
            label19.Size = new Size(314, 24);
            label19.TabIndex = 65;
            label19.Text = "FOLLOW-UP AND NEXT STEPS";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(37, 22);
            label12.Name = "label12";
            label12.Size = new Size(417, 26);
            label12.TabIndex = 1;
            label12.Text = "DIAGNOSIS AND TREATMENT PLAN";
            // 
            // txtB_symptomsReport
            // 
            txtB_symptomsReport.BaseColor = Color.White;
            txtB_symptomsReport.BorderColor = Color.FromArgb(200, 200, 200);
            txtB_symptomsReport.FocusBorderColor = Color.FromArgb(100, 100, 100);
            txtB_symptomsReport.Font = new Font("Poppins", 12F);
            txtB_symptomsReport.HoverBorderColor = Color.FromArgb(170, 170, 170);
            txtB_symptomsReport.Location = new Point(37, 373);
            txtB_symptomsReport.Name = "txtB_symptomsReport";
            txtB_symptomsReport.Size = new Size(710, 125);
            txtB_symptomsReport.TabIndex = 76;
            txtB_symptomsReport.TextColor = Color.Black;
            txtB_symptomsReport.TextPadding = new Padding(14, 12, 14, 12);
            // 
            // DoctorViewPastRecords
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1920, 1080);
            Controls.Add(btn_back);
            Controls.Add(lbl_patientData);
            Controls.Add(roundedPanel2);
            Controls.Add(roundedPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "DoctorViewPastRecords";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ViewPastRecords";
            Load += ViewPastRecords_Load;
            roundedPanel1.ResumeLayout(false);
            roundedPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btn_back).EndInit();
            roundedPanel2.ResumeLayout(false);
            roundedPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private CustomControls.RoundedPanel roundedPanel1;
        private Label lbl_heartrate;
        private Label lbl_reason;
        private PictureBox btn_showConfirmPassword;
        private PictureBox btn_showPassword;
        private RoundedTextBox txtB_confirmPassword;
        private RoundedTextBox txtB_password;
        private RoundedTextBox txtB_contactNumber;
        private RoundedComboBox cmbBox_suffix;
        private RoundedTextBox txtB_middleInitial;
        private RoundedButton btn_register;
        private Label label2;
        private RoundedTextBox roundedTextBox13;
        private PictureBox btn_back;
        private Label lbl_patientData;
        private Label label5;
        private Label label7;
        private Label label6;
        private RoundedTextBox txtB_physicalExam;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private CustomControls.RoundedPanel roundedPanel2;
        private RoundedButton btn_finalize;
        private RoundedTextBox txtB_followup;
        private Label label19;
        private Label label12;
        private RoundedTextBox txtB_diagnosis;
        private RoundedTextBox txtB_prescription;
        private RoundedTextBox txtB_treatmentPlan;
        private Label label1;
        private Label lbl_weight;
        private Label lbl_temperature;
        private Label lbl_bloodPressure;
        private Label label3;
        private CheckBox chkBox_others;
        private CheckBox chkBox_ultrasound;
        private RoundedTextBox txtB_otherTest;
        private CheckBox chkBox_xray;
        private CheckBox chkBox_urinalysis;
        private CheckBox chkBox_bloodtest;
        private RoundedMultilineTextBox txtB_symptomsReport;
    }
}