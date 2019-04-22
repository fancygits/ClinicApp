namespace ClinicApp.View
{
    partial class AdministratorDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdministratorDashboard));
            this.lblUsername = new System.Windows.Forms.Label();
            this.credentialsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.logoutLinkLabel = new System.Windows.Forms.LinkLabel();
            this.lblRole = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.nurseInformationTabPage = new System.Windows.Forms.TabPage();
            this.nurseInformationUserControl1 = new ClinicApp.UserControls.NurseInformationUserControl();
            this.labTestReportTabPage = new System.Windows.Forms.TabPage();
            this.labTestReportUserControl1 = new ClinicApp.UserControls.LabTestReportUserControl();
            this.credentialsTableLayoutPanel.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.nurseInformationTabPage.SuspendLayout();
            this.labTestReportTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(6, 6);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(288, 67);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Username";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // credentialsTableLayoutPanel
            // 
            this.credentialsTableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.credentialsTableLayoutPanel.AutoSize = true;
            this.credentialsTableLayoutPanel.ColumnCount = 3;
            this.credentialsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.credentialsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 220F));
            this.credentialsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.credentialsTableLayoutPanel.Controls.Add(this.logoutLinkLabel, 2, 0);
            this.credentialsTableLayoutPanel.Controls.Add(this.lblUsername, 0, 0);
            this.credentialsTableLayoutPanel.Controls.Add(this.lblRole, 1, 0);
            this.credentialsTableLayoutPanel.Location = new System.Drawing.Point(1000, 0);
            this.credentialsTableLayoutPanel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.credentialsTableLayoutPanel.Name = "credentialsTableLayoutPanel";
            this.credentialsTableLayoutPanel.RowCount = 1;
            this.credentialsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.credentialsTableLayoutPanel.Size = new System.Drawing.Size(660, 79);
            this.credentialsTableLayoutPanel.TabIndex = 1;
            this.credentialsTableLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawLines);
            // 
            // logoutLinkLabel
            // 
            this.logoutLinkLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logoutLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutLinkLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(68)))), ((int)(((byte)(36)))));
            this.logoutLinkLabel.Location = new System.Drawing.Point(526, 6);
            this.logoutLinkLabel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.logoutLinkLabel.Name = "logoutLinkLabel";
            this.logoutLinkLabel.Size = new System.Drawing.Size(128, 67);
            this.logoutLinkLabel.TabIndex = 0;
            this.logoutLinkLabel.TabStop = true;
            this.logoutLinkLabel.Text = "Logout";
            this.logoutLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.logoutLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.logoutLinkLabel_LinkClicked);
            // 
            // lblRole
            // 
            this.lblRole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.Location = new System.Drawing.Point(306, 6);
            this.lblRole.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(208, 67);
            this.lblRole.TabIndex = 2;
            this.lblRole.Text = " Administrator";
            this.lblRole.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.nurseInformationTabPage);
            this.tabControl1.Controls.Add(this.labTestReportTabPage);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(24, 60);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1620, 804);
            this.tabControl1.TabIndex = 2;
            // 
            // nurseInformationTabPage
            // 
            this.nurseInformationTabPage.Controls.Add(this.nurseInformationUserControl1);
            this.nurseInformationTabPage.Location = new System.Drawing.Point(8, 44);
            this.nurseInformationTabPage.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.nurseInformationTabPage.Name = "nurseInformationTabPage";
            this.nurseInformationTabPage.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.nurseInformationTabPage.Size = new System.Drawing.Size(1604, 752);
            this.nurseInformationTabPage.TabIndex = 1;
            this.nurseInformationTabPage.Text = "Nurse Information";
            this.nurseInformationTabPage.UseVisualStyleBackColor = true;
            // 
            // nurseInformationUserControl1
            // 
            this.nurseInformationUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nurseInformationUserControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nurseInformationUserControl1.Location = new System.Drawing.Point(6, 6);
            this.nurseInformationUserControl1.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.nurseInformationUserControl1.Name = "nurseInformationUserControl1";
            this.nurseInformationUserControl1.Size = new System.Drawing.Size(1592, 740);
            this.nurseInformationUserControl1.TabIndex = 0;
            // 
            // labTestReportTabPage
            // 
            this.labTestReportTabPage.Controls.Add(this.labTestReportUserControl1);
            this.labTestReportTabPage.Location = new System.Drawing.Point(8, 44);
            this.labTestReportTabPage.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.labTestReportTabPage.Name = "labTestReportTabPage";
            this.labTestReportTabPage.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.labTestReportTabPage.Size = new System.Drawing.Size(1604, 752);
            this.labTestReportTabPage.TabIndex = 0;
            this.labTestReportTabPage.Text = "Lab Test Report";
            this.labTestReportTabPage.UseVisualStyleBackColor = true;
            // 
            // labTestReportUserControl1
            // 
            this.labTestReportUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labTestReportUserControl1.Location = new System.Drawing.Point(6, 6);
            this.labTestReportUserControl1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.labTestReportUserControl1.Name = "labTestReportUserControl1";
            this.labTestReportUserControl1.Size = new System.Drawing.Size(1592, 740);
            this.labTestReportUserControl1.TabIndex = 0;
            // 
            // AdministratorDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1668, 887);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.credentialsTableLayoutPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MinimumSize = new System.Drawing.Size(1674, 896);
            this.Name = "AdministratorDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrator Dashboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdministratorDashboard_FormClosing);
            this.credentialsTableLayoutPanel.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.nurseInformationTabPage.ResumeLayout(false);
            this.labTestReportTabPage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblUsername;
        public System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.TableLayoutPanel credentialsTableLayoutPanel;
        private System.Windows.Forms.LinkLabel logoutLinkLabel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage labTestReportTabPage;
        private System.Windows.Forms.TabPage nurseInformationTabPage;
        private UserControls.NurseInformationUserControl nurseInformationUserControl1;
        private UserControls.LabTestReportUserControl labTestReportUserControl1;
    }
}