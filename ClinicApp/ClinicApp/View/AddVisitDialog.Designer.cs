﻿namespace ClinicApp.View
{
    partial class AddVisitDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddVisitDialog));
            this.addVisitUserControl1 = new ClinicApp.UserControls.AddVisitUserControl();
            this.SuspendLayout();
            // 
            // addVisitUserControl1
            // 
            this.addVisitUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addVisitUserControl1.Location = new System.Drawing.Point(0, 0);
            this.addVisitUserControl1.Margin = new System.Windows.Forms.Padding(2);
            this.addVisitUserControl1.Name = "addVisitUserControl1";
            this.addVisitUserControl1.Size = new System.Drawing.Size(809, 361);
            this.addVisitUserControl1.TabIndex = 0;
            // 
            // AddVisitDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 361);
            this.ControlBox = false;
            this.Controls.Add(this.addVisitUserControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddVisitDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Visit";
            this.ResumeLayout(false);

        }

        #endregion

        public UserControls.AddVisitUserControl addVisitUserControl1;
    }
}