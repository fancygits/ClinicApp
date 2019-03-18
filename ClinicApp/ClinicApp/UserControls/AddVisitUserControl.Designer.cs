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
            System.Windows.Forms.Label diastolicBPLabel;
            System.Windows.Forms.Label finalDiagnosisLabel;
            System.Windows.Forms.Label initialDiagnosisLabel;
            System.Windows.Forms.Label nurseIDLabel;
            System.Windows.Forms.Label patientIDLabel;
            System.Windows.Forms.Label pulseLabel;
            System.Windows.Forms.Label symptomsLabel;
            System.Windows.Forms.Label systolicBPLabel;
            System.Windows.Forms.Label temperatureLabel;
            System.Windows.Forms.Label weightLabel;
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label birthDateLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddVisitUserControl));
            this.visitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.visitBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.visitBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.appointmentIDTextBox = new System.Windows.Forms.TextBox();
            this.diastolicBPTextBox = new System.Windows.Forms.TextBox();
            this.finalDiagnosisTextBox = new System.Windows.Forms.TextBox();
            this.initialDiagnosisTextBox = new System.Windows.Forms.TextBox();
            this.nurseIDTextBox = new System.Windows.Forms.TextBox();
            this.patientIDTextBox = new System.Windows.Forms.TextBox();
            this.pulseTextBox = new System.Windows.Forms.TextBox();
            this.symptomsTextBox = new System.Windows.Forms.TextBox();
            this.systolicBPTextBox = new System.Windows.Forms.TextBox();
            this.temperatureTextBox = new System.Windows.Forms.TextBox();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.vistiGroupBox = new System.Windows.Forms.GroupBox();
            this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.birthDateTextBox = new System.Windows.Forms.TextBox();
            this.nurseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            appointmentIDLabel = new System.Windows.Forms.Label();
            diastolicBPLabel = new System.Windows.Forms.Label();
            finalDiagnosisLabel = new System.Windows.Forms.Label();
            initialDiagnosisLabel = new System.Windows.Forms.Label();
            nurseIDLabel = new System.Windows.Forms.Label();
            patientIDLabel = new System.Windows.Forms.Label();
            pulseLabel = new System.Windows.Forms.Label();
            symptomsLabel = new System.Windows.Forms.Label();
            systolicBPLabel = new System.Windows.Forms.Label();
            temperatureLabel = new System.Windows.Forms.Label();
            weightLabel = new System.Windows.Forms.Label();
            firstNameLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            birthDateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.visitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitBindingNavigator)).BeginInit();
            this.visitBindingNavigator.SuspendLayout();
            this.vistiGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nurseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // appointmentIDLabel
            // 
            appointmentIDLabel.AutoSize = true;
            appointmentIDLabel.Location = new System.Drawing.Point(66, 73);
            appointmentIDLabel.Name = "appointmentIDLabel";
            appointmentIDLabel.Size = new System.Drawing.Size(164, 25);
            appointmentIDLabel.TabIndex = 1;
            appointmentIDLabel.Text = "Appointment ID:";
            // 
            // diastolicBPLabel
            // 
            diastolicBPLabel.AutoSize = true;
            diastolicBPLabel.Location = new System.Drawing.Point(26, 140);
            diastolicBPLabel.Name = "diastolicBPLabel";
            diastolicBPLabel.Size = new System.Drawing.Size(134, 25);
            diastolicBPLabel.TabIndex = 3;
            diastolicBPLabel.Text = "Diastolic BP:";
            // 
            // finalDiagnosisLabel
            // 
            finalDiagnosisLabel.AutoSize = true;
            finalDiagnosisLabel.Location = new System.Drawing.Point(1278, 565);
            finalDiagnosisLabel.Name = "finalDiagnosisLabel";
            finalDiagnosisLabel.Size = new System.Drawing.Size(166, 25);
            finalDiagnosisLabel.TabIndex = 5;
            finalDiagnosisLabel.Text = "Final Diagnosis:";
            // 
            // initialDiagnosisLabel
            // 
            initialDiagnosisLabel.AutoSize = true;
            initialDiagnosisLabel.Location = new System.Drawing.Point(1278, 602);
            initialDiagnosisLabel.Name = "initialDiagnosisLabel";
            initialDiagnosisLabel.Size = new System.Drawing.Size(169, 25);
            initialDiagnosisLabel.TabIndex = 7;
            initialDiagnosisLabel.Text = "Initial Diagnosis:";
            // 
            // nurseIDLabel
            // 
            nurseIDLabel.AutoSize = true;
            nurseIDLabel.Location = new System.Drawing.Point(878, 67);
            nurseIDLabel.Name = "nurseIDLabel";
            nurseIDLabel.Size = new System.Drawing.Size(101, 25);
            nurseIDLabel.TabIndex = 9;
            nurseIDLabel.Text = "Nurse ID:";
            // 
            // patientIDLabel
            // 
            patientIDLabel.AutoSize = true;
            patientIDLabel.Location = new System.Drawing.Point(502, 70);
            patientIDLabel.Name = "patientIDLabel";
            patientIDLabel.Size = new System.Drawing.Size(111, 25);
            patientIDLabel.TabIndex = 11;
            patientIDLabel.Text = "Patient ID:";
            // 
            // pulseLabel
            // 
            pulseLabel.AutoSize = true;
            pulseLabel.Location = new System.Drawing.Point(26, 223);
            pulseLabel.Name = "pulseLabel";
            pulseLabel.Size = new System.Drawing.Size(72, 25);
            pulseLabel.TabIndex = 13;
            pulseLabel.Text = "Pulse:";
            // 
            // symptomsLabel
            // 
            symptomsLabel.AutoSize = true;
            symptomsLabel.Location = new System.Drawing.Point(26, 260);
            symptomsLabel.Name = "symptomsLabel";
            symptomsLabel.Size = new System.Drawing.Size(118, 25);
            symptomsLabel.TabIndex = 15;
            symptomsLabel.Text = "Symptoms:";
            // 
            // systolicBPLabel
            // 
            systolicBPLabel.AutoSize = true;
            systolicBPLabel.Location = new System.Drawing.Point(26, 181);
            systolicBPLabel.Name = "systolicBPLabel";
            systolicBPLabel.Size = new System.Drawing.Size(127, 25);
            systolicBPLabel.TabIndex = 17;
            systolicBPLabel.Text = "Systolic BP:";
            // 
            // temperatureLabel
            // 
            temperatureLabel.AutoSize = true;
            temperatureLabel.Location = new System.Drawing.Point(26, 62);
            temperatureLabel.Name = "temperatureLabel";
            temperatureLabel.Size = new System.Drawing.Size(140, 25);
            temperatureLabel.TabIndex = 19;
            temperatureLabel.Text = "Temperature:";
            // 
            // weightLabel
            // 
            weightLabel.AutoSize = true;
            weightLabel.Location = new System.Drawing.Point(26, 99);
            weightLabel.Name = "weightLabel";
            weightLabel.Size = new System.Drawing.Size(85, 25);
            weightLabel.TabIndex = 21;
            weightLabel.Text = "Weight:";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new System.Drawing.Point(116, 237);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(122, 25);
            firstNameLabel.TabIndex = 23;
            firstNameLabel.Text = "First Name:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new System.Drawing.Point(117, 281);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(121, 25);
            lastNameLabel.TabIndex = 24;
            lastNameLabel.Text = "Last Name:";
            // 
            // birthDateLabel
            // 
            birthDateLabel.AutoSize = true;
            birthDateLabel.Location = new System.Drawing.Point(125, 325);
            birthDateLabel.Name = "birthDateLabel";
            birthDateLabel.Size = new System.Drawing.Size(113, 25);
            birthDateLabel.TabIndex = 25;
            birthDateLabel.Text = "Birth Date:";
            // 
            // visitBindingSource
            // 
            this.visitBindingSource.DataSource = typeof(ClinicApp.Model.Visit);
            // 
            // visitBindingNavigator
            // 
            this.visitBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.visitBindingNavigator.BindingSource = this.visitBindingSource;
            this.visitBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.visitBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.visitBindingNavigator.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.visitBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.visitBindingNavigatorSaveItem});
            this.visitBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.visitBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.visitBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.visitBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.visitBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.visitBindingNavigator.Name = "visitBindingNavigator";
            this.visitBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.visitBindingNavigator.Size = new System.Drawing.Size(1626, 39);
            this.visitBindingNavigator.TabIndex = 0;
            this.visitBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(36, 36);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(71, 36);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(36, 36);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(36, 36);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(36, 36);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 39);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 39);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(36, 36);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(36, 36);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // visitBindingNavigatorSaveItem
            // 
            this.visitBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.visitBindingNavigatorSaveItem.Enabled = false;
            this.visitBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("visitBindingNavigatorSaveItem.Image")));
            this.visitBindingNavigatorSaveItem.Name = "visitBindingNavigatorSaveItem";
            this.visitBindingNavigatorSaveItem.Size = new System.Drawing.Size(36, 36);
            this.visitBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // appointmentIDTextBox
            // 
            this.appointmentIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitBindingSource, "AppointmentID", true));
            this.appointmentIDTextBox.Location = new System.Drawing.Point(241, 70);
            this.appointmentIDTextBox.Name = "appointmentIDTextBox";
            this.appointmentIDTextBox.Size = new System.Drawing.Size(100, 31);
            this.appointmentIDTextBox.TabIndex = 2;
            // 
            // diastolicBPTextBox
            // 
            this.diastolicBPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitBindingSource, "DiastolicBP", true));
            this.diastolicBPTextBox.Location = new System.Drawing.Point(201, 137);
            this.diastolicBPTextBox.Name = "diastolicBPTextBox";
            this.diastolicBPTextBox.Size = new System.Drawing.Size(278, 31);
            this.diastolicBPTextBox.TabIndex = 4;
            // 
            // finalDiagnosisTextBox
            // 
            this.finalDiagnosisTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitBindingSource, "FinalDiagnosis", true));
            this.finalDiagnosisTextBox.Location = new System.Drawing.Point(1453, 562);
            this.finalDiagnosisTextBox.Name = "finalDiagnosisTextBox";
            this.finalDiagnosisTextBox.Size = new System.Drawing.Size(100, 31);
            this.finalDiagnosisTextBox.TabIndex = 6;
            // 
            // initialDiagnosisTextBox
            // 
            this.initialDiagnosisTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitBindingSource, "InitialDiagnosis", true));
            this.initialDiagnosisTextBox.Location = new System.Drawing.Point(1453, 599);
            this.initialDiagnosisTextBox.Name = "initialDiagnosisTextBox";
            this.initialDiagnosisTextBox.Size = new System.Drawing.Size(100, 31);
            this.initialDiagnosisTextBox.TabIndex = 8;
            // 
            // nurseIDTextBox
            // 
            this.nurseIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitBindingSource, "NurseID", true));
            this.nurseIDTextBox.Location = new System.Drawing.Point(1053, 64);
            this.nurseIDTextBox.Name = "nurseIDTextBox";
            this.nurseIDTextBox.Size = new System.Drawing.Size(100, 31);
            this.nurseIDTextBox.TabIndex = 10;
            // 
            // patientIDTextBox
            // 
            this.patientIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitBindingSource, "PatientID", true));
            this.patientIDTextBox.Location = new System.Drawing.Point(677, 67);
            this.patientIDTextBox.Name = "patientIDTextBox";
            this.patientIDTextBox.Size = new System.Drawing.Size(100, 31);
            this.patientIDTextBox.TabIndex = 12;
            // 
            // pulseTextBox
            // 
            this.pulseTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitBindingSource, "Pulse", true));
            this.pulseTextBox.Location = new System.Drawing.Point(201, 220);
            this.pulseTextBox.Name = "pulseTextBox";
            this.pulseTextBox.Size = new System.Drawing.Size(278, 31);
            this.pulseTextBox.TabIndex = 14;
            // 
            // symptomsTextBox
            // 
            this.symptomsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitBindingSource, "Symptoms", true));
            this.symptomsTextBox.Location = new System.Drawing.Point(201, 257);
            this.symptomsTextBox.Name = "symptomsTextBox";
            this.symptomsTextBox.Size = new System.Drawing.Size(278, 31);
            this.symptomsTextBox.TabIndex = 16;
            // 
            // systolicBPTextBox
            // 
            this.systolicBPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitBindingSource, "SystolicBP", true));
            this.systolicBPTextBox.Location = new System.Drawing.Point(201, 178);
            this.systolicBPTextBox.Name = "systolicBPTextBox";
            this.systolicBPTextBox.Size = new System.Drawing.Size(278, 31);
            this.systolicBPTextBox.TabIndex = 18;
            // 
            // temperatureTextBox
            // 
            this.temperatureTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitBindingSource, "Temperature", true));
            this.temperatureTextBox.Location = new System.Drawing.Point(201, 59);
            this.temperatureTextBox.Name = "temperatureTextBox";
            this.temperatureTextBox.Size = new System.Drawing.Size(278, 31);
            this.temperatureTextBox.TabIndex = 20;
            // 
            // weightTextBox
            // 
            this.weightTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitBindingSource, "Weight", true));
            this.weightTextBox.Location = new System.Drawing.Point(201, 96);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(278, 31);
            this.weightTextBox.TabIndex = 22;
            // 
            // vistiGroupBox
            // 
            this.vistiGroupBox.Controls.Add(weightLabel);
            this.vistiGroupBox.Controls.Add(this.weightTextBox);
            this.vistiGroupBox.Controls.Add(this.temperatureTextBox);
            this.vistiGroupBox.Controls.Add(diastolicBPLabel);
            this.vistiGroupBox.Controls.Add(temperatureLabel);
            this.vistiGroupBox.Controls.Add(this.diastolicBPTextBox);
            this.vistiGroupBox.Controls.Add(this.systolicBPTextBox);
            this.vistiGroupBox.Controls.Add(systolicBPLabel);
            this.vistiGroupBox.Controls.Add(this.symptomsTextBox);
            this.vistiGroupBox.Controls.Add(symptomsLabel);
            this.vistiGroupBox.Controls.Add(this.pulseTextBox);
            this.vistiGroupBox.Controls.Add(pulseLabel);
            this.vistiGroupBox.Location = new System.Drawing.Point(736, 182);
            this.vistiGroupBox.Name = "vistiGroupBox";
            this.vistiGroupBox.Size = new System.Drawing.Size(502, 456);
            this.vistiGroupBox.TabIndex = 23;
            this.vistiGroupBox.TabStop = false;
            this.vistiGroupBox.Text = "Visit Information";
            // 
            // patientBindingSource
            // 
            this.patientBindingSource.DataSource = typeof(ClinicApp.Model.Patient);
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "FirstName", true));
            this.firstNameTextBox.Location = new System.Drawing.Point(244, 234);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(100, 31);
            this.firstNameTextBox.TabIndex = 24;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "LastName", true));
            this.lastNameTextBox.Location = new System.Drawing.Point(244, 278);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(100, 31);
            this.lastNameTextBox.TabIndex = 25;
            // 
            // birthDateTextBox
            // 
            this.birthDateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "BirthDate", true));
            this.birthDateTextBox.Location = new System.Drawing.Point(244, 322);
            this.birthDateTextBox.Name = "birthDateTextBox";
            this.birthDateTextBox.Size = new System.Drawing.Size(100, 31);
            this.birthDateTextBox.TabIndex = 26;
            // 
            // nurseBindingSource
            // 
            this.nurseBindingSource.DataSource = typeof(ClinicApp.Model.Nurse);
            // 
            // AddVisitUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(birthDateLabel);
            this.Controls.Add(this.birthDateTextBox);
            this.Controls.Add(lastNameLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(firstNameLabel);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.vistiGroupBox);
            this.Controls.Add(appointmentIDLabel);
            this.Controls.Add(this.appointmentIDTextBox);
            this.Controls.Add(finalDiagnosisLabel);
            this.Controls.Add(this.finalDiagnosisTextBox);
            this.Controls.Add(initialDiagnosisLabel);
            this.Controls.Add(this.initialDiagnosisTextBox);
            this.Controls.Add(nurseIDLabel);
            this.Controls.Add(this.nurseIDTextBox);
            this.Controls.Add(patientIDLabel);
            this.Controls.Add(this.patientIDTextBox);
            this.Controls.Add(this.visitBindingNavigator);
            this.Name = "AddVisitUserControl";
            this.Size = new System.Drawing.Size(1626, 814);
            ((System.ComponentModel.ISupportInitialize)(this.visitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitBindingNavigator)).EndInit();
            this.visitBindingNavigator.ResumeLayout(false);
            this.visitBindingNavigator.PerformLayout();
            this.vistiGroupBox.ResumeLayout(false);
            this.vistiGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nurseBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource visitBindingSource;
        private System.Windows.Forms.BindingNavigator visitBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton visitBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox appointmentIDTextBox;
        private System.Windows.Forms.TextBox diastolicBPTextBox;
        private System.Windows.Forms.TextBox finalDiagnosisTextBox;
        private System.Windows.Forms.TextBox initialDiagnosisTextBox;
        private System.Windows.Forms.TextBox nurseIDTextBox;
        private System.Windows.Forms.TextBox patientIDTextBox;
        private System.Windows.Forms.TextBox pulseTextBox;
        private System.Windows.Forms.TextBox symptomsTextBox;
        private System.Windows.Forms.TextBox systolicBPTextBox;
        private System.Windows.Forms.TextBox temperatureTextBox;
        private System.Windows.Forms.TextBox weightTextBox;
        private System.Windows.Forms.GroupBox vistiGroupBox;
        private System.Windows.Forms.BindingSource patientBindingSource;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox birthDateTextBox;
        private System.Windows.Forms.BindingSource nurseBindingSource;
    }
}
