namespace ClinicApp.UserControls
{
    partial class LabTestReportUserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.sp_mostPerformedTestsDuringDatesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._CS6232_g1DataSet = new ClinicApp._CS6232_g1DataSet();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.dateTimePickerStartDate = new System.Windows.Forms.DateTimePicker();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.spmostPerformedTestsDuringDatesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_mostPerformedTestsDuringDatesTableAdapter = new ClinicApp._CS6232_g1DataSetTableAdapters.sp_mostPerformedTestsDuringDatesTableAdapter();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dateTimePickerEndDate = new System.Windows.Forms.DateTimePicker();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sp_mostPerformedTestsDuringDatesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._CS6232_g1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spmostPerformedTestsDuringDatesBindingSource)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // sp_mostPerformedTestsDuringDatesBindingSource
            // 
            this.sp_mostPerformedTestsDuringDatesBindingSource.DataMember = "sp_mostPerformedTestsDuringDates";
            this.sp_mostPerformedTestsDuringDatesBindingSource.DataSource = this._CS6232_g1DataSet;
            // 
            // _CS6232_g1DataSet
            // 
            this._CS6232_g1DataSet.DataSetName = "_CS6232_g1DataSet";
            this._CS6232_g1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblStartDate
            // 
            this.lblStartDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.Location = new System.Drawing.Point(20, 0);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(48, 32);
            this.lblStartDate.TabIndex = 2;
            this.lblStartDate.Text = "Start Date";
            // 
            // dateTimePickerStartDate
            // 
            this.dateTimePickerStartDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePickerStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerStartDate.Location = new System.Drawing.Point(157, 6);
            this.dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            this.dateTimePickerStartDate.Size = new System.Drawing.Size(102, 20);
            this.dateTimePickerStartDate.TabIndex = 4;
            this.dateTimePickerStartDate.Tag = "Start Date";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "LabTestReport2";
            reportDataSource1.Value = this.sp_mostPerformedTestsDuringDatesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ClinicApp.LabReports.LabTestReport2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(2, 70);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(636, 329);
            this.reportViewer1.TabIndex = 6;
            // 
            // spmostPerformedTestsDuringDatesBindingSource
            // 
            this.spmostPerformedTestsDuringDatesBindingSource.DataMember = "sp_mostPerformedTestsDuringDates";
            this.spmostPerformedTestsDuringDatesBindingSource.DataSource = this._CS6232_g1DataSet;
            // 
            // sp_mostPerformedTestsDuringDatesTableAdapter
            // 
            this.sp_mostPerformedTestsDuringDatesTableAdapter.ClearBeforeFill = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.reportViewer1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.12062F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.87938F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(640, 401);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.79671F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.20329F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 307F));
            this.tableLayoutPanel2.Controls.Add(this.dateTimePickerEndDate, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblStartDate, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblEndDate, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.dateTimePickerStartDate, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnGenerateReport, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(636, 64);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // dateTimePickerEndDate
            // 
            this.dateTimePickerEndDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePickerEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerEndDate.Location = new System.Drawing.Point(157, 38);
            this.dateTimePickerEndDate.Name = "dateTimePickerEndDate";
            this.dateTimePickerEndDate.Size = new System.Drawing.Size(102, 20);
            this.dateTimePickerEndDate.TabIndex = 5;
            this.dateTimePickerEndDate.Tag = "End Date";
            // 
            // lblEndDate
            // 
            this.lblEndDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDate.Location = new System.Drawing.Point(5, 38);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(77, 20);
            this.lblEndDate.TabIndex = 3;
            this.lblEndDate.Text = "End Date";
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGenerateReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateReport.Location = new System.Drawing.Point(410, 9);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.tableLayoutPanel2.SetRowSpan(this.btnGenerateReport, 2);
            this.btnGenerateReport.Size = new System.Drawing.Size(144, 46);
            this.btnGenerateReport.TabIndex = 1;
            this.btnGenerateReport.Text = "Generate Report";
            this.btnGenerateReport.UseVisualStyleBackColor = true;
            this.btnGenerateReport.Click += new System.EventHandler(this.btnGenerateReport_Click);
            // 
            // LabTestReportUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "LabTestReportUserControl";
            this.Size = new System.Drawing.Size(640, 401);
            ((System.ComponentModel.ISupportInitialize)(this.sp_mostPerformedTestsDuringDatesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._CS6232_g1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spmostPerformedTestsDuringDatesBindingSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource spmostPerformedTestsDuringDatesBindingSource;
        private _CS6232_g1DataSet _CS6232_g1DataSet;
        private _CS6232_g1DataSetTableAdapters.sp_mostPerformedTestsDuringDatesTableAdapter sp_mostPerformedTestsDuringDatesTableAdapter;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartDate;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sp_mostPerformedTestsDuringDatesBindingSource;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Button btnGenerateReport;
    }
}
