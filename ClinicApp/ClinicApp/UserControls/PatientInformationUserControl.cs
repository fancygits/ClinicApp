using ClinicApp.Controller;
using ClinicApp.Model;
using System;
using System.Windows.Forms;

namespace ClinicApp.UserControls
{
    public partial class PatientInformationUserControl : UserControl
    {
        private readonly PatientController patientController;

        public PatientInformationUserControl()
        {
            InitializeComponent();
            this.patientController = new PatientController();
        }

        private void PatientInformationUserControl_Load(object sender, System.EventArgs e)
        {
            patientBindingSource.Clear();
           
        }

        private void btnGetPatient_Click(object sender, EventArgs e)
        {
            int patientID = Convert.ToInt32(patientIDNumericUpDown.Value);
            try
            {
                Patient patient = this.patientController.GetPatient(patientID);
                patientBindingSource.Clear();
                patientBindingSource.Add(patient);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }
    }
}
