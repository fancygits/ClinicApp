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
        /// <summary>
        /// Gets a list of all active Nurses
        /// </summary>
        /// <returns>A list of active Nurses</returns>
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
                                PhoneNumber = reader.GetString(phoneOrd),
                                Active = reader.GetBoolean(activeOrd)
                            };

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
                "streetAddress, city, state, postCode, phoneNumber, active, username " +
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
                        int activeOrd = reader.GetOrdinal("active");
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
                            nurse.Active = reader.GetBoolean(activeOrd);
                            nurse.Username = reader.GetString(usernameOrd);
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
        /// Gets a single nurse from the database by SSN
        /// </summary>
        /// <param name="SSN">The SSN to retrieve</param>
        /// <returns>A Nurse object</returns>
        public static Nurse GetNurseBySSN(string SSN)
        {
            Nurse nurse = new Nurse();
            string selectStatement =
                "SELECT nurseID, p.personID, lastName, firstName, birthDate, SSN, gender, " +
                "streetAddress, city, state, postCode, phoneNumber, active, username " +
                "FROM Nurse " +
                "JOIN Person p ON Nurse.personID = p.personID " +
                "WHERE SSN = @SSN";
            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@SSN", SSN);
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
                        int activeOrd = reader.GetOrdinal("active");
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
                            nurse.Active = reader.GetBoolean(activeOrd);
                            nurse.Username = reader.GetString(usernameOrd);
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
        /// Gets a single nurse from the database by nurseID
        /// </summary>
        /// <param name="personID">The personID to retrieve</param>
        /// <returns>A Nurse object</returns>
        public static Nurse GetNurseByBirthDate(string birthDate)
        {
            Nurse nurse = null;
            string countStatement =
                "SELECT COUNT(*) FROM Nurse n " +
                "JOIN Person pe ON n.personID = pe.personID " +
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
                "SELECT nurseID, p.personID, lastName, firstName, birthDate, SSN, gender, " +
                "streetAddress, city, state, postCode, phoneNumber, active, username " +
                "FROM Nurse " +
                "JOIN Person p ON Nurse.personID = p.personID " +
                "WHERE birthDate = @birthDate";
                using (SqlConnection connection = ClinicDBConnection.GetConnection())
                {
                    connection.Open();
                    using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                    {
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
                            int activeOrd = reader.GetOrdinal("active");
                            int usernameOrd = reader.GetOrdinal("username");
                            if (reader.Read())
                            {
                                nurse = new Nurse
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
                                    PhoneNumber = reader.GetString(phoneOrd),
                                    Active = reader.GetBoolean(activeOrd),
                                    Username = reader.GetString(usernameOrd)
                            };
                            }
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
        /// <returns>The nurse</returns>
        public static Nurse GetNurseByName(string firstName, string lastName)
        {
            Nurse nurse = null;
            string countStatement =
                "SELECT COUNT(*) FROM Nurse n " +
                "JOIN Person pe ON n.personID = pe.personID " +
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
                nurse = new Nurse();
                string selectStatement =
                "SELECT nurseID, p.personID, lastName, firstName, birthDate, SSN, gender, " +
                "streetAddress, city, state, postCode, phoneNumber, active, username " +
                "FROM Nurse " +
                "JOIN Person p ON Nurse.personID = p.personID " +
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
                                nurse.Active = reader.GetBoolean(activeOrd);
                                nurse.Username = reader.GetString(usernameOrd);
                            }
                            else
                            {
                                nurse = null;
                            }
                        }
                    }
                }
            }
            return nurse;
        }

        /// <summary>
        /// Gets a Nurse by their last name and birthdate
        /// </summary>
        /// <param name="lastName">Nurse's last name</param>
        /// <param name="birthDate">Nurse's birth date</param>
        /// <returns>A Nurse</returns>
        public static Nurse GetNurseByLastNameAndBirthDate(string lastName, string birthDate)
        {
            Nurse nurse = null;
            string countStatement =
                "SELECT COUNT(*) FROM Nurse n " +
                "JOIN Person p ON n.personID = p.personID " +
                "WHERE p.birthDate = @birthDate " +
                "AND p.lastName = @lastName";
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
                nurse = new Nurse();
                string selectStatement =
                "SELECT nurseID, p.personID, lastName, firstName, birthDate, SSN, gender, " +
                "streetAddress, city, state, postCode, phoneNumber, active, username " +
                "FROM Nurse " +
                "JOIN Person p ON Nurse.personID = p.personID " +
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
                                nurse.Active = reader.GetBoolean(activeOrd);
                                nurse.Username = reader.GetString(usernameOrd);
                            }
                            else
                            {
                                nurse = null;
                            }
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
                "streetAddress, city, state, postCode, phoneNumber, username, active " +
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
                        int activeOrd = reader.GetOrdinal("active");
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
                                PhoneNumber = reader.GetString(phoneOrd),
                                Active = reader.GetBoolean(activeOrd),
                                Username = reader.GetString(usernameOrd)
                        };
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

                nurseTransaction = connection.BeginTransaction("AddNurse");

                command.Connection = connection;
                command.Transaction = nurseTransaction;

                try
                {
                    CredentialDAL.AddCredential(nurse.Username, nurse.Password, "nurse");
                    int personID = PersonDAL.AddPerson(nurse);
                    nurseID = InsertNurse(personID, nurse.Active);
                    nurseTransaction.Commit();
                    return nurseID;
                }
                catch
                {
                    try
                    {
                        nurseTransaction.Rollback();
                        throw;
                    }
                    catch
                    {
                        throw;
                    }
                }
            }
        }

        /// <summary>
        /// Inserts a new Person into the Nurse table
        /// </summary>
        /// <param name="personID">The PersonID to add</param>
        /// <returns>The new Nurse's NurseID</returns>
        public static int InsertNurse(int personID, bool active)
        {
            int nurseID;
            string insertStatement =
                "INSERT INTO Nurse (personID, active) VALUES (@personID, @active)";
            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand insertCommand = new SqlCommand(insertStatement, connection))
                {
                    insertCommand.Parameters.AddWithValue("@personID", personID);
                    insertCommand.Parameters.AddWithValue("@active", active);
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

        /// <summary>
        /// Adds a Person to Nurse, adds new credentials, updates Person
        /// </summary>
        /// <param name="nurse">The Nurse-Person to add to Nurse</param>
        /// <returns>The new NurseID</returns>
        public static int PersonToNurse(Nurse nurse)
        {
            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                SqlTransaction nurseTransaction;

                nurseTransaction = connection.BeginTransaction("PersonToNurse");

                command.Connection = connection;
                command.Transaction = nurseTransaction;

                try
                {
                    CredentialDAL.AddCredential(nurse.Username, nurse.Password, "nurse");
                    PersonDAL.AddUsername(nurse.PersonID, nurse.SSN, nurse.Username);
                    int nurseID = InsertNurse(nurse.PersonID, nurse.Active);

                    nurseTransaction.Commit();
                    return nurseID;
                }
                catch
                {
                    nurseTransaction.Rollback();
                    throw;
                }
            }
        }

        /// <summary>
        /// Updates a Nurse and the credentials
        /// </summary>
        /// <param name="oldNurse">Nurse to change from</param>
        /// <param name="oldCredential">Credential to change from</param>
        /// <param name="newNurse">Nurse to change to</param>
        /// <param name="newCredential">Credential to change to</param>
        /// <returns>True if update was successful</returns>
        public static bool UpdateNurse(Nurse oldNurse, Credential oldCredential, Nurse newNurse, Credential newCredential)
        {
            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                SqlTransaction nurseTransaction;

                nurseTransaction = connection.BeginTransaction("Update Nurse");

                command.Connection = connection;
                command.Transaction = nurseTransaction;

                try
                {
                    if (newCredential.Password != null)
                    {
                        CredentialDAL.UpdateCredential(oldCredential, newCredential);
                    }
                    else if (oldCredential.Username != newCredential.Username) {
                        CredentialDAL.UpdateUsername(oldCredential, newCredential);
                    }
                    PersonDAL.UpdatePerson(oldNurse, newNurse);
                    UpdateNurseActiveState(newNurse);

                    nurseTransaction.Commit();
                    return true;
                }
                catch
                {
                    nurseTransaction.Rollback();
                    throw;
                }
            }
        }

        /// <summary>
        /// Updates the active state of a Nurse
        /// </summary>
        /// <param name="nurse">The Nurse to update</param>
        /// <param name="active">The active state</param>
        /// <returns>True if successful</returns>
        public static bool UpdateNurseActiveState(Nurse nurse)
        {

            string updateStatement =
                "UPDATE Nurse SET " +
                    "active = @active " +
                "WHERE nurseID = @nurseID " +
                    "AND personID = @personID ";
            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand updateCommand = new SqlCommand(updateStatement, connection))
                {
                    updateCommand.Parameters.AddWithValue("@active", nurse.Active);
                    updateCommand.Parameters.AddWithValue("@nurseID", nurse.NurseID);
                    updateCommand.Parameters.AddWithValue("@personID", nurse.PersonID);
                    
                    int count = updateCommand.ExecuteNonQuery();
                    return count > 0;
                }
            }
        }
    }
}
