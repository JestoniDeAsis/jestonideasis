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
using VitalHealth.Forms.Dialogs;

namespace VitalHealth.Forms.Admin
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            lbl_adminLastName.Text = MainForm.loggedInUserLastname;
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

        private void btnManageStaff_Click(object sender, EventArgs e)
        {
            MainForm.Instance.OpenChildForm(new ManageStaff());
        }

        private void btnPatientsRec_Click(object sender, EventArgs e)
        {
            MainForm.Instance.OpenChildForm(new ViewPreviousRecords());
        }

        private void btnSchedNFee_Click(object sender, EventArgs e)
        {
            MainForm.Instance.OpenChildForm(new DocSched());
        }
    }
}
