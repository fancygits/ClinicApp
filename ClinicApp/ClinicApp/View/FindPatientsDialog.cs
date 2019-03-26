﻿using ClinicApp.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ClinicApp.View
{
    public partial class FindPatientsDialog : Form
    {
        public FindPatientsDialog()
        {
            InitializeComponent();
        }

        public Patient patient;
        public List<Patient> patientList;

        private void FindPatientsDialog_Load(object sender, EventArgs e)
        {
            patientDataGridView.DataSource = patientList;
        }

        private void SelectPatient(object sender, EventArgs e)
        {
            patient = patientDataGridView.SelectedRows[0].DataBoundItem as Patient;
            this.DialogResult = DialogResult.OK;
        }

        private void patientDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            patient = patientDataGridView.SelectedRows[0].DataBoundItem as Patient;
            this.DialogResult = DialogResult.OK;
        }
    }
}
