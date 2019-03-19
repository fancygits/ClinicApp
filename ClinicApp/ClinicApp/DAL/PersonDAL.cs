using ClinicApp.Model;
using System;
using System.Data.SqlClient;

namespace ClinicApp.DAL
{
    /// <summary>
    /// Defines the DataAccessLayer for Person
    /// </summary>
    public class PersonDAL
    {
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
                    "personID = @newPersonID, " +
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
            using (SqlConnection connection = ClinicDBConnection.GetConnection()){
                connection.Open();
                using (SqlCommand updateCommand = new SqlCommand(updateStatement, connection))
                {
                    updateCommand.Parameters.AddWithValue("@newPersonID", newPerson.PersonID);
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
                    updateCommand.Parameters.AddWithValue("@newUsername", newPerson.Username);
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
                    if (oldPerson.Username == null)
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
    }
}
