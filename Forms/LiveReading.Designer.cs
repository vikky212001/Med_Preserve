namespace Med_Preserve.Forms
{
    partial class LiveReading
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LiveReading));
            this.cmb_LogName = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.lb_LogName = new System.Windows.Forms.Label();
            this.lb_SerialPort = new System.Windows.Forms.Label();
            this.tb_S1_Temp = new System.Windows.Forms.TextBox();
            this.tb_S1_Humi = new System.Windows.Forms.TextBox();
            this.tb_S2_Humi = new System.Windows.Forms.TextBox();
            this.tb_S2_Temp = new System.Windows.Forms.TextBox();
            this.tb_S4_Humi = new System.Windows.Forms.TextBox();
            this.tb_S4_Temp = new System.Windows.Forms.TextBox();
            this.tb_S3_Humi = new System.Windows.Forms.TextBox();
            this.tb_S3_Temp = new System.Windows.Forms.TextBox();
            this.ch_Humi = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ch_Temp = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gb_S1 = new System.Windows.Forms.GroupBox();
            this.lb_S1_Humi = new System.Windows.Forms.Label();
            this.lb_S1_Temp = new System.Windows.Forms.Label();
            this.gb_S2 = new System.Windows.Forms.GroupBox();
            this.lb_S2_Humi = new System.Windows.Forms.Label();
            this.lb_S2_Temp = new System.Windows.Forms.Label();
            this.gb_S3 = new System.Windows.Forms.GroupBox();
            this.lb_S3_Humi = new System.Windows.Forms.Label();
            this.lb_S3_Temp = new System.Windows.Forms.Label();
            this.gb_S4 = new System.Windows.Forms.GroupBox();
            this.lb_S4_Humi = new System.Windows.Forms.Label();
            this.lb_S4_Temp = new System.Windows.Forms.Label();
            this.tb_SerialPort = new System.Windows.Forms.TextBox();
            this.tb_T1SV = new System.Windows.Forms.TextBox();
            this.tb_T1LL = new System.Windows.Forms.TextBox();
            this.tb_H1SV = new System.Windows.Forms.TextBox();
            this.tb_H1LL = new System.Windows.Forms.TextBox();
            this.tb_H1UL = new System.Windows.Forms.TextBox();
            this.tb_T1UL = new System.Windows.Forms.TextBox();
            this.tb_T2UL = new System.Windows.Forms.TextBox();
            this.tb_H2UL = new System.Windows.Forms.TextBox();
            this.tb_H2LL = new System.Windows.Forms.TextBox();
            this.tb_H2SV = new System.Windows.Forms.TextBox();
            this.tb_T2LL = new System.Windows.Forms.TextBox();
            this.tb_T2SV = new System.Windows.Forms.TextBox();
            this.tb_T3UL = new System.Windows.Forms.TextBox();
            this.tb_H3UL = new System.Windows.Forms.TextBox();
            this.tb_H3LL = new System.Windows.Forms.TextBox();
            this.tb_H3SV = new System.Windows.Forms.TextBox();
            this.tb_T3LL = new System.Windows.Forms.TextBox();
            this.tb_T3SV = new System.Windows.Forms.TextBox();
            this.tb_T4UL = new System.Windows.Forms.TextBox();
            this.tb_H4UL = new System.Windows.Forms.TextBox();
            this.tb_H4LL = new System.Windows.Forms.TextBox();
            this.tb_H4SV = new System.Windows.Forms.TextBox();
            this.tb_T4LL = new System.Windows.Forms.TextBox();
            this.tb_T4SV = new System.Windows.Forms.TextBox();
            this.tb_LogType = new System.Windows.Forms.TextBox();
            this.tb_NoOfSensors = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ch_Humi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ch_Temp)).BeginInit();
            this.gb_S1.SuspendLayout();
            this.gb_S2.SuspendLayout();
            this.gb_S3.SuspendLayout();
            this.gb_S4.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmb_LogName
            // 
            this.cmb_LogName.FormattingEnabled = true;
            this.cmb_LogName.Location = new System.Drawing.Point(144, 113);
            this.cmb_LogName.Name = "cmb_LogName";
            this.cmb_LogName.Size = new System.Drawing.Size(121, 21);
            this.cmb_LogName.TabIndex = 1;
            this.cmb_LogName.TextChanged += new System.EventHandler(this.cmb_LogName_TextChanged);
            // 
            // lb_LogName
            // 
            this.lb_LogName.AutoSize = true;
            this.lb_LogName.Font = new System.Drawing.Font("Comfortaa SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.lb_LogName.Location = new System.Drawing.Point(44, 112);
            this.lb_LogName.Name = "lb_LogName";
            this.lb_LogName.Size = new System.Drawing.Size(94, 19);
            this.lb_LogName.TabIndex = 3;
            this.lb_LogName.Text = "Logger Name";
            // 
            // lb_SerialPort
            // 
            this.lb_SerialPort.AutoSize = true;
            this.lb_SerialPort.Font = new System.Drawing.Font("Comfortaa SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.lb_SerialPort.Location = new System.Drawing.Point(54, 141);
            this.lb_SerialPort.Name = "lb_SerialPort";
            this.lb_SerialPort.Size = new System.Drawing.Size(76, 19);
            this.lb_SerialPort.TabIndex = 4;
            this.lb_SerialPort.Text = "Serial Port";
            // 
            // tb_S1_Temp
            // 
            this.tb_S1_Temp.Location = new System.Drawing.Point(111, 25);
            this.tb_S1_Temp.Name = "tb_S1_Temp";
            this.tb_S1_Temp.Size = new System.Drawing.Size(69, 22);
            this.tb_S1_Temp.TabIndex = 5;
            // 
            // tb_S1_Humi
            // 
            this.tb_S1_Humi.Location = new System.Drawing.Point(111, 50);
            this.tb_S1_Humi.Name = "tb_S1_Humi";
            this.tb_S1_Humi.Size = new System.Drawing.Size(69, 22);
            this.tb_S1_Humi.TabIndex = 6;
            // 
            // tb_S2_Humi
            // 
            this.tb_S2_Humi.Location = new System.Drawing.Point(111, 49);
            this.tb_S2_Humi.Name = "tb_S2_Humi";
            this.tb_S2_Humi.Size = new System.Drawing.Size(69, 22);
            this.tb_S2_Humi.TabIndex = 8;
            // 
            // tb_S2_Temp
            // 
            this.tb_S2_Temp.Location = new System.Drawing.Point(111, 23);
            this.tb_S2_Temp.Name = "tb_S2_Temp";
            this.tb_S2_Temp.Size = new System.Drawing.Size(69, 22);
            this.tb_S2_Temp.TabIndex = 7;
            // 
            // tb_S4_Humi
            // 
            this.tb_S4_Humi.Location = new System.Drawing.Point(111, 45);
            this.tb_S4_Humi.Name = "tb_S4_Humi";
            this.tb_S4_Humi.Size = new System.Drawing.Size(69, 22);
            this.tb_S4_Humi.TabIndex = 12;
            // 
            // tb_S4_Temp
            // 
            this.tb_S4_Temp.Location = new System.Drawing.Point(111, 19);
            this.tb_S4_Temp.Name = "tb_S4_Temp";
            this.tb_S4_Temp.Size = new System.Drawing.Size(69, 22);
            this.tb_S4_Temp.TabIndex = 11;
            // 
            // tb_S3_Humi
            // 
            this.tb_S3_Humi.Location = new System.Drawing.Point(111, 46);
            this.tb_S3_Humi.Name = "tb_S3_Humi";
            this.tb_S3_Humi.Size = new System.Drawing.Size(69, 22);
            this.tb_S3_Humi.TabIndex = 10;
            // 
            // tb_S3_Temp
            // 
            this.tb_S3_Temp.Location = new System.Drawing.Point(111, 19);
            this.tb_S3_Temp.Name = "tb_S3_Temp";
            this.tb_S3_Temp.Size = new System.Drawing.Size(69, 22);
            this.tb_S3_Temp.TabIndex = 9;
            // 
            // ch_Humi
            // 
            chartArea1.Name = "ChartArea1";
            this.ch_Humi.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ch_Humi.Legends.Add(legend1);
            this.ch_Humi.Location = new System.Drawing.Point(280, 106);
            this.ch_Humi.Name = "ch_Humi";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.ch_Humi.Series.Add(series1);
            this.ch_Humi.Size = new System.Drawing.Size(667, 211);
            this.ch_Humi.TabIndex = 13;
            this.ch_Humi.Text = "chart1";
            // 
            // ch_Temp
            // 
            chartArea2.Name = "ChartArea1";
            this.ch_Temp.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.ch_Temp.Legends.Add(legend2);
            this.ch_Temp.Location = new System.Drawing.Point(280, 323);
            this.ch_Temp.Name = "ch_Temp";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.ch_Temp.Series.Add(series2);
            this.ch_Temp.Size = new System.Drawing.Size(667, 211);
            this.ch_Temp.TabIndex = 14;
            this.ch_Temp.Text = "chart2";
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
            this.gb_S1.Location = new System.Drawing.Point(47, 176);
            this.gb_S1.Name = "gb_S1";
            this.gb_S1.Size = new System.Drawing.Size(200, 79);
            this.gb_S1.TabIndex = 15;
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
            // gb_S2
            // 
            this.gb_S2.BackColor = System.Drawing.Color.White;
            this.gb_S2.Controls.Add(this.lb_S2_Humi);
            this.gb_S2.Controls.Add(this.lb_S2_Temp);
            this.gb_S2.Controls.Add(this.tb_S2_Humi);
            this.gb_S2.Controls.Add(this.tb_S2_Temp);
            this.gb_S2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gb_S2.Font = new System.Drawing.Font("Comfortaa", 9.75F, System.Drawing.FontStyle.Bold);
            this.gb_S2.Location = new System.Drawing.Point(47, 273);
            this.gb_S2.Name = "gb_S2";
            this.gb_S2.Size = new System.Drawing.Size(200, 75);
            this.gb_S2.TabIndex = 16;
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
            // gb_S3
            // 
            this.gb_S3.BackColor = System.Drawing.Color.White;
            this.gb_S3.Controls.Add(this.lb_S3_Humi);
            this.gb_S3.Controls.Add(this.lb_S3_Temp);
            this.gb_S3.Controls.Add(this.tb_S3_Temp);
            this.gb_S3.Controls.Add(this.tb_S3_Humi);
            this.gb_S3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gb_S3.Font = new System.Drawing.Font("Comfortaa", 9.75F, System.Drawing.FontStyle.Bold);
            this.gb_S3.Location = new System.Drawing.Point(47, 368);
            this.gb_S3.Name = "gb_S3";
            this.gb_S3.Size = new System.Drawing.Size(200, 75);
            this.gb_S3.TabIndex = 17;
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
            // gb_S4
            // 
            this.gb_S4.BackColor = System.Drawing.Color.White;
            this.gb_S4.Controls.Add(this.lb_S4_Humi);
            this.gb_S4.Controls.Add(this.lb_S4_Temp);
            this.gb_S4.Controls.Add(this.tb_S4_Temp);
            this.gb_S4.Controls.Add(this.tb_S4_Humi);
            this.gb_S4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gb_S4.Font = new System.Drawing.Font("Comfortaa", 9.75F, System.Drawing.FontStyle.Bold);
            this.gb_S4.Location = new System.Drawing.Point(47, 461);
            this.gb_S4.Name = "gb_S4";
            this.gb_S4.Size = new System.Drawing.Size(200, 75);
            this.gb_S4.TabIndex = 17;
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
            // tb_SerialPort
            // 
            this.tb_SerialPort.Location = new System.Drawing.Point(144, 140);
            this.tb_SerialPort.Name = "tb_SerialPort";
            this.tb_SerialPort.Size = new System.Drawing.Size(115, 20);
            this.tb_SerialPort.TabIndex = 18;
            // 
            // tb_T1SV
            // 
            this.tb_T1SV.Location = new System.Drawing.Point(933, 221);
            this.tb_T1SV.Name = "tb_T1SV";
            this.tb_T1SV.Size = new System.Drawing.Size(46, 20);
            this.tb_T1SV.TabIndex = 19;
            this.tb_T1SV.Visible = false;
            // 
            // tb_T1LL
            // 
            this.tb_T1LL.Location = new System.Drawing.Point(933, 247);
            this.tb_T1LL.Name = "tb_T1LL";
            this.tb_T1LL.Size = new System.Drawing.Size(46, 20);
            this.tb_T1LL.TabIndex = 20;
            this.tb_T1LL.Visible = false;
            // 
            // tb_H1SV
            // 
            this.tb_H1SV.Location = new System.Drawing.Point(933, 298);
            this.tb_H1SV.Name = "tb_H1SV";
            this.tb_H1SV.Size = new System.Drawing.Size(46, 20);
            this.tb_H1SV.TabIndex = 21;
            this.tb_H1SV.Visible = false;
            // 
            // tb_H1LL
            // 
            this.tb_H1LL.Location = new System.Drawing.Point(933, 324);
            this.tb_H1LL.Name = "tb_H1LL";
            this.tb_H1LL.Size = new System.Drawing.Size(46, 20);
            this.tb_H1LL.TabIndex = 22;
            this.tb_H1LL.Visible = false;
            // 
            // tb_H1UL
            // 
            this.tb_H1UL.Location = new System.Drawing.Point(933, 350);
            this.tb_H1UL.Name = "tb_H1UL";
            this.tb_H1UL.Size = new System.Drawing.Size(46, 20);
            this.tb_H1UL.TabIndex = 23;
            this.tb_H1UL.Visible = false;
            // 
            // tb_T1UL
            // 
            this.tb_T1UL.Location = new System.Drawing.Point(933, 273);
            this.tb_T1UL.Name = "tb_T1UL";
            this.tb_T1UL.Size = new System.Drawing.Size(46, 20);
            this.tb_T1UL.TabIndex = 24;
            this.tb_T1UL.Visible = false;
            // 
            // tb_T2UL
            // 
            this.tb_T2UL.Location = new System.Drawing.Point(933, 88);
            this.tb_T2UL.Name = "tb_T2UL";
            this.tb_T2UL.Size = new System.Drawing.Size(46, 20);
            this.tb_T2UL.TabIndex = 30;
            this.tb_T2UL.Visible = false;
            // 
            // tb_H2UL
            // 
            this.tb_H2UL.Location = new System.Drawing.Point(933, 197);
            this.tb_H2UL.Name = "tb_H2UL";
            this.tb_H2UL.Size = new System.Drawing.Size(46, 20);
            this.tb_H2UL.TabIndex = 29;
            this.tb_H2UL.Visible = false;
            // 
            // tb_H2LL
            // 
            this.tb_H2LL.Location = new System.Drawing.Point(933, 171);
            this.tb_H2LL.Name = "tb_H2LL";
            this.tb_H2LL.Size = new System.Drawing.Size(46, 20);
            this.tb_H2LL.TabIndex = 28;
            this.tb_H2LL.Visible = false;
            // 
            // tb_H2SV
            // 
            this.tb_H2SV.Location = new System.Drawing.Point(933, 145);
            this.tb_H2SV.Name = "tb_H2SV";
            this.tb_H2SV.Size = new System.Drawing.Size(46, 20);
            this.tb_H2SV.TabIndex = 27;
            this.tb_H2SV.Visible = false;
            // 
            // tb_T2LL
            // 
            this.tb_T2LL.Location = new System.Drawing.Point(933, 62);
            this.tb_T2LL.Name = "tb_T2LL";
            this.tb_T2LL.Size = new System.Drawing.Size(46, 20);
            this.tb_T2LL.TabIndex = 26;
            this.tb_T2LL.Visible = false;
            // 
            // tb_T2SV
            // 
            this.tb_T2SV.Location = new System.Drawing.Point(933, 36);
            this.tb_T2SV.Name = "tb_T2SV";
            this.tb_T2SV.Size = new System.Drawing.Size(46, 20);
            this.tb_T2SV.TabIndex = 25;
            this.tb_T2SV.Visible = false;
            // 
            // tb_T3UL
            // 
            this.tb_T3UL.Location = new System.Drawing.Point(932, 533);
            this.tb_T3UL.Name = "tb_T3UL";
            this.tb_T3UL.Size = new System.Drawing.Size(46, 20);
            this.tb_T3UL.TabIndex = 36;
            this.tb_T3UL.Visible = false;
            // 
            // tb_H3UL
            // 
            this.tb_H3UL.Location = new System.Drawing.Point(933, 428);
            this.tb_H3UL.Name = "tb_H3UL";
            this.tb_H3UL.Size = new System.Drawing.Size(46, 20);
            this.tb_H3UL.TabIndex = 35;
            this.tb_H3UL.Visible = false;
            // 
            // tb_H3LL
            // 
            this.tb_H3LL.Location = new System.Drawing.Point(933, 402);
            this.tb_H3LL.Name = "tb_H3LL";
            this.tb_H3LL.Size = new System.Drawing.Size(46, 20);
            this.tb_H3LL.TabIndex = 34;
            this.tb_H3LL.Visible = false;
            // 
            // tb_H3SV
            // 
            this.tb_H3SV.Location = new System.Drawing.Point(933, 376);
            this.tb_H3SV.Name = "tb_H3SV";
            this.tb_H3SV.Size = new System.Drawing.Size(46, 20);
            this.tb_H3SV.TabIndex = 33;
            this.tb_H3SV.Visible = false;
            // 
            // tb_T3LL
            // 
            this.tb_T3LL.Location = new System.Drawing.Point(932, 480);
            this.tb_T3LL.Name = "tb_T3LL";
            this.tb_T3LL.Size = new System.Drawing.Size(46, 20);
            this.tb_T3LL.TabIndex = 32;
            this.tb_T3LL.Visible = false;
            // 
            // tb_T3SV
            // 
            this.tb_T3SV.Location = new System.Drawing.Point(932, 454);
            this.tb_T3SV.Name = "tb_T3SV";
            this.tb_T3SV.Size = new System.Drawing.Size(46, 20);
            this.tb_T3SV.TabIndex = 31;
            this.tb_T3SV.Visible = false;
            // 
            // tb_T4UL
            // 
            this.tb_T4UL.Location = new System.Drawing.Point(828, 533);
            this.tb_T4UL.Name = "tb_T4UL";
            this.tb_T4UL.Size = new System.Drawing.Size(46, 20);
            this.tb_T4UL.TabIndex = 42;
            this.tb_T4UL.Visible = false;
            // 
            // tb_H4UL
            // 
            this.tb_H4UL.Location = new System.Drawing.Point(880, 533);
            this.tb_H4UL.Name = "tb_H4UL";
            this.tb_H4UL.Size = new System.Drawing.Size(46, 20);
            this.tb_H4UL.TabIndex = 41;
            this.tb_H4UL.Visible = false;
            // 
            // tb_H4LL
            // 
            this.tb_H4LL.Location = new System.Drawing.Point(776, 533);
            this.tb_H4LL.Name = "tb_H4LL";
            this.tb_H4LL.Size = new System.Drawing.Size(46, 20);
            this.tb_H4LL.TabIndex = 40;
            this.tb_H4LL.Visible = false;
            // 
            // tb_H4SV
            // 
            this.tb_H4SV.Location = new System.Drawing.Point(672, 533);
            this.tb_H4SV.Name = "tb_H4SV";
            this.tb_H4SV.Size = new System.Drawing.Size(46, 20);
            this.tb_H4SV.TabIndex = 39;
            this.tb_H4SV.Visible = false;
            // 
            // tb_T4LL
            // 
            this.tb_T4LL.Location = new System.Drawing.Point(724, 533);
            this.tb_T4LL.Name = "tb_T4LL";
            this.tb_T4LL.Size = new System.Drawing.Size(46, 20);
            this.tb_T4LL.TabIndex = 38;
            this.tb_T4LL.Visible = false;
            // 
            // tb_T4SV
            // 
            this.tb_T4SV.Location = new System.Drawing.Point(933, 505);
            this.tb_T4SV.Name = "tb_T4SV";
            this.tb_T4SV.Size = new System.Drawing.Size(46, 20);
            this.tb_T4SV.TabIndex = 37;
            this.tb_T4SV.Visible = false;
            // 
            // tb_LogType
            // 
            this.tb_LogType.Location = new System.Drawing.Point(933, 10);
            this.tb_LogType.Name = "tb_LogType";
            this.tb_LogType.Size = new System.Drawing.Size(46, 20);
            this.tb_LogType.TabIndex = 43;
            this.tb_LogType.Visible = false;
            // 
            // tb_NoOfSensors
            // 
            this.tb_NoOfSensors.Location = new System.Drawing.Point(933, 119);
            this.tb_NoOfSensors.Name = "tb_NoOfSensors";
            this.tb_NoOfSensors.Size = new System.Drawing.Size(46, 20);
            this.tb_NoOfSensors.TabIndex = 44;
            this.tb_NoOfSensors.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comfortaa", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(406, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 34);
            this.label1.TabIndex = 45;
            this.label1.Text = "Real-Time Data";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LiveReading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(966, 633);
            this.Controls.Add(this.label1);
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
            this.Controls.Add(this.tb_SerialPort);
            this.Controls.Add(this.gb_S4);
            this.Controls.Add(this.gb_S3);
            this.Controls.Add(this.gb_S2);
            this.Controls.Add(this.gb_S1);
            this.Controls.Add(this.ch_Temp);
            this.Controls.Add(this.ch_Humi);
            this.Controls.Add(this.lb_SerialPort);
            this.Controls.Add(this.lb_LogName);
            this.Controls.Add(this.cmb_LogName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LiveReading";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Live Reading";
            this.Load += new System.EventHandler(this.LiveReading_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ch_Humi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ch_Temp)).EndInit();
            this.gb_S1.ResumeLayout(false);
            this.gb_S1.PerformLayout();
            this.gb_S2.ResumeLayout(false);
            this.gb_S2.PerformLayout();
            this.gb_S3.ResumeLayout(false);
            this.gb_S3.PerformLayout();
            this.gb_S4.ResumeLayout(false);
            this.gb_S4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmb_LogName;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label lb_LogName;
        private System.Windows.Forms.Label lb_SerialPort;
        private System.Windows.Forms.TextBox tb_S1_Temp;
        private System.Windows.Forms.TextBox tb_S1_Humi;
        private System.Windows.Forms.TextBox tb_S2_Humi;
        private System.Windows.Forms.TextBox tb_S2_Temp;
        private System.Windows.Forms.TextBox tb_S4_Humi;
        private System.Windows.Forms.TextBox tb_S4_Temp;
        private System.Windows.Forms.TextBox tb_S3_Humi;
        private System.Windows.Forms.TextBox tb_S3_Temp;
        private System.Windows.Forms.DataVisualization.Charting.Chart ch_Humi;
        private System.Windows.Forms.DataVisualization.Charting.Chart ch_Temp;
        private System.Windows.Forms.GroupBox gb_S1;
        private System.Windows.Forms.Label lb_S1_Humi;
        private System.Windows.Forms.Label lb_S1_Temp;
        private System.Windows.Forms.GroupBox gb_S2;
        private System.Windows.Forms.Label lb_S2_Humi;
        private System.Windows.Forms.Label lb_S2_Temp;
        private System.Windows.Forms.GroupBox gb_S3;
        private System.Windows.Forms.Label lb_S3_Humi;
        private System.Windows.Forms.Label lb_S3_Temp;
        private System.Windows.Forms.GroupBox gb_S4;
        private System.Windows.Forms.Label lb_S4_Humi;
        private System.Windows.Forms.Label lb_S4_Temp;
        private System.Windows.Forms.TextBox tb_SerialPort;
        private System.Windows.Forms.TextBox tb_T1SV;
        private System.Windows.Forms.TextBox tb_T1LL;
        private System.Windows.Forms.TextBox tb_H1SV;
        private System.Windows.Forms.TextBox tb_H1LL;
        private System.Windows.Forms.TextBox tb_H1UL;
        private System.Windows.Forms.TextBox tb_T1UL;
        private System.Windows.Forms.TextBox tb_T2UL;
        private System.Windows.Forms.TextBox tb_H2UL;
        private System.Windows.Forms.TextBox tb_H2LL;
        private System.Windows.Forms.TextBox tb_H2SV;
        private System.Windows.Forms.TextBox tb_T2LL;
        private System.Windows.Forms.TextBox tb_T2SV;
        private System.Windows.Forms.TextBox tb_T3UL;
        private System.Windows.Forms.TextBox tb_H3UL;
        private System.Windows.Forms.TextBox tb_H3LL;
        private System.Windows.Forms.TextBox tb_H3SV;
        private System.Windows.Forms.TextBox tb_T3LL;
        private System.Windows.Forms.TextBox tb_T3SV;
        private System.Windows.Forms.TextBox tb_T4UL;
        private System.Windows.Forms.TextBox tb_H4UL;
        private System.Windows.Forms.TextBox tb_H4LL;
        private System.Windows.Forms.TextBox tb_H4SV;
        private System.Windows.Forms.TextBox tb_T4LL;
        private System.Windows.Forms.TextBox tb_T4SV;
        private System.Windows.Forms.TextBox tb_LogType;
        private System.Windows.Forms.TextBox tb_NoOfSensors;
        private System.Windows.Forms.Label label1;
    }
}