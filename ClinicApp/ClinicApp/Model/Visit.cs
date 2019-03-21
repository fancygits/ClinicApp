using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.Model
{
    class Visit
    {
        public Appointment VisitAppointment { get; set; }
        public int AppointmentID { get; set; }
        public DateTime AppointmentTime { get; set; }
        public int DoctorID { get; set; }
        public string DoctorName { get; set; }
        public decimal Weight { get; set; }
        public int SystolicBP { get; set; }
        public int DiastolicBP { get; set; }
        public decimal Temperature { get; set; }
        public int Pulse { get; set; }
        public string Symptoms { get; set; }
        public string InitialDiagnosis { get; set; }
        public string FinalDiagnosis { get; set; }
        public Nurse VisitNurse { get; set; }
        public int NurseID { get; set; }
        public string NurseName { get; set; }
        public Patient VisitPatient { get; set; }
        public int PatientID { get; set; }
        public string PatientName { get; set; }
        public DateTime PatientBirthDate { get; set; }
    }


}
