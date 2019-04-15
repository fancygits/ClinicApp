﻿using ClinicApp.Model;
using System;
using System.Windows.Forms;

namespace ClinicApp.UserControls
{
    public partial class PersonSearchUserControl : UserControl, IUserControlSearch
    {
        public Nurse nurse;
        public Patient patient;
        private string personType;
        public event EventHandler GetPersonButtonClicked;
        public event EventHandler ClearButtonClicked;
        public event EventHandler AddPersonClicked;
        public PersonSearchUserControl(Person person) : this()
        {
            SetPersonType(person);
        }

        public PersonSearchUserControl()
        {
            InitializeComponent();
            ClearFields();
        }

        protected virtual void OnGetPersonButtonClicked(EventArgs e)
        {
            GetPersonButtonClicked?.Invoke(this, e);
        }

        protected virtual void OnClearButtonClicked(EventArgs e)
        {
            ClearButtonClicked?.Invoke(this, e);
        }

        protected virtual void OnAddPersonClicked(EventArgs e)
        {
            AddPersonClicked?.Invoke(this, e);
        }

        private void PersonSearchUserControl_Enter(object sender, EventArgs e)
        {
            firstNameTextBox.Focus();
        }

        public void SetPersonType(Person person)
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
            btnGetPerson.Text = "Get " + personType;
        }

        /// <summary>
        /// Gets a patient from the given textboxes.
        /// If no patient is found, returns a list of possible matches.
        /// If no matches are found, prompts to add a new Patient.
        /// </summary>
        private void GetPatient(string firstName, string lastName, string birthDate)
        {
            personBindingSource.Clear();
            patient = this.FindPatient(firstName, lastName, birthDate);
            if (patient == null)
            {
                NoMatchesDialog(null, null);
            }
            else
            {
                personBindingSource.Add(patient);
            }
        }

        /// <summary>
        /// Gets a nurse from the given textboxes.
        /// If no nurse is found, returns a list of possible matches.
        /// If no matches are found, prompts to add a new Nurse.
        /// </summary>
        private void GetNurse(string firstName, string lastName, string birthDate)
        {
            personBindingSource.Clear();
            nurse = this.FindNurse(firstName, lastName, birthDate);
            personBindingSource.Add(nurse);
        }

        /// <summary>
        /// Refreshes the Person object
        /// </summary>
        public void RefreshPerson()
        {
            if (patient != null)
            {
                patient = this.GetPatientByID(patient.PatientID);
            }
            else if (nurse != null)
            {
                nurse = this.GetNurseByID(nurse.NurseID);
            }
        }

        /// <summary>
        /// Prompts to add a new person since none are found
        /// </summary>
        public void NoMatchesDialog(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("No " + personType + "s matched your search.\n" +
                            "Would you like to add a new " + personType + "? ", "No Matches",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                //patient = new Patient();
                OnAddPersonClicked(e);
            }
        }

        private void ClearFields()
        {
            patient = null;
            personBindingSource.Clear();
            firstNameTextBox.Clear();
            lastNameTextBox.Clear();
            birthDateDateTimePicker.Value = DateTime.Today;
            btnGetPerson.Enabled = false;
            btnClear.Enabled = false;
            firstNameTextBox.Focus();
        }

        private void GetPersonButton_Click(object sender, EventArgs e)
        {
            string firstName = firstNameTextBox.Text;
            string lastName = lastNameTextBox.Text;
            string birthDate = birthDateDateTimePicker.Value.ToShortDateString();
            switch (personType)
            {
                case "Patient":
                    GetPatient(firstName, lastName, birthDate);
                    break;
                case "Nurse":
                    GetNurse(firstName, lastName, birthDate);
                    break;
                case "Doctor":

                    break;
                case "Administrator":

                    break;
            }
            OnGetPersonButtonClicked(e);
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
                btnGetPerson.PerformClick();
            }
        }
        
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
            OnClearButtonClicked(e);
        }

        private void textChanged(object sender, EventArgs e)
        {
            btnGetPerson.Enabled = true;
            btnClear.Enabled = true;
        }

    }
}
