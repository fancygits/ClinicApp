using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicApp.Model;
using ClinicApp.Controller;

namespace ClinicApp.UserControls
{
    public partial class SearchForVisitUserControl : UserControl
    {
        private Visit visit;
        private VisitController visitController;
        private List<Visit> listOfPatients;
        public SearchForVisitUserControl()
        {
            InitializeComponent();
            this.listOfPatients = new List<Visit>();
            this.visitController = new VisitController();

        }


        private void PopulateComboBox()
        {
            this.listOfPatients = this.visitController.GetPatients();
            this.patientNameComboBox.DataSource = this.listOfPatients;
        }

        private void SearchForVisitUserControl_Load(object sender, EventArgs e)
        {
            this.PopulateComboBox();
        }
    }
}
