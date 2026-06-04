using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VitalHealth.CustomControls;
using VitalHealth.Forms.Authentication;
using VitalHealth.Forms.Dialogs;

namespace VitalHealth.Forms.Nurse
{
    public partial class TodaysPatients : Form
    {
        public TodaysPatients()
        {
            InitializeComponent();

        }

        private void TodaysPatients_Load(object sender, EventArgs e)
        {
            lbl_nurseLastName.Text = MainForm.loggedInUserLastname;
        }

        private void roundedDataGridView_Load(object sender, EventArgs e)
        {
            roundedDataGridView1.Grid.Columns.Add("QueueNumber", "Queue Number");
            roundedDataGridView1.Grid.Columns.Add("PatientName", "Patient Name");
            roundedDataGridView1.Grid.Columns.Add("Date", "Date");
            roundedDataGridView1.Grid.Columns.Add("ArrivalTime", "Arrival Time");
            roundedDataGridView1.Grid.Columns.Add("AssignedDoctor", "Assigned Doctor");
            roundedDataGridView1.Grid.Columns.Add("Specialty", "Specialty");
            roundedDataGridView1.Grid.Columns.Add("RoomNumber", "Room Number");
            roundedDataGridView1.Grid.Columns.Add("Status", "Status");

            // Add rows
            roundedDataGridView1.Grid.Rows.Add("GC-001", "Marianne Claire A.", "2026-03-16", "09:05 AM", "Dr. Carlos Sant.", "General Co.", "1", "Waiting");
            roundedDataGridView1.Grid.Rows.Add("OBG-001", "Angela Bautista", "2026-03-16", "09:45 AM", "Dr. Carlos Sant.", "OB-Gyne", "3", "Waiting");
            roundedDataGridView1.Grid.Rows.Add("PD-001", "Nathan Villanueva", "2026-03-16", "10:15 AM", "Dr. Samantha C.", "Pediatrics", "2", "Waiting");
        }

        private void btn_checkupForm_Click(object sender, EventArgs e)
        {
            MainForm.Instance.OpenChildForm(new PatientsCheckUpForm());
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            ConfirmActionDialog dialog = new ConfirmActionDialog();
            dialog.setResult("Are you sure you want to Logout?");
            DialogResult result = dialog.ShowDialog(this);

            if (result == DialogResult.OK)
            {
                MainForm.Instance.OpenChildForm(new LoginForm());
            }
        }

        private void btn_missedCheckups_Click(object sender, EventArgs e)
        {
            MainForm.Instance.OpenChildForm(new MissedCheckups());
        }

        private void btn_pastRecords_Click(object sender, EventArgs e)
        {
            MainForm.Instance.OpenChildForm(new NursePatientPastRecords());
        }

        private void btn_schedAndFee_Click(object sender, EventArgs e)
        {
            MainForm.Instance.OpenChildForm(new SchedAndFee());
        }

        private void btn_editProfile_Click(object sender, EventArgs e)
        {
            MainForm.Instance.OpenChildForm(new EditNurseProfile());
        }
    }
}
