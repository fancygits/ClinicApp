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
        /// Gets a Nurse by the NurseID
        /// </summary>
        /// <param name="nurseID"></param>
        /// <returns>A Nurses</returns>
        public Nurse GetNurseByID(int nurseID)
        {
            return NurseDAL.GetNurseByID(nurseID);
        }

        /// <summary>
        /// Gets a Nurse by full name and birthDate
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="birthDate"></param>
        /// <returns>A Nurse</returns>
        public Nurse GetNurseByName(string firstName, string lastName, string birthDate)
        {
            return NurseDAL.GetNurseByName(firstName, lastName, birthDate);
        }

        /// <summary>
        /// Searches Nurses by name and birthdate
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="birthDate"></param>
        /// <returns>A List of Nurses</returns>
        public List<Nurse> SearchNursesByName(string firstName, string lastName, string birthDate)
        {
            return NurseDAL.SearchNursesByName(firstName, lastName, birthDate);
        }

        /// <summary>
        /// Updates a Nurse
        /// </summary>
        /// <param name="oldNurse"></param>
        /// <param name="newNurse"></param>
        /// <returns>True if update was successful</returns>
        public bool UpdateNurse(Nurse oldNurse, Nurse newNurse)
        {
            return PersonDAL.UpdatePerson(oldNurse, newNurse);
        }

        /// <summary>
        /// Adds a new Nurse
        /// </summary>
        /// <param name="nurse">The Nurse to add</param>
        /// <returns>The new NurseID</returns>
        public int AddNurse(Nurse nurse)
        {
            return NurseDAL.AddNurse(nurse);
        }

        /// <summary>
        /// Inserts an existing Person as a nurse
        /// </summary>
        /// <param name="personID">The PersonID of the new nurse</param>
        /// <returns>The new NurseID</returns>
        public int InsertNurse(int personID)
        {
            return NurseDAL.InsertNurse(personID);
        }

        /// <summary>
        /// Retrieves the PersonID from the database or -1 if not found
        /// According to statistics, the full name and date of birth can stil lead to multiple results.
        /// </summary>
        /// <param name="firstName">Person's first name</param>
        /// <param name="lastName">Person's last name</param>
        /// <param name="birthDate">Person's birthdate</param>
        /// <param name="SSN">Person's SSN</param>
        /// <returns></returns>
        public int GetPersonID(string firstName, string lastName, string birthDate, string SSN)
        {
            return PersonDAL.GetPersonID(firstName, lastName, birthDate, SSN);
        }
    }
}
