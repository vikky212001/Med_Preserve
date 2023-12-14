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
            this.lb_Temp_Threshold = new System.Windows.Forms.Label();
            this.lb_Humidity = new System.Windows.Forms.Label();
            this.lb_Temp = new System.Windows.Forms.Label();
            this.lb_SetValue = new System.Windows.Forms.Label();
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
            this.lb_Humi_Threshold = new System.Windows.Forms.Label();
            this.tb_HS4_Calibrate = new System.Windows.Forms.TextBox();
            this.tb_HS3_Calibrate = new System.Windows.Forms.TextBox();
            this.tb_HS2_Calibrate = new System.Windows.Forms.TextBox();
            this.tb_HS1_Calibrate = new System.Windows.Forms.TextBox();
            this.lb_Humi_Calibrate = new System.Windows.Forms.Label();
            this.lb_Calibrate = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LoggerConfig)).BeginInit();
            this.gb_Unit.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_TS4_LL
            // 
            this.tb_TS4_LL.Location = new System.Drawing.Point(309, 414);
            this.tb_TS4_LL.Name = "tb_TS4_LL";
            this.tb_TS4_LL.Size = new System.Drawing.Size(64, 20);
            this.tb_TS4_LL.TabIndex = 64;
            // 
            // tb_TS4_UL
            // 
            this.tb_TS4_UL.Location = new System.Drawing.Point(379, 414);
            this.tb_TS4_UL.Name = "tb_TS4_UL";
            this.tb_TS4_UL.Size = new System.Drawing.Size(64, 20);
            this.tb_TS4_UL.TabIndex = 63;
            // 
            // tb_TS3_LL
            // 
            this.tb_TS3_LL.Location = new System.Drawing.Point(309, 388);
            this.tb_TS3_LL.Name = "tb_TS3_LL";
            this.tb_TS3_LL.Size = new System.Drawing.Size(64, 20);
            this.tb_TS3_LL.TabIndex = 62;
            // 
            // tb_TS3_UL
            // 
            this.tb_TS3_UL.Location = new System.Drawing.Point(379, 388);
            this.tb_TS3_UL.Name = "tb_TS3_UL";
            this.tb_TS3_UL.Size = new System.Drawing.Size(64, 20);
            this.tb_TS3_UL.TabIndex = 61;
            // 
            // tb_TS2_LL
            // 
            this.tb_TS2_LL.Location = new System.Drawing.Point(309, 362);
            this.tb_TS2_LL.Name = "tb_TS2_LL";
            this.tb_TS2_LL.Size = new System.Drawing.Size(64, 20);
            this.tb_TS2_LL.TabIndex = 60;
            // 
            // tb_TS2_UL
            // 
            this.tb_TS2_UL.Location = new System.Drawing.Point(379, 362);
            this.tb_TS2_UL.Name = "tb_TS2_UL";
            this.tb_TS2_UL.Size = new System.Drawing.Size(64, 20);
            this.tb_TS2_UL.TabIndex = 59;
            // 
            // tb_TS1_LL
            // 
            this.tb_TS1_LL.Location = new System.Drawing.Point(309, 336);
            this.tb_TS1_LL.Name = "tb_TS1_LL";
            this.tb_TS1_LL.Size = new System.Drawing.Size(64, 20);
            this.tb_TS1_LL.TabIndex = 58;
            // 
            // tb_TS1_UL
            // 
            this.tb_TS1_UL.Location = new System.Drawing.Point(379, 336);
            this.tb_TS1_UL.Name = "tb_TS1_UL";
            this.tb_TS1_UL.Size = new System.Drawing.Size(64, 20);
            this.tb_TS1_UL.TabIndex = 57;
            // 
            // tb_S4_Humidity
            // 
            this.tb_S4_Humidity.Location = new System.Drawing.Point(216, 414);
            this.tb_S4_Humidity.Name = "tb_S4_Humidity";
            this.tb_S4_Humidity.Size = new System.Drawing.Size(64, 20);
            this.tb_S4_Humidity.TabIndex = 56;
            // 
            // tb_S4_Temp
            // 
            this.tb_S4_Temp.Location = new System.Drawing.Point(146, 414);
            this.tb_S4_Temp.Name = "tb_S4_Temp";
            this.tb_S4_Temp.Size = new System.Drawing.Size(64, 20);
            this.tb_S4_Temp.TabIndex = 55;
            // 
            // tb_S3_Humidity
            // 
            this.tb_S3_Humidity.Location = new System.Drawing.Point(216, 388);
            this.tb_S3_Humidity.Name = "tb_S3_Humidity";
            this.tb_S3_Humidity.Size = new System.Drawing.Size(64, 20);
            this.tb_S3_Humidity.TabIndex = 54;
            // 
            // tb_S3_Temp
            // 
            this.tb_S3_Temp.Location = new System.Drawing.Point(146, 388);
            this.tb_S3_Temp.Name = "tb_S3_Temp";
            this.tb_S3_Temp.Size = new System.Drawing.Size(64, 20);
            this.tb_S3_Temp.TabIndex = 53;
            // 
            // tb_S2_Humidity
            // 
            this.tb_S2_Humidity.Location = new System.Drawing.Point(216, 362);
            this.tb_S2_Humidity.Name = "tb_S2_Humidity";
            this.tb_S2_Humidity.Size = new System.Drawing.Size(64, 20);
            this.tb_S2_Humidity.TabIndex = 52;
            // 
            // tb_S2_Temp
            // 
            this.tb_S2_Temp.Location = new System.Drawing.Point(146, 362);
            this.tb_S2_Temp.Name = "tb_S2_Temp";
            this.tb_S2_Temp.Size = new System.Drawing.Size(64, 20);
            this.tb_S2_Temp.TabIndex = 51;
            // 
            // tb_S1_Humidity
            // 
            this.tb_S1_Humidity.Location = new System.Drawing.Point(216, 336);
            this.tb_S1_Humidity.Name = "tb_S1_Humidity";
            this.tb_S1_Humidity.Size = new System.Drawing.Size(64, 20);
            this.tb_S1_Humidity.TabIndex = 50;
            // 
            // tb_S1_Temp
            // 
            this.tb_S1_Temp.Location = new System.Drawing.Point(146, 336);
            this.tb_S1_Temp.Name = "tb_S1_Temp";
            this.tb_S1_Temp.Size = new System.Drawing.Size(64, 20);
            this.tb_S1_Temp.TabIndex = 49;
            // 
            // lb_T_LowThreshold
            // 
            this.lb_T_LowThreshold.AutoSize = true;
            this.lb_T_LowThreshold.Location = new System.Drawing.Point(310, 319);
            this.lb_T_LowThreshold.Name = "lb_T_LowThreshold";
            this.lb_T_LowThreshold.Size = new System.Drawing.Size(60, 13);
            this.lb_T_LowThreshold.TabIndex = 48;
            this.lb_T_LowThreshold.Text = "Lower Limit";
            // 
            // lb_T_UpThreshold
            // 
            this.lb_T_UpThreshold.AutoSize = true;
            this.lb_T_UpThreshold.Location = new System.Drawing.Point(384, 319);
            this.lb_T_UpThreshold.Name = "lb_T_UpThreshold";
            this.lb_T_UpThreshold.Size = new System.Drawing.Size(60, 13);
            this.lb_T_UpThreshold.TabIndex = 47;
            this.lb_T_UpThreshold.Text = "Upper Limit";
            // 
            // lb_Temp_Threshold
            // 
            this.lb_Temp_Threshold.AutoSize = true;
            this.lb_Temp_Threshold.Location = new System.Drawing.Point(317, 303);
            this.lb_Temp_Threshold.Name = "lb_Temp_Threshold";
            this.lb_Temp_Threshold.Size = new System.Drawing.Size(117, 13);
            this.lb_Temp_Threshold.TabIndex = 46;
            this.lb_Temp_Threshold.Text = "Temperature Threshold";
            // 
            // lb_Humidity
            // 
            this.lb_Humidity.AutoSize = true;
            this.lb_Humidity.Location = new System.Drawing.Point(218, 317);
            this.lb_Humidity.Name = "lb_Humidity";
            this.lb_Humidity.Size = new System.Drawing.Size(47, 13);
            this.lb_Humidity.TabIndex = 45;
            this.lb_Humidity.Text = "Humidity";
            // 
            // lb_Temp
            // 
            this.lb_Temp.AutoSize = true;
            this.lb_Temp.Location = new System.Drawing.Point(143, 317);
            this.lb_Temp.Name = "lb_Temp";
            this.lb_Temp.Size = new System.Drawing.Size(67, 13);
            this.lb_Temp.TabIndex = 44;
            this.lb_Temp.Text = "Temperature";
            // 
            // lb_SetValue
            // 
            this.lb_SetValue.AutoSize = true;
            this.lb_SetValue.Location = new System.Drawing.Point(179, 303);
            this.lb_SetValue.Name = "lb_SetValue";
            this.lb_SetValue.Size = new System.Drawing.Size(53, 13);
            this.lb_SetValue.TabIndex = 43;
            this.lb_SetValue.Text = "Set Value";
            // 
            // lb_Sensors
            // 
            this.lb_Sensors.AutoSize = true;
            this.lb_Sensors.Location = new System.Drawing.Point(27, 317);
            this.lb_Sensors.Name = "lb_Sensors";
            this.lb_Sensors.Size = new System.Drawing.Size(45, 13);
            this.lb_Sensors.TabIndex = 66;
            this.lb_Sensors.Text = "Sensors";
            // 
            // lb_Temp_Calibrate
            // 
            this.lb_Temp_Calibrate.AutoSize = true;
            this.lb_Temp_Calibrate.Location = new System.Drawing.Point(635, 319);
            this.lb_Temp_Calibrate.Name = "lb_Temp_Calibrate";
            this.lb_Temp_Calibrate.Size = new System.Drawing.Size(67, 13);
            this.lb_Temp_Calibrate.TabIndex = 67;
            this.lb_Temp_Calibrate.Text = "Temperature";
            // 
            // tb_TS1_Calibrate
            // 
            this.tb_TS1_Calibrate.Location = new System.Drawing.Point(638, 336);
            this.tb_TS1_Calibrate.Name = "tb_TS1_Calibrate";
            this.tb_TS1_Calibrate.Size = new System.Drawing.Size(64, 20);
            this.tb_TS1_Calibrate.TabIndex = 68;
            // 
            // tb_TS2_Calibrate
            // 
            this.tb_TS2_Calibrate.Location = new System.Drawing.Point(638, 362);
            this.tb_TS2_Calibrate.Name = "tb_TS2_Calibrate";
            this.tb_TS2_Calibrate.Size = new System.Drawing.Size(64, 20);
            this.tb_TS2_Calibrate.TabIndex = 69;
            // 
            // tb_TS3_Calibrate
            // 
            this.tb_TS3_Calibrate.Location = new System.Drawing.Point(638, 388);
            this.tb_TS3_Calibrate.Name = "tb_TS3_Calibrate";
            this.tb_TS3_Calibrate.Size = new System.Drawing.Size(64, 20);
            this.tb_TS3_Calibrate.TabIndex = 70;
            // 
            // tb_TS4_Calibrate
            // 
            this.tb_TS4_Calibrate.Location = new System.Drawing.Point(638, 414);
            this.tb_TS4_Calibrate.Name = "tb_TS4_Calibrate";
            this.tb_TS4_Calibrate.Size = new System.Drawing.Size(64, 20);
            this.tb_TS4_Calibrate.TabIndex = 71;
            // 
            // dgv_LoggerConfig
            // 
            this.dgv_LoggerConfig.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_LoggerConfig.Location = new System.Drawing.Point(13, 50);
            this.dgv_LoggerConfig.Name = "dgv_LoggerConfig";
            this.dgv_LoggerConfig.Size = new System.Drawing.Size(771, 150);
            this.dgv_LoggerConfig.TabIndex = 72;
            this.dgv_LoggerConfig.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_LoggerConfig_CellClick);
            // 
            // tb_S1_Name
            // 
            this.tb_S1_Name.Location = new System.Drawing.Point(13, 336);
            this.tb_S1_Name.Name = "tb_S1_Name";
            this.tb_S1_Name.ReadOnly = true;
            this.tb_S1_Name.Size = new System.Drawing.Size(98, 20);
            this.tb_S1_Name.TabIndex = 73;
            // 
            // tb_S2_Name
            // 
            this.tb_S2_Name.Location = new System.Drawing.Point(13, 362);
            this.tb_S2_Name.Name = "tb_S2_Name";
            this.tb_S2_Name.ReadOnly = true;
            this.tb_S2_Name.Size = new System.Drawing.Size(98, 20);
            this.tb_S2_Name.TabIndex = 74;
            // 
            // tb_S3_Name
            // 
            this.tb_S3_Name.Location = new System.Drawing.Point(13, 388);
            this.tb_S3_Name.Name = "tb_S3_Name";
            this.tb_S3_Name.ReadOnly = true;
            this.tb_S3_Name.Size = new System.Drawing.Size(98, 20);
            this.tb_S3_Name.TabIndex = 75;
            // 
            // tb_S4_Name
            // 
            this.tb_S4_Name.Location = new System.Drawing.Point(13, 414);
            this.tb_S4_Name.Name = "tb_S4_Name";
            this.tb_S4_Name.ReadOnly = true;
            this.tb_S4_Name.Size = new System.Drawing.Size(98, 20);
            this.tb_S4_Name.TabIndex = 76;
            // 
            // lb_LogID
            // 
            this.lb_LogID.AutoSize = true;
            this.lb_LogID.Location = new System.Drawing.Point(12, 12);
            this.lb_LogID.Name = "lb_LogID";
            this.lb_LogID.Size = new System.Drawing.Size(54, 13);
            this.lb_LogID.TabIndex = 77;
            this.lb_LogID.Text = "Logger ID";
            this.lb_LogID.Visible = false;
            // 
            // lb_LogType
            // 
            this.lb_LogType.AutoSize = true;
            this.lb_LogType.Location = new System.Drawing.Point(297, 219);
            this.lb_LogType.Name = "lb_LogType";
            this.lb_LogType.Size = new System.Drawing.Size(67, 13);
            this.lb_LogType.TabIndex = 78;
            this.lb_LogType.Text = "Logger Type";
            // 
            // lb_NoOfSensors
            // 
            this.lb_NoOfSensors.AutoSize = true;
            this.lb_NoOfSensors.Location = new System.Drawing.Point(299, 245);
            this.lb_NoOfSensors.Name = "lb_NoOfSensors";
            this.lb_NoOfSensors.Size = new System.Drawing.Size(74, 13);
            this.lb_NoOfSensors.TabIndex = 79;
            this.lb_NoOfSensors.Text = "No of Sensors";
            // 
            // lb_Assign
            // 
            this.lb_Assign.AutoSize = true;
            this.lb_Assign.Location = new System.Drawing.Point(568, 246);
            this.lb_Assign.Name = "lb_Assign";
            this.lb_Assign.Size = new System.Drawing.Size(38, 13);
            this.lb_Assign.TabIndex = 80;
            this.lb_Assign.Text = "Assign";
            // 
            // lb_Interval
            // 
            this.lb_Interval.AutoSize = true;
            this.lb_Interval.Location = new System.Drawing.Point(572, 218);
            this.lb_Interval.Name = "lb_Interval";
            this.lb_Interval.Size = new System.Drawing.Size(42, 13);
            this.lb_Interval.TabIndex = 81;
            this.lb_Interval.Text = "Interval";
            // 
            // tb_LogID
            // 
            this.tb_LogID.Location = new System.Drawing.Point(72, 9);
            this.tb_LogID.Name = "tb_LogID";
            this.tb_LogID.Size = new System.Drawing.Size(98, 20);
            this.tb_LogID.TabIndex = 82;
            this.tb_LogID.Visible = false;
            // 
            // tb_NoOfSensors
            // 
            this.tb_NoOfSensors.Location = new System.Drawing.Point(379, 242);
            this.tb_NoOfSensors.Name = "tb_NoOfSensors";
            this.tb_NoOfSensors.ReadOnly = true;
            this.tb_NoOfSensors.Size = new System.Drawing.Size(98, 20);
            this.tb_NoOfSensors.TabIndex = 83;
            this.tb_NoOfSensors.TextChanged += new System.EventHandler(this.tb_NoOfSensors_TextChanged);
            // 
            // tb_LogType
            // 
            this.tb_LogType.Location = new System.Drawing.Point(379, 216);
            this.tb_LogType.Name = "tb_LogType";
            this.tb_LogType.ReadOnly = true;
            this.tb_LogType.Size = new System.Drawing.Size(98, 20);
            this.tb_LogType.TabIndex = 84;
            this.tb_LogType.TextChanged += new System.EventHandler(this.tb_LogType_TextChanged);
            // 
            // tb_Assign
            // 
            this.tb_Assign.Location = new System.Drawing.Point(620, 242);
            this.tb_Assign.Name = "tb_Assign";
            this.tb_Assign.ReadOnly = true;
            this.tb_Assign.Size = new System.Drawing.Size(98, 20);
            this.tb_Assign.TabIndex = 85;
            // 
            // tb_Interval
            // 
            this.tb_Interval.Location = new System.Drawing.Point(620, 216);
            this.tb_Interval.Name = "tb_Interval";
            this.tb_Interval.ReadOnly = true;
            this.tb_Interval.Size = new System.Drawing.Size(98, 20);
            this.tb_Interval.TabIndex = 86;
            // 
            // bt_Close
            // 
            this.bt_Close.Location = new System.Drawing.Point(495, 453);
            this.bt_Close.Name = "bt_Close";
            this.bt_Close.Size = new System.Drawing.Size(75, 23);
            this.bt_Close.TabIndex = 91;
            this.bt_Close.Text = "CLOSE";
            this.bt_Close.UseVisualStyleBackColor = true;
            this.bt_Close.Click += new System.EventHandler(this.bt_Close_Click);
            // 
            // bt_Clear
            // 
            this.bt_Clear.Location = new System.Drawing.Point(396, 453);
            this.bt_Clear.Name = "bt_Clear";
            this.bt_Clear.Size = new System.Drawing.Size(75, 23);
            this.bt_Clear.TabIndex = 90;
            this.bt_Clear.Text = "CLEAR";
            this.bt_Clear.UseVisualStyleBackColor = true;
            this.bt_Clear.Click += new System.EventHandler(this.bt_Clear_Click);
            // 
            // bt_Delete
            // 
            this.bt_Delete.Location = new System.Drawing.Point(287, 453);
            this.bt_Delete.Name = "bt_Delete";
            this.bt_Delete.Size = new System.Drawing.Size(75, 23);
            this.bt_Delete.TabIndex = 89;
            this.bt_Delete.Text = "DELETE";
            this.bt_Delete.UseVisualStyleBackColor = true;
            this.bt_Delete.Click += new System.EventHandler(this.bt_Delete_Click);
            // 
            // bt_Update
            // 
            this.bt_Update.Location = new System.Drawing.Point(172, 453);
            this.bt_Update.Name = "bt_Update";
            this.bt_Update.Size = new System.Drawing.Size(75, 23);
            this.bt_Update.TabIndex = 88;
            this.bt_Update.Text = "UPDATE";
            this.bt_Update.UseVisualStyleBackColor = true;
            this.bt_Update.Click += new System.EventHandler(this.bt_Update_Click);
            // 
            // bt_Add
            // 
            this.bt_Add.Location = new System.Drawing.Point(64, 453);
            this.bt_Add.Name = "bt_Add";
            this.bt_Add.Size = new System.Drawing.Size(75, 23);
            this.bt_Add.TabIndex = 87;
            this.bt_Add.Text = "ADD";
            this.bt_Add.UseVisualStyleBackColor = true;
            this.bt_Add.Click += new System.EventHandler(this.bt_Add_Click);
            // 
            // lb_LoggerName
            // 
            this.lb_LoggerName.AutoSize = true;
            this.lb_LoggerName.Location = new System.Drawing.Point(12, 219);
            this.lb_LoggerName.Name = "lb_LoggerName";
            this.lb_LoggerName.Size = new System.Drawing.Size(71, 13);
            this.lb_LoggerName.TabIndex = 92;
            this.lb_LoggerName.Text = "Logger Name";
            // 
            // cmb_LoggerName
            // 
            this.cmb_LoggerName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb_LoggerName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_LoggerName.FormattingEnabled = true;
            this.cmb_LoggerName.Location = new System.Drawing.Point(89, 219);
            this.cmb_LoggerName.Name = "cmb_LoggerName";
            this.cmb_LoggerName.Size = new System.Drawing.Size(121, 21);
            this.cmb_LoggerName.TabIndex = 93;
            this.cmb_LoggerName.TextChanged += new System.EventHandler(this.cmb_LoggerName_TextChanged);
            // 
            // tb_HS4_LL
            // 
            this.tb_HS4_LL.Location = new System.Drawing.Point(470, 414);
            this.tb_HS4_LL.Name = "tb_HS4_LL";
            this.tb_HS4_LL.Size = new System.Drawing.Size(64, 20);
            this.tb_HS4_LL.TabIndex = 104;
            // 
            // tb_HS4_UL
            // 
            this.tb_HS4_UL.Location = new System.Drawing.Point(541, 414);
            this.tb_HS4_UL.Name = "tb_HS4_UL";
            this.tb_HS4_UL.Size = new System.Drawing.Size(64, 20);
            this.tb_HS4_UL.TabIndex = 103;
            // 
            // tb_HS3_LL
            // 
            this.tb_HS3_LL.Location = new System.Drawing.Point(470, 388);
            this.tb_HS3_LL.Name = "tb_HS3_LL";
            this.tb_HS3_LL.Size = new System.Drawing.Size(64, 20);
            this.tb_HS3_LL.TabIndex = 102;
            // 
            // tb_HS3_UL
            // 
            this.tb_HS3_UL.Location = new System.Drawing.Point(541, 388);
            this.tb_HS3_UL.Name = "tb_HS3_UL";
            this.tb_HS3_UL.Size = new System.Drawing.Size(64, 20);
            this.tb_HS3_UL.TabIndex = 101;
            // 
            // tb_HS2_LL
            // 
            this.tb_HS2_LL.Location = new System.Drawing.Point(470, 362);
            this.tb_HS2_LL.Name = "tb_HS2_LL";
            this.tb_HS2_LL.Size = new System.Drawing.Size(64, 20);
            this.tb_HS2_LL.TabIndex = 100;
            // 
            // tb_HS2_UL
            // 
            this.tb_HS2_UL.Location = new System.Drawing.Point(541, 362);
            this.tb_HS2_UL.Name = "tb_HS2_UL";
            this.tb_HS2_UL.Size = new System.Drawing.Size(64, 20);
            this.tb_HS2_UL.TabIndex = 99;
            // 
            // tb_HS1_LL
            // 
            this.tb_HS1_LL.Location = new System.Drawing.Point(470, 336);
            this.tb_HS1_LL.Name = "tb_HS1_LL";
            this.tb_HS1_LL.Size = new System.Drawing.Size(64, 20);
            this.tb_HS1_LL.TabIndex = 98;
            // 
            // tb_HS1_UL
            // 
            this.tb_HS1_UL.Location = new System.Drawing.Point(541, 336);
            this.tb_HS1_UL.Name = "tb_HS1_UL";
            this.tb_HS1_UL.Size = new System.Drawing.Size(64, 20);
            this.tb_HS1_UL.TabIndex = 97;
            // 
            // lb_H_LowThreshold
            // 
            this.lb_H_LowThreshold.AutoSize = true;
            this.lb_H_LowThreshold.Location = new System.Drawing.Point(471, 319);
            this.lb_H_LowThreshold.Name = "lb_H_LowThreshold";
            this.lb_H_LowThreshold.Size = new System.Drawing.Size(60, 13);
            this.lb_H_LowThreshold.TabIndex = 96;
            this.lb_H_LowThreshold.Text = "Lower Limit";
            // 
            // lb_H_UpThreshold
            // 
            this.lb_H_UpThreshold.AutoSize = true;
            this.lb_H_UpThreshold.Location = new System.Drawing.Point(545, 320);
            this.lb_H_UpThreshold.Name = "lb_H_UpThreshold";
            this.lb_H_UpThreshold.Size = new System.Drawing.Size(60, 13);
            this.lb_H_UpThreshold.TabIndex = 95;
            this.lb_H_UpThreshold.Text = "Upper Limit";
            // 
            // lb_Humi_Threshold
            // 
            this.lb_Humi_Threshold.AutoSize = true;
            this.lb_Humi_Threshold.Location = new System.Drawing.Point(488, 303);
            this.lb_Humi_Threshold.Name = "lb_Humi_Threshold";
            this.lb_Humi_Threshold.Size = new System.Drawing.Size(97, 13);
            this.lb_Humi_Threshold.TabIndex = 94;
            this.lb_Humi_Threshold.Text = "Humidity Threshold";
            // 
            // tb_HS4_Calibrate
            // 
            this.tb_HS4_Calibrate.Location = new System.Drawing.Point(708, 414);
            this.tb_HS4_Calibrate.Name = "tb_HS4_Calibrate";
            this.tb_HS4_Calibrate.Size = new System.Drawing.Size(64, 20);
            this.tb_HS4_Calibrate.TabIndex = 109;
            // 
            // tb_HS3_Calibrate
            // 
            this.tb_HS3_Calibrate.Location = new System.Drawing.Point(708, 388);
            this.tb_HS3_Calibrate.Name = "tb_HS3_Calibrate";
            this.tb_HS3_Calibrate.Size = new System.Drawing.Size(64, 20);
            this.tb_HS3_Calibrate.TabIndex = 108;
            // 
            // tb_HS2_Calibrate
            // 
            this.tb_HS2_Calibrate.Location = new System.Drawing.Point(708, 362);
            this.tb_HS2_Calibrate.Name = "tb_HS2_Calibrate";
            this.tb_HS2_Calibrate.Size = new System.Drawing.Size(64, 20);
            this.tb_HS2_Calibrate.TabIndex = 107;
            // 
            // tb_HS1_Calibrate
            // 
            this.tb_HS1_Calibrate.Location = new System.Drawing.Point(708, 336);
            this.tb_HS1_Calibrate.Name = "tb_HS1_Calibrate";
            this.tb_HS1_Calibrate.Size = new System.Drawing.Size(64, 20);
            this.tb_HS1_Calibrate.TabIndex = 106;
            // 
            // lb_Humi_Calibrate
            // 
            this.lb_Humi_Calibrate.AutoSize = true;
            this.lb_Humi_Calibrate.Location = new System.Drawing.Point(714, 319);
            this.lb_Humi_Calibrate.Name = "lb_Humi_Calibrate";
            this.lb_Humi_Calibrate.Size = new System.Drawing.Size(47, 13);
            this.lb_Humi_Calibrate.TabIndex = 105;
            this.lb_Humi_Calibrate.Text = "Humidity";
            // 
            // lb_Calibrate
            // 
            this.lb_Calibrate.AutoSize = true;
            this.lb_Calibrate.Location = new System.Drawing.Point(671, 303);
            this.lb_Calibrate.Name = "lb_Calibrate";
            this.lb_Calibrate.Size = new System.Drawing.Size(48, 13);
            this.lb_Calibrate.TabIndex = 110;
            this.lb_Calibrate.Text = "Calibrate";
            // 
            // tb_IsConfig
            // 
            this.tb_IsConfig.Location = new System.Drawing.Point(182, 12);
            this.tb_IsConfig.Name = "tb_IsConfig";
            this.tb_IsConfig.Size = new System.Drawing.Size(44, 20);
            this.tb_IsConfig.TabIndex = 111;
            this.tb_IsConfig.Visible = false;
            this.tb_IsConfig.TextChanged += new System.EventHandler(this.tb_IsConfig_TextChanged);
            // 
            // tb_Search
            // 
            this.tb_Search.Location = new System.Drawing.Point(579, 12);
            this.tb_Search.Name = "tb_Search";
            this.tb_Search.Size = new System.Drawing.Size(205, 20);
            this.tb_Search.TabIndex = 113;
            this.tb_Search.TextChanged += new System.EventHandler(this.tb_Search_TextChanged);
            // 
            // lb_Search
            // 
            this.lb_Search.AutoSize = true;
            this.lb_Search.Location = new System.Drawing.Point(518, 16);
            this.lb_Search.Name = "lb_Search";
            this.lb_Search.Size = new System.Drawing.Size(41, 13);
            this.lb_Search.TabIndex = 112;
            this.lb_Search.Text = "Search";
            // 
            // rb_Celcius
            // 
            this.rb_Celcius.AutoSize = true;
            this.rb_Celcius.Location = new System.Drawing.Point(9, 24);
            this.rb_Celcius.Name = "rb_Celcius";
            this.rb_Celcius.Size = new System.Drawing.Size(59, 17);
            this.rb_Celcius.TabIndex = 114;
            this.rb_Celcius.Text = "Celcius";
            this.rb_Celcius.UseVisualStyleBackColor = true;
            // 
            // rb_farenheit
            // 
            this.rb_farenheit.AutoSize = true;
            this.rb_farenheit.Location = new System.Drawing.Point(92, 24);
            this.rb_farenheit.Name = "rb_farenheit";
            this.rb_farenheit.Size = new System.Drawing.Size(69, 17);
            this.rb_farenheit.TabIndex = 115;
            this.rb_farenheit.Text = "Farenheit";
            this.rb_farenheit.UseVisualStyleBackColor = true;
            // 
            // gb_Unit
            // 
            this.gb_Unit.Controls.Add(this.rb_Celcius);
            this.gb_Unit.Controls.Add(this.rb_farenheit);
            this.gb_Unit.Location = new System.Drawing.Point(15, 246);
            this.gb_Unit.Name = "gb_Unit";
            this.gb_Unit.Size = new System.Drawing.Size(195, 46);
            this.gb_Unit.TabIndex = 116;
            this.gb_Unit.TabStop = false;
            this.gb_Unit.Text = "Temperature Unit";
            // 
            // tb_SyncStatus
            // 
            this.tb_SyncStatus.Location = new System.Drawing.Point(620, 267);
            this.tb_SyncStatus.Name = "tb_SyncStatus";
            this.tb_SyncStatus.ReadOnly = true;
            this.tb_SyncStatus.Size = new System.Drawing.Size(98, 20);
            this.tb_SyncStatus.TabIndex = 118;
            // 
            // lb_Sync
            // 
            this.lb_Sync.AutoSize = true;
            this.lb_Sync.Location = new System.Drawing.Point(550, 270);
            this.lb_Sync.Name = "lb_Sync";
            this.lb_Sync.Size = new System.Drawing.Size(64, 13);
            this.lb_Sync.TabIndex = 117;
            this.lb_Sync.Text = "Sync Status";
            // 
            // bt_SyncNow
            // 
            this.bt_SyncNow.Location = new System.Drawing.Point(594, 453);
            this.bt_SyncNow.Name = "bt_SyncNow";
            this.bt_SyncNow.Size = new System.Drawing.Size(75, 23);
            this.bt_SyncNow.TabIndex = 119;
            this.bt_SyncNow.Text = "SYNC NOW";
            this.bt_SyncNow.UseVisualStyleBackColor = true;
            this.bt_SyncNow.Click += new System.EventHandler(this.bt_SyncNow_Click);
            // 
            // LoggerConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 493);
            this.Controls.Add(this.bt_SyncNow);
            this.Controls.Add(this.tb_SyncStatus);
            this.Controls.Add(this.lb_Sync);
            this.Controls.Add(this.gb_Unit);
            this.Controls.Add(this.tb_Search);
            this.Controls.Add(this.lb_Search);
            this.Controls.Add(this.tb_IsConfig);
            this.Controls.Add(this.lb_Calibrate);
            this.Controls.Add(this.tb_HS4_Calibrate);
            this.Controls.Add(this.tb_HS3_Calibrate);
            this.Controls.Add(this.tb_HS2_Calibrate);
            this.Controls.Add(this.tb_HS1_Calibrate);
            this.Controls.Add(this.lb_Humi_Calibrate);
            this.Controls.Add(this.tb_HS4_LL);
            this.Controls.Add(this.tb_HS4_UL);
            this.Controls.Add(this.tb_HS3_LL);
            this.Controls.Add(this.tb_HS3_UL);
            this.Controls.Add(this.tb_HS2_LL);
            this.Controls.Add(this.tb_HS2_UL);
            this.Controls.Add(this.tb_HS1_LL);
            this.Controls.Add(this.tb_HS1_UL);
            this.Controls.Add(this.lb_H_LowThreshold);
            this.Controls.Add(this.lb_H_UpThreshold);
            this.Controls.Add(this.lb_Humi_Threshold);
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
            this.Controls.Add(this.tb_TS4_Calibrate);
            this.Controls.Add(this.tb_TS3_Calibrate);
            this.Controls.Add(this.tb_TS2_Calibrate);
            this.Controls.Add(this.tb_TS1_Calibrate);
            this.Controls.Add(this.lb_Temp_Calibrate);
            this.Controls.Add(this.lb_Sensors);
            this.Controls.Add(this.tb_TS4_LL);
            this.Controls.Add(this.tb_TS4_UL);
            this.Controls.Add(this.tb_TS3_LL);
            this.Controls.Add(this.tb_TS3_UL);
            this.Controls.Add(this.tb_TS2_LL);
            this.Controls.Add(this.tb_TS2_UL);
            this.Controls.Add(this.tb_TS1_LL);
            this.Controls.Add(this.tb_TS1_UL);
            this.Controls.Add(this.tb_S4_Humidity);
            this.Controls.Add(this.tb_S4_Temp);
            this.Controls.Add(this.tb_S3_Humidity);
            this.Controls.Add(this.tb_S3_Temp);
            this.Controls.Add(this.tb_S2_Humidity);
            this.Controls.Add(this.tb_S2_Temp);
            this.Controls.Add(this.tb_S1_Humidity);
            this.Controls.Add(this.tb_S1_Temp);
            this.Controls.Add(this.lb_T_LowThreshold);
            this.Controls.Add(this.lb_T_UpThreshold);
            this.Controls.Add(this.lb_Temp_Threshold);
            this.Controls.Add(this.lb_Humidity);
            this.Controls.Add(this.lb_Temp);
            this.Controls.Add(this.lb_SetValue);
            this.Name = "LoggerConfig";
            this.Text = "Logger Configuration";
            this.Load += new System.EventHandler(this.LoggerConfig_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LoggerConfig)).EndInit();
            this.gb_Unit.ResumeLayout(false);
            this.gb_Unit.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.Label lb_Temp_Threshold;
        private System.Windows.Forms.Label lb_Humidity;
        private System.Windows.Forms.Label lb_Temp;
        private System.Windows.Forms.Label lb_SetValue;
        private System.Windows.Forms.Label lb_Sensors;
        private System.Windows.Forms.Label lb_Temp_Calibrate;
        private System.Windows.Forms.TextBox tb_TS1_Calibrate;
        private System.Windows.Forms.TextBox tb_TS2_Calibrate;
        private System.Windows.Forms.TextBox tb_TS3_Calibrate;
        private System.Windows.Forms.TextBox tb_TS4_Calibrate;
        private System.Windows.Forms.DataGridView dgv_LoggerConfig;
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
        private System.Windows.Forms.TextBox tb_S1_Name;
        private System.Windows.Forms.TextBox tb_S2_Name;
        private System.Windows.Forms.TextBox tb_S3_Name;
        private System.Windows.Forms.TextBox tb_S4_Name;
        private System.Windows.Forms.Label lb_LogID;
        private System.Windows.Forms.Label lb_LogType;
        private System.Windows.Forms.Label lb_NoOfSensors;
        private System.Windows.Forms.Label lb_Assign;
        private System.Windows.Forms.Label lb_Interval;
        private System.Windows.Forms.TextBox tb_LogID;
        private System.Windows.Forms.TextBox tb_NoOfSensors;
        private System.Windows.Forms.TextBox tb_LogType;
        private System.Windows.Forms.TextBox tb_Assign;
        private System.Windows.Forms.TextBox tb_Interval;
        private System.Windows.Forms.Button bt_Close;
        private System.Windows.Forms.Button bt_Clear;
        private System.Windows.Forms.Button bt_Delete;
        private System.Windows.Forms.Button bt_Update;
        private System.Windows.Forms.Button bt_Add;
        private System.Windows.Forms.Label lb_LoggerName;
        private System.Windows.Forms.ComboBox cmb_LoggerName;
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
        private System.Windows.Forms.Label lb_Humi_Threshold;
        private System.Windows.Forms.TextBox tb_HS4_Calibrate;
        private System.Windows.Forms.TextBox tb_HS3_Calibrate;
        private System.Windows.Forms.TextBox tb_HS2_Calibrate;
        private System.Windows.Forms.TextBox tb_HS1_Calibrate;
        private System.Windows.Forms.Label lb_Humi_Calibrate;
        private System.Windows.Forms.Label lb_Calibrate;
        private System.Windows.Forms.TextBox tb_IsConfig;
        private System.Windows.Forms.TextBox tb_Search;
        private System.Windows.Forms.Label lb_Search;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.RadioButton rb_Celcius;
        private System.Windows.Forms.RadioButton rb_farenheit;
        private System.Windows.Forms.GroupBox gb_Unit;
        private System.Windows.Forms.TextBox tb_SyncStatus;
        private System.Windows.Forms.Label lb_Sync;
        private System.Windows.Forms.Button bt_SyncNow;
    }
}