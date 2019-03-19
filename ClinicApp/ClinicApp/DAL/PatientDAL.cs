﻿using ClinicApp.Model;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace ClinicApp.DAL
{
    /// <summary>
    /// Defines the Patient DataAccessLayer class
    /// </summary>
    public class PatientDAL
    {
        /// <summary>
        /// Gets a list of all Patients from the database
        /// </summary>
        /// <returns>A List of Patients</returns>
        public static List<Patient> GetPatientList()
        {
            List<Patient> patientList = new List<Patient>();
            string selectStatement =
                "SELECT patientID, p.personID, lastName, firstName, birthDate, SSN, gender," +
                "streetAddress, city, state, postCode, phoneNumber " +
                "FROM Person p " +
                "JOIN Patient ON p.personID = Patient.personID " +
                "ORDER BY patientID";
            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        int patientIDOrd = reader.GetOrdinal("patientID");
                        int personIDOrd  = reader.GetOrdinal("personID");
                        int lastNameOrd  = reader.GetOrdinal("lastName");
                        int firstNameOrd = reader.GetOrdinal("firstName");
                        int birthDateOrd = reader.GetOrdinal("birthDate");
                        int ssnOrd       = reader.GetOrdinal("SSN");
                        int genderOrd    = reader.GetOrdinal("gender");
                        int addressOrd   = reader.GetOrdinal("streetAddress");
                        int cityOrd      = reader.GetOrdinal("city");
                        int stateOrd     = reader.GetOrdinal("state");
                        int postCodeOrd  = reader.GetOrdinal("postCode");
                        int phoneOrd     = reader.GetOrdinal("phoneNumber");
                        while (reader.Read())
                        {
                            Patient patient = new Patient();
                            patient.PatientID = reader.GetInt32(patientIDOrd);
                            patient.PersonID = reader.GetInt32(personIDOrd);
                            patient.LastName = reader.GetString(lastNameOrd);
                            patient.FirstName = reader.GetString(firstNameOrd);
                            patient.BirthDate = reader.GetDateTime(birthDateOrd);
                            patient.SSN = reader.GetString(ssnOrd);
                            patient.Gender = reader.GetString(genderOrd);
                            patient.StreetAddress = reader.GetString(addressOrd);
                            patient.City = reader.GetString(cityOrd);
                            patient.State = reader.GetString(stateOrd);
                            patient.PostCode = reader.GetString(postCodeOrd);
                            patient.PhoneNumber = reader.GetString(phoneOrd);

                            patientList.Add(patient);
                        }
                    }
                }
            }
                return patientList;
        }

        /// <summary>
        /// Gets a single patient from the database
        /// </summary>
        /// <param name="personID">The personID to retrieve</param>
        /// <returns>A Patient object</returns>
        public static Patient GetPatient(int patientID)
        {
            Patient patient = new Patient();
            string selectStatement = 
                "SELECT patientID, p.personID, lastName, firstName, birthDate, SSN, gender, " +
                "streetAddress, city, state, postCode, phoneNumber, username " +
                "FROM Patient " +
                "JOIN Person p ON Patient.personID = p.personID " +
                "WHERE patientID = @patientID";
            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@patientID", patientID);
                    using (SqlDataReader reader = selectCommand.ExecuteReader(CommandBehavior.SingleRow))
                    {
                        int patientIDOrd = reader.GetOrdinal("patientID");
                        int personIDOrd = reader.GetOrdinal("personID");
                        int lastNameOrd = reader.GetOrdinal("lastName");
                        int firstNameOrd = reader.GetOrdinal("firstName");
                        int birthDateOrd = reader.GetOrdinal("birthDate");
                        int ssnOrd = reader.GetOrdinal("SSN");
                        int genderOrd = reader.GetOrdinal("gender");
                        int addressOrd = reader.GetOrdinal("streetAddress");
                        int cityOrd = reader.GetOrdinal("city");
                        int stateOrd = reader.GetOrdinal("state");
                        int postCodeOrd = reader.GetOrdinal("postCode");
                        int phoneOrd = reader.GetOrdinal("phoneNumber");
                        int usernameOrd = reader.GetOrdinal("username");
                        while (reader.Read())
                        {
                            patient.PatientID = reader.GetInt32(patientIDOrd);
                            patient.PersonID = reader.GetInt32(personIDOrd);
                            patient.LastName = reader.GetString(lastNameOrd);
                            patient.FirstName = reader.GetString(firstNameOrd);
                            patient.BirthDate = reader.GetDateTime(birthDateOrd);
                            patient.SSN = reader.GetString(ssnOrd);
                            patient.Gender = reader.GetString(genderOrd);
                            patient.StreetAddress = reader.GetString(addressOrd);
                            patient.City = reader.GetString(cityOrd);
                            patient.State = reader.GetString(stateOrd);
                            patient.PostCode = reader.GetString(postCodeOrd);
                            patient.PhoneNumber = reader.GetString(phoneOrd);
                            patient.Username = reader.GetString(usernameOrd);
                        }
                    }
                }
            }
            return patient;
        }

        public bool UpdatePatient(Patient oldPatient, Patient newPatient)
        {
            return PersonDAL.UpdatePerson(oldPatient, newPatient);
        }
    }
}
