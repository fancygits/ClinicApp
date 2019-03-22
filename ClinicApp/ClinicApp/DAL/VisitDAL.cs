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
        public static string GetDoctor(int doctorID)
        {
            Visit doctor = new Visit();
            string selectStatement = "SELECT doctorID, CONCAT(firstName, ' ', lastName) AS \"Doctor Name\" " +
                                    "FROM Person p " +
                                    "JOIN Doctor d " +
                                    "ON d.personID = p.personID " +
                                    "WHERE doctorID = @doctorID";
            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@doctorID", doctorID);
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            doctor.DoctorName = reader["Doctor Name"].ToString();
                        } else
                        {
                            doctor = null;
                        }
                    }
                }
            }
            return doctor.DoctorName;
        }

        public static string GetNurse(int nurseID)
        {
            Visit nurse = new Visit();
            string selectStatement = "SELECT nurseID, CONCAT(firstName, ' ', lastName) AS \"Nurse Name\" " +
                                    "FROM Person p " +
                                    "JOIN Nurse n " +
                                    "ON n.personID = p.personID " +
                                    "WHERE nurseID = @nurseID";
            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@nurseID", nurseID);
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            nurse.NurseName = reader["Nurse Name"].ToString();
                        } else
                        {
                            nurse = null;
                        }
                    }
                }
            }
            return nurse.NurseName;
        }
        //GetPatientName
        public static Visit GetPatient(int patientID)
        {
            Visit patient = new Visit();
            string selectStatement = "SELECT patientID, birthDate, CONCAT(firstName, ' ', lastName) AS \"Patient Name\" " +
                                    "FROM Person pe " +
                                    "JOIN Patient pa " +
                                    "ON pa.personID = pe.personID " +
                                    "WHERE patientID = @patientID";
            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@patientID", patientID);
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            patient.PatientName = reader["Patient Name"].ToString();
                            patient.PatientBirthDate = (DateTime)reader["birthDate"];
                        }
                        else
                        {
                            patient = null;
                        }
                    }
                }
            }
            return patient;
        }
        public static List<Visit> GetPatients()
        {
            List<Visit> patientList = new List<Visit>();
            string selectStatement = "SELECT patientID, CONCAT(lastName, ', ', firstName) AS \"Patient Name\" " +
                                    "FROM Person p " +
                                    "JOIN Patient pa " +
                                    "ON pa.personID = p.personID " +
                                    "ORDER BY lastName";
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

        }


        //GetListOfAllNurses
        public static List<Visit> GetNurses()
        {
            List<Visit> nurseList = new List<Visit>();
            string selectStatement = "SELECT nurseID, CONCAT(firstName, ' ', lastName) AS \"Nurse Name\" " +
                                    "FROM Person p " +
                                    "JOIN Nurse n " +
                                    "ON n.personID = p.personID " +
                                    "ORDER BY lastName";
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

                return nurseList;
            }
        }
            //GetListOFVisitsByPatient
            public static List<Visit> GetListOfVisits(int patientID)
            {
                List<Visit> listOfVisits = new List<Visit>();
                string selectStatement = "SELECT DISTINCT pa.patientID, " +
                                         "a.appointmentID, " +
                                         "a.apptDatetime, " +
                                         "d.doctorID, " +
                                         "n.nurseID, " +
                                         "v.weight, v.systolicBP, v.diastolicBP, v.temperature, v.pulse, v.symptoms, v.initialDiagnosis, v.finalDiagnosis " +
                                         "FROM Appointment a " +
                                         "LEFT JOIN Visit v " +
                                         "ON a.appointmentID = v.appointmentID " +
                                         "LEFT JOIN Nurse n " +
                                         "ON n.nurseID = v.nurseID " +
                                         "Join Doctor d " +
                                         "ON d.doctorID = a.doctorID " +
                                         "Join Patient pa " +
                                         "ON pa.patientID = a.patientID " +
                                         "JOIN Person p " +
                                         "ON p.personID = n.personID OR p.personID = d.personID " +
                                         "WHERE a.patientID = @patientID " +
                                         "ORDER BY a.appointmentID";

                using (SqlConnection connection = ClinicDBConnection.GetConnection())
                {
                    connection.Open();
                    using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                    {
                        selectCommand.Parameters.AddWithValue("@patientID", patientID);
                        using (SqlDataReader reader = selectCommand.ExecuteReader())
                        {
                            int patIDOrd = reader.GetOrdinal("patientID");

                            int apptIDOrd = reader.GetOrdinal("appointmentID");
                            int apptDTOrd = reader.GetOrdinal("apptDatetime");
                            int doctorIDOrd = reader.GetOrdinal("doctorID");
                            int nurseIDOrd = reader.GetOrdinal("nurseID");
                            int weightOrd = reader.GetOrdinal("weight");
                            int systOrd = reader.GetOrdinal("systolicBP");
                            int diaOrd = reader.GetOrdinal("diastolicBP");
                            int tempOrd = reader.GetOrdinal("temperature");
                            int pulseOrd = reader.GetOrdinal("pulse");
                            int symptOrd = reader.GetOrdinal("symptoms");
                            int initOrd = reader.GetOrdinal("initialDiagnosis");
                            int finOrd = reader.GetOrdinal("finalDiagnosis");
                            while (reader.Read())
                            {
                                Visit visit = new Visit();
                                visit.PatientID = reader.GetInt32(patIDOrd);
                                visit.PatientName = GetPatient(visit.PatientID).PatientName;
                                visit.PatientBirthDate = GetPatient(visit.PatientID).PatientBirthDate;
                                visit.AppointmentID = reader.GetInt32(apptIDOrd);
                                visit.AppointmentTime = reader.GetDateTime(apptDTOrd);
                                visit.DoctorID = reader.GetInt32(doctorIDOrd);
                                visit.DoctorName = GetDoctor(visit.DoctorID);
                                if (reader.IsDBNull(nurseIDOrd))
                                {
                                    nurseIDOrd += -1;
                                    visit.NurseName = "";
                                } else
                                {
                                    visit.NurseID = reader.GetInt32(nurseIDOrd);
                                    visit.NurseName = GetNurse(visit.NurseID);
                                }
                            if (reader.IsDBNull(weightOrd))
                                {
                                    weightOrd += -1;
                                } else
                                {
                                    visit.Weight = reader.GetDecimal(weightOrd);
                                }
                                if (reader.IsDBNull(systOrd))
                                {
                                    systOrd += -1;
                                }
                                else
                                {
                                    visit.SystolicBP = reader.GetInt32(systOrd);
                                }
                                if (reader.IsDBNull(diaOrd))
                                {
                                    diaOrd += -1;
                                }
                                else
                                {
                                    visit.DiastolicBP = reader.GetInt32(diaOrd);
                                }
                                if (reader.IsDBNull(tempOrd))
                                {
                                    tempOrd += -1;
                                }
                                else
                                {
                                    visit.Temperature = reader.GetDecimal(tempOrd);
                                }
                                if (reader.IsDBNull(pulseOrd))
                                {
                                    pulseOrd += -1;
                                }
                                else
                                {
                                    visit.Pulse = reader.GetInt32(pulseOrd);
                                }
                                if (reader.IsDBNull(symptOrd))
                                {
                                    symptOrd += -1;
                                }
                                else
                                {
                                    visit.Symptoms = reader.GetString(symptOrd);
                                }
                                if (reader.IsDBNull(initOrd))
                                {
                                    initOrd += -1;
                                }
                                else
                                {
                                    visit.InitialDiagnosis = reader.GetString(initOrd);
                                }
                                if (reader.IsDBNull(finOrd))
                                {
                                    finOrd += -1;
                                }
                                else
                                {
                                    visit.FinalDiagnosis = reader.GetString(finOrd);
                                }
                                listOfVisits.Add(visit);
                            }
                        }
                    }

                    return listOfVisits;
                }
            }
        
        public static bool UpdateVisit()
        {
            return false;
        }

        public static bool AddVisit()
        {
            return false;
        }
    }
} 
