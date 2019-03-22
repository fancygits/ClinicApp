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
        public bool addAppointment;
        public Appointment appointment;
        public Patient patient;
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
            this.newAppointment = new Appointment();
            txtBxfirstName.Text = patient.FirstName;
            txtBxLastName.Text = patient.LastName;
            timePickerBirthDate.Value = patient.BirthDate;
            
            if (!this.addAppointment)
            {
                this.PutAppointment();
                btnAdd.Enabled = false;
            }
            else
            {
                btnUpdate.Enabled = false;
            }
           
        }

        private void LoadComboBoxes()
        {
            try
            {
                this.doctorList = doctorController.GetDoctorList();
                cmboBoxDoctorID.DataSource = this.doctorList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void PutAppointment()
        {
            newAppointment.AppointmentPatientID = appointment.AppointmentPatientID;
            newAppointment.AppointmentDoctorID = appointment.AppointmentDoctorID;
            newAppointment.AppointmentDateTime = appointment.AppointmentDateTime;
            newAppointment.AppointmentReason = appointment.AppointmentReason;
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
            this.PutAppointmentData(this.newAppointment);
            this.appointmentController.AddAppointment(new Appointment());
        }
    }
}
