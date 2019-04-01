using ClinicApp.DAL;
using ClinicApp.Model;
using System.Collections.Generic;


namespace ClinicApp.Controller
{
    /// <summary>
    /// Defines the NurseController
    /// </summary>
    public class NurseController
    {
        /// <summary>
        /// Returns a list of Nurse objects from the DAL
        /// </summary>
        /// <returns></returns>
        public List<Nurse> GetNurseList()
        {
           return NurseDAL.GetNurseList();
        }
    }
}
