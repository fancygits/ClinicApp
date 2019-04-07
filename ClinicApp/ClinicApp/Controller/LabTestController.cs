using System;
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

        public bool AddTestOrdered(TestOrdered testOrdered)
        {
            return LabTestDAL.AddTestOrdered(testOrdered);
        }
    }
}
