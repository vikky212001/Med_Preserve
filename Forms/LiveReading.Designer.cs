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
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cmb_LogName = new System.Windows.Forms.ComboBox();
            this.cmb_SerialPort = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.lb_LogName = new System.Windows.Forms.Label();
            this.lb_SerialPort = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 159);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(776, 253);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // cmb_LogName
            // 
            this.cmb_LogName.FormattingEnabled = true;
            this.cmb_LogName.Location = new System.Drawing.Point(110, 21);
            this.cmb_LogName.Name = "cmb_LogName";
            this.cmb_LogName.Size = new System.Drawing.Size(121, 21);
            this.cmb_LogName.TabIndex = 1;
            // 
            // cmb_SerialPort
            // 
            this.cmb_SerialPort.FormattingEnabled = true;
            this.cmb_SerialPort.Location = new System.Drawing.Point(652, 20);
            this.cmb_SerialPort.Name = "cmb_SerialPort";
            this.cmb_SerialPort.Size = new System.Drawing.Size(121, 21);
            this.cmb_SerialPort.TabIndex = 2;
            // 
            // lb_LogName
            // 
            this.lb_LogName.AutoSize = true;
            this.lb_LogName.Location = new System.Drawing.Point(30, 27);
            this.lb_LogName.Name = "lb_LogName";
            this.lb_LogName.Size = new System.Drawing.Size(71, 13);
            this.lb_LogName.TabIndex = 3;
            this.lb_LogName.Text = "Logger Name";
            // 
            // lb_SerialPort
            // 
            this.lb_SerialPort.AutoSize = true;
            this.lb_SerialPort.Location = new System.Drawing.Point(551, 26);
            this.lb_SerialPort.Name = "lb_SerialPort";
            this.lb_SerialPort.Size = new System.Drawing.Size(55, 13);
            this.lb_SerialPort.TabIndex = 4;
            this.lb_SerialPort.Text = "Serial Port";
            // 
            // LiveReading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_SerialPort);
            this.Controls.Add(this.lb_LogName);
            this.Controls.Add(this.cmb_SerialPort);
            this.Controls.Add(this.cmb_LogName);
            this.Controls.Add(this.chart1);
            this.Name = "LiveReading";
            this.Text = "LiveReading";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ComboBox cmb_LogName;
        private System.Windows.Forms.ComboBox cmb_SerialPort;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label lb_LogName;
        private System.Windows.Forms.Label lb_SerialPort;
    }
}