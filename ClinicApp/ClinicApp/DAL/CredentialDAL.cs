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
        public static Nurse GetNurseByUserName(string username)
        {
            Nurse nurse = new Nurse();
            string selectStatement = "SELECT p.firstName, p.lastName, c.username, c.password, c.role " +
                "FROM Credential c " +
                "JOIN Person p " +
                "ON p.username = c.username " +
                "JOIN Nurse n " +
                "ON n.personID = p.personID " +
                "WHERE c.username = @username";
            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@username", username);
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        int fNameOrd = reader.GetOrdinal("firstName");
                        int lNameOrd = reader.GetOrdinal("lastName");
                        int uNameOrd = reader.GetOrdinal("username");
                        int rolOrd = reader.GetOrdinal("role");
                        if (reader.Read())
                        {
                            nurse.FirstName = reader.GetString(fNameOrd);
                            nurse.LastName = reader.GetString(lNameOrd);
                            nurse.Username = reader.GetString(uNameOrd);
                        }
                    }
                }
            }
            return nurse;
        }

        public static Administrator GetAdministratorByUserName(string username)
        {
            Administrator administrator = new Administrator();
            string selectStatement = "SELECT p.firstName, p.lastName, c.username, c.password, c.role " +
                "FROM Credential c " +
                "JOIN Person p " +
                "ON p.username = c.username " +
                "JOIN Administrator a " +
                "ON a.personID = p.personID " +
                "WHERE c.username = @username";
            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@username", username);
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        int fNameOrd = reader.GetOrdinal("firstName");
                        int lNameOrd = reader.GetOrdinal("lastName");
                        int uNameOrd = reader.GetOrdinal("username");
                        int rolOrd = reader.GetOrdinal("role");
                        if (reader.Read())
                        {
                            administrator.FirstName = reader.GetString(fNameOrd);
                            administrator.LastName = reader.GetString(lNameOrd);
                            administrator.Username = reader.GetString(uNameOrd);
                        }
                    }
                }
            }
            return administrator;
        }

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
