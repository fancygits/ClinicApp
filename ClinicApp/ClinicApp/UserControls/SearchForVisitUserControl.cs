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
        private VisitController visitController;
        private Visit visit;
        private List<Visit> listOfPatients;
        private List<Visit> listOfVisits;
        public SearchForVisitUserControl()
        {
            InitializeComponent();
            this.listOfPatients = new List<Visit>();
            this.listOfVisits = new List<Visit>();
            this.visitController = new VisitController();

        }

        /// <summary>
        /// This method will display the visits by the patient that is selected
        /// </summary>
        public void DisplayVistsByPatient()
        {
            if(this.patientNameComboBox.SelectedIndex < 0)
            {
                return;
            }
            this.visit = this.listOfPatients[this.patientNameComboBox.SelectedIndex];
            visitBindingSource.Clear();
            visitBindingSource.Add(this.visit);
            try
            {
                this.listOfVisits = this.visitController.GetListOfVisits(this.visit.PatientID);
                if (this.listOfVisits.Count > 0)
                {
                    visitDataGridView.DataSource = this.listOfVisits;
                } else
                {
                    this.listOfVisits = new List<Visit>();
                    visitDataGridView.DataSource = this.listOfVisits;
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Data Error");
            }
        
        }

        public void PopulateComboBox()
        {
            this.listOfPatients = this.visitController.GetPatients();
            this.patientNameComboBox.DataSource = this.listOfPatients;
        }

        private void SearchForVisitUserControl_Load(object sender, EventArgs e)
        {
            this.PopulateComboBox();
        }

        private void patientNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.DisplayVistsByPatient();
        }
    }
}
