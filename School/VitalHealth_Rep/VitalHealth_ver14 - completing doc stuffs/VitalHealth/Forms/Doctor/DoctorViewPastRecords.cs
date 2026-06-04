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

        public bool viewOnly = false;
        private int recordID;
        public void set_recordID(int id)
        {
            recordID = id;
        }

        bool has_labRecords = false;
        int currentVitalSignsId;
        private void ViewPastRecords_Load(object sender, EventArgs e)
        {
            if (viewOnly)
            {
                btn_finalize.Visible = false;
                txtB_symptomsReport.ReadOnly = true;
                txtB_physicalExam.ReadOnly = true;
                txtB_diagnosis.ReadOnly = true;
                txtB_treatmentPlan.ReadOnly = true;
                txtB_prescription.ReadOnly = true;
                txtB_otherTest.ReadOnly = true;
                txtB_followup.ReadOnly = true;
            }

            var db = new Data.DBConnection();
            using var conn = db.GetConnection();
            conn.Open();

            string query = @"
            SELECT 
                pd.patient_id,
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

                pr.record_id,
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

            FROM patient_records pr

            INNER JOIN patient_vital_signs pvs 
                ON pr.vital_signs_id = pvs.vital_signs_id

            INNER JOIN patient_data pd
                ON pvs.patient_id = pd.patient_id

            LEFT JOIN lab_request lr
                ON pr.record_id = lr.record_id

            WHERE pr.record_id = @recordID
            LIMIT 1;
            ";

            using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@recordID", recordID);

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

                // Detect if lab_request exists
                has_labRecords = reader["bloodtest"] != DBNull.Value;

                if (has_labRecords)
                {
                    chkBox_bloodtest.Checked = Convert.ToInt32(reader["bloodtest"]) == 1;
                    chkBox_urinalysis.Checked = Convert.ToInt32(reader["urinalysis"]) == 1;
                    chkBox_xray.Checked = Convert.ToInt32(reader["x_ray"]) == 1;
                    chkBox_ultrasound.Checked = Convert.ToInt32(reader["ultrasound"]) == 1;

                    txtB_otherTest.Text = reader["other_test"]?.ToString();
                    chkBox_others.Checked = !string.IsNullOrEmpty(txtB_otherTest.Text);
                }
                else
                {
                    chkBox_bloodtest.Checked = false;
                    chkBox_urinalysis.Checked = false;
                    chkBox_xray.Checked = false;
                    chkBox_ultrasound.Checked = false;

                    txtB_otherTest.Text = "";
                    chkBox_others.Checked = false;
                }
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            if (viewOnly) 
                MainForm.Instance.OpenChildForm(new DoctorPatientPastRecord());
            else
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
            string updateRecordQuery = @"
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

            using (var cmd = new MySqlCommand(updateRecordQuery, conn))
            {
                cmd.Parameters.AddWithValue("@symptoms", txtB_symptomsReport.Text);
                cmd.Parameters.AddWithValue("@physicalExam", txtB_physicalExam.Text);
                cmd.Parameters.AddWithValue("@diagnosis", txtB_diagnosis.Text);
                cmd.Parameters.AddWithValue("@treatmentPlan", txtB_treatmentPlan.Text);
                cmd.Parameters.AddWithValue("@prescription", txtB_prescription.Text);
                cmd.Parameters.AddWithValue("@follow_up", txtB_followup.Text);
                cmd.Parameters.AddWithValue("@vitalSignsId", currentVitalSignsId);

                cmd.ExecuteNonQuery();
            }

            // STEP 3.1: Get record_id
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

            // STEP 4: INSERT or UPDATE lab_request
            string labQuery;

            if (has_labRecords)
            {
                // UPDATE
                labQuery = @"
                UPDATE lab_request
                SET
                    bloodtest = @bloodtest,
                    urinalysis = @urinalysis,
                    x_ray = @xray,
                    ultrasound = @ultrasound,
                    other_test = @otherTest
                WHERE record_id = @recordId";
            }
            else
            {
                // INSERT
                labQuery = @"
                INSERT INTO lab_request
                (record_id, bloodtest, urinalysis, x_ray, ultrasound, other_test)
                VALUES
                (@recordId, @bloodtest, @urinalysis, @xray, @ultrasound, @otherTest)";
            }

            using (var cmd = new MySqlCommand(labQuery, conn))
            {
                cmd.Parameters.AddWithValue("@recordId", recordId);
                cmd.Parameters.AddWithValue("@bloodtest", chkBox_bloodtest.Checked ? 1 : 0);
                cmd.Parameters.AddWithValue("@urinalysis", chkBox_urinalysis.Checked ? 1 : 0);
                cmd.Parameters.AddWithValue("@xray", chkBox_xray.Checked ? 1 : 0);
                cmd.Parameters.AddWithValue("@ultrasound", chkBox_ultrasound.Checked ? 1 : 0);

                string otherTest = chkBox_others.Checked ? txtB_otherTest.Text : "";
                cmd.Parameters.AddWithValue("@otherTest", otherTest);

                cmd.ExecuteNonQuery();
            }

            // STEP 5: Update queue status
            string updateQueueQuery = @"
            UPDATE patient_queue
            SET queue_status_id = 4
            WHERE queue_id = @queueId";

            using (var cmd = new MySqlCommand(updateQueueQuery, conn))
            {
                cmd.Parameters.AddWithValue("@queueId", queueId);
                cmd.ExecuteNonQuery();
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
