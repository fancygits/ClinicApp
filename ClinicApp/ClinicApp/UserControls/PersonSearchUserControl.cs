using ClinicApp.Controller;
using ClinicApp.Model;
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
    }
}
