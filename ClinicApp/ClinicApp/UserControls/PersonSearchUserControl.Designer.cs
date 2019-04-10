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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            firstNameLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            birthDateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // firstNameLabel
            // 
            firstNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            firstNameLabel.AutoSize = true;
            firstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            firstNameLabel.Location = new System.Drawing.Point(54, 22);
            firstNameLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(184, 37);
            firstNameLabel.TabIndex = 1;
            firstNameLabel.Text = "First Name:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lastNameLabel.Location = new System.Drawing.Point(347, 22);
            lastNameLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(182, 37);
            lastNameLabel.TabIndex = 3;
            lastNameLabel.Text = "Last Name:";
            // 
            // birthDateLabel
            // 
            birthDateLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            birthDateLabel.AutoSize = true;
            birthDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            birthDateLabel.Location = new System.Drawing.Point(646, 22);
            birthDateLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            birthDateLabel.Name = "birthDateLabel";
            birthDateLabel.Size = new System.Drawing.Size(168, 37);
            birthDateLabel.TabIndex = 5;
            birthDateLabel.Text = "Birth Date:";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personBindingSource, "FirstName", true));
            this.firstNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameTextBox.Location = new System.Drawing.Point(6, 99);
            this.firstNameTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(280, 44);
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
            this.lastNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personBindingSource, "LastName", true));
            this.lastNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameTextBox.Location = new System.Drawing.Point(298, 99);
            this.lastNameTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(280, 44);
            this.lastNameTextBox.TabIndex = 1;
            this.lastNameTextBox.TextChanged += new System.EventHandler(this.textChanged);
            this.lastNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Enter_KeyPress);
            // 
            // birthDateDateTimePicker
            // 
            this.birthDateDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.birthDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.personBindingSource, "BirthDate", true));
            this.birthDateDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.birthDateDateTimePicker.Location = new System.Drawing.Point(597, 99);
            this.birthDateDateTimePicker.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.birthDateDateTimePicker.Name = "birthDateDateTimePicker";
            this.birthDateDateTimePicker.Size = new System.Drawing.Size(266, 44);
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
            this.btnGetPerson.Location = new System.Drawing.Point(6, 37);
            this.btnGetPerson.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnGetPerson.Name = "btnGetPerson";
            this.btnGetPerson.Padding = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.btnGetPerson.Size = new System.Drawing.Size(279, 88);
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
            this.btnClear.Location = new System.Drawing.Point(360, 37);
            this.btnClear.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(154, 88);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1472, 168);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(firstNameLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(lastNameLabel, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.birthDateDateTimePicker, 2, 1);
            this.tableLayoutPanel2.Controls.Add(birthDateLabel, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.lastNameTextBox, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.firstNameTextBox, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(877, 162);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.btnClear, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnGetPerson, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(886, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(583, 162);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // PersonSearchUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "PersonSearchUserControl";
            this.Padding = new System.Windows.Forms.Padding(20, 19, 20, 19);
            this.Size = new System.Drawing.Size(1512, 206);
            this.Enter += new System.EventHandler(this.PersonSearchUserControl_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource personBindingSource;
        private System.Windows.Forms.Button btnGetPerson;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        public System.Windows.Forms.TextBox firstNameTextBox;
        public System.Windows.Forms.TextBox lastNameTextBox;
        public System.Windows.Forms.DateTimePicker birthDateDateTimePicker;
    }
}
