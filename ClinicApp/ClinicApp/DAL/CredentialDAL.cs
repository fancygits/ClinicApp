using ClinicApp.Model;
using ClinicApp.Controller;
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
            string selectStatement = "SELECT password_encrypted " +
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
                        int passwordOrd = reader.GetOrdinal("password_encrypted");
                        
                        if (reader.Read())
                        {
                           byte[] binary = (byte[])reader["password_encrypted"];

                            credential.Password = Encoding.Default.GetString(binary).ToString();
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

        public static bool AddCredential(string username, string password, string role)
        {
            int count = 0;
            string insertStatement =
                "INSERT INTO Credential (username, password,  role, password_encrypted) " +
                "VALUES(@username, @password, @role, @passwordpassword_encrypted)";
            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand insertCommand = new SqlCommand(insertStatement, connection))
                {
                    insertCommand.Parameters.AddWithValue("@username", username);
                    insertCommand.Parameters.AddWithValue("@password", password);
                    insertCommand.Parameters.AddWithValue("@password_encrypted", Security.Hash(password));
                    insertCommand.Parameters.AddWithValue("@role", role);
                    count = insertCommand.ExecuteNonQuery();
                    if (count > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }

    }

}
