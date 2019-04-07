using System;

namespace ClinicApp.Model
{
    /// <summary>
    /// Properties with get/set for TestOrdered object
    /// </summary>
    public class TestOrdered
    {
        public int AppointmentID { get; set; }
        public int TestCode { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public bool Result { get; set; }
        public string ResultDetail { get; set; }

    }
}
