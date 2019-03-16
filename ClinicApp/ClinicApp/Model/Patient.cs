using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.Model
{
    /// <summary>
    ///  Properties with get/set for Patient attributes
    /// </summary>
    public class Patient
    {
        public int PatientID { get; set; }
        public int PatientPersonID { get; set; }
        public string PatientFirstName { get; set; }
        public string PatientLastName { get; set; }
        public DateTime PatientBirthDate { get; set; }
        public string PatientSSN { get; set; }
        public char PatientGender { get; set; }
        public string PatientStreetAddress { get; set; }
        public string PatientCity { get; set; }
        public string PatientState { get; set; }
        public string PatientPostCode { get; set; }
        public string PatientPhoneNumber { get; set; }


    }
}
