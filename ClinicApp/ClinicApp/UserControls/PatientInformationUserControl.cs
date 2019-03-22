using ClinicApp.Controller;
using ClinicApp.Model;
using ClinicApp.View;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ClinicApp.UserControls
{
    public partial class PatientInformationUserControl : UserControl
    {
        private readonly PatientController patientController;
        private Patient patient;
        private Patient newPatient;
        private List<State> stateList;

        public PatientInformationUserControl()
        {
            InitializeComponent();
            this.patientController = new PatientController();
        }

        private void PatientInformationUserControl_Load(object sender, System.EventArgs e)
        {
            patientBindingSource.Clear();
            newPatient = new Patient();
            this.LoadComboboxes();
            this.DisableUpdates();
        }

        private void GetPatient(object sender, EventArgs e)
        {
            lblMessage.Text = "";
            string firstName = firstNameTextBox.Text;
            string lastName = lastNameTextBox.Text;
            string birthDate = birthDateDateTimePicker.Text;
            try
            {
                patient = this.patientController.GetPatientByName(firstName, lastName, birthDate);
                if (patient == null)
                {
                    List<Patient> patientList = this.patientController.GetPatientsByName(firstName, lastName);
                    this.GetMatchingPatients(patientList);
                    if (patient == null)
                    {
                        return;
                    }
                }
                this.PutNewPatient();
                patientBindingSource.Clear();
                patientBindingSource.Add(newPatient);
                this.EnableUpdates();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void GetMatchingPatients(List<Patient> patientList)
        {
            FindPatientsDialog findPatientsDialog = new FindPatientsDialog();
            findPatientsDialog.patientList = patientList;
            DialogResult result = findPatientsDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                patient = findPatientsDialog.patient;
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

        private void LoadComboboxes()
        {
            var genderDatasource = new List<KeyValuePair<string, string>>();
            genderDatasource.Add(new KeyValuePair < string, string>("Male", "M"));
            genderDatasource.Add(new KeyValuePair<string, string>("Female", "F"));
            genderDatasource.Add(new KeyValuePair<string, string>("Other", "O"));
            genderComboBox.DataSource = genderDatasource;
            genderComboBox.DisplayMember = "Key";
            genderComboBox.ValueMember = "Value";
            genderComboBox.SelectedValue = "";

            stateList = this.patientController.GetStateList();
            stateComboBox.DataSource = stateList;
            stateComboBox.SelectedValue = "";
        }

        private void EnableUpdates()
        {
            sSNTextBox.Enabled = true;
            genderComboBox.Enabled = true;
            streetAddressTextBox.Enabled = true;
            cityTextBox.Enabled = true;
            postCodeTextBox.Enabled = true;
            stateComboBox.Enabled = true;
            phoneNumberTextBox.Enabled = true;
            btnUpdatePatient.Enabled = true;
        }

        private void DisableUpdates()
        {
            sSNTextBox.Enabled = false;
            genderComboBox.Enabled = false;
            streetAddressTextBox.Enabled = false;
            cityTextBox.Enabled = false;
            postCodeTextBox.Enabled = false;
            stateComboBox.Enabled = false;
            phoneNumberTextBox.Enabled = false;
            btnUpdatePatient.Enabled = false;
        }
    }
}
