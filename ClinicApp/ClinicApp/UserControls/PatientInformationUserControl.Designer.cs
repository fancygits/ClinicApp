namespace ClinicApp.UserControls
{
    partial class PatientInformationUserControl
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
            System.Windows.Forms.Label birthDateLabel;
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label genderLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label phoneNumberLabel;
            System.Windows.Forms.Label postCodeLabel;
            System.Windows.Forms.Label sSNLabel;
            System.Windows.Forms.Label stateLabel;
            System.Windows.Forms.Label streetAddressLabel;
            this.birthDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.postCodeTextBox = new System.Windows.Forms.TextBox();
            this.streetAddressTextBox = new System.Windows.Forms.TextBox();
            this.btnGetPatient = new System.Windows.Forms.Button();
            this.btnAddUpdatePatient = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.stateComboBox = new System.Windows.Forms.ComboBox();
            this.stateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnClear = new System.Windows.Forms.Button();
            this.sSNMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.phoneNumberMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.btnSearchAppointments = new System.Windows.Forms.Button();
            this.btnSearchVisits = new System.Windows.Forms.Button();
            birthDateLabel = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            firstNameLabel = new System.Windows.Forms.Label();
            genderLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            phoneNumberLabel = new System.Windows.Forms.Label();
            postCodeLabel = new System.Windows.Forms.Label();
            sSNLabel = new System.Windows.Forms.Label();
            stateLabel = new System.Windows.Forms.Label();
            streetAddressLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // birthDateLabel
            // 
            birthDateLabel.AutoSize = true;
            birthDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            birthDateLabel.Location = new System.Drawing.Point(33, 119);
            birthDateLabel.Name = "birthDateLabel";
            birthDateLabel.Size = new System.Drawing.Size(103, 20);
            birthDateLabel.TabIndex = 0;
            birthDateLabel.Text = "Date of Birth:";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cityLabel.Location = new System.Drawing.Point(390, 149);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(39, 20);
            cityLabel.TabIndex = 2;
            cityLabel.Text = "City:";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            firstNameLabel.Location = new System.Drawing.Point(33, 33);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(90, 20);
            firstNameLabel.TabIndex = 4;
            firstNameLabel.Text = "First Name:";
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            genderLabel.Location = new System.Drawing.Point(390, 71);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new System.Drawing.Size(67, 20);
            genderLabel.TabIndex = 6;
            genderLabel.Text = "Gender:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lastNameLabel.Location = new System.Drawing.Point(33, 76);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(90, 20);
            lastNameLabel.TabIndex = 8;
            lastNameLabel.Text = "Last Name:";
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            phoneNumberLabel.Location = new System.Drawing.Point(390, 265);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new System.Drawing.Size(119, 20);
            phoneNumberLabel.TabIndex = 14;
            phoneNumberLabel.Text = "Phone Number:";
            // 
            // postCodeLabel
            // 
            postCodeLabel.AutoSize = true;
            postCodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            postCodeLabel.Location = new System.Drawing.Point(390, 227);
            postCodeLabel.Name = "postCodeLabel";
            postCodeLabel.Size = new System.Drawing.Size(87, 20);
            postCodeLabel.TabIndex = 16;
            postCodeLabel.Text = "Post Code:";
            // 
            // sSNLabel
            // 
            sSNLabel.AutoSize = true;
            sSNLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sSNLabel.Location = new System.Drawing.Point(390, 33);
            sSNLabel.Name = "sSNLabel";
            sSNLabel.Size = new System.Drawing.Size(46, 20);
            sSNLabel.TabIndex = 18;
            sSNLabel.Text = "SSN:";
            // 
            // stateLabel
            // 
            stateLabel.AutoSize = true;
            stateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            stateLabel.Location = new System.Drawing.Point(390, 187);
            stateLabel.Name = "stateLabel";
            stateLabel.Size = new System.Drawing.Size(52, 20);
            stateLabel.TabIndex = 20;
            stateLabel.Text = "State:";
            // 
            // streetAddressLabel
            // 
            streetAddressLabel.AutoSize = true;
            streetAddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            streetAddressLabel.Location = new System.Drawing.Point(390, 111);
            streetAddressLabel.Name = "streetAddressLabel";
            streetAddressLabel.Size = new System.Drawing.Size(120, 20);
            streetAddressLabel.TabIndex = 22;
            streetAddressLabel.Text = "Street Address:";
            // 
            // birthDateDateTimePicker
            // 
            this.birthDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.patientBindingSource, "BirthDate", true));
            this.birthDateDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.birthDateDateTimePicker.Location = new System.Drawing.Point(142, 114);
            this.birthDateDateTimePicker.Name = "birthDateDateTimePicker";
            this.birthDateDateTimePicker.Size = new System.Drawing.Size(200, 26);
            this.birthDateDateTimePicker.TabIndex = 2;
            this.birthDateDateTimePicker.Tag = "Date of birth";
            this.birthDateDateTimePicker.ValueChanged += new System.EventHandler(this.PatientTextboxChanged);
            this.birthDateDateTimePicker.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Enter_KeyPress);
            // 
            // patientBindingSource
            // 
            this.patientBindingSource.DataSource = typeof(ClinicApp.Model.Patient);
            // 
            // cityTextBox
            // 
            this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "City", true));
            this.cityTextBox.Enabled = false;
            this.cityTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityTextBox.Location = new System.Drawing.Point(516, 146);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(200, 26);
            this.cityTextBox.TabIndex = 7;
            this.cityTextBox.Tag = "City";
            this.cityTextBox.TextChanged += new System.EventHandler(this.PatientTextboxChanged);
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "FirstName", true));
            this.firstNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameTextBox.Location = new System.Drawing.Point(142, 30);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(200, 26);
            this.firstNameTextBox.TabIndex = 0;
            this.firstNameTextBox.Tag = "First name";
            this.firstNameTextBox.TextChanged += new System.EventHandler(this.PatientTextboxChanged);
            this.firstNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Enter_KeyPress);
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "LastName", true));
            this.lastNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameTextBox.Location = new System.Drawing.Point(142, 73);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(200, 26);
            this.lastNameTextBox.TabIndex = 1;
            this.lastNameTextBox.Tag = "Last name";
            this.lastNameTextBox.TextChanged += new System.EventHandler(this.PatientTextboxChanged);
            this.lastNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Enter_KeyPress);
            // 
            // postCodeTextBox
            // 
            this.postCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "PostCode", true));
            this.postCodeTextBox.Enabled = false;
            this.postCodeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postCodeTextBox.Location = new System.Drawing.Point(516, 224);
            this.postCodeTextBox.Name = "postCodeTextBox";
            this.postCodeTextBox.Size = new System.Drawing.Size(200, 26);
            this.postCodeTextBox.TabIndex = 9;
            this.postCodeTextBox.Tag = "Post code";
            this.postCodeTextBox.TextChanged += new System.EventHandler(this.PatientTextboxChanged);
            // 
            // streetAddressTextBox
            // 
            this.streetAddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "StreetAddress", true));
            this.streetAddressTextBox.Enabled = false;
            this.streetAddressTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.streetAddressTextBox.Location = new System.Drawing.Point(516, 108);
            this.streetAddressTextBox.Name = "streetAddressTextBox";
            this.streetAddressTextBox.Size = new System.Drawing.Size(200, 26);
            this.streetAddressTextBox.TabIndex = 6;
            this.streetAddressTextBox.Tag = "Street Address";
            this.streetAddressTextBox.TextChanged += new System.EventHandler(this.PatientTextboxChanged);
            // 
            // btnGetPatient
            // 
            this.btnGetPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetPatient.Image = global::ClinicApp.Properties.Resources.magnifier;
            this.btnGetPatient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGetPatient.Location = new System.Drawing.Point(161, 162);
            this.btnGetPatient.Name = "btnGetPatient";
            this.btnGetPatient.Padding = new System.Windows.Forms.Padding(5);
            this.btnGetPatient.Size = new System.Drawing.Size(181, 46);
            this.btnGetPatient.TabIndex = 3;
            this.btnGetPatient.Text = "Get Patient";
            this.btnGetPatient.UseVisualStyleBackColor = true;
            this.btnGetPatient.Click += new System.EventHandler(this.btnGetPatient_Click);
            this.btnGetPatient.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Enter_KeyPress);
            // 
            // btnAddUpdatePatient
            // 
            this.btnAddUpdatePatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUpdatePatient.Location = new System.Drawing.Point(608, 345);
            this.btnAddUpdatePatient.Name = "btnAddUpdatePatient";
            this.btnAddUpdatePatient.Size = new System.Drawing.Size(175, 35);
            this.btnAddUpdatePatient.TabIndex = 11;
            this.btnAddUpdatePatient.Text = "Update Patient";
            this.btnAddUpdatePatient.UseVisualStyleBackColor = true;
            this.btnAddUpdatePatient.Click += new System.EventHandler(this.btnAddUpdatePatient_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(394, 292);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(322, 50);
            this.lblMessage.TabIndex = 28;
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // genderComboBox
            // 
            this.genderComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.patientBindingSource, "Gender", true));
            this.genderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderComboBox.Enabled = false;
            this.genderComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Location = new System.Drawing.Point(516, 68);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(200, 28);
            this.genderComboBox.TabIndex = 5;
            this.genderComboBox.Tag = "Gender";
            this.genderComboBox.TextChanged += new System.EventHandler(this.PatientTextboxChanged);
            // 
            // stateComboBox
            // 
            this.stateComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.patientBindingSource, "State", true));
            this.stateComboBox.DataSource = this.stateBindingSource;
            this.stateComboBox.DisplayMember = "Name";
            this.stateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stateComboBox.Enabled = false;
            this.stateComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stateComboBox.FormattingEnabled = true;
            this.stateComboBox.Location = new System.Drawing.Point(516, 184);
            this.stateComboBox.Name = "stateComboBox";
            this.stateComboBox.Size = new System.Drawing.Size(200, 28);
            this.stateComboBox.TabIndex = 8;
            this.stateComboBox.Tag = "State";
            this.stateComboBox.ValueMember = "Abbreviation";
            this.stateComboBox.TextChanged += new System.EventHandler(this.PatientTextboxChanged);
            // 
            // stateBindingSource
            // 
            this.stateBindingSource.DataSource = typeof(ClinicApp.Model.State);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(31, 162);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(92, 46);
            this.btnClear.TabIndex = 30;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // sSNMaskedTextBox
            // 
            this.sSNMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "SSN", true));
            this.sSNMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sSNMaskedTextBox.Location = new System.Drawing.Point(516, 30);
            this.sSNMaskedTextBox.Mask = "000-00-0000";
            this.sSNMaskedTextBox.Name = "sSNMaskedTextBox";
            this.sSNMaskedTextBox.Size = new System.Drawing.Size(200, 26);
            this.sSNMaskedTextBox.TabIndex = 4;
            this.sSNMaskedTextBox.Tag = "SSN";
            this.sSNMaskedTextBox.TextChanged += new System.EventHandler(this.PatientTextboxChanged);
            // 
            // phoneNumberMaskedTextBox
            // 
            this.phoneNumberMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "PhoneNumber", true));
            this.phoneNumberMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumberMaskedTextBox.Location = new System.Drawing.Point(516, 262);
            this.phoneNumberMaskedTextBox.Mask = "(999) 000-0000";
            this.phoneNumberMaskedTextBox.Name = "phoneNumberMaskedTextBox";
            this.phoneNumberMaskedTextBox.Size = new System.Drawing.Size(200, 26);
            this.phoneNumberMaskedTextBox.TabIndex = 10;
            this.phoneNumberMaskedTextBox.Tag = "Phone number";
            this.phoneNumberMaskedTextBox.TextChanged += new System.EventHandler(this.PatientTextboxChanged);
            // 
            // btnSearchAppointments
            // 
            this.btnSearchAppointments.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchAppointments.Location = new System.Drawing.Point(31, 345);
            this.btnSearchAppointments.Name = "btnSearchAppointments";
            this.btnSearchAppointments.Size = new System.Drawing.Size(175, 35);
            this.btnSearchAppointments.TabIndex = 12;
            this.btnSearchAppointments.Text = "Search Appointments";
            this.btnSearchAppointments.UseVisualStyleBackColor = true;
            this.btnSearchAppointments.Click += new System.EventHandler(this.btnSearchAppointments_Click);
            // 
            // btnSearchVisits
            // 
            this.btnSearchVisits.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchVisits.Location = new System.Drawing.Point(244, 345);
            this.btnSearchVisits.Name = "btnSearchVisits";
            this.btnSearchVisits.Size = new System.Drawing.Size(175, 35);
            this.btnSearchVisits.TabIndex = 13;
            this.btnSearchVisits.Text = "Search Visits";
            this.btnSearchVisits.UseVisualStyleBackColor = true;
            // 
            // PatientInformationUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSearchVisits);
            this.Controls.Add(this.btnSearchAppointments);
            this.Controls.Add(this.phoneNumberMaskedTextBox);
            this.Controls.Add(this.sSNMaskedTextBox);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.stateComboBox);
            this.Controls.Add(this.genderComboBox);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnAddUpdatePatient);
            this.Controls.Add(this.btnGetPatient);
            this.Controls.Add(birthDateLabel);
            this.Controls.Add(this.birthDateDateTimePicker);
            this.Controls.Add(cityLabel);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(firstNameLabel);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(genderLabel);
            this.Controls.Add(lastNameLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(phoneNumberLabel);
            this.Controls.Add(postCodeLabel);
            this.Controls.Add(this.postCodeTextBox);
            this.Controls.Add(sSNLabel);
            this.Controls.Add(stateLabel);
            this.Controls.Add(streetAddressLabel);
            this.Controls.Add(this.streetAddressTextBox);
            this.Name = "PatientInformationUserControl";
            this.Size = new System.Drawing.Size(807, 400);
            this.Load += new System.EventHandler(this.PatientInformationUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource patientBindingSource;
        private System.Windows.Forms.DateTimePicker birthDateDateTimePicker;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox postCodeTextBox;
        private System.Windows.Forms.TextBox streetAddressTextBox;
        private System.Windows.Forms.Button btnGetPatient;
        private System.Windows.Forms.Button btnAddUpdatePatient;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.ComboBox genderComboBox;
        private System.Windows.Forms.ComboBox stateComboBox;
        private System.Windows.Forms.BindingSource stateBindingSource;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.MaskedTextBox sSNMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox phoneNumberMaskedTextBox;
        private System.Windows.Forms.Button btnSearchAppointments;
        private System.Windows.Forms.Button btnSearchVisits;
    }
}
