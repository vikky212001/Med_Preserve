using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.IO.Ports;
using System.Text;
using System.Windows.Forms;

namespace Med_Preserve.Forms
{
    public partial class DownloadData : Form
    {
        private string selectedComPort;
        private string connectionString;
        private SerialPort serialPort;
        private StringBuilder receivedData = new StringBuilder();
        private int totalDataLength;

        public DownloadData(string comPort)
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            selectedComPort = comPort;
            InitializeSerialPorts();
            bt_Download.Click += bt_Download_Click;
        }

        private void InitializeSerialPorts()
        {
            if (selectedComPort == null)
            {
                MessageBox.Show("No COM Port Selected", "Error");
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

        private void DownloadData_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (selectedComPort != null)
            {
                if (serialPort.IsOpen)
                {
                    serialPort.Close();
                }
            }
        }

        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (cmb_LogName.InvokeRequired)
            {
                cmb_LogName.Invoke(new MethodInvoker(delegate
                {
                    ProcessDataOnUIThread();
                }));
            }
            else
            {
                ProcessDataOnUIThread();
            }
        }

        private void ProcessDataOnUIThread()
        {
            // Read available data without waiting for a specific marker
            receivedData.Append(serialPort.ReadLine());

            // Check if the received data contains the expected message
            string message = $"{cmb_LogName.Text}_DOWN";
            if (receivedData.ToString().Contains(message))
            {
                totalDataLength = receivedData.Length;

                // Continue reading and processing data until encountering "EndOfFileMarker"
                while (receivedData.ToString().Contains("EndOfFileMarker"))
                {
                    // Process data and update ProgressBar
                    int chunkSize = 100; // Adjust the chunk size based on your data

                    // Ensure there's enough data to process
                    if (receivedData.Length > chunkSize)
                    {
                        string chunkData = receivedData.ToString().Substring(0, chunkSize);

                        // Invoke UI update on the main thread
                        Invoke(new Action(() => ProcessCSVData(chunkData)));

                        receivedData.Remove(0, chunkSize);
                    }

                    // Update ProgressBar value
                    int progressPercentage = (int)((double)(totalDataLength - receivedData.Length) / totalDataLength * 100);
                    // Invoke UI update on the main thread
                    Invoke(new Action(() => progressBar1.Value = progressPercentage));
                }

                // Hide the ProgressBar when data processing is complete
                Invoke(new Action(() => progressBar1.Visible = false));

                // Invoke UI update on the main thread
                Invoke(new Action(() => ProcessCSVData(receivedData.ToString())));

                // Clear the received data for the next batch
                receivedData.Clear();

                if (serialPort.IsOpen)
                {
                    string selectedDeviceName = cmb_LogName.Text;
                    if (!string.IsNullOrEmpty(selectedDeviceName))
                    {
                        string completionMessage = $"{selectedDeviceName}_DATHARVAD";
                        serialPort.Write(completionMessage);
                    }
                    else
                    {
                        MessageBox.Show("Please select a device name from the ComboBox.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Serial port is not open.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }




        private void ProcessCSVData(string csvData)
        {
            SaveToFile(csvData);
            DataTable csvDataTable = ParseCSVToDataTable(csvData);
            dataGridView1.DataSource = csvDataTable;
            progressBar1.Value = 100;
        }

        private void SaveToFile(string data)
        {
            string folderPath = "Resources";
            string fileName = "buffer.csv";
            string filePath = Path.Combine(folderPath, fileName);
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                sw.Write(data);
            }
        }

        private void DownloadData_Load(object sender, EventArgs e)
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

        private void bt_Download_Click(object sender, EventArgs e)
        {
            if (cmb_LogName.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a device name from the ComboBox.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string selectedDeviceName = cmb_LogName.Text;
            string message = $"{selectedDeviceName}_ATHARVA";
            if (serialPort.IsOpen)
            {
                serialPort.Write(message);
            }
            else
            {
                MessageBox.Show("Serial port is not open.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private DataTable ParseCSVToDataTable(string csvData)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Logger", typeof(string));
            dataTable.Columns.Add("Temperature", typeof(double));
            dataTable.Columns.Add("Humidity", typeof(int));
            dataTable.Columns.Add("Unit", typeof(string));
            dataTable.Columns.Add("Time", typeof(string));
            dataTable.Columns.Add("Date", typeof(DateTime));
            string[] lines = csvData.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string line in lines)
            {
                string[] values = line.Split(',');

                if (values.Length == 6)
                {
                    DataRow row = dataTable.NewRow();

                    row["Logger"] = values[0].Trim();
                    row["Temperature"] = double.Parse(values[1].Trim());
                    row["Humidity"] = int.Parse(values[2].Trim());
                    row["Unit"] = values[3].Trim();
                    row["Time"] = values[4].Trim();
                    row["Date"] = DateTime.Parse(values[5].Trim());

                    dataTable.Rows.Add(row);
                }
            }

            return dataTable;
        }

    }
}
