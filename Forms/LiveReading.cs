using System;
using System.Configuration;
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
            InitializeCharts();
        }

        private void InitializeForm()
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

        private void InitializeCharts()
        {
            temperatureChartArea = new ChartArea();
            temperatureSeries = new Series("Temperature");

            temperatureChartArea.AxisX.Title = "Time";
            temperatureChartArea.AxisY.Title = "Temperature";
            temperatureSeries.ChartType = SeriesChartType.Line;

            temperatureChartArea.AxisY.StripLines.Add(new StripLine
            {
                Interval = temperatureLimit,
                BorderDashStyle = ChartDashStyle.Dash,
                BorderColor = System.Drawing.Color.Red,
                StripWidth = 0.1 
            });

            temperatureChartArea.AxisY.StripLines.Add(new StripLine
            {
                Interval = temperatureLimit,
                BorderDashStyle = ChartDashStyle.Dash,
                BorderColor = System.Drawing.Color.Red,
                StripWidth = 0.1
            });

            temperatureChartArea.AxisY.StripLines.Add(new StripLine
            {
                Interval = temperatureLimit,
                BorderDashStyle = ChartDashStyle.Dash,
                BorderColor = System.Drawing.Color.Red,
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
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                {
                    try 
                    {
                        string selectQuery = "SELECT FROM LoggerConfig WHERE LoggerID = @LogID";
                    }
                    catch (Exception ex)
                    { MessageBox.Show("An error occurred: " + ex.Message, "Error"); }
                }
            }
            string[] values = data.Split(',');

            if (values.Length == 3)
            {
                long timestampMilliseconds = long.Parse(values[0]);
                DateTime timestamp = ;

                double temperature = double.Parse(values[1]);
                double humidity = double.Parse(values[2]);

                Invoke(new Action(() =>
                {
                    UpdateTemperatureChart(timestamp, temperature);
                    UpdateHumidityChart(timestamp, humidity);
                }));
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
            string logName = cmb_LoggerName.Text;
            if (cmb_LoggerName.Text == "-SELECT-")
            {
                Clear();
            }
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string fillQuery = "SELECT LoggerMaster.LoggerID, LoggerMaster.LoggerName, LoggerMaster.LoggerType, LoggerMaster.NoOfSensors, LoggerMaster.AssignTo, LoggerMaster.Interval, LoggerMaster.S1Name, LoggerMaster.S2Name, LoggerMaster.S3Name, LoggerMaster.S4Name, LoggerMaster.IntervalType, LoggerConfig.S1_Temp, LoggerConfig.S2_Temp, LoggerConfig.S3_Temp, LoggerConfig.S4_Temp, LoggerConfig.S1_Humi,LoggerConfig.S2_Humi, LoggerConfig.S3_Humi, LoggerConfig.S4_Humi, LoggerConfig.S1_T_Low, LoggerConfig.S1_T_High, LoggerConfig.S1_H_Low, LoggerConfig.S1_H_High, LoggerConfig.S2_T_Low,LoggerConfig.S2_T_High, LoggerConfig.S2_H_Low, LoggerConfig.S2_H_High, LoggerConfig.S3_T_Low, LoggerConfig.S3_T_High, LoggerConfig.S3_H_Low, LoggerConfig.S3_H_High, LoggerConfig.S4_T_Low, LoggerConfig.S4_T_High, LoggerConfig.S4_H_Low, LoggerConfig.S4_H_High, LoggerConfig.S1_T_Calibrate, LoggerConfig.S2_T_Calibrate, LoggerConfig.S3_T_Calibrate, LoggerConfig.S4_T_Calibrate, LoggerConfig.S1_H_Calibrate, LoggerConfig.S2_H_Calibrate, LoggerConfig.S3_H_Calibrate, LoggerConfig.S4_H_Calibrate, LoggerMaster.IsConfig FROM LoggerMaster LEFT JOIN LoggerConfig ON LoggerMaster.LoggerID = LoggerConfig.LoggerID WHERE (LoggerMaster.LoggerName = @LogName)";
                    using (SqlCommand selectCommand = new SqlCommand(fillQuery, connection))
                    {
                        selectCommand.Parameters.AddWithValue("@LogName", logName);
                        using (SqlDataReader reader = selectCommand.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                tb_LogID.Text = reader["LoggerID"].ToString();
                                tb_LogType.Text = reader["LoggerType"].ToString();
                                tb_NoOfSensors.Text = reader["NoOfSensors"].ToString();
                                tb_Assign.Text = reader["AssignTo"].ToString();
                                string interval = reader["Interval"].ToString();
                                tb_S1_Name.Text = reader["S1Name"].ToString();
                                tb_S2_Name.Text = reader["S2Name"].ToString();
                                tb_S3_Name.Text = reader["S3Name"].ToString();
                                tb_S4_Name.Text = reader["S4Name"].ToString();
                                string intervalType = reader["IntervalType"].ToString();
                                tb_Interval.Text = $"{interval} {intervalType}";
                                tb_S1_Temp.Text = reader["S1_Temp"].ToString();
                                tb_S2_Temp.Text = reader["S2_Temp"].ToString();
                                tb_S3_Temp.Text = reader["S3_Temp"].ToString();
                                tb_S4_Temp.Text = reader["S4_Temp"].ToString();
                                tb_S1_Humidity.Text = reader["S1_Humi"].ToString();
                                tb_S2_Humidity.Text = reader["S2_Humi"].ToString();
                                tb_S3_Humidity.Text = reader["S3_Humi"].ToString();
                                tb_S4_Humidity.Text = reader["S4_Humi"].ToString();
                                tb_TS1_LL.Text = reader["S1_T_Low"].ToString();
                                tb_TS1_UL.Text = reader["S1_T_High"].ToString();
                                tb_HS1_LL.Text = reader["S1_H_Low"].ToString();
                                tb_HS1_UL.Text = reader["S1_H_High"].ToString();
                                tb_TS2_LL.Text = reader["S2_T_Low"].ToString();
                                tb_TS2_UL.Text = reader["S2_T_High"].ToString();
                                tb_HS2_LL.Text = reader["S2_H_Low"].ToString();
                                tb_HS2_UL.Text = reader["S2_H_High"].ToString();
                                tb_TS3_LL.Text = reader["S3_T_Low"].ToString();
                                tb_TS3_UL.Text = reader["S3_T_High"].ToString();
                                tb_HS3_LL.Text = reader["S3_H_Low"].ToString();
                                tb_HS3_UL.Text = reader["S3_H_High"].ToString();
                                tb_TS4_LL.Text = reader["S4_T_Low"].ToString();
                                tb_TS4_UL.Text = reader["S4_T_High"].ToString();
                                tb_HS4_LL.Text = reader["S4_H_Low"].ToString();
                                tb_HS4_UL.Text = reader["S4_H_High"].ToString();
                                tb_TS1_Calibrate.Text = reader["S1_T_Calibrate"].ToString();
                                tb_TS2_Calibrate.Text = reader["S2_T_Calibrate"].ToString();
                                tb_TS3_Calibrate.Text = reader["S3_T_Calibrate"].ToString();
                                tb_TS4_Calibrate.Text = reader["S4_T_Calibrate"].ToString();
                                tb_HS1_Calibrate.Text = reader["S1_H_Calibrate"].ToString();
                                tb_HS2_Calibrate.Text = reader["S2_H_Calibrate"].ToString();
                                tb_HS3_Calibrate.Text = reader["S3_H_Calibrate"].ToString();
                                tb_HS4_Calibrate.Text = reader["S4_H_Calibrate"].ToString();
                                tb_IsConfig.Text = reader["IsConfig"].ToString();
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
    }
}
