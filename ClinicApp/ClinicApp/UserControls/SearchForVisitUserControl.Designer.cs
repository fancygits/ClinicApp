namespace ClinicApp.UserControls
{
    partial class SearchForVisitUserControl
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
            System.Windows.Forms.Label patientNameLabel;
            System.Windows.Forms.Label patientIDLabel;
            this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.visitDataGridView = new System.Windows.Forms.DataGridView();
            this.NurseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AppointmentTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatientBirthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoctorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NurseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditViewVisit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.visitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.patientIDTextBox = new System.Windows.Forms.TextBox();
            this.patientNameComboBox = new System.Windows.Forms.ComboBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            patientNameLabel = new System.Windows.Forms.Label();
            patientIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitBindingSource)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // patientNameLabel
            // 
            patientNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            patientNameLabel.AutoSize = true;
            patientNameLabel.Location = new System.Drawing.Point(176, 46);
            patientNameLabel.Name = "patientNameLabel";
            patientNameLabel.Size = new System.Drawing.Size(147, 25);
            patientNameLabel.TabIndex = 0;
            patientNameLabel.Text = "Patient Name:";
            // 
            // patientIDLabel
            // 
            patientIDLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            patientIDLabel.AutoSize = true;
            patientIDLabel.Enabled = false;
            patientIDLabel.Location = new System.Drawing.Point(194, 155);
            patientIDLabel.Name = "patientIDLabel";
            patientIDLabel.Size = new System.Drawing.Size(111, 25);
            patientIDLabel.TabIndex = 2;
            patientIDLabel.Text = "Patient ID:";
            // 
            // patientBindingSource
            // 
            this.patientBindingSource.DataSource = typeof(ClinicApp.Model.Patient);
            // 
            // visitDataGridView
            // 
            this.visitDataGridView.AllowUserToDeleteRows = false;
            this.visitDataGridView.AutoGenerateColumns = false;
            this.visitDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.visitDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.visitDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NurseID,
            this.AppointmentTime,
            this.PatientBirthDate,
            this.PatientName,
            this.DoctorName,
            this.NurseName,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.EditViewVisit});
            this.visitDataGridView.DataSource = this.visitBindingSource;
            this.visitDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.visitDataGridView.Location = new System.Drawing.Point(3, 228);
            this.visitDataGridView.Name = "visitDataGridView";
            this.visitDataGridView.ReadOnly = true;
            this.visitDataGridView.RowTemplate.Height = 33;
            this.visitDataGridView.Size = new System.Drawing.Size(2074, 725);
            this.visitDataGridView.TabIndex = 1;
            this.visitDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.visitDataGridView_CellContentClick);
            // 
            // NurseID
            // 
            this.NurseID.DataPropertyName = "NurseID";
            this.NurseID.HeaderText = "NurseID";
            this.NurseID.Name = "NurseID";
            this.NurseID.ReadOnly = true;
            this.NurseID.Visible = false;
            this.NurseID.Width = 95;
            // 
            // AppointmentTime
            // 
            this.AppointmentTime.DataPropertyName = "AppointmentTime";
            this.AppointmentTime.HeaderText = "Appointment Date and Time";
            this.AppointmentTime.Name = "AppointmentTime";
            this.AppointmentTime.ReadOnly = true;
            this.AppointmentTime.Width = 215;
            // 
            // PatientBirthDate
            // 
            this.PatientBirthDate.DataPropertyName = "PatientBirthDate";
            this.PatientBirthDate.HeaderText = "PatientBirthDate";
            this.PatientBirthDate.Name = "PatientBirthDate";
            this.PatientBirthDate.ReadOnly = true;
            this.PatientBirthDate.Visible = false;
            this.PatientBirthDate.Width = 213;
            // 
            // PatientName
            // 
            this.PatientName.DataPropertyName = "PatientName";
            this.PatientName.HeaderText = "PatientName";
            this.PatientName.Name = "PatientName";
            this.PatientName.ReadOnly = true;
            this.PatientName.Visible = false;
            this.PatientName.Width = 180;
            // 
            // DoctorName
            // 
            this.DoctorName.DataPropertyName = "DoctorName";
            this.DoctorName.HeaderText = "Doctor";
            this.DoctorName.Name = "DoctorName";
            this.DoctorName.ReadOnly = true;
            this.DoctorName.Width = 120;
            // 
            // NurseName
            // 
            this.NurseName.DataPropertyName = "NurseName";
            this.NurseName.HeaderText = "Nurse";
            this.NurseName.Name = "NurseName";
            this.NurseName.ReadOnly = true;
            this.NurseName.Width = 114;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Weight";
            this.dataGridViewTextBoxColumn3.HeaderText = "Weight";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 124;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "SystolicBP";
            this.dataGridViewTextBoxColumn4.HeaderText = "Systolic BP";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 153;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "DiastolicBP";
            this.dataGridViewTextBoxColumn5.HeaderText = "Diastolic BP";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 160;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Temperature";
            this.dataGridViewTextBoxColumn6.HeaderText = "Temperature";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 179;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Pulse";
            this.dataGridViewTextBoxColumn7.HeaderText = "Pulse";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 111;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Symptoms";
            this.dataGridViewTextBoxColumn8.HeaderText = "Symptoms";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 157;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "InitialDiagnosis";
            this.dataGridViewTextBoxColumn9.HeaderText = "Initial Diagnosis";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 191;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "FinalDiagnosis";
            this.dataGridViewTextBoxColumn10.HeaderText = "Final Diagnosis";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 188;
            // 
            // EditViewVisit
            // 
            this.EditViewVisit.HeaderText = "Edit/View Visit";
            this.EditViewVisit.Name = "EditViewVisit";
            this.EditViewVisit.ReadOnly = true;
            this.EditViewVisit.Text = "Add/Update";
            this.EditViewVisit.UseColumnTextForButtonValue = true;
            this.EditViewVisit.Width = 139;
            // 
            // visitBindingSource
            // 
            this.visitBindingSource.DataSource = typeof(ClinicApp.Model.Visit);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.visitDataGridView, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.55507F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.44493F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(2080, 973);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.05979F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.94021F));
            this.tableLayoutPanel2.Controls.Add(patientIDLabel, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.patientIDTextBox, 1, 1);
            this.tableLayoutPanel2.Controls.Add(patientNameLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.patientNameComboBox, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 102F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(2074, 219);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // patientIDTextBox
            // 
            this.patientIDTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.patientIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "PatientID", true));
            this.patientIDTextBox.Enabled = false;
            this.patientIDTextBox.Location = new System.Drawing.Point(502, 152);
            this.patientIDTextBox.Name = "patientIDTextBox";
            this.patientIDTextBox.Size = new System.Drawing.Size(100, 31);
            this.patientIDTextBox.TabIndex = 3;
            // 
            // patientNameComboBox
            // 
            this.patientNameComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.patientNameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitBindingSource, "PatientName", true));
            this.patientNameComboBox.DataSource = this.patientBindingSource;
            this.patientNameComboBox.DisplayMember = "FullName";
            this.patientNameComboBox.FormattingEnabled = true;
            this.patientNameComboBox.Location = new System.Drawing.Point(502, 42);
            this.patientNameComboBox.Name = "patientNameComboBox";
            this.patientNameComboBox.Size = new System.Drawing.Size(1391, 33);
            this.patientNameComboBox.TabIndex = 1;
            this.patientNameComboBox.ValueMember = "PatientID";
            this.patientNameComboBox.SelectedIndexChanged += new System.EventHandler(this.patientNameComboBox_SelectedIndexChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "VisitAppointment";
            this.dataGridViewTextBoxColumn1.HeaderText = "VisitAppointment";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 218;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "VisitNurse";
            this.dataGridViewTextBoxColumn2.HeaderText = "VisitNurse";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 155;
            // 
            // SearchForVisitUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "SearchForVisitUserControl";
            this.Size = new System.Drawing.Size(2080, 973);
            this.Load += new System.EventHandler(this.SearchForVisitUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitBindingSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource visitBindingSource;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.BindingSource patientBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ComboBox patientNameComboBox;
        private System.Windows.Forms.TextBox patientIDTextBox;
        public System.Windows.Forms.DataGridView visitDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn NurseID;
        private System.Windows.Forms.DataGridViewTextBoxColumn AppointmentTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientBirthDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoctorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn NurseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewButtonColumn EditViewVisit;
    }
}
