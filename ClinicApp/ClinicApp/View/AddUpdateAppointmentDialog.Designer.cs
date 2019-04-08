using System;
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
            firstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            firstNameLabel.Location = new System.Drawing.Point(20, 27);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(90, 20);
            firstNameLabel.TabIndex = 3;
            firstNameLabel.Text = "First Name:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lastNameLabel.Location = new System.Drawing.Point(19, 59);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(90, 20);
            lastNameLabel.TabIndex = 5;
            lastNameLabel.Text = "Last Name:";
            // 
            // appointmentDateTimeLabel
            // 
            appointmentDateTimeLabel.AutoSize = true;
            appointmentDateTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            appointmentDateTimeLabel.Location = new System.Drawing.Point(25, 134);
            appointmentDateTimeLabel.Name = "appointmentDateTimeLabel";
            appointmentDateTimeLabel.Size = new System.Drawing.Size(143, 20);
            appointmentDateTimeLabel.TabIndex = 7;
            appointmentDateTimeLabel.Text = "Appointment Date:";
            // 
            // appointmentDateTimeLabel1
            // 
            appointmentDateTimeLabel1.AutoSize = true;
            appointmentDateTimeLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            appointmentDateTimeLabel1.Location = new System.Drawing.Point(25, 164);
            appointmentDateTimeLabel1.Name = "appointmentDateTimeLabel1";
            appointmentDateTimeLabel1.Size = new System.Drawing.Size(142, 20);
            appointmentDateTimeLabel1.TabIndex = 9;
            appointmentDateTimeLabel1.Text = "Appointment Time:";
            // 
            // appointmentReasonLabel
            // 
            appointmentReasonLabel.AutoSize = true;
            appointmentReasonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            appointmentReasonLabel.Location = new System.Drawing.Point(22, 228);
            appointmentReasonLabel.Name = "appointmentReasonLabel";
            appointmentReasonLabel.Size = new System.Drawing.Size(164, 20);
            appointmentReasonLabel.TabIndex = 11;
            appointmentReasonLabel.Text = "Appointment Reason:";
            // 
            // doctorIDLabel
            // 
            doctorIDLabel.AutoSize = true;
            doctorIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            doctorIDLabel.Location = new System.Drawing.Point(25, 192);
            doctorIDLabel.Name = "doctorIDLabel";
            doctorIDLabel.Size = new System.Drawing.Size(61, 20);
            doctorIDLabel.TabIndex = 13;
            doctorIDLabel.Text = "Doctor:";
            // 
            // birthDateLabel
            // 
            birthDateLabel.AutoSize = true;
            birthDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            birthDateLabel.Location = new System.Drawing.Point(23, 92);
            birthDateLabel.Name = "birthDateLabel";
            birthDateLabel.Size = new System.Drawing.Size(85, 20);
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
            this.txtBxfirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxfirstName.Location = new System.Drawing.Point(167, 21);
            this.txtBxfirstName.Name = "txtBxfirstName";
            this.txtBxfirstName.Size = new System.Drawing.Size(303, 26);
            this.txtBxfirstName.TabIndex = 4;
            // 
            // txtBxLastName
            // 
            this.txtBxLastName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "LastName", true));
            this.txtBxLastName.Enabled = false;
            this.txtBxLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxLastName.Location = new System.Drawing.Point(167, 53);
            this.txtBxLastName.Name = "txtBxLastName";
            this.txtBxLastName.Size = new System.Drawing.Size(302, 26);
            this.txtBxLastName.TabIndex = 6;
            // 
            // appointmentBindingSource
            // 
            this.appointmentBindingSource.DataSource = typeof(ClinicApp.Model.Appointment);
            // 
            // dateTimePickerAppointmentDate
            // 
            this.dateTimePickerAppointmentDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.appointmentBindingSource, "AppointmentDateTime", true));
            this.dateTimePickerAppointmentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerAppointmentDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerAppointmentDate.Location = new System.Drawing.Point(233, 127);
            this.dateTimePickerAppointmentDate.MinDate = new System.DateTime(2019, 4, 1, 22, 56, 28, 464);
            this.dateTimePickerAppointmentDate.Name = "dateTimePickerAppointmentDate";
            this.dateTimePickerAppointmentDate.Size = new System.Drawing.Size(236, 26);
            this.dateTimePickerAppointmentDate.TabIndex = 1;
            this.dateTimePickerAppointmentDate.Tag = "Appointment Date";
            this.dateTimePickerAppointmentDate.Value = new System.DateTime(2019, 4, 1, 22, 56, 28, 464);
            // 
            // dateTimePickerAppointmentTime
            // 
            this.dateTimePickerAppointmentTime.CustomFormat = "h.mm.tt";
            this.dateTimePickerAppointmentTime.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.appointmentBindingSource, "AppointmentDateTime", true));
            this.dateTimePickerAppointmentTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerAppointmentTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerAppointmentTime.Location = new System.Drawing.Point(233, 157);
            this.dateTimePickerAppointmentTime.Name = "dateTimePickerAppointmentTime";
            this.dateTimePickerAppointmentTime.ShowUpDown = true;
            this.dateTimePickerAppointmentTime.Size = new System.Drawing.Size(236, 26);
            this.dateTimePickerAppointmentTime.TabIndex = 2;
            this.dateTimePickerAppointmentTime.Tag = "Appointment Time";
            // 
            // txtBoxAppointmentReason
            // 
            this.txtBoxAppointmentReason.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.appointmentBindingSource, "AppointmentReason", true));
            this.txtBoxAppointmentReason.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxAppointmentReason.Location = new System.Drawing.Point(233, 225);
            this.txtBoxAppointmentReason.Multiline = true;
            this.txtBoxAppointmentReason.Name = "txtBoxAppointmentReason";
            this.txtBoxAppointmentReason.Size = new System.Drawing.Size(236, 71);
            this.txtBoxAppointmentReason.TabIndex = 4;
            this.txtBoxAppointmentReason.Tag = "Appointment Reason";
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
            this.cmboBoxDoctorID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmboBoxDoctorID.FormattingEnabled = true;
            this.cmboBoxDoctorID.Location = new System.Drawing.Point(233, 189);
            this.cmboBoxDoctorID.Name = "cmboBoxDoctorID";
            this.cmboBoxDoctorID.Size = new System.Drawing.Size(236, 28);
            this.cmboBoxDoctorID.TabIndex = 3;
            this.cmboBoxDoctorID.Tag = "Doctor";
            this.cmboBoxDoctorID.ValueMember = "DoctorID";
            // 
            // timePickerBirthDate
            // 
            this.timePickerBirthDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.patientBindingSource, "BirthDate", true));
            this.timePickerBirthDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.appointmentBindingSource, "AppointmentPatientID", true));
            this.timePickerBirthDate.Enabled = false;
            this.timePickerBirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timePickerBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.timePickerBirthDate.Location = new System.Drawing.Point(167, 85);
            this.timePickerBirthDate.Name = "timePickerBirthDate";
            this.timePickerBirthDate.Size = new System.Drawing.Size(303, 26);
            this.timePickerBirthDate.TabIndex = 15;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(233, 327);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 36);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(393, 327);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 36);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // AddUpdateAppointmentDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 394);
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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