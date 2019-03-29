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
                MessageBox.Show("hello from inside else");
                if (this.appointmentList != null)
                {
                    MessageBox.Show("hello from inside if");
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

        private void Clear()
        {
            patientBindingSource.Clear();
            birthDateDateTimePicker.Text = "";
            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
            appointmentDataGridView.DataSource = null;
            appointmentDataGridView.Refresh();
            firstNameTextBox.Focus();
        }

        //private void btnGetPatient_Click(object sender, EventArgs e)
        //{
        //    int patientID = Convert.ToInt32(patientIDTextBox.Text);
        //    this.GetPatient(patientID);
        //    this.RefreshPage();

        //}
        
        //private void GetPatient(int patientID)
        //{
        //    try
        //    {
        //        this.patient = this.patientController.GetPatientByID(patientID);
        //        if (patient != null)
        //        {
        //            patientBindingSource.Clear();
        //            patientBindingSource.Add(patient);
        //        }
        //        else
        //        {
                    
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, ex.GetType().ToString());
        //    }
        //}

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
            this.patient = this.FindPatient(firstName, lastName, birthDate);
            if (this.patient != null)
            {
                patientBindingSource.Clear();
                patientBindingSource.Add(patient);
                this.RefreshPage();
            }
           else
            {
                this.NoMatchesDialog();
            }
        }

        /// <summary>
        /// Displays a dialog of matching patients
        /// </summary>
        /// <param name="patientList"></param>


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

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.Clear();
        }
    }
}
