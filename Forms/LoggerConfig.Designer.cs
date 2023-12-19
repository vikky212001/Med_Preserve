namespace Med_Preserve.Forms
{
    partial class LoggerConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoggerConfig));
            this.tb_TS4_LL = new System.Windows.Forms.TextBox();
            this.tb_TS4_UL = new System.Windows.Forms.TextBox();
            this.tb_TS3_LL = new System.Windows.Forms.TextBox();
            this.tb_TS3_UL = new System.Windows.Forms.TextBox();
            this.tb_TS2_LL = new System.Windows.Forms.TextBox();
            this.tb_TS2_UL = new System.Windows.Forms.TextBox();
            this.tb_TS1_LL = new System.Windows.Forms.TextBox();
            this.tb_TS1_UL = new System.Windows.Forms.TextBox();
            this.tb_S4_Humidity = new System.Windows.Forms.TextBox();
            this.tb_S4_Temp = new System.Windows.Forms.TextBox();
            this.tb_S3_Humidity = new System.Windows.Forms.TextBox();
            this.tb_S3_Temp = new System.Windows.Forms.TextBox();
            this.tb_S2_Humidity = new System.Windows.Forms.TextBox();
            this.tb_S2_Temp = new System.Windows.Forms.TextBox();
            this.tb_S1_Humidity = new System.Windows.Forms.TextBox();
            this.tb_S1_Temp = new System.Windows.Forms.TextBox();
            this.lb_T_LowThreshold = new System.Windows.Forms.Label();
            this.lb_T_UpThreshold = new System.Windows.Forms.Label();
            this.lb_Humidity = new System.Windows.Forms.Label();
            this.lb_Temp = new System.Windows.Forms.Label();
            this.lb_Sensors = new System.Windows.Forms.Label();
            this.lb_Temp_Calibrate = new System.Windows.Forms.Label();
            this.tb_TS1_Calibrate = new System.Windows.Forms.TextBox();
            this.tb_TS2_Calibrate = new System.Windows.Forms.TextBox();
            this.tb_TS3_Calibrate = new System.Windows.Forms.TextBox();
            this.tb_TS4_Calibrate = new System.Windows.Forms.TextBox();
            this.dgv_LoggerConfig = new System.Windows.Forms.DataGridView();
            this.tb_S1_Name = new System.Windows.Forms.TextBox();
            this.tb_S2_Name = new System.Windows.Forms.TextBox();
            this.tb_S3_Name = new System.Windows.Forms.TextBox();
            this.tb_S4_Name = new System.Windows.Forms.TextBox();
            this.lb_LogID = new System.Windows.Forms.Label();
            this.lb_LogType = new System.Windows.Forms.Label();
            this.lb_NoOfSensors = new System.Windows.Forms.Label();
            this.lb_Assign = new System.Windows.Forms.Label();
            this.lb_Interval = new System.Windows.Forms.Label();
            this.tb_LogID = new System.Windows.Forms.TextBox();
            this.tb_NoOfSensors = new System.Windows.Forms.TextBox();
            this.tb_LogType = new System.Windows.Forms.TextBox();
            this.tb_Assign = new System.Windows.Forms.TextBox();
            this.tb_Interval = new System.Windows.Forms.TextBox();
            this.bt_Close = new System.Windows.Forms.Button();
            this.bt_Clear = new System.Windows.Forms.Button();
            this.bt_Delete = new System.Windows.Forms.Button();
            this.bt_Update = new System.Windows.Forms.Button();
            this.bt_Add = new System.Windows.Forms.Button();
            this.lb_LoggerName = new System.Windows.Forms.Label();
            this.cmb_LoggerName = new System.Windows.Forms.ComboBox();
            this.tb_HS4_LL = new System.Windows.Forms.TextBox();
            this.tb_HS4_UL = new System.Windows.Forms.TextBox();
            this.tb_HS3_LL = new System.Windows.Forms.TextBox();
            this.tb_HS3_UL = new System.Windows.Forms.TextBox();
            this.tb_HS2_LL = new System.Windows.Forms.TextBox();
            this.tb_HS2_UL = new System.Windows.Forms.TextBox();
            this.tb_HS1_LL = new System.Windows.Forms.TextBox();
            this.tb_HS1_UL = new System.Windows.Forms.TextBox();
            this.lb_H_LowThreshold = new System.Windows.Forms.Label();
            this.lb_H_UpThreshold = new System.Windows.Forms.Label();
            this.tb_HS4_Calibrate = new System.Windows.Forms.TextBox();
            this.tb_HS3_Calibrate = new System.Windows.Forms.TextBox();
            this.tb_HS2_Calibrate = new System.Windows.Forms.TextBox();
            this.tb_HS1_Calibrate = new System.Windows.Forms.TextBox();
            this.lb_Humi_Calibrate = new System.Windows.Forms.Label();
            this.tb_IsConfig = new System.Windows.Forms.TextBox();
            this.tb_Search = new System.Windows.Forms.TextBox();
            this.lb_Search = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.rb_Celcius = new System.Windows.Forms.RadioButton();
            this.rb_farenheit = new System.Windows.Forms.RadioButton();
            this.gb_Unit = new System.Windows.Forms.GroupBox();
            this.tb_SyncStatus = new System.Windows.Forms.TextBox();
            this.lb_Sync = new System.Windows.Forms.Label();
            this.bt_SyncNow = new System.Windows.Forms.Button();
            this.gb_Calibrate = new System.Windows.Forms.GroupBox();
            this.lb_Cali_gb = new System.Windows.Forms.Label();
            this.gb_HumiLimit = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gb_TempLimit = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gb_SV = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_Title = new System.Windows.Forms.Label();
            this.tb_delay = new System.Windows.Forms.TextBox();
            this.tb_delaytype = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LoggerConfig)).BeginInit();
            this.gb_Unit.SuspendLayout();
            this.gb_Calibrate.SuspendLayout();
            this.gb_HumiLimit.SuspendLayout();
            this.gb_TempLimit.SuspendLayout();
            this.gb_SV.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_TS4_LL
            // 
            this.tb_TS4_LL.Font = new System.Drawing.Font("Comfortaa SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tb_TS4_LL.Location = new System.Drawing.Point(20, 121);
            this.tb_TS4_LL.Name = "tb_TS4_LL";
            this.tb_TS4_LL.Size = new System.Drawing.Size(64, 22);
            this.tb_TS4_LL.TabIndex = 6;
            // 
            // tb_TS4_UL
            // 
            this.tb_TS4_UL.Font = new System.Drawing.Font("Comfortaa SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tb_TS4_UL.Location = new System.Drawing.Point(114, 121);
            this.tb_TS4_UL.Name = "tb_TS4_UL";
            this.tb_TS4_UL.Size = new System.Drawing.Size(64, 22);
            this.tb_TS4_UL.TabIndex = 7;
            // 
            // tb_TS3_LL
            // 
            this.tb_TS3_LL.Font = new System.Drawing.Font("Comfortaa SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tb_TS3_LL.Location = new System.Drawing.Point(20, 95);
            this.tb_TS3_LL.Name = "tb_TS3_LL";
            this.tb_TS3_LL.Size = new System.Drawing.Size(64, 22);
            this.tb_TS3_LL.TabIndex = 4;
            // 
            // tb_TS3_UL
            // 
            this.tb_TS3_UL.Font = new System.Drawing.Font("Comfortaa SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tb_TS3_UL.Location = new System.Drawing.Point(114, 95);
            this.tb_TS3_UL.Name = "tb_TS3_UL";
            this.tb_TS3_UL.Size = new System.Drawing.Size(64, 22);
            this.tb_TS3_UL.TabIndex = 5;
            // 
            // tb_TS2_LL
            // 
            this.tb_TS2_LL.Font = new System.Drawing.Font("Comfortaa SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tb_TS2_LL.Location = new System.Drawing.Point(20, 69);
            this.tb_TS2_LL.Name = "tb_TS2_LL";
            this.tb_TS2_LL.Size = new System.Drawing.Size(64, 22);
            this.tb_TS2_LL.TabIndex = 2;
            // 
            // tb_TS2_UL
            // 
            this.tb_TS2_UL.Font = new System.Drawing.Font("Comfortaa SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tb_TS2_UL.Location = new System.Drawing.Point(114, 69);
            this.tb_TS2_UL.Name = "tb_TS2_UL";
            this.tb_TS2_UL.Size = new System.Drawing.Size(64, 22);
            this.tb_TS2_UL.TabIndex = 3;
            // 
            // tb_TS1_LL
            // 
            this.tb_TS1_LL.Font = new System.Drawing.Font("Comfortaa SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tb_TS1_LL.Location = new System.Drawing.Point(20, 43);
            this.tb_TS1_LL.Name = "tb_TS1_LL";
            this.tb_TS1_LL.Size = new System.Drawing.Size(64, 22);
            this.tb_TS1_LL.TabIndex = 0;
            // 
            // tb_TS1_UL
            // 
            this.tb_TS1_UL.Font = new System.Drawing.Font("Comfortaa SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tb_TS1_UL.Location = new System.Drawing.Point(114, 43);
            this.tb_TS1_UL.Name = "tb_TS1_UL";
            this.tb_TS1_UL.Size = new System.Drawing.Size(64, 22);
            this.tb_TS1_UL.TabIndex = 1;
            // 
            // tb_S4_Humidity
            // 
            this.tb_S4_Humidity.Font = new System.Drawing.Font("Comfortaa SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tb_S4_Humidity.Location = new System.Drawing.Point(119, 121);
            this.tb_S4_Humidity.Name = "tb_S4_Humidity";
            this.tb_S4_Humidity.Size = new System.Drawing.Size(64, 22);
            this.tb_S4_Humidity.TabIndex = 7;
            // 
            // tb_S4_Temp
            // 
            this.tb_S4_Temp.Font = new System.Drawing.Font("Comfortaa SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tb_S4_Temp.Location = new System.Drawing.Point(20, 121);
            this.tb_S4_Temp.Name = "tb_S4_Temp";
            this.tb_S4_Temp.Size = new System.Drawing.Size(64, 22);
            this.tb_S4_Temp.TabIndex = 6;
            // 
            // tb_S3_Humidity
            // 
            this.tb_S3_Humidity.Font = new System.Drawing.Font("Comfortaa SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tb_S3_Humidity.Location = new System.Drawing.Point(119, 95);
            this.tb_S3_Humidity.Name = "tb_S3_Humidity";
            this.tb_S3_Humidity.Size = new System.Drawing.Size(64, 22);
            this.tb_S3_Humidity.TabIndex = 5;
            // 
            // tb_S3_Temp
            // 
            this.tb_S3_Temp.Font = new System.Drawing.Font("Comfortaa SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tb_S3_Temp.Location = new System.Drawing.Point(20, 95);
            this.tb_S3_Temp.Name = "tb_S3_Temp";
            this.tb_S3_Temp.Size = new System.Drawing.Size(64, 22);
            this.tb_S3_Temp.TabIndex = 4;
            // 
            // tb_S2_Humidity
            // 
            this.tb_S2_Humidity.Font = new System.Drawing.Font("Comfortaa SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tb_S2_Humidity.Location = new System.Drawing.Point(119, 69);
            this.tb_S2_Humidity.Name = "tb_S2_Humidity";
            this.tb_S2_Humidity.Size = new System.Drawing.Size(64, 22);
            this.tb_S2_Humidity.TabIndex = 3;
            // 
            // tb_S2_Temp
            // 
            this.tb_S2_Temp.Font = new System.Drawing.Font("Comfortaa SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tb_S2_Temp.Location = new System.Drawing.Point(20, 69);
            this.tb_S2_Temp.Name = "tb_S2_Temp";
            this.tb_S2_Temp.Size = new System.Drawing.Size(64, 22);
            this.tb_S2_Temp.TabIndex = 2;
            // 
            // tb_S1_Humidity
            // 
            this.tb_S1_Humidity.Font = new System.Drawing.Font("Comfortaa SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tb_S1_Humidity.Location = new System.Drawing.Point(119, 43);
            this.tb_S1_Humidity.Name = "tb_S1_Humidity";
            this.tb_S1_Humidity.Size = new System.Drawing.Size(64, 22);
            this.tb_S1_Humidity.TabIndex = 1;
            // 
            // tb_S1_Temp
            // 
            this.tb_S1_Temp.Font = new System.Drawing.Font("Comfortaa SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tb_S1_Temp.Location = new System.Drawing.Point(20, 43);
            this.tb_S1_Temp.Name = "tb_S1_Temp";
            this.tb_S1_Temp.Size = new System.Drawing.Size(64, 22);
            this.tb_S1_Temp.TabIndex = 0;
            // 
            // lb_T_LowThreshold
            // 
            this.lb_T_LowThreshold.AutoSize = true;
            this.lb_T_LowThreshold.Font = new System.Drawing.Font("Comfortaa SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.lb_T_LowThreshold.Location = new System.Drawing.Point(12, 21);
            this.lb_T_LowThreshold.Name = "lb_T_LowThreshold";
            this.lb_T_LowThreshold.Size = new System.Drawing.Size(83, 19);
            this.lb_T_LowThreshold.TabIndex = 48;
            this.lb_T_LowThreshold.Text = "Lower Limit";
            // 
            // lb_T_UpThreshold
            // 
            this.lb_T_UpThreshold.AutoSize = true;
            this.lb_T_UpThreshold.Font = new System.Drawing.Font("Comfortaa SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.lb_T_UpThreshold.Location = new System.Drawing.Point(104, 21);
            this.lb_T_UpThreshold.Name = "lb_T_UpThreshold";
            this.lb_T_UpThreshold.Size = new System.Drawing.Size(84, 19);
            this.lb_T_UpThreshold.TabIndex = 47;
            this.lb_T_UpThreshold.Text = "Upper Limit";
            // 
            // lb_Humidity
            // 
            this.lb_Humidity.AutoSize = true;
            this.lb_Humidity.Font = new System.Drawing.Font("Comfortaa SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.lb_Humidity.Location = new System.Drawing.Point(120, 21);
            this.lb_Humidity.Name = "lb_Humidity";
            this.lb_Humidity.Size = new System.Drawing.Size(66, 19);
            this.lb_Humidity.TabIndex = 45;
            this.lb_Humidity.Text = "Humidity";
            // 
            // lb_Temp
            // 
            this.lb_Temp.AutoSize = true;
            this.lb_Temp.Font = new System.Drawing.Font("Comfortaa SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Temp.Location = new System.Drawing.Point(6, 20);
            this.lb_Temp.Name = "lb_Temp";
            this.lb_Temp.Size = new System.Drawing.Size(95, 21);
            this.lb_Temp.TabIndex = 44;
            this.lb_Temp.Text = "Temperature";
            // 
            // lb_Sensors
            // 
            this.lb_Sensors.AutoSize = true;
            this.lb_Sensors.Font = new System.Drawing.Font("Comfortaa SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.lb_Sensors.Location = new System.Drawing.Point(49, 393);
            this.lb_Sensors.Name = "lb_Sensors";
            this.lb_Sensors.Size = new System.Drawing.Size(58, 19);
            this.lb_Sensors.TabIndex = 66;
            this.lb_Sensors.Text = "Sensors";
            // 
            // lb_Temp_Calibrate
            // 
            this.lb_Temp_Calibrate.AutoSize = true;
            this.lb_Temp_Calibrate.Font = new System.Drawing.Font("Comfortaa SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.lb_Temp_Calibrate.Location = new System.Drawing.Point(6, 22);
            this.lb_Temp_Calibrate.Name = "lb_Temp_Calibrate";
            this.lb_Temp_Calibrate.Size = new System.Drawing.Size(88, 19);
            this.lb_Temp_Calibrate.TabIndex = 67;
            this.lb_Temp_Calibrate.Text = "Temperature";
            // 
            // tb_TS1_Calibrate
            // 
            this.tb_TS1_Calibrate.Font = new System.Drawing.Font("Comfortaa SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tb_TS1_Calibrate.Location = new System.Drawing.Point(25, 43);
            this.tb_TS1_Calibrate.Name = "tb_TS1_Calibrate";
            this.tb_TS1_Calibrate.Size = new System.Drawing.Size(64, 22);
            this.tb_TS1_Calibrate.TabIndex = 0;
            // 
            // tb_TS2_Calibrate
            // 
            this.tb_TS2_Calibrate.Font = new System.Drawing.Font("Comfortaa SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tb_TS2_Calibrate.Location = new System.Drawing.Point(25, 69);
            this.tb_TS2_Calibrate.Name = "tb_TS2_Calibrate";
            this.tb_TS2_Calibrate.Size = new System.Drawing.Size(64, 22);
            this.tb_TS2_Calibrate.TabIndex = 2;
            // 
            // tb_TS3_Calibrate
            // 
            this.tb_TS3_Calibrate.Font = new System.Drawing.Font("Comfortaa SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tb_TS3_Calibrate.Location = new System.Drawing.Point(25, 95);
            this.tb_TS3_Calibrate.Name = "tb_TS3_Calibrate";
            this.tb_TS3_Calibrate.Size = new System.Drawing.Size(64, 22);
            this.tb_TS3_Calibrate.TabIndex = 4;
            // 
            // tb_TS4_Calibrate
            // 
            this.tb_TS4_Calibrate.Font = new System.Drawing.Font("Comfortaa SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tb_TS4_Calibrate.Location = new System.Drawing.Point(25, 121);
            this.tb_TS4_Calibrate.Name = "tb_TS4_Calibrate";
            this.tb_TS4_Calibrate.Size = new System.Drawing.Size(64, 22);
            this.tb_TS4_Calibrate.TabIndex = 6;
            // 
            // dgv_LoggerConfig
            // 
            this.dgv_LoggerConfig.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgv_LoggerConfig.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_LoggerConfig.Location = new System.Drawing.Point(19, 112);
            this.dgv_LoggerConfig.Name = "dgv_LoggerConfig";
            this.dgv_LoggerConfig.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_LoggerConfig.Size = new System.Drawing.Size(929, 173);
            this.dgv_LoggerConfig.TabIndex = 12;
            this.dgv_LoggerConfig.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_LoggerConfig_CellClick);
            // 
            // tb_S1_Name
            // 
            this.tb_S1_Name.Enabled = false;
            this.tb_S1_Name.Font = new System.Drawing.Font("Comfortaa SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tb_S1_Name.Location = new System.Drawing.Point(31, 425);
            this.tb_S1_Name.Name = "tb_S1_Name";
            this.tb_S1_Name.ReadOnly = true;
            this.tb_S1_Name.Size = new System.Drawing.Size(98, 22);
            this.tb_S1_Name.TabIndex = 73;
            // 
            // tb_S2_Name
            // 
            this.tb_S2_Name.Enabled = false;
            this.tb_S2_Name.Font = new System.Drawing.Font("Comfortaa SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tb_S2_Name.Location = new System.Drawing.Point(30, 451);
            this.tb_S2_Name.Name = "tb_S2_Name";
            this.tb_S2_Name.ReadOnly = true;
            this.tb_S2_Name.Size = new System.Drawing.Size(98, 22);
            this.tb_S2_Name.TabIndex = 74;
            // 
            // tb_S3_Name
            // 
            this.tb_S3_Name.Enabled = false;
            this.tb_S3_Name.Font = new System.Drawing.Font("Comfortaa SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tb_S3_Name.Location = new System.Drawing.Point(30, 477);
            this.tb_S3_Name.Name = "tb_S3_Name";
            this.tb_S3_Name.ReadOnly = true;
            this.tb_S3_Name.Size = new System.Drawing.Size(98, 22);
            this.tb_S3_Name.TabIndex = 75;
            // 
            // tb_S4_Name
            // 
            this.tb_S4_Name.Enabled = false;
            this.tb_S4_Name.Font = new System.Drawing.Font("Comfortaa SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tb_S4_Name.Location = new System.Drawing.Point(30, 503);
            this.tb_S4_Name.Name = "tb_S4_Name";
            this.tb_S4_Name.ReadOnly = true;
            this.tb_S4_Name.Size = new System.Drawing.Size(98, 22);
            this.tb_S4_Name.TabIndex = 76;
            // 
            // lb_LogID
            // 
            this.lb_LogID.AutoSize = true;
            this.lb_LogID.Location = new System.Drawing.Point(24, 84);
            this.lb_LogID.Name = "lb_LogID";
            this.lb_LogID.Size = new System.Drawing.Size(54, 13);
            this.lb_LogID.TabIndex = 77;
            this.lb_LogID.Text = "Logger ID";
            this.lb_LogID.Visible = false;
            // 
            // lb_LogType
            // 
            this.lb_LogType.AutoSize = true;
            this.lb_LogType.Font = new System.Drawing.Font("Comfortaa SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.lb_LogType.Location = new System.Drawing.Point(503, 308);
            this.lb_LogType.Name = "lb_LogType";
            this.lb_LogType.Size = new System.Drawing.Size(87, 19);
            this.lb_LogType.TabIndex = 78;
            this.lb_LogType.Text = "Logger Type";
            // 
            // lb_NoOfSensors
            // 
            this.lb_NoOfSensors.AutoSize = true;
            this.lb_NoOfSensors.Font = new System.Drawing.Font("Comfortaa SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.lb_NoOfSensors.Location = new System.Drawing.Point(505, 334);
            this.lb_NoOfSensors.Name = "lb_NoOfSensors";
            this.lb_NoOfSensors.Size = new System.Drawing.Size(96, 19);
            this.lb_NoOfSensors.TabIndex = 79;
            this.lb_NoOfSensors.Text = "No of Sensors";
            // 
            // lb_Assign
            // 
            this.lb_Assign.AutoSize = true;
            this.lb_Assign.Font = new System.Drawing.Font("Comfortaa SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.lb_Assign.Location = new System.Drawing.Point(779, 334);
            this.lb_Assign.Name = "lb_Assign";
            this.lb_Assign.Size = new System.Drawing.Size(49, 19);
            this.lb_Assign.TabIndex = 80;
            this.lb_Assign.Text = "Assign";
            // 
            // lb_Interval
            // 
            this.lb_Interval.AutoSize = true;
            this.lb_Interval.Font = new System.Drawing.Font("Comfortaa SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.lb_Interval.Location = new System.Drawing.Point(779, 307);
            this.lb_Interval.Name = "lb_Interval";
            this.lb_Interval.Size = new System.Drawing.Size(58, 19);
            this.lb_Interval.TabIndex = 81;
            this.lb_Interval.Text = "Interval";
            // 
            // tb_LogID
            // 
            this.tb_LogID.Location = new System.Drawing.Point(84, 81);
            this.tb_LogID.Name = "tb_LogID";
            this.tb_LogID.Size = new System.Drawing.Size(98, 20);
            this.tb_LogID.TabIndex = 82;
            this.tb_LogID.Visible = false;
            // 
            // tb_NoOfSensors
            // 
            this.tb_NoOfSensors.Enabled = false;
            this.tb_NoOfSensors.Font = new System.Drawing.Font("Comfortaa SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tb_NoOfSensors.Location = new System.Drawing.Point(607, 332);
            this.tb_NoOfSensors.Name = "tb_NoOfSensors";
            this.tb_NoOfSensors.ReadOnly = true;
            this.tb_NoOfSensors.Size = new System.Drawing.Size(98, 22);
            this.tb_NoOfSensors.TabIndex = 83;
            this.tb_NoOfSensors.TextChanged += new System.EventHandler(this.tb_NoOfSensors_TextChanged);
            // 
            // tb_LogType
            // 
            this.tb_LogType.Enabled = false;
            this.tb_LogType.Font = new System.Drawing.Font("Comfortaa SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tb_LogType.Location = new System.Drawing.Point(607, 308);
            this.tb_LogType.Name = "tb_LogType";
            this.tb_LogType.ReadOnly = true;
            this.tb_LogType.Size = new System.Drawing.Size(98, 22);
            this.tb_LogType.TabIndex = 84;
            this.tb_LogType.TextChanged += new System.EventHandler(this.tb_LogType_TextChanged);
            // 
            // tb_Assign
            // 
            this.tb_Assign.Enabled = false;
            this.tb_Assign.Font = new System.Drawing.Font("Comfortaa SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tb_Assign.Location = new System.Drawing.Point(843, 333);
            this.tb_Assign.Name = "tb_Assign";
            this.tb_Assign.ReadOnly = true;
            this.tb_Assign.Size = new System.Drawing.Size(98, 22);
            this.tb_Assign.TabIndex = 85;
            // 
            // tb_Interval
            // 
            this.tb_Interval.Enabled = false;
            this.tb_Interval.Font = new System.Drawing.Font("Comfortaa SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tb_Interval.Location = new System.Drawing.Point(843, 307);
            this.tb_Interval.Name = "tb_Interval";
            this.tb_Interval.ReadOnly = true;
            this.tb_Interval.Size = new System.Drawing.Size(98, 22);
            this.tb_Interval.TabIndex = 86;
            // 
            // bt_Close
            // 
            this.bt_Close.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.bt_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Close.Font = new System.Drawing.Font("Comfortaa SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Close.Location = new System.Drawing.Point(606, 549);
            this.bt_Close.Name = "bt_Close";
            this.bt_Close.Size = new System.Drawing.Size(70, 30);
            this.bt_Close.TabIndex = 10;
            this.bt_Close.Text = "CLOSE";
            this.bt_Close.UseVisualStyleBackColor = true;
            this.bt_Close.Click += new System.EventHandler(this.bt_Close_Click);
            // 
            // bt_Clear
            // 
            this.bt_Clear.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.bt_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Clear.Font = new System.Drawing.Font("Comfortaa SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Clear.Location = new System.Drawing.Point(500, 549);
            this.bt_Clear.Name = "bt_Clear";
            this.bt_Clear.Size = new System.Drawing.Size(70, 30);
            this.bt_Clear.TabIndex = 9;
            this.bt_Clear.Text = "CLEAR";
            this.bt_Clear.UseVisualStyleBackColor = true;
            this.bt_Clear.Click += new System.EventHandler(this.bt_Clear_Click);
            // 
            // bt_Delete
            // 
            this.bt_Delete.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.bt_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Delete.Font = new System.Drawing.Font("Comfortaa SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Delete.Location = new System.Drawing.Point(394, 549);
            this.bt_Delete.Name = "bt_Delete";
            this.bt_Delete.Size = new System.Drawing.Size(70, 30);
            this.bt_Delete.TabIndex = 8;
            this.bt_Delete.Text = "DELETE";
            this.bt_Delete.UseVisualStyleBackColor = true;
            this.bt_Delete.Click += new System.EventHandler(this.bt_Delete_Click);
            // 
            // bt_Update
            // 
            this.bt_Update.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.bt_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Update.Font = new System.Drawing.Font("Comfortaa SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Update.Location = new System.Drawing.Point(288, 549);
            this.bt_Update.Name = "bt_Update";
            this.bt_Update.Size = new System.Drawing.Size(70, 30);
            this.bt_Update.TabIndex = 7;
            this.bt_Update.Text = "UPDATE";
            this.bt_Update.UseVisualStyleBackColor = true;
            this.bt_Update.Click += new System.EventHandler(this.bt_Update_Click);
            // 
            // bt_Add
            // 
            this.bt_Add.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.bt_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Add.Font = new System.Drawing.Font("Comfortaa SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Add.Location = new System.Drawing.Point(182, 549);
            this.bt_Add.Name = "bt_Add";
            this.bt_Add.Size = new System.Drawing.Size(70, 30);
            this.bt_Add.TabIndex = 6;
            this.bt_Add.Text = "ADD";
            this.bt_Add.UseVisualStyleBackColor = true;
            this.bt_Add.Click += new System.EventHandler(this.bt_Add_Click);
            // 
            // lb_LoggerName
            // 
            this.lb_LoggerName.AutoSize = true;
            this.lb_LoggerName.Font = new System.Drawing.Font("Comfortaa SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.lb_LoggerName.ForeColor = System.Drawing.Color.Black;
            this.lb_LoggerName.Location = new System.Drawing.Point(26, 305);
            this.lb_LoggerName.Name = "lb_LoggerName";
            this.lb_LoggerName.Size = new System.Drawing.Size(94, 19);
            this.lb_LoggerName.TabIndex = 92;
            this.lb_LoggerName.Text = "Logger Name";
            // 
            // cmb_LoggerName
            // 
            this.cmb_LoggerName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb_LoggerName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_LoggerName.Font = new System.Drawing.Font("Comfortaa SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.cmb_LoggerName.FormattingEnabled = true;
            this.cmb_LoggerName.Location = new System.Drawing.Point(126, 305);
            this.cmb_LoggerName.Name = "cmb_LoggerName";
            this.cmb_LoggerName.Size = new System.Drawing.Size(121, 29);
            this.cmb_LoggerName.TabIndex = 1;
            this.cmb_LoggerName.TextChanged += new System.EventHandler(this.cmb_LoggerName_TextChanged);
            // 
            // tb_HS4_LL
            // 
            this.tb_HS4_LL.Font = new System.Drawing.Font("Comfortaa SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tb_HS4_LL.Location = new System.Drawing.Point(17, 121);
            this.tb_HS4_LL.Name = "tb_HS4_LL";
            this.tb_HS4_LL.Size = new System.Drawing.Size(64, 22);
            this.tb_HS4_LL.TabIndex = 6;
            // 
            // tb_HS4_UL
            // 
            this.tb_HS4_UL.Font = new System.Drawing.Font("Comfortaa SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tb_HS4_UL.Location = new System.Drawing.Point(103, 121);
            this.tb_HS4_UL.Name = "tb_HS4_UL";
            this.tb_HS4_UL.Size = new System.Drawing.Size(64, 22);
            this.tb_HS4_UL.TabIndex = 7;
            // 
            // tb_HS3_LL
            // 
            this.tb_HS3_LL.Font = new System.Drawing.Font("Comfortaa SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tb_HS3_LL.Location = new System.Drawing.Point(17, 95);
            this.tb_HS3_LL.Name = "tb_HS3_LL";
            this.tb_HS3_LL.Size = new System.Drawing.Size(64, 22);
            this.tb_HS3_LL.TabIndex = 4;
            // 
            // tb_HS3_UL
            // 
            this.tb_HS3_UL.Font = new System.Drawing.Font("Comfortaa SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tb_HS3_UL.Location = new System.Drawing.Point(103, 95);
            this.tb_HS3_UL.Name = "tb_HS3_UL";
            this.tb_HS3_UL.Size = new System.Drawing.Size(64, 22);
            this.tb_HS3_UL.TabIndex = 5;
            // 
            // tb_HS2_LL
            // 
            this.tb_HS2_LL.Font = new System.Drawing.Font("Comfortaa SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tb_HS2_LL.Location = new System.Drawing.Point(17, 69);
            this.tb_HS2_LL.Name = "tb_HS2_LL";
            this.tb_HS2_LL.Size = new System.Drawing.Size(64, 22);
            this.tb_HS2_LL.TabIndex = 2;
            // 
            // tb_HS2_UL
            // 
            this.tb_HS2_UL.Font = new System.Drawing.Font("Comfortaa SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tb_HS2_UL.Location = new System.Drawing.Point(103, 69);
            this.tb_HS2_UL.Name = "tb_HS2_UL";
            this.tb_HS2_UL.Size = new System.Drawing.Size(64, 22);
            this.tb_HS2_UL.TabIndex = 3;
            // 
            // tb_HS1_LL
            // 
            this.tb_HS1_LL.Font = new System.Drawing.Font("Comfortaa SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tb_HS1_LL.Location = new System.Drawing.Point(17, 43);
            this.tb_HS1_LL.Name = "tb_HS1_LL";
            this.tb_HS1_LL.Size = new System.Drawing.Size(64, 22);
            this.tb_HS1_LL.TabIndex = 0;
            // 
            // tb_HS1_UL
            // 
            this.tb_HS1_UL.Font = new System.Drawing.Font("Comfortaa SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tb_HS1_UL.Location = new System.Drawing.Point(103, 43);
            this.tb_HS1_UL.Name = "tb_HS1_UL";
            this.tb_HS1_UL.Size = new System.Drawing.Size(64, 22);
            this.tb_HS1_UL.TabIndex = 1;
            // 
            // lb_H_LowThreshold
            // 
            this.lb_H_LowThreshold.AutoSize = true;
            this.lb_H_LowThreshold.Font = new System.Drawing.Font("Comfortaa SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.lb_H_LowThreshold.Location = new System.Drawing.Point(9, 21);
            this.lb_H_LowThreshold.Name = "lb_H_LowThreshold";
            this.lb_H_LowThreshold.Size = new System.Drawing.Size(83, 19);
            this.lb_H_LowThreshold.TabIndex = 96;
            this.lb_H_LowThreshold.Text = "Lower Limit";
            // 
            // lb_H_UpThreshold
            // 
            this.lb_H_UpThreshold.AutoSize = true;
            this.lb_H_UpThreshold.Font = new System.Drawing.Font("Comfortaa SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.lb_H_UpThreshold.Location = new System.Drawing.Point(97, 21);
            this.lb_H_UpThreshold.Name = "lb_H_UpThreshold";
            this.lb_H_UpThreshold.Size = new System.Drawing.Size(84, 19);
            this.lb_H_UpThreshold.TabIndex = 95;
            this.lb_H_UpThreshold.Text = "Upper Limit";
            // 
            // tb_HS4_Calibrate
            // 
            this.tb_HS4_Calibrate.Font = new System.Drawing.Font("Comfortaa SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tb_HS4_Calibrate.Location = new System.Drawing.Point(108, 121);
            this.tb_HS4_Calibrate.Name = "tb_HS4_Calibrate";
            this.tb_HS4_Calibrate.Size = new System.Drawing.Size(64, 22);
            this.tb_HS4_Calibrate.TabIndex = 7;
            // 
            // tb_HS3_Calibrate
            // 
            this.tb_HS3_Calibrate.Font = new System.Drawing.Font("Comfortaa SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tb_HS3_Calibrate.Location = new System.Drawing.Point(108, 95);
            this.tb_HS3_Calibrate.Name = "tb_HS3_Calibrate";
            this.tb_HS3_Calibrate.Size = new System.Drawing.Size(64, 22);
            this.tb_HS3_Calibrate.TabIndex = 5;
            // 
            // tb_HS2_Calibrate
            // 
            this.tb_HS2_Calibrate.Font = new System.Drawing.Font("Comfortaa SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tb_HS2_Calibrate.Location = new System.Drawing.Point(108, 69);
            this.tb_HS2_Calibrate.Name = "tb_HS2_Calibrate";
            this.tb_HS2_Calibrate.Size = new System.Drawing.Size(64, 22);
            this.tb_HS2_Calibrate.TabIndex = 3;
            // 
            // tb_HS1_Calibrate
            // 
            this.tb_HS1_Calibrate.Font = new System.Drawing.Font("Comfortaa SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tb_HS1_Calibrate.Location = new System.Drawing.Point(108, 43);
            this.tb_HS1_Calibrate.Name = "tb_HS1_Calibrate";
            this.tb_HS1_Calibrate.Size = new System.Drawing.Size(64, 22);
            this.tb_HS1_Calibrate.TabIndex = 1;
            // 
            // lb_Humi_Calibrate
            // 
            this.lb_Humi_Calibrate.AutoSize = true;
            this.lb_Humi_Calibrate.Font = new System.Drawing.Font("Comfortaa SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.lb_Humi_Calibrate.Location = new System.Drawing.Point(109, 22);
            this.lb_Humi_Calibrate.Name = "lb_Humi_Calibrate";
            this.lb_Humi_Calibrate.Size = new System.Drawing.Size(66, 19);
            this.lb_Humi_Calibrate.TabIndex = 105;
            this.lb_Humi_Calibrate.Text = "Humidity";
            // 
            // tb_IsConfig
            // 
            this.tb_IsConfig.Location = new System.Drawing.Point(194, 81);
            this.tb_IsConfig.Name = "tb_IsConfig";
            this.tb_IsConfig.Size = new System.Drawing.Size(44, 20);
            this.tb_IsConfig.TabIndex = 111;
            this.tb_IsConfig.Visible = false;
            this.tb_IsConfig.TextChanged += new System.EventHandler(this.tb_IsConfig_TextChanged);
            // 
            // tb_Search
            // 
            this.tb_Search.Font = new System.Drawing.Font("Comfortaa SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tb_Search.Location = new System.Drawing.Point(741, 83);
            this.tb_Search.Name = "tb_Search";
            this.tb_Search.Size = new System.Drawing.Size(205, 22);
            this.tb_Search.TabIndex = 0;
            this.tb_Search.TextChanged += new System.EventHandler(this.tb_Search_TextChanged);
            // 
            // lb_Search
            // 
            this.lb_Search.AutoSize = true;
            this.lb_Search.Font = new System.Drawing.Font("Comfortaa SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lb_Search.Location = new System.Drawing.Point(684, 83);
            this.lb_Search.Name = "lb_Search";
            this.lb_Search.Size = new System.Drawing.Size(58, 21);
            this.lb_Search.TabIndex = 112;
            this.lb_Search.Text = "Search";
            // 
            // rb_Celcius
            // 
            this.rb_Celcius.AutoSize = true;
            this.rb_Celcius.Font = new System.Drawing.Font("Comfortaa SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.rb_Celcius.Location = new System.Drawing.Point(9, 24);
            this.rb_Celcius.Name = "rb_Celcius";
            this.rb_Celcius.Size = new System.Drawing.Size(72, 23);
            this.rb_Celcius.TabIndex = 114;
            this.rb_Celcius.Text = "Celcius";
            this.rb_Celcius.UseVisualStyleBackColor = true;
            // 
            // rb_farenheit
            // 
            this.rb_farenheit.AutoSize = true;
            this.rb_farenheit.Font = new System.Drawing.Font("Comfortaa SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.rb_farenheit.Location = new System.Drawing.Point(92, 24);
            this.rb_farenheit.Name = "rb_farenheit";
            this.rb_farenheit.Size = new System.Drawing.Size(87, 23);
            this.rb_farenheit.TabIndex = 115;
            this.rb_farenheit.Text = "Farenheit";
            this.rb_farenheit.UseVisualStyleBackColor = true;
            // 
            // gb_Unit
            // 
            this.gb_Unit.Controls.Add(this.rb_Celcius);
            this.gb_Unit.Controls.Add(this.rb_farenheit);
            this.gb_Unit.Font = new System.Drawing.Font("Comfortaa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Unit.Location = new System.Drawing.Point(275, 303);
            this.gb_Unit.Name = "gb_Unit";
            this.gb_Unit.Size = new System.Drawing.Size(195, 54);
            this.gb_Unit.TabIndex = 116;
            this.gb_Unit.TabStop = false;
            this.gb_Unit.Text = "Temperature Unit";
            // 
            // tb_SyncStatus
            // 
            this.tb_SyncStatus.Enabled = false;
            this.tb_SyncStatus.Font = new System.Drawing.Font("Comfortaa SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tb_SyncStatus.Location = new System.Drawing.Point(126, 338);
            this.tb_SyncStatus.Name = "tb_SyncStatus";
            this.tb_SyncStatus.ReadOnly = true;
            this.tb_SyncStatus.Size = new System.Drawing.Size(121, 22);
            this.tb_SyncStatus.TabIndex = 118;
            // 
            // lb_Sync
            // 
            this.lb_Sync.AutoSize = true;
            this.lb_Sync.Font = new System.Drawing.Font("Comfortaa SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.lb_Sync.Location = new System.Drawing.Point(33, 338);
            this.lb_Sync.Name = "lb_Sync";
            this.lb_Sync.Size = new System.Drawing.Size(83, 19);
            this.lb_Sync.TabIndex = 117;
            this.lb_Sync.Text = "Sync Status";
            // 
            // bt_SyncNow
            // 
            this.bt_SyncNow.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.bt_SyncNow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_SyncNow.Font = new System.Drawing.Font("Comfortaa SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_SyncNow.Location = new System.Drawing.Point(712, 549);
            this.bt_SyncNow.Name = "bt_SyncNow";
            this.bt_SyncNow.Size = new System.Drawing.Size(70, 30);
            this.bt_SyncNow.TabIndex = 11;
            this.bt_SyncNow.Text = "SYNC NOW";
            this.bt_SyncNow.UseVisualStyleBackColor = true;
            this.bt_SyncNow.Click += new System.EventHandler(this.bt_SyncNow_Click);
            // 
            // gb_Calibrate
            // 
            this.gb_Calibrate.Controls.Add(this.lb_Cali_gb);
            this.gb_Calibrate.Controls.Add(this.tb_TS2_Calibrate);
            this.gb_Calibrate.Controls.Add(this.lb_Temp_Calibrate);
            this.gb_Calibrate.Controls.Add(this.tb_TS1_Calibrate);
            this.gb_Calibrate.Controls.Add(this.tb_TS3_Calibrate);
            this.gb_Calibrate.Controls.Add(this.tb_TS4_Calibrate);
            this.gb_Calibrate.Controls.Add(this.lb_Humi_Calibrate);
            this.gb_Calibrate.Controls.Add(this.tb_HS1_Calibrate);
            this.gb_Calibrate.Controls.Add(this.tb_HS2_Calibrate);
            this.gb_Calibrate.Controls.Add(this.tb_HS3_Calibrate);
            this.gb_Calibrate.Controls.Add(this.tb_HS4_Calibrate);
            this.gb_Calibrate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gb_Calibrate.Location = new System.Drawing.Point(754, 382);
            this.gb_Calibrate.Name = "gb_Calibrate";
            this.gb_Calibrate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gb_Calibrate.Size = new System.Drawing.Size(183, 152);
            this.gb_Calibrate.TabIndex = 5;
            this.gb_Calibrate.TabStop = false;
            // 
            // lb_Cali_gb
            // 
            this.lb_Cali_gb.AutoSize = true;
            this.lb_Cali_gb.Font = new System.Drawing.Font("Comfortaa", 9.75F, System.Drawing.FontStyle.Bold);
            this.lb_Cali_gb.Location = new System.Drawing.Point(47, -4);
            this.lb_Cali_gb.Name = "lb_Cali_gb";
            this.lb_Cali_gb.Size = new System.Drawing.Size(84, 21);
            this.lb_Cali_gb.TabIndex = 110;
            this.lb_Cali_gb.Text = "CALIBRATE";
            // 
            // gb_HumiLimit
            // 
            this.gb_HumiLimit.Controls.Add(this.label1);
            this.gb_HumiLimit.Controls.Add(this.tb_HS2_UL);
            this.gb_HumiLimit.Controls.Add(this.lb_H_UpThreshold);
            this.gb_HumiLimit.Controls.Add(this.lb_H_LowThreshold);
            this.gb_HumiLimit.Controls.Add(this.tb_HS1_UL);
            this.gb_HumiLimit.Controls.Add(this.tb_HS1_LL);
            this.gb_HumiLimit.Controls.Add(this.tb_HS2_LL);
            this.gb_HumiLimit.Controls.Add(this.tb_HS3_UL);
            this.gb_HumiLimit.Controls.Add(this.tb_HS3_LL);
            this.gb_HumiLimit.Controls.Add(this.tb_HS4_UL);
            this.gb_HumiLimit.Controls.Add(this.tb_HS4_LL);
            this.gb_HumiLimit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gb_HumiLimit.Location = new System.Drawing.Point(561, 382);
            this.gb_HumiLimit.Name = "gb_HumiLimit";
            this.gb_HumiLimit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gb_HumiLimit.Size = new System.Drawing.Size(183, 152);
            this.gb_HumiLimit.TabIndex = 4;
            this.gb_HumiLimit.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comfortaa", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(18, -4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 21);
            this.label1.TabIndex = 110;
            this.label1.Text = "HUMI THRESHOLD";
            // 
            // gb_TempLimit
            // 
            this.gb_TempLimit.Controls.Add(this.label2);
            this.gb_TempLimit.Controls.Add(this.tb_TS3_UL);
            this.gb_TempLimit.Controls.Add(this.lb_T_UpThreshold);
            this.gb_TempLimit.Controls.Add(this.lb_T_LowThreshold);
            this.gb_TempLimit.Controls.Add(this.tb_TS1_UL);
            this.gb_TempLimit.Controls.Add(this.tb_TS1_LL);
            this.gb_TempLimit.Controls.Add(this.tb_TS2_UL);
            this.gb_TempLimit.Controls.Add(this.tb_TS2_LL);
            this.gb_TempLimit.Controls.Add(this.tb_TS3_LL);
            this.gb_TempLimit.Controls.Add(this.tb_TS4_UL);
            this.gb_TempLimit.Controls.Add(this.tb_TS4_LL);
            this.gb_TempLimit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gb_TempLimit.Location = new System.Drawing.Point(348, 382);
            this.gb_TempLimit.Name = "gb_TempLimit";
            this.gb_TempLimit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gb_TempLimit.Size = new System.Drawing.Size(203, 152);
            this.gb_TempLimit.TabIndex = 3;
            this.gb_TempLimit.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comfortaa", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(30, -4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 21);
            this.label2.TabIndex = 110;
            this.label2.Text = "TEMP THRESHOLD";
            // 
            // gb_SV
            // 
            this.gb_SV.Controls.Add(this.label3);
            this.gb_SV.Controls.Add(this.tb_S1_Humidity);
            this.gb_SV.Controls.Add(this.lb_Temp);
            this.gb_SV.Controls.Add(this.lb_Humidity);
            this.gb_SV.Controls.Add(this.tb_S1_Temp);
            this.gb_SV.Controls.Add(this.tb_S2_Temp);
            this.gb_SV.Controls.Add(this.tb_S2_Humidity);
            this.gb_SV.Controls.Add(this.tb_S3_Temp);
            this.gb_SV.Controls.Add(this.tb_S3_Humidity);
            this.gb_SV.Controls.Add(this.tb_S4_Temp);
            this.gb_SV.Controls.Add(this.tb_S4_Humidity);
            this.gb_SV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gb_SV.Location = new System.Drawing.Point(143, 382);
            this.gb_SV.Name = "gb_SV";
            this.gb_SV.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gb_SV.Size = new System.Drawing.Size(195, 152);
            this.gb_SV.TabIndex = 2;
            this.gb_SV.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comfortaa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(54, -4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 21);
            this.label3.TabIndex = 110;
            this.label3.Text = "SET VALUE";
            // 
            // lb_Title
            // 
            this.lb_Title.AutoSize = true;
            this.lb_Title.Font = new System.Drawing.Font("Comfortaa", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Title.Location = new System.Drawing.Point(310, 15);
            this.lb_Title.Name = "lb_Title";
            this.lb_Title.Size = new System.Drawing.Size(346, 39);
            this.lb_Title.TabIndex = 124;
            this.lb_Title.Text = "LOGGER CONFIGURATION";
            // 
            // tb_delay
            // 
            this.tb_delay.Location = new System.Drawing.Point(368, 81);
            this.tb_delay.Name = "tb_delay";
            this.tb_delay.Size = new System.Drawing.Size(44, 20);
            this.tb_delay.TabIndex = 125;
            this.tb_delay.Visible = false;
            // 
            // tb_delaytype
            // 
            this.tb_delaytype.Location = new System.Drawing.Point(418, 81);
            this.tb_delaytype.Name = "tb_delaytype";
            this.tb_delaytype.Size = new System.Drawing.Size(44, 20);
            this.tb_delaytype.TabIndex = 126;
            this.tb_delaytype.Visible = false;
            // 
            // LoggerConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(966, 633);
            this.Controls.Add(this.tb_delaytype);
            this.Controls.Add(this.tb_delay);
            this.Controls.Add(this.lb_Title);
            this.Controls.Add(this.gb_SV);
            this.Controls.Add(this.gb_TempLimit);
            this.Controls.Add(this.gb_HumiLimit);
            this.Controls.Add(this.gb_Calibrate);
            this.Controls.Add(this.bt_SyncNow);
            this.Controls.Add(this.tb_SyncStatus);
            this.Controls.Add(this.lb_Sync);
            this.Controls.Add(this.gb_Unit);
            this.Controls.Add(this.tb_Search);
            this.Controls.Add(this.lb_Search);
            this.Controls.Add(this.tb_IsConfig);
            this.Controls.Add(this.cmb_LoggerName);
            this.Controls.Add(this.lb_LoggerName);
            this.Controls.Add(this.bt_Close);
            this.Controls.Add(this.bt_Clear);
            this.Controls.Add(this.bt_Delete);
            this.Controls.Add(this.bt_Update);
            this.Controls.Add(this.bt_Add);
            this.Controls.Add(this.tb_Interval);
            this.Controls.Add(this.tb_Assign);
            this.Controls.Add(this.tb_LogType);
            this.Controls.Add(this.tb_NoOfSensors);
            this.Controls.Add(this.tb_LogID);
            this.Controls.Add(this.lb_Interval);
            this.Controls.Add(this.lb_Assign);
            this.Controls.Add(this.lb_NoOfSensors);
            this.Controls.Add(this.lb_LogType);
            this.Controls.Add(this.lb_LogID);
            this.Controls.Add(this.tb_S4_Name);
            this.Controls.Add(this.tb_S3_Name);
            this.Controls.Add(this.tb_S2_Name);
            this.Controls.Add(this.tb_S1_Name);
            this.Controls.Add(this.dgv_LoggerConfig);
            this.Controls.Add(this.lb_Sensors);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoggerConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logger Configuration";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoggerConfig_FormClosing);
            this.Load += new System.EventHandler(this.LoggerConfig_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LoggerConfig)).EndInit();
            this.gb_Unit.ResumeLayout(false);
            this.gb_Unit.PerformLayout();
            this.gb_Calibrate.ResumeLayout(false);
            this.gb_Calibrate.PerformLayout();
            this.gb_HumiLimit.ResumeLayout(false);
            this.gb_HumiLimit.PerformLayout();
            this.gb_TempLimit.ResumeLayout(false);
            this.gb_TempLimit.PerformLayout();
            this.gb_SV.ResumeLayout(false);
            this.gb_SV.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn s1TLowDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn s1THighDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn s2TLowDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn s2THighDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn s3TLowDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn s3THighDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn s4TLowDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn s4THighDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn s1HLowDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn s1HHighDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn s2HLowDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn s2HHighDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn s3HLowDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn s3HHighDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn s4HLowDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn s4HHighDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn s1CalibrateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn s2CalibrateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn s3CalibrateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn s4CalibrateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lb_Title;
        private System.Windows.Forms.TextBox tb_LogID;
        private System.Windows.Forms.TextBox tb_IsConfig;
        private System.Windows.Forms.Label lb_LogType;
        private System.Windows.Forms.Label lb_NoOfSensors;
        private System.Windows.Forms.Label lb_Assign;
        private System.Windows.Forms.Label lb_Interval;
        private System.Windows.Forms.TextBox tb_NoOfSensors;
        private System.Windows.Forms.TextBox tb_LogType;
        private System.Windows.Forms.TextBox tb_Assign;
        private System.Windows.Forms.TextBox tb_Interval;
        private System.Windows.Forms.Label lb_LoggerName;
        private System.Windows.Forms.ComboBox cmb_LoggerName;
        private System.Windows.Forms.RadioButton rb_Celcius;
        private System.Windows.Forms.RadioButton rb_farenheit;
        private System.Windows.Forms.GroupBox gb_Unit;
        private System.Windows.Forms.TextBox tb_SyncStatus;
        private System.Windows.Forms.Label lb_Sync;
        private System.Windows.Forms.Button bt_Close;
        private System.Windows.Forms.Button bt_Clear;
        private System.Windows.Forms.Button bt_Delete;
        private System.Windows.Forms.Button bt_Update;
        private System.Windows.Forms.Button bt_Add;
        private System.Windows.Forms.Button bt_SyncNow;
        private System.Windows.Forms.TextBox tb_TS4_LL;
        private System.Windows.Forms.TextBox tb_TS4_UL;
        private System.Windows.Forms.TextBox tb_TS3_LL;
        private System.Windows.Forms.TextBox tb_TS3_UL;
        private System.Windows.Forms.TextBox tb_TS2_LL;
        private System.Windows.Forms.TextBox tb_TS2_UL;
        private System.Windows.Forms.TextBox tb_TS1_LL;
        private System.Windows.Forms.TextBox tb_TS1_UL;
        private System.Windows.Forms.TextBox tb_S4_Humidity;
        private System.Windows.Forms.TextBox tb_S4_Temp;
        private System.Windows.Forms.TextBox tb_S3_Humidity;
        private System.Windows.Forms.TextBox tb_S3_Temp;
        private System.Windows.Forms.TextBox tb_S2_Humidity;
        private System.Windows.Forms.TextBox tb_S2_Temp;
        private System.Windows.Forms.TextBox tb_S1_Humidity;
        private System.Windows.Forms.TextBox tb_S1_Temp;
        private System.Windows.Forms.Label lb_T_LowThreshold;
        private System.Windows.Forms.Label lb_T_UpThreshold;
        private System.Windows.Forms.Label lb_Humidity;
        private System.Windows.Forms.Label lb_Temp;
        private System.Windows.Forms.Label lb_Sensors;
        private System.Windows.Forms.Label lb_Temp_Calibrate;
        private System.Windows.Forms.TextBox tb_TS1_Calibrate;
        private System.Windows.Forms.TextBox tb_TS2_Calibrate;
        private System.Windows.Forms.TextBox tb_TS3_Calibrate;
        private System.Windows.Forms.TextBox tb_TS4_Calibrate;
        private System.Windows.Forms.DataGridView dgv_LoggerConfig;
        private System.Windows.Forms.TextBox tb_S1_Name;
        private System.Windows.Forms.TextBox tb_S2_Name;
        private System.Windows.Forms.TextBox tb_S3_Name;
        private System.Windows.Forms.TextBox tb_S4_Name;
        private System.Windows.Forms.Label lb_LogID;
        private System.Windows.Forms.TextBox tb_HS4_LL;
        private System.Windows.Forms.TextBox tb_HS4_UL;
        private System.Windows.Forms.TextBox tb_HS3_LL;
        private System.Windows.Forms.TextBox tb_HS3_UL;
        private System.Windows.Forms.TextBox tb_HS2_LL;
        private System.Windows.Forms.TextBox tb_HS2_UL;
        private System.Windows.Forms.TextBox tb_HS1_LL;
        private System.Windows.Forms.TextBox tb_HS1_UL;
        private System.Windows.Forms.Label lb_H_LowThreshold;
        private System.Windows.Forms.Label lb_H_UpThreshold;
        private System.Windows.Forms.TextBox tb_HS4_Calibrate;
        private System.Windows.Forms.TextBox tb_HS3_Calibrate;
        private System.Windows.Forms.TextBox tb_HS2_Calibrate;
        private System.Windows.Forms.TextBox tb_HS1_Calibrate;
        private System.Windows.Forms.Label lb_Humi_Calibrate;
        private System.Windows.Forms.TextBox tb_Search;
        private System.Windows.Forms.Label lb_Search;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.GroupBox gb_Calibrate;
        private System.Windows.Forms.Label lb_Cali_gb;
        private System.Windows.Forms.GroupBox gb_HumiLimit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gb_TempLimit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gb_SV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_delay;
        private System.Windows.Forms.TextBox tb_delaytype;
    }
}