using View.Controls;

namespace View
{
    public partial class MainForm : Form
    {
        private readonly RegisterView registerView = new RegisterView();
        private readonly LoginView loginView = new LoginView();
        private readonly StrengthView strengthView = new StrengthView();
        private readonly PerfView perfView = new PerfView();

        public MainForm()
        {
            InitializeComponent();

            ShowView(registerView);
        }

        private void ShowView(UserControl view)
        {
            panelContent.Controls.Clear();
            view.Dock = DockStyle.Fill;
            panelContent.Controls.Add(view);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            ShowView(registerView);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            ShowView(loginView);
        }

        private void btnStrength_Click(object sender, EventArgs e)
        {
            ShowView(strengthView);
        }

        private void btnPerf_Click(object sender, EventArgs e)
        {
            ShowView(perfView);
        }
    }
}
