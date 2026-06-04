using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VitalHealth.Forms.Nurse
{
    public partial class DoctorConsult : Form
    {
        public DoctorConsult()
        {
            InitializeComponent();
        }
        private void DoctorConsult_Load(object sender, EventArgs e)
        {

        }

        private void backPatientHistory_Click(object sender, EventArgs e)
        {
            MainForm.Instance.OpenChildForm(new NursePatientPastRecords());
        }
    }
}
