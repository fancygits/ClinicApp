namespace ClinicApp.UserControls
{
    partial class PersonSearchUserControl
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
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label birthDateLabel;
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.birthDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.btnGetPerson = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            firstNameLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            birthDateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            firstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            firstNameLabel.Location = new System.Drawing.Point(3, 0);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(161, 35);
            firstNameLabel.TabIndex = 1;
            firstNameLabel.Text = "First Name:";
            firstNameLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            lastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lastNameLabel.Location = new System.Drawing.Point(170, 0);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(161, 35);
            lastNameLabel.TabIndex = 3;
            lastNameLabel.Text = "Last Name:";
            lastNameLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // birthDateLabel
            // 
            birthDateLabel.AutoSize = true;
            birthDateLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            birthDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            birthDateLabel.Location = new System.Drawing.Point(337, 0);
            birthDateLabel.Name = "birthDateLabel";
            birthDateLabel.Size = new System.Drawing.Size(161, 35);
            birthDateLabel.TabIndex = 5;
            birthDateLabel.Text = "Birth Date:";
            birthDateLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personBindingSource, "FirstName", true));
            this.firstNameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.firstNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameTextBox.Location = new System.Drawing.Point(5, 40);
            this.firstNameTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(157, 26);
            this.firstNameTextBox.TabIndex = 0;
            this.firstNameTextBox.TextChanged += new System.EventHandler(this.textChanged);
            this.firstNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Enter_KeyPress);
            // 
            // personBindingSource
            // 
            this.personBindingSource.DataSource = typeof(ClinicApp.Model.Person);
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personBindingSource, "LastName", true));
            this.lastNameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lastNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameTextBox.Location = new System.Drawing.Point(172, 40);
            this.lastNameTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(157, 26);
            this.lastNameTextBox.TabIndex = 1;
            this.lastNameTextBox.TextChanged += new System.EventHandler(this.textChanged);
            this.lastNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Enter_KeyPress);
            // 
            // birthDateDateTimePicker
            // 
            this.birthDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.personBindingSource, "BirthDate", true));
            this.birthDateDateTimePicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.birthDateDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.birthDateDateTimePicker.Location = new System.Drawing.Point(339, 40);
            this.birthDateDateTimePicker.Margin = new System.Windows.Forms.Padding(5);
            this.birthDateDateTimePicker.Name = "birthDateDateTimePicker";
            this.birthDateDateTimePicker.Size = new System.Drawing.Size(157, 26);
            this.birthDateDateTimePicker.TabIndex = 2;
            this.birthDateDateTimePicker.ValueChanged += new System.EventHandler(this.textChanged);
            this.birthDateDateTimePicker.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Enter_KeyPress);
            // 
            // btnGetPerson
            // 
            this.btnGetPerson.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGetPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetPerson.Image = global::ClinicApp.Properties.Resources.magnifier;
            this.btnGetPerson.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGetPerson.Location = new System.Drawing.Point(511, 12);
            this.btnGetPerson.Name = "btnGetPerson";
            this.btnGetPerson.Padding = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel4.SetRowSpan(this.btnGetPerson, 2);
            this.btnGetPerson.Size = new System.Drawing.Size(140, 46);
            this.btnGetPerson.TabIndex = 3;
            this.btnGetPerson.Text = "Get Person";
            this.btnGetPerson.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGetPerson.UseVisualStyleBackColor = true;
            this.btnGetPerson.Click += new System.EventHandler(this.GetPersonButton_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(667, 12);
            this.btnClear.Name = "btnClear";
            this.tableLayoutPanel4.SetRowSpan(this.btnClear, 2);
            this.btnClear.Size = new System.Drawing.Size(77, 46);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 5;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 88F));
            this.tableLayoutPanel4.Controls.Add(birthDateLabel, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.birthDateDateTimePicker, 2, 1);
            this.tableLayoutPanel4.Controls.Add(this.btnGetPerson, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnClear, 4, 0);
            this.tableLayoutPanel4.Controls.Add(lastNameLabel, 1, 0);
            this.tableLayoutPanel4.Controls.Add(firstNameLabel, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.lastNameTextBox, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.firstNameTextBox, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(750, 70);
            this.tableLayoutPanel4.TabIndex = 7;
            // 
            // PersonSearchUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.tableLayoutPanel4);
            this.Name = "PersonSearchUserControl";
            this.Size = new System.Drawing.Size(750, 70);
            this.Enter += new System.EventHandler(this.PersonSearchUserControl_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource personBindingSource;
        private System.Windows.Forms.Button btnGetPerson;
        private System.Windows.Forms.Button btnClear;
        public System.Windows.Forms.TextBox firstNameTextBox;
        public System.Windows.Forms.TextBox lastNameTextBox;
        public System.Windows.Forms.DateTimePicker birthDateDateTimePicker;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
    }
}
