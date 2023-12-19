namespace Med_Preserve.Forms
{
    partial class RealTimeData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RealTimeData));
            this.gb_S4 = new System.Windows.Forms.GroupBox();
            this.lb_S4_Humi = new System.Windows.Forms.Label();
            this.lb_S4_Temp = new System.Windows.Forms.Label();
            this.tb_S4_Temp = new System.Windows.Forms.TextBox();
            this.tb_S4_Humi = new System.Windows.Forms.TextBox();
            this.gb_S3 = new System.Windows.Forms.GroupBox();
            this.lb_S3_Humi = new System.Windows.Forms.Label();
            this.lb_S3_Temp = new System.Windows.Forms.Label();
            this.tb_S3_Temp = new System.Windows.Forms.TextBox();
            this.tb_S3_Humi = new System.Windows.Forms.TextBox();
            this.gb_S2 = new System.Windows.Forms.GroupBox();
            this.lb_S2_Humi = new System.Windows.Forms.Label();
            this.lb_S2_Temp = new System.Windows.Forms.Label();
            this.tb_S2_Humi = new System.Windows.Forms.TextBox();
            this.tb_S2_Temp = new System.Windows.Forms.TextBox();
            this.gb_S1 = new System.Windows.Forms.GroupBox();
            this.lb_S1_Humi = new System.Windows.Forms.Label();
            this.lb_S1_Temp = new System.Windows.Forms.Label();
            this.tb_S1_Temp = new System.Windows.Forms.TextBox();
            this.tb_S1_Humi = new System.Windows.Forms.TextBox();
            this.lb_LogName = new System.Windows.Forms.Label();
            this.cmb_LogName = new System.Windows.Forms.ComboBox();
            this.tb_Date = new System.Windows.Forms.TextBox();
            this.tb_Time = new System.Windows.Forms.TextBox();
            this.tb_NoOfSensors = new System.Windows.Forms.TextBox();
            this.tb_LogType = new System.Windows.Forms.TextBox();
            this.tb_T4UL = new System.Windows.Forms.TextBox();
            this.tb_H4UL = new System.Windows.Forms.TextBox();
            this.tb_H4LL = new System.Windows.Forms.TextBox();
            this.tb_H4SV = new System.Windows.Forms.TextBox();
            this.tb_T4LL = new System.Windows.Forms.TextBox();
            this.tb_T4SV = new System.Windows.Forms.TextBox();
            this.tb_T3UL = new System.Windows.Forms.TextBox();
            this.tb_H3UL = new System.Windows.Forms.TextBox();
            this.tb_H3LL = new System.Windows.Forms.TextBox();
            this.tb_H3SV = new System.Windows.Forms.TextBox();
            this.tb_T3LL = new System.Windows.Forms.TextBox();
            this.tb_T3SV = new System.Windows.Forms.TextBox();
            this.tb_T2UL = new System.Windows.Forms.TextBox();
            this.tb_H2UL = new System.Windows.Forms.TextBox();
            this.tb_H2LL = new System.Windows.Forms.TextBox();
            this.tb_H2SV = new System.Windows.Forms.TextBox();
            this.tb_T2LL = new System.Windows.Forms.TextBox();
            this.tb_T2SV = new System.Windows.Forms.TextBox();
            this.tb_T1UL = new System.Windows.Forms.TextBox();
            this.tb_H1UL = new System.Windows.Forms.TextBox();
            this.tb_H1LL = new System.Windows.Forms.TextBox();
            this.tb_H1SV = new System.Windows.Forms.TextBox();
            this.tb_T1LL = new System.Windows.Forms.TextBox();
            this.tb_T1SV = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.cartesianTemp = new LiveCharts.WinForms.CartesianChart();
            this.cartesianHumi = new LiveCharts.WinForms.CartesianChart();
            this.lb_date = new System.Windows.Forms.Label();
            this.lb_time = new System.Windows.Forms.Label();
            this.lb_Title = new System.Windows.Forms.Label();
            this.gb_S4.SuspendLayout();
            this.gb_S3.SuspendLayout();
            this.gb_S2.SuspendLayout();
            this.gb_S1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_S4
            // 
            this.gb_S4.BackColor = System.Drawing.Color.White;
            this.gb_S4.Controls.Add(this.lb_S4_Humi);
            this.gb_S4.Controls.Add(this.lb_S4_Temp);
            this.gb_S4.Controls.Add(this.tb_S4_Temp);
            this.gb_S4.Controls.Add(this.tb_S4_Humi);
            this.gb_S4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gb_S4.Font = new System.Drawing.Font("Comfortaa", 9.75F, System.Drawing.FontStyle.Bold);
            this.gb_S4.Location = new System.Drawing.Point(35, 521);
            this.gb_S4.Name = "gb_S4";
            this.gb_S4.Size = new System.Drawing.Size(200, 75);
            this.gb_S4.TabIndex = 24;
            this.gb_S4.TabStop = false;
            this.gb_S4.Text = "Sensor 4";
            // 
            // lb_S4_Humi
            // 
            this.lb_S4_Humi.AutoSize = true;
            this.lb_S4_Humi.Font = new System.Drawing.Font("Comfortaa SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.lb_S4_Humi.Location = new System.Drawing.Point(26, 45);
            this.lb_S4_Humi.Name = "lb_S4_Humi";
            this.lb_S4_Humi.Size = new System.Drawing.Size(66, 19);
            this.lb_S4_Humi.TabIndex = 8;
            this.lb_S4_Humi.Text = "Humidity";
            // 
            // lb_S4_Temp
            // 
            this.lb_S4_Temp.AutoSize = true;
            this.lb_S4_Temp.Font = new System.Drawing.Font("Comfortaa SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.lb_S4_Temp.Location = new System.Drawing.Point(17, 21);
            this.lb_S4_Temp.Name = "lb_S4_Temp";
            this.lb_S4_Temp.Size = new System.Drawing.Size(88, 19);
            this.lb_S4_Temp.TabIndex = 7;
            this.lb_S4_Temp.Text = "Temperature";
            // 
            // tb_S4_Temp
            // 
            this.tb_S4_Temp.Enabled = false;
            this.tb_S4_Temp.Location = new System.Drawing.Point(111, 19);
            this.tb_S4_Temp.Name = "tb_S4_Temp";
            this.tb_S4_Temp.Size = new System.Drawing.Size(69, 22);
            this.tb_S4_Temp.TabIndex = 11;
            // 
            // tb_S4_Humi
            // 
            this.tb_S4_Humi.Enabled = false;
            this.tb_S4_Humi.Location = new System.Drawing.Point(111, 45);
            this.tb_S4_Humi.Name = "tb_S4_Humi";
            this.tb_S4_Humi.Size = new System.Drawing.Size(69, 22);
            this.tb_S4_Humi.TabIndex = 12;
            // 
            // gb_S3
            // 
            this.gb_S3.BackColor = System.Drawing.Color.White;
            this.gb_S3.Controls.Add(this.lb_S3_Humi);
            this.gb_S3.Controls.Add(this.lb_S3_Temp);
            this.gb_S3.Controls.Add(this.tb_S3_Temp);
            this.gb_S3.Controls.Add(this.tb_S3_Humi);
            this.gb_S3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gb_S3.Font = new System.Drawing.Font("Comfortaa", 9.75F, System.Drawing.FontStyle.Bold);
            this.gb_S3.Location = new System.Drawing.Point(35, 428);
            this.gb_S3.Name = "gb_S3";
            this.gb_S3.Size = new System.Drawing.Size(200, 75);
            this.gb_S3.TabIndex = 25;
            this.gb_S3.TabStop = false;
            this.gb_S3.Text = "Sensor 3";
            // 
            // lb_S3_Humi
            // 
            this.lb_S3_Humi.AutoSize = true;
            this.lb_S3_Humi.Font = new System.Drawing.Font("Comfortaa SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.lb_S3_Humi.Location = new System.Drawing.Point(25, 44);
            this.lb_S3_Humi.Name = "lb_S3_Humi";
            this.lb_S3_Humi.Size = new System.Drawing.Size(66, 19);
            this.lb_S3_Humi.TabIndex = 8;
            this.lb_S3_Humi.Text = "Humidity";
            // 
            // lb_S3_Temp
            // 
            this.lb_S3_Temp.AutoSize = true;
            this.lb_S3_Temp.Font = new System.Drawing.Font("Comfortaa SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.lb_S3_Temp.Location = new System.Drawing.Point(17, 21);
            this.lb_S3_Temp.Name = "lb_S3_Temp";
            this.lb_S3_Temp.Size = new System.Drawing.Size(88, 19);
            this.lb_S3_Temp.TabIndex = 7;
            this.lb_S3_Temp.Text = "Temperature";
            // 
            // tb_S3_Temp
            // 
            this.tb_S3_Temp.Enabled = false;
            this.tb_S3_Temp.Location = new System.Drawing.Point(111, 19);
            this.tb_S3_Temp.Name = "tb_S3_Temp";
            this.tb_S3_Temp.Size = new System.Drawing.Size(69, 22);
            this.tb_S3_Temp.TabIndex = 9;
            // 
            // tb_S3_Humi
            // 
            this.tb_S3_Humi.Enabled = false;
            this.tb_S3_Humi.Location = new System.Drawing.Point(111, 46);
            this.tb_S3_Humi.Name = "tb_S3_Humi";
            this.tb_S3_Humi.Size = new System.Drawing.Size(69, 22);
            this.tb_S3_Humi.TabIndex = 10;
            // 
            // gb_S2
            // 
            this.gb_S2.BackColor = System.Drawing.Color.White;
            this.gb_S2.Controls.Add(this.lb_S2_Humi);
            this.gb_S2.Controls.Add(this.lb_S2_Temp);
            this.gb_S2.Controls.Add(this.tb_S2_Humi);
            this.gb_S2.Controls.Add(this.tb_S2_Temp);
            this.gb_S2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gb_S2.Font = new System.Drawing.Font("Comfortaa", 9.75F, System.Drawing.FontStyle.Bold);
            this.gb_S2.Location = new System.Drawing.Point(35, 333);
            this.gb_S2.Name = "gb_S2";
            this.gb_S2.Size = new System.Drawing.Size(200, 75);
            this.gb_S2.TabIndex = 23;
            this.gb_S2.TabStop = false;
            this.gb_S2.Text = "Sensor 2";
            // 
            // lb_S2_Humi
            // 
            this.lb_S2_Humi.AutoSize = true;
            this.lb_S2_Humi.Font = new System.Drawing.Font("Comfortaa SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.lb_S2_Humi.Location = new System.Drawing.Point(26, 49);
            this.lb_S2_Humi.Name = "lb_S2_Humi";
            this.lb_S2_Humi.Size = new System.Drawing.Size(66, 19);
            this.lb_S2_Humi.TabIndex = 8;
            this.lb_S2_Humi.Text = "Humidity";
            // 
            // lb_S2_Temp
            // 
            this.lb_S2_Temp.AutoSize = true;
            this.lb_S2_Temp.Font = new System.Drawing.Font("Comfortaa SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.lb_S2_Temp.Location = new System.Drawing.Point(17, 23);
            this.lb_S2_Temp.Name = "lb_S2_Temp";
            this.lb_S2_Temp.Size = new System.Drawing.Size(88, 19);
            this.lb_S2_Temp.TabIndex = 7;
            this.lb_S2_Temp.Text = "Temperature";
            // 
            // tb_S2_Humi
            // 
            this.tb_S2_Humi.Enabled = false;
            this.tb_S2_Humi.Location = new System.Drawing.Point(111, 49);
            this.tb_S2_Humi.Name = "tb_S2_Humi";
            this.tb_S2_Humi.Size = new System.Drawing.Size(69, 22);
            this.tb_S2_Humi.TabIndex = 8;
            // 
            // tb_S2_Temp
            // 
            this.tb_S2_Temp.Enabled = false;
            this.tb_S2_Temp.Location = new System.Drawing.Point(111, 23);
            this.tb_S2_Temp.Name = "tb_S2_Temp";
            this.tb_S2_Temp.Size = new System.Drawing.Size(69, 22);
            this.tb_S2_Temp.TabIndex = 7;
            // 
            // gb_S1
            // 
            this.gb_S1.BackColor = System.Drawing.Color.White;
            this.gb_S1.Controls.Add(this.lb_S1_Humi);
            this.gb_S1.Controls.Add(this.lb_S1_Temp);
            this.gb_S1.Controls.Add(this.tb_S1_Temp);
            this.gb_S1.Controls.Add(this.tb_S1_Humi);
            this.gb_S1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gb_S1.Font = new System.Drawing.Font("Comfortaa", 9.75F, System.Drawing.FontStyle.Bold);
            this.gb_S1.Location = new System.Drawing.Point(35, 236);
            this.gb_S1.Name = "gb_S1";
            this.gb_S1.Size = new System.Drawing.Size(200, 79);
            this.gb_S1.TabIndex = 22;
            this.gb_S1.TabStop = false;
            this.gb_S1.Text = "Sensor 1";
            // 
            // lb_S1_Humi
            // 
            this.lb_S1_Humi.AutoSize = true;
            this.lb_S1_Humi.Font = new System.Drawing.Font("Comfortaa SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.lb_S1_Humi.Location = new System.Drawing.Point(27, 51);
            this.lb_S1_Humi.Name = "lb_S1_Humi";
            this.lb_S1_Humi.Size = new System.Drawing.Size(66, 19);
            this.lb_S1_Humi.TabIndex = 8;
            this.lb_S1_Humi.Text = "Humidity";
            // 
            // lb_S1_Temp
            // 
            this.lb_S1_Temp.AutoSize = true;
            this.lb_S1_Temp.Font = new System.Drawing.Font("Comfortaa SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.lb_S1_Temp.Location = new System.Drawing.Point(17, 24);
            this.lb_S1_Temp.Name = "lb_S1_Temp";
            this.lb_S1_Temp.Size = new System.Drawing.Size(88, 19);
            this.lb_S1_Temp.TabIndex = 7;
            this.lb_S1_Temp.Text = "Temperature";
            // 
            // tb_S1_Temp
            // 
            this.tb_S1_Temp.Enabled = false;
            this.tb_S1_Temp.Location = new System.Drawing.Point(111, 25);
            this.tb_S1_Temp.Name = "tb_S1_Temp";
            this.tb_S1_Temp.Size = new System.Drawing.Size(69, 22);
            this.tb_S1_Temp.TabIndex = 5;
            // 
            // tb_S1_Humi
            // 
            this.tb_S1_Humi.Enabled = false;
            this.tb_S1_Humi.Location = new System.Drawing.Point(111, 50);
            this.tb_S1_Humi.Name = "tb_S1_Humi";
            this.tb_S1_Humi.Size = new System.Drawing.Size(69, 22);
            this.tb_S1_Humi.TabIndex = 6;
            // 
            // lb_LogName
            // 
            this.lb_LogName.AutoSize = true;
            this.lb_LogName.Font = new System.Drawing.Font("Comfortaa SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.lb_LogName.Location = new System.Drawing.Point(46, 99);
            this.lb_LogName.Name = "lb_LogName";
            this.lb_LogName.Size = new System.Drawing.Size(94, 19);
            this.lb_LogName.TabIndex = 20;
            this.lb_LogName.Text = "Logger Name";
            // 
            // cmb_LogName
            // 
            this.cmb_LogName.FormattingEnabled = true;
            this.cmb_LogName.Location = new System.Drawing.Point(64, 121);
            this.cmb_LogName.Name = "cmb_LogName";
            this.cmb_LogName.Size = new System.Drawing.Size(151, 21);
            this.cmb_LogName.TabIndex = 19;
            this.cmb_LogName.TextChanged += new System.EventHandler(this.cmb_LogName_TextChanged);
            // 
            // tb_Date
            // 
            this.tb_Date.Enabled = false;
            this.tb_Date.Location = new System.Drawing.Point(40, 192);
            this.tb_Date.Name = "tb_Date";
            this.tb_Date.Size = new System.Drawing.Size(100, 20);
            this.tb_Date.TabIndex = 27;
            // 
            // tb_Time
            // 
            this.tb_Time.Enabled = false;
            this.tb_Time.Location = new System.Drawing.Point(146, 192);
            this.tb_Time.Name = "tb_Time";
            this.tb_Time.Size = new System.Drawing.Size(100, 20);
            this.tb_Time.TabIndex = 28;
            // 
            // tb_NoOfSensors
            // 
            this.tb_NoOfSensors.Enabled = false;
            this.tb_NoOfSensors.Location = new System.Drawing.Point(485, 53);
            this.tb_NoOfSensors.Name = "tb_NoOfSensors";
            this.tb_NoOfSensors.Size = new System.Drawing.Size(46, 20);
            this.tb_NoOfSensors.TabIndex = 70;
            this.tb_NoOfSensors.Visible = false;
            // 
            // tb_LogType
            // 
            this.tb_LogType.Enabled = false;
            this.tb_LogType.Location = new System.Drawing.Point(435, 53);
            this.tb_LogType.Name = "tb_LogType";
            this.tb_LogType.Size = new System.Drawing.Size(46, 20);
            this.tb_LogType.TabIndex = 69;
            this.tb_LogType.Visible = false;
            // 
            // tb_T4UL
            // 
            this.tb_T4UL.Enabled = false;
            this.tb_T4UL.Location = new System.Drawing.Point(270, 53);
            this.tb_T4UL.Name = "tb_T4UL";
            this.tb_T4UL.Size = new System.Drawing.Size(46, 20);
            this.tb_T4UL.TabIndex = 68;
            this.tb_T4UL.Visible = false;
            // 
            // tb_H4UL
            // 
            this.tb_H4UL.Enabled = false;
            this.tb_H4UL.Location = new System.Drawing.Point(784, 56);
            this.tb_H4UL.Name = "tb_H4UL";
            this.tb_H4UL.Size = new System.Drawing.Size(46, 20);
            this.tb_H4UL.TabIndex = 67;
            this.tb_H4UL.Visible = false;
            // 
            // tb_H4LL
            // 
            this.tb_H4LL.Enabled = false;
            this.tb_H4LL.Location = new System.Drawing.Point(784, 29);
            this.tb_H4LL.Name = "tb_H4LL";
            this.tb_H4LL.Size = new System.Drawing.Size(46, 20);
            this.tb_H4LL.TabIndex = 66;
            this.tb_H4LL.Visible = false;
            // 
            // tb_H4SV
            // 
            this.tb_H4SV.Enabled = false;
            this.tb_H4SV.Location = new System.Drawing.Point(785, 3);
            this.tb_H4SV.Name = "tb_H4SV";
            this.tb_H4SV.Size = new System.Drawing.Size(46, 20);
            this.tb_H4SV.TabIndex = 65;
            this.tb_H4SV.Visible = false;
            // 
            // tb_T4LL
            // 
            this.tb_T4LL.Enabled = false;
            this.tb_T4LL.Location = new System.Drawing.Point(270, 27);
            this.tb_T4LL.Name = "tb_T4LL";
            this.tb_T4LL.Size = new System.Drawing.Size(46, 20);
            this.tb_T4LL.TabIndex = 64;
            this.tb_T4LL.Visible = false;
            // 
            // tb_T4SV
            // 
            this.tb_T4SV.Enabled = false;
            this.tb_T4SV.Location = new System.Drawing.Point(270, 1);
            this.tb_T4SV.Name = "tb_T4SV";
            this.tb_T4SV.Size = new System.Drawing.Size(46, 20);
            this.tb_T4SV.TabIndex = 63;
            this.tb_T4SV.Visible = false;
            // 
            // tb_T3UL
            // 
            this.tb_T3UL.Enabled = false;
            this.tb_T3UL.Location = new System.Drawing.Point(218, 53);
            this.tb_T3UL.Name = "tb_T3UL";
            this.tb_T3UL.Size = new System.Drawing.Size(46, 20);
            this.tb_T3UL.TabIndex = 62;
            this.tb_T3UL.Visible = false;
            // 
            // tb_H3UL
            // 
            this.tb_H3UL.Enabled = false;
            this.tb_H3UL.Location = new System.Drawing.Point(733, 55);
            this.tb_H3UL.Name = "tb_H3UL";
            this.tb_H3UL.Size = new System.Drawing.Size(46, 20);
            this.tb_H3UL.TabIndex = 61;
            this.tb_H3UL.Visible = false;
            // 
            // tb_H3LL
            // 
            this.tb_H3LL.Enabled = false;
            this.tb_H3LL.Location = new System.Drawing.Point(733, 28);
            this.tb_H3LL.Name = "tb_H3LL";
            this.tb_H3LL.Size = new System.Drawing.Size(46, 20);
            this.tb_H3LL.TabIndex = 60;
            this.tb_H3LL.Visible = false;
            // 
            // tb_H3SV
            // 
            this.tb_H3SV.Enabled = false;
            this.tb_H3SV.Location = new System.Drawing.Point(733, 3);
            this.tb_H3SV.Name = "tb_H3SV";
            this.tb_H3SV.Size = new System.Drawing.Size(46, 20);
            this.tb_H3SV.TabIndex = 59;
            this.tb_H3SV.Visible = false;
            // 
            // tb_T3LL
            // 
            this.tb_T3LL.Enabled = false;
            this.tb_T3LL.Location = new System.Drawing.Point(218, 25);
            this.tb_T3LL.Name = "tb_T3LL";
            this.tb_T3LL.Size = new System.Drawing.Size(46, 20);
            this.tb_T3LL.TabIndex = 58;
            this.tb_T3LL.Visible = false;
            // 
            // tb_T3SV
            // 
            this.tb_T3SV.Enabled = false;
            this.tb_T3SV.Location = new System.Drawing.Point(218, 0);
            this.tb_T3SV.Name = "tb_T3SV";
            this.tb_T3SV.Size = new System.Drawing.Size(46, 20);
            this.tb_T3SV.TabIndex = 57;
            this.tb_T3SV.Visible = false;
            // 
            // tb_T2UL
            // 
            this.tb_T2UL.Enabled = false;
            this.tb_T2UL.Location = new System.Drawing.Point(166, 52);
            this.tb_T2UL.Name = "tb_T2UL";
            this.tb_T2UL.Size = new System.Drawing.Size(46, 20);
            this.tb_T2UL.TabIndex = 56;
            this.tb_T2UL.Visible = false;
            // 
            // tb_H2UL
            // 
            this.tb_H2UL.Enabled = false;
            this.tb_H2UL.Location = new System.Drawing.Point(681, 55);
            this.tb_H2UL.Name = "tb_H2UL";
            this.tb_H2UL.Size = new System.Drawing.Size(46, 20);
            this.tb_H2UL.TabIndex = 55;
            this.tb_H2UL.Visible = false;
            // 
            // tb_H2LL
            // 
            this.tb_H2LL.Enabled = false;
            this.tb_H2LL.Location = new System.Drawing.Point(681, 29);
            this.tb_H2LL.Name = "tb_H2LL";
            this.tb_H2LL.Size = new System.Drawing.Size(46, 20);
            this.tb_H2LL.TabIndex = 54;
            this.tb_H2LL.Visible = false;
            // 
            // tb_H2SV
            // 
            this.tb_H2SV.Enabled = false;
            this.tb_H2SV.Location = new System.Drawing.Point(681, 3);
            this.tb_H2SV.Name = "tb_H2SV";
            this.tb_H2SV.Size = new System.Drawing.Size(46, 20);
            this.tb_H2SV.TabIndex = 53;
            this.tb_H2SV.Visible = false;
            // 
            // tb_T2LL
            // 
            this.tb_T2LL.Enabled = false;
            this.tb_T2LL.Location = new System.Drawing.Point(166, 26);
            this.tb_T2LL.Name = "tb_T2LL";
            this.tb_T2LL.Size = new System.Drawing.Size(46, 20);
            this.tb_T2LL.TabIndex = 52;
            this.tb_T2LL.Visible = false;
            // 
            // tb_T2SV
            // 
            this.tb_T2SV.Enabled = false;
            this.tb_T2SV.Location = new System.Drawing.Point(166, 0);
            this.tb_T2SV.Name = "tb_T2SV";
            this.tb_T2SV.Size = new System.Drawing.Size(46, 20);
            this.tb_T2SV.TabIndex = 51;
            this.tb_T2SV.Visible = false;
            // 
            // tb_T1UL
            // 
            this.tb_T1UL.Enabled = false;
            this.tb_T1UL.Location = new System.Drawing.Point(114, 52);
            this.tb_T1UL.Name = "tb_T1UL";
            this.tb_T1UL.Size = new System.Drawing.Size(46, 20);
            this.tb_T1UL.TabIndex = 50;
            this.tb_T1UL.Visible = false;
            // 
            // tb_H1UL
            // 
            this.tb_H1UL.Enabled = false;
            this.tb_H1UL.Location = new System.Drawing.Point(629, 55);
            this.tb_H1UL.Name = "tb_H1UL";
            this.tb_H1UL.Size = new System.Drawing.Size(46, 20);
            this.tb_H1UL.TabIndex = 49;
            this.tb_H1UL.Visible = false;
            // 
            // tb_H1LL
            // 
            this.tb_H1LL.Enabled = false;
            this.tb_H1LL.Location = new System.Drawing.Point(629, 29);
            this.tb_H1LL.Name = "tb_H1LL";
            this.tb_H1LL.Size = new System.Drawing.Size(46, 20);
            this.tb_H1LL.TabIndex = 48;
            this.tb_H1LL.Visible = false;
            // 
            // tb_H1SV
            // 
            this.tb_H1SV.Enabled = false;
            this.tb_H1SV.Location = new System.Drawing.Point(629, 3);
            this.tb_H1SV.Name = "tb_H1SV";
            this.tb_H1SV.Size = new System.Drawing.Size(46, 20);
            this.tb_H1SV.TabIndex = 47;
            this.tb_H1SV.Visible = false;
            // 
            // tb_T1LL
            // 
            this.tb_T1LL.Enabled = false;
            this.tb_T1LL.Location = new System.Drawing.Point(114, 26);
            this.tb_T1LL.Name = "tb_T1LL";
            this.tb_T1LL.Size = new System.Drawing.Size(46, 20);
            this.tb_T1LL.TabIndex = 46;
            this.tb_T1LL.Visible = false;
            // 
            // tb_T1SV
            // 
            this.tb_T1SV.Enabled = false;
            this.tb_T1SV.Location = new System.Drawing.Point(114, 0);
            this.tb_T1SV.Name = "tb_T1SV";
            this.tb_T1SV.Size = new System.Drawing.Size(46, 20);
            this.tb_T1SV.TabIndex = 45;
            this.tb_T1SV.Visible = false;
            // 
            // cartesianTemp
            // 
            this.cartesianTemp.BackColor = System.Drawing.Color.White;
            this.cartesianTemp.Location = new System.Drawing.Point(270, 91);
            this.cartesianTemp.Name = "cartesianTemp";
            this.cartesianTemp.Size = new System.Drawing.Size(673, 239);
            this.cartesianTemp.TabIndex = 71;
            this.cartesianTemp.Text = "cartesianChart1";
            // 
            // cartesianHumi
            // 
            this.cartesianHumi.BackColor = System.Drawing.Color.White;
            this.cartesianHumi.Location = new System.Drawing.Point(270, 376);
            this.cartesianHumi.Name = "cartesianHumi";
            this.cartesianHumi.Size = new System.Drawing.Size(673, 239);
            this.cartesianHumi.TabIndex = 72;
            this.cartesianHumi.Text = "cartesianChart1";
            // 
            // lb_date
            // 
            this.lb_date.AutoSize = true;
            this.lb_date.Font = new System.Drawing.Font("Comfortaa SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.lb_date.Location = new System.Drawing.Point(41, 172);
            this.lb_date.Name = "lb_date";
            this.lb_date.Size = new System.Drawing.Size(38, 19);
            this.lb_date.TabIndex = 73;
            this.lb_date.Text = "Date";
            // 
            // lb_time
            // 
            this.lb_time.AutoSize = true;
            this.lb_time.Font = new System.Drawing.Font("Comfortaa SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.lb_time.Location = new System.Drawing.Point(146, 171);
            this.lb_time.Name = "lb_time";
            this.lb_time.Size = new System.Drawing.Size(39, 19);
            this.lb_time.TabIndex = 74;
            this.lb_time.Text = "Time";
            // 
            // lb_Title
            // 
            this.lb_Title.AutoSize = true;
            this.lb_Title.Font = new System.Drawing.Font("Comfortaa", 15.75F, System.Drawing.FontStyle.Bold);
            this.lb_Title.Location = new System.Drawing.Point(394, 15);
            this.lb_Title.Name = "lb_Title";
            this.lb_Title.Size = new System.Drawing.Size(178, 34);
            this.lb_Title.TabIndex = 75;
            this.lb_Title.Text = "Real-Time Data";
            this.lb_Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // RealTimeData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(966, 633);
            this.Controls.Add(this.lb_Title);
            this.Controls.Add(this.lb_time);
            this.Controls.Add(this.lb_date);
            this.Controls.Add(this.cartesianHumi);
            this.Controls.Add(this.cartesianTemp);
            this.Controls.Add(this.tb_NoOfSensors);
            this.Controls.Add(this.tb_LogType);
            this.Controls.Add(this.tb_T4UL);
            this.Controls.Add(this.tb_H4UL);
            this.Controls.Add(this.tb_H4LL);
            this.Controls.Add(this.tb_H4SV);
            this.Controls.Add(this.tb_T4LL);
            this.Controls.Add(this.tb_T4SV);
            this.Controls.Add(this.tb_T3UL);
            this.Controls.Add(this.tb_H3UL);
            this.Controls.Add(this.tb_H3LL);
            this.Controls.Add(this.tb_H3SV);
            this.Controls.Add(this.tb_T3LL);
            this.Controls.Add(this.tb_T3SV);
            this.Controls.Add(this.tb_T2UL);
            this.Controls.Add(this.tb_H2UL);
            this.Controls.Add(this.tb_H2LL);
            this.Controls.Add(this.tb_H2SV);
            this.Controls.Add(this.tb_T2LL);
            this.Controls.Add(this.tb_T2SV);
            this.Controls.Add(this.tb_T1UL);
            this.Controls.Add(this.tb_H1UL);
            this.Controls.Add(this.tb_H1LL);
            this.Controls.Add(this.tb_H1SV);
            this.Controls.Add(this.tb_T1LL);
            this.Controls.Add(this.tb_T1SV);
            this.Controls.Add(this.tb_Time);
            this.Controls.Add(this.tb_Date);
            this.Controls.Add(this.gb_S4);
            this.Controls.Add(this.gb_S3);
            this.Controls.Add(this.gb_S2);
            this.Controls.Add(this.gb_S1);
            this.Controls.Add(this.lb_LogName);
            this.Controls.Add(this.cmb_LogName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RealTimeData";
            this.Text = "RealTimeData";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RealTimeData_FormClosing);
            this.Load += new System.EventHandler(this.RealTimeData_Load);
            this.gb_S4.ResumeLayout(false);
            this.gb_S4.PerformLayout();
            this.gb_S3.ResumeLayout(false);
            this.gb_S3.PerformLayout();
            this.gb_S2.ResumeLayout(false);
            this.gb_S2.PerformLayout();
            this.gb_S1.ResumeLayout(false);
            this.gb_S1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gb_S4;
        private System.Windows.Forms.Label lb_S4_Humi;
        private System.Windows.Forms.Label lb_S4_Temp;
        private System.Windows.Forms.TextBox tb_S4_Temp;
        private System.Windows.Forms.TextBox tb_S4_Humi;
        private System.Windows.Forms.GroupBox gb_S3;
        private System.Windows.Forms.Label lb_S3_Humi;
        private System.Windows.Forms.Label lb_S3_Temp;
        private System.Windows.Forms.TextBox tb_S3_Temp;
        private System.Windows.Forms.TextBox tb_S3_Humi;
        private System.Windows.Forms.GroupBox gb_S2;
        private System.Windows.Forms.Label lb_S2_Humi;
        private System.Windows.Forms.Label lb_S2_Temp;
        private System.Windows.Forms.TextBox tb_S2_Humi;
        private System.Windows.Forms.TextBox tb_S2_Temp;
        private System.Windows.Forms.GroupBox gb_S1;
        private System.Windows.Forms.Label lb_S1_Humi;
        private System.Windows.Forms.Label lb_S1_Temp;
        private System.Windows.Forms.TextBox tb_S1_Temp;
        private System.Windows.Forms.TextBox tb_S1_Humi;
        private System.Windows.Forms.Label lb_LogName;
        private System.Windows.Forms.ComboBox cmb_LogName;
        private System.Windows.Forms.TextBox tb_Date;
        private System.Windows.Forms.TextBox tb_Time;
        private System.Windows.Forms.TextBox tb_NoOfSensors;
        private System.Windows.Forms.TextBox tb_LogType;
        private System.Windows.Forms.TextBox tb_T4UL;
        private System.Windows.Forms.TextBox tb_H4UL;
        private System.Windows.Forms.TextBox tb_H4LL;
        private System.Windows.Forms.TextBox tb_H4SV;
        private System.Windows.Forms.TextBox tb_T4LL;
        private System.Windows.Forms.TextBox tb_T4SV;
        private System.Windows.Forms.TextBox tb_T3UL;
        private System.Windows.Forms.TextBox tb_H3UL;
        private System.Windows.Forms.TextBox tb_H3LL;
        private System.Windows.Forms.TextBox tb_H3SV;
        private System.Windows.Forms.TextBox tb_T3LL;
        private System.Windows.Forms.TextBox tb_T3SV;
        private System.Windows.Forms.TextBox tb_T2UL;
        private System.Windows.Forms.TextBox tb_H2UL;
        private System.Windows.Forms.TextBox tb_H2LL;
        private System.Windows.Forms.TextBox tb_H2SV;
        private System.Windows.Forms.TextBox tb_T2LL;
        private System.Windows.Forms.TextBox tb_T2SV;
        private System.Windows.Forms.TextBox tb_T1UL;
        private System.Windows.Forms.TextBox tb_H1UL;
        private System.Windows.Forms.TextBox tb_H1LL;
        private System.Windows.Forms.TextBox tb_H1SV;
        private System.Windows.Forms.TextBox tb_T1LL;
        private System.Windows.Forms.TextBox tb_T1SV;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private LiveCharts.WinForms.CartesianChart cartesianTemp;
        private LiveCharts.WinForms.CartesianChart cartesianHumi;
        private System.Windows.Forms.Label lb_date;
        private System.Windows.Forms.Label lb_time;
        private System.Windows.Forms.Label lb_Title;
    }
}