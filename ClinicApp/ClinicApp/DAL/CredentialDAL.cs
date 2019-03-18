using ClinicApp.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.DAL
{
   
    class CredentialDAL
    {

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
