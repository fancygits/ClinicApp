using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicApp.Controller;
using ClinicApp.Model;

namespace ClinicApp.UserControls
{
    /// <summary>
    /// User Control to interface with Appointment functionality
    /// </summary>
    public partial class AppointmentUserControl : UserControl
    {
        private readonly DoctorController doctorController;
        private List<Doctor> doctorList;
        
        /// <summary>
        /// Constructor; initializes the User Control and the Controller objects
        /// </summary>
        public AppointmentUserControl()
        {
            InitializeComponent();
            this.doctorController = new DoctorController();
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
                doctorDataGridView.DataSource = doctorList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void AppointmentUserControl_Load(object sender, EventArgs e)
        {
            this.RefreshPage();
        }
    }
}
