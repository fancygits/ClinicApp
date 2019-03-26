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
            newPatient = new Patient();
            this.LoadComboboxes();
            this.DisableUpdates();
            phoneNumberMaskedTextBox.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            this.ClearFields(null, null);
        }

        private void GetPatient(object sender, EventArgs e)
        {
            string firstName = firstNameTextBox.Text;
            string lastName = lastNameTextBox.Text;
            string birthDate = birthDateDateTimePicker.Text;
            try
            {
                patient = this.patientController.GetPatientByName(firstName, lastName, birthDate);
                if (patient == null)
                {
                    List<Patient> patientList = this.patientController.SearchPatientsByName(firstName, lastName, birthDate);
                    if (patientList.Count == 0)
                    {
                        this.NoMatchesDialog();
                    }
                    else
                    {
                        this.GetMatchingPatients(patientList);
                    }
                    if (patient == null)
                    {
                        return;
                    }
                }
                this.PutNewPatient();
                patientBindingSource.Clear();
                patientBindingSource.Add(newPatient);
                this.EnableUpdates();
                btnGetPatient.Enabled = false;
                btnUpdatePatient.Enabled = false;
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

        private void NoMatchesDialog()
        {
            DialogResult result = MessageBox.Show("No patients matched your search.\n" +
                            "Would you like to add a new patient?", "No Matches",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.AddPatientDialog();
            }
        }

        private void AddPatientDialog()
        {

        }

        private void btnUpdatePatient_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.patientController.UpdatePatient(patient, newPatient))
                {
                    lblMessage.Text = "Patient has been updated successfully.";
                }
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
            sSNMaskedTextBox.Enabled = true;
            genderComboBox.Enabled = true;
            streetAddressTextBox.Enabled = true;
            cityTextBox.Enabled = true;
            postCodeTextBox.Enabled = true;
            stateComboBox.Enabled = true;
            phoneNumberMaskedTextBox.Enabled = true;
            btnSearchAppointments.Enabled = true;
            btnSearchVisits.Enabled = true;
        }

        private void DisableUpdates()
        {
            sSNMaskedTextBox.Enabled = false;
            genderComboBox.Enabled = false;
            streetAddressTextBox.Enabled = false;
            cityTextBox.Enabled = false;
            postCodeTextBox.Enabled = false;
            stateComboBox.Enabled = false;
            phoneNumberMaskedTextBox.Enabled = false;
            btnUpdatePatient.Enabled = false;
        }

        private void PatientTextboxChanged(object sender, EventArgs e)
        {
            if (cityTextBox.Text != "")
            {
                if (btnUpdatePatient.Enabled == false)
                {
                    lblMessage.Text = "";
                }
                btnUpdatePatient.Enabled = true;
            }
            btnGetPatient.Enabled = true;
            btnSearchAppointments.Enabled = false;
            btnSearchVisits.Enabled = false;
        }

        private void ClearFields(object sender, EventArgs e)
        {
            this.DisableUpdates();
            patientBindingSource.Clear();
            birthDateDateTimePicker.Text = "";
            btnGetPatient.Enabled = false;
            btnSearchAppointments.Enabled = false;
            btnSearchVisits.Enabled = false;
            lblMessage.Text = "";
            firstNameTextBox.Focus();
        }

        private void Enter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                btnGetPatient.PerformClick();
            }
        }
    }
}
