using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ClinicApp.Controller;
using ClinicApp.Model;

namespace ClinicApp.UserControls
{
    public partial class AddVisitUserControl : UserControl
    {
        public Visit visit;
        public Nurse nurse;
        private List<Nurse> listOfNurses;
        private VisitController visitController;
        public AddVisitUserControl()
        {
            InitializeComponent();
            this.listOfNurses = new List<Nurse>();
            this.visitController = new VisitController();
        }

        public int apptID;
        public string nurseName;
        public string birthDate;
        private void AddVisitUserControl_Load(object sender, EventArgs e)
        {
            this.listOfNurses = this.visitController.GetNurses();
            this.nurseNameComboBox.DataSource = this.listOfNurses;
            if (this.visit.NurseID > 0)
            {
                this.nurseNameComboBox.SelectedValue = this.visit.NurseID;
            } else
            {
                this.nurseNameComboBox.SelectedIndex = -1;
            }
        }
        private void PutData(Visit newVisit)
        {
            try
            {
                newVisit.AppointmentID = Convert.ToInt32(this.appointmentIDTextBox.Text);
                newVisit.NurseID = (int)this.nurseNameComboBox.SelectedValue;
                newVisit.Weight = Convert.ToDecimal(this.weightTextBox.Text);
                newVisit.SystolicBP = Convert.ToInt32(this.systolicBPTextBox.Text);
                newVisit.DiastolicBP = Convert.ToInt32(this.diastolicBPTextBox.Text);
                newVisit.Temperature = Convert.ToDecimal(this.temperatureTextBox.Text);
                newVisit.Pulse = Convert.ToInt32(this.pulseTextBox.Text);
                newVisit.Symptoms = this.symptomsTextBox.Text;
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }

        }

        private void updateVisitButton_Click(object sender, EventArgs e)
        {
            Visit newVisit = new Visit();
            this.PutData(newVisit);
            try
            {
                if (!this.visitController.UpdateVisit(this.visit, newVisit))
                {
                    MessageBox.Show("Someone has already updated that visit");
                } else
                {
                    this.visit = newVisit;
                    MessageBox.Show("Your visit has been successfully updated", "Success");
                    NurseDashboard.Instance().searchForVisitUserControl1.DisplayVistsByPatient();
                    this.PutData(newVisit);
                }
            } catch (Exception ex)
            {
                MessageBox.Show("Error updating table", ex.GetType().ToString());
            }

        }

        private void addVisitButton_Click(object sender, EventArgs e)
        {
            Visit newVisit = new Visit();
            this.PutData(newVisit);
            try
            {
                if(!this.visitController.AddVisit(newVisit))
                {
                    MessageBox.Show("There was an error adding your visit");
                } else
                {
                    MessageBox.Show("Your visit was successfully added", "Success");
                    NurseDashboard.Instance().searchForVisitUserControl1.DisplayVistsByPatient();
                    this.addVisitButton.Enabled = false;
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
           
        }
    }
}
