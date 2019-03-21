using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicApp.Model;
using ClinicApp.Controller;
using ClinicApp.View;

namespace ClinicApp.UserControls
{
    public partial class SearchForVisitUserControl : UserControl
    {
        private VisitController visitController;
        private Visit visit;
        private List<Visit> listOfPatients;
        private List<Visit> listOfVisits;
        public SearchForVisitUserControl()
        {
            InitializeComponent();
            this.listOfPatients = new List<Visit>();
            this.listOfVisits = new List<Visit>();
            this.visitController = new VisitController();

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
            this.visit = this.listOfPatients[this.patientNameComboBox.SelectedIndex];
            visitBindingSource.Clear();
            visitBindingSource.Add(this.visit);
            try
            {
                this.listOfVisits = this.visitController.GetListOfVisits(this.visit.PatientID);
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
            if (e.ColumnIndex == 13)
            {
                int i = e.RowIndex;
                DataGridViewRow row = visitDataGridView.Rows[i];
                Visit visit = (Visit)row.DataBoundItem;
                AddVisitDialog addVisitDialog = new AddVisitDialog();
                addVisitDialog.addVisitUserControl1.appointmentIDTextBox.Text = visit.AppointmentID + "";
                addVisitDialog.addVisitUserControl1.weightTextBox.Text = visit.Weight + "";
                addVisitDialog.addVisitUserControl1.temperatureTextBox.Text = visit.Temperature + "";
                addVisitDialog.addVisitUserControl1.systolicBPTextBox.Text = visit.SystolicBP + "";
                addVisitDialog.addVisitUserControl1.diastolicBPTextBox.Text = visit.DiastolicBP + "";
                addVisitDialog.addVisitUserControl1.pulseTextBox.Text = visit.Pulse + "";
                addVisitDialog.addVisitUserControl1.symptomsTextBox.Text = visit.Symptoms;
                addVisitDialog.addVisitUserControl1.doctorNameTextBox.Text = visit.DoctorName;
                addVisitDialog.addVisitUserControl1.nurseNameTextBox.Text = visit.NurseName;
                addVisitDialog.addVisitUserControl1.patientNameTextBox.Text = visit.PatientName;
                addVisitDialog.addVisitUserControl1.birthDateTextBox.Text = visit.PatientBirthDate.ToShortDateString();
                addVisitDialog.addVisitUserControl1.appointmentTimeTextBox.Text = visit.AppointmentTime.ToShortDateString() + " " + visit.AppointmentTime.ToShortTimeString();

                addVisitDialog.Show();
            }
        }
    }
}
