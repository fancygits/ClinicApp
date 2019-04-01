using ClinicApp.DAL;
using ClinicApp.Model;
using System.Collections.Generic;

namespace ClinicApp.Controller
{
    /// <summary>
    /// Defines the VisitController
    /// </summary>
    public class VisitController
    {
        /// <summary>
        /// Returns a Nurse based on nurseID
        /// </summary>
        /// <param name="nurseID"></param>
        /// <returns></returns>
        public Nurse GetNurse(int nurseID)
        {
            return VisitDAL.GetNurse(nurseID);
        }

        /// <summary>
        /// Gets a List of Nurses from DAL
        /// </summary>
        /// <returns></returns>
        public List<Nurse> GetNurses()
        {
            return NurseDAL.GetNurseList();
        }

        /// <summary>
        /// Updates the db with new Visit information
        /// </summary>
        /// <param name="oldVisit"></param>
        /// <param name="newVisit"></param>
        /// <returns></returns>
        public bool UpdateVisit(Visit oldVisit, Visit newVisit)
        {
            return VisitDAL.UpdateVisit(oldVisit, newVisit);
        }

        /// <summary>
        /// Adds a new Visit to the db
        /// </summary>
        /// <param name="newVisit"></param>
        /// <returns></returns>
        public bool AddVisit(Visit newVisit)
        {
            return VisitDAL.AddVisit(newVisit);
        }

        /// <summary>
        /// Gets a Doctor based on doctorID
        /// </summary>
        /// <param name="doctorID"></param>
        /// <returns></returns>
        public Doctor GetDoctor(int doctorID)
        {
            return VisitDAL.GetDoctor(doctorID);
        }

        /// <summary>
        /// Gets a list of Patients from the db
        /// </summary>
        /// <returns></returns>
        public List<Patient> GetPatients()
        {
            return VisitDAL.GetPatients();
        }

        /// <summary>
        /// Gets a list of Visits based on patientID
        /// </summary>
        /// <param name="patientID"></param>
        /// <returns></returns>
        public List<Visit> GetListOfVisits(int patientID)
        {
            return VisitDAL.GetListOfVisits(patientID);
        }
    }
}
