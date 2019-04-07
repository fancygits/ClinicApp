using ClinicApp.Controller;
using ClinicApp.Model;
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
            //ClearFields();
            //DisableFields();
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

            stateList = nurseController.GetStateList();
            stateComboBox.DataSource = stateList;
            stateComboBox.SelectedIndex = -1;
            stateComboBox.SelectedValue = "";
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
            //    this.RefreshNurse();
            //    if (nurse == null)
            //    {
            //        NoMatchesDialog();
            //    }
            //    else if (nurse.FirstName == null)
            //    {
            //        firstNameTextBox.Focus();
            //        btnAddUpdateNurse.Text = "Add Nurse";
            //        PutNewNurse();
            //        nurseBindingSource.Clear();
            //        nurseBindingSource.Add(newNurse);
            //        EnableFields();
            //        btnAddUpdateNurse.Enabled = true;
            //    }
            //    else
            //    {
            //        btnAddUpdateNurse.Text = "Update Nurse";
            //        PutNewNurse();
            //        nurseBindingSource.Clear();
            //        nurseBindingSource.Add(newNurse);
            //        EnableFields();
            //        btnAddUpdateNurse.Enabled = false;
            //    }
        }

    }
}
