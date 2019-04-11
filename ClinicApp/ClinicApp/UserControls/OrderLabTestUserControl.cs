
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ClinicApp.Controller;
using ClinicApp.Model;
using ClinicApp.View;


namespace ClinicApp.UserControls
{
    /// <summary>
    /// User Control for TestOrdered
    /// </summary>
    public partial class OrderLabTestUserControl : UserControl
    {
        private readonly LabTestController labTestController;
        private List<TestOrdered> testOrderedList;
        public Visit visit;

        /// <summary>
        /// Constructor for the User Control
        /// </summary>
        public OrderLabTestUserControl()
        {
            InitializeComponent();
            this.labTestController = new LabTestController();
            testOrderedList = new List<TestOrdered>();
        }

        private void LoadComboBoxes()
        {
            try
            {
                List<LabTest> testList = new List<LabTest>();
                testList = labTestController.GetLabTests();
                this.GetTestOrderedList();
                if (this.testOrderedList.Count > 0)
                {
                    for (int i = 0; i < this.testOrderedList.Count; i++)
                    {
                        for (int j = 0; j < testList.Count; j++)
                        {
                            if (this.testOrderedList[i].TestCode == testList[j].TestCode)
                            {
                                testList.Remove(testList[j]);
                            }
                        }
                    }
                }
                if (testList.Count > 0)
                {
                    cmboBoxTestID.DataSource = testList;
                }
                else
                {
                    btnAddTest.Enabled = false;
                    cmboBoxTestID.Text = "No Lab Tests Available";
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }


        private void OrderLabTestUserControl_Load(object sender, EventArgs e)
        {
            
            this.RefreshPage();
        }

        public void RefreshPage()
        {
            this.LoadComboBoxes();
            this.GetTestOrderedList();
            this.SetDisplay();
        }

        public void SetDisplay()
        {
            if (this.visit.FinalDiagnosis != null)
            {
                MessageBox.Show(this.visit.FinalDiagnosis.ToString());
                btnAddTest.Enabled = false;
                btnOrder.Enabled = false;
            }
            else
            {
                MessageBox.Show("I'm in the else");
                btnAddTest.Enabled = true;
                btnOrder.Enabled = true;
            }
        }

        private void GetTestOrderedList()
        {
            try
            {
                this.testOrderedList = this.labTestController.GetTestOrderedByAppointmentID(this.visit.AppointmentID);
                testOrderedDataGridView.DataSource = this.testOrderedList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void btnAddTest_Click(object sender, EventArgs e)
        {
            TestOrdered testOrdered = new TestOrdered();
            testOrdered.AppointmentID = visit.AppointmentID;
            testOrdered.TestCode = (int)cmboBoxTestID.SelectedValue;
            try
            {
                if (this.labTestController.AddTestOrdered(testOrdered))
                {
                    //this.SetMessage(testOrdered.Name.ToString() + " was added to the Patients record.");
                    this.RefreshPage();
                }
                else
                {
                    //this.SetMessage("There was a problem adding this Lab Test.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void SetMessage(String message)
        {
            lblMessage.Text = message;
        }

        private void testOrderedDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                int i = e.RowIndex;
                DataGridViewRow row = testOrderedDataGridView.Rows[i];
                TestOrdered testOrdered = (TestOrdered)row.DataBoundItem;
                LabTestInfoDialog labTestInfoForm = new LabTestInfoDialog();
                labTestInfoForm.labTestInfoUserControl1.testOrdered = testOrdered;
                labTestInfoForm.Show();
                this.RefreshPage();
            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            OrderLabTestDialog.Instance().Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OrderLabTestDialog.Instance().Hide();
        }
    }
}
