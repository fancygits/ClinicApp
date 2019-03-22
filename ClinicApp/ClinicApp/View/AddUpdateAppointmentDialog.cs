using System;
using System.Collections.Generic;
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

        /// <summary>
        /// Constructor for Form; initializes instance variables
        /// </summary>
        public AddUpdateAppointmentDialog()
        {
            InitializeComponent();
            this.appointmentController = new AppointmentController();
            this.doctorController = new DoctorController();
            this.newAppointment = new Appointment();
        }

        private void AddUpdateAppointmentDialog_Load(object sender, EventArgs e)
        {
            this.LoadComboBoxes();
            txtBxfirstName.Text = this.patient.FirstName;
            txtBxLastName.Text = this.patient.LastName;
            timePickerBirthDate.Value = this.patient.BirthDate;
            
            if (!this.addAppointment)
            {
                dateTimePickerAppointmentDate.Value = this.appointment.AppointmentDateTime;
                dateTimePickerAppointmentTime.Value = this.appointment.AppointmentDateTime;
                cmboBoxDoctorID.SelectedValue = this.appointment.AppointmentDoctorID;
                txtBoxAppointmentReason.Text = this.appointment.AppointmentReason;
                this.PutAppointment();
                btnAdd.Enabled = false;
                if (this.appointment.AppointmentDateTime < DateTime.Now)
                {
                    btnUpdate.Enabled = false;
                    dateTimePickerAppointmentDate.Enabled = false;
                    dateTimePickerAppointmentTime.Enabled = false;
                    cmboBoxDoctorID.Enabled = false;
                    txtBoxAppointmentReason.Enabled = false;
                }
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
