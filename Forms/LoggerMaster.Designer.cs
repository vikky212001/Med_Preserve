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
            this.lb_LogID = new System.Windows.Forms.Label();
            this.dgv_LoggerMaster = new System.Windows.Forms.DataGridView();
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
            this.lb_CreatedDate = new System.Windows.Forms.Label();
            this.tb_CreatedDate = new System.Windows.Forms.TextBox();
            this.bt_Add = new System.Windows.Forms.Button();
            this.bt_Update = new System.Windows.Forms.Button();
            this.bt_Delete = new System.Windows.Forms.Button();
            this.bt_Clear = new System.Windows.Forms.Button();
            this.bt_Close = new System.Windows.Forms.Button();
            this.tb_LogName = new System.Windows.Forms.TextBox();
            this.lb_LogName = new System.Windows.Forms.Label();
            this.cmb_IntervalType = new System.Windows.Forms.ComboBox();
            this.med_PreserveDataSet = new Med_Preserve.Med_PreserveDataSet();
            this.tb_Search = new System.Windows.Forms.TextBox();
            this.lb_Search = new System.Windows.Forms.Label();
            this.lb_Title = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LoggerMaster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.med_PreserveDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_LogID
            // 
            this.lb_LogID.AutoSize = true;
            this.lb_LogID.Font = new System.Drawing.Font("Comfortaa SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lb_LogID.Location = new System.Drawing.Point(99, 102);
            this.lb_LogID.Name = "lb_LogID";
            this.lb_LogID.Size = new System.Drawing.Size(77, 21);
            this.lb_LogID.TabIndex = 1;
            this.lb_LogID.Text = "Logger ID";
            this.lb_LogID.Visible = false;
            // 
            // dgv_LoggerMaster
            // 
            this.dgv_LoggerMaster.AllowUserToAddRows = false;
            this.dgv_LoggerMaster.AllowUserToDeleteRows = false;
            this.dgv_LoggerMaster.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgv_LoggerMaster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_LoggerMaster.Location = new System.Drawing.Point(95, 128);
            this.dgv_LoggerMaster.Name = "dgv_LoggerMaster";
            this.dgv_LoggerMaster.ReadOnly = true;
            this.dgv_LoggerMaster.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_LoggerMaster.Size = new System.Drawing.Size(776, 150);
            this.dgv_LoggerMaster.TabIndex = 2;
            this.dgv_LoggerMaster.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_LoggerMaster_CellClick);
            // 
            // lb_LogType
            // 
            this.lb_LogType.AutoSize = true;
            this.lb_LogType.Font = new System.Drawing.Font("Comfortaa SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lb_LogType.Location = new System.Drawing.Point(452, 295);
            this.lb_LogType.Name = "lb_LogType";
            this.lb_LogType.Size = new System.Drawing.Size(95, 21);
            this.lb_LogType.TabIndex = 3;
            this.lb_LogType.Text = "Logger Type";
            // 
            // lb_NoOfSensors
            // 
            this.lb_NoOfSensors.AutoSize = true;
            this.lb_NoOfSensors.Font = new System.Drawing.Font("Comfortaa SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lb_NoOfSensors.Location = new System.Drawing.Point(168, 330);
            this.lb_NoOfSensors.Name = "lb_NoOfSensors";
            this.lb_NoOfSensors.Size = new System.Drawing.Size(107, 21);
            this.lb_NoOfSensors.TabIndex = 4;
            this.lb_NoOfSensors.Text = "No of Sensors";
            // 
            // lb_AssignTo
            // 
            this.lb_AssignTo.AutoSize = true;
            this.lb_AssignTo.Font = new System.Drawing.Font("Comfortaa SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lb_AssignTo.Location = new System.Drawing.Point(513, 326);
            this.lb_AssignTo.Name = "lb_AssignTo";
            this.lb_AssignTo.Size = new System.Drawing.Size(75, 21);
            this.lb_AssignTo.TabIndex = 5;
            this.lb_AssignTo.Text = "Assign To";
            // 
            // lb_Interval
            // 
            this.lb_Interval.AutoSize = true;
            this.lb_Interval.Font = new System.Drawing.Font("Comfortaa SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lb_Interval.Location = new System.Drawing.Point(526, 357);
            this.lb_Interval.Name = "lb_Interval";
            this.lb_Interval.Size = new System.Drawing.Size(62, 21);
            this.lb_Interval.TabIndex = 6;
            this.lb_Interval.Text = "Interval";
            // 
            // lb_S1_Name
            // 
            this.lb_S1_Name.AutoSize = true;
            this.lb_S1_Name.Font = new System.Drawing.Font("Comfortaa SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lb_S1_Name.Location = new System.Drawing.Point(241, 407);
            this.lb_S1_Name.Name = "lb_S1_Name";
            this.lb_S1_Name.Size = new System.Drawing.Size(67, 21);
            this.lb_S1_Name.TabIndex = 7;
            this.lb_S1_Name.Text = "Sensor 1";
            // 
            // lb_S2_Name
            // 
            this.lb_S2_Name.AutoSize = true;
            this.lb_S2_Name.Font = new System.Drawing.Font("Comfortaa SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lb_S2_Name.Location = new System.Drawing.Point(367, 407);
            this.lb_S2_Name.Name = "lb_S2_Name";
            this.lb_S2_Name.Size = new System.Drawing.Size(70, 21);
            this.lb_S2_Name.TabIndex = 8;
            this.lb_S2_Name.Text = "Sensor 2";
            // 
            // lb_S3_Name
            // 
            this.lb_S3_Name.AutoSize = true;
            this.lb_S3_Name.Font = new System.Drawing.Font("Comfortaa SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lb_S3_Name.Location = new System.Drawing.Point(493, 407);
            this.lb_S3_Name.Name = "lb_S3_Name";
            this.lb_S3_Name.Size = new System.Drawing.Size(70, 21);
            this.lb_S3_Name.TabIndex = 9;
            this.lb_S3_Name.Text = "Sensor 3";
            // 
            // lb_S4_Name
            // 
            this.lb_S4_Name.AutoSize = true;
            this.lb_S4_Name.Font = new System.Drawing.Font("Comfortaa SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lb_S4_Name.Location = new System.Drawing.Point(619, 407);
            this.lb_S4_Name.Name = "lb_S4_Name";
            this.lb_S4_Name.Size = new System.Drawing.Size(70, 21);
            this.lb_S4_Name.TabIndex = 10;
            this.lb_S4_Name.Text = "Sensor 4";
            // 
            // lb_SName
            // 
            this.lb_SName.AutoSize = true;
            this.lb_SName.Font = new System.Drawing.Font("Comfortaa SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lb_SName.Location = new System.Drawing.Point(178, 427);
            this.lb_SName.Name = "lb_SName";
            this.lb_SName.Size = new System.Drawing.Size(50, 21);
            this.lb_SName.TabIndex = 11;
            this.lb_SName.Text = "Name";
            // 
            // tb_S1_Name
            // 
            this.tb_S1_Name.Font = new System.Drawing.Font("Comfortaa SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tb_S1_Name.Location = new System.Drawing.Point(244, 428);
            this.tb_S1_Name.Name = "tb_S1_Name";
            this.tb_S1_Name.Size = new System.Drawing.Size(100, 22);
            this.tb_S1_Name.TabIndex = 14;
            // 
            // tb_LogID
            // 
            this.tb_LogID.Font = new System.Drawing.Font("Comfortaa SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tb_LogID.Location = new System.Drawing.Point(182, 102);
            this.tb_LogID.Name = "tb_LogID";
            this.tb_LogID.Size = new System.Drawing.Size(118, 22);
            this.tb_LogID.TabIndex = 21;
            this.tb_LogID.Visible = false;
            // 
            // tb_Interval
            // 
            this.tb_Interval.Font = new System.Drawing.Font("Comfortaa SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tb_Interval.Location = new System.Drawing.Point(602, 360);
            this.tb_Interval.Name = "tb_Interval";
            this.tb_Interval.Size = new System.Drawing.Size(85, 22);
            this.tb_Interval.TabIndex = 23;
            // 
            // tb_S2_Name
            // 
            this.tb_S2_Name.Font = new System.Drawing.Font("Comfortaa SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tb_S2_Name.Location = new System.Drawing.Point(370, 428);
            this.tb_S2_Name.Name = "tb_S2_Name";
            this.tb_S2_Name.Size = new System.Drawing.Size(100, 22);
            this.tb_S2_Name.TabIndex = 24;
            // 
            // tb_S3_Name
            // 
            this.tb_S3_Name.Font = new System.Drawing.Font("Comfortaa SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tb_S3_Name.Location = new System.Drawing.Point(496, 428);
            this.tb_S3_Name.Name = "tb_S3_Name";
            this.tb_S3_Name.Size = new System.Drawing.Size(100, 22);
            this.tb_S3_Name.TabIndex = 25;
            // 
            // tb_S4_Name
            // 
            this.tb_S4_Name.Font = new System.Drawing.Font("Comfortaa SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tb_S4_Name.Location = new System.Drawing.Point(622, 428);
            this.tb_S4_Name.Name = "tb_S4_Name";
            this.tb_S4_Name.Size = new System.Drawing.Size(100, 22);
            this.tb_S4_Name.TabIndex = 26;
            // 
            // cmb_NoOfSensors
            // 
            this.cmb_NoOfSensors.Font = new System.Drawing.Font("Comfortaa SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.cmb_NoOfSensors.FormattingEnabled = true;
            this.cmb_NoOfSensors.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cmb_NoOfSensors.Location = new System.Drawing.Point(281, 327);
            this.cmb_NoOfSensors.Name = "cmb_NoOfSensors";
            this.cmb_NoOfSensors.Size = new System.Drawing.Size(77, 29);
            this.cmb_NoOfSensors.TabIndex = 43;
            this.cmb_NoOfSensors.TextChanged += new System.EventHandler(this.cmb_NoOfSensors_TextChanged);
            // 
            // rb_Temp
            // 
            this.rb_Temp.AutoSize = true;
            this.rb_Temp.Font = new System.Drawing.Font("Comfortaa SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.rb_Temp.Location = new System.Drawing.Point(561, 293);
            this.rb_Temp.Name = "rb_Temp";
            this.rb_Temp.Size = new System.Drawing.Size(113, 25);
            this.rb_Temp.TabIndex = 44;
            this.rb_Temp.TabStop = true;
            this.rb_Temp.Text = "Temperature";
            this.rb_Temp.UseVisualStyleBackColor = true;
            // 
            // rb_humidity
            // 
            this.rb_humidity.AutoSize = true;
            this.rb_humidity.Font = new System.Drawing.Font("Comfortaa SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.rb_humidity.Location = new System.Drawing.Point(680, 293);
            this.rb_humidity.Name = "rb_humidity";
            this.rb_humidity.Size = new System.Drawing.Size(89, 25);
            this.rb_humidity.TabIndex = 45;
            this.rb_humidity.TabStop = true;
            this.rb_humidity.Text = "Humidity";
            this.rb_humidity.UseVisualStyleBackColor = true;
            this.rb_humidity.CheckedChanged += new System.EventHandler(this.rb_humidity_CheckedChanged);
            // 
            // rb_both
            // 
            this.rb_both.AutoSize = true;
            this.rb_both.Font = new System.Drawing.Font("Comfortaa SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.rb_both.Location = new System.Drawing.Point(775, 293);
            this.rb_both.Name = "rb_both";
            this.rb_both.Size = new System.Drawing.Size(60, 25);
            this.rb_both.TabIndex = 46;
            this.rb_both.TabStop = true;
            this.rb_both.Text = "Both";
            this.rb_both.UseVisualStyleBackColor = true;
            // 
            // cmb_AssignTo
            // 
            this.cmb_AssignTo.Font = new System.Drawing.Font("Comfortaa SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.cmb_AssignTo.FormattingEnabled = true;
            this.cmb_AssignTo.Location = new System.Drawing.Point(602, 323);
            this.cmb_AssignTo.Name = "cmb_AssignTo";
            this.cmb_AssignTo.Size = new System.Drawing.Size(137, 29);
            this.cmb_AssignTo.TabIndex = 47;
            // 
            // lb_CreatedDate
            // 
            this.lb_CreatedDate.AutoSize = true;
            this.lb_CreatedDate.Font = new System.Drawing.Font("Comfortaa SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lb_CreatedDate.Location = new System.Drawing.Point(175, 360);
            this.lb_CreatedDate.Name = "lb_CreatedDate";
            this.lb_CreatedDate.Size = new System.Drawing.Size(100, 21);
            this.lb_CreatedDate.TabIndex = 48;
            this.lb_CreatedDate.Text = "Created Date";
            // 
            // tb_CreatedDate
            // 
            this.tb_CreatedDate.Enabled = false;
            this.tb_CreatedDate.Font = new System.Drawing.Font("Comfortaa SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tb_CreatedDate.Location = new System.Drawing.Point(281, 362);
            this.tb_CreatedDate.Name = "tb_CreatedDate";
            this.tb_CreatedDate.Size = new System.Drawing.Size(118, 22);
            this.tb_CreatedDate.TabIndex = 49;
            // 
            // bt_Add
            // 
            this.bt_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Add.Font = new System.Drawing.Font("Comfortaa SemiBold", 8.999999F, System.Drawing.FontStyle.Bold);
            this.bt_Add.Location = new System.Drawing.Point(233, 464);
            this.bt_Add.Name = "bt_Add";
            this.bt_Add.Size = new System.Drawing.Size(70, 30);
            this.bt_Add.TabIndex = 50;
            this.bt_Add.Text = "ADD";
            this.bt_Add.UseVisualStyleBackColor = true;
            this.bt_Add.Click += new System.EventHandler(this.bt_Add_Click);
            // 
            // bt_Update
            // 
            this.bt_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Update.Font = new System.Drawing.Font("Comfortaa SemiBold", 8.999999F, System.Drawing.FontStyle.Bold);
            this.bt_Update.Location = new System.Drawing.Point(340, 464);
            this.bt_Update.Name = "bt_Update";
            this.bt_Update.Size = new System.Drawing.Size(70, 30);
            this.bt_Update.TabIndex = 51;
            this.bt_Update.Text = "UPDATE";
            this.bt_Update.UseVisualStyleBackColor = true;
            this.bt_Update.Click += new System.EventHandler(this.bt_Update_Click);
            // 
            // bt_Delete
            // 
            this.bt_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Delete.Font = new System.Drawing.Font("Comfortaa SemiBold", 8.999999F, System.Drawing.FontStyle.Bold);
            this.bt_Delete.Location = new System.Drawing.Point(447, 464);
            this.bt_Delete.Name = "bt_Delete";
            this.bt_Delete.Size = new System.Drawing.Size(70, 30);
            this.bt_Delete.TabIndex = 52;
            this.bt_Delete.Text = "DELETE";
            this.bt_Delete.UseVisualStyleBackColor = true;
            this.bt_Delete.Click += new System.EventHandler(this.bt_Delete_Click);
            // 
            // bt_Clear
            // 
            this.bt_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Clear.Font = new System.Drawing.Font("Comfortaa SemiBold", 8.999999F, System.Drawing.FontStyle.Bold);
            this.bt_Clear.Location = new System.Drawing.Point(554, 464);
            this.bt_Clear.Name = "bt_Clear";
            this.bt_Clear.Size = new System.Drawing.Size(70, 30);
            this.bt_Clear.TabIndex = 53;
            this.bt_Clear.Text = "CLEAR";
            this.bt_Clear.UseVisualStyleBackColor = true;
            this.bt_Clear.Click += new System.EventHandler(this.bt_Clear_Click);
            // 
            // bt_Close
            // 
            this.bt_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Close.Font = new System.Drawing.Font("Comfortaa SemiBold", 8.999999F, System.Drawing.FontStyle.Bold);
            this.bt_Close.Location = new System.Drawing.Point(661, 464);
            this.bt_Close.Name = "bt_Close";
            this.bt_Close.Size = new System.Drawing.Size(70, 30);
            this.bt_Close.TabIndex = 54;
            this.bt_Close.Text = "CLOSE";
            this.bt_Close.UseVisualStyleBackColor = true;
            this.bt_Close.Click += new System.EventHandler(this.bt_Close_Click);
            // 
            // tb_LogName
            // 
            this.tb_LogName.Font = new System.Drawing.Font("Comfortaa SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tb_LogName.Location = new System.Drawing.Point(240, 299);
            this.tb_LogName.Name = "tb_LogName";
            this.tb_LogName.Size = new System.Drawing.Size(118, 22);
            this.tb_LogName.TabIndex = 56;
            // 
            // lb_LogName
            // 
            this.lb_LogName.AutoSize = true;
            this.lb_LogName.Font = new System.Drawing.Font("Comfortaa SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lb_LogName.Location = new System.Drawing.Point(131, 299);
            this.lb_LogName.Name = "lb_LogName";
            this.lb_LogName.Size = new System.Drawing.Size(103, 21);
            this.lb_LogName.TabIndex = 55;
            this.lb_LogName.Text = "Logger Name";
            // 
            // cmb_IntervalType
            // 
            this.cmb_IntervalType.Font = new System.Drawing.Font("Comfortaa SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.cmb_IntervalType.FormattingEnabled = true;
            this.cmb_IntervalType.Items.AddRange(new object[] {
            "min",
            "sec"});
            this.cmb_IntervalType.Location = new System.Drawing.Point(693, 358);
            this.cmb_IntervalType.Name = "cmb_IntervalType";
            this.cmb_IntervalType.Size = new System.Drawing.Size(64, 29);
            this.cmb_IntervalType.TabIndex = 57;
            this.cmb_IntervalType.TextChanged += new System.EventHandler(this.cmb_IntervalType_TextChanged);
            // 
            // med_PreserveDataSet
            // 
            this.med_PreserveDataSet.DataSetName = "Med_PreserveDataSet";
            this.med_PreserveDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_Search
            // 
            this.tb_Search.Font = new System.Drawing.Font("Comfortaa SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tb_Search.Location = new System.Drawing.Point(666, 100);
            this.tb_Search.Name = "tb_Search";
            this.tb_Search.Size = new System.Drawing.Size(205, 22);
            this.tb_Search.TabIndex = 115;
            this.tb_Search.TextChanged += new System.EventHandler(this.tb_Search_TextChanged);
            // 
            // lb_Search
            // 
            this.lb_Search.AutoSize = true;
            this.lb_Search.Font = new System.Drawing.Font("Comfortaa SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lb_Search.Location = new System.Drawing.Point(606, 100);
            this.lb_Search.Name = "lb_Search";
            this.lb_Search.Size = new System.Drawing.Size(58, 21);
            this.lb_Search.TabIndex = 114;
            this.lb_Search.Text = "Search";
            // 
            // lb_Title
            // 
            this.lb_Title.AutoSize = true;
            this.lb_Title.Font = new System.Drawing.Font("Comfortaa", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Title.Location = new System.Drawing.Point(366, 15);
            this.lb_Title.Name = "lb_Title";
            this.lb_Title.Size = new System.Drawing.Size(234, 39);
            this.lb_Title.TabIndex = 125;
            this.lb_Title.Text = "LOGGER MASTER";
            // 
            // LoggerMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(966, 633);
            this.Controls.Add(this.lb_Title);
            this.Controls.Add(this.tb_Search);
            this.Controls.Add(this.lb_Search);
            this.Controls.Add(this.cmb_IntervalType);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoggerMaster";
            this.Text = "Logger Master";
            this.Load += new System.EventHandler(this.LoggerMaster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LoggerMaster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.med_PreserveDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lb_LogID;
        private System.Windows.Forms.DataGridView dgv_LoggerMaster;
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
        private System.Windows.Forms.Button bt_Add;
        private System.Windows.Forms.Button bt_Update;
        private System.Windows.Forms.Button bt_Delete;
        private System.Windows.Forms.Button bt_Clear;
        private System.Windows.Forms.Button bt_Close;
        private System.Windows.Forms.TextBox tb_LogName;
        private System.Windows.Forms.Label lb_LogName;
        private System.Windows.Forms.ComboBox cmb_IntervalType;
        private Med_PreserveDataSet med_PreserveDataSet;
        private System.Windows.Forms.TextBox tb_Search;
        private System.Windows.Forms.Label lb_Search;
        private System.Windows.Forms.Label lb_Title;
    }
}