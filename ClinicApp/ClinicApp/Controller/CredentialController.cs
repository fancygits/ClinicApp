using ClinicApp.DAL;


namespace ClinicApp.Controller
{
    /// <summary>
    /// Defines the CredentialController
    /// </summary>
    public class CredentialController
    {
        /// <summary>
        /// Returns the password for username
        /// </summary>
        /// <param name="username">string username</param>
        /// <returns>password</returns>
        public string GetPassword(string username)
        {
            return CredentialDAL.GetPassword(username);
        }

        /// <summary>
        /// Returns rolls for username
        /// </summary>
        /// <param name="username">string username</param>
        /// <returns>person roll</returns>
        public string GetRole(string username)
        {
            return CredentialDAL.GetRole(username);
        }
    }
}
