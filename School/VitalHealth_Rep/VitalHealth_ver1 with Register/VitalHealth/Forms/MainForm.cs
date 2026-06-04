namespace VitalHealth
{
    public partial class MainForm : Form
    {
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
    }
}
