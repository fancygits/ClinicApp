namespace ClinicApp.UserControls
{
    partial class NurseInformationUserControl
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
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label streetAddressLabel;
            System.Windows.Forms.Label stateLabel;
            System.Windows.Forms.Label sSNLabel;
            System.Windows.Forms.Label postCodeLabel;
            System.Windows.Forms.Label phoneNumberLabel;
            System.Windows.Forms.Label birthDateLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label genderLabel;
            System.Windows.Forms.Label activeLabel;
            System.Windows.Forms.Label usernameLabel;
            this.btnClear = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnAddUpdateNurse = new System.Windows.Forms.Button();
            this.streetAddressTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.sSNMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.stateComboBox = new System.Windows.Forms.ComboBox();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.postCodeTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.birthDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.activeCheckBox = new System.Windows.Forms.CheckBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.btnUpdateCredentials = new System.Windows.Forms.Button();
            this.personSearchUserControl = new ClinicApp.UserControls.PersonSearchUserControl();
            this.nurseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            firstNameLabel = new System.Windows.Forms.Label();
            streetAddressLabel = new System.Windows.Forms.Label();
            stateLabel = new System.Windows.Forms.Label();
            sSNLabel = new System.Windows.Forms.Label();
            postCodeLabel = new System.Windows.Forms.Label();
            phoneNumberLabel = new System.Windows.Forms.Label();
            birthDateLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            genderLabel = new System.Windows.Forms.Label();
            activeLabel = new System.Windows.Forms.Label();
            usernameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nurseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // firstNameLabel
            // 
            firstNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            firstNameLabel.AutoSize = true;
            firstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            firstNameLabel.Location = new System.Drawing.Point(65, 114);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(90, 20);
            firstNameLabel.TabIndex = 61;
            firstNameLabel.Text = "First Name:";
            // 
            // streetAddressLabel
            // 
            streetAddressLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            streetAddressLabel.AutoSize = true;
            streetAddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            streetAddressLabel.Location = new System.Drawing.Point(408, 114);
            streetAddressLabel.Name = "streetAddressLabel";
            streetAddressLabel.Size = new System.Drawing.Size(120, 20);
            streetAddressLabel.TabIndex = 74;
            streetAddressLabel.Text = "Street Address:";
            // 
            // stateLabel
            // 
            stateLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            stateLabel.AutoSize = true;
            stateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            stateLabel.Location = new System.Drawing.Point(408, 194);
            stateLabel.Name = "stateLabel";
            stateLabel.Size = new System.Drawing.Size(52, 20);
            stateLabel.TabIndex = 73;
            stateLabel.Text = "State:";
            // 
            // sSNLabel
            // 
            sSNLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            sSNLabel.AutoSize = true;
            sSNLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sSNLabel.Location = new System.Drawing.Point(65, 231);
            sSNLabel.Name = "sSNLabel";
            sSNLabel.Size = new System.Drawing.Size(46, 20);
            sSNLabel.TabIndex = 72;
            sSNLabel.Text = "SSN:";
            // 
            // postCodeLabel
            // 
            postCodeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            postCodeLabel.AutoSize = true;
            postCodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            postCodeLabel.Location = new System.Drawing.Point(408, 231);
            postCodeLabel.Name = "postCodeLabel";
            postCodeLabel.Size = new System.Drawing.Size(87, 20);
            postCodeLabel.TabIndex = 71;
            postCodeLabel.Text = "Post Code:";
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            phoneNumberLabel.Location = new System.Drawing.Point(408, 270);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new System.Drawing.Size(119, 20);
            phoneNumberLabel.TabIndex = 70;
            phoneNumberLabel.Text = "Phone Number:";
            // 
            // birthDateLabel
            // 
            birthDateLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            birthDateLabel.AutoSize = true;
            birthDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            birthDateLabel.Location = new System.Drawing.Point(65, 194);
            birthDateLabel.Name = "birthDateLabel";
            birthDateLabel.Size = new System.Drawing.Size(103, 20);
            birthDateLabel.TabIndex = 55;
            birthDateLabel.Text = "Date of Birth:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lastNameLabel.Location = new System.Drawing.Point(65, 153);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(90, 20);
            lastNameLabel.TabIndex = 67;
            lastNameLabel.Text = "Last Name:";
            // 
            // cityLabel
            // 
            cityLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            cityLabel.AutoSize = true;
            cityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cityLabel.Location = new System.Drawing.Point(408, 153);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(39, 20);
            cityLabel.TabIndex = 58;
            cityLabel.Text = "City:";
            // 
            // genderLabel
            // 
            genderLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            genderLabel.AutoSize = true;
            genderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            genderLabel.Location = new System.Drawing.Point(65, 270);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new System.Drawing.Size(67, 20);
            genderLabel.TabIndex = 64;
            genderLabel.Text = "Gender:";
            // 
            // activeLabel
            // 
            activeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            activeLabel.AutoSize = true;
            activeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            activeLabel.Location = new System.Drawing.Point(65, 346);
            activeLabel.Name = "activeLabel";
            activeLabel.Size = new System.Drawing.Size(119, 20);
            activeLabel.TabIndex = 74;
            activeLabel.Text = "Account Active:";
            // 
            // usernameLabel
            // 
            usernameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            usernameLabel.Location = new System.Drawing.Point(65, 309);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new System.Drawing.Size(87, 20);
            usernameLabel.TabIndex = 74;
            usernameLabel.Text = "Username:";
            // 
            // btnClear
            // 
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(514, 345);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 35);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(413, 292);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(322, 50);
            this.lblMessage.TabIndex = 53;
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAddUpdateNurse
            // 
            this.btnAddUpdateNurse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddUpdateNurse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUpdateNurse.Location = new System.Drawing.Point(595, 345);
            this.btnAddUpdateNurse.Name = "btnAddUpdateNurse";
            this.btnAddUpdateNurse.Size = new System.Drawing.Size(175, 35);
            this.btnAddUpdateNurse.TabIndex = 12;
            this.btnAddUpdateNurse.Text = "Update Nurse";
            this.btnAddUpdateNurse.UseVisualStyleBackColor = true;
            this.btnAddUpdateNurse.Click += new System.EventHandler(this.btnAddUpdateNurse_Click);
            // 
            // streetAddressTextBox
            // 
            this.streetAddressTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.streetAddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nurseBindingSource, "StreetAddress", true));
            this.streetAddressTextBox.Enabled = false;
            this.streetAddressTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.streetAddressTextBox.Location = new System.Drawing.Point(534, 111);
            this.streetAddressTextBox.Name = "streetAddressTextBox";
            this.streetAddressTextBox.Size = new System.Drawing.Size(200, 26);
            this.streetAddressTextBox.TabIndex = 6;
            this.streetAddressTextBox.Tag = "Street Address";
            this.streetAddressTextBox.TextChanged += new System.EventHandler(this.NurseTextboxChanged);
            // 
            // phoneNumberMaskedTextBox
            // 
            this.phoneNumberMaskedTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.phoneNumberMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nurseBindingSource, "PhoneNumber", true));
            this.phoneNumberMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumberMaskedTextBox.Location = new System.Drawing.Point(534, 267);
            this.phoneNumberMaskedTextBox.Mask = "(999) 000-0000";
            this.phoneNumberMaskedTextBox.Name = "phoneNumberMaskedTextBox";
            this.phoneNumberMaskedTextBox.Size = new System.Drawing.Size(200, 26);
            this.phoneNumberMaskedTextBox.TabIndex = 10;
            this.phoneNumberMaskedTextBox.Tag = "Phone number";
            this.phoneNumberMaskedTextBox.TextChanged += new System.EventHandler(this.NurseTextboxChanged);
            // 
            // sSNMaskedTextBox
            // 
            this.sSNMaskedTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sSNMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nurseBindingSource, "SSN", true));
            this.sSNMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sSNMaskedTextBox.Location = new System.Drawing.Point(174, 228);
            this.sSNMaskedTextBox.Mask = "000-00-0000";
            this.sSNMaskedTextBox.Name = "sSNMaskedTextBox";
            this.sSNMaskedTextBox.Size = new System.Drawing.Size(200, 26);
            this.sSNMaskedTextBox.TabIndex = 4;
            this.sSNMaskedTextBox.Tag = "SSN";
            this.sSNMaskedTextBox.TextChanged += new System.EventHandler(this.NurseTextboxChanged);
            // 
            // stateComboBox
            // 
            this.stateComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.stateComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.nurseBindingSource, "State", true));
            this.stateComboBox.DisplayMember = "Name";
            this.stateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stateComboBox.Enabled = false;
            this.stateComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stateComboBox.FormattingEnabled = true;
            this.stateComboBox.Location = new System.Drawing.Point(534, 189);
            this.stateComboBox.Name = "stateComboBox";
            this.stateComboBox.Size = new System.Drawing.Size(200, 28);
            this.stateComboBox.TabIndex = 8;
            this.stateComboBox.Tag = "State";
            this.stateComboBox.ValueMember = "Abbreviation";
            this.stateComboBox.TextChanged += new System.EventHandler(this.NurseTextboxChanged);
            // 
            // genderComboBox
            // 
            this.genderComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.genderComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.nurseBindingSource, "Gender", true));
            this.genderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderComboBox.Enabled = false;
            this.genderComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Location = new System.Drawing.Point(174, 267);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(200, 28);
            this.genderComboBox.TabIndex = 5;
            this.genderComboBox.Tag = "Gender";
            this.genderComboBox.TextChanged += new System.EventHandler(this.NurseTextboxChanged);
            // 
            // postCodeTextBox
            // 
            this.postCodeTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.postCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nurseBindingSource, "PostCode", true));
            this.postCodeTextBox.Enabled = false;
            this.postCodeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postCodeTextBox.Location = new System.Drawing.Point(534, 228);
            this.postCodeTextBox.Name = "postCodeTextBox";
            this.postCodeTextBox.Size = new System.Drawing.Size(200, 26);
            this.postCodeTextBox.TabIndex = 9;
            this.postCodeTextBox.Tag = "Post code";
            this.postCodeTextBox.TextChanged += new System.EventHandler(this.NurseTextboxChanged);
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nurseBindingSource, "LastName", true));
            this.lastNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameTextBox.Location = new System.Drawing.Point(174, 150);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(200, 26);
            this.lastNameTextBox.TabIndex = 2;
            this.lastNameTextBox.Tag = "Last name";
            this.lastNameTextBox.TextChanged += new System.EventHandler(this.NurseTextboxChanged);
            // 
            // birthDateDateTimePicker
            // 
            this.birthDateDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.birthDateDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.birthDateDateTimePicker.Location = new System.Drawing.Point(174, 189);
            this.birthDateDateTimePicker.Name = "birthDateDateTimePicker";
            this.birthDateDateTimePicker.Size = new System.Drawing.Size(200, 26);
            this.birthDateDateTimePicker.TabIndex = 3;
            this.birthDateDateTimePicker.Tag = "Date of birth";
            this.birthDateDateTimePicker.ValueChanged += new System.EventHandler(this.NurseTextboxChanged);
            // 
            // cityTextBox
            // 
            this.cityTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nurseBindingSource, "City", true));
            this.cityTextBox.Enabled = false;
            this.cityTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityTextBox.Location = new System.Drawing.Point(534, 150);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(200, 26);
            this.cityTextBox.TabIndex = 7;
            this.cityTextBox.Tag = "City";
            this.cityTextBox.TextChanged += new System.EventHandler(this.NurseTextboxChanged);
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nurseBindingSource, "FirstName", true));
            this.firstNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameTextBox.Location = new System.Drawing.Point(174, 111);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(200, 26);
            this.firstNameTextBox.TabIndex = 1;
            this.firstNameTextBox.Tag = "First name";
            this.firstNameTextBox.TextChanged += new System.EventHandler(this.NurseTextboxChanged);
            // 
            // activeCheckBox
            // 
            this.activeCheckBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.activeCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.nurseBindingSource, "Active", true));
            this.activeCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activeCheckBox.Location = new System.Drawing.Point(190, 345);
            this.activeCheckBox.Name = "activeCheckBox";
            this.activeCheckBox.Size = new System.Drawing.Size(23, 24);
            this.activeCheckBox.TabIndex = 11;
            this.activeCheckBox.Tag = "Account Active";
            this.activeCheckBox.UseVisualStyleBackColor = true;
            this.activeCheckBox.CheckStateChanged += new System.EventHandler(this.NurseTextboxChanged);
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.usernameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nurseBindingSource, "Username", true));
            this.usernameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTextBox.Location = new System.Drawing.Point(174, 306);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(200, 26);
            this.usernameTextBox.TabIndex = 75;
            this.usernameTextBox.TextChanged += new System.EventHandler(this.NurseTextboxChanged);
            // 
            // btnUpdateCredentials
            // 
            this.btnUpdateCredentials.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdateCredentials.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateCredentials.Location = new System.Drawing.Point(219, 345);
            this.btnUpdateCredentials.Name = "btnUpdateCredentials";
            this.btnUpdateCredentials.Size = new System.Drawing.Size(155, 35);
            this.btnUpdateCredentials.TabIndex = 76;
            this.btnUpdateCredentials.Text = "Reset Password";
            this.btnUpdateCredentials.UseVisualStyleBackColor = true;
            this.btnUpdateCredentials.Click += new System.EventHandler(this.btnUpdateCredentials_Click);
            // 
            // personSearchUserControl
            // 
            this.personSearchUserControl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.personSearchUserControl.Location = new System.Drawing.Point(25, 0);
            this.personSearchUserControl.Margin = new System.Windows.Forms.Padding(0);
            this.personSearchUserControl.Name = "personSearchUserControl";
            this.personSearchUserControl.Size = new System.Drawing.Size(750, 80);
            this.personSearchUserControl.TabIndex = 0;
            // 
            // nurseBindingSource
            // 
            this.nurseBindingSource.DataSource = typeof(ClinicApp.Model.Nurse);
            // 
            // NurseInformationUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.personSearchUserControl);
            this.Controls.Add(this.btnUpdateCredentials);
            this.Controls.Add(usernameLabel);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(activeLabel);
            this.Controls.Add(this.activeCheckBox);
            this.Controls.Add(firstNameLabel);
            this.Controls.Add(this.streetAddressTextBox);
            this.Controls.Add(this.phoneNumberMaskedTextBox);
            this.Controls.Add(streetAddressLabel);
            this.Controls.Add(this.sSNMaskedTextBox);
            this.Controls.Add(stateLabel);
            this.Controls.Add(this.stateComboBox);
            this.Controls.Add(sSNLabel);
            this.Controls.Add(this.genderComboBox);
            this.Controls.Add(this.postCodeTextBox);
            this.Controls.Add(postCodeLabel);
            this.Controls.Add(phoneNumberLabel);
            this.Controls.Add(birthDateLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.birthDateDateTimePicker);
            this.Controls.Add(lastNameLabel);
            this.Controls.Add(cityLabel);
            this.Controls.Add(genderLabel);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnAddUpdateNurse);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "NurseInformationUserControl";
            this.Size = new System.Drawing.Size(800, 400);
            this.Load += new System.EventHandler(this.NurseInformationUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nurseBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnAddUpdateNurse;
        private System.Windows.Forms.BindingSource nurseBindingSource;
        private System.Windows.Forms.TextBox streetAddressTextBox;
        private System.Windows.Forms.MaskedTextBox phoneNumberMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox sSNMaskedTextBox;
        private System.Windows.Forms.ComboBox stateComboBox;
        private System.Windows.Forms.ComboBox genderComboBox;
        private System.Windows.Forms.TextBox postCodeTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.DateTimePicker birthDateDateTimePicker;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.CheckBox activeCheckBox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Button btnUpdateCredentials;
        private PersonSearchUserControl personSearchUserControl;
    }
}
