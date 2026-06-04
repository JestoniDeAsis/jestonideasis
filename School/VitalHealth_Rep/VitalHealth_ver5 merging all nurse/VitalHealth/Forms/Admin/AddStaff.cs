using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VitalHealth.Forms.Authentication;

namespace VitalHealth.Forms.Admin
{
    public partial class AddStaff : Form
    {
        public AddStaff()
        {
            InitializeComponent();
        }

        private void AddStaff_Load(object sender, EventArgs e)
        {
            lbl_adminLastName.Text = MainForm.loggedInUserLastname;
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            MainForm.Instance.OpenChildForm(new LoginForm());
        }

        private void btnSalesDashboard_Click(object sender, EventArgs e)
        {
            MainForm.Instance.OpenChildForm(new AdminDashboard());
        }

        private void btnManageStaff_Click(object sender, EventArgs e)
        {
            MainForm.Instance.OpenChildForm(new ManageStaff());
        }

        private void btnPatientsRec_Click(object sender, EventArgs e)
        {
            MainForm.Instance.OpenChildForm(new());
        }

        private void btnPatientsRec_Click_1(object sender, EventArgs e)
        {
            MainForm.Instance.OpenChildForm(new ViewPreviousRecords());
        }

        private void btnSchedNFee_Click(object sender, EventArgs e)
        {
            MainForm.Instance.OpenChildForm(new DocSched());
        }
    }
}
