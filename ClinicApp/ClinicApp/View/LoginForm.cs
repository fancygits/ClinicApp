﻿using ClinicApp.Controller;
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
        private CredentialController credentialController;
        public LoginForm()
        {
            InitializeComponent();
            this.credentialController = new CredentialController();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (passwordTextBox.Text == this.credentialController.GetPassword(this.userNameTextBox.Text)) {
                if (this.credentialController.GetRole(this.userNameTextBox.Text) == "nurse")
                {
                    NurseDashboard nurseDashboard = new NurseDashboard();
                    nurseDashboard.Show();
                    nurseDashboard.lblUserName.Text = this.userNameTextBox.Text;
                    nurseDashboard.lblRoll.Text = this.credentialController.GetRole(this.userNameTextBox.Text);
                    this.Hide();

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

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            accessLabel.Text = "";
        }
    }
}
