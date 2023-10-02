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
            this.changeMasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loggerMasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loggerReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.liveDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masterToolStripMenuItem,
            this.reportToolStripMenuItem,
            this.liveDataToolStripMenuItem});
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
            this.changeMasterToolStripMenuItem,
            this.loggerMasterToolStripMenuItem});
            this.masterToolStripMenuItem.Name = "masterToolStripMenuItem";
            this.masterToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.masterToolStripMenuItem.Text = "Master";
            // 
            // userMasterToolStripMenuItem
            // 
            this.userMasterToolStripMenuItem.Name = "userMasterToolStripMenuItem";
            this.userMasterToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.userMasterToolStripMenuItem.Text = "User Master";
            // 
            // changeMasterToolStripMenuItem
            // 
            this.changeMasterToolStripMenuItem.Name = "changeMasterToolStripMenuItem";
            this.changeMasterToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.changeMasterToolStripMenuItem.Text = "Change Master";
            // 
            // loggerMasterToolStripMenuItem
            // 
            this.loggerMasterToolStripMenuItem.Name = "loggerMasterToolStripMenuItem";
            this.loggerMasterToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.loggerMasterToolStripMenuItem.Text = "Logger Master";
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginReportToolStripMenuItem,
            this.loggerReportToolStripMenuItem});
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
            // liveDataToolStripMenuItem
            // 
            this.liveDataToolStripMenuItem.Name = "liveDataToolStripMenuItem";
            this.liveDataToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.liveDataToolStripMenuItem.Text = "Live Data";
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
        private System.Windows.Forms.ToolStripMenuItem changeMasterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loggerMasterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loggerReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem liveDataToolStripMenuItem;
    }
}