using ClinicApp.Controller;
using ClinicApp.Model;
using System;
using System.Windows.Forms;

namespace ClinicApp.UserControls
{
    public partial class PersonSearchUserControl : UserControl, IUserControlSearch
    {
        public Person person;
        public Patient patient;
        private string personType;
        private PatientController patientController;
        private NurseController nurseController;
        private DoctorController doctorController;
        public PersonSearchUserControl(Person newPerson)
        {
            InitializeComponent();
            person = newPerson;
            SetPersonType();
            btnGetPerson.Text = "Get " + personType;
            btnClear.PerformClick();
        }


        private void SetPersonType()
        {
            switch (person.GetType().ToString())
            {
                case "ClinicApp.Model.Patient":
                    personType = "Patient";
                    patientController = new PatientController();
                    break;
                case "ClinicApp.Model.Nurse":
                    personType = "Nurse";
                    nurseController = new NurseController();
                    break;
                case "ClinicApp.Model.Doctor":
                    personType = "Doctor";
                    doctorController = new DoctorController();
                    break;
                case "ClinicApp.Model.Administrator":
                    personType = "Administrator";
                    break;
            }
        }

        /// <summary>
        /// Gets a patient from the given textboxes.
        /// If no patient is found, returns a list of possible matches.
        /// If no matches are found, prompts to add a new Patient.
        /// </summary>
        private void GetPatient()
        {
            string firstName = firstNameTextBox.Text;
            string lastName = lastNameTextBox.Text;
            string birthDate = birthDateDateTimePicker.Value.ToShortDateString();
            patient = this.FindPatient(firstName, lastName, birthDate);
            PatientInformationUserControl control = Parent as PatientInformationUserControl;
            control.patient = patient;
            control.GetPatient();
        }

        private void ClearFields()
        {
            patient = null;
            firstNameTextBox.Clear();
            lastNameTextBox.Clear();
            birthDateDateTimePicker.Value = DateTime.Today;
            btnGetPerson.Enabled = false;
            btnClear.Enabled = false;
            firstNameTextBox.Focus();
        }



        private void btnGetPerson_Click(object sender, System.EventArgs e)
        {
            switch (personType)
            {
                case "Patient":
                    GetPatient();
                    break;
                case "Nurse":

                    break;
                case "Doctor":

                    break;
                case "Administrator":

                    break;
            }
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
        }

        private void textChanged(object sender, EventArgs e)
        {
            btnGetPerson.Enabled = true;
            btnClear.Enabled = true;
        }
    }
}
