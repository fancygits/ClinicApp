using ClinicApp.Model;
using System;
using System.Windows.Forms;

namespace ClinicApp.UserControls
{
    /// <summary>
    /// Defines the PersonSearch User Control. To search for Nurses, Patients, and others.
    /// </summary>
    public partial class PersonSearchUserControl : UserControl, IUserControlSearch
    {
        public Nurse nurse;
        public Patient patient;
        private string personType;
        public event EventHandler GetPersonButtonClicked;
        public event EventHandler ClearButtonClicked;
        public event EventHandler AddPersonClicked;

        /// <summary>
        /// Constructs a PersonSearchUC and sets the personType.
        /// </summary>
        /// <param name="person"></param>
        public PersonSearchUserControl(Person person) : this()
        {
            SetPersonType(person);
        }

        /// <summary>
        /// Constructs a PersonSearchUC. personType must be set before working.
        /// </summary>
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

        /// <summary>
        /// Sets the PersonType of the UserControl
        /// </summary>
        /// <param name="person"></param>
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
            if (nurse == null)
            {
                NoMatchesDialog(null, null);
            }
            else
            {
                personBindingSource.Add(nurse);
            }
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
                CreateNewPerson();
                OnAddPersonClicked(e);
            }
        }

        private void CreateNewPerson()
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
        }

        private void ClearFields()
        {
            patient = null;
            personBindingSource.Clear();
            firstNameTextBox.Clear();
            lastNameTextBox.Clear();
            birthDateDateTimePicker.Value = DateTime.Today;
            btnGetPerson.Enabled = false;
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
                    if (patient != null)
                    {
                        OnGetPersonButtonClicked(e);
                    }
                    break;
                case "Nurse":
                    GetNurse(firstName, lastName, birthDate);
                    if (nurse != null)
                    {
                        OnGetPersonButtonClicked(e);
                    }
                    break;
                case "Doctor":

                    break;
                case "Administrator":

                    break;
            }
            //OnGetPersonButtonClicked(e);
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
        }

    }
}
