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

        public List<LabTest> GetLabTests()
        {
            return LabTestDAL.GetTestList();
        }
    }
}
