﻿using ClinicApp.Controller;
using ClinicApp.Model;
using ClinicApp.View;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ClinicApp.UserControls
{
    public static class UserControlExtensions
    {
        /// <summary>
        /// Gets a patient from the given textboxes.
        /// If no patient is found, returns a list of possible matches.
        /// If no matches are found, returns null
        /// </summary>
        /// <param name="userControl">UserControl to send patient to</param>
        /// <param name="firstName">The first name of the patient</param>
        /// <param name="lastName">The last name of the patient</param>
        /// <param name="birthDate">The birthdate of the patient</param>
        /// <returns></returns>
        public static Patient FindPatient(this IUserControlSearch userControl, string firstName, string lastName, string birthDate)
        {
            Patient patient = null;
            PatientController patientController = new PatientController();
            try
            {
                patient = patientController.GetPatientByName(firstName, lastName, birthDate);
                if (patient == null)
                {
                    List<Patient> patientList = patientController.SearchPatientsByName(firstName, lastName, birthDate);
                    if (patientList.Count != 0)
                    {
                        FindPatientsDialog findPatientsDialog = new FindPatientsDialog();
                        findPatientsDialog.patientList = patientList;
                        DialogResult result = findPatientsDialog.ShowDialog();
                        if (result == DialogResult.OK)
                        {
                            patient = findPatientsDialog.patient;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
            return patient;
        }
    }
}