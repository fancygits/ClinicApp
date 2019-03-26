
using System;
using System.Collections.Generic;
using ClinicApp.Model;
using ClinicApp.DAL;

namespace ClinicApp.Controller
{
    /// <summary>
    /// Controller for the Appointment class
    /// </summary>
    public class AppointmentController
    {
        /// <summary>
        /// Returns a list of Appointments by PatientID
        /// </summary>
        /// <param name="patientID">Patient ID</param>
        /// <returns></returns>
        public List<Appointment> GetAppointmentsByPatientID(int patientID)
        {
            return AppointmentDAL.GetAppointmentsByPatientID(patientID);
        }

        /// <summary>
        /// Adds new Appintment object information to the database
        /// </summary>
        /// <param name="appointment">Appointment to be added</param>
        /// <returns>Newly added Appointment appointmentID</returns>
        public int AddAppointment(Appointment appointment)
        {
            return AppointmentDAL.AddAppointment(appointment);
        }

        /// <summary>
        /// Updates the database with new Appointment object information
        /// </summary>
        /// <param name="appointment">Current Appointment object info</param>
        /// <param name="newAppointment">New Appointment object info to update</param>
        /// <returns>True if update is performed</returns>
        public bool UpdateAppointment(Appointment appointment, Appointment newAppointment)
        {
            return AppointmentDAL.UpdateAppointment(appointment, newAppointment);
        }

        /// <summary>
        /// Checks doctorID and apptDateTime of incoming Appointment to make sure the doctor is not doublebooked;
        /// 
        /// </summary>
        /// <param name="doctorID"></param>
        /// <param name="apptDateTime"></param>
        /// <returns>Returns true if there's a match, false if not</returns>
        public bool CheckDoubleBooking(int doctorID, DateTime apptDateTime)
        {
            return AppointmentDAL.CheckDoubleBooking(doctorID, apptDateTime);
        }
    }
}
