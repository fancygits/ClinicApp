using ClinicApp.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicApp.View
{
    public partial class LoginForm : Form
    {
        private static LoginForm instance = null;
        private CredentialController credentialController;
        private LoginForm()
        {
            InitializeComponent();
            this.credentialController = new CredentialController();
        }

        public static LoginForm Instance()
        {
            if (instance == null)
            {
                instance = new LoginForm();
            }
            return instance;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (passwordTextBox.Text == this.credentialController.GetPassword(this.userNameTextBox.Text)) {
                if (this.credentialController.GetRole(this.userNameTextBox.Text) == "nurse")
                {
                    NurseDashboard.Instance().Show();
                    NurseDashboard.Instance().lblUserName.Text = this.userNameTextBox.Text;
                    NurseDashboard.Instance().lblRoll.Text = this.credentialController.GetRole(this.userNameTextBox.Text);
                    LoginForm.Instance().Hide();

                } else if (this.credentialController.GetRole(this.userNameTextBox.Text) == "administrator")
                {
                    accessLabel.Text = "Access Granted For Admin: " + this.userNameTextBox.Text + " as an " + this.credentialController.GetRole(this.userNameTextBox.Text);
                }
                
            } else
            {
                accessLabel.ForeColor = Color.Red;
                accessLabel.Text = "Incorrect username/password";
            }
        }

        public static void ClearFields()
        {
            LoginForm.Instance().userNameTextBox.Text = "";
            LoginForm.Instance().passwordTextBox.Text = "";
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            accessLabel.Text = "";
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
