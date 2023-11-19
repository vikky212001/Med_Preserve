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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.p_MenuPanel = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.bt_AuditReport = new System.Windows.Forms.Button();
            this.bt_LoggerReport = new System.Windows.Forms.Button();
            this.bt_LoginReport = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.bt_Devices = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_ChangePassword = new System.Windows.Forms.Button();
            this.bt_CompanyMaster = new System.Windows.Forms.Button();
            this.bt_UserMaster = new System.Windows.Forms.Button();
            this.bt_UserManagement = new System.Windows.Forms.Button();
            this.med_PreserveDataSet1 = new Med_Preserve.Med_PreserveDataSet();
            this.p_RightPanel = new System.Windows.Forms.Panel();
            this.p_Title = new System.Windows.Forms.Panel();
            this.p_MainScreen = new System.Windows.Forms.Panel();
            this.lb_Title = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.p_MenuPanel.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.med_PreserveDataSet1)).BeginInit();
            this.p_Title.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(938, 24);
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
            this.loggerMasterToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.loggerMasterToolStripMenuItem.Text = "Logger Master";
            this.loggerMasterToolStripMenuItem.Click += new System.EventHandler(this.loggerMasterToolStripMenuItem_Click);
            // 
            // loggerConfigToolStripMenuItem
            // 
            this.loggerConfigToolStripMenuItem.Name = "loggerConfigToolStripMenuItem";
            this.loggerConfigToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
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
            this.liveReadingToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.liveReadingToolStripMenuItem.Text = "Live Reading";
            this.liveReadingToolStripMenuItem.Click += new System.EventHandler(this.liveReadingToolStripMenuItem_Click);
            // 
            // doenloadDataToolStripMenuItem
            // 
            this.doenloadDataToolStripMenuItem.Name = "doenloadDataToolStripMenuItem";
            this.doenloadDataToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
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
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 683);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(938, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // p_MenuPanel
            // 
            this.p_MenuPanel.AutoScroll = true;
            this.p_MenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(217)))), ((int)(((byte)(85)))));
            this.p_MenuPanel.Controls.Add(this.panel4);
            this.p_MenuPanel.Controls.Add(this.button3);
            this.p_MenuPanel.Controls.Add(this.panel3);
            this.p_MenuPanel.Controls.Add(this.button10);
            this.p_MenuPanel.Controls.Add(this.panel2);
            this.p_MenuPanel.Controls.Add(this.bt_Devices);
            this.p_MenuPanel.Controls.Add(this.panel1);
            this.p_MenuPanel.Controls.Add(this.bt_UserManagement);
            this.p_MenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.p_MenuPanel.Location = new System.Drawing.Point(0, 24);
            this.p_MenuPanel.Name = "p_MenuPanel";
            this.p_MenuPanel.Size = new System.Drawing.Size(200, 659);
            this.p_MenuPanel.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel4.Controls.Add(this.bt_AuditReport);
            this.panel4.Controls.Add(this.bt_LoggerReport);
            this.panel4.Controls.Add(this.bt_LoginReport);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 492);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 122);
            this.panel4.TabIndex = 10;
            // 
            // bt_AuditReport
            // 
            this.bt_AuditReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_AuditReport.FlatAppearance.BorderSize = 0;
            this.bt_AuditReport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bt_AuditReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bt_AuditReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_AuditReport.Image = global::Med_Preserve.Properties.Resources.Audit_Report;
            this.bt_AuditReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_AuditReport.Location = new System.Drawing.Point(0, 80);
            this.bt_AuditReport.Name = "bt_AuditReport";
            this.bt_AuditReport.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.bt_AuditReport.Size = new System.Drawing.Size(200, 40);
            this.bt_AuditReport.TabIndex = 6;
            this.bt_AuditReport.Text = "Audit Report";
            this.bt_AuditReport.UseVisualStyleBackColor = true;
            // 
            // bt_LoggerReport
            // 
            this.bt_LoggerReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_LoggerReport.FlatAppearance.BorderSize = 0;
            this.bt_LoggerReport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bt_LoggerReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bt_LoggerReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_LoggerReport.Image = global::Med_Preserve.Properties.Resources.Logger_Report;
            this.bt_LoggerReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_LoggerReport.Location = new System.Drawing.Point(0, 40);
            this.bt_LoggerReport.Name = "bt_LoggerReport";
            this.bt_LoggerReport.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.bt_LoggerReport.Size = new System.Drawing.Size(200, 40);
            this.bt_LoggerReport.TabIndex = 5;
            this.bt_LoggerReport.Text = "Logger Report";
            this.bt_LoggerReport.UseVisualStyleBackColor = true;
            // 
            // bt_LoginReport
            // 
            this.bt_LoginReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_LoginReport.FlatAppearance.BorderSize = 0;
            this.bt_LoginReport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bt_LoginReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bt_LoginReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_LoginReport.Image = global::Med_Preserve.Properties.Resources.Login_Report;
            this.bt_LoginReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_LoginReport.Location = new System.Drawing.Point(0, 0);
            this.bt_LoginReport.Name = "bt_LoginReport";
            this.bt_LoginReport.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.bt_LoginReport.Size = new System.Drawing.Size(200, 40);
            this.bt_LoginReport.TabIndex = 4;
            this.bt_LoginReport.Text = "Login Report";
            this.bt_LoginReport.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = global::Med_Preserve.Properties.Resources.Reports;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(0, 442);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(200, 50);
            this.button3.TabIndex = 9;
            this.button3.Text = "Reports";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel3.Controls.Add(this.button8);
            this.panel3.Controls.Add(this.button9);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 361);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 81);
            this.panel3.TabIndex = 8;
            // 
            // button8
            // 
            this.button8.Dock = System.Windows.Forms.DockStyle.Top;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Image = global::Med_Preserve.Properties.Resources.Data_Download;
            this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.Location = new System.Drawing.Point(0, 40);
            this.button8.Name = "button8";
            this.button8.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button8.Size = new System.Drawing.Size(200, 40);
            this.button8.TabIndex = 5;
            this.button8.Text = "Download Data";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Dock = System.Windows.Forms.DockStyle.Top;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Image = global::Med_Preserve.Properties.Resources.Real_Time_Data;
            this.button9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.Location = new System.Drawing.Point(0, 0);
            this.button9.Name = "button9";
            this.button9.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button9.Size = new System.Drawing.Size(200, 40);
            this.button9.TabIndex = 4;
            this.button9.Text = "Real-time Data";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Dock = System.Windows.Forms.DockStyle.Top;
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Image = global::Med_Preserve.Properties.Resources.Data_Management;
            this.button10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button10.Location = new System.Drawing.Point(0, 311);
            this.button10.Name = "button10";
            this.button10.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.button10.Size = new System.Drawing.Size(200, 50);
            this.button10.TabIndex = 7;
            this.button10.Text = "Data Management";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 229);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 82);
            this.panel2.TabIndex = 6;
            // 
            // button7
            // 
            this.button7.Dock = System.Windows.Forms.DockStyle.Top;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Image = global::Med_Preserve.Properties.Resources.Logger_Config;
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(0, 40);
            this.button7.Name = "button7";
            this.button7.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button7.Size = new System.Drawing.Size(200, 40);
            this.button7.TabIndex = 5;
            this.button7.Text = "Logger Config";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Dock = System.Windows.Forms.DockStyle.Top;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Image = global::Med_Preserve.Properties.Resources.Logger_Master;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(0, 0);
            this.button6.Name = "button6";
            this.button6.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button6.Size = new System.Drawing.Size(200, 40);
            this.button6.TabIndex = 4;
            this.button6.Text = "Logger Master";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // bt_Devices
            // 
            this.bt_Devices.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_Devices.FlatAppearance.BorderSize = 0;
            this.bt_Devices.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bt_Devices.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bt_Devices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Devices.Image = global::Med_Preserve.Properties.Resources.Device_Management;
            this.bt_Devices.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Devices.Location = new System.Drawing.Point(0, 179);
            this.bt_Devices.Name = "bt_Devices";
            this.bt_Devices.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.bt_Devices.Size = new System.Drawing.Size(200, 50);
            this.bt_Devices.TabIndex = 5;
            this.bt_Devices.Text = "Devices Management";
            this.bt_Devices.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.bt_ChangePassword);
            this.panel1.Controls.Add(this.bt_CompanyMaster);
            this.panel1.Controls.Add(this.bt_UserMaster);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 129);
            this.panel1.TabIndex = 4;
            // 
            // bt_ChangePassword
            // 
            this.bt_ChangePassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_ChangePassword.FlatAppearance.BorderSize = 0;
            this.bt_ChangePassword.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bt_ChangePassword.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bt_ChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_ChangePassword.Image = global::Med_Preserve.Properties.Resources.Change_Password;
            this.bt_ChangePassword.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_ChangePassword.Location = new System.Drawing.Point(0, 80);
            this.bt_ChangePassword.Name = "bt_ChangePassword";
            this.bt_ChangePassword.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.bt_ChangePassword.Size = new System.Drawing.Size(200, 40);
            this.bt_ChangePassword.TabIndex = 3;
            this.bt_ChangePassword.Text = "Change Password";
            this.bt_ChangePassword.UseVisualStyleBackColor = true;
            // 
            // bt_CompanyMaster
            // 
            this.bt_CompanyMaster.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_CompanyMaster.FlatAppearance.BorderSize = 0;
            this.bt_CompanyMaster.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bt_CompanyMaster.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bt_CompanyMaster.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_CompanyMaster.Image = global::Med_Preserve.Properties.Resources.Company_Master;
            this.bt_CompanyMaster.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_CompanyMaster.Location = new System.Drawing.Point(0, 40);
            this.bt_CompanyMaster.Name = "bt_CompanyMaster";
            this.bt_CompanyMaster.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.bt_CompanyMaster.Size = new System.Drawing.Size(200, 40);
            this.bt_CompanyMaster.TabIndex = 2;
            this.bt_CompanyMaster.Text = "Company Master";
            this.bt_CompanyMaster.UseVisualStyleBackColor = true;
            // 
            // bt_UserMaster
            // 
            this.bt_UserMaster.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_UserMaster.FlatAppearance.BorderSize = 0;
            this.bt_UserMaster.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bt_UserMaster.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bt_UserMaster.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_UserMaster.Image = global::Med_Preserve.Properties.Resources.User_Master;
            this.bt_UserMaster.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_UserMaster.Location = new System.Drawing.Point(0, 0);
            this.bt_UserMaster.Name = "bt_UserMaster";
            this.bt_UserMaster.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.bt_UserMaster.Size = new System.Drawing.Size(200, 40);
            this.bt_UserMaster.TabIndex = 1;
            this.bt_UserMaster.Text = "User Master";
            this.bt_UserMaster.UseVisualStyleBackColor = true;
            // 
            // bt_UserManagement
            // 
            this.bt_UserManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_UserManagement.FlatAppearance.BorderSize = 0;
            this.bt_UserManagement.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bt_UserManagement.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bt_UserManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_UserManagement.Image = global::Med_Preserve.Properties.Resources.User_Management;
            this.bt_UserManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_UserManagement.Location = new System.Drawing.Point(0, 0);
            this.bt_UserManagement.Name = "bt_UserManagement";
            this.bt_UserManagement.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.bt_UserManagement.Size = new System.Drawing.Size(200, 50);
            this.bt_UserManagement.TabIndex = 0;
            this.bt_UserManagement.Text = "User Management";
            this.bt_UserManagement.UseVisualStyleBackColor = true;
            // 
            // med_PreserveDataSet1
            // 
            this.med_PreserveDataSet1.DataSetName = "Med_PreserveDataSet";
            this.med_PreserveDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // p_RightPanel
            // 
            this.p_RightPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.p_RightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.p_RightPanel.Location = new System.Drawing.Point(738, 24);
            this.p_RightPanel.Name = "p_RightPanel";
            this.p_RightPanel.Size = new System.Drawing.Size(200, 659);
            this.p_RightPanel.TabIndex = 4;
            // 
            // p_Title
            // 
            this.p_Title.BackColor = System.Drawing.Color.White;
            this.p_Title.Controls.Add(this.lb_Title);
            this.p_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.p_Title.Location = new System.Drawing.Point(200, 24);
            this.p_Title.Name = "p_Title";
            this.p_Title.Size = new System.Drawing.Size(538, 100);
            this.p_Title.TabIndex = 5;
            // 
            // p_MainScreen
            // 
            this.p_MainScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p_MainScreen.Location = new System.Drawing.Point(200, 124);
            this.p_MainScreen.Name = "p_MainScreen";
            this.p_MainScreen.Size = new System.Drawing.Size(538, 559);
            this.p_MainScreen.TabIndex = 6;
            // 
            // lb_Title
            // 
            this.lb_Title.AutoSize = true;
            this.lb_Title.Location = new System.Drawing.Point(252, 44);
            this.lb_Title.Name = "lb_Title";
            this.lb_Title.Size = new System.Drawing.Size(0, 13);
            this.lb_Title.TabIndex = 0;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 705);
            this.Controls.Add(this.p_MainScreen);
            this.Controls.Add(this.p_Title);
            this.Controls.Add(this.p_RightPanel);
            this.Controls.Add(this.p_MenuPanel);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Home";
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Home_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.p_MenuPanel.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.med_PreserveDataSet1)).EndInit();
            this.p_Title.ResumeLayout(false);
            this.p_Title.PerformLayout();
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
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel p_MenuPanel;
        private Med_PreserveDataSet med_PreserveDataSet1;
        private System.Windows.Forms.Button bt_UserManagement;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bt_UserMaster;
        private System.Windows.Forms.Button bt_CompanyMaster;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button bt_Devices;
        private System.Windows.Forms.Button bt_ChangePassword;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button bt_LoggerReport;
        private System.Windows.Forms.Button bt_LoginReport;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button bt_AuditReport;
        private System.Windows.Forms.Panel p_RightPanel;
        private System.Windows.Forms.Panel p_Title;
        private System.Windows.Forms.Panel p_MainScreen;
        private System.Windows.Forms.Label lb_Title;
    }
}