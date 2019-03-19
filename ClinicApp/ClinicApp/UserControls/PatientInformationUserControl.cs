using ClinicApp.Controller;
using ClinicApp.Model;
using System;
using System.Windows.Forms;

namespace ClinicApp.UserControls
{
    public partial class PatientInformationUserControl : UserControl
    {
        private readonly PatientController patientController;
        private Patient patient;
        private Patient newPatient;

        public PatientInformationUserControl()
        {
            InitializeComponent();
            this.patientController = new PatientController();
        }

        private void PatientInformationUserControl_Load(object sender, System.EventArgs e)
        {
            patientBindingSource.Clear();
            newPatient = new Patient();
        }

        private void GetPatient(object sender, EventArgs e)
        {
            int patientID = Convert.ToInt32(patientIDNumericUpDown.Value);
            try
            {
                patient = this.patientController.GetPatient(patientID);
                this.PutNewPatient();
                patientBindingSource.Clear();
                patientBindingSource.Add(newPatient);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void btnUpdatePatient_Click(object sender, EventArgs e)
        {
            if (this.patientController.UpdatePatient(patient, newPatient))
            {
                lblMessage.Text = "Patient has been updated successfully.";
            }
            try
            {
                    
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something is wrong with the input!! \n" + ex.Message,
                                    "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.GetPatient(null, null);
            }
        }

        private void PutNewPatient()
        {
            newPatient.PatientID = patient.PatientID;
            newPatient.PersonID = patient.PersonID;
            newPatient.LastName = patient.LastName;
            newPatient.FirstName = patient.FirstName;
            newPatient.BirthDate = patient.BirthDate;
            newPatient.SSN = patient.SSN;
            newPatient.Gender = patient.Gender;
            newPatient.StreetAddress = patient.StreetAddress;
            newPatient.City = patient.City;
            newPatient.State = patient.State;
            newPatient.PostCode = patient.PostCode;
            newPatient.PhoneNumber = patient.PhoneNumber;
            newPatient.Username = patient.Username;
        }
    }
}
