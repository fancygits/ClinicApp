using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ClinicApp.Controller;
using ClinicApp.Model;

namespace ClinicApp.UserControls
{
    public partial class AddAppointmentUserControl : UserControl
    {

        private readonly DoctorController doctorController;
        private List<Doctor> doctorList;

        /// <summary>
        /// Constructor; initializes the User Control and the Controller objects
        /// </summary>
        public AddAppointmentUserControl()
        {
            InitializeComponent();
            this.doctorController = new DoctorController();
        }

        private void AddAppointmentUserControl_Load(object sender, EventArgs e)
        {
            this.RefreshPage();
        }

        public void RefreshPage()
        {
            this.GetDoctorList();
        }
        private void GetDoctorList()
        {
            try
            {
                doctorList = doctorController.GetDoctorList();
                //doctorDataGridView.DataSource = doctorList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }
    }
}
