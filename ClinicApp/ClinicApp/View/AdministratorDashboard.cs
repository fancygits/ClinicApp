using System.Windows.Forms;

namespace ClinicApp.View
{
    public partial class AdministratorDashboard : Form
    {
        private static AdministratorDashboard instance = null;
        public AdministratorDashboard()
        {
            InitializeComponent();
        }

        public static AdministratorDashboard Instance()
        {
            if (instance == null)
            {
                instance = new AdministratorDashboard();
            }
            return instance;
        }

        private void AdministratorDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void logoutLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AdministratorDashboard.Instance().Hide();
            LoginForm.Instance().Show();
            LoginForm.ClearFields();
        }
    }
}
