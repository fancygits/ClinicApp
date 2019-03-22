using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicApp.Model;
using ClinicApp.Controller;

namespace ClinicApp.View
{
    /// <summary>
    /// The Add/Update Form for the Appointment object.  If Appointment is not null, fills form and allows update.  If it is null, creates a new object.
    /// </summary>
    public partial class AddUpdateAppointmentDialog : Form
    {
        private AppointmentController appointmentController;
        private DoctorController doctorController;
        public Appointment appointment;
        private Appointment newAppointment;
        private List<Doctor> doctorList;
        public AddUpdateAppointmentDialog()
        {
            InitializeComponent();
            this.appointmentController = new AppointmentController();
            this.doctorController = new DoctorController();
        }

        private void AddUpdateAppointmentDialog_Load(object sender, EventArgs e)
        {
            this.LoadComboBoxes();
        }

        private void LoadComboBoxes()
        {
            try
            {
                this.doctorList = doctorController.GetDoctorList();
                doctorIDComboBox.DataSource = this.doctorList;
                //this.PutNewAppointment();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void PutAppointmentData(Appointment appointment)
        {
            //MessageBox.Show(this.appointment.AppointmentReason.ToString());
            appointment.AppointmentID = appointment.AppointmentID;
            appointment.AppointmentPatientID = appointment.AppointmentPatientID;
            appointment.AppointmentReason = appointment.AppointmentReason;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Appointment newAppointment = new Appointment();
            this.PutAppointmentData(newAppointment);
            this.appointmentController.AddAppointment(new Appointment());
        }
    }
}
