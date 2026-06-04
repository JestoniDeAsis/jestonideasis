using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VitalHealth.Forms.Nurse
{
    public partial class ViewingPatientsRecord : Form
    {
        public ViewingPatientsRecord()
        {
            InitializeComponent();
        }
        private void ViewingPatientsRecord_Load(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            MainForm.Instance.OpenChildForm(new NursePatientPastRecords());
        }
    }
}
