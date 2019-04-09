namespace ClinicApp.View
{
    partial class LabTestInfoDialog
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
            this.labTestInfoUserControl1 = new ClinicApp.UserControls.LabTestInfoUserControl();
            this.SuspendLayout();
            // 
            // labTestInfoUserControl1
            // 
            this.labTestInfoUserControl1.Location = new System.Drawing.Point(-3, 1);
            this.labTestInfoUserControl1.Name = "labTestInfoUserControl1";
            this.labTestInfoUserControl1.Size = new System.Drawing.Size(396, 251);
            this.labTestInfoUserControl1.TabIndex = 0;
            // 
            // LabTestInfoDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 255);
            this.Controls.Add(this.labTestInfoUserControl1);
            this.Name = "LabTestInfoDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab Test Info";
            this.ResumeLayout(false);

        }

        #endregion

        public UserControls.LabTestInfoUserControl labTestInfoUserControl1;
    }
}