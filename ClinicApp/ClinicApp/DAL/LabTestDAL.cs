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
                        reader.Close();
                    };
                }
                return testOrderedByApptIDList;
            }

        }
    }
}
