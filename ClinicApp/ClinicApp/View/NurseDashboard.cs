﻿using ClinicApp.View;
using System.Drawing;
using System.Windows.Forms;

namespace ClinicApp
{
    public partial class NurseDashboard : Form
    {
        private static NurseDashboard instance = null;
        //public TabControl patientTabControl;
        private NurseDashboard()
        {
            InitializeComponent();
            this.searchForVisitUserControl1.personSearchUserControl.AddPersonClicked += patientsTabControl_AddPatientClicked;
            this.addAppointmentUserControl1.personSearchUserControl.AddPersonClicked += patientsTabControl_AddPatientClicked;
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

        private void DrawLines(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Gray, 3);
            Point start1 = new Point(lblRole.Location.X, lblRole.Location.Y + 10);
            Point end1 = new Point(lblRole.Location.X, lblRole.Location.Y + 30);
            Point start2 = new Point(logoutLinkLabel.Location.X, logoutLinkLabel.Location.Y + 10);
            Point end2 = new Point(logoutLinkLabel.Location.X, logoutLinkLabel.Location.Y + 30);
            e.Graphics.DrawLine(pen, start1, end1);
            e.Graphics.DrawLine(pen, start2, end2);
        }

        /// <summary>
        /// Switches to the Patient Information Tab and prepares to add a new patient
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void patientsTabControl_AddPatientClicked(object sender, System.EventArgs e)
        {
            patientsTabControl.SelectTab("infoTabPage");
            this.patientInformationUserControl1.GetPatient();
            this.patientInformationUserControl1.ClearFields();
            this.patientInformationUserControl1.firstNameTextBox.Focus();
        }
    }
}
