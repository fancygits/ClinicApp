using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using ClinicApp.Model;


namespace ClinicApp.DAL
{
    /// <summary>
    /// Establishes connection and accesses data in the Patient and Person tables
    /// </summary>
    public class PatientDAL
    {
        public static List<Patient> GetSelectedPatients(string firstName, string lastName, DateTime DOB)
        {
            List<Patient> patientList = new List<Patient>();
            string selectStatement =
                "SELECT patientID, lastName, firstName, birthDate, SSN, gender, streetAddress, city, state, postCode, phoneNumber " +
                "FROM Patient pat " +
                "JOIN Person per " +
                "ON pat.personID = per.personID " +
                "WHERE(lastName LIKE 'Hu%' AND firstName LIKE 'La%')";
            using (SqlConnection connection = DBAccess.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Patient patient = new Patient();
                            patient.PatientID = (int)reader["patientID"];
                            patient.PatientLastName = reader["lastName"].ToString();
                            patient.PatientFirstName = reader["firstName"].ToString();
                            patientList.Add(patient);
                        }
                        reader.Close();
                    };
                }
                return patientList;
            }
        }
    }
}
