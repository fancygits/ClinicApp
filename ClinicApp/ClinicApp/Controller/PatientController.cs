﻿using ClinicApp.DAL;
using ClinicApp.Model;
using System.Collections.Generic;

namespace ClinicApp.Controller
{
    public class PatientController
    {

        public List<Patient> GetPatientList()
        {
            return PatientDAL.GetPatientList();
        }

        public Patient GetPatient(int patientID)
        {
            return PatientDAL.GetPatient(patientID);
        }
    }
}