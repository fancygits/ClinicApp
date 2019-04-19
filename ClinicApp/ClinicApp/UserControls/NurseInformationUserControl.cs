using ClinicApp.Controller;
using ClinicApp.Model;
using ClinicApp.View;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ClinicApp.UserControls
{
    /// <summary>
    /// UserControl for NurseInformation
    /// </summary>
    public partial class NurseInformationUserControl : UserControl, IUserControlSearch
    {
        private readonly NurseController nurseController;
        public Nurse nurse;
        private Credential currentCredential;
        private Nurse newNurse;
        private Credential newCredential;
        private List<State> stateList;
        private ErrorProvider errorProvider;

        /// <summary>
        /// Constructs a new NurseInformationUserControl
        /// </summary>
        public NurseInformationUserControl()
        {
            InitializeComponent();
            nurseController = new NurseController();
            errorProvider = new ErrorProvider();
            personSearchUserControl.SetPersonType(new Nurse());
            personSearchUserControl.GetPersonButtonClicked += personSearchUserControl_GetPersonButtonClicked;
            personSearchUserControl.ClearButtonClicked += personSearchUserControl_ClearButtonClicked;
            personSearchUserControl.AddPersonClicked += btnAddUpdateNurse_Click;
        }
        
        /// <summary>
        /// Loads the UserControl
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NurseInformationUserControl_Load(object sender, EventArgs e)
        {
            newNurse = new Nurse();
            currentCredential = new Credential();
            newCredential = new Credential();
            LoadComboboxes();
            phoneNumberMaskedTextBox.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            ClearFields();
            DisableFields();
            this.ActiveControl = personSearchUserControl;
        }

        /// <summary>
        /// The method to run when the GetPerson Button in PersonSearchUserControl is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void personSearchUserControl_GetPersonButtonClicked(object sender, EventArgs e)
        {
            nurse = personSearchUserControl.nurse;
            nurseBindingSource.Clear();
            nurseBindingSource.Add(nurse);
            this.GetNurse();
        }

        /// <summary>
        /// The method to run when the Clear button in PersonSearchUserControl is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void personSearchUserControl_ClearButtonClicked(object sender, EventArgs e)
        {
            ClearFields();
            DisableFields();
        }

        /// <summary>
        /// Gets a nurse from the given textboxes.
        /// If no nurse is found, returns a list of possible matches.
        /// If no matches are found, prompts to add a new Nurse.
        /// </summary>
        public void GetNurse()
        {
            //if (nurse == null)
            //{
            //    nurse = new Nurse();
            //    currentCredential = new Credential();
            //}
            if (nurse.FirstName == null)
            {
                firstNameTextBox.Focus();
                btnAddUpdateNurse.Text = "Add Nurse";
                resetPasswordButton.Text = "Set Password";
                PutNewNurse();
                nurseBindingSource.Clear();
                nurseBindingSource.Add(nurse);
                EnableFields();
                btnAddUpdateNurse.Enabled = true;
            }
            else
            {
                btnAddUpdateNurse.Text = "Update Nurse";
                resetPasswordButton.Text = "Reset Password";
                PutNewNurse();
                nurseBindingSource.Clear();
                nurseBindingSource.Add(newNurse);
                EnableFields();
                btnAddUpdateNurse.Enabled = false;
            }
        }

        private void AddNurse()
        {
            if (IsValidData())
            {
                if (newCredential.Password == null)
                {
                    errorProvider.SetError(resetPasswordButton, "Password hasn't been set.");
                    return;
                }
                string firstName = firstNameTextBox.Text;
                string lastName = lastNameTextBox.Text;
                string birthDate = birthDateDateTimePicker.Value.ToShortDateString();
                string SSN = sSNMaskedTextBox.Text;
                int nurseID = -1;
                try
                {
                    PutNewNurse();
                    Nurse tempNurse = nurseController.GetNurseByName(firstName, lastName, birthDate);
                    if (tempNurse != null)
                    {
                        nurseID = tempNurse.NurseID;
                        lblMessage.Text = "Error: That person is already a nurse.";
                        return;
                    }
                    else
                    {
                        nurseID = PersonToNurse();
                    }
                    if (nurseID > 0)
                    {
                        lblMessage.Text = "Nurse " + nurseID + " has been added successfully.";
                        return;
                    }
                    else
                    {
                        nurseID = nurseController.AddNurse(newNurse);
                    }
                    if (nurseID > 0)
                    {
                        GetNurse();
                        lblMessage.Text = "Nurse " + nurseID + " has been added successfully.";
                    }
                    else
                    {
                        lblMessage.Text = "Error: There was a problem adding a new nurse.";
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
        /// Checks if a Person already exists and offers to add them as a nurse
        /// </summary>
        /// <returns>The new NurseID or -1 if fail</returns>
        private int PersonToNurse()
        {
            string firstName = firstNameTextBox.Text;
            string lastName = lastNameTextBox.Text;
            string birthDate = birthDateDateTimePicker.Value.ToShortDateString();
            string SSN = sSNMaskedTextBox.Text;
            bool active = activeCheckBox.Checked;
            int nurseID = -1;
            try
            {
                int personID = nurseController.GetPersonID(firstName, lastName, birthDate, SSN);
                if (personID > 0)
                {
                    DialogResult result = MessageBox.Show("That person already exists in our database.\n" +
                            "S/he will be added as a new nurse", "Person already exists",
                            MessageBoxButtons.OK, MessageBoxIcon.Question);
                    if (result == DialogResult.OK)
                    {
                        nurseID = nurseController.InsertNurse(personID, active);
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
            return nurseID;
        }

        /// <summary>
        /// Updates the nurse
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateNurse()
        {
            if (IsValidData())
            {
                try
                {
                    newCredential.Username = usernameTextBox.Text;
                    if (nurseController.UpdateNurse(nurse, currentCredential, newNurse, newCredential))
                    {
                        RefreshNurse();
                        GetNurse();
                        lblMessage.Text = "Nurse has been updated successfully.";
                    }
                    else
                    {
                        lblMessage.Text = "Error: There was a problem updating this nurse.";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Something is wrong with the input!! \n" + ex.ToString(),
                                        "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void SetResetPassword()
        {
            ResetPasswordDialog updateAccountDialog = new ResetPasswordDialog(newNurse);
            Enabled = false;
            DialogResult result = updateAccountDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                newCredential = updateAccountDialog.newCredential;
                lblMessage.Text = "New password is set. Press " + btnAddUpdateNurse.Text + " to save.";
                btnAddUpdateNurse.Enabled = true;
            }
            Enabled = true;
        }

        /// <summary>
        /// Puts fields into a new nurse object
        /// </summary>
        private void PutNewNurse()
        {
            newNurse.NurseID = nurse.NurseID;
            newNurse.PersonID = nurse.PersonID;
            newNurse.LastName = nurse.LastName;
            newNurse.FirstName = nurse.FirstName;
            newNurse.BirthDate = nurse.BirthDate.Date;
            newNurse.SSN = nurse.SSN;
            newNurse.Gender = nurse.Gender;
            newNurse.StreetAddress = nurse.StreetAddress;
            newNurse.City = nurse.City;
            newNurse.State = nurse.State;
            newNurse.PostCode = nurse.PostCode;
            newNurse.PhoneNumber = nurse.PhoneNumber;
            newNurse.Active = nurse.Active;
            newNurse.Username = nurse.Username;
            newNurse.Password = newCredential.Password;
            currentCredential.Username = nurse.Username;
            currentCredential.Role = "nurse";
            newCredential.Username = currentCredential.Username;
            newCredential.Password = currentCredential.Password;
            newCredential.Role = currentCredential.Role;
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

            stateList = StateList.list;
            stateComboBox.DataSource = stateList;
            stateComboBox.SelectedIndex = -1;
            stateComboBox.SelectedValue = "";
        }

        public void ClearFields()
        {
            errorProvider.Clear();
            nurse = null;
            nurseBindingSource.Clear();
            birthDateDateTimePicker.Value = DateTime.Today;
            genderComboBox.SelectedIndex = -1;
            stateComboBox.SelectedIndex = -1;
            lblMessage.Text = "";
            firstNameTextBox.Focus();
        }

        private void EnableFields()
        {
            firstNameTextBox.Enabled = true;
            lastNameTextBox.Enabled = true;
            birthDateDateTimePicker.Enabled = true;
            sSNMaskedTextBox.Enabled = true;
            genderComboBox.Enabled = true;
            streetAddressTextBox.Enabled = true;
            cityTextBox.Enabled = true;
            postCodeTextBox.Enabled = true;
            stateComboBox.Enabled = true;
            phoneNumberMaskedTextBox.Enabled = true;
            usernameTextBox.Enabled = true;
            activeCheckBox.Enabled = true;
            resetPasswordButton.Enabled = true;
        }

        private void DisableFields()
        {
            firstNameTextBox.Enabled = false;
            lastNameTextBox.Enabled = false;
            birthDateDateTimePicker.Enabled = false;
            sSNMaskedTextBox.Enabled = false;
            genderComboBox.Enabled = false;
            streetAddressTextBox.Enabled = false;
            cityTextBox.Enabled = false;
            postCodeTextBox.Enabled = false;
            stateComboBox.Enabled = false;
            phoneNumberMaskedTextBox.Enabled = false;
            usernameTextBox.Enabled = false;
            activeCheckBox.Enabled = false;
            resetPasswordButton.Enabled = false;
            btnAddUpdateNurse.Text = "Add Nurse";
            resetPasswordButton.Text = "Set Password";
        }

        private void RefreshNurse()
        {
            personSearchUserControl.RefreshPerson();
            nurse = personSearchUserControl.nurse;
            currentCredential.Username = nurse.Username;
            currentCredential.Role = "nurse";
            nurseBindingSource.Clear();
            nurseBindingSource.Add(nurse);
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
                   Validator.IsPresent(phoneNumberMaskedTextBox, errorProvider) &&
                   Validator.IsPresent(usernameTextBox, errorProvider);
        }

        /// <summary>
        /// Enables buttons if necessary. Clears message label.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NurseTextboxChanged(object sender, EventArgs e)
        {
            if (sSNMaskedTextBox.MaskFull)
            {
                if (btnAddUpdateNurse.Enabled == false)
                {
                    lblMessage.Text = "";
                }
                btnAddUpdateNurse.Enabled = true;
            }
        }

        private void btnAddUpdateNurse_Click(object sender, EventArgs e)
        {
            if (btnAddUpdateNurse.Text == "Update Nurse")
            {
                UpdateNurse();
            }
            else
            {
                if (nurse == null)
                {
                    nurse = new Nurse();
                }
                if (sSNMaskedTextBox.Enabled)
                {
                    AddNurse();
                }
                else
                {
                    EnableFields();
                    nurseBindingSource.Clear();
                    nurseBindingSource.Add(nurse);
                }
            }
        }

        private void resetPasswordButton_Click(object sender, EventArgs e)
        {
            SetResetPassword();
        }

        /// <summary>
        /// Used to find possible errors in a nurse
        /// </summary>
        private void DebugNurse(object sender, EventArgs e)
        {
            if (nurse == null)
            {
                System.Diagnostics.Debug.Print("No Nurse Loaded.");
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
                    System.Diagnostics.Debug.Print("Username:\t" + usernameTextBox.Text);
                    System.Diagnostics.Debug.Print("Active:\t\t" + activeCheckBox.Checked);

                    System.Diagnostics.Debug.Print("\t[Current Nurse]");
                    System.Diagnostics.Debug.Print("NurseID:\t" + nurse.NurseID.ToString());
                    System.Diagnostics.Debug.Print("PersonID:\t" + nurse.PersonID.ToString());
                    System.Diagnostics.Debug.Print("Full Name:\t" + nurse.FullName.ToString());
                    System.Diagnostics.Debug.Print("Birth Date:\t" + nurse.BirthDate.ToString());
                    System.Diagnostics.Debug.Print("SSN:\t\t" + nurse.SSN.ToString());
                    System.Diagnostics.Debug.Print("Gender:\t\t" + nurse.Gender.ToString());
                    System.Diagnostics.Debug.Print("Address:\t" + nurse.StreetAddress.ToString());
                    System.Diagnostics.Debug.Print("City:\t\t" + nurse.City.ToString());
                    System.Diagnostics.Debug.Print("State:\t\t" + nurse.State.ToString());
                    System.Diagnostics.Debug.Print("Postcode:\t" + nurse.PostCode.ToString());
                    System.Diagnostics.Debug.Print("Phone:\t\t" + nurse.PhoneNumber.ToString());
                    System.Diagnostics.Debug.Print("Username:\t" + nurse.Username.ToString());
                    System.Diagnostics.Debug.Print("Active:\t\t" + nurse.Active.ToString());

                    System.Diagnostics.Debug.Print("\t[Current Credential]");
                    System.Diagnostics.Debug.Print("Username:\t" + Convert.ToString(currentCredential.Username));
                    System.Diagnostics.Debug.Print("Password:\t" + Convert.ToString(currentCredential.Password));
                    System.Diagnostics.Debug.Print("Role:\t\t" + currentCredential.Role.ToString());

                    System.Diagnostics.Debug.Print("\t[New Nurse]");
                    System.Diagnostics.Debug.Print("NurseID:\t" + newNurse.NurseID.ToString());
                    System.Diagnostics.Debug.Print("PersonID:\t" + newNurse.PersonID.ToString());
                    System.Diagnostics.Debug.Print("Full Name:\t" + newNurse.FullName.ToString());
                    System.Diagnostics.Debug.Print("Birth Date:\t" + newNurse.BirthDate.ToString());
                    System.Diagnostics.Debug.Print("SSN:\t\t" + newNurse.SSN.ToString());
                    System.Diagnostics.Debug.Print("Gender:\t\t" + newNurse.Gender.ToString());
                    System.Diagnostics.Debug.Print("Address:\t" + newNurse.StreetAddress.ToString());
                    System.Diagnostics.Debug.Print("City:\t\t" + newNurse.City.ToString());
                    System.Diagnostics.Debug.Print("State:\t\t" + newNurse.State.ToString());
                    System.Diagnostics.Debug.Print("Postcode:\t" + newNurse.PostCode.ToString());
                    System.Diagnostics.Debug.Print("Phone:\t\t" + newNurse.PhoneNumber.ToString());
                    System.Diagnostics.Debug.Print("Username:\t" + newNurse.Username.ToString());
                    System.Diagnostics.Debug.Print("Active:\t\t" + newNurse.Active.ToString());

                    System.Diagnostics.Debug.Print("\t[New Credential]");
                    System.Diagnostics.Debug.Print("Username:\t" + Convert.ToString(newCredential.Username));
                    System.Diagnostics.Debug.Print("Password:\t" + Convert.ToString(newCredential.Password));
                    System.Diagnostics.Debug.Print("Role:\t\t" + newCredential.Role.ToString());
                }
                catch
                {
                    return;
                }
            }
        }

    }
}
