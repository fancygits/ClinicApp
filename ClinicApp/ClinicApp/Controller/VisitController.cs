using ClinicApp.DAL;
using ClinicApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.Controller
{
    class VisitController
    {
        public string GetNurse(int nurseID)
        {
            return VisitDAL.GetNurse(nurseID);
        }

        public string GetDoctor(int doctorID)
        {
            return VisitDAL.GetDoctor(doctorID);
        }
        
        public List<Visit> GetPatients()
        {
            return VisitDAL.GetPatients();
        }
        public List<Visit> GetListOfVisits(int patientID)
        {
            return VisitDAL.GetListOfVisits(patientID);
        }
    }
}
