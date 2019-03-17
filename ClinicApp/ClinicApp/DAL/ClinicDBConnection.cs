using System.Data.SqlClient;

namespace ClinicApp.DAL
{
    /// <summary>
    /// Defines the static database connection class
    /// </summary>
    public static class ClinicDBConnection
    {
        /// <summary>
        /// Gets the connection to the clinic's CS6232-g1 database
        /// </summary>
        /// <returns>The connection object</returns>
        public static SqlConnection GetConnection()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "localhost";
            builder.InitialCatalog = "CS6232-g1";
            builder.IntegratedSecurity = true;

            SqlConnection connection = new SqlConnection(builder.ConnectionString);
            return connection;
        }
    }
}
