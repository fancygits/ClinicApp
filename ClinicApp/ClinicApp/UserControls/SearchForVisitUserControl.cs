using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ClinicApp.Model;
using ClinicApp.Controller;
using ClinicApp.View;

namespace ClinicApp.UserControls
{
    public partial class SearchForVisitUserControl : UserControl
    {
        private VisitController visitController;
        public Patient patient;
        public Visit visit;
        private List<Patient> listOfPatients;
        private List<Visit> listOfVisits;
        private static SearchForVisitUserControl instance;
        private SearchForVisitUserControl()
        {
            InitializeComponent();
            this.listOfPatients = new List<Patient>();
            this.listOfVisits = new List<Visit>();
            this.visitController = new VisitController();

        }

        public static SearchForVisitUserControl Instance()
        {
            if (instance == null)
            {
                instance = new SearchForVisitUserControl();
            }
            return instance;
        }

        /// <summary>
        /// This method will display the visits by the patient that is selected
        /// </summary>
        public void DisplayVistsByPatient()
        {
            if(this.patientNameComboBox.SelectedIndex < 0)
            {
                return;
            }
            this.patient = this.listOfPatients[this.patientNameComboBox.SelectedIndex];
            patientBindingSource.Clear();
            patientBindingSource.Add(this.patient);
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

        public void PopulateComboBox()
        {
            this.listOfPatients = this.visitController.GetPatients();
            this.patientNameComboBox.DataSource = this.listOfPatients;
        }

        private void SearchForVisitUserControl_Load(object sender, EventArgs e)
        {
            this.PopulateComboBox();
        }

        private void patientNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.DisplayVistsByPatient();
        }

        private void visitDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 14)
            {
                int i = e.RowIndex;
                DataGridViewRow row = visitDataGridView.Rows[i];
                this.visit = (Visit)row.DataBoundItem;
                AddVisitDialog addVisitDialog = new AddVisitDialog();

                addVisitDialog.addVisitUserControl1.appointmentIDTextBox.Text = this.visit.AppointmentID + "";
                addVisitDialog.addVisitUserControl1.weightTextBox.Text = this.visit.Weight + "";
                addVisitDialog.addVisitUserControl1.temperatureTextBox.Text = visit.Temperature + "";
                addVisitDialog.addVisitUserControl1.systolicBPTextBox.Text = visit.SystolicBP + "";
                addVisitDialog.addVisitUserControl1.diastolicBPTextBox.Text = visit.DiastolicBP + "";
                addVisitDialog.addVisitUserControl1.pulseTextBox.Text = visit.Pulse + "";
                addVisitDialog.addVisitUserControl1.symptomsTextBox.Text = visit.Symptoms;
                addVisitDialog.addVisitUserControl1.doctorNameTextBox.Text = visit.DoctorName;
                if (this.visit.NurseID > 0)
                {
                    if (visit.FinalDiagnosis != null)
                    {
                        addVisitDialog.addVisitUserControl1.addVisitButton.Enabled = false;
                        addVisitDialog.addVisitUserControl1.updateVisitButton.Enabled = false;
                        addVisitDialog.addVisitUserControl1.nurseNameTextBox.Enabled = false;
                        addVisitDialog.addVisitUserControl1.weightTextBox.Enabled = false;
                        addVisitDialog.addVisitUserControl1.temperatureTextBox.Enabled = false;
                        addVisitDialog.addVisitUserControl1.systolicBPTextBox.Enabled = false;
                        addVisitDialog.addVisitUserControl1.diastolicBPTextBox.Enabled = false;
                        addVisitDialog.addVisitUserControl1.symptomsTextBox.Enabled = false;
                        addVisitDialog.addVisitUserControl1.pulseTextBox.Enabled = false;
                        addVisitDialog.addVisitUserControl1.nurseNameTextBox.Text = visit.NurseName;
                        addVisitDialog.addVisitUserControl1.nurseNameTextBox.Show();
                        addVisitDialog.addVisitUserControl1.nurseNameComboBox.Hide();

                    }
                    else
                    {
                        addVisitDialog.addVisitUserControl1.nurseNameTextBox.Hide();
                        addVisitDialog.addVisitUserControl1.nurseNameComboBox.Show();
                        addVisitDialog.addVisitUserControl1.nurseNameComboBox.SelectedValue = visit.NurseID;
                        addVisitDialog.addVisitUserControl1.addVisitButton.Enabled = false;
                        addVisitDialog.addVisitUserControl1.updateVisitButton.Enabled = true;
                    }
                } else
                {
                    addVisitDialog.addVisitUserControl1.nurseNameComboBox.Show();
                    addVisitDialog.addVisitUserControl1.nurseNameTextBox.Hide();
                    addVisitDialog.addVisitUserControl1.addVisitButton.Enabled = true;
                    addVisitDialog.addVisitUserControl1.updateVisitButton.Enabled = false;
                }
                addVisitDialog.addVisitUserControl1.patientNameTextBox.Text = visit.PatientName;
                addVisitDialog.addVisitUserControl1.birthDateTextBox.Text = visit.PatientBirthDate.ToShortDateString();
                addVisitDialog.addVisitUserControl1.appointmentTimeTextBox.Text = visit.AppointmentTime.ToShortDateString() + " " + visit.AppointmentTime.ToShortTimeString();
                addVisitDialog.addVisitUserControl1.visit = this.visit;
                addVisitDialog.Show();
            }
        }
    }
}
