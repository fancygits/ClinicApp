namespace ClinicApp.View
{
    partial class AddUpdateAppointmentDialog
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label appointmentDateTimeLabel;
            System.Windows.Forms.Label appointmentDateTimeLabel1;
            System.Windows.Forms.Label appointmentReasonLabel;
            System.Windows.Forms.Label doctorIDLabel;
            System.Windows.Forms.Label birthDateLabel;
            this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtBxfirstName = new System.Windows.Forms.TextBox();
            this.txtBxLastName = new System.Windows.Forms.TextBox();
            this.appointmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateTimePickerAppointmentDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerAppointmentTime = new System.Windows.Forms.DateTimePicker();
            this.txtBoxAppointmentReason = new System.Windows.Forms.TextBox();
            this.doctorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmboBoxDoctorID = new System.Windows.Forms.ComboBox();
            this.timePickerBirthDate = new System.Windows.Forms.DateTimePicker();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            firstNameLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            appointmentDateTimeLabel = new System.Windows.Forms.Label();
            appointmentDateTimeLabel1 = new System.Windows.Forms.Label();
            appointmentReasonLabel = new System.Windows.Forms.Label();
            doctorIDLabel = new System.Windows.Forms.Label();
            birthDateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new System.Drawing.Point(20, 34);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(60, 13);
            firstNameLabel.TabIndex = 3;
            firstNameLabel.Text = "First Name:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new System.Drawing.Point(19, 59);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(61, 13);
            lastNameLabel.TabIndex = 5;
            lastNameLabel.Text = "Last Name:";
            // 
            // appointmentDateTimeLabel
            // 
            appointmentDateTimeLabel.AutoSize = true;
            appointmentDateTimeLabel.Location = new System.Drawing.Point(25, 134);
            appointmentDateTimeLabel.Name = "appointmentDateTimeLabel";
            appointmentDateTimeLabel.Size = new System.Drawing.Size(121, 13);
            appointmentDateTimeLabel.TabIndex = 7;
            appointmentDateTimeLabel.Text = "Appointment Date Time:";
            // 
            // appointmentDateTimeLabel1
            // 
            appointmentDateTimeLabel1.AutoSize = true;
            appointmentDateTimeLabel1.Location = new System.Drawing.Point(25, 164);
            appointmentDateTimeLabel1.Name = "appointmentDateTimeLabel1";
            appointmentDateTimeLabel1.Size = new System.Drawing.Size(121, 13);
            appointmentDateTimeLabel1.TabIndex = 9;
            appointmentDateTimeLabel1.Text = "Appointment Date Time:";
            // 
            // appointmentReasonLabel
            // 
            appointmentReasonLabel.AutoSize = true;
            appointmentReasonLabel.Location = new System.Drawing.Point(22, 228);
            appointmentReasonLabel.Name = "appointmentReasonLabel";
            appointmentReasonLabel.Size = new System.Drawing.Size(109, 13);
            appointmentReasonLabel.TabIndex = 11;
            appointmentReasonLabel.Text = "Appointment Reason:";
            // 
            // doctorIDLabel
            // 
            doctorIDLabel.AutoSize = true;
            doctorIDLabel.Location = new System.Drawing.Point(25, 192);
            doctorIDLabel.Name = "doctorIDLabel";
            doctorIDLabel.Size = new System.Drawing.Size(56, 13);
            doctorIDLabel.TabIndex = 13;
            doctorIDLabel.Text = "Doctor ID:";
            // 
            // birthDateLabel
            // 
            birthDateLabel.AutoSize = true;
            birthDateLabel.Location = new System.Drawing.Point(22, 86);
            birthDateLabel.Name = "birthDateLabel";
            birthDateLabel.Size = new System.Drawing.Size(57, 13);
            birthDateLabel.TabIndex = 14;
            birthDateLabel.Text = "Birth Date:";
            // 
            // patientBindingSource
            // 
            this.patientBindingSource.DataSource = typeof(ClinicApp.Model.Patient);
            // 
            // txtBxfirstName
            // 
            this.txtBxfirstName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "FirstName", true));
            this.txtBxfirstName.Enabled = false;
            this.txtBxfirstName.Location = new System.Drawing.Point(86, 31);
            this.txtBxfirstName.Name = "txtBxfirstName";
            this.txtBxfirstName.Size = new System.Drawing.Size(303, 20);
            this.txtBxfirstName.TabIndex = 4;
            // 
            // txtBxLastName
            // 
            this.txtBxLastName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "LastName", true));
            this.txtBxLastName.Enabled = false;
            this.txtBxLastName.Location = new System.Drawing.Point(86, 56);
            this.txtBxLastName.Name = "txtBxLastName";
            this.txtBxLastName.Size = new System.Drawing.Size(302, 20);
            this.txtBxLastName.TabIndex = 6;
            // 
            // appointmentBindingSource
            // 
            this.appointmentBindingSource.DataSource = typeof(ClinicApp.Model.Appointment);
            // 
            // dateTimePickerAppointmentDate
            // 
            this.dateTimePickerAppointmentDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.appointmentBindingSource, "AppointmentDateTime", true));
            this.dateTimePickerAppointmentDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerAppointmentDate.Location = new System.Drawing.Point(152, 130);
            this.dateTimePickerAppointmentDate.Name = "dateTimePickerAppointmentDate";
            this.dateTimePickerAppointmentDate.Size = new System.Drawing.Size(236, 20);
            this.dateTimePickerAppointmentDate.TabIndex = 1;
            // 
            // dateTimePickerAppointmentTime
            // 
            this.dateTimePickerAppointmentTime.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.appointmentBindingSource, "AppointmentDateTime", true));
            this.dateTimePickerAppointmentTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerAppointmentTime.Location = new System.Drawing.Point(152, 160);
            this.dateTimePickerAppointmentTime.Name = "dateTimePickerAppointmentTime";
            this.dateTimePickerAppointmentTime.ShowUpDown = true;
            this.dateTimePickerAppointmentTime.Size = new System.Drawing.Size(236, 20);
            this.dateTimePickerAppointmentTime.TabIndex = 2;
            // 
            // txtBoxAppointmentReason
            // 
            this.txtBoxAppointmentReason.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.appointmentBindingSource, "AppointmentReason", true));
            this.txtBoxAppointmentReason.Location = new System.Drawing.Point(152, 228);
            this.txtBoxAppointmentReason.Multiline = true;
            this.txtBoxAppointmentReason.Name = "txtBoxAppointmentReason";
            this.txtBoxAppointmentReason.Size = new System.Drawing.Size(236, 71);
            this.txtBoxAppointmentReason.TabIndex = 4;
            // 
            // doctorBindingSource
            // 
            this.doctorBindingSource.DataSource = typeof(ClinicApp.Model.Doctor);
            // 
            // cmboBoxDoctorID
            // 
            this.cmboBoxDoctorID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorBindingSource, "DoctorID", true));
            this.cmboBoxDoctorID.DataSource = this.doctorBindingSource;
            this.cmboBoxDoctorID.DisplayMember = "FullName";
            this.cmboBoxDoctorID.FormattingEnabled = true;
            this.cmboBoxDoctorID.Location = new System.Drawing.Point(152, 192);
            this.cmboBoxDoctorID.Name = "cmboBoxDoctorID";
            this.cmboBoxDoctorID.Size = new System.Drawing.Size(236, 21);
            this.cmboBoxDoctorID.TabIndex = 3;
            this.cmboBoxDoctorID.ValueMember = "DoctorID";
            // 
            // timePickerBirthDate
            // 
            this.timePickerBirthDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.patientBindingSource, "BirthDate", true));
            this.timePickerBirthDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.appointmentBindingSource, "AppointmentPatientID", true));
            this.timePickerBirthDate.Enabled = false;
            this.timePickerBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.timePickerBirthDate.Location = new System.Drawing.Point(85, 82);
            this.timePickerBirthDate.Name = "timePickerBirthDate";
            this.timePickerBirthDate.Size = new System.Drawing.Size(303, 20);
            this.timePickerBirthDate.TabIndex = 15;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(220, 330);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(312, 330);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // AddUpdateAppointmentDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 365);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(birthDateLabel);
            this.Controls.Add(this.timePickerBirthDate);
            this.Controls.Add(doctorIDLabel);
            this.Controls.Add(this.cmboBoxDoctorID);
            this.Controls.Add(appointmentReasonLabel);
            this.Controls.Add(this.txtBoxAppointmentReason);
            this.Controls.Add(appointmentDateTimeLabel1);
            this.Controls.Add(this.dateTimePickerAppointmentTime);
            this.Controls.Add(appointmentDateTimeLabel);
            this.Controls.Add(this.dateTimePickerAppointmentDate);
            this.Controls.Add(lastNameLabel);
            this.Controls.Add(this.txtBxLastName);
            this.Controls.Add(firstNameLabel);
            this.Controls.Add(this.txtBxfirstName);
            this.Name = "AddUpdateAppointmentDialog";
            this.Text = "Add/Update Appointment";
            this.Load += new System.EventHandler(this.AddUpdateAppointmentDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource patientBindingSource;
        private System.Windows.Forms.TextBox txtBxfirstName;
        private System.Windows.Forms.TextBox txtBxLastName;
        private System.Windows.Forms.BindingSource appointmentBindingSource;
        private System.Windows.Forms.DateTimePicker dateTimePickerAppointmentDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerAppointmentTime;
        private System.Windows.Forms.TextBox txtBoxAppointmentReason;
        private System.Windows.Forms.BindingSource doctorBindingSource;
        private System.Windows.Forms.ComboBox cmboBoxDoctorID;
        private System.Windows.Forms.DateTimePicker timePickerBirthDate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
    }
}