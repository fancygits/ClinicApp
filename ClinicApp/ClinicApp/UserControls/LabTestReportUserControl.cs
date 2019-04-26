using System;
using System.Windows.Forms;
using ClinicApp.View;

namespace ClinicApp.UserControls
{
    public partial class LabTestReportUserControl : UserControl
    {
        private ErrorProvider errorProvider;
        public LabTestReportUserControl()
        {
            InitializeComponent();
            this.errorProvider = new ErrorProvider();
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validator.IsValidDate(dateTimePickerStartDate, dateTimePickerStartDate.Value, dateTimePickerEndDate.Value, this.errorProvider))
                {
                    DateTime startDate = Convert.ToDateTime(this.dateTimePickerStartDate.Text);
                    DateTime endDate = Convert.ToDateTime(this.dateTimePickerEndDate.Text);
                    this.sp_mostPerformedTestsDuringDatesTableAdapter.Fill(this._CS6232_g1DataSet.sp_mostPerformedTestsDuringDates, startDate, endDate);
                    this.reportViewer1.RefreshReport();
                }
                  
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }


        }
    }
}
