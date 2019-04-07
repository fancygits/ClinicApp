using ClinicApp.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ClinicApp.DAL
{
    /// <summary>
    /// Establishes connection and accesses data in the Appointment table
    /// </summary>
    public static class AppointmentDAL
    {
        /// <summary>
        /// Returns a list of Appointment objects by patient ID
        /// </summary>
        /// <param name="patientID"></param>
        /// <returns></returns>
        public static List<Appointment> GetAppointmentsByPatientID(int patientID)
        {
            List<Appointment> appointmentsByPatientID = new List<Appointment>();
            string selectStatement =
                "SELECT appointmentID, apptDatetime, firstName, lastName, app.doctorID AS doctorID, reasonForVisit " +
                "FROM Appointment app " +
                "JOIN Doctor doc " +
                "ON app.doctorID = doc.doctorID " +
                "JOIN Person per " +
                "ON doc.personID = per.personID " +
                "WHERE patientID = @PatientID " +
                "ORDER BY apptDatetime";
            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@PatientID", patientID);
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        int apptIDOrd = reader.GetOrdinal("appointmentID");
                        int apptDateTimeOrd = reader.GetOrdinal("apptDatetime");
                        int firstNameOrd = reader.GetOrdinal("firstName");
                        int lastNameOrd = reader.GetOrdinal("lastName");
                        int doctorIDOrd = reader.GetOrdinal("doctorID");
                        int reasonForVisitOrd = reader.GetOrdinal("reasonForVisit");
                        while (reader.Read())
                        {
                            Appointment appointment = new Appointment();
                            appointment.AppointmentID = reader.GetInt32(apptIDOrd);
                            appointment.AppointmentDateTime = reader.GetDateTime(apptDateTimeOrd);
                            appointment.AppointmentDoctorFirstName = reader.GetString(firstNameOrd);
                            appointment.AppointmentDoctorLastName = reader.GetString(lastNameOrd);
                            appointment.AppointmentDoctorID = reader.GetInt32(doctorIDOrd);
                            appointment.AppointmentReason = reader.GetString(reasonForVisitOrd);
                            appointmentsByPatientID.Add(appointment);
                        }
                    }
                }
                return appointmentsByPatientID;
            };
        }

        /// <summary>
        /// Adds a new Appointment object to the database.  Returns the new Appointment aappointmentID
        /// </summary>
        /// <param name="appointment">New Appointment to be added</param>
        public static int AddAppointment(Appointment appointment)
        {
            string insertStatement =
                "INSERT INTO Appointment (patientID, doctorID, apptDatetime, reasonForVisit) " +
                "VALUES(@PatientID, @DoctorID, @Date, @Reason)";
            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand insertCommand = new SqlCommand(insertStatement, connection))
                {
                    insertCommand.Parameters.AddWithValue("@PatientID", appointment.AppointmentPatientID);
                    insertCommand.Parameters.AddWithValue("@DoctorID", appointment.AppointmentDoctorID);
                    insertCommand.Parameters.AddWithValue("@Date", appointment.AppointmentDateTime);
                    insertCommand.Parameters.AddWithValue("@Reason", appointment.AppointmentReason);

                    insertCommand.ExecuteNonQuery();
                    string selectStatement =
                        "SELECT IDENT_CURRENT('Appointment') FROM Appointment";
                    SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
                    int appointmentID = Convert.ToInt32(selectCommand.ExecuteScalar());
                    return appointmentID;

                }
            }
        }

        /// <summary>
        /// Updates the database with new Appointment object information
        /// </summary>
        /// <param name="appointment">current Appointment info</param>
        /// <param name="newAppointment"><updated Appointment info/param>
        /// <returns></returns>
        public static bool UpdateAppointment(Appointment appointment, Appointment newAppointment)
        {
            string updateStatement =
                "UPDATE Appointment SET " +
                "doctorID = @NewDoctorID," +
                "reasonForVisit = @NewReason, " +
                "apptDatetime = @NewDateTime " +
                "WHERE appointmentID = @AppointmentID " +
                "AND doctorID = @OldDoctorID " +
                "AND reasonForVisit = @OldReason " +
                "AND apptDatetime = @OldDateTime ";
            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand updateCommand = new SqlCommand(updateStatement, connection))
                {
                    updateCommand.Parameters.AddWithValue("@AppointmentID", appointment.AppointmentID);
                    updateCommand.Parameters.AddWithValue("@NewDoctorID", newAppointment.AppointmentDoctorID);
                    updateCommand.Parameters.AddWithValue("@NewReason", newAppointment.AppointmentReason);
                    updateCommand.Parameters.AddWithValue("@NewDateTime", newAppointment.AppointmentDateTime);
                    updateCommand.Parameters.AddWithValue("@OldDoctorID", appointment.AppointmentDoctorID);
                    updateCommand.Parameters.AddWithValue("@OldReason", appointment.AppointmentReason);
                    updateCommand.Parameters.AddWithValue("@OldDateTime", appointment.AppointmentDateTime);

                    int count = updateCommand.ExecuteNonQuery();
                    return count > 0;
                }
            }
        }


        /// <summary>
        /// Check doctorID and apptDateTime and returns true if there is a match; false if not
        /// </summary>
        /// <param name="doctorID">The doctorID to check against</param>
        /// <param name="apptDateTime">The appointment time to check against</param>
        /// <returns></returns>
        public static bool CheckDoubleBooking(int doctorID, DateTime apptDateTime)
        {
            List<Appointment> apptWithDoubleBooking = new List<Appointment>();
            string selectStatement =
                "SELECT appointmentID " +
                "FROM Appointment " +
                "WHERE doctorID = @DoctorID " +
                "AND apptDatetime BETWEEN DATEADD(MINUTE, -1, @ApptDateTime) AND DATEADD(MINUTE, 1, @ApptDateTime)";
            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@DoctorID", doctorID);
                    selectCommand.Parameters.AddWithValue("@ApptDateTime", apptDateTime);
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        int apptIDOrd = reader.GetOrdinal("appointmentID");
                        while (reader.Read())
                        {
                            Appointment appointment = new Appointment();
                            appointment.AppointmentID = reader.GetInt32(apptIDOrd);
                            apptWithDoubleBooking.Add(appointment);
                        }
                    }
                    
                }
                return apptWithDoubleBooking.Count > 0;
            }
        }
            

    }
}
