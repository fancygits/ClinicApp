using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicApp.UserControls
{
    public partial class LabTestReportUserControl : UserControl
    {
        public LabTestReportUserControl()
        {
            InitializeComponent();
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            DateTime startDate = Convert.ToDateTime(this.dateTimePicker1.Text);
            DateTime endDate = Convert.ToDateTime(this.dateTimePickerEndDate.Text);
            this.sp_mostPerformedTestsDuringDatesTableAdapter.Fill(this._CS6232_g1DataSet.sp_mostPerformedTestsDuringDates, startDate, endDate);
            this.reportViewer1.RefreshReport();
        }
    }
}
