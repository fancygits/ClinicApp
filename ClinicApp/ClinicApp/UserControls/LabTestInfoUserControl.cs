using System;
using System.Windows.Forms;
using ClinicApp.Controller;
using ClinicApp.Model;

namespace ClinicApp.UserControls
{
    /// <summary>
    /// User Control for displaying, updating and deleting Lab Tests
    /// </summary>
    public partial class LabTestInfoUserControl : UserControl
    {
        private readonly LabTestController labTestController;
        public TestOrdered testOrdered;
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
            testOrderedBindingSource.Add(this.testOrdered);
        }

        private void LabTestInfoUserControl_Load(object sender, System.EventArgs e)
        {
            this.RefreshPage();
        }

        private void btnUpdate_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (!this.labTestController.UpdateTestOrdered(new TestOrdered(), new TestOrdered()))
                {
                    MessageBox.Show("Another user has updated this LabTest. Please modify and try again", "Database Error");
                }
                else
                {
                    MessageBox.Show("Lab Test Updated");
                    this.testOrdered = this.newTestOrdered;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }
    }
}
