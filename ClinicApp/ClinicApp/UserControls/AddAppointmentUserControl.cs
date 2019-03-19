using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ClinicApp.Controller;
using ClinicApp.Model;

namespace ClinicApp.UserControls
{
    public partial class AddAppointmentUserControl : UserControl
    {

        private readonly AppointmentController appointmentController;
        private List<Appointment> appointmentList;

        /// <summary>
        /// Constructor; initializes the User Control and the Controller objects
        /// </summary>
        public AddAppointmentUserControl()
        {
            InitializeComponent();
            this.appointmentController = new AppointmentController();
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
    }
}
