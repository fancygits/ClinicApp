using ClinicApp.Model;
using System;
using System.Data;
using System.Data.SqlClient;

namespace ClinicApp.DAL
{
    /// <summary>
    /// Defines the DataAccessLayer for Person
    /// </summary>
    public class PersonDAL
    {
        /// <summary>
        /// Gets a person from the database based on personal details
        /// </summary>
        /// <param name="firstName">Person's first name</param>
        /// <param name="lastName">Person's last name</param>
        /// <param name="birthDate">Persons date of birth</param>
        /// <param name="SSN">Person's SSN</param>
        /// <returns>The personID of the found Person</returns>
        public static int GetPersonID(string firstName, string lastName, string birthDate, string SSN)
        {
            int personID = -1;
            string selectStatement =
                "SELECT personID " +
                "FROM Person " +
                "WHERE firstName = @firstname " +
                    "AND lastName = @lastName " +
                    "AND birthDate = @birthDate " +
                    "AND SSN = @SSN";
            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@firstName", firstName);
                    selectCommand.Parameters.AddWithValue("@lastName", lastName);
                    selectCommand.Parameters.AddWithValue("@birthDate", birthDate);
                    selectCommand.Parameters.AddWithValue("@SSN", SSN);
                    using (SqlDataReader reader = selectCommand.ExecuteReader(CommandBehavior.SingleRow))
                    {
                        if (reader.Read())
                        {
                            personID = (int)reader["personID"];
                        }
                    }
                }
            }
            return personID;
        }

        /// <summary>
        /// Updates a Person in the database.
        /// </summary>
        /// <param name="oldPerson">The former Person to reference against</param>
        /// <param name="newPerson">The new Person to update to</param>
        /// <returns>True if successful</returns>
        public static bool UpdatePerson(Person oldPerson, Person newPerson)
        {
            string updateStatement =
                "UPDATE Person SET " +
                    "lastName = @newLastName, " +
                    "firstName = @newFirstName, " +
                    "birthDate = @newBirthDate, " +
                    "SSN = @newSSN, " +
                    "gender = @newGender, " +
                    "streetAddress = @newStreetAddress, " +
                    "city = @newCity, " +
                    "state = @newState, " +
                    "postCode = @newPostCode, " +
                    "phoneNumber = @newPhoneNumber, " +
                    "username = @newUsername " +
                "WHERE personID = @oldPersonID " +
                    "AND lastName = @oldLastName " +
                    "AND firstName = @oldFirstName " +
                    "AND birthDate = @oldBirthDate " +
                    "AND SSN = @oldSSN " +
                    "AND gender = @oldGender " +
                    "AND streetAddress = @oldStreetAddress " +
                    "AND city = @oldCity " +
                    "AND state = @oldState " +
                    "AND postCode = @oldPostCode " +
                    "AND phoneNumber = @oldPhoneNumber " +
                    "AND (username = @oldUserName " +
                        "OR username IS NULL AND @oldUserName IS NULL)";
            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand updateCommand = new SqlCommand(updateStatement, connection))
                {
                    updateCommand.Parameters.AddWithValue("@newLastName", newPerson.LastName);
                    updateCommand.Parameters.AddWithValue("@newFirstName", newPerson.FirstName);
                    updateCommand.Parameters.AddWithValue("@newBirthDate", newPerson.BirthDate);
                    updateCommand.Parameters.AddWithValue("@newSSN", newPerson.SSN);
                    updateCommand.Parameters.AddWithValue("@newGender", newPerson.Gender);
                    updateCommand.Parameters.AddWithValue("@newStreetAddress", newPerson.StreetAddress);
                    updateCommand.Parameters.AddWithValue("@newCity", newPerson.City);
                    updateCommand.Parameters.AddWithValue("@newState", newPerson.State);
                    updateCommand.Parameters.AddWithValue("@newPostCode", newPerson.PostCode);
                    updateCommand.Parameters.AddWithValue("@newPhoneNumber", newPerson.PhoneNumber);
                    if (newPerson.Username == "" || newPerson.Username == null)
                    {
                        updateCommand.Parameters.AddWithValue("@newUsername", DBNull.Value);
                    }
                    else
                    {
                        updateCommand.Parameters.AddWithValue("@newUsername", newPerson.Username);
                    }
                    updateCommand.Parameters.AddWithValue("@oldPersonID", oldPerson.PersonID);
                    updateCommand.Parameters.AddWithValue("@oldLastName", oldPerson.LastName);
                    updateCommand.Parameters.AddWithValue("@oldFirstName", oldPerson.FirstName);
                    updateCommand.Parameters.AddWithValue("@oldBirthDate", oldPerson.BirthDate);
                    updateCommand.Parameters.AddWithValue("@oldSSN", oldPerson.SSN);
                    updateCommand.Parameters.AddWithValue("@oldGender", oldPerson.Gender);
                    updateCommand.Parameters.AddWithValue("@oldStreetAddress", oldPerson.StreetAddress);
                    updateCommand.Parameters.AddWithValue("@oldCity", oldPerson.City);
                    updateCommand.Parameters.AddWithValue("@oldState", oldPerson.State);
                    updateCommand.Parameters.AddWithValue("@oldPostCode", oldPerson.PostCode);
                    updateCommand.Parameters.AddWithValue("@oldPhoneNumber", oldPerson.PhoneNumber);
                    if (oldPerson.Username == "" || oldPerson.Username == null)
                    {
                        updateCommand.Parameters.AddWithValue("@oldUsername", DBNull.Value);
                    }
                    else
                    {
                        updateCommand.Parameters.AddWithValue("@oldUsername", oldPerson.Username);
                    }
                    int count = updateCommand.ExecuteNonQuery();
                    return count > 0;
                }
            }
        }

        /// <summary>
        /// Adds a Username to a given Person
        /// </summary>
        /// <param name="personID">The PersonID to update</param>
        /// <param name="SSN">The SSN to verify correct person</param>
        /// <param name="username">The new Username</param>
        /// <returns>True if successful</returns>
        public static bool AddUsername(int personID, string SSN, string username)
        {
            string updateStatement =
                "UPDATE Person SET " +
                "username = @username " +
                "WHERE personID = @personID " +
                "AND SSN = @SSN " +
                "AND username IS NULL";
            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand updateCommand = new SqlCommand(updateStatement, connection))
                {
                    updateCommand.Parameters.AddWithValue("@username", username);
                    updateCommand.Parameters.AddWithValue("@personID", personID);
                    updateCommand.Parameters.AddWithValue("@SSN", SSN);
                    int count = updateCommand.ExecuteNonQuery();
                    return count > 0;
                }
            }
        }

        /// <summary>
        /// Adds a Person to the database
        /// </summary>
        /// <param name="person">The Person to add</param>
        /// <returns>The PersonID of the new Person</returns>
        public static int AddPerson(Person person)
        {
            int personID;
            string insertStatement =
                "INSERT INTO Person " +
                "(lastName, firstName, birthDate, SSN, gender, " +
                "streetAddress, city, state, postCode, phoneNumber, username) " +
                "VALUES (@lastName, @firstName, @birthDate, @SSN, @gender, " +
                "@streetAddress, @city, @state, @postCode, @phoneNumber, @username)";
            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand insertCommand = new SqlCommand(insertStatement, connection))
                {
                    insertCommand.Parameters.AddWithValue("@lastName", person.LastName);
                    insertCommand.Parameters.AddWithValue("@firstName", person.FirstName);
                    insertCommand.Parameters.AddWithValue("@birthDate", person.BirthDate);
                    insertCommand.Parameters.AddWithValue("@SSN", person.SSN);
                    insertCommand.Parameters.AddWithValue("@gender", person.Gender);
                    insertCommand.Parameters.AddWithValue("@streetAddress", person.StreetAddress);
                    insertCommand.Parameters.AddWithValue("@city", person.City);
                    insertCommand.Parameters.AddWithValue("@state", person.State);
                    insertCommand.Parameters.AddWithValue("@postCode", person.PostCode);
                    insertCommand.Parameters.AddWithValue("@phoneNumber", person.PhoneNumber);
                    if (person.Username == "" || person.Username == null)
                    {
                        insertCommand.Parameters.AddWithValue("@username", DBNull.Value);
                    }
                    else
                    {
                        insertCommand.Parameters.AddWithValue("@username", person.Username);
                    }
                    insertCommand.ExecuteNonQuery();
                }
                string selectStatement = "SELECT IDENT_CURRENT('Person') FROM Person";
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    personID = Convert.ToInt32(selectCommand.ExecuteScalar());
                }
            }
            return personID;
        }

        /// <summary>
        /// Deletes a Person from the database
        /// </summary>
        /// <param name="person">The Person to delete</param>
        /// <returns>True if successful</returns>
        public static bool DeletePerson(Person person)
        {
            int rowCount = 0;
            string deleteStatement =
                "DELETE FROM Person " +
                "WHERE personID = @personID";
            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand deleteCommand = new SqlCommand(deleteStatement, connection))
                {
                    deleteCommand.Parameters.AddWithValue("@personID", person.PersonID);
                    rowCount = deleteCommand.ExecuteNonQuery();
                }
            }
            return (rowCount == 1);
        }

        /// <summary>
        /// Checks if a Person is a Nurse
        /// </summary>
        /// <param name="personID">The PersonID to check</param>
        /// <returns>True if Person is a Nurse</returns>
        public static bool IsANurse(int personID)
        {
            string selectStatement = "SELECT COUNT(*) FROM Nurse WHERE personID = @personID";
            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@personID", personID);
                    int count = Convert.ToInt32(selectCommand.ExecuteScalar());
                    return count > 0;
                }
            }
        }

        /// <summary>
        /// Checks if a Person is a Doctor
        /// </summary>
        /// <param name="personID">The PersonID to check</param>
        /// <returns>True if Person is a Doctor</returns>
        public static bool IsADoctor(int personID)
        {
            string selectStatement = "SELECT COUNT(*) FROM Doctor WHERE personID = @personID";
            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@personID", personID);
                    int count = Convert.ToInt32(selectCommand.ExecuteScalar());
                    return count > 0;
                }
            }
        }

        /// <summary>
        /// Checks if a Person is a Patient
        /// </summary>
        /// <param name="personID">The PersonID to check</param>
        /// <returns>True if Person is a Patient</returns>
        public static bool IsAPatient(int personID)
        {
            string selectStatement = "SELECT COUNT(*) FROM Patient WHERE personID = @personID";
            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@personID", personID);
                    int count = Convert.ToInt32(selectCommand.ExecuteScalar());
                    return count > 0;
                }
            }
        }

        /// <summary>
        /// Checks if a Person is an Administrator
        /// </summary>
        /// <param name="personID">The PersonID to check</param>
        /// <returns>True if Person is an Administrator</returns>
        public static bool IsAnAdministrator(int personID)
        {
            string selectStatement = "SELECT COUNT(*) FROM Administrator WHERE personID = @personID";
            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@personID", personID);
                    int count = Convert.ToInt32(selectCommand.ExecuteScalar());
                    return count > 0;
                }
            }
        }
    }
}
