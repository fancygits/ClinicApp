using System;
using System.Windows.Forms;
using ClinicApp.Controller;
using ClinicApp.Model;
using ClinicApp.View;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
                    MessageBox.Show("Lab Test Updated");
                    this.testOrdered = this.newTestOrdered;
                    OrderLabTestDialog.Instance().orderLabTestUserControl1.RefreshPage();
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
    }
}
