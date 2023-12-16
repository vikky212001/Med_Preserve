using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.IO.Ports;
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
                tb_SerialPort.Text = selectedComPort;
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

        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string data = serialPort.ReadLine();
            string[] head = data.Split('_');
            if (head.Length == 3 || head.Length == 4)
            {
                string deviceName = head[0];
                string cmd = head[1];
                string logName = string.Empty; 
                string logType = string.Empty; 
                string SensorCount = string.Empty;
                Invoke(new Action(() =>
                {
                    logName = cmb_LogName.Text;
                    logType = tb_LogType.Text;
                    SensorCount = tb_NoOfSensors.Text;
                }));
                if (deviceName == logName)
                {
                    if (cmd == "VALUES")
                    {
                        if (logType == "Temperature")
                        {
                            string[] body = head[3].Split(' ');
                            if (SensorCount == "1")
                            {
                                double temp1 = 0;
                                string Etemp1 = body[0];
                                string dateTimeString = body[1] + " " + body[2];
                                DateTime timeStamp;
                                DateTime date = DateTime.MinValue;
                                TimeSpan time = TimeSpan.Zero;
                                if (DateTime.TryParseExact(dateTimeString, "yyyy/MM/dd H:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, out timeStamp))
                                {
                                    date = timeStamp.Date;
                                    time = timeStamp.TimeOfDay;
                                }
                                else
                                {
                                    Console.WriteLine("Timestamp Parsing failed.");
                                }
                                double.TryParse(Etemp1, out temp1);
                                Invoke(new Action(() =>
                                {
                                    tb_S1_Temp.Text = (temp1 != 0) ? temp1.ToString() : Etemp1;
                                    tb_Time.Text = time.ToString();
                                    tb_Date.Text = date.ToString();
                                }));

                            }
                            else if (SensorCount == "2")
                            {
                                double temp1, temp2 = 0;
                                string Etemp1 = body[0];
                                string Etemp2 = body[1];
                                string dateTimeString = body[2] + " " + body[3];
                                DateTime timeStamp;
                                DateTime date = DateTime.MinValue;
                                TimeSpan time = TimeSpan.Zero;
                                if (DateTime.TryParseExact(dateTimeString, "yyyy/MM/dd H:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, out timeStamp))
                                {
                                    date = timeStamp.Date;
                                    time = timeStamp.TimeOfDay;
                                }
                                else
                                {
                                    Console.WriteLine("Timestamp Parsing failed.");
                                }
                                double.TryParse(Etemp1, out temp1);
                                double.TryParse(Etemp2, out temp2);
                                Invoke(new Action(() =>
                                {
                                    tb_S1_Temp.Text = (temp1 != 0) ? temp1.ToString() : Etemp1;
                                    tb_S2_Temp.Text = (temp2 != 0) ? temp2.ToString() : Etemp2;
                                    tb_Time.Text = time.ToString();
                                    tb_Date.Text = date.ToString();
                                }));
                            }
                            else if (SensorCount == "3")
                            {
                                double temp1, temp2, temp3 = 0;
                                string Etemp1 = body[0];
                                string Etemp2 = body[1];
                                string Etemp3 = body[2];
                                string dateTimeString = body[3] + " " + body[4];
                                DateTime timeStamp;
                                DateTime date = DateTime.MinValue;
                                TimeSpan time = TimeSpan.Zero;
                                if (DateTime.TryParseExact(dateTimeString, "yyyy/MM/dd H:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, out timeStamp))
                                {
                                    date = timeStamp.Date;
                                    time = timeStamp.TimeOfDay;
                                }
                                else
                                {
                                    Console.WriteLine("Timestamp Parsing failed.");
                                }
                                double.TryParse(Etemp1, out temp1);
                                double.TryParse(Etemp2, out temp2);
                                double.TryParse(Etemp3, out temp3);
                                Invoke(new Action(() =>
                                {
                                    tb_S1_Temp.Text = (temp1 != 0) ? temp1.ToString() : Etemp1;
                                    tb_S2_Temp.Text = (temp2 != 0) ? temp2.ToString() : Etemp2;
                                    tb_S3_Temp.Text = (temp3 != 0) ? temp3.ToString() : Etemp3;
                                    tb_Time.Text = time.ToString();
                                    tb_Date.Text = date.ToString();
                                }));
                            }
                            else if (SensorCount == "4")
                            {
                                double temp1, temp2, temp3, temp4 = 0;
                                string Etemp1 = body[0];
                                string Etemp2 = body[1];
                                string Etemp3 = body[2];
                                string Etemp4 = body[3];
                                string dateTimeString = body[4] + " " + body[5];
                                DateTime timeStamp;
                                DateTime date = DateTime.MinValue;
                                TimeSpan time = TimeSpan.Zero;
                                if (DateTime.TryParseExact(dateTimeString, "yyyy/MM/dd H:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, out timeStamp))
                                {
                                    date = timeStamp.Date;
                                    time = timeStamp.TimeOfDay;
                                }
                                else
                                {
                                    Console.WriteLine("Timestamp Parsing failed.");
                                }
                                double.TryParse(Etemp1, out temp1);
                                double.TryParse(Etemp2, out temp2);
                                double.TryParse(Etemp3, out temp3);
                                double.TryParse(Etemp4, out temp4);
                                Invoke(new Action(() =>
                                {
                                    tb_S1_Temp.Text = (temp1 != 0) ? temp1.ToString() : Etemp1;
                                    tb_S2_Temp.Text = (temp2 != 0) ? temp2.ToString() : Etemp2;
                                    tb_S3_Temp.Text = (temp3 != 0) ? temp3.ToString() : Etemp3;
                                    tb_S4_Temp.Text = (temp4 != 0) ? temp4.ToString() : Etemp4;
                                    tb_Time.Text = time.ToString();
                                    tb_Date.Text = date.ToString();
                                }));
                            }
                        }
                        else if (logType == "Humidity")
                        {
                            string[] body = head[2].Split(' ');
                            if (SensorCount == "1")
                            {
                                int humi1 = 0;
                                string Ehumi1 = body[0];
                                string dateTimeString = body[1] + " " + body[2];
                                DateTime timeStamp;
                                DateTime date = DateTime.MinValue;
                                TimeSpan time = TimeSpan.Zero;
                                if (DateTime.TryParseExact(dateTimeString, "yyyy/MM/dd H:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, out timeStamp))
                                {
                                    date = timeStamp.Date;
                                    time = timeStamp.TimeOfDay;
                                }
                                else
                                {
                                    Console.WriteLine("Timestamp Parsing failed.");
                                }
                                int.TryParse(Ehumi1, out humi1);
                                Invoke(new Action(() =>
                                {
                                    tb_S1_Humi.Text = (humi1 != 0) ? humi1.ToString() : Ehumi1;
                                    tb_Time.Text = time.ToString();
                                    tb_Date.Text = date.ToString();
                                }));

                            }
                            else if (SensorCount == "2")
                            {
                                int humi1, humi2 = 0;
                                string Ehumi1 = body[0];
                                string Ehumi2 = body[1];
                                string dateTimeString = body[2] + " " + body[3];
                                DateTime timeStamp;
                                DateTime date = DateTime.MinValue;
                                TimeSpan time = TimeSpan.Zero;
                                if (DateTime.TryParseExact(dateTimeString, "yyyy/MM/dd H:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, out timeStamp))
                                {
                                    date = timeStamp.Date;
                                    time = timeStamp.TimeOfDay;
                                }
                                else
                                {
                                    Console.WriteLine("Timestamp Parsing failed.");
                                }
                                int.TryParse(Ehumi1, out humi1);
                                int.TryParse(Ehumi2, out humi2);
                                Invoke(new Action(() =>
                                {
                                    tb_S1_Humi.Text = (humi1 != 0) ? humi1.ToString() : Ehumi1;
                                    tb_S2_Humi.Text = (humi2 != 0) ? humi2.ToString() : Ehumi2;
                                    tb_Time.Text = time.ToString();
                                    tb_Date.Text = date.ToString();
                                }));
                            }
                            else if (SensorCount == "3")
                            {
                                int humi1, humi2, humi3 = 0;
                                string Ehumi1 = body[0];
                                string Ehumi2 = body[1];
                                string Ehumi3 = body[2];
                                string dateTimeString = body[3] + " " + body[4];
                                DateTime timeStamp;
                                DateTime date = DateTime.MinValue;
                                TimeSpan time = TimeSpan.Zero;
                                if (DateTime.TryParseExact(dateTimeString, "yyyy/MM/dd H:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, out timeStamp))
                                {
                                    date = timeStamp.Date;
                                    time = timeStamp.TimeOfDay;
                                }
                                else
                                {
                                    Console.WriteLine("Timestamp Parsing failed.");
                                }
                                int.TryParse(Ehumi1, out humi1);
                                int.TryParse(Ehumi2, out humi2);
                                int.TryParse(Ehumi3, out humi3);
                                Invoke(new Action(() =>
                                {
                                    tb_S1_Humi.Text = (humi1 != 0) ? humi1.ToString() : Ehumi1;
                                    tb_S2_Humi.Text = (humi2 != 0) ? humi2.ToString() : Ehumi2;
                                    tb_S3_Humi.Text = (humi3 != 0) ? humi3.ToString() : Ehumi3;
                                    tb_Time.Text = time.ToString();
                                    tb_Date.Text = date.ToString();
                                }));
                            }
                            else if (SensorCount == "4")
                            {
                                int humi1, humi2, humi3, humi4 = 0;
                                string Ehumi1 = body[0];
                                string Ehumi2 = body[1];
                                string Ehumi3 = body[2];
                                string Ehumi4 = body[3];
                                string dateTimeString = body[4] + " " + body[5];
                                DateTime timeStamp;
                                DateTime date = DateTime.MinValue;
                                TimeSpan time = TimeSpan.Zero;
                                if (DateTime.TryParseExact(dateTimeString, "yyyy/MM/dd H:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, out timeStamp))
                                {
                                    date = timeStamp.Date;
                                    time = timeStamp.TimeOfDay;
                                }
                                else
                                {
                                    Console.WriteLine("Timestamp Parsing failed.");
                                }
                                int.TryParse(Ehumi1, out humi1);
                                int.TryParse(Ehumi2, out humi2);
                                int.TryParse(Ehumi3, out humi3);
                                int.TryParse(Ehumi4, out humi4);
                                Invoke(new Action(() =>
                                {
                                    tb_S1_Humi.Text = (humi1 != 0) ? humi1.ToString() : Ehumi1;
                                    tb_S2_Humi.Text = (humi2 != 0) ? humi2.ToString() : Ehumi2;
                                    tb_S3_Humi.Text = (humi3 != 0) ? humi3.ToString() : Ehumi3;
                                    tb_S4_Humi.Text = (humi4 != 0) ? humi4.ToString() : Ehumi4;
                                    tb_Time.Text = time.ToString();
                                    tb_Date.Text = date.ToString();
                                }));
                            }
                        }
                        else if (logType == "Both")
                        {
                            string[] body = head[3].Split(' ');
                            if (SensorCount == "1")
                            {
                                double temp1 = 0;
                                int humi1 = 0;
                                string Etemp1 = body[0];
                                string Ehumi1 = body[1];
                                string dateTimeString = body[2] + " " + body[3];
                                string dateTime = dateTimeString.Trim();
                                DateTime timeStamp;
                                DateTime date = DateTime.MinValue;
                                TimeSpan time = TimeSpan.Zero;
                                if (DateTime.TryParseExact(dateTime, "yyyy/MM/dd H:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, out timeStamp))
                                {
                                    date = timeStamp.Date;
                                    time = timeStamp.TimeOfDay;
                                }
                                else
                                {
                                    Console.WriteLine("Timestamp Parsing failed.");
                                }
                                double.TryParse(Etemp1, out temp1);
                                int.TryParse(Ehumi1, out humi1);
                                Invoke(new Action(() =>
                                {
                                    tb_S1_Temp.Text = (temp1 != 0) ? temp1.ToString() : Etemp1;
                                    tb_S1_Humi.Text = (humi1 != 0) ? humi1.ToString() : Ehumi1;
                                    tb_Time.Text = time.ToString(@"hh\:mm\:ss");  
                                    tb_Date.Text = date.ToString("yyyy/MM/dd"); //working here this block is correct now mimic this in other if else statements
                                }));

                            }
                            else if (SensorCount == "2")
                            {
                                double temp1, temp2 = 0;
                                int humi1, humi2 = 0;
                                string Etemp1 = body[0];
                                string Ehumi1 = body[1];
                                string Etemp2 = body[2];
                                string Ehumi2 = body[3];
                                string dateTimeString = body[4] + " " + body[5];
                                DateTime timeStamp;
                                DateTime date = DateTime.MinValue;
                                TimeSpan time = TimeSpan.Zero;
                                if (DateTime.TryParseExact(dateTimeString, "yyyy/MM/dd H:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, out timeStamp))
                                {
                                    date = timeStamp.Date;
                                    time = timeStamp.TimeOfDay;
                                }
                                else
                                {
                                    Console.WriteLine("Timestamp Parsing failed.");
                                }
                                double.TryParse(Etemp1, out temp1);
                                int.TryParse(Ehumi1, out humi1);
                                double.TryParse(Etemp2, out temp2);
                                int.TryParse(Ehumi2, out humi2);
                                Invoke(new Action(() =>
                                {
                                    tb_S1_Temp.Text = (temp1 != 0) ? temp1.ToString() : Etemp1;
                                    tb_S1_Humi.Text = (humi1 != 0) ? humi1.ToString() : Ehumi1;
                                    tb_S2_Temp.Text = (temp2 != 0) ? temp2.ToString() : Etemp2;
                                    tb_S2_Humi.Text = (humi2 != 0) ? humi2.ToString() : Ehumi2;
                                    tb_Time.Text = time.ToString();
                                    tb_Date.Text = date.ToString();
                                }));
                            }
                            else if (SensorCount == "3")
                            {
                                double temp1, temp2, temp3 = 0;
                                int humi1, humi2, humi3 = 0;
                                string Etemp1 = body[0];
                                string Ehumi1 = body[1];
                                string Etemp2 = body[2];
                                string Ehumi2 = body[3];
                                string Etemp3 = body[4];
                                string Ehumi3 = body[5];
                                string dateTimeString = body[6] + " " + body[7];
                                DateTime timeStamp;
                                DateTime date = DateTime.MinValue;
                                TimeSpan time = TimeSpan.Zero;
                                if (DateTime.TryParseExact(dateTimeString, "yyyy/MM/dd H:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, out timeStamp))
                                {
                                    date = timeStamp.Date;
                                    time = timeStamp.TimeOfDay;
                                }
                                else
                                {
                                    Console.WriteLine("Timestamp Parsing failed.");
                                }
                                double.TryParse(Etemp1, out temp1);
                                int.TryParse(Ehumi1, out humi1);
                                double.TryParse(Etemp2, out temp2);
                                int.TryParse(Ehumi2, out humi2);
                                double.TryParse(Etemp3, out temp3);
                                int.TryParse(Ehumi3, out humi3);
                                Invoke(new Action(() =>
                                {
                                    tb_S1_Temp.Text = (temp1 != 0) ? temp1.ToString() : Etemp1;
                                    tb_S1_Humi.Text = (humi1 != 0) ? humi1.ToString() : Ehumi1;
                                    tb_S2_Temp.Text = (temp2 != 0) ? temp2.ToString() : Etemp2;
                                    tb_S2_Humi.Text = (humi2 != 0) ? humi2.ToString() : Ehumi2;
                                    tb_S3_Temp.Text = (temp3 != 0) ? temp3.ToString() : Etemp3;
                                    tb_S3_Humi.Text = (humi3 != 0) ? humi3.ToString() : Ehumi3;
                                    tb_Time.Text = time.ToString();
                                    tb_Date.Text = date.ToString();
                                }));
                            }
                            else if (SensorCount == "4")
                            {
                                double temp1, temp2, temp3, temp4 = 0;
                                int humi1, humi2, humi3, humi4 = 0;
                                string Etemp1 = body[0];
                                string Ehumi1 = body[1];
                                string Etemp2 = body[2];
                                string Ehumi2 = body[3];
                                string Etemp3 = body[4];
                                string Ehumi3 = body[5];
                                string Etemp4 = body[6];
                                string Ehumi4 = body[7];
                                string dateTimeString = body[8] + " " + body[9];
                                DateTime timeStamp;
                                DateTime date = DateTime.MinValue;
                                TimeSpan time = TimeSpan.Zero;
                                if (DateTime.TryParseExact(dateTimeString, "yyyy/MM/dd H:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, out timeStamp))
                                {
                                    date = timeStamp.Date;
                                    time = timeStamp.TimeOfDay;
                                }
                                else
                                {
                                    Console.WriteLine("Timestamp Parsing failed.");
                                }
                                double.TryParse(Etemp1, out temp1);
                                int.TryParse(Ehumi1, out humi1);
                                double.TryParse(Etemp2, out temp2);
                                int.TryParse(Ehumi2, out humi2);
                                double.TryParse(Etemp3, out temp3);
                                int.TryParse(Ehumi3, out humi3);
                                double.TryParse(Etemp4, out temp4);
                                int.TryParse(Ehumi4, out humi4);
                                Invoke(new Action(() =>
                                {
                                    tb_S1_Temp.Text = (temp1 != 0) ? temp1.ToString() : Etemp1;
                                    tb_S1_Humi.Text = (humi1 != 0) ? humi1.ToString() : Ehumi1;
                                    tb_S2_Temp.Text = (temp2 != 0) ? temp2.ToString() : Etemp2;
                                    tb_S2_Humi.Text = (humi2 != 0) ? humi2.ToString() : Ehumi2;
                                    tb_S3_Temp.Text = (temp3 != 0) ? temp3.ToString() : Etemp3;
                                    tb_S3_Humi.Text = (humi3 != 0) ? humi3.ToString() : Ehumi3;
                                    tb_S4_Temp.Text = (temp4 != 0) ? temp4.ToString() : Etemp4;
                                    tb_S4_Humi.Text = (humi4 != 0) ? humi4.ToString() : Ehumi4;
                                    tb_Time.Text = time.ToString();
                                    tb_Date.Text = date.ToString();
                                }));
                            }
                        }
                    }
                }
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
                                tb_S1_Temp.Text = " ";
                                tb_S1_Humi.Text = " ";
                                tb_S2_Temp.Text = " ";
                                tb_S2_Humi.Text = " ";
                                tb_S3_Temp.Text = " ";
                                tb_S3_Humi.Text = " ";
                                tb_S4_Temp.Text = " ";
                                tb_S4_Humi.Text = " ";
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

        private void RealTimeData_Load(object sender, EventArgs e)
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
