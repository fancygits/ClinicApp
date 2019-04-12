﻿using ClinicApp.DAL;
using ClinicApp.Model;
using System.Collections.Generic;

namespace ClinicApp.Controller
{
    /// <summary>
    /// Defines the PatientController
    /// </summary>
    public class PatientController
    {
        /// <summary>
        /// Gets a list of all Patients
        /// </summary>
        /// <returns>A List of Patients</returns>
        public List<Patient> GetPatientList()
        {
            return PatientDAL.GetPatientList();
        }

        /// <summary>
        /// Gets a Patient by the PatientID
        /// </summary>
        /// <param name="patientID"></param>
        /// <returns>A Patients</returns>
        public Patient GetPatientByID(int patientID)
        {
            return PatientDAL.GetPatientByID(patientID);
        }

        /// <summary>
        /// Gets a Patient matching a birth date. 
        /// </summary>
        /// <param name="birthDate">The birth date to search</param>
        /// <returns>A Patient or null if none or multiple patients are found.</returns>
        public Patient GetPatientByBirthDate(string birthDate)
        {
            return PatientDAL.GetPatientByBirthDate(birthDate);
        }

        /// <summary>
        /// Gets a Patient by full name and birthDate
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <returns>A Patient</returns>
        public Patient GetPatientByName(string firstName, string lastName)
        {
            return PatientDAL.GetPatientByName(firstName, lastName);
        }

        public Patient GetPatientByLastNameAndBirthDate(string lastName, string birthDate)
        {
            return PatientDAL.GetPatientByLastNameAndBirthDate(lastName, birthDate);
        }

        /// <summary>
        /// Gets a Patient matching a SSN.
        /// </summary>
        /// <param name="SSN">The SSN to search</param>
        /// <returns>A Patient or null if none are found.</returns>
        public Patient GetPatientBySSN(string SSN)
        {
            return PatientDAL.GetPatientBySSN(SSN);
        }


        /// <summary>
        /// Searches Patients by name and birthdate
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="birthDate"></param>
        /// <returns>A List of Patients</returns>
        public List<Patient> SearchPatientsByName(string firstName, string lastName, string birthDate)
        {
            return PatientDAL.SearchPatientsByName(firstName, lastName, birthDate);
        }

        /// <summary>
        /// Updates a Patient
        /// </summary>
        /// <param name="oldPatient"></param>
        /// <param name="newPatient"></param>
        /// <returns>True if update was successful</returns>
        public bool UpdatePatient(Patient oldPatient, Patient newPatient)
        {
            return PersonDAL.UpdatePerson(oldPatient, newPatient);
        }

        /// <summary>
        /// Adds a new Patient
        /// </summary>
        /// <param name="patient">The Patient to add</param>
        /// <returns>The new PatientID</returns>
        public int AddPatient(Patient patient)
        {
            return PatientDAL.AddPatient(patient);
        }

        /// <summary>
        /// Inserts an existing Person as a patient
        /// </summary>
        /// <param name="personID">The PersonID of the new patient</param>
        /// <returns>The new PatientID</returns>
        public int InsertPatient(int personID)
        {
            return PatientDAL.InsertPatient(personID);
        }

        /// <summary>
        /// Deletes a Patient
        /// </summary>
        /// <param name="patient">The Patient to delete</param>
        /// <returns>True if successful</returns>
        public bool DeletePatient(Patient patient)
        {
            bool success;
            try
            {
                success = PatientDAL.DeletePatient(patient);
            }
            catch
            {
                return false;
            }
            if (success)
            {
                try
                {
                    PersonDAL.DeletePerson(patient);
                }
                catch
                {

                }
            }
            return success;
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
