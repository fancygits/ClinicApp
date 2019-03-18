using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicApp.Controller;
using ClinicApp.Model;

namespace ClinicApp.UserControls
{
    public partial class AddVisitUserControl : UserControl
    {
        private NurseController nurseController;
        private List<Nurse> nurseList;
        public AddVisitUserControl()
        {
            InitializeComponent();
            this.nurseList = new List<Nurse>();
            this.nurseController = new NurseController();
        }
    }
}
