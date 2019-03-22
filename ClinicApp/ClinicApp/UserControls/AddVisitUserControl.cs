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
            newVisit.AppointmentID = Convert.ToInt32(this.appointmentIDTextBox.Text);
            newVisit.NurseID = (int)this.nurseNameComboBox.SelectedValue;
            newVisit.Weight = Convert.ToDecimal(this.weightTextBox.Text);
            newVisit.SystolicBP = Convert.ToInt32(this.systolicBPTextBox.Text);
            newVisit.DiastolicBP = Convert.ToInt32(this.diastolicBPTextBox.Text);
            newVisit.Temperature = Convert.ToDecimal(this.temperatureTextBox.Text);
            newVisit.Pulse = Convert.ToInt32(this.pulseTextBox.Text);
            newVisit.Symptoms = this.symptomsTextBox.Text;
        }

        private void updateVisitButton_Click(object sender, EventArgs e)
        {
            Visit newVisit = new Visit();
            this.PutData(newVisit);
     //       try
     //       {
                if (!this.visitController.UpdateVisit(this.visit, newVisit))
                {
                    MessageBox.Show("Someone has already updated that visit");
                } else
                {
                    this.visit = newVisit;
                    MessageBox.Show("Your visit has been successfully updated", "Success");
                }
      //      } catch (Exception ex)
      //      {
      //          MessageBox.Show("Error updating table", ex.GetType().ToString());
      //      }

        }
    }
}
