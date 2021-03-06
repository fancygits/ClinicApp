﻿using ClinicApp.Controller;
using ClinicApp.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ClinicApp.View
{
    /// <summary>
    /// The Add/Update Form for the Appointment object.  If Appointment is not null, fills form and allows update.  If it is null, creates a new object.
    /// </summary>
    public partial class AddUpdateAppointmentDialog : Form
    {
        private readonly AppointmentController appointmentController;
        private readonly DoctorController doctorController;
        public bool addAppointment;
        public Appointment appointment;
        public Patient patient;
        private Appointment newAppointment;
        private ErrorProvider errorProvider;

        /// <summary>
        /// Constructor for Form; initializes instance variables
        /// </summary>
        public AddUpdateAppointmentDialog()
        {
            InitializeComponent();
            this.appointmentController = new AppointmentController();
            this.doctorController = new DoctorController();
            this.newAppointment = new Appointment();
            this.errorProvider = new ErrorProvider();
        }

        private void AddUpdateAppointmentDialog_Load(object sender, EventArgs e)
        {
            this.LoadComboBoxes();
            this.DisplayAppointment();
           
        }

        private void DisplayAppointment()
        {
            txtBxfirstName.Text = this.patient.FirstName;
            txtBxLastName.Text = this.patient.LastName;
            timePickerBirthDate.Value = this.patient.BirthDate;

            if (!this.addAppointment)
            {
                dateTimePickerAppointmentDate.MinDate = DateTimePicker.MinimumDateTime;
                dateTimePickerAppointmentDate.Value = this.appointment.AppointmentDateTime;
                dateTimePickerAppointmentTime.Value = this.appointment.AppointmentDateTime;
                cmboBoxDoctorID.SelectedValue = this.appointment.AppointmentDoctorID;
                txtBoxAppointmentReason.Text = this.appointment.AppointmentReason;
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
                dateTimePickerAppointmentDate.MinDate = DateTime.Today;
                btnUpdate.Enabled = false;
            }
        }

        private void LoadComboBoxes()
        {
            try
            {
                List<Doctor> doctorList = new List<Doctor>();
                doctorList = doctorController.GetDoctorList();
                cmboBoxDoctorID.DataSource = doctorList;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private bool PutAppointment()
        {
            bool isPut = false;
            newAppointment.AppointmentPatientID = this.patient.PatientID;
            newAppointment.AppointmentDoctorID = (int)cmboBoxDoctorID.SelectedValue;
            if (CombineDateTime(dateTimePickerAppointmentDate.Value, dateTimePickerAppointmentTime.Value) > DateTime.Now)
            {
                newAppointment.AppointmentDateTime = CombineDateTime(dateTimePickerAppointmentDate.Value, dateTimePickerAppointmentTime.Value);
                if (Validator.IsPresent(txtBoxAppointmentReason, errorProvider))
                {
                    newAppointment.AppointmentReason = txtBoxAppointmentReason.Text;
                    isPut = true;
                }
                else
                {
                    isPut = false;
                }
            }  
            else
            {
                errorProvider.SetError(dateTimePickerAppointmentTime, "Please select a valid time");
                dateTimePickerAppointmentTime.Focus();
            }
            return isPut;

        }

        private DateTime CombineDateTime(DateTime date, DateTime time)
        {
            return date.Date + time.TimeOfDay;
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (this.PutAppointment())
            {
                if (!this.appointmentController.CheckDoubleBooking(this.newAppointment.AppointmentDoctorID, this.newAppointment.AppointmentDateTime))
                {
                    try
                    {
                        this.newAppointment.AppointmentID = this.appointmentController.AddAppointment(this.newAppointment);
                        this.appointment = this.newAppointment;
                        this.DialogResult = DialogResult.OK;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, ex.GetType().ToString());
                    }
                }
                else
                {
                    MessageBox.Show("This Doctor is already booked for " + this.newAppointment.AppointmentDateTime.ToShortTimeString() +
                        ". Please choose a different time.");
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (this.PutAppointment())
            {
                // Gets around the DoctorID Appointment DateTime constraint to update the visitReason on an existing appointment
                if (this.newAppointment.AppointmentDoctorID == this.appointment.AppointmentDoctorID && this.newAppointment.AppointmentDateTime == this.appointment.AppointmentDateTime)
                {
                    try
                    {
                        this.newAppointment.AppointmentDateTime = this.newAppointment.AppointmentDateTime.AddSeconds(1);
                        if (!this.appointmentController.UpdateAppointment(this.appointment, this.newAppointment))
                        {
                            MessageBox.Show("Another user has updated this Appointment. Please modify and try again", "Database Error");
                        }
                        else
                        {
                            //MessageBox.Show("Appointment Updated");
                            this.appointment = this.newAppointment;
                            this.DialogResult = DialogResult.OK;
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, ex.GetType().ToString());
                    }
                }
                else if (!this.appointmentController.CheckDoubleBooking(this.newAppointment.AppointmentDoctorID, this.newAppointment.AppointmentDateTime))
                {
                    try
                    {
                        if (!this.appointmentController.UpdateAppointment(this.appointment, this.newAppointment))
                        {
                            MessageBox.Show("Another user has updated this Appointment. Please modify and try again", "Database Error");
                        }
                        else
                        {
                            //MessageBox.Show("Appointment Updated");
                            this.appointment = this.newAppointment;
                            this.DialogResult = DialogResult.OK;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, ex.GetType().ToString());
                    }
                }
                else
                {
                    MessageBox.Show("This Doctor is already booked for " + this.newAppointment.AppointmentDateTime.ToShortTimeString() +
                        ". Please choose a different time.");
                }
            }

        }

    }
}
