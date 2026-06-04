using VitalHealth.Forms.Authentication;

namespace VitalHealth
{
    public partial class IndexForm : Form
    {
        public IndexForm()
        {
            InitializeComponent();
        }

        private void btn_exitApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_goToLogin_Click(object sender, EventArgs e)
        {
            MainForm.Instance.OpenChildForm(new LoginForm());
        }
    }
}
