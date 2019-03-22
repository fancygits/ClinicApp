using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ClinicApp.Controller;
using ClinicApp.Model;
using ClinicApp.View;

namespace ClinicApp.UserControls
{
    /// <summary>
    /// User Control for getting and adding patient Appointment objects
    /// </summary>
    public partial class AddAppointmentUserControl : UserControl
    {

        private readonly PatientController patientController;
        private readonly AppointmentController appointmentController;
        private Patient patient;
        private List<Appointment> appointmentList;

        /// <summary>
        /// Constructor; initializes the User Control and the Controller objects
        /// </summary>
        public AddAppointmentUserControl()
        {
            InitializeComponent();
            this.appointmentController = new AppointmentController();
            this.patientController = new PatientController();
            this.patient = new Patient();
        }

        private void AddAppointmentUserControl_Load(object sender, EventArgs e)
        {
            //this.RefreshPage();
        }

        public void RefreshPage()
        {
            this.GetAppointmentList(9);
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
                
            if (this.patient != null)
            {
                this.GetAppointmentList(patientID);
            }
            else
            {
                if (this.appointmentList != null)
                {
                    appointmentList.Clear();
                }
            }

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
            }
        }

        private void btnAddAppointment_Click(object sender, EventArgs e)
        {
            AddUpdateAppointmentDialog addApptForm = new AddUpdateAppointmentDialog();
            addApptForm.patient = this.patient;
            addApptForm.addAppointment = true;
            addApptForm.ShowDialog();
        }
    }
}
