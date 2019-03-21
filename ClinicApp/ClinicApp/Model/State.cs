namespace ClinicApp.Model
{
    /// <summary>
    /// Defines a State in US or Canada
    /// </summary>
    public class State

    {
        public string Name { get; set; }
        public string Abbreviation { get; set; }

        /// <summary>
        /// Constructs a new State
        /// </summary>
        /// <param name="abbreviation">2 character abbreviation</param>
        /// <param name="name">State Name</param>
        public State(string abbreviation, string name)
        {
            this.Name = name;
            this.Abbreviation = abbreviation;
        }
    }
    
}
