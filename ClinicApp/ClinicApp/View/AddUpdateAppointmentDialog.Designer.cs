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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUpdateAppointmentDialog));
            this.patientBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.patientBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.txtBxfirstName = new System.Windows.Forms.TextBox();
            this.txtBxLastName = new System.Windows.Forms.TextBox();
            this.appointmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appointmentDateTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.appointmentDateTimeDateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtBoxAppointmentReason = new System.Windows.Forms.TextBox();
            this.doctorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmboBoxDoctorID = new System.Windows.Forms.ComboBox();
            this.timePickerBirthDateDate = new System.Windows.Forms.DateTimePicker();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            firstNameLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            appointmentDateTimeLabel = new System.Windows.Forms.Label();
            appointmentDateTimeLabel1 = new System.Windows.Forms.Label();
            appointmentReasonLabel = new System.Windows.Forms.Label();
            doctorIDLabel = new System.Windows.Forms.Label();
            birthDateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingNavigator)).BeginInit();
            this.patientBindingNavigator.SuspendLayout();
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
            // patientBindingNavigator
            // 
            this.patientBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.patientBindingNavigator.BindingSource = this.patientBindingSource;
            this.patientBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.patientBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.patientBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.patientBindingNavigatorSaveItem});
            this.patientBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.patientBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.patientBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.patientBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.patientBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.patientBindingNavigator.Name = "patientBindingNavigator";
            this.patientBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.patientBindingNavigator.Size = new System.Drawing.Size(421, 25);
            this.patientBindingNavigator.TabIndex = 0;
            this.patientBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // patientBindingSource
            // 
            this.patientBindingSource.DataSource = typeof(ClinicApp.Model.Patient);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // patientBindingNavigatorSaveItem
            // 
            this.patientBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.patientBindingNavigatorSaveItem.Enabled = false;
            this.patientBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("patientBindingNavigatorSaveItem.Image")));
            this.patientBindingNavigatorSaveItem.Name = "patientBindingNavigatorSaveItem";
            this.patientBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.patientBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // txtBxfirstName
            // 
            this.txtBxfirstName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "FirstName", true));
            this.txtBxfirstName.Location = new System.Drawing.Point(86, 31);
            this.txtBxfirstName.Name = "txtBxfirstName";
            this.txtBxfirstName.Size = new System.Drawing.Size(303, 20);
            this.txtBxfirstName.TabIndex = 4;
            // 
            // txtBxLastName
            // 
            this.txtBxLastName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "LastName", true));
            this.txtBxLastName.Location = new System.Drawing.Point(86, 56);
            this.txtBxLastName.Name = "txtBxLastName";
            this.txtBxLastName.Size = new System.Drawing.Size(302, 20);
            this.txtBxLastName.TabIndex = 6;
            // 
            // appointmentBindingSource
            // 
            this.appointmentBindingSource.DataSource = typeof(ClinicApp.Model.Appointment);
            // 
            // appointmentDateTimeDateTimePicker
            // 
            this.appointmentDateTimeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.appointmentBindingSource, "AppointmentDateTime", true));
            this.appointmentDateTimeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.appointmentDateTimeDateTimePicker.Location = new System.Drawing.Point(152, 130);
            this.appointmentDateTimeDateTimePicker.Name = "appointmentDateTimeDateTimePicker";
            this.appointmentDateTimeDateTimePicker.Size = new System.Drawing.Size(236, 20);
            this.appointmentDateTimeDateTimePicker.TabIndex = 8;
            // 
            // appointmentDateTimeDateTimePicker1
            // 
            this.appointmentDateTimeDateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.appointmentBindingSource, "AppointmentDateTime", true));
            this.appointmentDateTimeDateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.appointmentDateTimeDateTimePicker1.Location = new System.Drawing.Point(152, 160);
            this.appointmentDateTimeDateTimePicker1.Name = "appointmentDateTimeDateTimePicker1";
            this.appointmentDateTimeDateTimePicker1.Size = new System.Drawing.Size(236, 20);
            this.appointmentDateTimeDateTimePicker1.TabIndex = 10;
            // 
            // txtBoxAppointmentReason
            // 
            this.txtBoxAppointmentReason.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.appointmentBindingSource, "AppointmentReason", true));
            this.txtBoxAppointmentReason.Location = new System.Drawing.Point(152, 228);
            this.txtBoxAppointmentReason.Multiline = true;
            this.txtBoxAppointmentReason.Name = "txtBoxAppointmentReason";
            this.txtBoxAppointmentReason.Size = new System.Drawing.Size(236, 71);
            this.txtBoxAppointmentReason.TabIndex = 12;
            // 
            // doctorBindingSource
            // 
            this.doctorBindingSource.DataSource = typeof(ClinicApp.Model.Doctor);
            // 
            // cmboBoxDoctorID
            // 
            this.cmboBoxDoctorID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorBindingSource, "DoctorID", true));
            this.cmboBoxDoctorID.DataSource = this.doctorBindingSource;
            this.cmboBoxDoctorID.DisplayMember = "LastName";
            this.cmboBoxDoctorID.FormattingEnabled = true;
            this.cmboBoxDoctorID.Location = new System.Drawing.Point(152, 192);
            this.cmboBoxDoctorID.Name = "cmboBoxDoctorID";
            this.cmboBoxDoctorID.Size = new System.Drawing.Size(236, 21);
            this.cmboBoxDoctorID.TabIndex = 14;
            this.cmboBoxDoctorID.ValueMember = "DoctorID";
            // 
            // timePickerBirthDateDate
            // 
            this.timePickerBirthDateDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.patientBindingSource, "BirthDate", true));
            this.timePickerBirthDateDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.appointmentBindingSource, "AppointmentPatientID", true));
            this.timePickerBirthDateDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.timePickerBirthDateDate.Location = new System.Drawing.Point(85, 82);
            this.timePickerBirthDateDate.Name = "timePickerBirthDateDate";
            this.timePickerBirthDateDate.Size = new System.Drawing.Size(303, 20);
            this.timePickerBirthDateDate.TabIndex = 15;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(220, 330);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(312, 330);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 17;
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
            this.Controls.Add(this.timePickerBirthDateDate);
            this.Controls.Add(doctorIDLabel);
            this.Controls.Add(this.cmboBoxDoctorID);
            this.Controls.Add(appointmentReasonLabel);
            this.Controls.Add(this.txtBoxAppointmentReason);
            this.Controls.Add(appointmentDateTimeLabel1);
            this.Controls.Add(this.appointmentDateTimeDateTimePicker1);
            this.Controls.Add(appointmentDateTimeLabel);
            this.Controls.Add(this.appointmentDateTimeDateTimePicker);
            this.Controls.Add(lastNameLabel);
            this.Controls.Add(this.txtBxLastName);
            this.Controls.Add(firstNameLabel);
            this.Controls.Add(this.txtBxfirstName);
            this.Controls.Add(this.patientBindingNavigator);
            this.Name = "AddUpdateAppointmentDialog";
            this.Text = "Add/Update Appointment";
            this.Load += new System.EventHandler(this.AddUpdateAppointmentDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingNavigator)).EndInit();
            this.patientBindingNavigator.ResumeLayout(false);
            this.patientBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource patientBindingSource;
        private System.Windows.Forms.BindingNavigator patientBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton patientBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox txtBxfirstName;
        private System.Windows.Forms.TextBox txtBxLastName;
        private System.Windows.Forms.BindingSource appointmentBindingSource;
        private System.Windows.Forms.DateTimePicker appointmentDateTimeDateTimePicker;
        private System.Windows.Forms.DateTimePicker appointmentDateTimeDateTimePicker1;
        private System.Windows.Forms.TextBox txtBoxAppointmentReason;
        private System.Windows.Forms.BindingSource doctorBindingSource;
        private System.Windows.Forms.ComboBox cmboBoxDoctorID;
        private System.Windows.Forms.DateTimePicker timePickerBirthDateDate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
    }
}