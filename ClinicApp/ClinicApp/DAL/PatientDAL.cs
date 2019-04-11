using ClinicApp.Model;
using System;
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
                "streetAddress, city, state, postCode, phoneNumber, username " +
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
                        int personIDOrd = reader.GetOrdinal("personID");
                        int lastNameOrd = reader.GetOrdinal("lastName");
                        int firstNameOrd = reader.GetOrdinal("firstName");
                        int birthDateOrd = reader.GetOrdinal("birthDate");
                        int ssnOrd       = reader.GetOrdinal("SSN");
                        int genderOrd    = reader.GetOrdinal("gender");
                        int addressOrd   = reader.GetOrdinal("streetAddress");
                        int cityOrd      = reader.GetOrdinal("city");
                        int stateOrd     = reader.GetOrdinal("state");
                        int postCodeOrd  = reader.GetOrdinal("postCode");
                        int phoneOrd     = reader.GetOrdinal("phoneNumber");
                        int usernameOrd  = reader.GetOrdinal("username");
                        while (reader.Read())
                        {
                            Patient patient = new Patient
                            {
                                PatientID = reader.GetInt32(patientIDOrd),
                                PersonID = reader.GetInt32(personIDOrd),
                                LastName = reader.GetString(lastNameOrd),
                                FirstName = reader.GetString(firstNameOrd),
                                BirthDate = reader.GetDateTime(birthDateOrd),
                                SSN = reader.GetString(ssnOrd),
                                Gender = reader.GetString(genderOrd),
                                StreetAddress = reader.GetString(addressOrd),
                                City = reader.GetString(cityOrd),
                                State = reader.GetString(stateOrd),
                                PostCode = reader.GetString(postCodeOrd),
                                PhoneNumber = reader.GetString(phoneOrd)
                            };
                            if (!reader.IsDBNull(usernameOrd))
                            {
                                patient.Username = reader.GetString(usernameOrd);
                            }
                            patientList.Add(patient);
                        }
                    }
                }
            }
            return patientList;
        }

        /// <summary>
        /// Gets a single patient from the database by patientID
        /// </summary>
        /// <param name="personID">The personID to retrieve</param>
        /// <returns>A Patient object</returns>
        public static Patient GetPatientByID(int patientID)
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
                        if (reader.Read())
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
                            if (!reader.IsDBNull(usernameOrd))
                            {
                                patient.Username = reader.GetString(usernameOrd);
                            }
                        }
                        else
                        {
                            patient = null;
                        }
                    }
                }
            }
            return patient;
        }

        /// <summary>
        /// Gets a single patient from the database by SSN
        /// </summary>
        /// <param name="SSN">The SSN to retrieve</param>
        /// <returns>A Patient object</returns>
        public static Patient GetPatientBySSN(string SSN)
        {
            Patient patient = new Patient();
            string selectStatement =
                "SELECT patientID, p.personID, lastName, firstName, birthDate, SSN, gender, " +
                "streetAddress, city, state, postCode, phoneNumber, username " +
                "FROM Patient " +
                "JOIN Person p ON Patient.personID = p.personID " +
                "WHERE SSN = @SSN";
            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@SSN", SSN);
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
                        if (reader.Read())
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
                            if (!reader.IsDBNull(usernameOrd))
                            {
                                patient.Username = reader.GetString(usernameOrd);
                            }
                        }
                        else
                        {
                            patient = null;
                        }
                    }
                }
            }
            return patient;
        }

        /// <summary>
        /// Gets a single patient from the database by patientID
        /// </summary>
        /// <param name="personID">The personID to retrieve</param>
        /// <returns>A Patient object</returns>
        public static Patient GetPatientByBirthDate(string birthDate)
        {
            Patient patient = null;
            string countStatement = 
                "SELECT COUNT(*) FROM Patient pa " +
                "JOIN Person pe ON pa.personID = pe.personID " +
                "WHERE pe.birthDate = @birthdate";
            int count = 0;
            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand countCommand = new SqlCommand(countStatement, connection))
                {
                    countCommand.Parameters.AddWithValue("@birthDate", birthDate);
                    count = Convert.ToInt32(countCommand.ExecuteScalar());
                }
            }
            if (count == 1)
            {
                string selectStatement =
                "SELECT patientID, p.personID, lastName, firstName, birthDate, SSN, gender, " +
                "streetAddress, city, state, postCode, phoneNumber, username " +
                "FROM Patient " +
                "JOIN Person p ON Patient.personID = p.personID " +
                "WHERE birthDate = @birthDate";
                using (SqlConnection connection = ClinicDBConnection.GetConnection())
                {
                    connection.Open();
                    using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                    {
                        selectCommand.Parameters.AddWithValue("@birthDate", birthDate);
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
                            if (reader.Read())
                            {
                                patient = new Patient
                                {
                                    PatientID = reader.GetInt32(patientIDOrd),
                                    PersonID = reader.GetInt32(personIDOrd),
                                    LastName = reader.GetString(lastNameOrd),
                                    FirstName = reader.GetString(firstNameOrd),
                                    BirthDate = reader.GetDateTime(birthDateOrd),
                                    SSN = reader.GetString(ssnOrd),
                                    Gender = reader.GetString(genderOrd),
                                    StreetAddress = reader.GetString(addressOrd),
                                    City = reader.GetString(cityOrd),
                                    State = reader.GetString(stateOrd),
                                    PostCode = reader.GetString(postCodeOrd),
                                    PhoneNumber = reader.GetString(phoneOrd)
                                };
                                if (!reader.IsDBNull(usernameOrd))
                                {
                                    patient.Username = reader.GetString(usernameOrd);
                                }
                            }
                        }
                    }
                }
            }
            return patient;
        }

        /// <summary>
        /// Gets a patient from the database based on personal details
        /// </summary>
        /// <param name="firstName">Patient's first name</param>
        /// <param name="lastName">Patient's last name</param>
        /// <returns>The patient</returns>
        public static Patient GetPatientByName(string firstName, string lastName)
        {
            Patient patient = null;
            string countStatement =
                "SELECT COUNT(*) FROM Patient pa " +
                "JOIN Person pe ON pa.personID = pe.personID " +
                "WHERE pe.firstName = @firstName " +
                "AND pe.lastName = @lastName";
            int count = 0;
            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand countCommand = new SqlCommand(countStatement, connection))
                {
                    countCommand.Parameters.AddWithValue("@firstName", firstName);
                    countCommand.Parameters.AddWithValue("@lastName", lastName);
                    count = Convert.ToInt32(countCommand.ExecuteScalar());
                }
            }
            if (count == 1)
            {
                patient = new Patient();
                string selectStatement =
                "SELECT patientID, p.personID, lastName, firstName, birthDate, SSN, gender, " +
                "streetAddress, city, state, postCode, phoneNumber, username " +
                "FROM Patient " +
                "JOIN Person p ON Patient.personID = p.personID " +
                "WHERE firstName = @firstname " +
                    "AND lastName = @lastName ";
                using (SqlConnection connection = ClinicDBConnection.GetConnection())
                {
                    connection.Open();
                    using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                    {
                        selectCommand.Parameters.AddWithValue("@firstName", firstName);
                        selectCommand.Parameters.AddWithValue("@lastName", lastName);
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
                            if (reader.Read())
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
                                if (!reader.IsDBNull(usernameOrd))
                                {
                                    patient.Username = reader.GetString(usernameOrd);
                                }
                            }
                            else
                            {
                                patient = null;
                            }
                        }
                    }
                }
            }
            return patient;
        }


        public static Patient GetPatientByLastNameAndBirthDate(string lastName, string birthDate)
        {
            Patient patient = null;
            string countStatement =
                "SELECT COUNT(*) FROM Patient pa " +
                "JOIN Person pe ON pa.personID = pe.personID " +
                "WHERE pe.birthDate = @birthDate " +
                "AND pe.lastName = @lastName";
            int count = 0;
            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand countCommand = new SqlCommand(countStatement, connection))
                {
                    countCommand.Parameters.AddWithValue("@lastName", lastName);
                    countCommand.Parameters.AddWithValue("@birthDate", birthDate);
                    count = Convert.ToInt32(countCommand.ExecuteScalar());
                }
            }
            if (count == 1)
            {
                patient = new Patient();
                string selectStatement =
                "SELECT patientID, p.personID, lastName, firstName, birthDate, SSN, gender, " +
                "streetAddress, city, state, postCode, phoneNumber, username " +
                "FROM Patient " +
                "JOIN Person p ON Patient.personID = p.personID " +
                "WHERE birthDate = @birthDate " +
                    "AND lastName = @lastName ";
                using (SqlConnection connection = ClinicDBConnection.GetConnection())
                {
                    connection.Open();
                    using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                    {
                        selectCommand.Parameters.AddWithValue("@birthDate", birthDate);
                        selectCommand.Parameters.AddWithValue("@lastName", lastName);
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
                            if (reader.Read())
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
                                if (!reader.IsDBNull(usernameOrd))
                                {
                                    patient.Username = reader.GetString(usernameOrd);
                                }
                            }
                            else
                            {
                                patient = null;
                            }
                        }
                    }
                }
            }
            return patient;
        }

        /// <summary>
        /// Searches patients by given firstName, lastName, and birthDate
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="birthDate"></param>
        /// <returns>A List of matching Patients</returns>
        public static List<Patient> SearchPatientsByName(string firstName, string lastName, string birthDate)
        {
            // This is to prevent blank textboxes from returning all results since all names match %
            if (firstName == "")
            {
                firstName = "1";
            }
            if (lastName == "")
            {
                lastName = "1";
            }
            List<Patient> patientList = new List<Patient>();
            string selectStatement =
                "SELECT patientID, p.personID, lastName, firstName, birthDate, SSN, gender, " +
                "streetAddress, city, state, postCode, phoneNumber, username " +
                "FROM Patient " +
                "JOIN Person p ON Patient.personID = p.personID " +
                "WHERE firstName LIKE @fnameSubstring " +
                    "OR lastName LIKE @lnameSubstring " +
                    "OR birthDate = @birthDate " +
                    "ORDER BY firstName, lastName";
            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@fnameSubstring", firstName + "%");
                    selectCommand.Parameters.AddWithValue("@lnameSubstring", lastName + "%");
                    selectCommand.Parameters.AddWithValue("@birthDate", birthDate);
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
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
                            Patient patient = new Patient
                            {
                                PatientID = reader.GetInt32(patientIDOrd),
                                PersonID = reader.GetInt32(personIDOrd),
                                LastName = reader.GetString(lastNameOrd),
                                FirstName = reader.GetString(firstNameOrd),
                                BirthDate = reader.GetDateTime(birthDateOrd),
                                SSN = reader.GetString(ssnOrd),
                                Gender = reader.GetString(genderOrd),
                                StreetAddress = reader.GetString(addressOrd),
                                City = reader.GetString(cityOrd),
                                State = reader.GetString(stateOrd),
                                PostCode = reader.GetString(postCodeOrd),
                                PhoneNumber = reader.GetString(phoneOrd)
                            };
                            if (!reader.IsDBNull(usernameOrd))
                            {
                                patient.Username = reader.GetString(usernameOrd);
                            }
                            patientList.Add(patient);
                        }
                    }
                }
            }
            return patientList;
        }

        /// <summary>
        /// Adds a Patient to Person and Patient
        /// </summary>
        /// <param name="patient">The Patient to add</param>
        /// <returns>The PatientID for the new Patient</returns>
        public static int AddPatient(Patient patient)
        {
            int patientID = -1;
            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                SqlTransaction patientTransaction;

                patientTransaction = connection.BeginTransaction("Add Patient");

                command.Connection = connection;
                command.Transaction = patientTransaction;

                try
                {
                    int personID = PersonDAL.AddPerson(patient);
                    patientID = InsertPatient(personID);

                    patientTransaction.Commit();
                }
                catch
                {
                    patientTransaction.Rollback();
                    throw;
                }
            }
            return patientID;
        }

        /// <summary>
        /// Inserts a new Person into the Patient table
        /// </summary>
        /// <param name="personID">The PersonID to add</param>
        /// <returns>The new Patient's PatientID</returns>
        public static int InsertPatient(int personID)
        {
            int patientID;
            string insertStatement =
                "INSERT INTO Patient (personID) VALUES (@personID)";
            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand insertCommand = new SqlCommand(insertStatement, connection))
                {
                    insertCommand.Parameters.AddWithValue("@personID", personID);
                    patientID = insertCommand.ExecuteNonQuery();
                }
                string selectStatement = "SELECT IDENT_CURRENT('Patient') FROM Patient";
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    patientID = Convert.ToInt32(selectCommand.ExecuteScalar());
                }
            }
            return patientID;
        }
    }
}
