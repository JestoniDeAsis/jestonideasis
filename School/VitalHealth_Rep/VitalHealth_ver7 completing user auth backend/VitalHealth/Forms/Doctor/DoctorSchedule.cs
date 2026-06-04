using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VitalHealth.Forms.Authentication;
using VitalHealth.Forms.Dialogs;

namespace VitalHealth.Forms.Doctor
{
    public partial class DoctorSchedule : Form
    {
        public DoctorSchedule()
        {
            InitializeComponent();
        }

        private void DoctorSchedule_Load(object sender, EventArgs e)
        {
            lbl_doctorLastName.Text = MainForm.loggedInUserLastname;
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

        private void btn_assignedPatients_Click(object sender, EventArgs e)
        {
            MainForm.Instance.OpenChildForm(new DoctorAssignedPatients());
        }

        private void btn_patientRecord_Click(object sender, EventArgs e)
        {
            MainForm.Instance.OpenChildForm(new DoctorPatientPastRecord());
        }

        private void btn_editProfile_Click(object sender, EventArgs e)
        {
            MainForm.Instance.OpenChildForm(new DoctorEditProfile());
        }
    }
}
