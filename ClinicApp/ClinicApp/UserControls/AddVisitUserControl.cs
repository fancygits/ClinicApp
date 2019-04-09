﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ClinicApp.Controller;
using ClinicApp.Model;
using ClinicApp.View;

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
        private ErrorProvider errorProvider;
        public AddVisitUserControl()
        {
            InitializeComponent();
            this.listOfNurses = new List<Nurse>();
            this.visitController = new VisitController();
            this.nurseController = new NurseController();
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
            } else
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
                newVisit.Weight = Convert.ToDecimal(this.weightTextBox.Text);
                newVisit.SystolicBP = Convert.ToInt32(this.systolicBPTextBox.Text);
                newVisit.DiastolicBP = Convert.ToInt32(this.diastolicBPTextBox.Text);
                newVisit.Temperature = Convert.ToDecimal(this.temperatureTextBox.Text);
                newVisit.Pulse = Convert.ToInt32(this.pulseTextBox.Text);
                if (Validator.IsPresent(this.symptomsTextBox, errorProvider))
                {
                    newVisit.Symptoms = this.symptomsTextBox.Text;
                    isValid = true;
                }
                if (Validator.IsPresent(this.initialDiagnosisTextBox, errorProvider))
                {
                    newVisit.InitialDiagnosis = this.initialDiagnosisTextBox.Text;
                    isValid = true;
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
                        MessageBox.Show("Your visit has been successfully updated", "Success");
                        NurseDashboard.Instance().searchForVisitUserControl1.DisplayVistsByPatient();
                        this.PutData(newVisit);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating table", ex.GetType().ToString());
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
                        MessageBox.Show("Your visit was successfully added", "Success");
                        NurseDashboard.Instance().searchForVisitUserControl1.DisplayVistsByPatient();
                        this.addVisitButton.Enabled = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
            }
            
           
        }

        private void btnLabTest_Click(object sender, EventArgs e)
        {
            OrderLabTestDialog orderLabTestForm = new OrderLabTestDialog();
            orderLabTestForm.orderLabTestUserControl1.visit = visit;
            MessageBox.Show(orderLabTestForm.orderLabTestUserControl1.visit.AppointmentID.ToString());
            DialogResult result = orderLabTestForm.ShowDialog();
            if (result == DialogResult.OK)
            {

            }
        }
    }
}
