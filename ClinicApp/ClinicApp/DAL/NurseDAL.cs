using ClinicApp.Model;
using System.Data;
using System.Data.SqlClient;

namespace ClinicApp.DAL
{
    class NurseDAL
    {
        public static Nurse GetNurse(int nurseID)
        {
            Nurse nurse = new Nurse();
            string selectStatement =
                "SELECT personID " +
                "FROM Nurse " +
                "WHERE nurseID = @nurseID";
            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@nurseID", nurseID);
                    using (SqlDataReader reader = selectCommand.ExecuteReader(CommandBehavior.SingleRow))
                    {
                        if (reader.Read())
                        {
                            int personID = (int)reader["personID"];
                            nurse = (Nurse)PersonDAL.GetPerson("Nurse", personID);
                            nurse.NurseID = nurseID;
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
    }
}
