using ClinicApp.View;
using System.Windows.Forms;

namespace ClinicApp
{

    /// <summary>
    /// Main Form for the Nurse interface
    /// </summary>
    public partial class NurseDashboard : Form
    {
        private static NurseDashboard instance = null;
        public TabControl patientTabControl;
        private NurseDashboard()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This is the singleton method. If there is not a current instance of the NurseDashboard it will create one. 
        /// </summary>
        /// <returns>And instance of the NurseDashboard</returns>
        public static NurseDashboard Instance()
        {
            if (instance == null)
            {
                instance = new NurseDashboard();
            }
            return instance;
        }

        private void NurseDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void lnkLblLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NurseDashboard.Instance().Hide();
            LoginForm.Instance().Show();
            LoginForm.ClearFields();
        }
    }
}
