using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ClinicApp.Controller;
using ClinicApp.Model;

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
        }

        private void AddAppointmentUserControl_Load(object sender, EventArgs e)
        {
            this.RefreshPage();
        }

        public void RefreshPage()
        {
            this.GetAppointmentList(5);
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

        private void appointmentDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
