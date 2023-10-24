namespace Med_Preserve.Forms
{
    partial class LoggerMaster
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
            this.lb_LogID = new System.Windows.Forms.Label();
            this.dgv_LoggerMaster = new System.Windows.Forms.DataGridView();
            this.loggerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loggerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loggerTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noOfSensorsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assignToDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intervalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.s1NameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.s2NameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.s3NameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.s4NameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isActiveDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.createdDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loggerMasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.med_PreserveDataSet = new Med_Preserve.Med_PreserveDataSet();
            this.lb_LogType = new System.Windows.Forms.Label();
            this.lb_NoOfSensors = new System.Windows.Forms.Label();
            this.lb_AssignTo = new System.Windows.Forms.Label();
            this.lb_Interval = new System.Windows.Forms.Label();
            this.lb_S1_Name = new System.Windows.Forms.Label();
            this.lb_S2_Name = new System.Windows.Forms.Label();
            this.lb_S3_Name = new System.Windows.Forms.Label();
            this.lb_S4_Name = new System.Windows.Forms.Label();
            this.lb_SName = new System.Windows.Forms.Label();
            this.tb_S1_Name = new System.Windows.Forms.TextBox();
            this.tb_LogID = new System.Windows.Forms.TextBox();
            this.tb_Interval = new System.Windows.Forms.TextBox();
            this.tb_S2_Name = new System.Windows.Forms.TextBox();
            this.tb_S3_Name = new System.Windows.Forms.TextBox();
            this.tb_S4_Name = new System.Windows.Forms.TextBox();
            this.cmb_NoOfSensors = new System.Windows.Forms.ComboBox();
            this.rb_Temp = new System.Windows.Forms.RadioButton();
            this.rb_humidity = new System.Windows.Forms.RadioButton();
            this.rb_both = new System.Windows.Forms.RadioButton();
            this.cmb_AssignTo = new System.Windows.Forms.ComboBox();
            this.loggerMasterTableAdapter = new Med_Preserve.Med_PreserveDataSetTableAdapters.LoggerMasterTableAdapter();
            this.lb_CreatedDate = new System.Windows.Forms.Label();
            this.tb_CreatedDate = new System.Windows.Forms.TextBox();
            this.bt_Add = new System.Windows.Forms.Button();
            this.bt_Update = new System.Windows.Forms.Button();
            this.bt_Delete = new System.Windows.Forms.Button();
            this.bt_Clear = new System.Windows.Forms.Button();
            this.bt_Close = new System.Windows.Forms.Button();
            this.tb_LogName = new System.Windows.Forms.TextBox();
            this.lb_LogName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LoggerMaster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loggerMasterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.med_PreserveDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_LogID
            // 
            this.lb_LogID.AutoSize = true;
            this.lb_LogID.Location = new System.Drawing.Point(27, 181);
            this.lb_LogID.Name = "lb_LogID";
            this.lb_LogID.Size = new System.Drawing.Size(54, 13);
            this.lb_LogID.TabIndex = 1;
            this.lb_LogID.Text = "Logger ID";
            // 
            // dgv_LoggerMaster
            // 
            this.dgv_LoggerMaster.AllowUserToAddRows = false;
            this.dgv_LoggerMaster.AllowUserToDeleteRows = false;
            this.dgv_LoggerMaster.AutoGenerateColumns = false;
            this.dgv_LoggerMaster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_LoggerMaster.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.loggerIDDataGridViewTextBoxColumn,
            this.loggerNameDataGridViewTextBoxColumn,
            this.loggerTypeDataGridViewTextBoxColumn,
            this.noOfSensorsDataGridViewTextBoxColumn,
            this.assignToDataGridViewTextBoxColumn,
            this.intervalDataGridViewTextBoxColumn,
            this.s1NameDataGridViewTextBoxColumn,
            this.s2NameDataGridViewTextBoxColumn,
            this.s3NameDataGridViewTextBoxColumn,
            this.s4NameDataGridViewTextBoxColumn,
            this.isActiveDataGridViewCheckBoxColumn,
            this.createdDateDataGridViewTextBoxColumn});
            this.dgv_LoggerMaster.DataSource = this.loggerMasterBindingSource;
            this.dgv_LoggerMaster.Location = new System.Drawing.Point(12, 12);
            this.dgv_LoggerMaster.Name = "dgv_LoggerMaster";
            this.dgv_LoggerMaster.ReadOnly = true;
            this.dgv_LoggerMaster.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_LoggerMaster.Size = new System.Drawing.Size(776, 150);
            this.dgv_LoggerMaster.TabIndex = 2;
            this.dgv_LoggerMaster.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_LoggerMaster_CellClick);
            // 
            // loggerIDDataGridViewTextBoxColumn
            // 
            this.loggerIDDataGridViewTextBoxColumn.DataPropertyName = "LoggerID";
            this.loggerIDDataGridViewTextBoxColumn.HeaderText = "LoggerID";
            this.loggerIDDataGridViewTextBoxColumn.Name = "loggerIDDataGridViewTextBoxColumn";
            this.loggerIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // loggerNameDataGridViewTextBoxColumn
            // 
            this.loggerNameDataGridViewTextBoxColumn.DataPropertyName = "LoggerName";
            this.loggerNameDataGridViewTextBoxColumn.HeaderText = "LoggerName";
            this.loggerNameDataGridViewTextBoxColumn.Name = "loggerNameDataGridViewTextBoxColumn";
            this.loggerNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // loggerTypeDataGridViewTextBoxColumn
            // 
            this.loggerTypeDataGridViewTextBoxColumn.DataPropertyName = "LoggerType";
            this.loggerTypeDataGridViewTextBoxColumn.HeaderText = "LoggerType";
            this.loggerTypeDataGridViewTextBoxColumn.Name = "loggerTypeDataGridViewTextBoxColumn";
            this.loggerTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // noOfSensorsDataGridViewTextBoxColumn
            // 
            this.noOfSensorsDataGridViewTextBoxColumn.DataPropertyName = "NoOfSensors";
            this.noOfSensorsDataGridViewTextBoxColumn.HeaderText = "NoOfSensors";
            this.noOfSensorsDataGridViewTextBoxColumn.Name = "noOfSensorsDataGridViewTextBoxColumn";
            this.noOfSensorsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // assignToDataGridViewTextBoxColumn
            // 
            this.assignToDataGridViewTextBoxColumn.DataPropertyName = "AssignTo";
            this.assignToDataGridViewTextBoxColumn.HeaderText = "AssignTo";
            this.assignToDataGridViewTextBoxColumn.Name = "assignToDataGridViewTextBoxColumn";
            this.assignToDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // intervalDataGridViewTextBoxColumn
            // 
            this.intervalDataGridViewTextBoxColumn.DataPropertyName = "Interval";
            this.intervalDataGridViewTextBoxColumn.HeaderText = "Interval";
            this.intervalDataGridViewTextBoxColumn.Name = "intervalDataGridViewTextBoxColumn";
            this.intervalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // s1NameDataGridViewTextBoxColumn
            // 
            this.s1NameDataGridViewTextBoxColumn.DataPropertyName = "S1Name";
            this.s1NameDataGridViewTextBoxColumn.HeaderText = "S1Name";
            this.s1NameDataGridViewTextBoxColumn.Name = "s1NameDataGridViewTextBoxColumn";
            this.s1NameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // s2NameDataGridViewTextBoxColumn
            // 
            this.s2NameDataGridViewTextBoxColumn.DataPropertyName = "S2Name";
            this.s2NameDataGridViewTextBoxColumn.HeaderText = "S2Name";
            this.s2NameDataGridViewTextBoxColumn.Name = "s2NameDataGridViewTextBoxColumn";
            this.s2NameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // s3NameDataGridViewTextBoxColumn
            // 
            this.s3NameDataGridViewTextBoxColumn.DataPropertyName = "S3Name";
            this.s3NameDataGridViewTextBoxColumn.HeaderText = "S3Name";
            this.s3NameDataGridViewTextBoxColumn.Name = "s3NameDataGridViewTextBoxColumn";
            this.s3NameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // s4NameDataGridViewTextBoxColumn
            // 
            this.s4NameDataGridViewTextBoxColumn.DataPropertyName = "S4Name";
            this.s4NameDataGridViewTextBoxColumn.HeaderText = "S4Name";
            this.s4NameDataGridViewTextBoxColumn.Name = "s4NameDataGridViewTextBoxColumn";
            this.s4NameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // isActiveDataGridViewCheckBoxColumn
            // 
            this.isActiveDataGridViewCheckBoxColumn.DataPropertyName = "IsActive";
            this.isActiveDataGridViewCheckBoxColumn.HeaderText = "IsActive";
            this.isActiveDataGridViewCheckBoxColumn.Name = "isActiveDataGridViewCheckBoxColumn";
            this.isActiveDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // createdDateDataGridViewTextBoxColumn
            // 
            this.createdDateDataGridViewTextBoxColumn.DataPropertyName = "CreatedDate";
            this.createdDateDataGridViewTextBoxColumn.HeaderText = "CreatedDate";
            this.createdDateDataGridViewTextBoxColumn.Name = "createdDateDataGridViewTextBoxColumn";
            this.createdDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // loggerMasterBindingSource
            // 
            this.loggerMasterBindingSource.DataMember = "LoggerMaster";
            this.loggerMasterBindingSource.DataSource = this.med_PreserveDataSet;
            // 
            // med_PreserveDataSet
            // 
            this.med_PreserveDataSet.DataSetName = "Med_PreserveDataSet";
            this.med_PreserveDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lb_LogType
            // 
            this.lb_LogType.AutoSize = true;
            this.lb_LogType.Location = new System.Drawing.Point(382, 181);
            this.lb_LogType.Name = "lb_LogType";
            this.lb_LogType.Size = new System.Drawing.Size(67, 13);
            this.lb_LogType.TabIndex = 3;
            this.lb_LogType.Text = "Logger Type";
            // 
            // lb_NoOfSensors
            // 
            this.lb_NoOfSensors.AutoSize = true;
            this.lb_NoOfSensors.Location = new System.Drawing.Point(27, 239);
            this.lb_NoOfSensors.Name = "lb_NoOfSensors";
            this.lb_NoOfSensors.Size = new System.Drawing.Size(74, 13);
            this.lb_NoOfSensors.TabIndex = 4;
            this.lb_NoOfSensors.Text = "No of Sensors";
            // 
            // lb_AssignTo
            // 
            this.lb_AssignTo.AutoSize = true;
            this.lb_AssignTo.Location = new System.Drawing.Point(383, 230);
            this.lb_AssignTo.Name = "lb_AssignTo";
            this.lb_AssignTo.Size = new System.Drawing.Size(54, 13);
            this.lb_AssignTo.TabIndex = 5;
            this.lb_AssignTo.Text = "Assign To";
            // 
            // lb_Interval
            // 
            this.lb_Interval.AutoSize = true;
            this.lb_Interval.Location = new System.Drawing.Point(383, 254);
            this.lb_Interval.Name = "lb_Interval";
            this.lb_Interval.Size = new System.Drawing.Size(42, 13);
            this.lb_Interval.TabIndex = 6;
            this.lb_Interval.Text = "Interval";
            // 
            // lb_S1_Name
            // 
            this.lb_S1_Name.AutoSize = true;
            this.lb_S1_Name.Location = new System.Drawing.Point(135, 309);
            this.lb_S1_Name.Name = "lb_S1_Name";
            this.lb_S1_Name.Size = new System.Drawing.Size(49, 13);
            this.lb_S1_Name.TabIndex = 7;
            this.lb_S1_Name.Text = "Sensor 1";
            // 
            // lb_S2_Name
            // 
            this.lb_S2_Name.AutoSize = true;
            this.lb_S2_Name.Location = new System.Drawing.Point(263, 309);
            this.lb_S2_Name.Name = "lb_S2_Name";
            this.lb_S2_Name.Size = new System.Drawing.Size(49, 13);
            this.lb_S2_Name.TabIndex = 8;
            this.lb_S2_Name.Text = "Sensor 2";
            // 
            // lb_S3_Name
            // 
            this.lb_S3_Name.AutoSize = true;
            this.lb_S3_Name.Location = new System.Drawing.Point(388, 309);
            this.lb_S3_Name.Name = "lb_S3_Name";
            this.lb_S3_Name.Size = new System.Drawing.Size(49, 13);
            this.lb_S3_Name.TabIndex = 9;
            this.lb_S3_Name.Text = "Sensor 3";
            // 
            // lb_S4_Name
            // 
            this.lb_S4_Name.AutoSize = true;
            this.lb_S4_Name.Location = new System.Drawing.Point(513, 309);
            this.lb_S4_Name.Name = "lb_S4_Name";
            this.lb_S4_Name.Size = new System.Drawing.Size(49, 13);
            this.lb_S4_Name.TabIndex = 10;
            this.lb_S4_Name.Text = "Sensor 4";
            // 
            // lb_SName
            // 
            this.lb_SName.AutoSize = true;
            this.lb_SName.Location = new System.Drawing.Point(81, 337);
            this.lb_SName.Name = "lb_SName";
            this.lb_SName.Size = new System.Drawing.Size(35, 13);
            this.lb_SName.TabIndex = 11;
            this.lb_SName.Text = "Name";
            // 
            // tb_S1_Name
            // 
            this.tb_S1_Name.Location = new System.Drawing.Point(138, 334);
            this.tb_S1_Name.Name = "tb_S1_Name";
            this.tb_S1_Name.Size = new System.Drawing.Size(100, 20);
            this.tb_S1_Name.TabIndex = 14;
            // 
            // tb_LogID
            // 
            this.tb_LogID.Location = new System.Drawing.Point(111, 178);
            this.tb_LogID.Name = "tb_LogID";
            this.tb_LogID.Size = new System.Drawing.Size(118, 20);
            this.tb_LogID.TabIndex = 21;
            // 
            // tb_Interval
            // 
            this.tb_Interval.Location = new System.Drawing.Point(451, 254);
            this.tb_Interval.Name = "tb_Interval";
            this.tb_Interval.Size = new System.Drawing.Size(100, 20);
            this.tb_Interval.TabIndex = 23;
            // 
            // tb_S2_Name
            // 
            this.tb_S2_Name.Location = new System.Drawing.Point(266, 334);
            this.tb_S2_Name.Name = "tb_S2_Name";
            this.tb_S2_Name.Size = new System.Drawing.Size(100, 20);
            this.tb_S2_Name.TabIndex = 24;
            // 
            // tb_S3_Name
            // 
            this.tb_S3_Name.Location = new System.Drawing.Point(391, 334);
            this.tb_S3_Name.Name = "tb_S3_Name";
            this.tb_S3_Name.Size = new System.Drawing.Size(100, 20);
            this.tb_S3_Name.TabIndex = 25;
            // 
            // tb_S4_Name
            // 
            this.tb_S4_Name.Location = new System.Drawing.Point(516, 334);
            this.tb_S4_Name.Name = "tb_S4_Name";
            this.tb_S4_Name.Size = new System.Drawing.Size(100, 20);
            this.tb_S4_Name.TabIndex = 26;
            // 
            // cmb_NoOfSensors
            // 
            this.cmb_NoOfSensors.FormattingEnabled = true;
            this.cmb_NoOfSensors.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cmb_NoOfSensors.Location = new System.Drawing.Point(107, 236);
            this.cmb_NoOfSensors.Name = "cmb_NoOfSensors";
            this.cmb_NoOfSensors.Size = new System.Drawing.Size(77, 21);
            this.cmb_NoOfSensors.TabIndex = 43;
            // 
            // rb_Temp
            // 
            this.rb_Temp.AutoSize = true;
            this.rb_Temp.Location = new System.Drawing.Point(451, 176);
            this.rb_Temp.Name = "rb_Temp";
            this.rb_Temp.Size = new System.Drawing.Size(85, 17);
            this.rb_Temp.TabIndex = 44;
            this.rb_Temp.TabStop = true;
            this.rb_Temp.Text = "Temperature";
            this.rb_Temp.UseVisualStyleBackColor = true;
            // 
            // rb_humidity
            // 
            this.rb_humidity.AutoSize = true;
            this.rb_humidity.Location = new System.Drawing.Point(542, 176);
            this.rb_humidity.Name = "rb_humidity";
            this.rb_humidity.Size = new System.Drawing.Size(65, 17);
            this.rb_humidity.TabIndex = 45;
            this.rb_humidity.TabStop = true;
            this.rb_humidity.Text = "Humidity";
            this.rb_humidity.UseVisualStyleBackColor = true;
            // 
            // rb_both
            // 
            this.rb_both.AutoSize = true;
            this.rb_both.Location = new System.Drawing.Point(613, 176);
            this.rb_both.Name = "rb_both";
            this.rb_both.Size = new System.Drawing.Size(47, 17);
            this.rb_both.TabIndex = 46;
            this.rb_both.TabStop = true;
            this.rb_both.Text = "Both";
            this.rb_both.UseVisualStyleBackColor = true;
            // 
            // cmb_AssignTo
            // 
            this.cmb_AssignTo.FormattingEnabled = true;
            this.cmb_AssignTo.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cmb_AssignTo.Location = new System.Drawing.Point(451, 227);
            this.cmb_AssignTo.Name = "cmb_AssignTo";
            this.cmb_AssignTo.Size = new System.Drawing.Size(137, 21);
            this.cmb_AssignTo.TabIndex = 47;
            // 
            // loggerMasterTableAdapter
            // 
            this.loggerMasterTableAdapter.ClearBeforeFill = true;
            // 
            // lb_CreatedDate
            // 
            this.lb_CreatedDate.AutoSize = true;
            this.lb_CreatedDate.Location = new System.Drawing.Point(27, 271);
            this.lb_CreatedDate.Name = "lb_CreatedDate";
            this.lb_CreatedDate.Size = new System.Drawing.Size(70, 13);
            this.lb_CreatedDate.TabIndex = 48;
            this.lb_CreatedDate.Text = "Created Date";
            // 
            // tb_CreatedDate
            // 
            this.tb_CreatedDate.Enabled = false;
            this.tb_CreatedDate.Location = new System.Drawing.Point(107, 268);
            this.tb_CreatedDate.Name = "tb_CreatedDate";
            this.tb_CreatedDate.Size = new System.Drawing.Size(118, 20);
            this.tb_CreatedDate.TabIndex = 49;
            // 
            // bt_Add
            // 
            this.bt_Add.Location = new System.Drawing.Point(30, 370);
            this.bt_Add.Name = "bt_Add";
            this.bt_Add.Size = new System.Drawing.Size(75, 23);
            this.bt_Add.TabIndex = 50;
            this.bt_Add.Text = "ADD";
            this.bt_Add.UseVisualStyleBackColor = true;
            this.bt_Add.Click += new System.EventHandler(this.bt_Add_Click);
            // 
            // bt_Update
            // 
            this.bt_Update.Location = new System.Drawing.Point(138, 370);
            this.bt_Update.Name = "bt_Update";
            this.bt_Update.Size = new System.Drawing.Size(75, 23);
            this.bt_Update.TabIndex = 51;
            this.bt_Update.Text = "UPDATE";
            this.bt_Update.UseVisualStyleBackColor = true;
            // 
            // bt_Delete
            // 
            this.bt_Delete.Location = new System.Drawing.Point(253, 370);
            this.bt_Delete.Name = "bt_Delete";
            this.bt_Delete.Size = new System.Drawing.Size(75, 23);
            this.bt_Delete.TabIndex = 52;
            this.bt_Delete.Text = "DELETE";
            this.bt_Delete.UseVisualStyleBackColor = true;
            // 
            // bt_Clear
            // 
            this.bt_Clear.Location = new System.Drawing.Point(362, 370);
            this.bt_Clear.Name = "bt_Clear";
            this.bt_Clear.Size = new System.Drawing.Size(75, 23);
            this.bt_Clear.TabIndex = 53;
            this.bt_Clear.Text = "CLEAR";
            this.bt_Clear.UseVisualStyleBackColor = true;
            this.bt_Clear.Click += new System.EventHandler(this.bt_Clear_Click);
            // 
            // bt_Close
            // 
            this.bt_Close.Location = new System.Drawing.Point(461, 370);
            this.bt_Close.Name = "bt_Close";
            this.bt_Close.Size = new System.Drawing.Size(75, 23);
            this.bt_Close.TabIndex = 54;
            this.bt_Close.Text = "CLOSE";
            this.bt_Close.UseVisualStyleBackColor = true;
            // 
            // tb_LogName
            // 
            this.tb_LogName.Location = new System.Drawing.Point(111, 204);
            this.tb_LogName.Name = "tb_LogName";
            this.tb_LogName.Size = new System.Drawing.Size(118, 20);
            this.tb_LogName.TabIndex = 56;
            // 
            // lb_LogName
            // 
            this.lb_LogName.AutoSize = true;
            this.lb_LogName.Location = new System.Drawing.Point(27, 207);
            this.lb_LogName.Name = "lb_LogName";
            this.lb_LogName.Size = new System.Drawing.Size(71, 13);
            this.lb_LogName.TabIndex = 55;
            this.lb_LogName.Text = "Logger Name";
            // 
            // LoggerMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 414);
            this.Controls.Add(this.tb_LogName);
            this.Controls.Add(this.lb_LogName);
            this.Controls.Add(this.bt_Close);
            this.Controls.Add(this.bt_Clear);
            this.Controls.Add(this.bt_Delete);
            this.Controls.Add(this.bt_Update);
            this.Controls.Add(this.bt_Add);
            this.Controls.Add(this.tb_CreatedDate);
            this.Controls.Add(this.lb_CreatedDate);
            this.Controls.Add(this.cmb_AssignTo);
            this.Controls.Add(this.rb_both);
            this.Controls.Add(this.rb_humidity);
            this.Controls.Add(this.rb_Temp);
            this.Controls.Add(this.cmb_NoOfSensors);
            this.Controls.Add(this.tb_S4_Name);
            this.Controls.Add(this.tb_S3_Name);
            this.Controls.Add(this.tb_S2_Name);
            this.Controls.Add(this.tb_Interval);
            this.Controls.Add(this.tb_LogID);
            this.Controls.Add(this.lb_S3_Name);
            this.Controls.Add(this.lb_S2_Name);
            this.Controls.Add(this.lb_S1_Name);
            this.Controls.Add(this.tb_S1_Name);
            this.Controls.Add(this.lb_SName);
            this.Controls.Add(this.lb_S4_Name);
            this.Controls.Add(this.lb_Interval);
            this.Controls.Add(this.lb_AssignTo);
            this.Controls.Add(this.lb_NoOfSensors);
            this.Controls.Add(this.lb_LogType);
            this.Controls.Add(this.dgv_LoggerMaster);
            this.Controls.Add(this.lb_LogID);
            this.Name = "LoggerMaster";
            this.Text = "Logger Master";
            this.Load += new System.EventHandler(this.LoggerMaster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LoggerMaster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loggerMasterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.med_PreserveDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lb_LogID;
        private System.Windows.Forms.DataGridView dgv_LoggerMaster;
        private Med_PreserveDataSet med_PreserveDataSet;
        private Med_PreserveDataSetTableAdapters.LoggerMasterTableAdapter loggerMasterTableAdapter;
        private System.Windows.Forms.Label lb_LogType;
        private System.Windows.Forms.Label lb_NoOfSensors;
        private System.Windows.Forms.Label lb_AssignTo;
        private System.Windows.Forms.Label lb_Interval;
        private System.Windows.Forms.Label lb_S1_Name;
        private System.Windows.Forms.Label lb_S2_Name;
        private System.Windows.Forms.Label lb_S3_Name;
        private System.Windows.Forms.Label lb_S4_Name;
        private System.Windows.Forms.Label lb_SName;
        private System.Windows.Forms.TextBox tb_S1_Name;
        private System.Windows.Forms.TextBox tb_LogID;
        private System.Windows.Forms.TextBox tb_Interval;
        private System.Windows.Forms.TextBox tb_S2_Name;
        private System.Windows.Forms.TextBox tb_S3_Name;
        private System.Windows.Forms.TextBox tb_S4_Name;
        private System.Windows.Forms.ComboBox cmb_NoOfSensors;
        private System.Windows.Forms.RadioButton rb_Temp;
        private System.Windows.Forms.RadioButton rb_humidity;
        private System.Windows.Forms.RadioButton rb_both;
        private System.Windows.Forms.ComboBox cmb_AssignTo;
        private System.Windows.Forms.Label lb_CreatedDate;
        private System.Windows.Forms.TextBox tb_CreatedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn loggerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loggerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loggerTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noOfSensorsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn assignToDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn intervalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn s1NameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn s2NameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn s3NameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn s4NameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isActiveDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource loggerMasterBindingSource;
        private System.Windows.Forms.Button bt_Add;
        private System.Windows.Forms.Button bt_Update;
        private System.Windows.Forms.Button bt_Delete;
        private System.Windows.Forms.Button bt_Clear;
        private System.Windows.Forms.Button bt_Close;
        private System.Windows.Forms.TextBox tb_LogName;
        private System.Windows.Forms.Label lb_LogName;
    }
}