namespace ClinicApp
{
    partial class NurseDashboard
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
            this.patientsTabControl = new System.Windows.Forms.TabControl();
            this.apptTabPage = new System.Windows.Forms.TabPage();
            this.infoTabPage = new System.Windows.Forms.TabPage();
            this.VisitTabPage = new System.Windows.Forms.TabPage();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lnkLblLogout = new System.Windows.Forms.LinkLabel();
            this.lblRoll = new System.Windows.Forms.Label();
            this.lblPlaceholder2 = new System.Windows.Forms.Label();
            this.lblPlaceholder1 = new System.Windows.Forms.Label();
            this.appointmentUserControl1 = new ClinicApp.UserControls.AppointmentUserControl();
            this.patientsTabControl.SuspendLayout();
            this.apptTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // patientsTabControl
            // 
            this.patientsTabControl.Controls.Add(this.apptTabPage);
            this.patientsTabControl.Controls.Add(this.infoTabPage);
            this.patientsTabControl.Controls.Add(this.VisitTabPage);
            this.patientsTabControl.Location = new System.Drawing.Point(1, 33);
            this.patientsTabControl.Name = "patientsTabControl";
            this.patientsTabControl.SelectedIndex = 0;
            this.patientsTabControl.Size = new System.Drawing.Size(810, 418);
            this.patientsTabControl.TabIndex = 0;
            // 
            // apptTabPage
            // 
            this.apptTabPage.Controls.Add(this.appointmentUserControl1);
            this.apptTabPage.Location = new System.Drawing.Point(4, 22);
            this.apptTabPage.Name = "apptTabPage";
            this.apptTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.apptTabPage.Size = new System.Drawing.Size(802, 392);
            this.apptTabPage.TabIndex = 0;
            this.apptTabPage.Text = "Patient Appointments";
            this.apptTabPage.UseVisualStyleBackColor = true;
            // 
            // infoTabPage
            // 
            this.infoTabPage.Location = new System.Drawing.Point(4, 22);
            this.infoTabPage.Name = "infoTabPage";
            this.infoTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.infoTabPage.Size = new System.Drawing.Size(802, 392);
            this.infoTabPage.TabIndex = 1;
            this.infoTabPage.Text = "Patient Information";
            this.infoTabPage.UseVisualStyleBackColor = true;
            // 
            // VisitTabPage
            // 
            this.VisitTabPage.Location = new System.Drawing.Point(4, 22);
            this.VisitTabPage.Name = "VisitTabPage";
            this.VisitTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.VisitTabPage.Size = new System.Drawing.Size(802, 392);
            this.VisitTabPage.TabIndex = 2;
            this.VisitTabPage.Text = "Patient Visit";
            this.VisitTabPage.UseVisualStyleBackColor = true;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(615, 12);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(55, 13);
            this.lblUserName.TabIndex = 1;
            this.lblUserName.Text = "Username";
            // 
            // lnkLblLogout
            // 
            this.lnkLblLogout.AutoSize = true;
            this.lnkLblLogout.Location = new System.Drawing.Point(737, 12);
            this.lnkLblLogout.Name = "lnkLblLogout";
            this.lnkLblLogout.Size = new System.Drawing.Size(40, 13);
            this.lnkLblLogout.TabIndex = 2;
            this.lnkLblLogout.TabStop = true;
            this.lnkLblLogout.Text = "Logout";
            // 
            // lblRoll
            // 
            this.lblRoll.AutoSize = true;
            this.lblRoll.Location = new System.Drawing.Point(691, 12);
            this.lblRoll.Name = "lblRoll";
            this.lblRoll.Size = new System.Drawing.Size(25, 13);
            this.lblRoll.TabIndex = 3;
            this.lblRoll.Text = "Roll";
            // 
            // lblPlaceholder2
            // 
            this.lblPlaceholder2.AutoSize = true;
            this.lblPlaceholder2.Location = new System.Drawing.Point(722, 12);
            this.lblPlaceholder2.Name = "lblPlaceholder2";
            this.lblPlaceholder2.Size = new System.Drawing.Size(9, 13);
            this.lblPlaceholder2.TabIndex = 4;
            this.lblPlaceholder2.Text = "|";
            // 
            // lblPlaceholder1
            // 
            this.lblPlaceholder1.AutoSize = true;
            this.lblPlaceholder1.Location = new System.Drawing.Point(676, 12);
            this.lblPlaceholder1.Name = "lblPlaceholder1";
            this.lblPlaceholder1.Size = new System.Drawing.Size(9, 13);
            this.lblPlaceholder1.TabIndex = 5;
            this.lblPlaceholder1.Text = "|";
            // 
            // appointmentUserControl1
            // 
            this.appointmentUserControl1.Location = new System.Drawing.Point(0, 6);
            this.appointmentUserControl1.Name = "appointmentUserControl1";
            this.appointmentUserControl1.Size = new System.Drawing.Size(793, 377);
            this.appointmentUserControl1.TabIndex = 0;
            // 
            // NurseDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 450);
            this.Controls.Add(this.lblPlaceholder1);
            this.Controls.Add(this.lblPlaceholder2);
            this.Controls.Add(this.lblRoll);
            this.Controls.Add(this.lnkLblLogout);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.patientsTabControl);
            this.Name = "NurseDashboard";
            this.Text = "Nurse Dashboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NurseDashboard_FormClosing);
            this.patientsTabControl.ResumeLayout(false);
            this.apptTabPage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl patientsTabControl;
        private System.Windows.Forms.TabPage apptTabPage;
        private System.Windows.Forms.TabPage infoTabPage;
        private System.Windows.Forms.TabPage VisitTabPage;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.LinkLabel lnkLblLogout;
        private System.Windows.Forms.Label lblRoll;
        private System.Windows.Forms.Label lblPlaceholder2;
        private System.Windows.Forms.Label lblPlaceholder1;
        private UserControls.AppointmentUserControl appointmentUserControl1;
    }
}

