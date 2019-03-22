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
        public Visit visit;
        private List<Visit> listOfNurses;
        private VisitController visitController;
        public AddVisitUserControl()
        {
            InitializeComponent();
            this.listOfNurses = new List<Visit>();
            this.visitController = new VisitController();
        }

        public int apptID;
        public string nurseName;
        public string birthDate;
        private void AddVisitUserControl_Load(object sender, EventArgs e)
        {
            this.listOfNurses = this.visitController.GetNurses();
            this.nurseNameComboBox.DataSource = this.listOfNurses;
            this.nurseNameComboBox.SelectedValue = -1;
        }
    }
}
