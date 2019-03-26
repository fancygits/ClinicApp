using ClinicApp.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ClinicApp.DAL
{
    class VisitDAL
    {
        /// <summary>
        /// This is the method that will return a string of the doctors name. 
        /// </summary>
        /// <param name="doctorID"></param>
        /// <returns></returns>
        public static Doctor GetDoctor(int doctorID)
        {
            Doctor doctor = new Doctor();
            string selectStatement = "SELECT doctorID, firstName, lastName " +
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
                            doctor.FirstName = reader["firstName"].ToString();
                            doctor.LastName = reader["lastName"].ToString();
                        } else
                        {
                            doctor = null;
                        }
                    }
                }
            }
            return doctor;
        }

        /// <summary>
        /// This method will return the string of a nurses name given the nurseID
        /// </summary>
        /// <param name="nurseID"></param>
        /// <returns></returns>
        public static Nurse GetNurse(int nurseID)
        {
            Nurse nurse = new Nurse();
            string selectStatement = "SELECT nurseID, firstName, lastName " +
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
                            nurse.FirstName = reader["firstName"].ToString();
                            nurse.LastName = reader["lastName"].ToString();
                        } else
                        {
                            nurse = null;
                        }
                    }
                }
            }
            return nurse;
        }

        /// <summary>
        /// This method returns a visit object that contains the patient name, id and birthdate for a visit
        /// </summary>
        /// <param name="patientID"></param>
        /// <returns></returns>
        public static Patient GetPatient(int patientID)
        {
            Patient patient = new Patient();
            string selectStatement = "SELECT patientID, birthDate, firstName, lastName " +
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
                            patient.FirstName = reader["firstName"].ToString();
                            patient.LastName = reader["lastName"].ToString();
                            patient.BirthDate = (DateTime)reader["birthDate"];
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

        /// <summary>
        /// /This method will return the list of all patients in the DB
        /// </summary>
        /// <returns></returns>
        public static List<Patient> GetPatients()
        {
            List<Patient> patientList = new List<Patient>();
            string selectStatement = "SELECT patientID, firstName, lastName " +
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
                            Patient patient = new Patient();
                            patient.PatientID = (int)reader["patientID"];
                            patient.FirstName = reader["firstName"].ToString();
                            patient.LastName = reader["lastName"].ToString();
                            patientList.Add(patient);
                        }
                    }
                }

                return patientList;
            }

        }


        /// <summary>
        /// This method will return a list of all nurses thart can have a vist. 
        /// </summary>
        /// <returns></returns>
        public static List<Nurse> GetNurses()
        {
            List<Nurse> nurseList = new List<Nurse>();
            string selectStatement = "SELECT nurseID, firstName, lastName " +
                                    "FROM Person p " +
                                    "JOIN Nurse n " +
                                    "ON n.personID = p.personID " +
                                    "WHERE active = 1 " +
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
                            Nurse nurse = new Nurse();
                            nurse.NurseID = (int)reader["nurseID"];
                            nurse.FirstName = reader["firstName"].ToString();
                            nurse.LastName = reader["lastName"].ToString();
                            nurseList.Add(nurse);
                        }
                    }
                }

                return nurseList;
            }
        }
            
            /// <summary>
            /// This will return a list of visits for each patient
            /// </summary>
            /// <param name="patientID"></param>
            /// <returns></returns>
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
                                visit.PatientName = GetPatient(visit.PatientID).FullName;
                                visit.PatientBirthDate = GetPatient(visit.PatientID).BirthDate;
                                visit.AppointmentID = reader.GetInt32(apptIDOrd);
                                visit.AppointmentTime = reader.GetDateTime(apptDTOrd);
                                visit.DoctorID = reader.GetInt32(doctorIDOrd);
                                visit.DoctorName = GetDoctor(visit.DoctorID).FullName;
                                if (reader.IsDBNull(nurseIDOrd))
                                {
                                    nurseIDOrd += -1;
                                    visit.NurseName = "";
                                } else
                                {
                                    visit.NurseID = reader.GetInt32(nurseIDOrd);
                                    visit.NurseName = GetNurse(visit.NurseID).FullName;
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
        
        /// <summary>
        /// this will update a visit 
        /// </summary>
        /// <param name="oldVisit"></param>
        /// <param name="newVisit"></param>
        /// <returns></returns>
        public static bool UpdateVisit(Visit oldVisit, Visit newVisit)
        {
            int count = 0;
            string updateStatement = "UPDATE Visit " +
                                     "SET weight = @newWeight, " +
                                     "systolicBP = @newSystolicBP, " +
                                     "diastolicBP = @newDiastolicBP, " +
                                     "temperature = @newTemperature, " +
                                     "pulse = @newPulse, " +
                                     "symptoms = @newSymptoms, " +
                                     "nurseID = @newNurseID " +
                                     "WHERE appointmentID = @oldAppointmentID " +
                                     "AND weight = @oldWeight " +
                                     "AND systolicBP = @oldSystolicBP " +
                                     "AND diastolicBP = @oldDiastolicBP " +
                                     "AND temperature = @oldTemperature " +
                                     "AND pulse = @oldPulse " +
                                     "AND symptoms = @oldSymptoms " +
                                     "AND nurseID = @oldNurseID " +
                                     "AND finalDiagnosis IS NULL";
            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();
                using(SqlCommand updateCommand = new SqlCommand(updateStatement, connection))
                {
                    updateCommand.Parameters.AddWithValue("@newWeight", newVisit.Weight);
                    updateCommand.Parameters.AddWithValue("@newSystolicBP", newVisit.SystolicBP);
                    updateCommand.Parameters.AddWithValue("@newDiastolicBP", newVisit.DiastolicBP);
                    updateCommand.Parameters.AddWithValue("@newTemperature", newVisit.Temperature);
                    updateCommand.Parameters.AddWithValue("@newPulse", newVisit.Pulse);
                    updateCommand.Parameters.AddWithValue("@newSymptoms", newVisit.Symptoms);
                    updateCommand.Parameters.AddWithValue("@newNurseID", newVisit.NurseID);
                    updateCommand.Parameters.AddWithValue("@oldAppointmentID", oldVisit.AppointmentID);
                    updateCommand.Parameters.AddWithValue("@oldWeight", oldVisit.Weight);
                    updateCommand.Parameters.AddWithValue("@oldSystolicBP", oldVisit.SystolicBP);
                    updateCommand.Parameters.AddWithValue("@oldDiastolicBP", oldVisit.DiastolicBP);
                    updateCommand.Parameters.AddWithValue("@oldTemperature", oldVisit.Temperature);
                    updateCommand.Parameters.AddWithValue("@oldPulse", oldVisit.Pulse);
                    updateCommand.Parameters.AddWithValue("@oldSymptoms", oldVisit.Symptoms);
                    updateCommand.Parameters.AddWithValue("@oldNurseID", oldVisit.NurseID);
                    count = updateCommand.ExecuteNonQuery();
                }
            }

            if (count > 0)
            {
                return true;
            } else
            {
                return false;
            }
        }

        /// <summary>
        /// this will add a visit to the visit table
        /// </summary>
        /// <param name="newVisit"></param>
        /// <returns></returns>
        public static bool AddVisit(Visit newVisit)
        {
            int count = 0;
            string insertStatement = "INSERT INTO Visit " +
                                     "(appointmentID, weight, systolicBP, diastolicBP, temperature, pulse, symptoms, initialDiagnosis, finalDiagnosis, nurseID) " +
                                     "VALUES (@appointmentID, @weight, @systolicBP, @diastolicBP, @temperature, @pulse, @symptoms, 'Pending doctor visit', NULL, @nurseID)";
            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand insertCommand = new SqlCommand(insertStatement, connection))
                {
                    insertCommand.Parameters.AddWithValue("@appointmentID", newVisit.AppointmentID);
                    insertCommand.Parameters.AddWithValue("@weight", newVisit.Weight);
                    insertCommand.Parameters.AddWithValue("@systolicBP", newVisit.SystolicBP);
                    insertCommand.Parameters.AddWithValue("@diastolicBP", newVisit.DiastolicBP);
                    insertCommand.Parameters.AddWithValue("@temperature", newVisit.Temperature);
                    insertCommand.Parameters.AddWithValue("@pulse", newVisit.Pulse);
                    insertCommand.Parameters.AddWithValue("@symptoms", newVisit.Symptoms);
                    insertCommand.Parameters.AddWithValue("@nurseID", newVisit.NurseID);
                    count = insertCommand.ExecuteNonQuery();
                }
            }

            if(count > 0)
            {
                return true;
            } else
            {
                return false;
            }
        }
    }
} 
