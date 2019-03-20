using ClinicApp.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.DAL
{
    class VisitDAL
    {
        //GetNurseName



        //GetDoctorName
        public static List<Visit> GetDoctors()
        {
            List<Visit> doctorList = new List<Visit>();
            string selectStatement = "SELECT doctorID, CONCAT(firstName, ' ', lastName) AS \"Doctor Name\" " +
                                    "FROM Person p " +
                                    "JOIN Doctor d " +
                                    "ON d.personID = p.personID";
            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Visit doctor = new Visit();
                            doctor.DoctorID = (int)reader["DoctorID"];
                            doctor.DoctorName = reader["Doctor Name"].ToString();
                            doctorList.Add(doctor);
                        }
                    }
                }
            }


            return doctorList;
        }

        public static List<Visit> GetNurses()
        {
            List<Visit> nurseList = new List<Visit>();
            string selectStatement = "SELECT nurseID, CONCAT(firstName, ' ', lastName) AS \"Nurse Name\" " +
                                    "FROM Person p " +
                                    "JOIN Nurse n " +
                                    "ON n.personID = p.personID";
            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Visit nurse = new Visit();
                            nurse.NurseID = (int)reader["nurseID"];
                            nurse.NurseName = reader["Nurse Name"].ToString();
                            nurseList.Add(nurse);
                        }
                    }
                }
            }
            return nurseList;
        }
        //GetPatientName
        public static List<Visit> GetPatients()
        {
            List<Visit> patientList = new List<Visit>();
            string selectStatement = "SELECT patientID, CONCAT(firstName, ' ', lastName) AS \"Patient Name\" " +
                                    "FROM Person p " +
                                    "JOIN Patient pa " +
                                    "ON pa.personID = p.personID";
            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Visit patient = new Visit();
                            patient.PatientID = (int)reader["patientID"];
                            patient.PatientName = reader["Patient Name"].ToString();
                            patientList.Add(patient);
                        }
                    }
                }

                return patientList;
            }
            //GetListOfAllVisits

            //GetListOFVisitsByPatient
        }
    }
}
