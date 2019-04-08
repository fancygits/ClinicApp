using ClinicApp.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace ClinicApp.DAL
{
    /// <summary>
    /// This is the data access layer for the nurse class. 
    /// </summary>
    class NurseDAL
    {
        public static Nurse GetNurse(int nurseID)
        {
            Nurse nurse = new Nurse();
            string selectStatement = "SELECT nurseID, firstName, lastName " +
                                    "FROM Person p " +
                                    "JOIN Nurse n " +
                                    "ON n.personID = p.personID " +
                                    "WHERE nurseID = @nurseID";
            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@nurseID", nurseID);
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            nurse.FirstName = reader["firstName"].ToString();
                            nurse.LastName = reader["lastName"].ToString();
                        }
                        else
                        {
                            nurse = null;
                        }
                    }
                }
            }
            return nurse;
        }
        public static List<Nurse> GetNurseList()
        {
            List<Nurse> listOfNurses = new List<Nurse>();
            string selectStatement =
            "SELECT nurseID, p.personID, lastName, firstName, birthDate, SSN, gender," +
            "streetAddress, city, state, postCode, phoneNumber, active " +
            "FROM Person p " +
            "JOIN Nurse n ON p.personID = n.personID " +
            "WHERE active = 1 " +
            "ORDER BY lastName";
            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        int nurseIDOrd = reader.GetOrdinal("nurseID");
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
                        int activeOrd = reader.GetOrdinal("active");
                        while (reader.Read())
                        {
                            Nurse nurse = new Nurse();
                            nurse.NurseID = reader.GetInt32(nurseIDOrd);
                            nurse.PersonID = reader.GetInt32(personIDOrd);
                            nurse.LastName = reader.GetString(lastNameOrd);
                            nurse.FirstName = reader.GetString(firstNameOrd);
                            nurse.BirthDate = reader.GetDateTime(birthDateOrd);
                            nurse.SSN = reader.GetString(ssnOrd);
                            nurse.Gender = reader.GetString(genderOrd);
                            nurse.StreetAddress = reader.GetString(addressOrd);
                            nurse.City = reader.GetString(cityOrd);
                            nurse.State = reader.GetString(stateOrd);
                            nurse.PostCode = reader.GetString(postCodeOrd);
                            nurse.PhoneNumber = reader.GetString(phoneOrd);
                            nurse.Active = reader.GetBoolean(activeOrd);

                            listOfNurses.Add(nurse);
                        }
                    }
                }
            }
            return listOfNurses;
        }

        /// <summary>
        /// Gets a single nurse from the database by nurseID
        /// </summary>
        /// <param name="personID">The personID to retrieve</param>
        /// <returns>A Nurse object</returns>
        public static Nurse GetNurseByID(int nurseID)
        {
            Nurse nurse = new Nurse();
            string selectStatement =
                "SELECT nurseID, p.personID, lastName, firstName, birthDate, SSN, gender, " +
                "streetAddress, city, state, postCode, phoneNumber, username " +
                "FROM Nurse " +
                "JOIN Person p ON Nurse.personID = p.personID " +
                "WHERE nurseID = @nurseID";
            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@nurseID", nurseID);
                    using (SqlDataReader reader = selectCommand.ExecuteReader(CommandBehavior.SingleRow))
                    {
                        int nurseIDOrd = reader.GetOrdinal("nurseID");
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
                            nurse.NurseID = reader.GetInt32(nurseIDOrd);
                            nurse.PersonID = reader.GetInt32(personIDOrd);
                            nurse.LastName = reader.GetString(lastNameOrd);
                            nurse.FirstName = reader.GetString(firstNameOrd);
                            nurse.BirthDate = reader.GetDateTime(birthDateOrd);
                            nurse.SSN = reader.GetString(ssnOrd);
                            nurse.Gender = reader.GetString(genderOrd);
                            nurse.StreetAddress = reader.GetString(addressOrd);
                            nurse.City = reader.GetString(cityOrd);
                            nurse.State = reader.GetString(stateOrd);
                            nurse.PostCode = reader.GetString(postCodeOrd);
                            nurse.PhoneNumber = reader.GetString(phoneOrd);
                            if (!reader.IsDBNull(usernameOrd))
                            {
                                nurse.Username = reader.GetString(usernameOrd);
                            }
                        }
                        else
                        {
                            nurse = null;
                        }
                    }
                }
            }
            return nurse;
        }

        /// <summary>
        /// Gets a nurse from the database based on personal details
        /// </summary>
        /// <param name="firstName">Nurse's first name</param>
        /// <param name="lastName">Nurse's last name</param>
        /// <param name="birthDate">Nurses date of birth</param>
        /// <returns>The nurse</returns>
        public static Nurse GetNurseByName(string firstName, string lastName, string birthDate)
        {
            Nurse nurse = new Nurse();
            string selectStatement =
                "SELECT nurseID, p.personID, lastName, firstName, birthDate, SSN, gender, " +
                "streetAddress, city, state, postCode, phoneNumber, username " +
                "FROM Nurse " +
                "JOIN Person p ON Nurse.personID = p.personID " +
                "WHERE firstName = @firstname " +
                    "AND lastName = @lastName " +
                    "AND birthDate = @birthDate";
            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@firstName", firstName);
                    selectCommand.Parameters.AddWithValue("@lastName", lastName);
                    selectCommand.Parameters.AddWithValue("@birthDate", birthDate);
                    using (SqlDataReader reader = selectCommand.ExecuteReader(CommandBehavior.SingleRow))
                    {
                        int nurseIDOrd = reader.GetOrdinal("nurseID");
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
                            nurse.NurseID = reader.GetInt32(nurseIDOrd);
                            nurse.PersonID = reader.GetInt32(personIDOrd);
                            nurse.LastName = reader.GetString(lastNameOrd);
                            nurse.FirstName = reader.GetString(firstNameOrd);
                            nurse.BirthDate = reader.GetDateTime(birthDateOrd);
                            nurse.SSN = reader.GetString(ssnOrd);
                            nurse.Gender = reader.GetString(genderOrd);
                            nurse.StreetAddress = reader.GetString(addressOrd);
                            nurse.City = reader.GetString(cityOrd);
                            nurse.State = reader.GetString(stateOrd);
                            nurse.PostCode = reader.GetString(postCodeOrd);
                            nurse.PhoneNumber = reader.GetString(phoneOrd);
                            if (!reader.IsDBNull(usernameOrd))
                            {
                                nurse.Username = reader.GetString(usernameOrd);
                            }
                        }
                        else
                        {
                            nurse = null;
                        }
                    }
                }
            }
            return nurse;
        }

        /// <summary>
        /// Searches nurses by given firstName, lastName, and birthDate
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="birthDate"></param>
        /// <returns>A List of matching Nurses</returns>
        public static List<Nurse> SearchNursesByName(string firstName, string lastName, string birthDate)
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
            List<Nurse> nurseList = new List<Nurse>();
            string selectStatement =
                "SELECT nurseID, p.personID, lastName, firstName, birthDate, SSN, gender, " +
                "streetAddress, city, state, postCode, phoneNumber, username " +
                "FROM Nurse " +
                "JOIN Person p ON Nurse.personID = p.personID " +
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
                        int nurseIDOrd = reader.GetOrdinal("nurseID");
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
                            Nurse nurse = new Nurse
                            {
                                NurseID = reader.GetInt32(nurseIDOrd),
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
                                nurse.Username = reader.GetString(usernameOrd);
                            }
                            nurseList.Add(nurse);
                        }
                    }
                }
            }
            return nurseList;
        }

        /// <summary>
        /// Adds a Nurse to Person and Nurse
        /// </summary>
        /// <param name="nurse">The Nurse to add</param>
        /// <returns>The NurseID for the new Nurse</returns>
        public static int AddNurse(Nurse nurse)
        {
            int nurseID = -1;
            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                SqlTransaction nurseTransaction;

                nurseTransaction = connection.BeginTransaction("Add Nurse");

                command.Connection = connection;
                command.Transaction = nurseTransaction;

                try
                {
                    int personID = PersonDAL.AddPerson(nurse);
                    nurseID = InsertNurse(personID);

                    nurseTransaction.Commit();
                }
                catch
                {
                    nurseTransaction.Rollback();
                    throw;
                }
            }
            return nurseID;
        }

        /// <summary>
        /// Inserts a new Person into the Nurse table
        /// </summary>
        /// <param name="personID">The PersonID to add</param>
        /// <returns>The new Nurse's NurseID</returns>
        public static int InsertNurse(int personID)
        {
            int nurseID;
            string insertStatement =
                "INSERT INTO Nurse (personID) VALUES (@personID)";
            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand insertCommand = new SqlCommand(insertStatement, connection))
                {
                    insertCommand.Parameters.AddWithValue("@personID", personID);
                    nurseID = insertCommand.ExecuteNonQuery();
                }
                string selectStatement = "SELECT IDENT_CURRENT('Nurse') FROM Nurse";
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    nurseID = Convert.ToInt32(selectCommand.ExecuteScalar());
                }
            }
            return nurseID;
        }
    }
}
