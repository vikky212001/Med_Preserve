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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.p_MenuPanel = new System.Windows.Forms.Panel();
            this.p_Reports = new System.Windows.Forms.Panel();
            this.bt_AuditReport = new System.Windows.Forms.Button();
            this.bt_LoggerReport = new System.Windows.Forms.Button();
            this.bt_LoginReport = new System.Windows.Forms.Button();
            this.bt_Reports = new System.Windows.Forms.Button();
            this.p_DataManagement = new System.Windows.Forms.Panel();
            this.bt_DownloadData = new System.Windows.Forms.Button();
            this.bt_RealTimeData = new System.Windows.Forms.Button();
            this.bt_DataManagement = new System.Windows.Forms.Button();
            this.p_Devices = new System.Windows.Forms.Panel();
            this.bt_LoggerConfig = new System.Windows.Forms.Button();
            this.bt_LoggerMaster = new System.Windows.Forms.Button();
            this.bt_Devices = new System.Windows.Forms.Button();
            this.p_UserManagement = new System.Windows.Forms.Panel();
            this.bt_DeletedUser = new System.Windows.Forms.Button();
            this.bt_ChangePassword = new System.Windows.Forms.Button();
            this.bt_CompanyMaster = new System.Windows.Forms.Button();
            this.bt_UserMaster = new System.Windows.Forms.Button();
            this.bt_UserManagement = new System.Windows.Forms.Button();
            this.med_PreserveDataSet1 = new Med_Preserve.Med_PreserveDataSet();
            this.p_RightPanel = new System.Windows.Forms.Panel();
            this.bt_Close = new System.Windows.Forms.Button();
            this.lb_COM = new System.Windows.Forms.Label();
            this.cmb_COMPort = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.p_MainScreen = new System.Windows.Forms.Panel();
            this.p_Title = new System.Windows.Forms.Panel();
            this.p_MenuPanel.SuspendLayout();
            this.p_Reports.SuspendLayout();
            this.p_DataManagement.SuspendLayout();
            this.p_Devices.SuspendLayout();
            this.p_UserManagement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.med_PreserveDataSet1)).BeginInit();
            this.p_RightPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.White;
            this.statusStrip1.Location = new System.Drawing.Point(0, 727);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(938, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // p_MenuPanel
            // 
            this.p_MenuPanel.AutoScroll = true;
            this.p_MenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(217)))), ((int)(((byte)(85)))));
            this.p_MenuPanel.Controls.Add(this.p_Reports);
            this.p_MenuPanel.Controls.Add(this.bt_Reports);
            this.p_MenuPanel.Controls.Add(this.p_DataManagement);
            this.p_MenuPanel.Controls.Add(this.bt_DataManagement);
            this.p_MenuPanel.Controls.Add(this.p_Devices);
            this.p_MenuPanel.Controls.Add(this.bt_Devices);
            this.p_MenuPanel.Controls.Add(this.p_UserManagement);
            this.p_MenuPanel.Controls.Add(this.bt_UserManagement);
            this.p_MenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.p_MenuPanel.Location = new System.Drawing.Point(0, 0);
            this.p_MenuPanel.Name = "p_MenuPanel";
            this.p_MenuPanel.Size = new System.Drawing.Size(200, 727);
            this.p_MenuPanel.TabIndex = 3;
            // 
            // p_Reports
            // 
            this.p_Reports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.p_Reports.Controls.Add(this.bt_AuditReport);
            this.p_Reports.Controls.Add(this.bt_LoggerReport);
            this.p_Reports.Controls.Add(this.bt_LoginReport);
            this.p_Reports.Dock = System.Windows.Forms.DockStyle.Top;
            this.p_Reports.Location = new System.Drawing.Point(0, 524);
            this.p_Reports.Name = "p_Reports";
            this.p_Reports.Size = new System.Drawing.Size(200, 122);
            this.p_Reports.TabIndex = 10;
            this.p_Reports.Visible = false;
            // 
            // bt_AuditReport
            // 
            this.bt_AuditReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_AuditReport.FlatAppearance.BorderSize = 0;
            this.bt_AuditReport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bt_AuditReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bt_AuditReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_AuditReport.Font = new System.Drawing.Font("Comfortaa", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_AuditReport.Image = global::Med_Preserve.Properties.Resources.Audit_Report;
            this.bt_AuditReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_AuditReport.Location = new System.Drawing.Point(0, 80);
            this.bt_AuditReport.Name = "bt_AuditReport";
            this.bt_AuditReport.Padding = new System.Windows.Forms.Padding(25, 0, 10, 0);
            this.bt_AuditReport.Size = new System.Drawing.Size(200, 40);
            this.bt_AuditReport.TabIndex = 2;
            this.bt_AuditReport.Text = "Audit Report";
            this.bt_AuditReport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_AuditReport.UseVisualStyleBackColor = true;
            // 
            // bt_LoggerReport
            // 
            this.bt_LoggerReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_LoggerReport.FlatAppearance.BorderSize = 0;
            this.bt_LoggerReport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bt_LoggerReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bt_LoggerReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_LoggerReport.Font = new System.Drawing.Font("Comfortaa", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_LoggerReport.Image = global::Med_Preserve.Properties.Resources.Logger_Report;
            this.bt_LoggerReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_LoggerReport.Location = new System.Drawing.Point(0, 40);
            this.bt_LoggerReport.Name = "bt_LoggerReport";
            this.bt_LoggerReport.Padding = new System.Windows.Forms.Padding(25, 0, 10, 0);
            this.bt_LoggerReport.Size = new System.Drawing.Size(200, 40);
            this.bt_LoggerReport.TabIndex = 1;
            this.bt_LoggerReport.Text = "Logger Report";
            this.bt_LoggerReport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_LoggerReport.UseVisualStyleBackColor = true;
            // 
            // bt_LoginReport
            // 
            this.bt_LoginReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_LoginReport.FlatAppearance.BorderSize = 0;
            this.bt_LoginReport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bt_LoginReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bt_LoginReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_LoginReport.Font = new System.Drawing.Font("Comfortaa", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_LoginReport.Image = global::Med_Preserve.Properties.Resources.Login_Report;
            this.bt_LoginReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_LoginReport.Location = new System.Drawing.Point(0, 0);
            this.bt_LoginReport.Name = "bt_LoginReport";
            this.bt_LoginReport.Padding = new System.Windows.Forms.Padding(25, 0, 10, 0);
            this.bt_LoginReport.Size = new System.Drawing.Size(200, 40);
            this.bt_LoginReport.TabIndex = 0;
            this.bt_LoginReport.Text = "Login Report";
            this.bt_LoginReport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_LoginReport.UseVisualStyleBackColor = true;
            // 
            // bt_Reports
            // 
            this.bt_Reports.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_Reports.FlatAppearance.BorderSize = 0;
            this.bt_Reports.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bt_Reports.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bt_Reports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Reports.Font = new System.Drawing.Font("Comfortaa", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Reports.Image = global::Med_Preserve.Properties.Resources.Reports;
            this.bt_Reports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Reports.Location = new System.Drawing.Point(0, 474);
            this.bt_Reports.Name = "bt_Reports";
            this.bt_Reports.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.bt_Reports.Size = new System.Drawing.Size(200, 50);
            this.bt_Reports.TabIndex = 3;
            this.bt_Reports.Text = "Reports";
            this.bt_Reports.UseVisualStyleBackColor = true;
            this.bt_Reports.Visible = false;
            this.bt_Reports.Click += new System.EventHandler(this.bt_Reports_Click);
            // 
            // p_DataManagement
            // 
            this.p_DataManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.p_DataManagement.Controls.Add(this.bt_DownloadData);
            this.p_DataManagement.Controls.Add(this.bt_RealTimeData);
            this.p_DataManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.p_DataManagement.Location = new System.Drawing.Point(0, 393);
            this.p_DataManagement.Name = "p_DataManagement";
            this.p_DataManagement.Size = new System.Drawing.Size(200, 81);
            this.p_DataManagement.TabIndex = 8;
            // 
            // bt_DownloadData
            // 
            this.bt_DownloadData.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_DownloadData.FlatAppearance.BorderSize = 0;
            this.bt_DownloadData.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bt_DownloadData.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bt_DownloadData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_DownloadData.Font = new System.Drawing.Font("Comfortaa", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_DownloadData.Image = global::Med_Preserve.Properties.Resources.Data_Download;
            this.bt_DownloadData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_DownloadData.Location = new System.Drawing.Point(0, 40);
            this.bt_DownloadData.Name = "bt_DownloadData";
            this.bt_DownloadData.Padding = new System.Windows.Forms.Padding(25, 0, 10, 0);
            this.bt_DownloadData.Size = new System.Drawing.Size(200, 40);
            this.bt_DownloadData.TabIndex = 1;
            this.bt_DownloadData.Text = "Download Data";
            this.bt_DownloadData.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_DownloadData.UseVisualStyleBackColor = true;
            this.bt_DownloadData.Visible = false;
            this.bt_DownloadData.Click += new System.EventHandler(this.bt_DownloadData_Click);
            // 
            // bt_RealTimeData
            // 
            this.bt_RealTimeData.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_RealTimeData.FlatAppearance.BorderSize = 0;
            this.bt_RealTimeData.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bt_RealTimeData.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bt_RealTimeData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_RealTimeData.Font = new System.Drawing.Font("Comfortaa", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_RealTimeData.Image = global::Med_Preserve.Properties.Resources.Real_Time_Data;
            this.bt_RealTimeData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_RealTimeData.Location = new System.Drawing.Point(0, 0);
            this.bt_RealTimeData.Name = "bt_RealTimeData";
            this.bt_RealTimeData.Padding = new System.Windows.Forms.Padding(25, 0, 10, 0);
            this.bt_RealTimeData.Size = new System.Drawing.Size(200, 40);
            this.bt_RealTimeData.TabIndex = 0;
            this.bt_RealTimeData.Text = "Real-time Data";
            this.bt_RealTimeData.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_RealTimeData.UseVisualStyleBackColor = true;
            this.bt_RealTimeData.Click += new System.EventHandler(this.bt_RealTimeData_Click);
            // 
            // bt_DataManagement
            // 
            this.bt_DataManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_DataManagement.FlatAppearance.BorderSize = 0;
            this.bt_DataManagement.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bt_DataManagement.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bt_DataManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_DataManagement.Font = new System.Drawing.Font("Comfortaa", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_DataManagement.Image = global::Med_Preserve.Properties.Resources.Data_Management;
            this.bt_DataManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_DataManagement.Location = new System.Drawing.Point(0, 343);
            this.bt_DataManagement.Name = "bt_DataManagement";
            this.bt_DataManagement.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.bt_DataManagement.Size = new System.Drawing.Size(200, 50);
            this.bt_DataManagement.TabIndex = 2;
            this.bt_DataManagement.Text = "Data Management";
            this.bt_DataManagement.UseVisualStyleBackColor = true;
            this.bt_DataManagement.Click += new System.EventHandler(this.bt_DataManagement_Click);
            // 
            // p_Devices
            // 
            this.p_Devices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.p_Devices.Controls.Add(this.bt_LoggerConfig);
            this.p_Devices.Controls.Add(this.bt_LoggerMaster);
            this.p_Devices.Dock = System.Windows.Forms.DockStyle.Top;
            this.p_Devices.Location = new System.Drawing.Point(0, 261);
            this.p_Devices.Name = "p_Devices";
            this.p_Devices.Size = new System.Drawing.Size(200, 82);
            this.p_Devices.TabIndex = 6;
            // 
            // bt_LoggerConfig
            // 
            this.bt_LoggerConfig.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_LoggerConfig.FlatAppearance.BorderSize = 0;
            this.bt_LoggerConfig.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bt_LoggerConfig.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bt_LoggerConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_LoggerConfig.Font = new System.Drawing.Font("Comfortaa", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_LoggerConfig.Image = global::Med_Preserve.Properties.Resources.Logger_Config;
            this.bt_LoggerConfig.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_LoggerConfig.Location = new System.Drawing.Point(0, 40);
            this.bt_LoggerConfig.Name = "bt_LoggerConfig";
            this.bt_LoggerConfig.Padding = new System.Windows.Forms.Padding(25, 0, 10, 0);
            this.bt_LoggerConfig.Size = new System.Drawing.Size(200, 40);
            this.bt_LoggerConfig.TabIndex = 1;
            this.bt_LoggerConfig.Text = "Logger Config";
            this.bt_LoggerConfig.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_LoggerConfig.UseVisualStyleBackColor = true;
            this.bt_LoggerConfig.Click += new System.EventHandler(this.bt_LoggerConfig_Click);
            // 
            // bt_LoggerMaster
            // 
            this.bt_LoggerMaster.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_LoggerMaster.FlatAppearance.BorderSize = 0;
            this.bt_LoggerMaster.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bt_LoggerMaster.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bt_LoggerMaster.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_LoggerMaster.Font = new System.Drawing.Font("Comfortaa", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_LoggerMaster.Image = global::Med_Preserve.Properties.Resources.Logger_Master;
            this.bt_LoggerMaster.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_LoggerMaster.Location = new System.Drawing.Point(0, 0);
            this.bt_LoggerMaster.Name = "bt_LoggerMaster";
            this.bt_LoggerMaster.Padding = new System.Windows.Forms.Padding(25, 0, 10, 0);
            this.bt_LoggerMaster.Size = new System.Drawing.Size(200, 40);
            this.bt_LoggerMaster.TabIndex = 0;
            this.bt_LoggerMaster.Text = "Logger Master";
            this.bt_LoggerMaster.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_LoggerMaster.UseVisualStyleBackColor = true;
            this.bt_LoggerMaster.Click += new System.EventHandler(this.bt_LoggerMaster_Click);
            // 
            // bt_Devices
            // 
            this.bt_Devices.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_Devices.FlatAppearance.BorderSize = 0;
            this.bt_Devices.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bt_Devices.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bt_Devices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Devices.Font = new System.Drawing.Font("Comfortaa", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Devices.Image = global::Med_Preserve.Properties.Resources.Device_Management;
            this.bt_Devices.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Devices.Location = new System.Drawing.Point(0, 211);
            this.bt_Devices.Name = "bt_Devices";
            this.bt_Devices.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.bt_Devices.Size = new System.Drawing.Size(200, 50);
            this.bt_Devices.TabIndex = 1;
            this.bt_Devices.Text = "Devices Management";
            this.bt_Devices.UseVisualStyleBackColor = true;
            this.bt_Devices.Click += new System.EventHandler(this.bt_Devices_Click);
            // 
            // p_UserManagement
            // 
            this.p_UserManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.p_UserManagement.Controls.Add(this.bt_DeletedUser);
            this.p_UserManagement.Controls.Add(this.bt_ChangePassword);
            this.p_UserManagement.Controls.Add(this.bt_CompanyMaster);
            this.p_UserManagement.Controls.Add(this.bt_UserMaster);
            this.p_UserManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.p_UserManagement.Location = new System.Drawing.Point(0, 50);
            this.p_UserManagement.Name = "p_UserManagement";
            this.p_UserManagement.Size = new System.Drawing.Size(200, 161);
            this.p_UserManagement.TabIndex = 4;
            // 
            // bt_DeletedUser
            // 
            this.bt_DeletedUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_DeletedUser.FlatAppearance.BorderSize = 0;
            this.bt_DeletedUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bt_DeletedUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bt_DeletedUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_DeletedUser.Font = new System.Drawing.Font("Comfortaa", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_DeletedUser.Image = global::Med_Preserve.Properties.Resources.delete_user;
            this.bt_DeletedUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_DeletedUser.Location = new System.Drawing.Point(0, 120);
            this.bt_DeletedUser.Name = "bt_DeletedUser";
            this.bt_DeletedUser.Padding = new System.Windows.Forms.Padding(20, 0, 10, 0);
            this.bt_DeletedUser.Size = new System.Drawing.Size(200, 40);
            this.bt_DeletedUser.TabIndex = 3;
            this.bt_DeletedUser.Text = "Deleted User";
            this.bt_DeletedUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_DeletedUser.UseVisualStyleBackColor = true;
            this.bt_DeletedUser.Click += new System.EventHandler(this.bt_DeletedUser_Click);
            // 
            // bt_ChangePassword
            // 
            this.bt_ChangePassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_ChangePassword.FlatAppearance.BorderSize = 0;
            this.bt_ChangePassword.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bt_ChangePassword.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bt_ChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_ChangePassword.Font = new System.Drawing.Font("Comfortaa", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_ChangePassword.Image = global::Med_Preserve.Properties.Resources.Change_Password;
            this.bt_ChangePassword.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_ChangePassword.Location = new System.Drawing.Point(0, 80);
            this.bt_ChangePassword.Name = "bt_ChangePassword";
            this.bt_ChangePassword.Padding = new System.Windows.Forms.Padding(20, 0, 10, 0);
            this.bt_ChangePassword.Size = new System.Drawing.Size(200, 40);
            this.bt_ChangePassword.TabIndex = 2;
            this.bt_ChangePassword.Text = "Change Password";
            this.bt_ChangePassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_ChangePassword.UseVisualStyleBackColor = true;
            this.bt_ChangePassword.Click += new System.EventHandler(this.bt_ChangePassword_Click);
            // 
            // bt_CompanyMaster
            // 
            this.bt_CompanyMaster.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_CompanyMaster.FlatAppearance.BorderSize = 0;
            this.bt_CompanyMaster.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bt_CompanyMaster.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bt_CompanyMaster.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_CompanyMaster.Font = new System.Drawing.Font("Comfortaa", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_CompanyMaster.Image = global::Med_Preserve.Properties.Resources.Company_Master;
            this.bt_CompanyMaster.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_CompanyMaster.Location = new System.Drawing.Point(0, 40);
            this.bt_CompanyMaster.Name = "bt_CompanyMaster";
            this.bt_CompanyMaster.Padding = new System.Windows.Forms.Padding(20, 0, 10, 0);
            this.bt_CompanyMaster.Size = new System.Drawing.Size(200, 40);
            this.bt_CompanyMaster.TabIndex = 1;
            this.bt_CompanyMaster.Text = "Company Master";
            this.bt_CompanyMaster.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_CompanyMaster.UseVisualStyleBackColor = true;
            this.bt_CompanyMaster.Click += new System.EventHandler(this.bt_CompanyMaster_Click);
            // 
            // bt_UserMaster
            // 
            this.bt_UserMaster.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_UserMaster.FlatAppearance.BorderSize = 0;
            this.bt_UserMaster.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bt_UserMaster.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bt_UserMaster.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_UserMaster.Font = new System.Drawing.Font("Comfortaa", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_UserMaster.Image = global::Med_Preserve.Properties.Resources.User_Master;
            this.bt_UserMaster.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_UserMaster.Location = new System.Drawing.Point(0, 0);
            this.bt_UserMaster.Name = "bt_UserMaster";
            this.bt_UserMaster.Padding = new System.Windows.Forms.Padding(20, 0, 10, 0);
            this.bt_UserMaster.Size = new System.Drawing.Size(200, 40);
            this.bt_UserMaster.TabIndex = 0;
            this.bt_UserMaster.Text = "User Master";
            this.bt_UserMaster.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_UserMaster.UseVisualStyleBackColor = true;
            this.bt_UserMaster.Click += new System.EventHandler(this.bt_UserMaster_Click);
            // 
            // bt_UserManagement
            // 
            this.bt_UserManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_UserManagement.FlatAppearance.BorderSize = 0;
            this.bt_UserManagement.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bt_UserManagement.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bt_UserManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_UserManagement.Font = new System.Drawing.Font("Comfortaa", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_UserManagement.Image = global::Med_Preserve.Properties.Resources.User_Management;
            this.bt_UserManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_UserManagement.Location = new System.Drawing.Point(0, 0);
            this.bt_UserManagement.Name = "bt_UserManagement";
            this.bt_UserManagement.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.bt_UserManagement.Size = new System.Drawing.Size(200, 50);
            this.bt_UserManagement.TabIndex = 0;
            this.bt_UserManagement.Text = "User Management";
            this.bt_UserManagement.UseVisualStyleBackColor = true;
            this.bt_UserManagement.Click += new System.EventHandler(this.bt_UserManagement_Click);
            // 
            // med_PreserveDataSet1
            // 
            this.med_PreserveDataSet1.DataSetName = "Med_PreserveDataSet";
            this.med_PreserveDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // p_RightPanel
            // 
            this.p_RightPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.p_RightPanel.Controls.Add(this.bt_Close);
            this.p_RightPanel.Controls.Add(this.lb_COM);
            this.p_RightPanel.Controls.Add(this.cmb_COMPort);
            this.p_RightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.p_RightPanel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.p_RightPanel.Location = new System.Drawing.Point(738, 0);
            this.p_RightPanel.Name = "p_RightPanel";
            this.p_RightPanel.Size = new System.Drawing.Size(200, 727);
            this.p_RightPanel.TabIndex = 4;
            // 
            // bt_Close
            // 
            this.bt_Close.BackColor = System.Drawing.Color.Transparent;
            this.bt_Close.FlatAppearance.BorderSize = 0;
            this.bt_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Close.ForeColor = System.Drawing.Color.Black;
            this.bt_Close.Location = new System.Drawing.Point(175, 0);
            this.bt_Close.Name = "bt_Close";
            this.bt_Close.Size = new System.Drawing.Size(25, 27);
            this.bt_Close.TabIndex = 0;
            this.bt_Close.Text = "X";
            this.bt_Close.UseVisualStyleBackColor = false;
            this.bt_Close.Click += new System.EventHandler(this.bt_Close_Click);
            // 
            // lb_COM
            // 
            this.lb_COM.AutoSize = true;
            this.lb_COM.Font = new System.Drawing.Font("Comfortaa", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_COM.Location = new System.Drawing.Point(67, 48);
            this.lb_COM.Name = "lb_COM";
            this.lb_COM.Size = new System.Drawing.Size(103, 18);
            this.lb_COM.TabIndex = 1;
            this.lb_COM.Text = "Select COM Port";
            // 
            // cmb_COMPort
            // 
            this.cmb_COMPort.FormattingEnabled = true;
            this.cmb_COMPort.Location = new System.Drawing.Point(56, 67);
            this.cmb_COMPort.Name = "cmb_COMPort";
            this.cmb_COMPort.Size = new System.Drawing.Size(121, 21);
            this.cmb_COMPort.TabIndex = 0;
            // 
            // p_MainScreen
            // 
            this.p_MainScreen.BackColor = System.Drawing.Color.White;
            this.p_MainScreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.p_MainScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p_MainScreen.Location = new System.Drawing.Point(200, 90);
            this.p_MainScreen.Name = "p_MainScreen";
            this.p_MainScreen.Size = new System.Drawing.Size(538, 637);
            this.p_MainScreen.TabIndex = 6;
            // 
            // p_Title
            // 
            this.p_Title.BackColor = System.Drawing.Color.White;
            this.p_Title.BackgroundImage = global::Med_Preserve.Properties.Resources.Banner;
            this.p_Title.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.p_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.p_Title.Location = new System.Drawing.Point(200, 0);
            this.p_Title.Name = "p_Title";
            this.p_Title.Size = new System.Drawing.Size(538, 90);
            this.p_Title.TabIndex = 5;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 749);
            this.Controls.Add(this.p_MainScreen);
            this.Controls.Add(this.p_Title);
            this.Controls.Add(this.p_RightPanel);
            this.Controls.Add(this.p_MenuPanel);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Home_Load);
            this.p_MenuPanel.ResumeLayout(false);
            this.p_Reports.ResumeLayout(false);
            this.p_DataManagement.ResumeLayout(false);
            this.p_Devices.ResumeLayout(false);
            this.p_UserManagement.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.med_PreserveDataSet1)).EndInit();
            this.p_RightPanel.ResumeLayout(false);
            this.p_RightPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel p_MenuPanel;
        private Med_PreserveDataSet med_PreserveDataSet1;
        private System.Windows.Forms.Button bt_UserManagement;
        private System.Windows.Forms.Panel p_UserManagement;
        private System.Windows.Forms.Button bt_UserMaster;
        private System.Windows.Forms.Button bt_CompanyMaster;
        private System.Windows.Forms.Panel p_DataManagement;
        private System.Windows.Forms.Button bt_DownloadData;
        private System.Windows.Forms.Button bt_RealTimeData;
        private System.Windows.Forms.Button bt_DataManagement;
        private System.Windows.Forms.Panel p_Devices;
        private System.Windows.Forms.Button bt_LoggerConfig;
        private System.Windows.Forms.Button bt_LoggerMaster;
        private System.Windows.Forms.Button bt_Devices;
        private System.Windows.Forms.Button bt_ChangePassword;
        private System.Windows.Forms.Panel p_Reports;
        private System.Windows.Forms.Button bt_LoggerReport;
        private System.Windows.Forms.Button bt_LoginReport;
        private System.Windows.Forms.Button bt_Reports;
        private System.Windows.Forms.Button bt_AuditReport;
        private System.Windows.Forms.Panel p_RightPanel;
        private System.Windows.Forms.Panel p_Title;
        private System.Windows.Forms.Label lb_COM;
        private System.Windows.Forms.ComboBox cmb_COMPort;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Panel p_MainScreen;
        private System.Windows.Forms.Button bt_DeletedUser;
        private System.Windows.Forms.Button bt_Close;
    }
}