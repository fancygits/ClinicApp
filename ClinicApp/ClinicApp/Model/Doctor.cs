using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.Model
{
    /// <summary>
    /// Properties with get/set for Doctor attributes
    /// </summary>
    public class Doctor
    {
        public int DoctorID { get; set; }
        public int DoctorPersonID { get; set; }
        public string DoctorFirstName { get; set; }
        public string DoctorLastName { get; set; }
    }
}
