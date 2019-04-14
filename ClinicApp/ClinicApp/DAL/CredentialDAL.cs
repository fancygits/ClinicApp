using ClinicApp.Controller;
using ClinicApp.Model;
using System.Data.SqlClient;

namespace ClinicApp.DAL
{

    class CredentialDAL
    {
        public static Nurse GetNurseByUserName(string username)
        {
            Nurse nurse = new Nurse();
            string selectStatement = "SELECT p.firstName, p.lastName, c.username, c.password, c.role, n.nurseID, n.active " +
                "FROM Credential c " +
                "JOIN Person p " +
                "ON p.username = c.username " +
                "JOIN Nurse n " +
                "ON n.personID = p.personID " +
                "WHERE c.username = @username " +
                "AND n.active = 1";
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
                        int nIDOrd = reader.GetOrdinal("nurseID");
                        int activeOrd = reader.GetOrdinal("active");
                        if (reader.Read())
                        {
                            nurse.FirstName = reader.GetString(fNameOrd);
                            nurse.LastName = reader.GetString(lNameOrd);
                            nurse.Username = reader.GetString(uNameOrd);
                            nurse.NurseID = reader.GetInt32(nIDOrd);
                            nurse.Active = reader.GetBoolean(activeOrd);
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

        public static bool AddCredential(string username, string password, string role)
        {
            int count = 0;
            string insertStatement =
                "INSERT INTO Credential (username, password,  role) " +
                "VALUES(@username, @password, @role)";
            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand insertCommand = new SqlCommand(insertStatement, connection))
                {
                    insertCommand.Parameters.AddWithValue("@username", username);
                    insertCommand.Parameters.AddWithValue("@password", Security.Hash(password));
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

        /// <summary>
        /// Updates the username in the DB
        /// </summary>
        /// <param name="oldCredential">The former credentials</param>
        /// <param name="newCredential">The updated credentials</param>
        /// <returns>True if successful</returns>
        public static bool UpdateUsername(Credential oldCredential, Credential newCredential)
        {
            string updateStatement =
                "UPDATE Credential SET " +
                    "username = @newUsername " +
                "WHERE username = @oldUsername " +
                    "AND role = @oldRole";
            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand updateCommand = new SqlCommand(updateStatement, connection))
                {
                    updateCommand.Parameters.AddWithValue("@newUsername", newCredential.Username);
                    updateCommand.Parameters.AddWithValue("@oldUsername", oldCredential.Username);
                    updateCommand.Parameters.AddWithValue("@oldRole", oldCredential.Role);
                    
                    int count = updateCommand.ExecuteNonQuery();
                    return count > 0;
                }
            }
        }

        /// <summary>
        /// Updates the password in the DB
        /// </summary>
        /// <param name="oldCredential">The former credentials</param>
        /// <param name="newCredential">The updated credentials</param>
        /// <returns>True if successful</returns>
        public static bool UpdateCredential(Credential oldCredential, Credential newCredential)
        {
            string updateStatement =
                "UPDATE Credential SET " +
                    "username = @newUsername, " +
                    "password = @newPassword, " +
                    "role = @newRole " +
                "WHERE username = @oldUsername " +
                    "AND role = @oldRole";
            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand updateCommand = new SqlCommand(updateStatement, connection))
                {
                    updateCommand.Parameters.AddWithValue("@newUsername", newCredential.Username);
                    updateCommand.Parameters.AddWithValue("@newPassword", Security.Hash(newCredential.Password));
                    updateCommand.Parameters.AddWithValue("@newRole", newCredential.Role);
                    updateCommand.Parameters.AddWithValue("@oldUsername", oldCredential.Username);
                    updateCommand.Parameters.AddWithValue("@oldRole", oldCredential.Role);

                    int count = updateCommand.ExecuteNonQuery();
                    return count > 0;
                }
            }
        }

    }

}
