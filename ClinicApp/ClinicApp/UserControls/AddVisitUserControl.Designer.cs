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
            this.addVisitButton = new System.Windows.Forms.Button();
            this.updateVisitButton = new System.Windows.Forms.Button();
            this.nurseNameTextBox = new System.Windows.Forms.TextBox();
            this.btnLabTest = new System.Windows.Forms.Button();
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
            appointmentIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            appointmentIDLabel.Location = new System.Drawing.Point(63, 38);
            appointmentIDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            appointmentIDLabel.Name = "appointmentIDLabel";
            appointmentIDLabel.Size = new System.Drawing.Size(125, 20);
            appointmentIDLabel.TabIndex = 0;
            appointmentIDLabel.Text = "Appointment ID:";
            // 
            // patientNameLabel
            // 
            patientNameLabel.AutoSize = true;
            patientNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            patientNameLabel.Location = new System.Drawing.Point(64, 123);
            patientNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            patientNameLabel.Name = "patientNameLabel";
            patientNameLabel.Size = new System.Drawing.Size(109, 20);
            patientNameLabel.TabIndex = 4;
            patientNameLabel.Text = "Patient Name:";
            // 
            // birthDateLabel
            // 
            birthDateLabel.AutoSize = true;
            birthDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            birthDateLabel.Location = new System.Drawing.Point(64, 153);
            birthDateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            birthDateLabel.Name = "birthDateLabel";
            birthDateLabel.Size = new System.Drawing.Size(85, 20);
            birthDateLabel.TabIndex = 6;
            birthDateLabel.Text = "Birth Date:";
            // 
            // appointmentTimeLabel
            // 
            appointmentTimeLabel.AutoSize = true;
            appointmentTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            appointmentTimeLabel.Location = new System.Drawing.Point(64, 188);
            appointmentTimeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            appointmentTimeLabel.Name = "appointmentTimeLabel";
            appointmentTimeLabel.Size = new System.Drawing.Size(142, 20);
            appointmentTimeLabel.TabIndex = 8;
            appointmentTimeLabel.Text = "Appointment Time:";
            // 
            // doctorNameLabel
            // 
            doctorNameLabel.AutoSize = true;
            doctorNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            doctorNameLabel.Location = new System.Drawing.Point(64, 225);
            doctorNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            doctorNameLabel.Name = "doctorNameLabel";
            doctorNameLabel.Size = new System.Drawing.Size(107, 20);
            doctorNameLabel.TabIndex = 10;
            doctorNameLabel.Text = "Doctor Name:";
            // 
            // weightLabel
            // 
            weightLabel.AutoSize = true;
            weightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            weightLabel.Location = new System.Drawing.Point(483, 125);
            weightLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            weightLabel.Name = "weightLabel";
            weightLabel.Size = new System.Drawing.Size(63, 20);
            weightLabel.TabIndex = 12;
            weightLabel.Text = "Weight:";
            // 
            // systolicBPLabel
            // 
            systolicBPLabel.AutoSize = true;
            systolicBPLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            systolicBPLabel.Location = new System.Drawing.Point(483, 155);
            systolicBPLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            systolicBPLabel.Name = "systolicBPLabel";
            systolicBPLabel.Size = new System.Drawing.Size(92, 20);
            systolicBPLabel.TabIndex = 14;
            systolicBPLabel.Text = "Systolic BP:";
            // 
            // diastolicBPLabel
            // 
            diastolicBPLabel.AutoSize = true;
            diastolicBPLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            diastolicBPLabel.Location = new System.Drawing.Point(483, 184);
            diastolicBPLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            diastolicBPLabel.Name = "diastolicBPLabel";
            diastolicBPLabel.Size = new System.Drawing.Size(98, 20);
            diastolicBPLabel.TabIndex = 16;
            diastolicBPLabel.Text = "Diastolic BP:";
            // 
            // temperatureLabel
            // 
            temperatureLabel.AutoSize = true;
            temperatureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            temperatureLabel.Location = new System.Drawing.Point(483, 216);
            temperatureLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            temperatureLabel.Name = "temperatureLabel";
            temperatureLabel.Size = new System.Drawing.Size(104, 20);
            temperatureLabel.TabIndex = 18;
            temperatureLabel.Text = "Temperature:";
            // 
            // pulseLabel
            // 
            pulseLabel.AutoSize = true;
            pulseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pulseLabel.Location = new System.Drawing.Point(483, 252);
            pulseLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            pulseLabel.Name = "pulseLabel";
            pulseLabel.Size = new System.Drawing.Size(52, 20);
            pulseLabel.TabIndex = 20;
            pulseLabel.Text = "Pulse:";
            // 
            // symptomsLabel
            // 
            symptomsLabel.AutoSize = true;
            symptomsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            symptomsLabel.Location = new System.Drawing.Point(483, 282);
            symptomsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            symptomsLabel.Name = "symptomsLabel";
            symptomsLabel.Size = new System.Drawing.Size(88, 20);
            symptomsLabel.TabIndex = 22;
            symptomsLabel.Text = "Symptoms:";
            // 
            // nurseNameLabel
            // 
            nurseNameLabel.AutoSize = true;
            nurseNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nurseNameLabel.Location = new System.Drawing.Point(64, 258);
            nurseNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            nurseNameLabel.Name = "nurseNameLabel";
            nurseNameLabel.Size = new System.Drawing.Size(101, 20);
            nurseNameLabel.TabIndex = 23;
            nurseNameLabel.Text = "Nurse Name:";
            // 
            // appointmentIDTextBox
            // 
            this.appointmentIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitBindingSource, "AppointmentID", true));
            this.appointmentIDTextBox.Enabled = false;
            this.appointmentIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentIDTextBox.Location = new System.Drawing.Point(213, 36);
            this.appointmentIDTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.appointmentIDTextBox.Name = "appointmentIDTextBox";
            this.appointmentIDTextBox.Size = new System.Drawing.Size(52, 26);
            this.appointmentIDTextBox.TabIndex = 1;
            // 
            // visitBindingSource
            // 
            this.visitBindingSource.DataSource = typeof(ClinicApp.Model.Visit);
            // 
            // patientNameTextBox
            // 
            this.patientNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitBindingSource, "PatientName", true));
            this.patientNameTextBox.Enabled = false;
            this.patientNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientNameTextBox.Location = new System.Drawing.Point(256, 120);
            this.patientNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.patientNameTextBox.Name = "patientNameTextBox";
            this.patientNameTextBox.Size = new System.Drawing.Size(176, 26);
            this.patientNameTextBox.TabIndex = 5;
            // 
            // birthDateTextBox
            // 
            this.birthDateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitBindingSource, "VisitPatient.BirthDate", true));
            this.birthDateTextBox.Enabled = false;
            this.birthDateTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthDateTextBox.Location = new System.Drawing.Point(256, 153);
            this.birthDateTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.birthDateTextBox.Name = "birthDateTextBox";
            this.birthDateTextBox.Size = new System.Drawing.Size(176, 26);
            this.birthDateTextBox.TabIndex = 7;
            // 
            // appointmentTimeTextBox
            // 
            this.appointmentTimeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitBindingSource, "AppointmentTime", true));
            this.appointmentTimeTextBox.Enabled = false;
            this.appointmentTimeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentTimeTextBox.Location = new System.Drawing.Point(256, 188);
            this.appointmentTimeTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.appointmentTimeTextBox.Name = "appointmentTimeTextBox";
            this.appointmentTimeTextBox.Size = new System.Drawing.Size(176, 26);
            this.appointmentTimeTextBox.TabIndex = 9;
            // 
            // doctorNameTextBox
            // 
            this.doctorNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitBindingSource, "DoctorName", true));
            this.doctorNameTextBox.Enabled = false;
            this.doctorNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctorNameTextBox.Location = new System.Drawing.Point(256, 224);
            this.doctorNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.doctorNameTextBox.Name = "doctorNameTextBox";
            this.doctorNameTextBox.Size = new System.Drawing.Size(176, 26);
            this.doctorNameTextBox.TabIndex = 11;
            // 
            // weightTextBox
            // 
            this.weightTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitBindingSource, "Weight", true));
            this.weightTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weightTextBox.Location = new System.Drawing.Point(618, 120);
            this.weightTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(132, 26);
            this.weightTextBox.TabIndex = 13;
            // 
            // systolicBPTextBox
            // 
            this.systolicBPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitBindingSource, "SystolicBP", true));
            this.systolicBPTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.systolicBPTextBox.Location = new System.Drawing.Point(618, 151);
            this.systolicBPTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.systolicBPTextBox.Name = "systolicBPTextBox";
            this.systolicBPTextBox.Size = new System.Drawing.Size(132, 26);
            this.systolicBPTextBox.TabIndex = 15;
            // 
            // diastolicBPTextBox
            // 
            this.diastolicBPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitBindingSource, "DiastolicBP", true));
            this.diastolicBPTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diastolicBPTextBox.Location = new System.Drawing.Point(618, 180);
            this.diastolicBPTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.diastolicBPTextBox.Name = "diastolicBPTextBox";
            this.diastolicBPTextBox.Size = new System.Drawing.Size(132, 26);
            this.diastolicBPTextBox.TabIndex = 17;
            // 
            // temperatureTextBox
            // 
            this.temperatureTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitBindingSource, "Temperature", true));
            this.temperatureTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temperatureTextBox.Location = new System.Drawing.Point(618, 213);
            this.temperatureTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.temperatureTextBox.Name = "temperatureTextBox";
            this.temperatureTextBox.Size = new System.Drawing.Size(132, 26);
            this.temperatureTextBox.TabIndex = 19;
            // 
            // pulseTextBox
            // 
            this.pulseTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitBindingSource, "Pulse", true));
            this.pulseTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pulseTextBox.Location = new System.Drawing.Point(618, 250);
            this.pulseTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.pulseTextBox.Name = "pulseTextBox";
            this.pulseTextBox.Size = new System.Drawing.Size(132, 26);
            this.pulseTextBox.TabIndex = 21;
            // 
            // symptomsTextBox
            // 
            this.symptomsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitBindingSource, "Symptoms", true));
            this.symptomsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.symptomsTextBox.Location = new System.Drawing.Point(618, 281);
            this.symptomsTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.symptomsTextBox.Multiline = true;
            this.symptomsTextBox.Name = "symptomsTextBox";
            this.symptomsTextBox.Size = new System.Drawing.Size(132, 125);
            this.symptomsTextBox.TabIndex = 23;
            this.symptomsTextBox.Tag = "Visit";
            // 
            // nurseNameComboBox
            // 
            this.nurseNameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitBindingSource, "NurseName", true));
            this.nurseNameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.visitBindingSource, "NurseName", true));
            this.nurseNameComboBox.DataSource = this.nurseBindingSource;
            this.nurseNameComboBox.DisplayMember = "FullName";
            this.nurseNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nurseNameComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nurseNameComboBox.FormattingEnabled = true;
            this.nurseNameComboBox.Location = new System.Drawing.Point(256, 259);
            this.nurseNameComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.nurseNameComboBox.Name = "nurseNameComboBox";
            this.nurseNameComboBox.Size = new System.Drawing.Size(176, 28);
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
            this.addVisitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addVisitButton.Location = new System.Drawing.Point(66, 370);
            this.addVisitButton.Margin = new System.Windows.Forms.Padding(2);
            this.addVisitButton.Name = "addVisitButton";
            this.addVisitButton.Size = new System.Drawing.Size(128, 33);
            this.addVisitButton.TabIndex = 25;
            this.addVisitButton.Text = "Add Visit";
            this.addVisitButton.UseVisualStyleBackColor = true;
            this.addVisitButton.Click += new System.EventHandler(this.addVisitButton_Click);
            // 
            // updateVisitButton
            // 
            this.updateVisitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateVisitButton.Location = new System.Drawing.Point(256, 370);
            this.updateVisitButton.Margin = new System.Windows.Forms.Padding(2);
            this.updateVisitButton.Name = "updateVisitButton";
            this.updateVisitButton.Size = new System.Drawing.Size(128, 33);
            this.updateVisitButton.TabIndex = 26;
            this.updateVisitButton.Text = "Update Visit";
            this.updateVisitButton.UseVisualStyleBackColor = true;
            this.updateVisitButton.Click += new System.EventHandler(this.updateVisitButton_Click);
            // 
            // nurseNameTextBox
            // 
            this.nurseNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitBindingSource, "NurseName", true));
            this.nurseNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nurseNameTextBox.Location = new System.Drawing.Point(256, 259);
            this.nurseNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.nurseNameTextBox.Name = "nurseNameTextBox";
            this.nurseNameTextBox.Size = new System.Drawing.Size(176, 26);
            this.nurseNameTextBox.TabIndex = 27;
            // 
            // btnLabTest
            // 
            this.btnLabTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLabTest.Location = new System.Drawing.Point(631, 28);
            this.btnLabTest.Name = "btnLabTest";
            this.btnLabTest.Size = new System.Drawing.Size(109, 34);
            this.btnLabTest.TabIndex = 28;
            this.btnLabTest.Text = "Lab Tests";
            this.btnLabTest.UseVisualStyleBackColor = true;
            this.btnLabTest.Click += new System.EventHandler(this.btnLabTest_Click);
            // 
            // AddVisitUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnLabTest);
            this.Controls.Add(this.nurseNameTextBox);
            this.Controls.Add(this.updateVisitButton);
            this.Controls.Add(this.addVisitButton);
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
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddVisitUserControl";
            this.Size = new System.Drawing.Size(813, 423);
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
        public System.Windows.Forms.Button addVisitButton;
        public System.Windows.Forms.Button updateVisitButton;
        public System.Windows.Forms.TextBox nurseNameTextBox;
        private System.Windows.Forms.Button btnLabTest;
    }
}
