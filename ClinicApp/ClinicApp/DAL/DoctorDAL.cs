using System.Data.SqlClient;
using System.Collections.Generic;
using ClinicApp.Model;

namespace ClinicApp.DAL
{
    
    /// <summary>
    /// Establishes connection and access data in the Doctor and Person tables
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
                "SELECT doctorID, per.firstName AS firstName, per.lastName AS lastName " +
                "FROM Doctor doc " +
                "JOIN Person per " +
                "ON doc.personID = per.personID";
            using (SqlConnection connection = DBAccess.GetConnection())
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
                            doctor.DoctorFirstName = reader["firstName"].ToString();
                            doctor.DoctorLastName = reader["lastName"].ToString();
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
