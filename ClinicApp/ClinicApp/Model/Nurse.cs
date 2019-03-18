using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.Model
{
    class Nurse : Person
    {
        public int NurseID { get; set; }
        public bool Active { get; set; }
    }
}
