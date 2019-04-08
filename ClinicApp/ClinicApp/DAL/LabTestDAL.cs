using ClinicApp.Model;
using System.Collections.Generic;
using System.Data.SqlClient;

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
                    }
                }
                return testList;
            }
        }

        /// <summary>
        /// Gets a list of TestOrdered by AppoitnmentID
        /// </summary>
        /// <param name="appointmentID">AppointmentID of Visit</param>
        /// <returns>List of TestOrdered</returns>
        public static List<TestOrdered> GetTestOrderedByAppointmentID(int appointmentID)
        {
            List<TestOrdered> testOrderedByApptIDList = new List<TestOrdered>();
            string selectStatement =
                "SELECT tord.testCode AS testCode, testName, testDate, result, resultDetails " +
                "FROM TestOrdered tord " +
                "JOIN LabTest lb " +
                "ON tord.testCode = lb.testCode " +
                "WHERE appointmentID = @AppointmentID";
            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@AppointmentID", appointmentID);
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        int testCodeOrd = reader.GetOrdinal("testCode");
                        int testNameOrd = reader.GetOrdinal("testName");
                        int testDateOrd = reader.GetOrdinal("testDate");
                        int testResultOrd = reader.GetOrdinal("result");
                        int testResultDetailsOrd = reader.GetOrdinal("resultDetails");
                        while (reader.Read())
                        {
                            TestOrdered testOrdered = new TestOrdered();
                            testOrdered.TestCode = reader.GetInt32(testCodeOrd);
                            testOrdered.Name = reader.GetString(testNameOrd);
                            testOrdered.Date = reader.GetDateTime(testDateOrd);
                            if (!reader.IsDBNull(testResultOrd))
                            {
                                testOrdered.Result = reader.GetBoolean(testResultOrd);
                            }
                            if (!reader.IsDBNull(testResultDetailsOrd))
                            {
                                testOrdered.ResultDetail = reader.GetString(testResultDetailsOrd);
                            }
                            testOrderedByApptIDList.Add(testOrdered);
                        }
                    }
                }
                return testOrderedByApptIDList;
            }

        }

        /// <summary>
        /// Adds a TestOrdered object to the database
        /// </summary>
        /// <param name="testOrdered">TestOrdered object to be added</param>
        /// <returns>true if insert was greater than 0 or false if not</returns>
        public static bool AddTestOrdered(TestOrdered testOrdered)
        {
            string insertStatement =
                "INSERT INTO TestOrdered (appointmentID, testCode, testDate) " +
                "VALUES(@AppointmentID, @TestCode, GETDATE())";
            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand insertCommand = new SqlCommand(insertStatement, connection))
                {
                    insertCommand.Parameters.AddWithValue("@AppointmentID", testOrdered.AppointmentID);
                    insertCommand.Parameters.AddWithValue("@TestCode", testOrdered.TestCode);

                    int count = insertCommand.ExecuteNonQuery();
                    return count > 0;
                }
            }
        }

        public static bool UpdateTestOrdered(TestOrdered testOrdered, TestOrdered newTestOrdered)
        {
            string updateStatement =
                "UPDATE TestOrdered " +
                "SET testDate = '2019-02-23', result = 0, resultDetails = 'testing2' " +
                "WHERE appointmentID = 24 AND testCode = 9";
            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand updateCommand = new SqlCommand(updateStatement, connection))
                {
                    updateCommand.Parameters.AddWithValue("@TestCode", testOrdered.TestCode);
                    updateCommand.Parameters.AddWithValue("@AppointmentID", testOrdered.AppointmentID);
                    //updateCommand.Parameters.AddWithValue("@NewTestDate", newTestOrdered.TestCode);
                    //updateCommand.Parameters.AddWithValue("@NewResult", newTestOrdered.Result);
                    //updateCommand.Parameters.AddWithValue("@NewResultDetail", newTestOrdered.ResultDetail);
                    //updateCommand.Parameters.AddWithValue("@OldTestDate", testOrdered.Date);
                    //updateCommand.Parameters.AddWithValue("@OldResult", testOrdered.Result);
                    //updateCommand.Parameters.AddWithValue("@OldResultDetail", testOrdered.ResultDetail);

                    int count = updateCommand.ExecuteNonQuery();
                    return count > 0;
                }
            }
        }
    }
}
