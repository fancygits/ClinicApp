using System.Data.SqlClient;

namespace ClinicApp.DAL
{
    public static class DBAccess
    {
        public static SqlConnection GetConnection()
        {
            string connectionString =
                "Data Source = .;Initial Catalog = CS6232-g1;" +
                "Integrated Security=True;";
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
    }
}
