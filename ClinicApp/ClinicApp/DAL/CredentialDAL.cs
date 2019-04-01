using ClinicApp.Model;
using System.Data.SqlClient;

namespace ClinicApp.DAL
{

    /// <summary>
    /// Defines the Credential DataAccessLayer class
    /// </summary>
    public class CredentialDAL
    {

        /// <summary>
        /// Gets password based on username
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public static string GetPassword(string username)
        {
            Credential credential = new Credential();
            string password = "";
             string selectStatement = "SELECT password " +
                "FROM Credential " +
                "WHERE username = @username";
            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@username", username);
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        int passwordOrd = reader.GetOrdinal("password");
                        if (reader.Read())
                        { 
                            credential.Password = reader.GetString(passwordOrd);
                            password = credential.Password;
                        } else
                        {
                            credential = null;
                        }
                    }
                }
            }
            return password;
        }

        /// <summary>
        /// Gets role based on username
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public static string GetRole(string username)
        {
            Credential credential = new Credential();
            string role = "";
            string selectStatement = "SELECT role " +
               "FROM Credential " +
               "WHERE username = @username";
            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@username", username);
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        int roleOrd = reader.GetOrdinal("role");
                        if (reader.Read())
                        {
                            credential.Role = reader.GetString(roleOrd);
                            role = credential.Role;
                        }
                        else
                        {
                            credential = null;
                        }
                    }
                }
            }
            return role;
        }

    }

}
