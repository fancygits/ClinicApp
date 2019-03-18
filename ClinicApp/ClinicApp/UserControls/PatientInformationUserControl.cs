using ClinicApp.Controller;
using ClinicApp.Model;
using System;
using System.Windows.Forms;

namespace ClinicApp.UserControls
{
    public partial class PatientInformationUserControl : UserControl
    {
        private readonly PatientController patientController;
        private readonly NurseController nurseController;

        public PatientInformationUserControl()
        {
            InitializeComponent();
            this.patientController = new PatientController();
            this.nurseController = new NurseController();
        }

        private void PatientInformationUserControl_Load(object sender, System.EventArgs e)
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void GetPatient(object sender, EventArgs e)
        {
            try
            {
                int patientID = Convert.ToInt32(patientIDNumericUpDown.Value);
                Patient patient = this.patientController.GetPatient(patientID);
                patientBindingSource.Clear();
                patientBindingSource.Add(patient);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void GetNurse(object sender, EventArgs e)
        {
            try
            {
                int nurseID = Convert.ToInt32(nurseIDNumericUpDown.Value);
                Nurse nurse = this.nurseController.GetNurse(nurseID);
                nurseBindingSource.Clear();
                nurseBindingSource.Add(nurse);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }
    }
}
