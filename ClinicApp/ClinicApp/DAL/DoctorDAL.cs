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
                "SELECT doctorID, per.personID AS personID, firstName, lastName " +
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
                        while (reader.Read())
                        {
                            Doctor doctor = new Doctor();
                            doctor.DoctorID = (int)reader["doctorID"];
                            doctor.PersonID = (int)reader["personID"];
                            doctor.FirstName = reader["firstName"].ToString();
                            doctor.LastName = reader["lastName"].ToString();
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
