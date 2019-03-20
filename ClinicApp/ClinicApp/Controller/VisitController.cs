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
        public List<Visit> GetNurses()
        {
            return VisitDAL.GetNurses();
        }

        public List<Visit> GetDoctors()
        {
            return VisitDAL.GetDoctors();
        }
        
        public List<Visit> GetPatients()
        {
            return VisitDAL.GetPatients();
        }
    }
}
