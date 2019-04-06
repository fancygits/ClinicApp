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
            this.testOrderedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmboBoxTestID = new System.Windows.Forms.ComboBox();
            this.labTestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAddTest = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.testOrderedDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
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
            lbltTestName.Location = new System.Drawing.Point(3, 30);
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
            this.cmboBoxTestID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmboBoxTestID.FormattingEnabled = true;
            this.cmboBoxTestID.Location = new System.Drawing.Point(65, 28);
            this.cmboBoxTestID.Name = "cmboBoxTestID";
            this.cmboBoxTestID.Size = new System.Drawing.Size(367, 26);
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
            this.btnAddTest.Location = new System.Drawing.Point(314, 65);
            this.btnAddTest.Name = "btnAddTest";
            this.btnAddTest.Size = new System.Drawing.Size(118, 28);
            this.btnAddTest.TabIndex = 4;
            this.btnAddTest.Text = "Add Test";
            this.btnAddTest.UseVisualStyleBackColor = true;
            // 
            // btnOrder
            // 
            this.btnOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.Location = new System.Drawing.Point(314, 334);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(115, 36);
            this.btnOrder.TabIndex = 5;
            this.btnOrder.Text = "Order Tests";
            this.btnOrder.UseVisualStyleBackColor = true;
            // 
            // testOrderedDataGridView
            // 
            this.testOrderedDataGridView.AllowUserToAddRows = false;
            this.testOrderedDataGridView.AllowUserToDeleteRows = false;
            this.testOrderedDataGridView.AutoGenerateColumns = false;
            this.testOrderedDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.testOrderedDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn5,
            this.Column1});
            this.testOrderedDataGridView.DataSource = this.testOrderedBindingSource;
            this.testOrderedDataGridView.Location = new System.Drawing.Point(0, 99);
            this.testOrderedDataGridView.Name = "testOrderedDataGridView";
            this.testOrderedDataGridView.ReadOnly = true;
            this.testOrderedDataGridView.Size = new System.Drawing.Size(449, 220);
            this.testOrderedDataGridView.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn3.HeaderText = "Name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Date";
            this.dataGridViewTextBoxColumn4.HeaderText = "Date";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Result";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Result";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            this.dataGridViewCheckBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ResultDetail";
            this.dataGridViewTextBoxColumn5.HeaderText = "Detail";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 75;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Text = "View/Edit";
            // 
            // OrderLabTestUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.testOrderedDataGridView);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.btnAddTest);
            this.Controls.Add(lbltTestName);
            this.Controls.Add(this.cmboBoxTestID);
            this.Name = "OrderLabTestUserControl";
            this.Size = new System.Drawing.Size(452, 377);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
    }
}
