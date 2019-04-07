using ClinicApp.Controller;
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
                        FindPeopleDialog findPatientsDialog = new FindPeopleDialog();
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

        /// <summary>
        /// Gets a Patient by their ID
        /// </summary>
        /// <param name="userControl">UserControl to send patient to</param>
        /// <param name="patientID">The int PatientID</param>
        /// <returns>The found Patient</returns>
        public static Patient GetPatientByID(this IUserControlSearch userControl, int patientID)
        {
            Patient patient = null;
            PatientController patientController = new PatientController();
            try
            {
                patient = patientController.GetPatientByID(patientID);
            }
            catch
            {
                patient = null;
            }
            return patient;
        }

        //public static Nurse FindNurse(this IUserControlSearch userControl, string firstName, string lastName, string birthDate)
        //{
        //    Nurse nurse = null;
        //    NurseController nurseController = new NurseController(); 
        //    try
        //    {
        //        nurse = nurseController.GetNurseByName(firstName, lastName, birthDate);
        //        if (nurse == null)
        //        {
        //            List<Nurse> nurseList = nurseController.SearchNursesByName(firstName, lastName, birthDate);
        //            if (nurseList.Count != 0)
        //            {
        //                FindPeopleDialog findNursesDialog = new FindPeopleDialog();
        //                findNursesDialog.nurseList = nurseList;
        //                DialogResult result = findNursesDialog.ShowDialog();
        //                if (result == DialogResult.OK)
        //                {
        //                    nurse = findNursesDialog.nurse;
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, ex.GetType().ToString());
        //    }
        //    return nurse;
        //}
    }
}
