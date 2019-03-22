using ClinicApp.DAL;
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

        public Patient GetPatientByID(int patientID)
        {
            return PatientDAL.GetPatientByID(patientID);
        }

        public Patient GetPatientByName(string firstName, string lastName, string birthDate)
        {
            return PatientDAL.GetPatientByName(firstName, lastName, birthDate);
        }

        public List<Patient> GetPatientsByName(string firstName, string lastName)
        {
            return PatientDAL.GetPatientsByName(firstName, lastName);
        }

        public bool UpdatePatient(Patient oldPatient, Patient newPatient)
        {
            return PersonDAL.UpdatePerson(oldPatient, newPatient);
        }

        public List<State> GetStateList()
        {
            return StateList.list;
        }
    }
}
