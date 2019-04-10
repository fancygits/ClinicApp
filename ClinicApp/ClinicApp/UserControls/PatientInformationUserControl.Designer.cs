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
            this.btnAddUpdatePatient = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.stateComboBox = new System.Windows.Forms.ComboBox();
            this.stateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sSNMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.phoneNumberMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.btnSearchAppointments = new System.Windows.Forms.Button();
            this.btnSearchVisits = new System.Windows.Forms.Button();
            this.btnDebug = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.personSearchUserControl = new ClinicApp.UserControls.PersonSearchUserControl();
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
            birthDateLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            birthDateLabel.AutoSize = true;
            birthDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            birthDateLabel.Location = new System.Drawing.Point(130, 373);
            birthDateLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            birthDateLabel.Name = "birthDateLabel";
            birthDateLabel.Size = new System.Drawing.Size(204, 37);
            birthDateLabel.TabIndex = 0;
            birthDateLabel.Text = "Date of Birth:";
            // 
            // cityLabel
            // 
            cityLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            cityLabel.AutoSize = true;
            cityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cityLabel.Location = new System.Drawing.Point(816, 294);
            cityLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(80, 37);
            cityLabel.TabIndex = 2;
            cityLabel.Text = "City:";
            // 
            // firstNameLabel
            // 
            firstNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            firstNameLabel.AutoSize = true;
            firstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            firstNameLabel.Location = new System.Drawing.Point(130, 219);
            firstNameLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(184, 37);
            firstNameLabel.TabIndex = 4;
            firstNameLabel.Text = "First Name:";
            // 
            // genderLabel
            // 
            genderLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            genderLabel.AutoSize = true;
            genderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            genderLabel.Location = new System.Drawing.Point(130, 519);
            genderLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new System.Drawing.Size(132, 37);
            genderLabel.TabIndex = 6;
            genderLabel.Text = "Gender:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lastNameLabel.Location = new System.Drawing.Point(130, 294);
            lastNameLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(182, 37);
            lastNameLabel.TabIndex = 8;
            lastNameLabel.Text = "Last Name:";
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            phoneNumberLabel.Location = new System.Drawing.Point(816, 519);
            phoneNumberLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new System.Drawing.Size(242, 37);
            phoneNumberLabel.TabIndex = 14;
            phoneNumberLabel.Text = "Phone Number:";
            // 
            // postCodeLabel
            // 
            postCodeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            postCodeLabel.AutoSize = true;
            postCodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            postCodeLabel.Location = new System.Drawing.Point(816, 444);
            postCodeLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            postCodeLabel.Name = "postCodeLabel";
            postCodeLabel.Size = new System.Drawing.Size(175, 37);
            postCodeLabel.TabIndex = 16;
            postCodeLabel.Text = "Post Code:";
            // 
            // sSNLabel
            // 
            sSNLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            sSNLabel.AutoSize = true;
            sSNLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sSNLabel.Location = new System.Drawing.Point(130, 444);
            sSNLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            sSNLabel.Name = "sSNLabel";
            sSNLabel.Size = new System.Drawing.Size(92, 37);
            sSNLabel.TabIndex = 18;
            sSNLabel.Text = "SSN:";
            // 
            // stateLabel
            // 
            stateLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            stateLabel.AutoSize = true;
            stateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            stateLabel.Location = new System.Drawing.Point(816, 373);
            stateLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            stateLabel.Name = "stateLabel";
            stateLabel.Size = new System.Drawing.Size(100, 37);
            stateLabel.TabIndex = 20;
            stateLabel.Text = "State:";
            // 
            // streetAddressLabel
            // 
            streetAddressLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            streetAddressLabel.AutoSize = true;
            streetAddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            streetAddressLabel.Location = new System.Drawing.Point(816, 219);
            streetAddressLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            streetAddressLabel.Name = "streetAddressLabel";
            streetAddressLabel.Size = new System.Drawing.Size(237, 37);
            streetAddressLabel.TabIndex = 22;
            streetAddressLabel.Text = "Street Address:";
            // 
            // birthDateDateTimePicker
            // 
            this.birthDateDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.birthDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.patientBindingSource, "BirthDate", true));
            this.birthDateDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.birthDateDateTimePicker.Location = new System.Drawing.Point(348, 363);
            this.birthDateDateTimePicker.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.birthDateDateTimePicker.Name = "birthDateDateTimePicker";
            this.birthDateDateTimePicker.Size = new System.Drawing.Size(396, 44);
            this.birthDateDateTimePicker.TabIndex = 2;
            this.birthDateDateTimePicker.Tag = "Date of birth";
            this.birthDateDateTimePicker.ValueChanged += new System.EventHandler(this.PatientTextboxChanged);
            // 
            // patientBindingSource
            // 
            this.patientBindingSource.DataSource = typeof(ClinicApp.Model.Patient);
            // 
            // cityTextBox
            // 
            this.cityTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "City", true));
            this.cityTextBox.Enabled = false;
            this.cityTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityTextBox.Location = new System.Drawing.Point(1068, 288);
            this.cityTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(396, 44);
            this.cityTextBox.TabIndex = 6;
            this.cityTextBox.Tag = "City";
            this.cityTextBox.TextChanged += new System.EventHandler(this.PatientTextboxChanged);
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "FirstName", true));
            this.firstNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameTextBox.Location = new System.Drawing.Point(348, 213);
            this.firstNameTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(396, 44);
            this.firstNameTextBox.TabIndex = 1;
            this.firstNameTextBox.Tag = "First name";
            this.firstNameTextBox.TextChanged += new System.EventHandler(this.PatientTextboxChanged);
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "LastName", true));
            this.lastNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameTextBox.Location = new System.Drawing.Point(348, 288);
            this.lastNameTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(396, 44);
            this.lastNameTextBox.TabIndex = 1;
            this.lastNameTextBox.Tag = "Last name";
            this.lastNameTextBox.TextChanged += new System.EventHandler(this.PatientTextboxChanged);
            // 
            // postCodeTextBox
            // 
            this.postCodeTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.postCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "PostCode", true));
            this.postCodeTextBox.Enabled = false;
            this.postCodeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postCodeTextBox.Location = new System.Drawing.Point(1068, 438);
            this.postCodeTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.postCodeTextBox.Name = "postCodeTextBox";
            this.postCodeTextBox.Size = new System.Drawing.Size(396, 44);
            this.postCodeTextBox.TabIndex = 8;
            this.postCodeTextBox.Tag = "Post code";
            this.postCodeTextBox.TextChanged += new System.EventHandler(this.PatientTextboxChanged);
            // 
            // streetAddressTextBox
            // 
            this.streetAddressTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.streetAddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "StreetAddress", true));
            this.streetAddressTextBox.Enabled = false;
            this.streetAddressTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.streetAddressTextBox.Location = new System.Drawing.Point(1068, 213);
            this.streetAddressTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.streetAddressTextBox.Name = "streetAddressTextBox";
            this.streetAddressTextBox.Size = new System.Drawing.Size(396, 44);
            this.streetAddressTextBox.TabIndex = 5;
            this.streetAddressTextBox.Tag = "Street Address";
            this.streetAddressTextBox.TextChanged += new System.EventHandler(this.PatientTextboxChanged);
            // 
            // btnAddUpdatePatient
            // 
            this.btnAddUpdatePatient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddUpdatePatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUpdatePatient.Location = new System.Drawing.Point(1190, 663);
            this.btnAddUpdatePatient.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnAddUpdatePatient.Name = "btnAddUpdatePatient";
            this.btnAddUpdatePatient.Size = new System.Drawing.Size(350, 67);
            this.btnAddUpdatePatient.TabIndex = 10;
            this.btnAddUpdatePatient.Text = "Update Patient";
            this.btnAddUpdatePatient.UseVisualStyleBackColor = true;
            this.btnAddUpdatePatient.Click += new System.EventHandler(this.btnAddUpdatePatient_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(826, 562);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(644, 96);
            this.lblMessage.TabIndex = 28;
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // genderComboBox
            // 
            this.genderComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.genderComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.patientBindingSource, "Gender", true));
            this.genderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderComboBox.Enabled = false;
            this.genderComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Location = new System.Drawing.Point(348, 513);
            this.genderComboBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(396, 45);
            this.genderComboBox.TabIndex = 4;
            this.genderComboBox.Tag = "Gender";
            this.genderComboBox.TextChanged += new System.EventHandler(this.PatientTextboxChanged);
            // 
            // stateComboBox
            // 
            this.stateComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.stateComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.patientBindingSource, "State", true));
            this.stateComboBox.DataSource = this.stateBindingSource;
            this.stateComboBox.DisplayMember = "Name";
            this.stateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stateComboBox.Enabled = false;
            this.stateComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stateComboBox.FormattingEnabled = true;
            this.stateComboBox.Location = new System.Drawing.Point(1068, 363);
            this.stateComboBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.stateComboBox.Name = "stateComboBox";
            this.stateComboBox.Size = new System.Drawing.Size(396, 45);
            this.stateComboBox.TabIndex = 7;
            this.stateComboBox.Tag = "State";
            this.stateComboBox.ValueMember = "Abbreviation";
            this.stateComboBox.TextChanged += new System.EventHandler(this.PatientTextboxChanged);
            // 
            // stateBindingSource
            // 
            this.stateBindingSource.DataSource = typeof(ClinicApp.Model.State);
            // 
            // sSNMaskedTextBox
            // 
            this.sSNMaskedTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sSNMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "SSN", true));
            this.sSNMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sSNMaskedTextBox.Location = new System.Drawing.Point(348, 438);
            this.sSNMaskedTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.sSNMaskedTextBox.Mask = "000-00-0000";
            this.sSNMaskedTextBox.Name = "sSNMaskedTextBox";
            this.sSNMaskedTextBox.Size = new System.Drawing.Size(396, 44);
            this.sSNMaskedTextBox.TabIndex = 3;
            this.sSNMaskedTextBox.Tag = "SSN";
            this.sSNMaskedTextBox.TextChanged += new System.EventHandler(this.PatientTextboxChanged);
            // 
            // phoneNumberMaskedTextBox
            // 
            this.phoneNumberMaskedTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.phoneNumberMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "PhoneNumber", true));
            this.phoneNumberMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumberMaskedTextBox.Location = new System.Drawing.Point(1068, 513);
            this.phoneNumberMaskedTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.phoneNumberMaskedTextBox.Mask = "(999) 000-0000";
            this.phoneNumberMaskedTextBox.Name = "phoneNumberMaskedTextBox";
            this.phoneNumberMaskedTextBox.Size = new System.Drawing.Size(396, 44);
            this.phoneNumberMaskedTextBox.TabIndex = 9;
            this.phoneNumberMaskedTextBox.Tag = "Phone number";
            this.phoneNumberMaskedTextBox.TextChanged += new System.EventHandler(this.PatientTextboxChanged);
            // 
            // btnSearchAppointments
            // 
            this.btnSearchAppointments.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearchAppointments.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchAppointments.Location = new System.Drawing.Point(60, 663);
            this.btnSearchAppointments.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnSearchAppointments.Name = "btnSearchAppointments";
            this.btnSearchAppointments.Size = new System.Drawing.Size(350, 67);
            this.btnSearchAppointments.TabIndex = 12;
            this.btnSearchAppointments.Text = "Search Appointments";
            this.btnSearchAppointments.UseVisualStyleBackColor = true;
            this.btnSearchAppointments.Click += new System.EventHandler(this.btnSearchAppointments_Click);
            // 
            // btnSearchVisits
            // 
            this.btnSearchVisits.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearchVisits.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchVisits.Location = new System.Drawing.Point(422, 663);
            this.btnSearchVisits.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnSearchVisits.Name = "btnSearchVisits";
            this.btnSearchVisits.Size = new System.Drawing.Size(350, 67);
            this.btnSearchVisits.TabIndex = 13;
            this.btnSearchVisits.Text = "Search Visits";
            this.btnSearchVisits.UseVisualStyleBackColor = true;
            this.btnSearchVisits.Click += new System.EventHandler(this.btnSearchVisits_Click);
            // 
            // btnDebug
            // 
            this.btnDebug.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDebug.BackColor = System.Drawing.Color.Transparent;
            this.btnDebug.Cursor = System.Windows.Forms.Cursors.Cross;
            this.btnDebug.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDebug.ForeColor = System.Drawing.Color.Transparent;
            this.btnDebug.Location = new System.Drawing.Point(4, 740);
            this.btnDebug.Margin = new System.Windows.Forms.Padding(0);
            this.btnDebug.Name = "btnDebug";
            this.btnDebug.Size = new System.Drawing.Size(10, 10);
            this.btnDebug.TabIndex = 31;
            this.btnDebug.TabStop = false;
            this.btnDebug.UseVisualStyleBackColor = false;
            this.btnDebug.Click += new System.EventHandler(this.DebugPatient);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(1028, 663);
            this.btnClear.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(150, 67);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // personSearchUserControl
            // 
            this.personSearchUserControl.Location = new System.Drawing.Point(0, 0);
            this.personSearchUserControl.Margin = new System.Windows.Forms.Padding(6);
            this.personSearchUserControl.Name = "personSearchUserControl";
            this.personSearchUserControl.Padding = new System.Windows.Forms.Padding(20, 19, 20, 19);
            this.personSearchUserControl.Size = new System.Drawing.Size(1594, 176);
            this.personSearchUserControl.TabIndex = 32;
            // 
            // PatientInformationUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.personSearchUserControl);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDebug);
            this.Controls.Add(this.btnSearchVisits);
            this.Controls.Add(this.btnSearchAppointments);
            this.Controls.Add(this.phoneNumberMaskedTextBox);
            this.Controls.Add(this.sSNMaskedTextBox);
            this.Controls.Add(this.stateComboBox);
            this.Controls.Add(this.genderComboBox);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnAddUpdatePatient);
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
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "PatientInformationUserControl";
            this.Size = new System.Drawing.Size(1600, 769);
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
        private System.Windows.Forms.Button btnAddUpdatePatient;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.ComboBox genderComboBox;
        private System.Windows.Forms.ComboBox stateComboBox;
        private System.Windows.Forms.BindingSource stateBindingSource;
        private System.Windows.Forms.MaskedTextBox sSNMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox phoneNumberMaskedTextBox;
        private System.Windows.Forms.Button btnSearchAppointments;
        private System.Windows.Forms.Button btnSearchVisits;
        private System.Windows.Forms.Button btnDebug;
        private System.Windows.Forms.Button btnClear;
        private PersonSearchUserControl personSearchUserControl;
    }
}
