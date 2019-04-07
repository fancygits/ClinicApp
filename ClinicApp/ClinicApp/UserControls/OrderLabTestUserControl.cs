
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ClinicApp.Controller;
using ClinicApp.Model;


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
            this.GetTestOrderedList(241);
        }

        private void GetTestOrderedList(int appointmentID)
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
            try
            {
                if (this.labTestController.AddTestOrdered(new TestOrdered()))
                {
                    MessageBox.Show("Test Added");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }

        }
    }
}
