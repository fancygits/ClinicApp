using ClinicApp.Controller;
using ClinicApp.Model;
using ClinicApp.View;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ClinicApp.UserControls
{
    /// <summary>
    /// User Control for getting and adding patient Appointment objects
    /// </summary>
    public partial class AddAppointmentUserControl : UserControl, IUserControlSearch
    {

        private readonly PatientController patientController;
        private readonly AppointmentController appointmentController;
        public Patient patient;
        private List<Appointment> appointmentList;

        /// <summary>
        /// Constructor; initializes the User Control and the Controller objects
        /// </summary>
        public AddAppointmentUserControl()
        {
            InitializeComponent();
            this.appointmentController = new AppointmentController();
            this.patientController = new PatientController();
            //this.patient = new Patient();
        }

        private void AddAppointmentUserControl_Load(object sender, EventArgs e)
        {
            this.RefreshPage();
        }

        /// <summary>
        /// Refreshes the page with the current Patient object and gets Appointment list
        /// </summary>
        public void RefreshPage()
        {
            if (this.patient != null)
            {
                this.GetAppointmentList(this.patient.PatientID);
            }
            else
            {
                if (this.appointmentList != null)
                {
                    appointmentList.Clear();
                }
            }
        }

        private void GetAppointmentList(int patientID)
        {
            try
            {
                appointmentList = appointmentController.GetAppointmentsByPatientID(patientID);
                appointmentDataGridView.DataSource = appointmentList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void btnGetPatient_Click(object sender, EventArgs e)
        {
            int patientID = Convert.ToInt32(patientIDTextBox.Text);
            this.GetPatient(patientID);
            this.RefreshPage();

        }
        
        private void GetPatient(int patientID)
        {
            try
            {
                this.patient = this.patientController.GetPatientByID(patientID);
                if (patient != null)
                {
                    patientBindingSource.Clear();
                    patientBindingSource.Add(patient);
                }
                else
                {
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void appointmentDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                int i = e.RowIndex;
                DataGridViewRow row = appointmentDataGridView.Rows[i];
                Appointment appointment = (Appointment)row.DataBoundItem;

                AddUpdateAppointmentDialog addApptForm = new AddUpdateAppointmentDialog();
                addApptForm.patient = this.patient;
                addApptForm.appointment = appointment;
                addApptForm.addAppointment = false;
                addApptForm.ShowDialog();
                this.RefreshPage();
            }
        }

        private void btnAddAppointment_Click(object sender, EventArgs e)
        {
            AddUpdateAppointmentDialog addApptForm = new AddUpdateAppointmentDialog();
            addApptForm.patient = this.patient;
            addApptForm.addAppointment = true;
            addApptForm.ShowDialog();
            this.RefreshPage();
        }

        private void btnSearchPatient_Click(object sender, EventArgs e)
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
                patientBindingSource.Clear();
                patientBindingSource.Add(patient);
                this.RefreshPage();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }

        }

        /// <summary>
        /// Displays a dialog of matching patients
        /// </summary>
        /// <param name="patientList"></param>
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
    }
}
