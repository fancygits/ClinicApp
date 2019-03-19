using System;
using System.Collections.Generic;
using ClinicApp.Model;
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
                "SELECT apptDatetime, firstName, lastName, reasonForVisit " +
                "FROM Appointment app " +
                "JOIN Doctor doc " +
                "ON app.doctorID = doc.doctorID " +
                "JOIN Person per " +
                "ON doc.personID = per.personID " +
                "WHERE patientID = 5 " +
                "ORDER BY apptDatetime";
            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    //selectCommand.Parameters.AddWithValue("@PatientID", patientID);
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        int apptDateTimeOrd = reader.GetOrdinal("apptDatetime");
                        int firstNameOrd = reader.GetOrdinal("firstName");
                        int lastNameOrd = reader.GetOrdinal("lastName");
                        int reasonForVisitOrd = reader.GetOrdinal("reasonForVisit");
                        while (reader.Read())
                        {
                            Appointment appointment = new Appointment();
                            appointment.AppointmentDateTime = reader.GetDateTime(apptDateTimeOrd);
                            appointment.AppointmentDoctorFirstName = reader.GetString(firstNameOrd);
                            appointment.AppointmentDoctorLastName = reader.GetString(lastNameOrd);
                            appointment.AppointmentReason = reader.GetString(reasonForVisitOrd);
                            appointmentsByPatientID.Add(appointment);
                        }
                        reader.Close();
                    };
                }
                return appointmentsByPatientID;
            };
        }
    }
}
