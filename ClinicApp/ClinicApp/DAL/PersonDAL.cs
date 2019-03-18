using ClinicApp.Model;
using System;
using System.Data;
using System.Data.SqlClient;

namespace ClinicApp.DAL
{
    public static class PersonDAL
    {
        public static Person GetPerson(string personType, int personID)
        {
            Person person = null;
            switch (personType.ToUpper())
            {
                case "PATIENT":
                    person = new Patient();
                    break;
                case "NURSE":
                    person = new Nurse();
                    break;
                case "ADMINISTRATOR":
                    //person = new Administrator();
                    break;
                case "DOCTOR":
                    //person = new Doctor();
                    break;
                default:
                    throw new ArgumentException("That's not a valid Person type");
            }
            string selectStatement =
                "SELECT personID, lastName, firstName, birthDate, SSN, gender," +
                "streetAddress, city, state, postCode, phoneNumber " +
                "FROM Person " +
                "WHERE personID = @personID";
            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@personID", personID);
                    using (SqlDataReader reader = selectCommand.ExecuteReader(CommandBehavior.SingleRow))
                    {
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
                        while (reader.Read())
                        {
                            person.PersonID = reader.GetInt32(personIDOrd);
                            person.LastName = reader.GetString(lastNameOrd);
                            person.FirstName = reader.GetString(firstNameOrd);
                            person.BirthDate = reader.GetDateTime(birthDateOrd);
                            person.SSN = reader.GetString(ssnOrd);
                            person.Gender = reader.GetString(genderOrd);
                            person.StreetAddress = reader.GetString(addressOrd);
                            person.City = reader.GetString(cityOrd);
                            person.State = reader.GetString(stateOrd);
                            person.PostCode = reader.GetString(postCodeOrd);
                            person.PhoneNumber = reader.GetString(phoneOrd);
                        }
                    }
                }
            }
            return person;
        }
    }
}
