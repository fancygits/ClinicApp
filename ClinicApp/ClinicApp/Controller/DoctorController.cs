using System.Collections.Generic;
using ClinicApp.Model;
using ClinicApp.DAL;

namespace ClinicApp.Controller
{
    /// <summary>
    /// Controller for the Doctor class
    /// </summary>
    public class DoctorController
    {
        /// <summary>
        /// Returns a list of Doctor objects from DAL
        /// </summary>
        /// <returns></returns>
        public List<Doctor> GetDoctorList()
        {
            return DoctorDAL.GetDoctorList();
        }
    }
}
