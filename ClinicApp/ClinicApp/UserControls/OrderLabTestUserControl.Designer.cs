namespace ClinicApp.UserControls
{
    partial class OrderLabTestUserControl
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
            System.Windows.Forms.Label lbltTestName;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.testOrderedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmboBoxTestID = new System.Windows.Forms.ComboBox();
            this.labTestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAddTest = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.testOrderedDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            lbltTestName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.testOrderedBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labTestBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testOrderedDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lbltTestName
            // 
            lbltTestName.AutoSize = true;
            lbltTestName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbltTestName.Location = new System.Drawing.Point(183, 41);
            lbltTestName.Name = "lbltTestName";
            lbltTestName.Size = new System.Drawing.Size(44, 20);
            lbltTestName.TabIndex = 2;
            lbltTestName.Text = "Test:";
            // 
            // testOrderedBindingSource
            // 
            this.testOrderedBindingSource.DataSource = typeof(ClinicApp.Model.TestOrdered);
            // 
            // cmboBoxTestID
            // 
            this.cmboBoxTestID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.labTestBindingSource, "TestName", true));
            this.cmboBoxTestID.DataSource = this.labTestBindingSource;
            this.cmboBoxTestID.DisplayMember = "TestName";
            this.cmboBoxTestID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboBoxTestID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmboBoxTestID.FormattingEnabled = true;
            this.cmboBoxTestID.Location = new System.Drawing.Point(246, 39);
            this.cmboBoxTestID.Name = "cmboBoxTestID";
            this.cmboBoxTestID.Size = new System.Drawing.Size(260, 26);
            this.cmboBoxTestID.TabIndex = 3;
            this.cmboBoxTestID.ValueMember = "TestCode";
            // 
            // labTestBindingSource
            // 
            this.labTestBindingSource.DataSource = typeof(ClinicApp.Model.LabTest);
            // 
            // btnAddTest
            // 
            this.btnAddTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTest.Location = new System.Drawing.Point(388, 71);
            this.btnAddTest.Name = "btnAddTest";
            this.btnAddTest.Size = new System.Drawing.Size(118, 28);
            this.btnAddTest.TabIndex = 4;
            this.btnAddTest.Text = "Order Test";
            this.btnAddTest.UseVisualStyleBackColor = true;
            this.btnAddTest.Click += new System.EventHandler(this.btnAddTest_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.Location = new System.Drawing.Point(352, 361);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(154, 36);
            this.btnOrder.TabIndex = 5;
            this.btnOrder.Text = "Add Labs to Visit";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // testOrderedDataGridView
            // 
            this.testOrderedDataGridView.AllowUserToAddRows = false;
            this.testOrderedDataGridView.AllowUserToDeleteRows = false;
            this.testOrderedDataGridView.AutoGenerateColumns = false;
            this.testOrderedDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.testOrderedDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn5,
            this.AddEdit});
            this.testOrderedDataGridView.DataSource = this.testOrderedBindingSource;
            this.testOrderedDataGridView.Location = new System.Drawing.Point(3, 105);
            this.testOrderedDataGridView.Name = "testOrderedDataGridView";
            this.testOrderedDataGridView.ReadOnly = true;
            this.testOrderedDataGridView.Size = new System.Drawing.Size(512, 238);
            this.testOrderedDataGridView.TabIndex = 5;
            this.testOrderedDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.testOrderedDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "AppointmentID";
            this.dataGridViewTextBoxColumn1.HeaderText = "AppointmentID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TestCode";
            this.dataGridViewTextBoxColumn2.HeaderText = "TestCode";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn3.HeaderText = "Test Name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Date";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn4.HeaderText = "Test Date";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 75;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Result";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Abnormal Result";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            this.dataGridViewCheckBoxColumn1.Width = 70;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ResultDetail";
            this.dataGridViewTextBoxColumn5.HeaderText = "Result Detail";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 130;
            // 
            // AddEdit
            // 
            this.AddEdit.HeaderText = "";
            this.AddEdit.Name = "AddEdit";
            this.AddEdit.ReadOnly = true;
            this.AddEdit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.AddEdit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.AddEdit.Text = "Add/Edit/Delete";
            this.AddEdit.UseColumnTextForButtonValue = true;
            this.AddEdit.Width = 90;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(20, 361);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 36);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Close";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.Black;
            this.lblMessage.Location = new System.Drawing.Point(17, 12);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 13);
            this.lblMessage.TabIndex = 7;
            // 
            // OrderLabTestUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.testOrderedDataGridView);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.btnAddTest);
            this.Controls.Add(lbltTestName);
            this.Controls.Add(this.cmboBoxTestID);
            this.Name = "OrderLabTestUserControl";
            this.Size = new System.Drawing.Size(523, 416);
            this.Load += new System.EventHandler(this.OrderLabTestUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.testOrderedBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labTestBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testOrderedDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource testOrderedBindingSource;
        private System.Windows.Forms.BindingSource labTestBindingSource;
        private System.Windows.Forms.ComboBox cmboBoxTestID;
        private System.Windows.Forms.Button btnAddTest;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.DataGridView testOrderedDataGridView;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewButtonColumn AddEdit;
        private System.Windows.Forms.Label lblMessage;
    }
}
