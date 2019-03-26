﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public int AddAppointment(Appointment appointment)
        {
            return AppointmentDAL.AddAppointment(appointment);
        }
    }
}
