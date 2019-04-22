using ClinicApp.Controller;
using ClinicApp.Model;
using ClinicApp.View;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ClinicApp.UserControls
{/// <summary>
/// This is the UserControl that will allow a user to add or update a patient visit.
/// </summary>
    public partial class AddVisitUserControl : UserControl
    {
        public Visit visit;
        public Nurse nurse;
        private NurseController nurseController;
        private List<Nurse> listOfNurses;
        private VisitController visitController;
        private LabTestController labTestController;
        private List<TestOrdered> testOrderedList;
        private ErrorProvider errorProvider;
        public AddVisitUserControl()
        {
            InitializeComponent();
            this.listOfNurses = new List<Nurse>();
            this.visitController = new VisitController();
            this.nurseController = new NurseController();
            this.labTestController = new LabTestController();
            this.errorProvider = new ErrorProvider();
            this.visit = new Visit();
        }

        public int apptID;
        public string nurseName;
        public string birthDate;
        private void AddVisitUserControl_Load(object sender, EventArgs e)
        {
            this.listOfNurses = this.nurseController.GetNurseList();
            this.nurseNameComboBox.DataSource = this.listOfNurses;
            if (this.visit.NurseID > 0)
            {
                this.nurseNameComboBox.SelectedValue = this.visit.NurseID;
                this.nurseNameComboBox.SelectedText = this.visit.NurseName;
            }
            else
            {
                this.nurseNameComboBox.SelectedIndex = -1;
            }
        }

        private bool PutData(Visit newVisit)
        {
            bool isValid = false;
            try
            {
                newVisit.AppointmentID = Convert.ToInt32(this.appointmentIDTextBox.Text);
                newVisit.NurseID = (int)this.nurseNameComboBox.SelectedValue;
                if (Validator.IsDecimal(this.weightTextBox, errorProvider) &&
                   Validator.IsInt32(this.systolicBPTextBox, errorProvider) &&
                   Validator.IsInt32(this.diastolicBPTextBox, errorProvider) &&
                   Validator.IsDecimal(this.temperatureTextBox, errorProvider) &&
                   Validator.IsInt32(this.pulseTextBox, errorProvider) &&
                   Validator.IsPresent(this.symptomsTextBox, errorProvider))
           //        Validator.IsPresent(this.initialDiagnosisTextBox, errorProvider))
                {
                    newVisit.Weight = Convert.ToDecimal(this.weightTextBox.Text);
                    newVisit.SystolicBP = Convert.ToInt32(this.systolicBPTextBox.Text);
                    newVisit.DiastolicBP = Convert.ToInt32(this.diastolicBPTextBox.Text);
                    newVisit.Temperature = Convert.ToDecimal(this.temperatureTextBox.Text);
                    newVisit.Pulse = Convert.ToInt32(this.pulseTextBox.Text);
                    newVisit.Symptoms = this.symptomsTextBox.Text;
                    newVisit.InitialDiagnosis = this.initialDiagnosisTextBox.Text;
                    isValid = true;
                } else
                {
                    isValid = false;
                }
                if (!this.finalDiagnosisTextBox.Equals(""))
                {
                    newVisit.FinalDiagnosis = this.finalDiagnosisTextBox.Text;
                } else
                {
                    newVisit.FinalDiagnosis = DBNull.Value.ToString();
                }

            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
            return isValid;

        }

        private void updateVisitButton_Click(object sender, EventArgs e)
        {
            Visit newVisit = new Visit();
            if (this.PutData(newVisit))
            {
                try
                {
                    if (!this.visitController.UpdateVisit(this.visit, newVisit))
                    {
                        MessageBox.Show("Someone has already updated that visit");
                    }
                    else
                    {
                        this.visit = newVisit;
                        AddVisitDialog.Instance().Hide();
                        //MessageBox.Show("Your visit has been successfully updated", "Success");
                        NurseDashboard.Instance().searchForVisitUserControl1.DisplayVistsByPatient();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
            }
            

        }

        private void addVisitButton_Click(object sender, EventArgs e)
        {
            Visit newVisit = new Visit();
            if (this.PutData(newVisit))
            {
                try
                {
                    if (!this.visitController.AddVisit(newVisit))
                    {
                        MessageBox.Show("There was an error adding your visit");
                    }
                    else
                    {
                        AddVisitDialog.Instance().Hide();
                        //MessageBox.Show("Your visit was successfully added", "Success");
                        NurseDashboard.Instance().searchForVisitUserControl1.DisplayVistsByPatient();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
            }
           
        }


        /// <summary>
        /// Sets the ordered lab tests and results list on Visit screen
        /// </summary>
        public void SetTestOrderedLabel()
        {
            this.testOrderedList = null;
            lblTestHeader.Visible = false;
            lblResults.Visible = false;
            lblTestOrdered.Text = "";
            llbAbResults.Text = "";
            try
            {
                this.testOrderedList = this.labTestController.GetTestOrderedByAppointmentID(this.visit.AppointmentID);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
            if (this.testOrderedList.Count > 0)
            {
                lblTestHeader.Visible = true;
                lblResults.Visible = true;
                string testNames = "";
                for (int i = 0; i < this.testOrderedList.Count; i++)
                {
                    testNames += this.testOrderedList[i].Name.ToString() + "\n";
                }
                string testResults = "";
                for (int i = 0; i < this.testOrderedList.Count; i++)
                {
                    testResults += this.testOrderedList[i].Result.ToString() + "\n";
                }
                lblTestOrdered.Text = testNames;
                llbAbResults.Text = testResults;
            }
        }

       

        private void btnLabTest_Click(object sender, EventArgs e)
        {
            //OrderLabTestDialog orderLabTestForm = new OrderLabTestDialog();
            //orderLabTestForm.orderLabTestUserControl1.visit = visit;
            //DialogResult result = orderLabTestForm.ShowDialog();
            //if (result == DialogResult.OK)
            //{

            //}
            if (this.visit.FinalDiagnosis != null)
            {
                OrderLabTestDialog.Instance().orderLabTestUserControl1.isFnaliazed = true;
            }
            else
            {
                OrderLabTestDialog.Instance().orderLabTestUserControl1.isFnaliazed = false;
            }
            OrderLabTestDialog.Instance().orderLabTestUserControl1.visit = visit;
            OrderLabTestDialog.Instance().orderLabTestUserControl1.RefreshPage();
            OrderLabTestDialog.Instance().Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            AddVisitDialog.Instance().Hide();
            this.errorProvider.Clear();
        }
    }
}
