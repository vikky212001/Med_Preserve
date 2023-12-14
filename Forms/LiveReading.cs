using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO.Ports;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Med_Preserve.Forms
{
    public partial class LiveReading : Form
    {
        private string selectedComPort;
        private string receivedDataBuffer = string.Empty;
        private string connectionString;
        private ChartArea temperatureChartArea;
        private ChartArea humidityChartArea;
        private Series temperatureSeries;
        private Series humiditySeries;
        private SerialPort serialPort;

        public LiveReading(string comPort)
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            selectedComPort = comPort;
            InitializeForm();
        }

        private void InitializeForm()
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
                try
                {
                    serialPort.Open();
                    serialPort.DataReceived += SerialPort_DataReceived;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error opening serial port: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void InitializeCharts()
        {
            temperatureChartArea = new ChartArea();
            temperatureSeries = new Series("Temperature");

            temperatureChartArea.AxisX.Title = "Time";
            temperatureChartArea.AxisY.Title = "Temperature";
            temperatureSeries.ChartType = SeriesChartType.Line;

            temperatureChartArea.AxisY.StripLines.Add(new StripLine
            {
                Interval = Convert.ToDouble(tb_T1UL.Text),
                BorderDashStyle = ChartDashStyle.Dash,
                BorderColor = System.Drawing.Color.Red,
                StripWidth = 0.1
            });

            temperatureChartArea.AxisY.StripLines.Add(new StripLine
            {
                Interval = Convert.ToDouble(tb_T1LL.Text),
                BorderDashStyle = ChartDashStyle.Dash,
                BorderColor = System.Drawing.Color.Red,
                StripWidth = 0.1
            });

            temperatureChartArea.AxisY.StripLines.Add(new StripLine
            {
                Interval = Convert.ToDouble(tb_T1SV.Text),
                BorderDashStyle = ChartDashStyle.Dash,
                BorderColor = System.Drawing.Color.Gray,
                StripWidth = 0.1
            });

            ch_Temp.ChartAreas.Add(temperatureChartArea);
            ch_Temp.Series.Add(temperatureSeries);

            humidityChartArea = new ChartArea();
            humiditySeries = new Series("Humidity");

            humidityChartArea.AxisX.Title = "Time";
            humidityChartArea.AxisY.Title = "Humidity";
            humiditySeries.ChartType = SeriesChartType.Line;

            humidityChartArea.AxisY.StripLines.Add(new StripLine
            {
                Interval = 0,
                BorderDashStyle = ChartDashStyle.Dash,
                BorderColor = System.Drawing.Color.Blue,
                StripWidth = 10
            });

            humidityChartArea.AxisY.StripLines.Add(new StripLine
            {
                Interval = 0,
                BorderDashStyle = ChartDashStyle.Dash,
                BorderColor = System.Drawing.Color.Blue,
                StripWidth = 10
            });

            ch_Humi.ChartAreas.Add(humidityChartArea);
            ch_Humi.Series.Add(humiditySeries);

            humidityChartArea.AxisY.StripLines.Add(new StripLine
            {
                Interval = 0,
                BorderDashStyle = ChartDashStyle.Dash,
                BorderColor = System.Drawing.Color.Blue,
                StripWidth = 10
            });
        }

        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            receivedDataBuffer += serialPort.ReadExisting();

            if (receivedDataBuffer.Contains("\n"))
            {
                string[] lines = receivedDataBuffer.Split('\n');
                foreach (string line in lines)
                {
                    if (!string.IsNullOrEmpty(line.Trim()))
                    {
                        ProcessData(line.Trim());
                    }
                }
                receivedDataBuffer = string.Empty;
            }
        }

        private void ProcessData(string data)
        {
            DateTime timestamp;
            string[] head = data.Split('_');
            string deviceName = head[0];
            string cmd = head[1];
            string logtype = tb_LogType.Text;
            string NoOfSensor = tb_NoOfSensors.Text;
            string logName = cmb_LogName.Text;
            if (deviceName == logName)
            {
                if (cmd == "VALUES")
                {
                    if (logtype == "Temperature")
                    {
                        if (NoOfSensor == "1")
                        {
                            string[] body = head[3].Split(' ');
                            double temp1 = double.Parse(body[0]);
                            string date = body[1];
                            string time = body[2];
                            string format = "yyyy/MM/dd HH:mm:ss";
                            string dateTimeString = $"{date} {time}";
                            tb_S1_Temp.Text = Convert.ToString(temp1);
                            tb_S1_Humi.Enabled = false;
                            gb_S2.Enabled = false;
                            gb_S3.Enabled = false;
                            gb_S4.Enabled = false;
                            ch_Temp.Enabled = true;
                            ch_Humi.Enabled = false;

                            if (DateTime.TryParseExact(dateTimeString, format, null, System.Globalization.DateTimeStyles.None, out timestamp))
                            {
                                Invoke(new Action(() =>
                                {
                                    UpdateTemperatureChart(timestamp, temp1);
                                }));
                            }
                            else
                            {
                                Console.WriteLine("Failed to parse DateTime.");
                            }

                        }
                        else if (NoOfSensor == "2")
                        {
                            string[] body = head[3].Split(' ');
                            double temp1 = double.Parse(body[0]);
                            double temp2 = double.Parse(body[1]);
                            string date = body[2];
                            string time = body[3];
                            string format = "yyyy/MM/dd HH:mm:ss";
                            string dateTimeString = $"{date} {time}";
                            tb_S1_Temp.Text = Convert.ToString(temp1);
                            tb_S1_Humi.Enabled = false;
                            gb_S2.Enabled = true;
                            tb_S2_Temp.Text = Convert.ToString(temp2);
                            tb_S2_Humi.Enabled = false;
                            gb_S3.Enabled = false;
                            gb_S4.Enabled = false;
                            ch_Temp.Enabled = true;
                            ch_Humi.Enabled = false;

                            if (DateTime.TryParseExact(dateTimeString, format, null, System.Globalization.DateTimeStyles.None, out timestamp))
                            {
                                Invoke(new Action(() =>
                                {
                                    UpdateTemperatureChart(timestamp, temp1);
                                    UpdateTemperatureChart(timestamp, temp2);
                                }));
                            }
                            else
                            {
                                Console.WriteLine("Failed to parse DateTime.");
                            }
                        }
                        else if (NoOfSensor == "3")
                        {
                            string[] body = head[3].Split(' ');
                            double temp1 = double.Parse(body[0]);
                            double temp2 = double.Parse(body[1]);
                            double temp3 = double.Parse(body[2]);
                            string date = body[3];
                            string time = body[4];
                            string format = "yyyy/MM/dd HH:mm:ss";
                            string dateTimeString = $"{date} {time}";
                            tb_S1_Temp.Text = Convert.ToString(temp1);
                            tb_S1_Humi.Enabled = false;
                            gb_S2.Enabled = true;
                            tb_S2_Temp.Text = Convert.ToString(temp2);
                            tb_S2_Humi.Enabled = false;
                            gb_S3.Enabled = true;
                            tb_S3_Temp.Text = Convert.ToString(temp3);
                            tb_S3_Humi.Enabled = false;
                            gb_S4.Enabled = false;
                            ch_Temp.Enabled = true;
                            ch_Humi.Enabled = false;

                            if (DateTime.TryParseExact(dateTimeString, format, null, System.Globalization.DateTimeStyles.None, out timestamp))
                            {
                                Invoke(new Action(() =>
                                {
                                    UpdateTemperatureChart(timestamp, temp1);
                                    UpdateTemperatureChart(timestamp, temp2);
                                    UpdateTemperatureChart(timestamp, temp3);
                                }));
                            }
                            else
                            {
                                Console.WriteLine("Failed to parse DateTime.");
                            }
                        }
                        else if (NoOfSensor == "4")
                        {
                            string[] body = head[3].Split(' ');
                            double temp1 = double.Parse(body[0]);
                            double temp2 = double.Parse(body[1]);
                            double temp3 = double.Parse(body[2]);
                            double temp4 = double.Parse(body[3]);
                            string date = body[4];
                            string time = body[5];
                            string format = "yyyy/MM/dd HH:mm:ss";
                            string dateTimeString = $"{date} {time}";
                            tb_S1_Temp.Text = Convert.ToString(temp1);
                            tb_S1_Humi.Enabled = false;
                            gb_S2.Enabled = true;
                            tb_S2_Temp.Text = Convert.ToString(temp2);
                            tb_S2_Humi.Enabled = false;
                            gb_S3.Enabled = true;
                            tb_S3_Temp.Text = Convert.ToString(temp3);
                            tb_S3_Humi.Enabled = false;
                            gb_S4.Enabled = true;
                            tb_S3_Temp.Text = Convert.ToString(temp4);
                            tb_S3_Humi.Enabled = false;
                            ch_Temp.Enabled = true;
                            ch_Humi.Enabled = false;

                            if (DateTime.TryParseExact(dateTimeString, format, null, System.Globalization.DateTimeStyles.None, out timestamp))
                            {
                                Invoke(new Action(() =>
                                {
                                    UpdateTemperatureChart(timestamp, temp1);
                                    UpdateTemperatureChart(timestamp, temp2);
                                    UpdateTemperatureChart(timestamp, temp3);
                                    UpdateTemperatureChart(timestamp, temp4);
                                }));
                            }
                            else
                            {
                                Console.WriteLine("Failed to parse DateTime.");
                            }
                        }
                    }
                    else if (logtype == "Humidity")
                    {
                        if (NoOfSensor == "1")
                        {
                            string[] body = head[2].Split(' ');
                            double humi1 = double.Parse(body[0]);
                            string date = body[1];
                            string time = body[2];
                            string format = "yyyy/MM/dd HH:mm:ss";
                            string dateTimeString = $"{date} {time}";
                            tb_S1_Humi.Text = Convert.ToString(humi1);
                            tb_S1_Temp.Enabled = false;
                            gb_S2.Enabled = false;
                            gb_S3.Enabled = false;
                            gb_S4.Enabled = false;
                            ch_Temp.Enabled = false;
                            ch_Humi.Enabled = true;

                            if (DateTime.TryParseExact(dateTimeString, format, null, System.Globalization.DateTimeStyles.None, out timestamp))
                            {
                                Invoke(new Action(() =>
                                {
                                    UpdateHumidityChart(timestamp, humi1);
                                }));
                            }
                            else
                            {
                                Console.WriteLine("Failed to parse DateTime.");
                            }
                        }
                        else if (NoOfSensor == "2")
                        {
                            string[] body = head[2].Split(' ');
                            double humi1 = double.Parse(body[0]);
                            double humi2 = double.Parse(body[1]);
                            string date = body[2];
                            string time = body[3];
                            string format = "yyyy/MM/dd HH:mm:ss";
                            string dateTimeString = $"{date} {time}";
                            tb_S1_Humi.Text = Convert.ToString(humi1);
                            tb_S1_Temp.Enabled = false;
                            gb_S2.Enabled = true;
                            tb_S2_Humi.Text = Convert.ToString(humi2);
                            tb_S2_Temp.Enabled = false;
                            gb_S3.Enabled = false;
                            gb_S4.Enabled = false;
                            ch_Temp.Enabled = false;
                            ch_Humi.Enabled = true;

                            if (DateTime.TryParseExact(dateTimeString, format, null, System.Globalization.DateTimeStyles.None, out timestamp))
                            {
                                Invoke(new Action(() =>
                                {
                                    UpdateHumidityChart(timestamp, humi1);
                                    UpdateHumidityChart(timestamp, humi2);
                                }));
                            }
                            else
                            {
                                Console.WriteLine("Failed to parse DateTime.");
                            }
                        }
                        else if (NoOfSensor == "3")
                        {
                            string[] body = head[2].Split(' ');
                            double humi1 = double.Parse(body[0]);
                            double humi2 = double.Parse(body[1]);
                            double humi3 = double.Parse(body[2]);
                            string date = body[3];
                            string time = body[4];
                            string format = "yyyy/MM/dd HH:mm:ss";
                            string dateTimeString = $"{date} {time}";
                            tb_S1_Humi.Text = Convert.ToString(humi1);
                            tb_S1_Temp.Enabled = false;
                            gb_S2.Enabled = true;
                            tb_S2_Humi.Text = Convert.ToString(humi2);
                            tb_S2_Temp.Enabled = false;
                            gb_S3.Enabled = true;
                            tb_S3_Humi.Text = Convert.ToString(humi3);
                            tb_S3_Temp.Enabled = false;
                            gb_S4.Enabled = false;
                            ch_Temp.Enabled = false;
                            ch_Humi.Enabled = true;

                            if (DateTime.TryParseExact(dateTimeString, format, null, System.Globalization.DateTimeStyles.None, out timestamp))
                            {
                                Invoke(new Action(() =>
                                {
                                    UpdateHumidityChart(timestamp, humi1);
                                    UpdateHumidityChart(timestamp, humi2);
                                    UpdateHumidityChart(timestamp, humi3);
                                }));
                            }
                            else
                            {
                                Console.WriteLine("Failed to parse DateTime.");
                            }
                        }
                        else if (NoOfSensor == "4")
                        {
                            string[] body = head[2].Split(' ');
                            double humi1 = double.Parse(body[0]);
                            double humi2 = double.Parse(body[1]);
                            double humi3 = double.Parse(body[2]);
                            double humi4 = double.Parse(body[3]);
                            string date = body[4];
                            string time = body[5];
                            string format = "yyyy/MM/dd HH:mm:ss";
                            string dateTimeString = $"{date} {time}";
                            tb_S1_Humi.Text = Convert.ToString(humi1);
                            tb_S1_Temp.Enabled = false;
                            gb_S2.Enabled = true;
                            tb_S2_Humi.Text = Convert.ToString(humi2);
                            tb_S2_Temp.Enabled = false;
                            gb_S3.Enabled = true;
                            tb_S3_Humi.Text = Convert.ToString(humi3);
                            tb_S3_Temp.Enabled = false;
                            gb_S4.Enabled = true;
                            tb_S4_Humi.Text = Convert.ToString(humi4);
                            tb_S4_Temp.Enabled = false;
                            ch_Temp.Enabled = false;
                            ch_Humi.Enabled = true;

                            if (DateTime.TryParseExact(dateTimeString, format, null, System.Globalization.DateTimeStyles.None, out timestamp))
                            {
                                Invoke(new Action(() =>
                                {
                                    UpdateHumidityChart(timestamp, humi1);
                                    UpdateHumidityChart(timestamp, humi2);
                                    UpdateHumidityChart(timestamp, humi3);
                                    UpdateHumidityChart(timestamp, humi4);
                                }));
                            }
                            else
                            {
                                Console.WriteLine("Failed to parse DateTime.");
                            }
                        }
                    }
                    else if (logtype == "Both")
                    {
                        if (NoOfSensor == "1")
                        {
                            string[] body = head[3].Split(' ');
                            double temp1 = double.Parse(body[0]);
                            double humi1 = double.Parse(body[1]);
                            string date = body[2];
                            string time = body[3];
                            string format = "yyyy/MM/dd HH:mm:ss";
                            string dateTimeString = $"{date} {time}";
                            tb_S1_Humi.Text = Convert.ToString(humi1);
                            tb_S1_Temp.Text = Convert.ToString(temp1);
                            gb_S2.Enabled = false;
                            gb_S3.Enabled = false;
                            gb_S4.Enabled = false;
                            ch_Temp.Enabled = true;
                            ch_Humi.Enabled = true;

                            if (DateTime.TryParseExact(dateTimeString, format, null, System.Globalization.DateTimeStyles.None, out timestamp))
                            {
                                Invoke(new Action(() =>
                                {
                                    UpdateTemperatureChart(timestamp, temp1);
                                    UpdateHumidityChart(timestamp, humi1);
                                }));
                            }
                            else
                            {
                                Console.WriteLine("Failed to parse DateTime.");
                            }
                        }
                        else if (NoOfSensor == "2")
                        {
                            string[] body = head[3].Split(' ');
                            double temp1 = double.Parse(body[0]);
                            double humi1 = double.Parse(body[1]);
                            double temp2 = double.Parse(body[2]);
                            double humi2 = double.Parse(body[3]);
                            string date = body[4];
                            string time = body[5];
                            string format = "yyyy/MM/dd HH:mm:ss";
                            string dateTimeString = $"{date} {time}";
                            tb_S1_Humi.Text = Convert.ToString(humi1);
                            tb_S1_Temp.Text = Convert.ToString(temp1);
                            gb_S2.Enabled = true;
                            tb_S2_Humi.Text = Convert.ToString(humi2);
                            tb_S2_Temp.Text = Convert.ToString(temp2);
                            gb_S3.Enabled = false;
                            gb_S4.Enabled = false;
                            ch_Temp.Enabled = true;
                            ch_Humi.Enabled = true;

                            if (DateTime.TryParseExact(dateTimeString, format, null, System.Globalization.DateTimeStyles.None, out timestamp))
                            {
                                Invoke(new Action(() =>
                                {
                                    UpdateTemperatureChart(timestamp, temp1);
                                    UpdateTemperatureChart(timestamp, temp2);
                                    UpdateHumidityChart(timestamp, humi1);
                                    UpdateHumidityChart(timestamp, humi2);
                                }));
                            }
                            else
                            {
                                Console.WriteLine("Failed to parse DateTime.");
                            }
                        }
                        else if (NoOfSensor == "3")
                        {
                            string[] body = head[3].Split(' ');
                            double temp1 = double.Parse(body[0]);
                            double humi1 = double.Parse(body[1]);
                            double temp2 = double.Parse(body[2]);
                            double humi2 = double.Parse(body[3]);
                            double temp3 = double.Parse(body[4]);
                            double humi3 = double.Parse(body[5]);
                            string date = body[6];
                            string time = body[7];
                            string format = "yyyy/MM/dd HH:mm:ss";
                            string dateTimeString = $"{date} {time}";
                            tb_S1_Humi.Text = Convert.ToString(humi1);
                            tb_S1_Temp.Text = Convert.ToString(temp1);
                            gb_S2.Enabled = true;
                            tb_S2_Humi.Text = Convert.ToString(humi2);
                            tb_S2_Temp.Text = Convert.ToString(temp2);
                            gb_S3.Enabled = true;
                            tb_S3_Humi.Text = Convert.ToString(humi3);
                            tb_S3_Temp.Text = Convert.ToString(temp3);
                            gb_S4.Enabled = false;
                            ch_Temp.Enabled = true;
                            ch_Humi.Enabled = true;

                            if (DateTime.TryParseExact(dateTimeString, format, null, System.Globalization.DateTimeStyles.None, out timestamp))
                            {
                                Invoke(new Action(() =>
                                {
                                    UpdateTemperatureChart(timestamp, temp1);
                                    UpdateTemperatureChart(timestamp, temp2);
                                    UpdateTemperatureChart(timestamp, temp3);
                                    UpdateHumidityChart(timestamp, humi1);
                                    UpdateHumidityChart(timestamp, humi2);
                                    UpdateHumidityChart(timestamp, humi3);
                                }));
                            }
                            else
                            {
                                Console.WriteLine("Failed to parse DateTime.");
                            }
                        }
                        else if (NoOfSensor == "4")
                        {
                            string[] body = head[3].Split(' ');
                            double temp1 = double.Parse(body[0]);
                            double humi1 = double.Parse(body[1]);
                            double temp2 = double.Parse(body[2]);
                            double humi2 = double.Parse(body[3]);
                            double temp3 = double.Parse(body[4]);
                            double humi3 = double.Parse(body[5]);
                            double temp4 = double.Parse(body[6]);
                            double humi4 = double.Parse(body[7]);
                            string date = body[8];
                            string time = body[9];
                            string format = "yyyy/MM/dd HH:mm:ss";
                            string dateTimeString = $"{date} {time}";
                            tb_S1_Humi.Text = Convert.ToString(humi1);
                            tb_S1_Temp.Text = Convert.ToString(temp1);
                            gb_S2.Enabled = true;
                            tb_S2_Humi.Text = Convert.ToString(humi2);
                            tb_S2_Temp.Text = Convert.ToString(temp2);
                            gb_S3.Enabled = true;
                            tb_S3_Humi.Text = Convert.ToString(humi3);
                            tb_S3_Temp.Text = Convert.ToString(temp3);
                            gb_S4.Enabled = true;
                            tb_S4_Humi.Text = Convert.ToString(humi4);
                            tb_S4_Temp.Text = Convert.ToString(temp4);
                            ch_Temp.Enabled = true;
                            ch_Humi.Enabled = true;

                            if (DateTime.TryParseExact(dateTimeString, format, null, System.Globalization.DateTimeStyles.None, out timestamp))
                            {
                                Invoke(new Action(() =>
                                {
                                    UpdateTemperatureChart(timestamp, temp1);
                                    UpdateTemperatureChart(timestamp, temp2);
                                    UpdateTemperatureChart(timestamp, temp3);
                                    UpdateTemperatureChart(timestamp, temp4);
                                    UpdateHumidityChart(timestamp, humi1);
                                    UpdateHumidityChart(timestamp, humi2);
                                    UpdateHumidityChart(timestamp, humi3);
                                    UpdateHumidityChart(timestamp, humi4);
                                }));
                            }
                            else
                            {
                                Console.WriteLine("Failed to parse DateTime.");
                            }
                        }
                    }
                }
            }
        }

        private void UpdateTemperatureChart(DateTime timestamp, double temperature)
        {
            temperatureSeries.Points.AddXY(timestamp, temperature);

            while (temperatureSeries.Points.Count > 20)
            {
                temperatureSeries.Points.RemoveAt(0);
            }
            ch_Temp.ResetAutoValues();
            ch_Temp.Invalidate();
        }

        private void UpdateHumidityChart(DateTime timestamp, double humidity)
        {
            humiditySeries.Points.AddXY(timestamp, humidity);

            while (humiditySeries.Points.Count > 20)
            {
                humiditySeries.Points.RemoveAt(0);
            }
            ch_Humi.ResetAutoValues();
            ch_Humi.Invalidate();
        }

        private void LiveReading_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort != null && serialPort.IsOpen)
            {
                serialPort.Close();
            }
        }

        private void cmb_LogName_TextChanged(object sender, EventArgs e)
        {
            string logName = cmb_LogName.Text;
            if (cmb_LogName.Text == "-SELECT-")
            {
                Clear();
            }
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string fillQuery = "SELECT LoggerMaster.Interval, LoggerMaster.S1Name, LoggerMaster.S2Name, LoggerMaster.S3Name, LoggerMaster.S4Name, LoggerMaster.IntervalType, LoggerConfig.S1_Temp, LoggerConfig.S2_Temp, LoggerConfig.S3_Temp, LoggerConfig.S4_Temp, LoggerConfig.S1_Humi,LoggerConfig.S2_Humi, LoggerConfig.S3_Humi, LoggerConfig.S4_Humi, LoggerConfig.S1_T_Low, LoggerConfig.S1_T_High, LoggerConfig.S1_H_Low, LoggerConfig.S1_H_High, LoggerConfig.S2_T_Low,LoggerConfig.S2_T_High, LoggerConfig.S2_H_Low, LoggerConfig.S2_H_High, LoggerConfig.S3_T_Low, LoggerConfig.S3_T_High, LoggerConfig.S3_H_Low, LoggerConfig.S3_H_High, LoggerConfig.S4_T_Low, LoggerConfig.S4_T_High, LoggerConfig.S4_H_Low, LoggerConfig.S4_H_High, LoggerMaster.LoggerType, LoggerMaster.NoOfSensors FROM LoggerMaster LEFT JOIN LoggerConfig ON LoggerMaster.LoggerID = LoggerConfig.LoggerID WHERE (LoggerMaster.LoggerName = @LogName)";
                    using (SqlCommand selectCommand = new SqlCommand(fillQuery, connection))
                    {
                        selectCommand.Parameters.AddWithValue("@LogName", logName);
                        using (SqlDataReader reader = selectCommand.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string interval = reader["Interval"].ToString();
                                gb_S1.Text = reader["S1Name"].ToString();
                                gb_S2.Text = reader["S2Name"].ToString();
                                gb_S3.Text = reader["S3Name"].ToString();
                                gb_S4.Text = reader["S4Name"].ToString();
                                string intervalType = reader["IntervalType"].ToString();
                                string Delay = $"{interval} {intervalType}";
                                tb_T1SV.Text = reader["S1_Temp"].ToString();
                                tb_T2SV.Text = reader["S2_Temp"].ToString();
                                tb_T3SV.Text = reader["S3_Temp"].ToString();
                                tb_T4SV.Text = reader["S4_Temp"].ToString();
                                tb_H1SV.Text = reader["S1_Humi"].ToString();
                                tb_H2SV.Text = reader["S2_Humi"].ToString();
                                tb_H3SV.Text = reader["S3_Humi"].ToString();
                                tb_H4SV.Text = reader["S4_Humi"].ToString();
                                tb_T1LL.Text = reader["S1_T_Low"].ToString();
                                tb_T1UL.Text = reader["S1_T_High"].ToString();
                                tb_H1LL.Text = reader["S1_H_Low"].ToString();
                                tb_H1UL.Text = reader["S1_H_High"].ToString();
                                tb_T2LL.Text = reader["S2_T_Low"].ToString();
                                tb_T2UL.Text = reader["S2_T_High"].ToString();
                                tb_H2LL.Text = reader["S2_H_Low"].ToString();
                                tb_H2UL.Text = reader["S2_H_High"].ToString();
                                tb_T3LL.Text = reader["S3_T_Low"].ToString();
                                tb_T3UL.Text = reader["S3_T_High"].ToString();
                                tb_H3LL.Text = reader["S3_H_Low"].ToString();
                                tb_H3UL.Text = reader["S3_H_High"].ToString();
                                tb_T4LL.Text = reader["S4_T_Low"].ToString();
                                tb_T4UL.Text = reader["S4_T_High"].ToString();
                                tb_H4LL.Text = reader["S4_H_Low"].ToString();
                                tb_H4UL.Text = reader["S4_H_High"].ToString();
                                tb_LogType.Text = reader["LoggerType"].ToString();
                                tb_NoOfSensors.Text = reader["NoOfSensors"].ToString();

                                InitializeCharts();
                            }
                            else
                            {
                                Clear();
                            }
                            reader.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred." + ex.Message, "Error");
            }
        }

        private void Clear()
        {
            foreach (Control control in Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Text = string.Empty;
                }
            }
            cmb_LogName.Text = "-SELECT-";
        }

        private void LiveReading_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string queryLogName = "SELECT LoggerMaster.LoggerName FROM LoggerMaster JOIN LoggerConfig ON LoggerMaster.LoggerID = LoggerConfig.LoggerID WHERE LoggerConfig.Sync = 1;";
                    using (SqlCommand command = new SqlCommand(queryLogName, connection))
                    {
                        using (SqlDataAdapter logAdapter = new SqlDataAdapter(command))
                        {
                            DataTable logDataTable = new DataTable();
                            logAdapter.Fill(logDataTable);
                            cmb_LogName.DataSource = logDataTable;
                            cmb_LogName.DisplayMember = "LoggerName";
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while refreshing data." + ex.Message, "Error");
                }
            }
        }
    }
}
