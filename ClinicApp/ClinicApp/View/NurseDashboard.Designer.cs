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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NurseDashboard));
            this.patientsTabControl = new System.Windows.Forms.TabControl();
            this.infoTabPage = new System.Windows.Forms.TabPage();
            this.patientInformationUserControl1 = new ClinicApp.UserControls.PatientInformationUserControl();
            this.apptTabPage = new System.Windows.Forms.TabPage();
            this.addAppointmentUserControl1 = new ClinicApp.UserControls.AddAppointmentUserControl();
            this.VisitTabPage = new System.Windows.Forms.TabPage();
            this.searchForVisitUserControl1 = new ClinicApp.UserControls.SearchForVisitUserControl();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lnkLblLogout = new System.Windows.Forms.LinkLabel();
            this.lblRoll = new System.Windows.Forms.Label();
            this.lblPlaceholder2 = new System.Windows.Forms.Label();
            this.lblPlaceholder1 = new System.Windows.Forms.Label();
            this.patientsTabControl.SuspendLayout();
            this.infoTabPage.SuspendLayout();
            this.apptTabPage.SuspendLayout();
            this.VisitTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // patientsTabControl
            // 
            this.patientsTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.patientsTabControl.Controls.Add(this.infoTabPage);
            this.patientsTabControl.Controls.Add(this.apptTabPage);
            this.patientsTabControl.Controls.Add(this.VisitTabPage);
            this.patientsTabControl.Location = new System.Drawing.Point(12, 28);
            this.patientsTabControl.Name = "patientsTabControl";
            this.patientsTabControl.SelectedIndex = 0;
            this.patientsTabControl.Size = new System.Drawing.Size(810, 421);
            this.patientsTabControl.TabIndex = 0;
            // 
            // infoTabPage
            // 
            this.infoTabPage.Controls.Add(this.patientInformationUserControl1);
            this.infoTabPage.Location = new System.Drawing.Point(4, 22);
            this.infoTabPage.Name = "infoTabPage";
            this.infoTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.infoTabPage.Size = new System.Drawing.Size(802, 395);
            this.infoTabPage.TabIndex = 1;
            this.infoTabPage.Text = "Patient Information";
            this.infoTabPage.UseVisualStyleBackColor = true;
            // 
            // patientInformationUserControl1
            // 
            this.patientInformationUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.patientInformationUserControl1.Location = new System.Drawing.Point(3, 3);
            this.patientInformationUserControl1.Margin = new System.Windows.Forms.Padding(6);
            this.patientInformationUserControl1.Name = "patientInformationUserControl1";
            this.patientInformationUserControl1.Size = new System.Drawing.Size(796, 389);
            this.patientInformationUserControl1.TabIndex = 0;
            // 
            // apptTabPage
            // 
            this.apptTabPage.Controls.Add(this.addAppointmentUserControl1);
            this.apptTabPage.Location = new System.Drawing.Point(4, 22);
            this.apptTabPage.Name = "apptTabPage";
            this.apptTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.apptTabPage.Size = new System.Drawing.Size(802, 395);
            this.apptTabPage.TabIndex = 0;
            this.apptTabPage.Text = "Patient Appointments";
            this.apptTabPage.UseVisualStyleBackColor = true;
            // 
            // addAppointmentUserControl1
            // 
            this.addAppointmentUserControl1.Location = new System.Drawing.Point(10, 3);
            this.addAppointmentUserControl1.Margin = new System.Windows.Forms.Padding(6);
            this.addAppointmentUserControl1.Name = "addAppointmentUserControl1";
            this.addAppointmentUserControl1.Size = new System.Drawing.Size(792, 392);
            this.addAppointmentUserControl1.TabIndex = 0;
            // 
            // VisitTabPage
            // 
            this.VisitTabPage.Controls.Add(this.searchForVisitUserControl1);
            this.VisitTabPage.Location = new System.Drawing.Point(4, 22);
            this.VisitTabPage.Name = "VisitTabPage";
            this.VisitTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.VisitTabPage.Size = new System.Drawing.Size(802, 395);
            this.VisitTabPage.TabIndex = 2;
            this.VisitTabPage.Text = "Patient Visit";
            this.VisitTabPage.UseVisualStyleBackColor = true;
            // 
            // searchForVisitUserControl1
            // 
            this.searchForVisitUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchForVisitUserControl1.Location = new System.Drawing.Point(3, 3);
            this.searchForVisitUserControl1.Margin = new System.Windows.Forms.Padding(1);
            this.searchForVisitUserControl1.Name = "searchForVisitUserControl1";
            this.searchForVisitUserControl1.Size = new System.Drawing.Size(796, 389);
            this.searchForVisitUserControl1.TabIndex = 0;
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
            this.lnkLblLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLblLogout_LinkClicked);
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
            // NurseDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.lblPlaceholder1);
            this.Controls.Add(this.lblPlaceholder2);
            this.Controls.Add(this.lblRoll);
            this.Controls.Add(this.lnkLblLogout);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.patientsTabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(850, 500);
            this.Name = "NurseDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nurse Dashboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NurseDashboard_FormClosing);
            this.patientsTabControl.ResumeLayout(false);
            this.infoTabPage.ResumeLayout(false);
            this.apptTabPage.ResumeLayout(false);
            this.VisitTabPage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl patientsTabControl;
        private System.Windows.Forms.TabPage apptTabPage;
        private System.Windows.Forms.TabPage infoTabPage;
        private System.Windows.Forms.TabPage VisitTabPage;
        private System.Windows.Forms.LinkLabel lnkLblLogout;
        private System.Windows.Forms.Label lblPlaceholder2;
        private System.Windows.Forms.Label lblPlaceholder1;
        private UserControls.PatientInformationUserControl patientInformationUserControl1;
        public System.Windows.Forms.Label lblUserName;
        public System.Windows.Forms.Label lblRoll;
        private UserControls.AddAppointmentUserControl addAppointmentUserControl1;
        public UserControls.SearchForVisitUserControl searchForVisitUserControl1;
    }
}

