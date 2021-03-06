﻿using System;
using System.Windows.Forms;
using ClinicApp.Controller;
using ClinicApp.Model;
using ClinicApp.View;

namespace ClinicApp.UserControls
{
    /// <summary>
    /// User Control for displaying, updating and deleting Lab Tests
    /// </summary>
    public partial class LabTestInfoUserControl : UserControl
    {
        private readonly LabTestController labTestController;
        public TestOrdered testOrdered;
        public bool isFinalized;
        private TestOrdered newTestOrdered;

        /// <summary>
        /// Constructor for the User Control
        /// </summary>
        public LabTestInfoUserControl()
        {
            InitializeComponent();
            this.labTestController = new LabTestController();
            this.newTestOrdered = new TestOrdered();
        }


        private void RefreshPage()
        {
            //testOrderedBindingSource.Clear();
            //testOrderedBindingSource.Add(this.testOrdered);
            this.SetDisplay();
        }

        private void LabTestInfoUserControl_Load(object sender, System.EventArgs e)
        {
            this.RefreshPage();
        }

        private void SetDisplay()
        {
            dateTimePickerTestDate.Value = this.testOrdered.Date;
            txBxTestName.Text = this.testOrdered.Name;
            ckBxAbnResults.Checked = this.testOrdered.Result;
            txBxResultDetail.Text = this.testOrdered.ResultDetail;

            if (isFinalized)
            {
                txBxResultDetail.Enabled = false;
                dateTimePickerTestDate.Enabled = false;
                ckBxAbnResults.Enabled = false;
                btnDelete.Enabled = false;
                btnUpdate.Enabled = false;
            }
            else
            {
                txBxResultDetail.Enabled = true;
                dateTimePickerTestDate.Enabled = true;
                ckBxAbnResults.Enabled = true;
                btnDelete.Enabled = true;
                btnUpdate.Enabled = true;
            }
        }

        private void PutLabTest()
        {
            this.newTestOrdered.AppointmentID = this.testOrdered.AppointmentID;
            this.newTestOrdered.TestCode = this.testOrdered.TestCode;
            this.newTestOrdered.Date = dateTimePickerTestDate.Value;
            this.newTestOrdered.Result = ckBxAbnResults.Checked;
            this.newTestOrdered.ResultDetail = txBxResultDetail.Text;
        }

        private void btnUpdate_Click(object sender, System.EventArgs e)
        {
            this.PutLabTest();
            try
            {
                if (!this.labTestController.UpdateTestOrdered(this.testOrdered, this.newTestOrdered))
                {
                    MessageBox.Show("Another user has updated this LabTest. Please modify and try again", "Database Error");
                }
                else
                {
                    OrderLabTestDialog.Instance().orderLabTestUserControl1.RefreshPage();
                    OrderLabTestDialog.Instance().orderLabTestUserControl1.SetMessage(this.testOrdered.Name.ToString() + " was updated on the Patient Lab Order");
                    Form labInfo = (Form)this.Parent;
                    labInfo.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Form labInfo = (Form)this.Parent;
            labInfo.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.labTestController.DeleteTestOrdered(this.testOrdered))
                {
                    OrderLabTestDialog.Instance().orderLabTestUserControl1.RefreshPage();
                    OrderLabTestDialog.Instance().orderLabTestUserControl1.SetMessage(this.testOrdered.Name.ToString() + " was deleted from the Patient Lab Order");
                    Form labInfo = (Form)this.Parent;
                    labInfo.Close();
                }
                else
                {
                    MessageBox.Show("There was a problem deleting this test.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }
    }
}
