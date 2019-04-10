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
            System.Windows.Forms.Label finalDiagnosisLabel;
            System.Windows.Forms.Label initialDiagnosisLabel;
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
            this.addVisitButton = new System.Windows.Forms.Button();
            this.updateVisitButton = new System.Windows.Forms.Button();
            this.nurseNameTextBox = new System.Windows.Forms.TextBox();
            this.btnLabTest = new System.Windows.Forms.Button();
            this.finalDiagnosisTextBox = new System.Windows.Forms.TextBox();
            this.initialDiagnosisTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
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
            finalDiagnosisLabel = new System.Windows.Forms.Label();
            initialDiagnosisLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.visitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nurseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // appointmentIDLabel
            // 
            appointmentIDLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            appointmentIDLabel.AutoSize = true;
            appointmentIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            appointmentIDLabel.Location = new System.Drawing.Point(4, 47);
            appointmentIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            appointmentIDLabel.Name = "appointmentIDLabel";
            appointmentIDLabel.Size = new System.Drawing.Size(209, 31);
            appointmentIDLabel.TabIndex = 0;
            appointmentIDLabel.Text = "Appointment ID:";
            // 
            // patientNameLabel
            // 
            patientNameLabel.AutoSize = true;
            patientNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            patientNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            patientNameLabel.Location = new System.Drawing.Point(4, 125);
            patientNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            patientNameLabel.Name = "patientNameLabel";
            patientNameLabel.Size = new System.Drawing.Size(310, 125);
            patientNameLabel.TabIndex = 4;
            patientNameLabel.Text = "Patient Name:";
            // 
            // birthDateLabel
            // 
            birthDateLabel.AutoSize = true;
            birthDateLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            birthDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            birthDateLabel.Location = new System.Drawing.Point(4, 250);
            birthDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            birthDateLabel.Name = "birthDateLabel";
            birthDateLabel.Size = new System.Drawing.Size(310, 125);
            birthDateLabel.TabIndex = 6;
            birthDateLabel.Text = "Birth Date:";
            // 
            // appointmentTimeLabel
            // 
            appointmentTimeLabel.AutoSize = true;
            appointmentTimeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            appointmentTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            appointmentTimeLabel.Location = new System.Drawing.Point(4, 375);
            appointmentTimeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            appointmentTimeLabel.Name = "appointmentTimeLabel";
            appointmentTimeLabel.Size = new System.Drawing.Size(310, 125);
            appointmentTimeLabel.TabIndex = 8;
            appointmentTimeLabel.Text = "Appointment Time:";
            // 
            // doctorNameLabel
            // 
            doctorNameLabel.AutoSize = true;
            doctorNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            doctorNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            doctorNameLabel.Location = new System.Drawing.Point(4, 500);
            doctorNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            doctorNameLabel.Name = "doctorNameLabel";
            doctorNameLabel.Size = new System.Drawing.Size(310, 125);
            doctorNameLabel.TabIndex = 10;
            doctorNameLabel.Text = "Doctor Name:";
            // 
            // weightLabel
            // 
            weightLabel.AutoSize = true;
            weightLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            weightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            weightLabel.Location = new System.Drawing.Point(639, 125);
            weightLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            weightLabel.Name = "weightLabel";
            weightLabel.Size = new System.Drawing.Size(309, 125);
            weightLabel.TabIndex = 12;
            weightLabel.Text = "Weight:";
            // 
            // systolicBPLabel
            // 
            systolicBPLabel.AutoSize = true;
            systolicBPLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            systolicBPLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            systolicBPLabel.Location = new System.Drawing.Point(639, 250);
            systolicBPLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            systolicBPLabel.Name = "systolicBPLabel";
            systolicBPLabel.Size = new System.Drawing.Size(309, 125);
            systolicBPLabel.TabIndex = 14;
            systolicBPLabel.Text = "Systolic BP:";
            // 
            // diastolicBPLabel
            // 
            diastolicBPLabel.AutoSize = true;
            diastolicBPLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            diastolicBPLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            diastolicBPLabel.Location = new System.Drawing.Point(639, 375);
            diastolicBPLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            diastolicBPLabel.Name = "diastolicBPLabel";
            diastolicBPLabel.Size = new System.Drawing.Size(309, 125);
            diastolicBPLabel.TabIndex = 16;
            diastolicBPLabel.Text = "Diastolic BP:";
            // 
            // temperatureLabel
            // 
            temperatureLabel.AutoSize = true;
            temperatureLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            temperatureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            temperatureLabel.Location = new System.Drawing.Point(639, 500);
            temperatureLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            temperatureLabel.Name = "temperatureLabel";
            temperatureLabel.Size = new System.Drawing.Size(309, 125);
            temperatureLabel.TabIndex = 18;
            temperatureLabel.Text = "Temperature:";
            // 
            // pulseLabel
            // 
            pulseLabel.AutoSize = true;
            pulseLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            pulseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pulseLabel.Location = new System.Drawing.Point(639, 625);
            pulseLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            pulseLabel.Name = "pulseLabel";
            pulseLabel.Size = new System.Drawing.Size(309, 125);
            pulseLabel.TabIndex = 20;
            pulseLabel.Text = "Pulse:";
            // 
            // symptomsLabel
            // 
            symptomsLabel.AutoSize = true;
            symptomsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            symptomsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            symptomsLabel.Location = new System.Drawing.Point(639, 750);
            symptomsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            symptomsLabel.Name = "symptomsLabel";
            symptomsLabel.Size = new System.Drawing.Size(309, 131);
            symptomsLabel.TabIndex = 22;
            symptomsLabel.Text = "Symptoms:";
            // 
            // nurseNameLabel
            // 
            nurseNameLabel.AutoSize = true;
            nurseNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            nurseNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nurseNameLabel.Location = new System.Drawing.Point(4, 625);
            nurseNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nurseNameLabel.Name = "nurseNameLabel";
            nurseNameLabel.Size = new System.Drawing.Size(310, 125);
            nurseNameLabel.TabIndex = 23;
            nurseNameLabel.Text = "Nurse Name:";
            // 
            // appointmentIDTextBox
            // 
            this.appointmentIDTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.appointmentIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitBindingSource, "AppointmentID", true));
            this.appointmentIDTextBox.Enabled = false;
            this.appointmentIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentIDTextBox.Location = new System.Drawing.Point(426, 43);
            this.appointmentIDTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.appointmentIDTextBox.Name = "appointmentIDTextBox";
            this.appointmentIDTextBox.Size = new System.Drawing.Size(100, 38);
            this.appointmentIDTextBox.TabIndex = 1;
            // 
            // visitBindingSource
            // 
            this.visitBindingSource.DataSource = typeof(ClinicApp.Model.Visit);
            // 
            // patientNameTextBox
            // 
            this.patientNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitBindingSource, "PatientName", true));
            this.patientNameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.patientNameTextBox.Enabled = false;
            this.patientNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientNameTextBox.Location = new System.Drawing.Point(322, 129);
            this.patientNameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.patientNameTextBox.Name = "patientNameTextBox";
            this.patientNameTextBox.Size = new System.Drawing.Size(309, 38);
            this.patientNameTextBox.TabIndex = 5;
            // 
            // birthDateTextBox
            // 
            this.birthDateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitBindingSource, "VisitPatient.BirthDate", true));
            this.birthDateTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.birthDateTextBox.Enabled = false;
            this.birthDateTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthDateTextBox.Location = new System.Drawing.Point(322, 254);
            this.birthDateTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.birthDateTextBox.Name = "birthDateTextBox";
            this.birthDateTextBox.Size = new System.Drawing.Size(309, 38);
            this.birthDateTextBox.TabIndex = 7;
            // 
            // appointmentTimeTextBox
            // 
            this.appointmentTimeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitBindingSource, "AppointmentTime", true));
            this.appointmentTimeTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.appointmentTimeTextBox.Enabled = false;
            this.appointmentTimeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentTimeTextBox.Location = new System.Drawing.Point(322, 379);
            this.appointmentTimeTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.appointmentTimeTextBox.Name = "appointmentTimeTextBox";
            this.appointmentTimeTextBox.Size = new System.Drawing.Size(309, 38);
            this.appointmentTimeTextBox.TabIndex = 9;
            // 
            // doctorNameTextBox
            // 
            this.doctorNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitBindingSource, "DoctorName", true));
            this.doctorNameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.doctorNameTextBox.Enabled = false;
            this.doctorNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctorNameTextBox.Location = new System.Drawing.Point(322, 504);
            this.doctorNameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.doctorNameTextBox.Name = "doctorNameTextBox";
            this.doctorNameTextBox.Size = new System.Drawing.Size(309, 38);
            this.doctorNameTextBox.TabIndex = 11;
            // 
            // weightTextBox
            // 
            this.weightTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitBindingSource, "Weight", true));
            this.weightTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.weightTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weightTextBox.Location = new System.Drawing.Point(956, 129);
            this.weightTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(309, 38);
            this.weightTextBox.TabIndex = 13;
            // 
            // systolicBPTextBox
            // 
            this.systolicBPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitBindingSource, "SystolicBP", true));
            this.systolicBPTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.systolicBPTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.systolicBPTextBox.Location = new System.Drawing.Point(956, 254);
            this.systolicBPTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.systolicBPTextBox.Name = "systolicBPTextBox";
            this.systolicBPTextBox.Size = new System.Drawing.Size(309, 38);
            this.systolicBPTextBox.TabIndex = 15;
            // 
            // diastolicBPTextBox
            // 
            this.diastolicBPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitBindingSource, "DiastolicBP", true));
            this.diastolicBPTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.diastolicBPTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diastolicBPTextBox.Location = new System.Drawing.Point(956, 379);
            this.diastolicBPTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.diastolicBPTextBox.Name = "diastolicBPTextBox";
            this.diastolicBPTextBox.Size = new System.Drawing.Size(309, 38);
            this.diastolicBPTextBox.TabIndex = 17;
            // 
            // temperatureTextBox
            // 
            this.temperatureTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitBindingSource, "Temperature", true));
            this.temperatureTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.temperatureTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temperatureTextBox.Location = new System.Drawing.Point(956, 504);
            this.temperatureTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.temperatureTextBox.Name = "temperatureTextBox";
            this.temperatureTextBox.Size = new System.Drawing.Size(309, 38);
            this.temperatureTextBox.TabIndex = 19;
            // 
            // pulseTextBox
            // 
            this.pulseTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitBindingSource, "Pulse", true));
            this.pulseTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pulseTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pulseTextBox.Location = new System.Drawing.Point(956, 629);
            this.pulseTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pulseTextBox.Name = "pulseTextBox";
            this.pulseTextBox.Size = new System.Drawing.Size(309, 38);
            this.pulseTextBox.TabIndex = 21;
            // 
            // symptomsTextBox
            // 
            this.symptomsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitBindingSource, "Symptoms", true));
            this.symptomsTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.symptomsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.symptomsTextBox.Location = new System.Drawing.Point(956, 754);
            this.symptomsTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.symptomsTextBox.Multiline = true;
            this.symptomsTextBox.Name = "symptomsTextBox";
            this.symptomsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.symptomsTextBox.Size = new System.Drawing.Size(309, 123);
            this.symptomsTextBox.TabIndex = 23;
            this.symptomsTextBox.Tag = "Visit";
            // 
            // nurseNameComboBox
            // 
            this.nurseNameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitBindingSource, "NurseName", true));
            this.nurseNameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.visitBindingSource, "NurseName", true));
            this.nurseNameComboBox.DataSource = this.nurseBindingSource;
            this.nurseNameComboBox.DisplayMember = "FullName";
            this.nurseNameComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nurseNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nurseNameComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nurseNameComboBox.FormattingEnabled = true;
            this.nurseNameComboBox.Location = new System.Drawing.Point(0, 0);
            this.nurseNameComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nurseNameComboBox.Name = "nurseNameComboBox";
            this.nurseNameComboBox.Size = new System.Drawing.Size(311, 37);
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
            // addVisitButton
            // 
            this.addVisitButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addVisitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addVisitButton.Location = new System.Drawing.Point(31, 784);
            this.addVisitButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addVisitButton.Name = "addVisitButton";
            this.addVisitButton.Size = new System.Drawing.Size(256, 63);
            this.addVisitButton.TabIndex = 25;
            this.addVisitButton.Text = "Add Visit";
            this.addVisitButton.UseVisualStyleBackColor = true;
            this.addVisitButton.Click += new System.EventHandler(this.addVisitButton_Click);
            // 
            // updateVisitButton
            // 
            this.updateVisitButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.updateVisitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateVisitButton.Location = new System.Drawing.Point(348, 784);
            this.updateVisitButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.updateVisitButton.Name = "updateVisitButton";
            this.updateVisitButton.Size = new System.Drawing.Size(256, 63);
            this.updateVisitButton.TabIndex = 26;
            this.updateVisitButton.Text = "Update Visit";
            this.updateVisitButton.UseVisualStyleBackColor = true;
            this.updateVisitButton.Click += new System.EventHandler(this.updateVisitButton_Click);
            // 
            // nurseNameTextBox
            // 
            this.nurseNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitBindingSource, "NurseName", true));
            this.nurseNameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nurseNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nurseNameTextBox.Location = new System.Drawing.Point(0, 0);
            this.nurseNameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nurseNameTextBox.Name = "nurseNameTextBox";
            this.nurseNameTextBox.Size = new System.Drawing.Size(311, 35);
            this.nurseNameTextBox.TabIndex = 27;
            // 
            // btnLabTest
            // 
            this.btnLabTest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLabTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLabTest.Location = new System.Drawing.Point(1275, 6);
            this.btnLabTest.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnLabTest.Name = "btnLabTest";
            this.btnLabTest.Size = new System.Drawing.Size(305, 113);
            this.btnLabTest.TabIndex = 28;
            this.btnLabTest.Text = "Lab Tests";
            this.btnLabTest.UseVisualStyleBackColor = true;
            this.btnLabTest.Click += new System.EventHandler(this.btnLabTest_Click);
            // 
            // finalDiagnosisLabel
            // 
            finalDiagnosisLabel.AutoSize = true;
            finalDiagnosisLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            finalDiagnosisLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            finalDiagnosisLabel.Location = new System.Drawing.Point(1272, 375);
            finalDiagnosisLabel.Name = "finalDiagnosisLabel";
            finalDiagnosisLabel.Size = new System.Drawing.Size(311, 125);
            finalDiagnosisLabel.TabIndex = 28;
            finalDiagnosisLabel.Text = "Final Diagnosis:";
            // 
            // finalDiagnosisTextBox
            // 
            this.finalDiagnosisTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitBindingSource, "FinalDiagnosis", true));
            this.finalDiagnosisTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.finalDiagnosisTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finalDiagnosisTextBox.Location = new System.Drawing.Point(1589, 378);
            this.finalDiagnosisTextBox.Multiline = true;
            this.finalDiagnosisTextBox.Name = "finalDiagnosisTextBox";
            this.finalDiagnosisTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.finalDiagnosisTextBox.Size = new System.Drawing.Size(316, 119);
            this.finalDiagnosisTextBox.TabIndex = 29;
            // 
            // initialDiagnosisLabel
            // 
            initialDiagnosisLabel.AutoSize = true;
            initialDiagnosisLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            initialDiagnosisLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            initialDiagnosisLabel.Location = new System.Drawing.Point(1272, 250);
            initialDiagnosisLabel.Name = "initialDiagnosisLabel";
            initialDiagnosisLabel.Size = new System.Drawing.Size(311, 125);
            initialDiagnosisLabel.TabIndex = 30;
            initialDiagnosisLabel.Text = "Initial Diagnosis:";
            // 
            // initialDiagnosisTextBox
            // 
            this.initialDiagnosisTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitBindingSource, "InitialDiagnosis", true));
            this.initialDiagnosisTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.initialDiagnosisTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.initialDiagnosisTextBox.Location = new System.Drawing.Point(1589, 253);
            this.initialDiagnosisTextBox.Multiline = true;
            this.initialDiagnosisTextBox.Name = "initialDiagnosisTextBox";
            this.initialDiagnosisTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.initialDiagnosisTextBox.Size = new System.Drawing.Size(316, 119);
            this.initialDiagnosisTextBox.TabIndex = 31;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Controls.Add(this.finalDiagnosisTextBox, 5, 3);
            this.tableLayoutPanel1.Controls.Add(this.initialDiagnosisTextBox, 5, 2);
            this.tableLayoutPanel1.Controls.Add(initialDiagnosisLabel, 4, 2);
            this.tableLayoutPanel1.Controls.Add(finalDiagnosisLabel, 4, 3);
            this.tableLayoutPanel1.Controls.Add(appointmentIDLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.appointmentIDTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(patientNameLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.patientNameTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(birthDateLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.diastolicBPTextBox, 3, 3);
            this.tableLayoutPanel1.Controls.Add(diastolicBPLabel, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.temperatureTextBox, 3, 4);
            this.tableLayoutPanel1.Controls.Add(temperatureLabel, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.updateVisitButton, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.birthDateTextBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.addVisitButton, 0, 6);
            this.tableLayoutPanel1.Controls.Add(appointmentTimeLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.appointmentTimeTextBox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(doctorNameLabel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.doctorNameTextBox, 1, 4);
            this.tableLayoutPanel1.Controls.Add(nurseNameLabel, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.systolicBPTextBox, 3, 2);
            this.tableLayoutPanel1.Controls.Add(systolicBPLabel, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.weightTextBox, 3, 1);
            this.tableLayoutPanel1.Controls.Add(weightLabel, 2, 1);
            this.tableLayoutPanel1.Controls.Add(symptomsLabel, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.symptomsTextBox, 3, 6);
            this.tableLayoutPanel1.Controls.Add(pulseLabel, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.pulseTextBox, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnLabTest, 4, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1908, 881);
            this.tableLayoutPanel1.TabIndex = 32;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.nurseNameTextBox);
            this.panel1.Controls.Add(this.nurseNameComboBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(321, 628);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(311, 119);
            this.panel1.TabIndex = 32;
            // 
            // AddVisitUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddVisitUserControl";
            this.Size = new System.Drawing.Size(1908, 881);
            this.Load += new System.EventHandler(this.AddVisitUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.visitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nurseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

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
        public System.Windows.Forms.Button addVisitButton;
        public System.Windows.Forms.Button updateVisitButton;
        public System.Windows.Forms.TextBox nurseNameTextBox;
        public System.Windows.Forms.TextBox finalDiagnosisTextBox;
        public System.Windows.Forms.TextBox initialDiagnosisTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button btnLabTest;
    }
}
