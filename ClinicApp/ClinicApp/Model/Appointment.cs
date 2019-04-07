using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.Model
{
    /// <summary>
    /// Properties with get/set for Appointment object
    /// </summary>
    public class Appointment
    {
        public int AppointmentID { get; set; }
        public int AppointmentPatientID { get; set; }
        public int AppointmentDoctorID { get; set; }
        public string AppointmentDoctorFirstName { get; set; }
        public string AppointmentDoctorLastName { get; set; }
        public DateTime AppointmentDateTime { get; set; }
        public string AppointmentReason { get; set; }
    }
}
