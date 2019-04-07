using ClinicApp.Controller;
using ClinicApp.Model;
using ClinicApp.View;
using System;
using System.Collections.Generic;
using System.Drawing;
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
        private ErrorProvider errorProvider;
        private PersonSearchUserControl personSearchUserControl;

        /// <summary>
        /// Constructs a new PatientInformationUserControl
        /// </summary>
        public PatientInformationUserControl()
        {
            InitializeComponent();
            patientController = new PatientController();
            errorProvider = new ErrorProvider();
            personSearchUserControl = new PersonSearchUserControl(new Patient());
            personSearchUserControl.GetPersonButtonClicked += personSearchUserControl_GetPersonButtonClicked;
        }

        /// <summary>
        /// Loads the UserControl
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PatientInformationUserControl_Load(object sender, EventArgs e)
        {
            newPatient = new Patient();
            LoadComboboxes();
            LoadSearchBox();
            phoneNumberMaskedTextBox.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            ClearFields();
            DisableFields();
        }
        
        /// <summary>
        /// Loads a PersonSearchUserControl and places it in the Parent UserControl
        /// </summary>
        public void LoadSearchBox()
        {
            personSearchUserControl.Location = new Point(0, 0);
            personSearchUserControl.Name = "personSearchUserControl";
            personSearchUserControl.Size = new Size(800, 75);
            personSearchUserControl.TabIndex = 0;
            Controls.Add(personSearchUserControl);
            this.ActiveControl = personSearchUserControl;
        }

        /// <summary>
        /// The method to run when the GetPerson Button in PersonSearchUserControl is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void personSearchUserControl_GetPersonButtonClicked(object sender, EventArgs e)
        {
            this.GetPatient();
        }

        /// <summary>
        /// Gets a patient from the given textboxes.
        /// If no patient is found, returns a list of possible matches.
        /// If no matches are found, prompts to add a new Patient.
        /// </summary>
        public void GetPatient()
        {
            this.RefreshPatient();
            if (patient == null)
            {
                NoMatchesDialog();
            }
            else if (patient.FirstName == null)
            {
                firstNameTextBox.Focus();
                btnAddUpdatePatient.Text = "Add Patient";
                PutNewPatient();
                patientBindingSource.Clear();
                patientBindingSource.Add(newPatient);
                EnableFields();
                btnAddUpdatePatient.Enabled = true;
            }
            else
            {
                btnAddUpdatePatient.Text = "Update Patient";
                PutNewPatient();
                patientBindingSource.Clear();
                patientBindingSource.Add(newPatient);
                EnableFields();
                btnAddUpdatePatient.Enabled = false;
            }
        }

        /// <summary>
        /// Prompts to add a new patient since none are found
        /// </summary>
        public void NoMatchesDialog()
        {
            DialogResult result = MessageBox.Show("No patients matched your search.\n" +
                            "Would you like to add a new patient?", "No Matches",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                TabControl tabControl = Parent.Parent as TabControl;
                tabControl.SelectedIndex = 0;
                btnAddUpdatePatient.PerformClick();
            }
        }

        private void AddPatient()
        {
            if (IsValidData())
            {
                string firstName = firstNameTextBox.Text;
                string lastName = lastNameTextBox.Text;
                string birthDate = birthDateDateTimePicker.Value.ToShortDateString();
                string SSN = sSNMaskedTextBox.Text;
                int patientID = -1;
                try
                {
                    PutNewPatient();
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
                        patientID = patientController.AddPatient(newPatient);
                    }
                    if (patientID > 0)
                    {
                        GetPatient();
                        lblMessage.Text = "Patient " + patientID + " has been added successfully.";
                    }
                    else
                    {
                        lblMessage.Text = "Error: There was a problem adding a new patient.";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Something is wrong with the input!! \n" + ex.ToString(),
                                        "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
            string birthDate = birthDateDateTimePicker.Value.ToShortDateString();
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
                        ClearFields();
                        DisableFields();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something is wrong with the input!! \n" + ex.ToString(),
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
            if (IsValidData())
            {
                try
                {
                    if (patientController.UpdatePatient(patient, newPatient))
                    {
                        GetPatient();
                        lblMessage.Text = "Patient has been updated successfully.";
                    }
                    else
                    {
                        lblMessage.Text = "Error: There was a problem updating this patient.";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Something is wrong with the input!! \n" + ex.ToString(),
                                        "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
            genderComboBox.SelectedIndex = -1;
            genderComboBox.SelectedValue = "";

            stateList = patientController.GetStateList();
            stateComboBox.DataSource = stateList;
            stateComboBox.SelectedIndex = -1;
            stateComboBox.SelectedValue = "";
        }
        
        public void ClearFields()
        {
            patient = null;
            patientBindingSource.Clear();
            birthDateDateTimePicker.Value = DateTime.Today;
            genderComboBox.SelectedIndex = -1;
            stateComboBox.SelectedIndex = -1;
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
            btnSearchVisits.Enabled = true;
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

        private void RefreshPatient()
        {
            this.personSearchUserControl.RefreshPerson();
            patient = this.personSearchUserControl.patient;
            patientBindingSource.Clear();
            patientBindingSource.Add(patient);
        }

        private bool IsValidData()
        {
            return Validator.IsPresent(firstNameTextBox, errorProvider) &&
                   Validator.IsPresent(lastNameTextBox, errorProvider) &&
                   Validator.IsPresent(birthDateDateTimePicker, errorProvider) &&
                   Validator.IsValidDate(birthDateDateTimePicker, DateTime.Parse("1900-01-01"), DateTime.Today.AddDays(1), errorProvider) &&
                   Validator.IsPresent(sSNMaskedTextBox, errorProvider) &&
                   Validator.IsPresent(genderComboBox, errorProvider) &&
                   Validator.IsPresent(streetAddressTextBox, errorProvider) &&
                   Validator.IsPresent(cityTextBox, errorProvider) &&
                   Validator.IsPresent(stateComboBox, errorProvider) &&
                   Validator.IsPresent(postCodeTextBox, errorProvider) &&
                   Validator.IsPostCode(postCodeTextBox, errorProvider) &&
                   Validator.IsPresent(phoneNumberMaskedTextBox, errorProvider);
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
            btnSearchAppointments.Enabled = false;
            btnSearchVisits.Enabled = false;
        }

        private void btnSearchAppointments_Click(object sender, EventArgs e)
        {
            TabControl tabControl = Parent.Parent as TabControl;
            tabControl.SelectedIndex = 1;
            AddAppointmentUserControl addAppointmentUserControl = tabControl.TabPages[1].Controls[0] as AddAppointmentUserControl;
            addAppointmentUserControl.patient = patient;
            addAppointmentUserControl.RefreshPage();
        }
        private void btnSearchVisits_Click(object sender, EventArgs e)
        {
            TabControl tabControl = Parent.Parent as TabControl;
            tabControl.SelectedIndex = 2;
            SearchForVisitUserControl searchForVisitUserControl = tabControl.TabPages[2].Controls[0] as SearchForVisitUserControl;
            searchForVisitUserControl.patient = patient;
            searchForVisitUserControl.SelectPatient();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
            DisableFields();
        }

        private void btnAddUpdatePatient_Click(object sender, EventArgs e)
        {
            if (btnAddUpdatePatient.Text == "Update Patient")
            {
                UpdatePatient();
            }
            else 
            {
                if (patient == null)
                {
                    patient = new Patient();
                }
                if (sSNMaskedTextBox.Enabled)
                {
                    AddPatient();
                }
                else
                {
                    EnableFields();
                }
                patientBindingSource.Clear();
                patientBindingSource.Add(patient);
            }
        }

        /// <summary>
        /// Used to find possible errors in a patient
        /// </summary>
        private void DebugPatient(object sender, EventArgs e)
        {
            if (patient == null)
            {
                System.Diagnostics.Debug.Print("No Patient Loaded.");
            }
            else
            {
                try
                {
                    System.Diagnostics.Debug.Print("\t[Current Fields]");
                    System.Diagnostics.Debug.Print("First Name:\t" + firstNameTextBox.Text);
                    System.Diagnostics.Debug.Print("Last Name:\t" + lastNameTextBox.Text);
                    System.Diagnostics.Debug.Print("Birth Date:\t" + birthDateDateTimePicker.Value.ToShortDateString());
                    System.Diagnostics.Debug.Print("SSN:\t\t" + sSNMaskedTextBox.Text);
                    System.Diagnostics.Debug.Print("Gender:\t\t" + genderComboBox.DisplayMember);
                    System.Diagnostics.Debug.Print("Address:\t" + streetAddressTextBox.Text);
                    System.Diagnostics.Debug.Print("City:\t\t" + cityTextBox.Text);
                    System.Diagnostics.Debug.Print("State:\t\t" + stateComboBox.DisplayMember);
                    System.Diagnostics.Debug.Print("Postcode:\t" + postCodeTextBox.Text);
                    System.Diagnostics.Debug.Print("Phone:\t\t" + phoneNumberMaskedTextBox.Text);

                    System.Diagnostics.Debug.Print("\t[Current Patient]");
                    System.Diagnostics.Debug.Print("PatientID:\t" + patient.PatientID.ToString());
                    System.Diagnostics.Debug.Print("PersonID:\t" + patient.PersonID.ToString());
                    System.Diagnostics.Debug.Print("Full Name:\t" + patient.FullName.ToString());
                    System.Diagnostics.Debug.Print("Birth Date:\t" + patient.BirthDate.ToString());
                    System.Diagnostics.Debug.Print("SSN:\t\t" + patient.SSN.ToString());
                    System.Diagnostics.Debug.Print("Gender:\t\t" + patient.Gender.ToString());
                    System.Diagnostics.Debug.Print("Address:\t" + patient.StreetAddress.ToString());
                    System.Diagnostics.Debug.Print("City:\t\t" + patient.City.ToString());
                    System.Diagnostics.Debug.Print("State:\t\t" + patient.State.ToString());
                    System.Diagnostics.Debug.Print("Postcode:\t" + patient.PostCode.ToString());
                    System.Diagnostics.Debug.Print("Phone:\t\t" + patient.PhoneNumber.ToString());
                }
                catch
                {
                    return;
                }
            }
        }

    }
}
