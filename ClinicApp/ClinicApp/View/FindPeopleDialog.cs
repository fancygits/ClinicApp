using ClinicApp.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ClinicApp.View
{
    public partial class FindPeopleDialog : Form
    {
        public Nurse nurse;
        public List<Nurse> nurseList;
        public Patient patient;
        public List<Patient> patientList;
        private string personType;
        public FindPeopleDialog(Person person)
        {
            InitializeComponent();
            SetPersonType(person);
            btnSelectPerson.Text = "Get " + personType;
            btnAddPerson.Text = "Add New " + personType;
            Text = personType + " Matches";
            this.Update();
        }

        private void FindPeopleDialog_Load(object sender, EventArgs e)
        {
            switch (personType)
            {
                case "Patient":
                    personDataGridView.DataSource = patientList;
                    break;
                case "Nurse":
                    personDataGridView.DataSource = nurseList;
                    break;
                case "Doctor":
                    break;
                case "Administrator":
                    break;
            }
        }

        private void SetPersonType(Person person)
        {
            switch (person.GetType().ToString())
            {
                case "ClinicApp.Model.Patient":
                    personType = "Patient";
                    break;
                case "ClinicApp.Model.Nurse":
                    personType = "Nurse";
                    break;
                case "ClinicApp.Model.Doctor":
                    personType = "Doctor";
                    break;
                case "ClinicApp.Model.Administrator":
                    personType = "Administrator";
                    break;
            }
        }

        private void SelectPerson()
        {
            switch (personType)
            {
                case "Patient":
                    patient = personDataGridView.SelectedRows[0].DataBoundItem as Patient;
                    break;
                case "Nurse":
                    nurse = personDataGridView.SelectedRows[0].DataBoundItem as Nurse;
                    break;
                case "Doctor":
                    break;
                case "Administrator":
                    break;
            }            
            this.DialogResult = DialogResult.OK;
        }

        private void personDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectPerson();
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            switch (personType)
            {
                case "Patient":
                    patient = new Patient();
                    break;
                case "Nurse":
                    nurse = new Nurse();
                    break;
                case "Doctor":
                    break;
                case "Administrator":
                    break;
            }
            this.DialogResult = DialogResult.OK;
        }

        private void btnSelectPerson_Click(object sender, EventArgs e)
        {
            SelectPerson();
        }
    }
}
