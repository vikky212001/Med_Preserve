namespace Med_Preserve.Forms
{
    partial class Home
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.masterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userMasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deletedUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.companyMasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.devicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loggerMasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loggerConfigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.liveDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.liveReadingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doenloadDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loggerReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.auditReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masterToolStripMenuItem,
            this.devicesToolStripMenuItem,
            this.liveDataToolStripMenuItem,
            this.reportToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // masterToolStripMenuItem
            // 
            this.masterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userMasterToolStripMenuItem,
            this.changePasswordToolStripMenuItem,
            this.deletedUserToolStripMenuItem,
            this.companyMasterToolStripMenuItem});
            this.masterToolStripMenuItem.Name = "masterToolStripMenuItem";
            this.masterToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.masterToolStripMenuItem.Text = "Master";
            // 
            // userMasterToolStripMenuItem
            // 
            this.userMasterToolStripMenuItem.Name = "userMasterToolStripMenuItem";
            this.userMasterToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.userMasterToolStripMenuItem.Text = "User Master";
            this.userMasterToolStripMenuItem.Click += new System.EventHandler(this.userMasterToolStripMenuItem_Click);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // deletedUserToolStripMenuItem
            // 
            this.deletedUserToolStripMenuItem.Name = "deletedUserToolStripMenuItem";
            this.deletedUserToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.deletedUserToolStripMenuItem.Text = "Deleted User";
            this.deletedUserToolStripMenuItem.Click += new System.EventHandler(this.deletedUserToolStripMenuItem_Click);
            // 
            // companyMasterToolStripMenuItem
            // 
            this.companyMasterToolStripMenuItem.Name = "companyMasterToolStripMenuItem";
            this.companyMasterToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.companyMasterToolStripMenuItem.Text = "Company Master";
            this.companyMasterToolStripMenuItem.Click += new System.EventHandler(this.companyMasterToolStripMenuItem_Click);
            // 
            // devicesToolStripMenuItem
            // 
            this.devicesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loggerMasterToolStripMenuItem,
            this.loggerConfigToolStripMenuItem});
            this.devicesToolStripMenuItem.Name = "devicesToolStripMenuItem";
            this.devicesToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.devicesToolStripMenuItem.Text = "Devices";
            // 
            // loggerMasterToolStripMenuItem
            // 
            this.loggerMasterToolStripMenuItem.Name = "loggerMasterToolStripMenuItem";
            this.loggerMasterToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loggerMasterToolStripMenuItem.Text = "Logger Master";
            this.loggerMasterToolStripMenuItem.Click += new System.EventHandler(this.loggerMasterToolStripMenuItem_Click);
            // 
            // loggerConfigToolStripMenuItem
            // 
            this.loggerConfigToolStripMenuItem.Name = "loggerConfigToolStripMenuItem";
            this.loggerConfigToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loggerConfigToolStripMenuItem.Text = "Logger Config";
            this.loggerConfigToolStripMenuItem.Click += new System.EventHandler(this.loggerConfigToolStripMenuItem_Click);
            // 
            // liveDataToolStripMenuItem
            // 
            this.liveDataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.liveReadingToolStripMenuItem,
            this.doenloadDataToolStripMenuItem});
            this.liveDataToolStripMenuItem.Name = "liveDataToolStripMenuItem";
            this.liveDataToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.liveDataToolStripMenuItem.Text = "Readings";
            // 
            // liveReadingToolStripMenuItem
            // 
            this.liveReadingToolStripMenuItem.Name = "liveReadingToolStripMenuItem";
            this.liveReadingToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.liveReadingToolStripMenuItem.Text = "Live Reading";
            this.liveReadingToolStripMenuItem.Click += new System.EventHandler(this.liveReadingToolStripMenuItem_Click);
            // 
            // doenloadDataToolStripMenuItem
            // 
            this.doenloadDataToolStripMenuItem.Name = "doenloadDataToolStripMenuItem";
            this.doenloadDataToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.doenloadDataToolStripMenuItem.Text = "Download Data";
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginReportToolStripMenuItem,
            this.loggerReportToolStripMenuItem,
            this.auditReportToolStripMenuItem});
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.reportToolStripMenuItem.Text = "Report";
            // 
            // loginReportToolStripMenuItem
            // 
            this.loginReportToolStripMenuItem.Name = "loginReportToolStripMenuItem";
            this.loginReportToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.loginReportToolStripMenuItem.Text = "Login Report";
            // 
            // loggerReportToolStripMenuItem
            // 
            this.loggerReportToolStripMenuItem.Name = "loggerReportToolStripMenuItem";
            this.loggerReportToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.loggerReportToolStripMenuItem.Text = "Logger Report";
            // 
            // auditReportToolStripMenuItem
            // 
            this.auditReportToolStripMenuItem.Name = "auditReportToolStripMenuItem";
            this.auditReportToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.auditReportToolStripMenuItem.Text = "Audit Report";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem masterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userMasterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loggerReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem liveDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deletedUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem liveReadingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doenloadDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem auditReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem companyMasterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem devicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loggerMasterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loggerConfigToolStripMenuItem;
    }
}