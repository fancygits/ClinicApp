
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
        }

        private void LoadComboBoxes()
        {
            try
            {
                List<LabTest> testList = new List<LabTest>();
                testList = labTestController.GetLabTests();
                cmboBoxTestID.DataSource = testList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void OrderLabTestUserControl_Load(object sender, EventArgs e)
        {
            this.LoadComboBoxes();
            this.RefreshPage();
        }

        private void RefreshPage()
        {
            this.GetTestOrderedList();
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
                    MessageBox.Show("Test Added");
                    this.RefreshPage();
                }
                else
                {
                    MessageBox.Show("Nope");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }

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
    }
}
