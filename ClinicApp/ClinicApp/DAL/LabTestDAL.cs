using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using ClinicApp.Model;

namespace ClinicApp.DAL
{
    
    /// <summary>
    /// Defines the LabTest DataAccessLayer class
    /// </summary>
    public class LabTestDAL
    {

        /// <summary>
        /// Returns a list of LabTest objects from database
        /// </summary>
        /// <returns></returns>
        public static List<LabTest> GetTestList()
        {
            List<LabTest> testList = new List<LabTest>();
            string selectStatement =
                "SELECT testCode, testName " +
                "FROM LabTest ";
            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        int testCodeOrd = reader.GetOrdinal("testCode");
                        int testNameOrd = reader.GetOrdinal("testName");
                        while (reader.Read())
                        {
                            LabTest labTest = new LabTest();
                            labTest.TestCode = reader.GetInt32(testCodeOrd);
                            labTest.TestName = reader.GetString(testNameOrd);
                            testList.Add(labTest);
                        }
                        reader.Close();
                    };
                }
                return testList;
            }
        }
    }
}
