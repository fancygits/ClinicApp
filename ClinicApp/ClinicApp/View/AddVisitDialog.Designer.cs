namespace ClinicApp.View
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
            this.addVisitUserControl1 = new ClinicApp.UserControls.AddVisitUserControl();
            this.SuspendLayout();
            // 
            // addVisitUserControl1
            // 
            this.addVisitUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addVisitUserControl1.Location = new System.Drawing.Point(0, 0);
            this.addVisitUserControl1.Margin = new System.Windows.Forms.Padding(4);
            this.addVisitUserControl1.Name = "addVisitUserControl1";
            this.addVisitUserControl1.Size = new System.Drawing.Size(1532, 762);
            this.addVisitUserControl1.TabIndex = 0;
            // 
            // AddVisitDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1532, 762);
            this.ControlBox = false;
            this.Controls.Add(this.addVisitUserControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddVisitDialog";
            this.Text = "AddVisitDialog";
            this.ResumeLayout(false);

        }

        #endregion

        public UserControls.AddVisitUserControl addVisitUserControl1;
    }
}