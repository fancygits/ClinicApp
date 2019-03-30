using ClinicApp.Controller;
using ClinicApp.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ClinicApp.UserControls
{
    /// <summary>
    /// UserControl for Patient Information
    /// </summary>
    public partial class PatientInformationUserControl : UserControl, IUserControlSearch
    {
        private readonly PatientController patientController;
        public Patient patient;
        private Patient newPatient;
        private List<State> stateList;

        /// <summary>
        /// Constructs a new PatientInformationUserControl
        /// </summary>
        public PatientInformationUserControl()
        {
            InitializeComponent();
            this.patientController = new PatientController();
        }

        /// <summary>
        /// Loads the UserControl
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PatientInformationUserControl_Load(object sender, System.EventArgs e)
        {
            newPatient = new Patient();
            this.LoadComboboxes();
            phoneNumberMaskedTextBox.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            this.ClearFields();
            this.DisableFields();
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
            string birthDate = birthDateDateTimePicker.Text;
            this.patient = this.FindPatient(firstName, lastName, birthDate);
            if (this.patient != null)
            {
                btnAddUpdatePatient.Text = "Update Patient";
                this.PutNewPatient();
                patientBindingSource.Clear();
                patientBindingSource.Add(newPatient);
                this.EnableFields();
                btnGetPatient.Enabled = false;
                btnAddUpdatePatient.Enabled = false;
            }
            else
            {
                this.NoMatchesDialog();
            }
        }

        /// <summary>
        /// Prompts to add a new patient since none are found
        /// </summary>
        private void NoMatchesDialog()
        {
            DialogResult result = MessageBox.Show("No patients matched your search.\n" +
                            "Would you like to add a new patient?", "No Matches",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                btnAddUpdatePatient.PerformClick();
            }
        }

        private void AddPatient()
        {
            string firstName = firstNameTextBox.Text;
            string lastName = lastNameTextBox.Text;
            string birthDate = birthDateDateTimePicker.Text;
            string SSN = sSNMaskedTextBox.Text;
            int patientID = -1;
            try
            {
                Patient tempPatient = patientController.GetPatientByName(firstName, lastName, birthDate);
                if (tempPatient != null)
                {
                    patientID = tempPatient.PatientID;
                    lblMessage.Text = "Error: That person is already a patient.";
                    return;
                }
                else
                {
                    patientID = PersonToPatient();
                }
                if (patientID > 0)
                {
                    lblMessage.Text = "Patient " + patientID + " has been added successfully.";
                    return;
                }
                else
                {
                    patientID = this.patientController.AddPatient(patient);
                }
                if (patientID > 0)
                {
                    this.GetPatient();
                    lblMessage.Text = "Patient " + patientID + " has been added successfully.";
                }
                else
                {
                    lblMessage.Text = "Error: There was a problem adding a new patient.";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something is wrong with the input!! \n" + ex.Message,
                                    "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Checks if a Person already exists and offers to add them as a patient
        /// </summary>
        /// <returns>The new PatientID or -1 if fail</returns>
        private int PersonToPatient()
        {
            string firstName = firstNameTextBox.Text;
            string lastName = lastNameTextBox.Text;
            string birthDate = birthDateDateTimePicker.Text;
            string SSN = sSNMaskedTextBox.Text;
            int patientID = -1;
            try
            {
                int personID = patientController.GetPersonID(firstName, lastName, birthDate, SSN);
                if (personID > 0)
                {
                    DialogResult result = MessageBox.Show("That person already exists in our database.\n" +
                            "S/he will be added as a new patient", "Person already exists",
                            MessageBoxButtons.OK, MessageBoxIcon.Question);
                    if (result == DialogResult.OK)
                    {
                        patientID = patientController.InsertPatient(personID);
                    }
                    else
                    {
                        btnClear.PerformClick();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something is wrong with the input!! \n" + ex.Message,
                                    "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return patientID;
        }

        /// <summary>
        /// Updates the patient
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdatePatient()
        {
            try
            {
                if (this.patientController.UpdatePatient(patient, newPatient))
                {
                    this.GetPatient();
                    lblMessage.Text = "Patient has been updated successfully.";
                }
                else
                {
                    lblMessage.Text = "Error: There was a problem updating this patient.";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something is wrong with the input!! \n" + ex.Message,
                                    "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Puts fields into a new patient object
        /// </summary>
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

        /// <summary>
        /// Loads the comboboxes
        /// </summary>
        private void LoadComboboxes()
        {
            var genderDatasource = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("Male", "M"),
                new KeyValuePair<string, string>("Female", "F"),
                new KeyValuePair<string, string>("Other", "O")
            };
            genderComboBox.DataSource = genderDatasource;
            genderComboBox.DisplayMember = "Key";
            genderComboBox.ValueMember = "Value";
            genderComboBox.SelectedValue = "";

            stateList = this.patientController.GetStateList();
            stateComboBox.DataSource = stateList;
            stateComboBox.SelectedValue = "";
        }
        
        private void ClearFields()
        {
            patientBindingSource.Clear();
            birthDateDateTimePicker.Text = "";
            btnGetPatient.Enabled = false;
            btnSearchAppointments.Enabled = false;
            btnSearchVisits.Enabled = false;
            lblMessage.Text = "";
            firstNameTextBox.Focus();
        }

        private void EnableFields()
        {
            sSNMaskedTextBox.Enabled = true;
            genderComboBox.Enabled = true;
            streetAddressTextBox.Enabled = true;
            cityTextBox.Enabled = true;
            postCodeTextBox.Enabled = true;
            stateComboBox.Enabled = true;
            phoneNumberMaskedTextBox.Enabled = true;
            btnSearchAppointments.Enabled = true;
        }

        private void DisableFields()
        {
            sSNMaskedTextBox.Enabled = false;
            genderComboBox.Enabled = false;
            streetAddressTextBox.Enabled = false;
            cityTextBox.Enabled = false;
            postCodeTextBox.Enabled = false;
            stateComboBox.Enabled = false;
            phoneNumberMaskedTextBox.Enabled = false;
            btnAddUpdatePatient.Text = "Add Patient";
        }

        /// <summary>
        /// Enables buttons if necessary. Clears message label.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PatientTextboxChanged(object sender, EventArgs e)
        {
            if (sSNMaskedTextBox.MaskFull)
            {
                if (btnAddUpdatePatient.Enabled == false)
                {
                    lblMessage.Text = "";
                }
                btnAddUpdatePatient.Enabled = true;
            }

            btnGetPatient.Enabled = true;
            btnSearchAppointments.Enabled = false;
            btnSearchVisits.Enabled = false;
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
                btnGetPatient.PerformClick();
            }
        }

        

        private void btnSearchAppointments_Click(object sender, EventArgs e)
        {
            TabControl tabControl = this.Parent.Parent as TabControl;
            tabControl.SelectedIndex = 1;
            AddAppointmentUserControl addAppointmentUserControl = tabControl.TabPages[1].Controls[0] as AddAppointmentUserControl;
            addAppointmentUserControl.patient = this.patient;
            addAppointmentUserControl.RefreshPage();
        }

        private void btnGetPatient_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "";
            this.GetPatient();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearFields();
            this.DisableFields();
        }

        private void btnAddUpdatePatient_Click(object sender, EventArgs e)
        {
            if (btnAddUpdatePatient.Text == "Update Patient")
            {
                this.UpdatePatient();
            }
            else 
            {
                if (patient == null)
                {
                    patient = new Patient();
                    patientBindingSource.Add(patient);
                }
                if (sSNMaskedTextBox.Enabled)
                {
                    this.AddPatient();
                }
                else
                {
                    this.EnableFields();
                }
            }
        }
    }
}
