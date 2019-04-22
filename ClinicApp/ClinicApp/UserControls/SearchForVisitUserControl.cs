using ClinicApp.Controller;
using ClinicApp.Model;
using ClinicApp.View;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ClinicApp.UserControls
{
    /// <summary>
    /// This is the user control that will allow a user to search for a visit by a patient and patient ID
    /// </summary>
    public partial class SearchForVisitUserControl : UserControl
    {
        private VisitController visitController;
        private CredentialController credentialController;
        public Patient patient;
        public Visit visit;
        private List<Patient> listOfPatients;
        private List<Visit> listOfVisits;

        public SearchForVisitUserControl()
        {
            InitializeComponent();
            this.listOfPatients = new List<Patient>();
            this.listOfVisits = new List<Visit>();
            this.visitController = new VisitController();
            this.credentialController = new CredentialController();
            personSearchUserControl.SetPersonType(new Patient());
            personSearchUserControl.GetPersonButtonClicked += personSearchUserControl_GetPersonButtonClicked;
            personSearchUserControl.ClearButtonClicked += personSearchUserControl_ClearButtonClicked;
        }

        private void RefreshPatient()
        {
            personSearchUserControl.RefreshPerson();
            patient = personSearchUserControl.patient;
            patientBindingSource.Clear();
            patientBindingSource.Add(patient);
        }

        /// <summary>
        /// The method to run when the GetPerson Button in PersonSearchUserControl is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void personSearchUserControl_GetPersonButtonClicked(object sender, EventArgs e)
        {
            RefreshPatient();
            RefreshPage();
        }

        /// <summary>
        /// The method to run when the Clear button in PersonSearchUserControl is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void personSearchUserControl_ClearButtonClicked(object sender, EventArgs e)
        {
            patientBindingSource.Clear();
            visitBindingSource.Clear();
            visitDataGridView.DataSource = null;
        }

        public void RefreshPage()
        {
            if (this.patient != null)
            {
                patientBindingSource.Add(patient);
                this.DisplayVistsByPatient();
            }
            else
            {
                if (this.listOfVisits != null)
                {
                    this.listOfVisits.Clear();
                }
            }
        }

        /// <summary>
        /// This method will display the visits by the patient that is selected
        /// </summary>
        public void DisplayVistsByPatient()
        {
            try
            {
                this.listOfVisits = this.visitController.GetListOfVisits(this.patient.PatientID);
                if (this.listOfVisits.Count > 0)
                {
                    visitDataGridView.DataSource = this.listOfVisits;
                } else
                {
                    this.listOfVisits = new List<Visit>();
                    visitDataGridView.DataSource = this.listOfVisits;
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Data Error");
            }
        
        }

        private void visitDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           try
            {
                if (e.ColumnIndex == 0 && e.RowIndex >= 0)
                {
                    int i = e.RowIndex;
                    DataGridViewRow row = visitDataGridView.Rows[i];
                    this.visit = (Visit)row.DataBoundItem;
                    AddVisitDialog.Instance().addVisitUserControl1.appointmentIDTextBox.Text = this.visit.AppointmentID + "";
                    AddVisitDialog.Instance().addVisitUserControl1.weightTextBox.Text = this.visit.Weight + "";
                    AddVisitDialog.Instance().addVisitUserControl1.temperatureTextBox.Text = visit.Temperature + "";
                    AddVisitDialog.Instance().addVisitUserControl1.systolicBPTextBox.Text = visit.SystolicBP + "";
                    AddVisitDialog.Instance().addVisitUserControl1.diastolicBPTextBox.Text = visit.DiastolicBP + "";
                    AddVisitDialog.Instance().addVisitUserControl1.pulseTextBox.Text = visit.Pulse + "";
                    AddVisitDialog.Instance().addVisitUserControl1.symptomsTextBox.Text = visit.Symptoms;
                    AddVisitDialog.Instance().addVisitUserControl1.doctorNameTextBox.Text = visit.DoctorName;
                    AddVisitDialog.Instance().addVisitUserControl1.initialDiagnosisTextBox.Text = visit.InitialDiagnosis;
                    AddVisitDialog.Instance().addVisitUserControl1.finalDiagnosisTextBox.Text = visit.FinalDiagnosis;
                    if (this.HasVisit())
                    {
                        if (visit.FinalDiagnosis != null)
                        {
                            this.DisableFields();
                            AddVisitDialog.Instance().addVisitUserControl1.btnLabTest.Enabled = true;
                            AddVisitDialog.Instance().addVisitUserControl1.nurseNameTextBox.Text = visit.NurseName;
                            AddVisitDialog.Instance().addVisitUserControl1.nurseNameTextBox.Show();
                            AddVisitDialog.Instance().addVisitUserControl1.nurseNameComboBox.Hide();

                        }
                        else
                        {
                            this.EnableFields();
                            AddVisitDialog.Instance().addVisitUserControl1.nurseNameTextBox.Hide();
                            AddVisitDialog.Instance().addVisitUserControl1.nurseNameComboBox.Show();
                            AddVisitDialog.Instance().addVisitUserControl1.nurseNameComboBox.SelectedValue = this.visit.NurseID;
                            AddVisitDialog.Instance().addVisitUserControl1.addVisitButton.Enabled = false;
                            AddVisitDialog.Instance().addVisitUserControl1.updateVisitButton.Enabled = true;
                            AddVisitDialog.Instance().addVisitUserControl1.btnLabTest.Enabled = true;
                        }
                    }
                    else
                    {
                        this.EnableFields();
                        this.visit.NurseID = this.credentialController.GetNurseByUserName(LoginForm.Instance().userNameTextBox.Text).NurseID;
                        AddVisitDialog.Instance().addVisitUserControl1.nurseNameComboBox.SelectedValue = this.visit.NurseID;
                        AddVisitDialog.Instance().addVisitUserControl1.nurseNameComboBox.SelectedText = this.visit.NurseName;
                        AddVisitDialog.Instance().addVisitUserControl1.nurseNameComboBox.Show();
                        AddVisitDialog.Instance().addVisitUserControl1.nurseNameComboBox.Enabled = false;
                        AddVisitDialog.Instance().addVisitUserControl1.nurseNameTextBox.Hide();
                        AddVisitDialog.Instance().addVisitUserControl1.initialDiagnosisTextBox.Enabled = false;
                        AddVisitDialog.Instance().addVisitUserControl1.finalDiagnosisTextBox.Enabled = false;
                        AddVisitDialog.Instance().addVisitUserControl1.addVisitButton.Enabled = true;
                        AddVisitDialog.Instance().addVisitUserControl1.updateVisitButton.Enabled = false;
                        AddVisitDialog.Instance().addVisitUserControl1.btnLabTest.Enabled = false;
                    }
                    AddVisitDialog.Instance().addVisitUserControl1.patientNameTextBox.Text = visit.PatientName;
                    AddVisitDialog.Instance().addVisitUserControl1.birthDateTextBox.Text = visit.PatientBirthDate.ToShortDateString();
                    AddVisitDialog.Instance().addVisitUserControl1.appointmentTimeTextBox.Text = visit.AppointmentTime.ToShortDateString() + " " + visit.AppointmentTime.ToShortTimeString();
                    AddVisitDialog.Instance().addVisitUserControl1.visit = this.visit;
                    AddVisitDialog.Instance().addVisitUserControl1.SetTestOrderedLabel();
                    AddVisitDialog.Instance().Show();
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        /// <summary>
        /// Allows selecting a patient from a different tab
        /// </summary>
        public void SelectPatient()
        {
            this.RefreshPatient();
            this.DisplayVistsByPatient();
        }

        private bool HasVisit()
        {
            if (this.visit.NurseID > 0 && 
                this.visit.Symptoms != null &&
                this.visit.InitialDiagnosis != null)
            {
                return true;
            } else
            {
                return false;
            }
        }
        private void DisableFields()
        {
            AddVisitDialog.Instance().addVisitUserControl1.addVisitButton.Enabled = false;
            AddVisitDialog.Instance().addVisitUserControl1.updateVisitButton.Enabled = false;
            AddVisitDialog.Instance().addVisitUserControl1.nurseNameTextBox.Enabled = false;
            AddVisitDialog.Instance().addVisitUserControl1.weightTextBox.Enabled = false;
            AddVisitDialog.Instance().addVisitUserControl1.temperatureTextBox.Enabled = false;
            AddVisitDialog.Instance().addVisitUserControl1.systolicBPTextBox.Enabled = false;
            AddVisitDialog.Instance().addVisitUserControl1.diastolicBPTextBox.Enabled = false;
            AddVisitDialog.Instance().addVisitUserControl1.symptomsTextBox.Enabled = false;
            AddVisitDialog.Instance().addVisitUserControl1.pulseTextBox.Enabled = false;
            AddVisitDialog.Instance().addVisitUserControl1.initialDiagnosisTextBox.Enabled = false;
            AddVisitDialog.Instance().addVisitUserControl1.finalDiagnosisTextBox.Enabled = false;
        }

        private void EnableFields()
        {
            AddVisitDialog.Instance().addVisitUserControl1.addVisitButton.Enabled = true;
            AddVisitDialog.Instance().addVisitUserControl1.updateVisitButton.Enabled = true;
            AddVisitDialog.Instance().addVisitUserControl1.nurseNameTextBox.Enabled = true;
            AddVisitDialog.Instance().addVisitUserControl1.nurseNameComboBox.Enabled = true;
            AddVisitDialog.Instance().addVisitUserControl1.weightTextBox.Enabled = true;
            AddVisitDialog.Instance().addVisitUserControl1.temperatureTextBox.Enabled = true;
            AddVisitDialog.Instance().addVisitUserControl1.systolicBPTextBox.Enabled = true;
            AddVisitDialog.Instance().addVisitUserControl1.diastolicBPTextBox.Enabled = true;
            AddVisitDialog.Instance().addVisitUserControl1.symptomsTextBox.Enabled = true;
            AddVisitDialog.Instance().addVisitUserControl1.pulseTextBox.Enabled = true;
            AddVisitDialog.Instance().addVisitUserControl1.initialDiagnosisTextBox.Enabled = true;
            AddVisitDialog.Instance().addVisitUserControl1.finalDiagnosisTextBox.Enabled = true;
        }
    }
}
