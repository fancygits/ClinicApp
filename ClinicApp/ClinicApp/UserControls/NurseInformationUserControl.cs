﻿using ClinicApp.Controller;
using ClinicApp.Model;
using ClinicApp.View;
using System;
using System.Collections.Generic;
using System.Drawing;
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
        private Nurse newNurse;
        private List<State> stateList;
        private ErrorProvider errorProvider;
        private PersonSearchUserControl personSearchUserControl;

        /// <summary>
        /// Constructs a new NurseInformationUserControl
        /// </summary>
        public NurseInformationUserControl()
        {
            InitializeComponent();
            nurseController = new NurseController();
            errorProvider = new ErrorProvider();
            personSearchUserControl = new PersonSearchUserControl(new Nurse());
            personSearchUserControl.GetPersonButtonClicked += personSearchUserControl_GetPersonButtonClicked;
        }
        
        /// <summary>
        /// Loads the UserControl
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NurseInformationUserControl_Load(object sender, EventArgs e)
        {
            newNurse = new Nurse();
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
            personSearchUserControl.TabIndex = 1;
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
            this.GetNurse();
        }

        /// <summary>
        /// Gets a nurse from the given textboxes.
        /// If no nurse is found, returns a list of possible matches.
        /// If no matches are found, prompts to add a new Nurse.
        /// </summary>
        public void GetNurse()
        {
            RefreshNurse();
            if (nurse == null)
            {
                NoMatchesDialog();
            }
            else if (nurse.FirstName == null)
            {
                firstNameTextBox.Focus();
                btnAddUpdateNurse.Text = "Add Nurse";
                PutNewNurse();
                nurseBindingSource.Clear();
                nurseBindingSource.Add(newNurse);
                EnableFields();
                btnAddUpdateNurse.Enabled = true;
            }
            else
            {
                btnAddUpdateNurse.Text = "Update Nurse";
                PutNewNurse();
                nurseBindingSource.Clear();
                nurseBindingSource.Add(newNurse);
                EnableFields();
                btnAddUpdateNurse.Enabled = false;
            }
        }

        /// <summary>
        /// Prompts to add a new nurse since none are found
        /// </summary>
        public void NoMatchesDialog()
        {
            DialogResult result = MessageBox.Show("No nurses matched your search.\n" +
                            "Would you like to add a new nurse?", "No Matches",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                TabControl tabControl = Parent.Parent as TabControl;
                tabControl.SelectedIndex = 0;
                btnAddUpdateNurse.PerformClick();
            }
        }

        private void AddNurse()
        {
            if (IsValidData())
            {
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
                        nurseID = nurseController.InsertNurse(personID);
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
                    if (nurseController.UpdateNurse(nurse, newNurse))
                    {
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

        /// <summary>
        /// Puts fields into a new nurse object
        /// </summary>
        private void PutNewNurse()
        {
            newNurse.NurseID = nurse.NurseID;
            newNurse.PersonID = nurse.PersonID;
            newNurse.LastName = nurse.LastName;
            newNurse.FirstName = nurse.FirstName;
            newNurse.BirthDate = nurse.BirthDate;
            newNurse.SSN = nurse.SSN;
            newNurse.Gender = nurse.Gender;
            newNurse.StreetAddress = nurse.StreetAddress;
            newNurse.City = nurse.City;
            newNurse.State = nurse.State;
            newNurse.PostCode = nurse.PostCode;
            newNurse.PhoneNumber = nurse.PhoneNumber;
            newNurse.Username = nurse.Username;
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
            sSNMaskedTextBox.Enabled = true;
            genderComboBox.Enabled = true;
            streetAddressTextBox.Enabled = true;
            cityTextBox.Enabled = true;
            postCodeTextBox.Enabled = true;
            stateComboBox.Enabled = true;
            phoneNumberMaskedTextBox.Enabled = true;
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
            btnAddUpdateNurse.Text = "Add Nurse";
        }

        private void RefreshNurse()
        {
            this.personSearchUserControl.RefreshPerson();
            nurse = this.personSearchUserControl.nurse;
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
                   Validator.IsPresent(phoneNumberMaskedTextBox, errorProvider);
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
            DisableFields();
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
                }
                nurseBindingSource.Clear();
                nurseBindingSource.Add(nurse);
            }
        }

    }
}
