﻿using ClinicApp.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.DAL
{
    /// <summary>
    /// This is the data access layer for the nurse class. 
    /// </summary>
    class NurseDAL
    {
        public static List<Nurse> GetNurseList()
        {
            List<Nurse> listOfNurses = new List<Nurse>();
            string selectStatement =
            "SELECT nurseID, p.personID, lastName, firstName, birthDate, SSN, gender," +
            "streetAddress, city, state, postCode, phoneNumber, active " +
            "FROM Person p " +
            "JOIN Nurse n ON p.personID = n.personID " +
            "ORDER BY nurseID";
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

                            listOfNurses.Add(nurse);
                        }
                    }
                }
            }
            return listOfNurses;
        }
    }
}
