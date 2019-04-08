using System.Windows.Forms;
using ClinicApp.Controller;
using ClinicApp.Model;

namespace ClinicApp.UserControls
{
    public partial class LabTestInfoUserControl : UserControl
    {
        private readonly LabTestController labTestController;
        public TestOrdered testOrdered;
        public LabTestInfoUserControl()
        {
            InitializeComponent();
            this.labTestController = new LabTestController();
        }

        private void DisplayTestOrdered()
        {
            txBxTestName.Text = this.testOrdered.Name;
            txBxResultDetail.Text = this.testOrdered.ResultDetail;
            dateTimePickerTestDate.Value = this.testOrdered.Date;
            ckBxAbnResults.Checked = this.testOrdered.Result;
        }

        private void LabTestInfoUserControl_Load(object sender, System.EventArgs e)
        {
            this.DisplayTestOrdered();
        }
    }
}
