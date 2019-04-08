﻿namespace ClinicApp.UserControls
{
    partial class LabTestInfoUserControl
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
            System.Windows.Forms.Label dateLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label resultLabel;
            System.Windows.Forms.Label resultDetailLabel;
            this.dateTimePickerTestDate = new System.Windows.Forms.DateTimePicker();
            this.txBxTestName = new System.Windows.Forms.TextBox();
            this.ckBxAbnResults = new System.Windows.Forms.CheckBox();
            this.txBxResultDetail = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.testOrderedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            dateLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            resultLabel = new System.Windows.Forms.Label();
            resultDetailLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.testOrderedBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dateLabel.Location = new System.Drawing.Point(14, 96);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(48, 20);
            dateLabel.TabIndex = 1;
            dateLabel.Text = "Date:";
            // 
            // dateTimePickerTestDate
            // 
            this.dateTimePickerTestDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.testOrderedBindingSource, "Date", true));
            this.dateTimePickerTestDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerTestDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerTestDate.Location = new System.Drawing.Point(219, 94);
            this.dateTimePickerTestDate.Name = "dateTimePickerTestDate";
            this.dateTimePickerTestDate.Size = new System.Drawing.Size(100, 26);
            this.dateTimePickerTestDate.TabIndex = 2;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nameLabel.Location = new System.Drawing.Point(14, 56);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(90, 20);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Test Name:";
            // 
            // txBxTestName
            // 
            this.txBxTestName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.testOrderedBindingSource, "Name", true));
            this.txBxTestName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txBxTestName.Location = new System.Drawing.Point(157, 56);
            this.txBxTestName.Name = "txBxTestName";
            this.txBxTestName.Size = new System.Drawing.Size(162, 26);
            this.txBxTestName.TabIndex = 4;
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            resultLabel.Location = new System.Drawing.Point(14, 130);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new System.Drawing.Size(131, 20);
            resultLabel.TabIndex = 5;
            resultLabel.Text = "Abnormal Result:";
            // 
            // ckBxAbnResults
            // 
            this.ckBxAbnResults.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.testOrderedBindingSource, "Result", true));
            this.ckBxAbnResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckBxAbnResults.Location = new System.Drawing.Point(306, 126);
            this.ckBxAbnResults.Name = "ckBxAbnResults";
            this.ckBxAbnResults.Size = new System.Drawing.Size(13, 24);
            this.ckBxAbnResults.TabIndex = 6;
            this.ckBxAbnResults.UseVisualStyleBackColor = true;
            // 
            // resultDetailLabel
            // 
            resultDetailLabel.AutoSize = true;
            resultDetailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            resultDetailLabel.Location = new System.Drawing.Point(14, 167);
            resultDetailLabel.Name = "resultDetailLabel";
            resultDetailLabel.Size = new System.Drawing.Size(104, 20);
            resultDetailLabel.TabIndex = 7;
            resultDetailLabel.Text = "Result Detail:";
            // 
            // txBxResultDetail
            // 
            this.txBxResultDetail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.testOrderedBindingSource, "ResultDetail", true));
            this.txBxResultDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txBxResultDetail.Location = new System.Drawing.Point(157, 161);
            this.txBxResultDetail.Name = "txBxResultDetail";
            this.txBxResultDetail.Size = new System.Drawing.Size(162, 26);
            this.txBxResultDetail.TabIndex = 8;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(185, 209);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(134, 32);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update Test";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(38, 209);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(124, 32);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete Test";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // testOrderedBindingSource
            // 
            this.testOrderedBindingSource.DataSource = typeof(ClinicApp.Model.TestOrdered);
            // 
            // LabTestInfoUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(resultDetailLabel);
            this.Controls.Add(this.txBxResultDetail);
            this.Controls.Add(resultLabel);
            this.Controls.Add(this.ckBxAbnResults);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.txBxTestName);
            this.Controls.Add(dateLabel);
            this.Controls.Add(this.dateTimePickerTestDate);
            this.Name = "LabTestInfoUserControl";
            this.Size = new System.Drawing.Size(338, 259);
            this.Load += new System.EventHandler(this.LabTestInfoUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.testOrderedBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource testOrderedBindingSource;
        private System.Windows.Forms.DateTimePicker dateTimePickerTestDate;
        private System.Windows.Forms.TextBox txBxTestName;
        private System.Windows.Forms.CheckBox ckBxAbnResults;
        private System.Windows.Forms.TextBox txBxResultDetail;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
    }
}