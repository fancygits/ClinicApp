using ClinicApp.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicApp
{
    public partial class NurseDashboard : Form
    {
        private static NurseDashboard instance = null;
        private NurseDashboard()
        {
            InitializeComponent();
        }

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
