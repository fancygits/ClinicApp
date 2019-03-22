namespace ClinicApp.UserControls
{
    partial class AddVisitUserControl
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
            System.Windows.Forms.Label appointmentIDLabel;
            System.Windows.Forms.Label patientNameLabel;
            System.Windows.Forms.Label birthDateLabel;
            System.Windows.Forms.Label appointmentTimeLabel;
            System.Windows.Forms.Label doctorNameLabel;
            System.Windows.Forms.Label weightLabel;
            System.Windows.Forms.Label systolicBPLabel;
            System.Windows.Forms.Label diastolicBPLabel;
            System.Windows.Forms.Label temperatureLabel;
            System.Windows.Forms.Label pulseLabel;
            System.Windows.Forms.Label symptomsLabel;
            System.Windows.Forms.Label nurseNameLabel;
            this.appointmentIDTextBox = new System.Windows.Forms.TextBox();
            this.visitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientNameTextBox = new System.Windows.Forms.TextBox();
            this.birthDateTextBox = new System.Windows.Forms.TextBox();
            this.appointmentTimeTextBox = new System.Windows.Forms.TextBox();
            this.doctorNameTextBox = new System.Windows.Forms.TextBox();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.systolicBPTextBox = new System.Windows.Forms.TextBox();
            this.diastolicBPTextBox = new System.Windows.Forms.TextBox();
            this.temperatureTextBox = new System.Windows.Forms.TextBox();
            this.pulseTextBox = new System.Windows.Forms.TextBox();
            this.symptomsTextBox = new System.Windows.Forms.TextBox();
            this.nurseNameComboBox = new System.Windows.Forms.ComboBox();
            this.nurseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            appointmentIDLabel = new System.Windows.Forms.Label();
            patientNameLabel = new System.Windows.Forms.Label();
            birthDateLabel = new System.Windows.Forms.Label();
            appointmentTimeLabel = new System.Windows.Forms.Label();
            doctorNameLabel = new System.Windows.Forms.Label();
            weightLabel = new System.Windows.Forms.Label();
            systolicBPLabel = new System.Windows.Forms.Label();
            diastolicBPLabel = new System.Windows.Forms.Label();
            temperatureLabel = new System.Windows.Forms.Label();
            pulseLabel = new System.Windows.Forms.Label();
            symptomsLabel = new System.Windows.Forms.Label();
            nurseNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.visitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nurseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // appointmentIDLabel
            // 
            appointmentIDLabel.AutoSize = true;
            appointmentIDLabel.Location = new System.Drawing.Point(118, 67);
            appointmentIDLabel.Name = "appointmentIDLabel";
            appointmentIDLabel.Size = new System.Drawing.Size(164, 25);
            appointmentIDLabel.TabIndex = 0;
            appointmentIDLabel.Text = "Appointment ID:";
            // 
            // patientNameLabel
            // 
            patientNameLabel.AutoSize = true;
            patientNameLabel.Location = new System.Drawing.Point(128, 237);
            patientNameLabel.Name = "patientNameLabel";
            patientNameLabel.Size = new System.Drawing.Size(147, 25);
            patientNameLabel.TabIndex = 4;
            patientNameLabel.Text = "Patient Name:";
            // 
            // birthDateLabel
            // 
            birthDateLabel.AutoSize = true;
            birthDateLabel.Location = new System.Drawing.Point(128, 289);
            birthDateLabel.Name = "birthDateLabel";
            birthDateLabel.Size = new System.Drawing.Size(113, 25);
            birthDateLabel.TabIndex = 6;
            birthDateLabel.Text = "Birth Date:";
            // 
            // appointmentTimeLabel
            // 
            appointmentTimeLabel.AutoSize = true;
            appointmentTimeLabel.Location = new System.Drawing.Point(128, 343);
            appointmentTimeLabel.Name = "appointmentTimeLabel";
            appointmentTimeLabel.Size = new System.Drawing.Size(191, 25);
            appointmentTimeLabel.TabIndex = 8;
            appointmentTimeLabel.Text = "Appointment Time:";
            // 
            // doctorNameLabel
            // 
            doctorNameLabel.AutoSize = true;
            doctorNameLabel.Location = new System.Drawing.Point(128, 403);
            doctorNameLabel.Name = "doctorNameLabel";
            doctorNameLabel.Size = new System.Drawing.Size(143, 25);
            doctorNameLabel.TabIndex = 10;
            doctorNameLabel.Text = "Doctor Name:";
            // 
            // weightLabel
            // 
            weightLabel.AutoSize = true;
            weightLabel.Location = new System.Drawing.Point(966, 241);
            weightLabel.Name = "weightLabel";
            weightLabel.Size = new System.Drawing.Size(85, 25);
            weightLabel.TabIndex = 12;
            weightLabel.Text = "Weight:";
            // 
            // systolicBPLabel
            // 
            systolicBPLabel.AutoSize = true;
            systolicBPLabel.Location = new System.Drawing.Point(966, 295);
            systolicBPLabel.Name = "systolicBPLabel";
            systolicBPLabel.Size = new System.Drawing.Size(127, 25);
            systolicBPLabel.TabIndex = 14;
            systolicBPLabel.Text = "Systolic BP:";
            // 
            // diastolicBPLabel
            // 
            diastolicBPLabel.AutoSize = true;
            diastolicBPLabel.Location = new System.Drawing.Point(966, 349);
            diastolicBPLabel.Name = "diastolicBPLabel";
            diastolicBPLabel.Size = new System.Drawing.Size(134, 25);
            diastolicBPLabel.TabIndex = 16;
            diastolicBPLabel.Text = "Diastolic BP:";
            // 
            // temperatureLabel
            // 
            temperatureLabel.AutoSize = true;
            temperatureLabel.Location = new System.Drawing.Point(966, 406);
            temperatureLabel.Name = "temperatureLabel";
            temperatureLabel.Size = new System.Drawing.Size(140, 25);
            temperatureLabel.TabIndex = 18;
            temperatureLabel.Text = "Temperature:";
            // 
            // pulseLabel
            // 
            pulseLabel.AutoSize = true;
            pulseLabel.Location = new System.Drawing.Point(966, 474);
            pulseLabel.Name = "pulseLabel";
            pulseLabel.Size = new System.Drawing.Size(72, 25);
            pulseLabel.TabIndex = 20;
            pulseLabel.Text = "Pulse:";
            // 
            // symptomsLabel
            // 
            symptomsLabel.AutoSize = true;
            symptomsLabel.Location = new System.Drawing.Point(966, 533);
            symptomsLabel.Name = "symptomsLabel";
            symptomsLabel.Size = new System.Drawing.Size(118, 25);
            symptomsLabel.TabIndex = 22;
            symptomsLabel.Text = "Symptoms:";
            // 
            // nurseNameLabel
            // 
            nurseNameLabel.AutoSize = true;
            nurseNameLabel.Location = new System.Drawing.Point(128, 474);
            nurseNameLabel.Name = "nurseNameLabel";
            nurseNameLabel.Size = new System.Drawing.Size(137, 25);
            nurseNameLabel.TabIndex = 23;
            nurseNameLabel.Text = "Nurse Name:";
            // 
            // appointmentIDTextBox
            // 
            this.appointmentIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitBindingSource, "AppointmentID", true));
            this.appointmentIDTextBox.Location = new System.Drawing.Point(288, 64);
            this.appointmentIDTextBox.Name = "appointmentIDTextBox";
            this.appointmentIDTextBox.Size = new System.Drawing.Size(100, 31);
            this.appointmentIDTextBox.TabIndex = 1;
            // 
            // visitBindingSource
            // 
            this.visitBindingSource.DataSource = typeof(ClinicApp.Model.Visit);
            // 
            // patientNameTextBox
            // 
            this.patientNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitBindingSource, "PatientName", true));
            this.patientNameTextBox.Location = new System.Drawing.Point(383, 234);
            this.patientNameTextBox.Name = "patientNameTextBox";
            this.patientNameTextBox.Size = new System.Drawing.Size(348, 31);
            this.patientNameTextBox.TabIndex = 5;
            // 
            // birthDateTextBox
            // 
            this.birthDateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitBindingSource, "VisitPatient.BirthDate", true));
            this.birthDateTextBox.Location = new System.Drawing.Point(383, 289);
            this.birthDateTextBox.Name = "birthDateTextBox";
            this.birthDateTextBox.Size = new System.Drawing.Size(348, 31);
            this.birthDateTextBox.TabIndex = 7;
            // 
            // appointmentTimeTextBox
            // 
            this.appointmentTimeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitBindingSource, "AppointmentTime", true));
            this.appointmentTimeTextBox.Location = new System.Drawing.Point(383, 343);
            this.appointmentTimeTextBox.Name = "appointmentTimeTextBox";
            this.appointmentTimeTextBox.Size = new System.Drawing.Size(348, 31);
            this.appointmentTimeTextBox.TabIndex = 9;
            // 
            // doctorNameTextBox
            // 
            this.doctorNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitBindingSource, "DoctorName", true));
            this.doctorNameTextBox.Location = new System.Drawing.Point(383, 400);
            this.doctorNameTextBox.Name = "doctorNameTextBox";
            this.doctorNameTextBox.Size = new System.Drawing.Size(348, 31);
            this.doctorNameTextBox.TabIndex = 11;
            // 
            // weightTextBox
            // 
            this.weightTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitBindingSource, "Weight", true));
            this.weightTextBox.Location = new System.Drawing.Point(1164, 238);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(260, 31);
            this.weightTextBox.TabIndex = 13;
            // 
            // systolicBPTextBox
            // 
            this.systolicBPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitBindingSource, "SystolicBP", true));
            this.systolicBPTextBox.Location = new System.Drawing.Point(1164, 292);
            this.systolicBPTextBox.Name = "systolicBPTextBox";
            this.systolicBPTextBox.Size = new System.Drawing.Size(260, 31);
            this.systolicBPTextBox.TabIndex = 15;
            // 
            // diastolicBPTextBox
            // 
            this.diastolicBPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitBindingSource, "DiastolicBP", true));
            this.diastolicBPTextBox.Location = new System.Drawing.Point(1164, 346);
            this.diastolicBPTextBox.Name = "diastolicBPTextBox";
            this.diastolicBPTextBox.Size = new System.Drawing.Size(260, 31);
            this.diastolicBPTextBox.TabIndex = 17;
            // 
            // temperatureTextBox
            // 
            this.temperatureTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitBindingSource, "Temperature", true));
            this.temperatureTextBox.Location = new System.Drawing.Point(1164, 403);
            this.temperatureTextBox.Name = "temperatureTextBox";
            this.temperatureTextBox.Size = new System.Drawing.Size(260, 31);
            this.temperatureTextBox.TabIndex = 19;
            // 
            // pulseTextBox
            // 
            this.pulseTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitBindingSource, "Pulse", true));
            this.pulseTextBox.Location = new System.Drawing.Point(1164, 474);
            this.pulseTextBox.Name = "pulseTextBox";
            this.pulseTextBox.Size = new System.Drawing.Size(260, 31);
            this.pulseTextBox.TabIndex = 21;
            // 
            // symptomsTextBox
            // 
            this.symptomsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitBindingSource, "Symptoms", true));
            this.symptomsTextBox.Location = new System.Drawing.Point(1164, 530);
            this.symptomsTextBox.Multiline = true;
            this.symptomsTextBox.Name = "symptomsTextBox";
            this.symptomsTextBox.Size = new System.Drawing.Size(260, 83);
            this.symptomsTextBox.TabIndex = 23;
            // 
            // nurseNameComboBox
            // 
            this.nurseNameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitBindingSource, "NurseName", true));
            this.nurseNameComboBox.DataSource = this.visitBindingSource;
            this.nurseNameComboBox.DisplayMember = "NurseName";
            this.nurseNameComboBox.FormattingEnabled = true;
            this.nurseNameComboBox.Location = new System.Drawing.Point(383, 466);
            this.nurseNameComboBox.Name = "nurseNameComboBox";
            this.nurseNameComboBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.nurseNameComboBox.Size = new System.Drawing.Size(348, 33);
            this.nurseNameComboBox.TabIndex = 24;
            this.nurseNameComboBox.ValueMember = "NurseID";
            // 
            // nurseBindingSource
            // 
            this.nurseBindingSource.DataSource = typeof(ClinicApp.Model.Nurse);
            // 
            // patientBindingSource
            // 
            this.patientBindingSource.DataSource = typeof(ClinicApp.Model.Patient);
            // 
            // AddVisitUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(nurseNameLabel);
            this.Controls.Add(this.nurseNameComboBox);
            this.Controls.Add(symptomsLabel);
            this.Controls.Add(this.symptomsTextBox);
            this.Controls.Add(pulseLabel);
            this.Controls.Add(this.pulseTextBox);
            this.Controls.Add(temperatureLabel);
            this.Controls.Add(this.temperatureTextBox);
            this.Controls.Add(diastolicBPLabel);
            this.Controls.Add(this.diastolicBPTextBox);
            this.Controls.Add(systolicBPLabel);
            this.Controls.Add(this.systolicBPTextBox);
            this.Controls.Add(weightLabel);
            this.Controls.Add(this.weightTextBox);
            this.Controls.Add(doctorNameLabel);
            this.Controls.Add(this.doctorNameTextBox);
            this.Controls.Add(appointmentTimeLabel);
            this.Controls.Add(this.appointmentTimeTextBox);
            this.Controls.Add(birthDateLabel);
            this.Controls.Add(this.birthDateTextBox);
            this.Controls.Add(patientNameLabel);
            this.Controls.Add(this.patientNameTextBox);
            this.Controls.Add(appointmentIDLabel);
            this.Controls.Add(this.appointmentIDTextBox);
            this.Name = "AddVisitUserControl";
            this.Size = new System.Drawing.Size(1626, 814);
            this.Load += new System.EventHandler(this.AddVisitUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.visitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nurseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource visitBindingSource;
        private System.Windows.Forms.BindingSource patientBindingSource;
        private System.Windows.Forms.BindingSource nurseBindingSource;
        public System.Windows.Forms.TextBox appointmentIDTextBox;
        public System.Windows.Forms.TextBox patientNameTextBox;
        public System.Windows.Forms.TextBox birthDateTextBox;
        public System.Windows.Forms.TextBox appointmentTimeTextBox;
        public System.Windows.Forms.TextBox doctorNameTextBox;
        public System.Windows.Forms.TextBox weightTextBox;
        public System.Windows.Forms.TextBox systolicBPTextBox;
        public System.Windows.Forms.TextBox diastolicBPTextBox;
        public System.Windows.Forms.TextBox temperatureTextBox;
        public System.Windows.Forms.TextBox pulseTextBox;
        public System.Windows.Forms.TextBox symptomsTextBox;
        public System.Windows.Forms.ComboBox nurseNameComboBox;
    }
}
