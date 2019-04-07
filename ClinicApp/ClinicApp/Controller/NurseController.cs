using ClinicApp.DAL;
using ClinicApp.Model;
using System.Collections.Generic;

namespace ClinicApp.Controller
{
    class NurseController
    {
        public List<Nurse> GetNurseList()
        {
           return NurseDAL.GetNurseList();
        }

        /// <summary>
        /// Gets a list of US States and Canadian Provinces
        /// </summary>
        /// <returns>A List of States</returns>
        public List<State> GetStateList()
        {
            return StateList.list;
        }
    }
}
