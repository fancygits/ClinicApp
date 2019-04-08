using ClinicApp.Controller;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ClinicApp.View
{
    /// <summary>
    /// This is the login form. It will allow the user to login and either direct them to the NurseDashboard or the AdminDashboard
    /// </summary>
    public partial class LoginForm : Form
    {
        private static LoginForm instance = null;
        private CredentialController credentialController;
        private LoginForm()
        {
            InitializeComponent();
            this.credentialController = new CredentialController();
        }

        /// <summary>
        /// This is the singleton method. If there is not a current instance of the LoginForm it will create one. 
        /// </summary>
        /// <returns>And instance of the LoginForm</returns>
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
            if (Security.Hash(passwordTextBox.Text).Equals(this.credentialController.GetPassword(this.userNameTextBox.Text))) {
                if (this.credentialController.GetRole(this.userNameTextBox.Text) == "nurse")
                {
                    NurseDashboard.Instance().Show();
                    NurseDashboard.Instance().lblUsername.Text = this.userNameTextBox.Text;
                    NurseDashboard.Instance().lblRole.Text = "Nurse";
                    LoginForm.Instance().Hide();

                } else if (this.credentialController.GetRole(this.userNameTextBox.Text) == "administrator")
                {
                    AdministratorDashboard.Instance().Show();
                    AdministratorDashboard.Instance().lblUsername.Text = this.userNameTextBox.Text;
                    AdministratorDashboard.Instance().lblRole.Text = "Administrator";
                    LoginForm.Instance().Hide();
                }
                
            } else
            {
                accessLabel.ForeColor = Color.Red;
                accessLabel.Text = this.credentialController.GetPassword(this.userNameTextBox.Text) + "Incorrect username/password";
            }
        }

        /// <summary>
        /// This will clear the fields of the login form for when a user logs out. 
        /// </summary>
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

        /// <summary>
        /// Used so users can press the Enter key in the name and birthdate textboxes to GetPatient
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Enter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                loginButton.PerformClick();
            }
        }
    }
}
