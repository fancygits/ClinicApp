
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
        }
    }
}
