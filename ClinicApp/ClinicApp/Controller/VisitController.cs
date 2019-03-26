using ClinicApp.DAL;
using ClinicApp.Model;
using System.Collections.Generic;

namespace ClinicApp.Controller
{
    class VisitController
    {
        public Nurse GetNurse(int nurseID)
        {
            return VisitDAL.GetNurse(nurseID);
        }

        public List<Nurse> GetNurses()
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
        public Doctor GetDoctor(int doctorID)
        {
            return VisitDAL.GetDoctor(doctorID);
        }
        
        public List<Patient> GetPatients()
        {
            return VisitDAL.GetPatients();
        }
        public List<Visit> GetListOfVisits(int patientID)
        {
            return VisitDAL.GetListOfVisits(patientID);
        }
    }
}
