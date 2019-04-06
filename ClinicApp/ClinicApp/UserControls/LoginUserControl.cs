using ClinicApp.View;
using System.Windows.Forms;

namespace ClinicApp.UserControls
{
    public partial class LoginUserControl : UserControl
    {
        public LoginUserControl()
        {
            InitializeComponent();
        }


        private void lnkLblLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //NurseDashboard dashboard = Parent as NurseDashboard;
            NurseDashboard.Instance().Hide();
            LoginForm.Instance().Show();
            LoginForm.ClearFields();
        }

    }
}
