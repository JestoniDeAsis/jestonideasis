using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VitalHealth.Forms.Authentication;

namespace VitalHealth.Forms.Doctor
{
    public partial class DoctorViewPastRecords : Form
    {
        public DoctorViewPastRecords()
        {
            InitializeComponent();
        }

        public int patientID;
        public void set_patientID(int givenID)
        {
            patientID = givenID;
        }

        int currentVitalSignsId;
        private void ViewPastRecords_Load(object sender, EventArgs e)
        {
            var db = new Data.DBConnection();
            using var conn = db.GetConnection();
            conn.Open();

            string query = @"
            SELECT 
            pd.first_name,
            pd.middle_name,
            pd.last_name,
            pd.name_suffix,
            pd.birthdate,
            pd.sex,
            pd.contact_number,

            pvs.blood_pressure,
            pvs.temperature,
            pvs.heart_rate,
            pvs.weight,

            pvs.vital_signs_id,
            pr.reason_for_checkup,

            pr.symptoms_report,
            pr.physical_exam,
            pr.diagnosis,
            pr.treatment_plan,
            pr.prescription,
            pr.follow_up,

            lr.bloodtest,
            lr.urinalysis,
            lr.x_ray,
            lr.ultrasound,
            lr.other_test

            FROM patient_data pd

            LEFT JOIN patient_vital_signs pvs 
                ON pd.patient_id = pvs.patient_id

            LEFT JOIN patient_records pr
                ON pvs.vital_signs_id = pr.vital_signs_id

            LEFT JOIN lab_request lr
                ON pr.record_id = lr.record_id

            WHERE pd.patient_id = @patientID;";

            using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@patientID", patientID);

            using var reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                currentVitalSignsId = Convert.ToInt32(reader["vital_signs_id"]);

                string middle = reader["middle_name"]?.ToString();
                string suffix = reader["name_suffix"]?.ToString();

                string fullName =
                    reader["first_name"] + " " +
                    (string.IsNullOrEmpty(middle) ? "" : middle + " ") +
                    reader["last_name"] +
                    (string.IsNullOrEmpty(suffix) ? "" : " " + suffix);

                DateTime birthdate = Convert.ToDateTime(reader["birthdate"]);
                DateTime today = DateTime.Today;

                int age = today.Year - birthdate.Year;

                if (birthdate > today.AddYears(-age))
                {
                    age--;
                }

                lbl_patientData.Text = fullName;
                lbl_patientData.Text += ", " + age;
                lbl_patientData.Text += ", " + reader["sex"];


                lbl_bloodPressure.Text = ": " + reader["blood_pressure"].ToString();
                lbl_temperature.Text = ": " + reader["temperature"].ToString();
                lbl_heartrate.Text = ": " + reader["heart_rate"].ToString();
                lbl_weight.Text = ": " + reader["weight"].ToString();

                lbl_reason.Text = reader["reason_for_checkup"]?.ToString();


                txtB_symptomsReport.Text = reader["symptoms_report"]?.ToString();
                txtB_physicalExam.Text = reader["physical_exam"]?.ToString();
                txtB_diagnosis.Text = reader["diagnosis"]?.ToString();
                txtB_treatmentPlan.Text = reader["treatment_plan"]?.ToString();
                txtB_prescription.Text = reader["prescription"]?.ToString();
                txtB_followup.Text = reader["follow_up"]?.ToString();

                // Checkboxes (tinyint → bool)
                chkBox_bloodtest.Checked = Convert.ToInt32(reader["bloodtest"] ?? 0) == 1;
                chkBox_urinalysis.Checked = Convert.ToInt32(reader["urinalysis"] ?? 0) == 1;
                chkBox_xray.Checked = Convert.ToInt32(reader["x_ray"] ?? 0) == 1;
                chkBox_ultrasound.Checked = Convert.ToInt32(reader["ultrasound"] ?? 0) == 1;

                // Other test
                txtB_otherTest.Text = reader["other_test"]?.ToString();

                // Optional: show/hide based on value
                chkBox_others.Checked = !string.IsNullOrEmpty(txtB_otherTest.Text);
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            MainForm.Instance.OpenChildForm(new DoctorAssignedPatients());
        }

        private void btn_finalize_Click(object sender, EventArgs e)
        {
            var db = new Data.DBConnection();
            using var conn = db.GetConnection();
            conn.Open();

            int patientId = 0;
            int queueId = 0;
            int recordId = 0;

            // STEP 1: Get patient_id
            string getPatientQuery = @"
    SELECT pvs.patient_id
    FROM patient_records pr
    JOIN patient_vital_signs pvs 
        ON pr.vital_signs_id = pvs.vital_signs_id
    WHERE pr.vital_signs_id = @vitalSignsId
    LIMIT 1";

            using (var cmd = new MySqlCommand(getPatientQuery, conn))
            {
                cmd.Parameters.AddWithValue("@vitalSignsId", currentVitalSignsId);

                var result = cmd.ExecuteScalar();
                if (result != null)
                    patientId = Convert.ToInt32(result);
                else
                {
                    MessageBox.Show("Patient not found.");
                    return;
                }
            }

            // STEP 2: Get queue_id
            string getQueueQuery = @"
            SELECT queue_id
            FROM patient_queue
            WHERE patient_id = @patientId
            ORDER BY queued_at DESC
            LIMIT 1";

            using (var cmd = new MySqlCommand(getQueueQuery, conn))
            {
                cmd.Parameters.AddWithValue("@patientId", patientId);

                var result = cmd.ExecuteScalar();
                if (result != null)
                    queueId = Convert.ToInt32(result);
                else
                {
                    MessageBox.Show("Queue record not found.");
                    return;
                }
            }

            // STEP 3: Update patient_records
            string query1 = @"
            UPDATE patient_records
            SET 
                symptoms_report = @symptoms,
                physical_exam = @physicalExam,
                diagnosis = @diagnosis,
                treatment_plan = @treatmentPlan,
                prescription = @prescription,
                follow_up = @follow_up,
                recorded_at = CURRENT_TIMESTAMP
            WHERE vital_signs_id = @vitalSignsId";

            using (var cmd1 = new MySqlCommand(query1, conn))
            {
                cmd1.Parameters.AddWithValue("@symptoms", txtB_symptomsReport.Text);
                cmd1.Parameters.AddWithValue("@physicalExam", txtB_physicalExam.Text);
                cmd1.Parameters.AddWithValue("@diagnosis", txtB_diagnosis.Text);
                cmd1.Parameters.AddWithValue("@treatmentPlan", txtB_treatmentPlan.Text);
                cmd1.Parameters.AddWithValue("@prescription", txtB_prescription.Text);
                cmd1.Parameters.AddWithValue("@follow_up", txtB_followup.Text);
                cmd1.Parameters.AddWithValue("@vitalSignsId", currentVitalSignsId);

                cmd1.ExecuteNonQuery();
            }

            // STEP 3.1: Get record_id (needed for lab_request)
            string getRecordQuery = @"
            SELECT record_id
            FROM patient_records
            WHERE vital_signs_id = @vitalSignsId
            LIMIT 1";

            using (var cmd = new MySqlCommand(getRecordQuery, conn))
            {
                cmd.Parameters.AddWithValue("@vitalSignsId", currentVitalSignsId);

                var result = cmd.ExecuteScalar();
                if (result != null)
                    recordId = Convert.ToInt32(result);
                else
                {
                    MessageBox.Show("Record not found.");
                    return;
                }
            }

            // STEP 4: Insert lab_request
            string query3 = @"
            UPDATE lab_request
            SET
                bloodtest = @bloodtest,
                urinalysis = @urinalysis,
                x_ray = @xray,
                ultrasound = @ultrasound,
                other_test = @otherTest
            WHERE record_id = @recordId";

            using (var cmd3 = new MySqlCommand(query3, conn))
            {
                cmd3.Parameters.AddWithValue("@recordId", recordId);
                cmd3.Parameters.AddWithValue("@bloodtest", chkBox_bloodtest.Checked ? 1 : 0);
                cmd3.Parameters.AddWithValue("@urinalysis", chkBox_urinalysis.Checked ? 1 : 0);
                cmd3.Parameters.AddWithValue("@xray", chkBox_xray.Checked ? 1 : 0);
                cmd3.Parameters.AddWithValue("@ultrasound", chkBox_ultrasound.Checked ? 1 : 0);

                string otherTest = chkBox_others.Checked ? txtB_otherTest.Text : null;
                cmd3.Parameters.AddWithValue("@otherTest", otherTest);

                cmd3.ExecuteNonQuery();
            }

            // STEP 5: Update patient_queue status
            string query2 = @"
            UPDATE patient_queue
            SET queue_status_id = 4
            WHERE queue_id = @queueId";

            using (var cmd2 = new MySqlCommand(query2, conn))
            {
                cmd2.Parameters.AddWithValue("@queueId", queueId);
                cmd2.ExecuteNonQuery();
            }

            MessageBox.Show("Record finalized, lab request saved, and queue updated.");

            MainForm.Instance.OpenChildForm(new DoctorAssignedPatients());
        }

        private void chkBox_others_CheckStateChanged(object sender, EventArgs e)
        {
            if (chkBox_others.Checked)
            {
                txtB_otherTest.Enabled = true;
            }
            else
            {
                txtB_otherTest.Text = "";
                txtB_otherTest.Enabled = false;
            }
        }
    }
}
