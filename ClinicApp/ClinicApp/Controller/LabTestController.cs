
using System.Collections.Generic;
using ClinicApp.Model;
using ClinicApp.DAL;

namespace ClinicApp.Controller
{

    /// <summary>
    /// Controller for LabTest class
    /// </summary>
    public class LabTestController
    {

        /// <summary>
        /// Returns a list of LabTest names from database
        /// </summary>
        /// <returns>List of LabTest objects</returns>
        public List<LabTest> GetLabTests()
        {
            return LabTestDAL.GetTestList();
        }

        /// <summary>
        /// Returns a list of TestOrdered
        /// </summary>
        /// <param name="appointmentID">The appointmentID of the Visit</param>
        /// <returns>List of TestOrdered objects</returns>
        public List<TestOrdered> GetTestOrderedByAppointmentID(int appointmentID)
        {
            return LabTestDAL.GetTestOrderedByAppointmentID(appointmentID);
        }

        /// <summary>
        /// Adds a new TestOrdered object to the database
        /// </summary>
        /// <param name="testOrdered">TestOrdered object to be added</param>
        /// <returns>true if it added, false if not</returns>
        public bool AddTestOrdered(TestOrdered testOrdered)
        {
            return LabTestDAL.AddTestOrdered(testOrdered);
        }

        /// <summary>
        /// Updates TestOrdered table with new TestOrdered object
        /// </summary>
        /// <param name="newTestOrdered">New TestOrdered object to be added</param>
        /// <param name="testOrdered">Old TestOrdered object to be replaced</param>
        /// <returns>True if successful, false otherwise</returns>
        public bool UpdateTestOrdered(TestOrdered newTestOrdered, TestOrdered testOrdered)
        {
            return LabTestDAL.UpdateTestOrdered(newTestOrdered, testOrdered);
        }

        /// <summary>
        /// Deletes from the TestOrdered table in the database
        /// </summary>
        /// <param name="testOrdered">TestOrdered object to be deleted</param>
        /// <returns>True if successful, false otherwise</returns>
        public bool DeleteTestOrdered(TestOrdered testOrdered)
        {
            return LabTestDAL.DeleteTestOrdered(testOrdered);
        }
    }
}
