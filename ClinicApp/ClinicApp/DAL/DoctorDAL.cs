using System.Data.SqlClient;
using System.Collections.Generic;
using ClinicApp.Model;

namespace ClinicApp.DAL
{
    /// <summary>
    /// Establishes connection and accesses data in the Doctor and Person tables
    /// </summary>
    public static class DoctorDAL
    {
        /// <summary>
        /// Queries database and returns list of Doctor objects
        /// </summary>
        /// <returns></returns>
        public static List<Doctor> GetDoctorList()
        {
            List<Doctor> doctorList = new List<Doctor>();
            string selectStatement =
                "SELECT doctorID, per.personID AS personID, firstName, lastName, CONCAT(firstName, ' ', lastName) AS fullName " +
                "FROM Doctor doc " +
                "JOIN Person per " +
                "ON doc.personID = per.personID " +
                "ORDER BY lastName";
            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        int doctorIDOrd = reader.GetOrdinal("doctorID");
                        int personIDOrd = reader.GetOrdinal("personID");
                        int firstNameOrd = reader.GetOrdinal("firstName");
                        int lastNameOrd = reader.GetOrdinal("lastName");
                        int fullNameOrd = reader.GetOrdinal("fullName");
                        while (reader.Read())
                        {
                            Doctor doctor = new Doctor();
                            doctor.DoctorID = reader.GetInt32(doctorIDOrd);
                            doctor.PersonID = reader.GetInt32(personIDOrd);
                            doctor.FirstName = reader.GetString(firstNameOrd);
                            doctor.LastName = reader.GetString(lastNameOrd);
                    //        doctor.FullName = reader.GetString(fullNameOrd);
                            doctorList.Add(doctor);
                        }
                        reader.Close();
                    };
                }
                return doctorList;
            };
        }
    }
}
