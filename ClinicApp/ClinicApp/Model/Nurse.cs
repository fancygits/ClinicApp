namespace ClinicApp.Model
{

    /// <summary>
    /// Defines a Nurse Person
    /// </summary>
    public class Nurse : Person
    {
        public int NurseID { get; set; }
        public bool Active { get; set; }
    }
}
