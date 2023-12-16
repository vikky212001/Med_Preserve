using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Med_Preserve.Forms
{
    public partial class RealTimeData : Form
    {
        private string selectedComPort;
        private string connectionString;
        private SerialPort serialPort;
        public RealTimeData(string comPort)
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            selectedComPort = comPort;
            InitializeSerialPorts();
        }

        private void InitializeSerialPorts()
        {
            if (selectedComPort == null)
            {
                tb_SerialPort.Text = "No COM Port Selected";
            }
            else
            {
                serialPort = new SerialPort();
                serialPort.PortName = selectedComPort;
                serialPort.BaudRate = 9600;
                serialPort.DataReceived += SerialPort_DataReceived;
                try
                {
                    serialPort.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error opening serial port: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string data = serialPort.ReadLine();
            string[] head = data.Split('_');
            if (head.Length == 2 || head.Length == 3)
            {
                string deviceName = head[0];
                string cmd = head[1];
                string logName = cmb_LogName.Text;
                string logType = tb_LogType.Text;
                string SensorCount = tb_NoOfSensors.Text;
                if (deviceName == logName)
                {
                    if (cmd == "VALUES")
                    {
                        if (logType == "Temperature")
                        {
                            if (SensorCount == "1")
                            { }
                            else if (SensorCount == "2")
                            { }
                            else if (SensorCount == "3")
                            { }
                            else if (SensorCount == "4")
                            { }
                        }
                        else if (logType == "Humidity")
                        {
                            if (SensorCount == "1")
                            { }
                            else if (SensorCount == "2")
                            { }
                            else if (SensorCount == "3")
                            { }
                            else if (SensorCount == "4")
                            { }
                        }
                        else if (logType == "Both")
                        {
                            if (SensorCount == "1")
                            { }
                            else if (SensorCount == "2")
                            { }
                            else if (SensorCount == "3")
                            { }
                            else if (SensorCount == "4")
                            { }
                        }
                    }
                }






                string temp1 = body[0].Trim();
                string humi1 = body[1].Trim(); 
                Invoke(new Action(() =>
                {
                    tb_S1_Temp.Text = temp1;
                    tb_S1_Humi.Text = humi1;
                }));
            }
        }
    }
}
