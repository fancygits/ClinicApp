using ClinicApp.DAL;
using ClinicApp.Model;
using System.Collections.Generic;

namespace ClinicApp.Controller
{
    class VisitController
    {
        public string GetNurse(int nurseID)
        {
            return VisitDAL.GetNurse(nurseID);
        }

        public List<Visit> GetNurses()
        {
            return VisitDAL.GetNurses();
        }
        public bool UpdateVisit(Visit oldVisit, Visit newVisit)
        {
            return VisitDAL.UpdateVisit(oldVisit, newVisit);
        }

        public bool AddVisit(Visit newVisit)
        {
            return VisitDAL.AddVisit(newVisit);
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
