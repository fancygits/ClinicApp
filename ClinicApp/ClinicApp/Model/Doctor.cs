
namespace ClinicApp.Model
{
    /// <summary>
    /// Properties with get/set for Doctor attributes
    /// </summary>
    public class Doctor : Person
    {
        public int DoctorID { get; set; }
        public string FullName { get; set; }
    }
}
