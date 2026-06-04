using System.Security.Cryptography;
using System.Text;

namespace VitalHealth
{
    public partial class MainForm : Form
    {
        public static int loggedInUserID = 0;
        public static string loggedInUserLastname = "";
        public static string userRole = "";
        public static MainForm Instance { get; private set; }
        public MainForm()
        {
            InitializeComponent();
            Instance = this; // store the running instance globally
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private Form? activeForm;

        public void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
                panelContainer.Controls.Remove(activeForm);
            }

            activeForm = childForm;

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            panelContainer.Controls.Add(childForm);
            panelContainer.Tag = childForm;

            childForm.Show();
            childForm.BringToFront();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            OpenChildForm(new IndexForm());
        }


        public static string HashString(string input)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(input);
                byte[] hashBytes = sha256.ComputeHash(bytes);

                StringBuilder builder = new StringBuilder();
                foreach (byte b in hashBytes)
                {
                    builder.Append(b.ToString("x2")); // convert to hex
                }

                return builder.ToString();
            }
        }
    }
}
