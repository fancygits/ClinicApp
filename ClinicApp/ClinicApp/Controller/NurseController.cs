using ClinicApp.DAL;
using ClinicApp.Model;

namespace ClinicApp.Controller
{
    class NurseController
    {

        public Nurse GetNurse(int nurseID)
        {
            return NurseDAL.GetNurse(nurseID);
        }
    }
}
