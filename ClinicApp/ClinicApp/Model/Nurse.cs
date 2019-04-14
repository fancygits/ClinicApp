namespace ClinicApp.Model
{
    public class Nurse : Person
    {
        public int NurseID { get; set; }
        public bool Active { get; set; }

        public string Password { get; set; }
    }
}
