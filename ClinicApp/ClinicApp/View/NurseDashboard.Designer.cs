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
            this.apptTabPage = new System.Windows.Forms.TabPage();
            this.VisitTabPage = new System.Windows.Forms.TabPage();
            this.credentialsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.logoutLinkLabel = new System.Windows.Forms.LinkLabel();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.patientInformationUserControl1 = new ClinicApp.UserControls.PatientInformationUserControl();
            this.addAppointmentUserControl1 = new ClinicApp.UserControls.AddAppointmentUserControl();
            this.searchForVisitUserControl1 = new ClinicApp.UserControls.SearchForVisitUserControl();
            this.patientsTabControl.SuspendLayout();
            this.infoTabPage.SuspendLayout();
            this.apptTabPage.SuspendLayout();
            this.VisitTabPage.SuspendLayout();
            this.credentialsTableLayoutPanel.SuspendLayout();
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
            this.patientsTabControl.Location = new System.Drawing.Point(12, 31);
            this.patientsTabControl.Name = "patientsTabControl";
            this.patientsTabControl.SelectedIndex = 0;
            this.patientsTabControl.Size = new System.Drawing.Size(810, 418);
            this.patientsTabControl.TabIndex = 0;
            // 
            // infoTabPage
            // 
            this.infoTabPage.Controls.Add(this.patientInformationUserControl1);
            this.infoTabPage.Location = new System.Drawing.Point(4, 22);
            this.infoTabPage.Name = "infoTabPage";
            this.infoTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.infoTabPage.Size = new System.Drawing.Size(802, 392);
            this.infoTabPage.TabIndex = 1;
            this.infoTabPage.Text = "Patient Information";
            this.infoTabPage.UseVisualStyleBackColor = true;
            // 
            // apptTabPage
            // 
            this.apptTabPage.Controls.Add(this.addAppointmentUserControl1);
            this.apptTabPage.Location = new System.Drawing.Point(4, 22);
            this.apptTabPage.Name = "apptTabPage";
            this.apptTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.apptTabPage.Size = new System.Drawing.Size(802, 392);
            this.apptTabPage.TabIndex = 0;
            this.apptTabPage.Text = "Patient Appointments";
            this.apptTabPage.UseVisualStyleBackColor = true;
            // 
            // VisitTabPage
            // 
            this.VisitTabPage.Controls.Add(this.searchForVisitUserControl1);
            this.VisitTabPage.Location = new System.Drawing.Point(4, 22);
            this.VisitTabPage.Name = "VisitTabPage";
            this.VisitTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.VisitTabPage.Size = new System.Drawing.Size(802, 392);
            this.VisitTabPage.TabIndex = 2;
            this.VisitTabPage.Text = "Patient Visit";
            this.VisitTabPage.UseVisualStyleBackColor = true;
            // 
            // credentialsTableLayoutPanel
            // 
            this.credentialsTableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.credentialsTableLayoutPanel.AutoSize = true;
            this.credentialsTableLayoutPanel.ColumnCount = 3;
            this.credentialsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.credentialsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.credentialsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.credentialsTableLayoutPanel.Controls.Add(this.logoutLinkLabel, 2, 0);
            this.credentialsTableLayoutPanel.Controls.Add(this.lblUsername, 0, 0);
            this.credentialsTableLayoutPanel.Controls.Add(this.lblRole, 1, 0);
            this.credentialsTableLayoutPanel.Location = new System.Drawing.Point(500, 0);
            this.credentialsTableLayoutPanel.Name = "credentialsTableLayoutPanel";
            this.credentialsTableLayoutPanel.RowCount = 1;
            this.credentialsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.credentialsTableLayoutPanel.Size = new System.Drawing.Size(330, 41);
            this.credentialsTableLayoutPanel.TabIndex = 7;
            this.credentialsTableLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawLines);
            // 
            // logoutLinkLabel
            // 
            this.logoutLinkLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logoutLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutLinkLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(68)))), ((int)(((byte)(36)))));
            this.logoutLinkLabel.Location = new System.Drawing.Point(263, 3);
            this.logoutLinkLabel.Margin = new System.Windows.Forms.Padding(3);
            this.logoutLinkLabel.Name = "logoutLinkLabel";
            this.logoutLinkLabel.Size = new System.Drawing.Size(64, 35);
            this.logoutLinkLabel.TabIndex = 0;
            this.logoutLinkLabel.TabStop = true;
            this.logoutLinkLabel.Text = "Logout";
            this.logoutLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.logoutLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLblLogout_LinkClicked);
            // 
            // lblUsername
            // 
            this.lblUsername.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(3, 3);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(3);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(144, 35);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Username";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblRole
            // 
            this.lblRole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.Location = new System.Drawing.Point(153, 3);
            this.lblRole.Margin = new System.Windows.Forms.Padding(3);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(104, 35);
            this.lblRole.TabIndex = 2;
            this.lblRole.Text = " Nurse";
            this.lblRole.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // patientInformationUserControl1
            // 
            this.patientInformationUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.patientInformationUserControl1.Location = new System.Drawing.Point(3, 3);
            this.patientInformationUserControl1.Margin = new System.Windows.Forms.Padding(6);
            this.patientInformationUserControl1.Name = "patientInformationUserControl1";
            this.patientInformationUserControl1.Size = new System.Drawing.Size(796, 386);
            this.patientInformationUserControl1.TabIndex = 0;
            // 
            // addAppointmentUserControl1
            // 
            this.addAppointmentUserControl1.Location = new System.Drawing.Point(10, 3);
            this.addAppointmentUserControl1.Margin = new System.Windows.Forms.Padding(6);
            this.addAppointmentUserControl1.Name = "addAppointmentUserControl1";
            this.addAppointmentUserControl1.Size = new System.Drawing.Size(792, 392);
            this.addAppointmentUserControl1.TabIndex = 0;
            // 
            // searchForVisitUserControl1
            // 
            this.searchForVisitUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchForVisitUserControl1.Location = new System.Drawing.Point(3, 3);
            this.searchForVisitUserControl1.Margin = new System.Windows.Forms.Padding(1);
            this.searchForVisitUserControl1.Name = "searchForVisitUserControl1";
            this.searchForVisitUserControl1.Size = new System.Drawing.Size(796, 386);
            this.searchForVisitUserControl1.TabIndex = 0;
            // 
            // NurseDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.credentialsTableLayoutPanel);
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
            this.credentialsTableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl patientsTabControl;
        private System.Windows.Forms.TabPage apptTabPage;
        private System.Windows.Forms.TabPage infoTabPage;
        private System.Windows.Forms.TabPage VisitTabPage;
        private UserControls.PatientInformationUserControl patientInformationUserControl1;
        private UserControls.AddAppointmentUserControl addAppointmentUserControl1;
        public UserControls.SearchForVisitUserControl searchForVisitUserControl1;
        private System.Windows.Forms.TableLayoutPanel credentialsTableLayoutPanel;
        private System.Windows.Forms.LinkLabel logoutLinkLabel;
        public System.Windows.Forms.Label lblUsername;
        public System.Windows.Forms.Label lblRole;
    }
}

