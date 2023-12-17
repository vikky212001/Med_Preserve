using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO.Ports;
using System.Windows.Forms;

namespace Med_Preserve.Forms
{
    public partial class LoggerConfig : Form
    {
        private DataTable dataTable = new DataTable();
        private string connectionString;
        private string selectedComPort;
        private SerialPort serialPort;
        public LoggerConfig(string comPort)
        {
            InitializeComponent();
            dgv_LoggerConfig.CellClick += dgv_LoggerConfig_CellClick;
            connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            selectedComPort = comPort;
            InitializeForm();
        }
        private void InitializeForm()
        {
            if (selectedComPort != null)
            {
                serialPort = new SerialPort();
                serialPort.PortName = selectedComPort;
                serialPort.BaudRate = 9600;
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
        private void LoggerConfig_Load(object sender, EventArgs e)
        {
            RefreshData();
            dgv_LoggerConfig.Columns[0].Visible = false;
            dgv_LoggerConfig.Columns[6].Visible = false;
            dgv_LoggerConfig.Columns[7].Visible = false;
            dgv_LoggerConfig.Columns[8].Visible = false;
            dgv_LoggerConfig.Columns[9].Visible = false;
            dgv_LoggerConfig.Columns[42].Visible = false;
            cmb_LoggerName.Text = "-SELECT-";
        }
        private void RefreshData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT LoggerMaster.LoggerID, LoggerMaster.LoggerName, LoggerMaster.LoggerType, LoggerMaster.NoOfSensors, LoggerMaster.AssignTo, LoggerMaster.Interval, LoggerMaster.S1Name, LoggerMaster.S2Name, LoggerMaster.S3Name, LoggerMaster.S4Name, LoggerConfig.S1_Temp, LoggerConfig.S2_Temp, LoggerConfig.S3_Temp, LoggerConfig.S4_Temp, LoggerConfig.S1_Humi,LoggerConfig.S2_Humi, LoggerConfig.S3_Humi, LoggerConfig.S4_Humi, LoggerConfig.S1_T_Low, LoggerConfig.S1_T_High, LoggerConfig.S1_H_Low, LoggerConfig.S1_H_High, LoggerConfig.S2_T_Low,LoggerConfig.S2_T_High, LoggerConfig.S2_H_Low, LoggerConfig.S2_H_High, LoggerConfig.S3_T_Low, LoggerConfig.S3_T_High, LoggerConfig.S3_H_Low, LoggerConfig.S3_H_High, LoggerConfig.S4_T_Low, LoggerConfig.S4_T_High, LoggerConfig.S4_H_Low, LoggerConfig.S4_H_High, LoggerConfig.S1_T_Calibrate, LoggerConfig.S2_T_Calibrate, LoggerConfig.S3_T_Calibrate, LoggerConfig.S4_T_Calibrate, LoggerConfig.S1_H_Calibrate, LoggerConfig.S2_H_Calibrate, LoggerConfig.S3_H_Calibrate, LoggerConfig.S4_H_Calibrate, LoggerMaster.IsConfig, LoggerConfig.Sync, LoggerConfig.Unit  FROM LoggerMaster INNER JOIN LoggerConfig ON LoggerMaster.LoggerID = LoggerConfig.LoggerID WHERE (LoggerMaster.IsActive = 1)";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    dataTable.Clear();
                    adapter.Fill(dataTable);
                    dgv_LoggerConfig.DataSource = dataTable;
                    string queryLogName = "SELECT LoggerName FROM LoggerMaster WHERE IsActive = 1 AND IsConfig = 0";
                    using (SqlCommand command = new SqlCommand(queryLogName, connection))
                    {
                        using (SqlDataAdapter logAdapter = new SqlDataAdapter(command))
                        {
                            DataTable logDataTable = new DataTable();
                            logAdapter.Fill(logDataTable);
                            cmb_LoggerName.DataSource = logDataTable;
                            cmb_LoggerName.DisplayMember = "LoggerName";
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while refreshing data." + ex.Message, "Error");
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
            cmb_LoggerName.Text = "-SELECT-";
            rb_Celcius.Checked = true;
            rb_farenheit.Checked = false;
        }
        private void dgv_LoggerConfig_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgv_LoggerConfig.Rows[e.RowIndex];
                UpdateUserFields(selectedRow);
            }
        }
        private void UpdateUserFields(DataGridViewRow row)
        {
            tb_LogID.Text = row.Cells[0].Value.ToString();
            cmb_LoggerName.Text = row.Cells[1].Value.ToString();
            tb_LogType.Text = row.Cells[2].Value.ToString();
            tb_NoOfSensors.Text = row.Cells[3].Value.ToString();
            tb_Assign.Text = row.Cells[4].Value.ToString();
            tb_Interval.Text = row.Cells[5].Value.ToString();
            tb_S1_Name.Text = row.Cells[6].Value.ToString();
            tb_S2_Name.Text = row.Cells[7].Value.ToString();
            tb_S3_Name.Text = row.Cells[8].Value.ToString();
            tb_S4_Name.Text = row.Cells[9].Value.ToString();
            tb_S1_Temp.Text = row.Cells[10].Value.ToString();
            tb_S2_Temp.Text = row.Cells[11].Value.ToString();
            tb_S3_Temp.Text = row.Cells[12].Value.ToString();
            tb_S4_Temp.Text = row.Cells[13].Value.ToString();
            tb_S1_Humidity.Text = row.Cells[14].Value.ToString();
            tb_S2_Humidity.Text = row.Cells[15].Value.ToString();
            tb_S3_Humidity.Text = row.Cells[16].Value.ToString();
            tb_S4_Humidity.Text = row.Cells[17].Value.ToString();
            tb_TS1_LL.Text = row.Cells[18].Value.ToString();
            tb_TS1_UL.Text = row.Cells[19].Value.ToString();
            tb_HS1_LL.Text = row.Cells[20].Value.ToString();
            tb_HS1_UL.Text = row.Cells[21].Value.ToString();
            tb_TS2_LL.Text = row.Cells[22].Value.ToString();
            tb_TS2_UL.Text = row.Cells[23].Value.ToString();
            tb_HS2_LL.Text = row.Cells[24].Value.ToString();
            tb_HS2_UL.Text = row.Cells[25].Value.ToString();
            tb_TS3_LL.Text = row.Cells[26].Value.ToString();
            tb_TS3_UL.Text = row.Cells[27].Value.ToString();
            tb_HS3_LL.Text = row.Cells[28].Value.ToString();
            tb_HS3_UL.Text = row.Cells[29].Value.ToString();
            tb_TS4_LL.Text = row.Cells[30].Value.ToString();
            tb_TS4_UL.Text = row.Cells[31].Value.ToString();
            tb_HS4_LL.Text = row.Cells[32].Value.ToString();
            tb_HS4_UL.Text = row.Cells[33].Value.ToString();
            tb_TS1_Calibrate.Text = row.Cells[34].Value.ToString();
            tb_TS2_Calibrate.Text = row.Cells[35].Value.ToString();
            tb_TS3_Calibrate.Text = row.Cells[36].Value.ToString();
            tb_TS4_Calibrate.Text = row.Cells[37].Value.ToString();
            tb_HS1_Calibrate.Text = row.Cells[38].Value.ToString();
            tb_HS2_Calibrate.Text = row.Cells[39].Value.ToString();
            tb_HS3_Calibrate.Text = row.Cells[40].Value.ToString();
            tb_HS4_Calibrate.Text = row.Cells[41].Value.ToString();
            tb_IsConfig.Text = row.Cells[42].Value.ToString();
            string sync = row.Cells[43].Value.ToString();
            if (sync == "True")
            {
                tb_SyncStatus.Text = "Synced";
                bt_SyncNow.Enabled = false;
            }
            else if (sync == "False")
            {
                tb_SyncStatus.Text = "Out of Sync";
                bt_SyncNow.Enabled = true;
            }
            string unit = row.Cells[44].Value.ToString();
            if (unit == "C")
            {
                rb_Celcius.Checked = true;
                rb_farenheit.Checked = false;
            }
            else if (unit == "F")
            {
                rb_farenheit.Checked = true;
                rb_Celcius.Checked = false;
            }
        }
        private void bt_Clear_Click(object sender, EventArgs e)
        {
            Clear();
        }
        private void bt_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void bt_Add_Click(object sender, EventArgs e)
        {
            bool foundEmptyActiveTextbox = false;
            bool comAvailable = false;
            string unit = "C";
            if (rb_farenheit.Checked)
            {
                unit = "F";
            }

            TextBox[] tb_Calibrate = new TextBox[]
{
    tb_TS1_Calibrate,
    tb_TS2_Calibrate,
    tb_TS3_Calibrate,
    tb_TS4_Calibrate,
    tb_HS1_Calibrate,
    tb_HS2_Calibrate,
    tb_HS3_Calibrate,
    tb_HS4_Calibrate
};

            foreach (var textBox in tb_Calibrate)
            {
                if (string.IsNullOrEmpty(textBox.Text))
                {
                    textBox.Text = "0";
                }
            }

            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    TextBox textbox = (TextBox)control;
                    if (textbox.Enabled)
                    {
                        if (string.IsNullOrWhiteSpace(textbox.Text))
                        {
                            if (textbox == tb_IsConfig || textbox == tb_SyncStatus || textbox == tb_Search)
                            {
                                continue;
                            }
                            foundEmptyActiveTextbox = true;
                        }
                    }
                }
            }
            if (foundEmptyActiveTextbox)
            {
                MessageBox.Show("Please Fill all the active Textboxes. If You Want the TextBox to Be Empty then Insert 0 in the TextBoxes", "Prompt");
            }
            else
            {
                if (selectedComPort != null)
                {
                    DialogResult result = MessageBox.Show("Do you want to Sync this data to Logger Now?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        comAvailable = true;
                        SerialWrite(unit);
                    }
                }
                try
                {
                    string[] textBoxValues = {
            tb_S1_Temp.Text, tb_S2_Temp.Text, tb_S3_Temp.Text, tb_S4_Temp.Text,
            tb_S1_Humidity.Text, tb_S2_Humidity.Text, tb_S3_Humidity.Text, tb_S4_Humidity.Text,
            tb_TS1_UL.Text, tb_TS2_UL.Text, tb_TS3_UL.Text, tb_TS4_UL.Text,
            tb_TS1_LL.Text, tb_TS2_LL.Text, tb_TS3_LL.Text, tb_TS4_LL.Text,
            tb_HS1_UL.Text, tb_HS2_UL.Text, tb_HS3_UL.Text, tb_HS4_UL.Text,
            tb_HS1_LL.Text, tb_HS2_LL.Text, tb_HS3_LL.Text, tb_HS4_LL.Text,
            tb_TS1_Calibrate.Text, tb_TS2_Calibrate.Text, tb_TS3_Calibrate.Text, tb_TS4_Calibrate.Text,
            tb_HS1_Calibrate.Text, tb_HS2_Calibrate.Text, tb_HS3_Calibrate.Text, tb_HS4_Calibrate.Text, tb_LogID.Text
        };

                    string[] parameterNames = {
            "@S1_Temp", "@S2_Temp", "@S3_Temp", "@S4_Temp",
            "@S1_Humi", "@S2_Humi", "@S3_Humi", "@S4_Humi",
            "@S1_T_High", "@S2_T_High", "@S3_T_High", "@S4_T_High",
            "@S1_T_Low", "@S2_T_Low", "@S3_T_Low", "@S4_T_Low",
            "@S1_H_High", "@S2_H_High", "@S3_H_High", "@S4_H_High",
            "@S1_H_Low", "@S2_H_Low", "@S3_H_Low", "@S4_H_Low",
            "@S1_T_Calibrate", "@S2_T_Calibrate", "@S3_T_Calibrate", "@S4_T_Calibrate",
            "@S1_H_Calibrate", "@S2_H_Calibrate", "@S3_H_Calibrate", "@S4_H_Calibrate", "@LogID"
        };

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        using (SqlTransaction trans = connection.BeginTransaction())
                        {
                            try
                            {
                                string configQuery = "INSERT INTO LoggerConfig (S1_Temp, S2_Temp, S3_Temp, S4_Temp, S1_Humi, S2_Humi, S3_Humi, S4_Humi, S1_T_Low, S1_T_High, S1_H_Low, S1_H_High, S2_T_Low, S2_T_High, S2_H_Low, S2_H_High, S3_T_Low, S3_T_High, S3_H_Low, S3_H_High, S4_T_Low, S4_T_High, S4_H_Low, S4_H_High, S1_T_Calibrate, S2_T_Calibrate, S3_T_Calibrate, S4_T_Calibrate, S1_H_Calibrate, S2_H_Calibrate, S3_H_Calibrate, S4_H_Calibrate, LoggerID, Sync, Unit) " +
                                    "VALUES (@S1_Temp, @S2_Temp, @S3_Temp, @S4_Temp, @S1_Humi, @S2_Humi, @S3_Humi, @S4_Humi, @S1_T_Low, @S1_T_High, @S1_H_Low, @S1_H_High, @S2_T_Low, @S2_T_High, @S2_H_Low, @S2_H_High, @S3_T_Low, @S3_T_High, @S3_H_Low, @S3_H_High, @S4_T_Low, @S4_T_High, @S4_H_Low, @S4_H_High, @S1_T_Calibrate, @S2_T_Calibrate, @S3_T_Calibrate, @S4_T_Calibrate, @S1_H_Calibrate, @S2_H_Calibrate, @S3_H_Calibrate, @S4_H_Calibrate, @LogID, @Sync, @Unit);";
                                string updateConfigQuery = "UPDATE LoggerMaster SET IsConfig = @IsConfig WHERE LoggerId = @LogID";
                                using (SqlCommand command = new SqlCommand(configQuery, connection, trans))
                                {
                                    for (int i = 0; i < parameterNames.Length; i++)
                                    {
                                        if (string.IsNullOrEmpty(textBoxValues[i]))
                                        {
                                            command.Parameters.AddWithValue(parameterNames[i], DBNull.Value);
                                        }
                                        else
                                        {
                                            if (int.TryParse(textBoxValues[i], out int numericValue))
                                            {
                                                command.Parameters.AddWithValue(parameterNames[i], numericValue);
                                            }
                                            else
                                            {
                                                command.Parameters.AddWithValue(parameterNames[i], DBNull.Value);
                                            }
                                        }
                                    }
                                    command.Parameters.AddWithValue("@Sync", comAvailable);
                                    command.Parameters.AddWithValue("@Unit", unit);
                                    command.ExecuteNonQuery();
                                    MessageBox.Show("Logger created successfully.", "Prompt");
                                }
                                using (SqlCommand updateConfig = new SqlCommand(updateConfigQuery, connection, trans))
                                {
                                    updateConfig.Parameters.AddWithValue("@IsConfig", "True");
                                    updateConfig.Parameters.AddWithValue("@LogID", tb_LogID.Text);
                                    updateConfig.ExecuteNonQuery();
                                }
                                trans.Commit();
                            }
                            catch (Exception ex)
                            {
                                trans.Rollback();
                                MessageBox.Show("An error occurred: " + ex.Message, "Error");
                            }
                        }
                        RefreshData();
                        Clear();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while configuring a new Logger: " + ex.Message, "Error");
                }
            }
        }
        private void cmb_LoggerName_TextChanged(object sender, EventArgs e)
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
        private void UpdateControlEnabledStatus()
        {
            string logType = tb_LogType.Text;
            int selectedSensors;

            if (int.TryParse(tb_NoOfSensors.Text, out selectedSensors) && selectedSensors >= 1 && selectedSensors <= 4)
            {
                bool isTemperature = logType == "Temperature" || logType == "Both";
                bool isHumidity = logType == "Humidity" || logType == "Both";

                tb_S1_Temp.Enabled = isTemperature;
                tb_S2_Temp.Enabled = isTemperature && selectedSensors >= 2;
                tb_S3_Temp.Enabled = isTemperature && selectedSensors >= 3;
                tb_S4_Temp.Enabled = isTemperature && selectedSensors >= 4;
                tb_S1_Humidity.Enabled = isHumidity;
                tb_S2_Humidity.Enabled = isHumidity && selectedSensors >= 2;
                tb_S3_Humidity.Enabled = isHumidity && selectedSensors >= 3;
                tb_S4_Humidity.Enabled = isHumidity && selectedSensors >= 4;
                tb_S1_Name.Enabled = true;
                tb_S2_Name.Enabled = selectedSensors >= 2;
                tb_S3_Name.Enabled = selectedSensors >= 3;
                tb_S4_Name.Enabled = selectedSensors >= 4;
                tb_TS1_UL.Enabled = isTemperature;
                tb_TS2_UL.Enabled = isTemperature && selectedSensors >= 2;
                tb_TS3_UL.Enabled = isTemperature && selectedSensors >= 3;
                tb_TS4_UL.Enabled = isTemperature && selectedSensors >= 4;
                tb_TS1_LL.Enabled = isTemperature;
                tb_TS2_LL.Enabled = isTemperature && selectedSensors >= 2;
                tb_TS3_LL.Enabled = isTemperature && selectedSensors >= 3;
                tb_TS4_LL.Enabled = isTemperature && selectedSensors >= 4;
                tb_HS1_UL.Enabled = isHumidity;
                tb_HS2_UL.Enabled = isHumidity && selectedSensors >= 2;
                tb_HS3_UL.Enabled = isHumidity && selectedSensors >= 3;
                tb_HS4_UL.Enabled = isHumidity && selectedSensors >= 4;
                tb_HS1_LL.Enabled = isHumidity;
                tb_HS2_LL.Enabled = isHumidity && selectedSensors >= 2;
                tb_HS3_LL.Enabled = isHumidity && selectedSensors >= 3;
                tb_HS4_LL.Enabled = isHumidity && selectedSensors >= 4;
                tb_TS1_Calibrate.Enabled = isTemperature;
                tb_TS2_Calibrate.Enabled = isTemperature && selectedSensors >= 2;
                tb_TS3_Calibrate.Enabled = isTemperature && selectedSensors >= 3;
                tb_TS4_Calibrate.Enabled = isTemperature && selectedSensors >= 4;
                tb_HS1_Calibrate.Enabled = isHumidity;
                tb_HS2_Calibrate.Enabled = isHumidity && selectedSensors >= 2;
                tb_HS3_Calibrate.Enabled = isHumidity && selectedSensors >= 3;
                tb_HS4_Calibrate.Enabled = isHumidity && selectedSensors >= 4;
            }
        }
        private void tb_NoOfSensors_TextChanged(object sender, EventArgs e)
        {
            UpdateControlEnabledStatus();
        }
        private void tb_LogType_TextChanged(object sender, EventArgs e)
        {
            UpdateControlEnabledStatus();
        }
        private void tb_IsConfig_TextChanged(object sender, EventArgs e)
        {
            string IsConfig = tb_IsConfig.Text;
            if (IsConfig == "True")
            {
                bt_Add.Enabled = false;
                bt_Update.Enabled = true;
            }
            else if (IsConfig == "False")
            {
                bt_Add.Enabled = true;
                bt_Update.Enabled = false;
            }
        }
        private bool AreEqual(object oldValue, string newValue)
        {
            if (oldValue is DBNull || oldValue == null)
            {
                return string.IsNullOrEmpty(newValue);
            }

            return oldValue.ToString() == newValue;
        }
        private void bt_Update_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_LogID.Text))
            {
                MessageBox.Show("Select the Data you want to update from the Data Grid View.", "Prompt");
                return;
            }
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))  
                {
                    connection.Open();
                    {
                        try
                        {
                            string unit_u = "C";
                            bool comAvailable = false;
                            if (rb_farenheit.Checked)
                            {
                                unit_u = "F";
                            }
                            bool changesFound = false;
                            string selectQuery = "SELECT S1_Temp, S2_Temp, S3_Temp, S4_Temp, " +
                                         "S1_Humi, S2_Humi, S3_Humi, S4_Humi, " +
                                         "S1_T_Low, S1_T_High, S1_H_Low, S1_H_High, " +
                                         "S2_T_Low, S2_T_High, S2_H_Low, S2_H_High, " +
                                         "S3_T_Low, S3_T_High, S3_H_Low, S3_H_High, " +
                                         "S4_T_Low, S4_T_High, S4_H_Low, S4_H_High, " +
                                         "S1_T_Calibrate, S2_T_Calibrate, S3_T_Calibrate, S4_T_Calibrate, " +
                                         "S1_H_Calibrate, S2_H_Calibrate, S3_H_Calibrate, S4_H_Calibrate, Unit " +
                                         "FROM LoggerConfig WHERE LoggerID = @LogID";

                            using (SqlCommand selectCommand = new SqlCommand(selectQuery, connection))
                            {
                                selectCommand.Parameters.AddWithValue("@LogID", tb_LogID.Text);

                                using (SqlDataReader reader = selectCommand.ExecuteReader())
                                {
                                    if (reader.Read())
                                    {
                                        if (!AreEqual(reader["S1_Temp"], tb_S1_Temp.Text)
                                    || !AreEqual(reader["S2_Temp"], tb_S2_Temp.Text)
                                    || !AreEqual(reader["S3_Temp"], tb_S3_Temp.Text)
                                    || !AreEqual(reader["S4_Temp"], tb_S4_Temp.Text)
                                    || !AreEqual(reader["S1_Humi"], tb_S1_Humidity.Text)
                                    || !AreEqual(reader["S2_Humi"], tb_S2_Humidity.Text)
                                    || !AreEqual(reader["S3_Humi"], tb_S3_Humidity.Text)
                                    || !AreEqual(reader["S4_Humi"], tb_S4_Humidity.Text)
                                    || !AreEqual(reader["S1_T_Low"], tb_TS1_LL.Text)
                                    || !AreEqual(reader["S1_T_High"], tb_TS1_UL.Text)
                                    || !AreEqual(reader["S1_H_Low"], tb_HS1_LL.Text)
                                    || !AreEqual(reader["S1_H_High"], tb_HS1_UL.Text)
                                    || !AreEqual(reader["S2_T_Low"], tb_TS2_LL.Text)
                                    || !AreEqual(reader["S2_T_High"], tb_TS2_UL.Text)
                                    || !AreEqual(reader["S2_H_Low"], tb_HS2_LL.Text)
                                    || !AreEqual(reader["S2_H_High"], tb_HS2_UL.Text)
                                    || !AreEqual(reader["S3_T_Low"], tb_TS3_LL.Text)
                                    || !AreEqual(reader["S3_T_High"], tb_TS3_UL.Text)
                                    || !AreEqual(reader["S3_H_Low"], tb_HS3_LL.Text)
                                    || !AreEqual(reader["S3_H_High"], tb_HS3_UL.Text)
                                    || !AreEqual(reader["S4_T_Low"], tb_TS4_LL.Text)
                                    || !AreEqual(reader["S4_T_High"], tb_TS4_UL.Text)
                                    || !AreEqual(reader["S4_H_Low"], tb_HS4_LL.Text)
                                    || !AreEqual(reader["S4_H_High"], tb_HS4_UL.Text)
                                    || !AreEqual(reader["S1_T_Calibrate"], tb_TS1_Calibrate.Text)
                                    || !AreEqual(reader["S2_T_Calibrate"], tb_TS2_Calibrate.Text)
                                    || !AreEqual(reader["S3_T_Calibrate"], tb_TS3_Calibrate.Text)
                                    || !AreEqual(reader["S4_T_Calibrate"], tb_TS4_Calibrate.Text)
                                    || !AreEqual(reader["S1_H_Calibrate"], tb_HS1_Calibrate.Text)
                                    || !AreEqual(reader["S2_H_Calibrate"], tb_HS2_Calibrate.Text)
                                    || !AreEqual(reader["S3_H_Calibrate"], tb_HS3_Calibrate.Text)
                                    || !AreEqual(reader["S4_H_Calibrate"], tb_HS4_Calibrate.Text)
                                    || !AreEqual(reader["Unit"], unit_u)
                                        )
                                        {
                                            changesFound = true;
                                        }
                                        if (!changesFound)
                                        {
                                            MessageBox.Show("No changes found.", "Prompt");
                                            return;
                                        }
                                    }
                                }
                                if (changesFound)
                                {
                                    if (selectedComPort != null)
                                    {
                                        DialogResult result = MessageBox.Show("Do you want to Sync this data to Logger Now?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                                        if (result == DialogResult.Yes)
                                        {
                                            comAvailable = true;
                                            SerialWrite(unit_u);
                                            
                                        }
                                    }

                                    string updateQuery = "UPDATE LoggerConfig " +
                                             "SET S1_Temp = @S1_Temp, S2_Temp = @S2_Temp, S3_Temp = @S3_Temp, S4_Temp = @S4_Temp, " +
                                             "S1_Humi = @S1_Humi, S2_Humi = @S2_Humi, S3_Humi = @S3_Humi, S4_Humi = @S4_Humi, " +
                                             "S1_T_Low = @S1_T_Low, S1_T_High = @S1_T_High, S1_H_Low = @S1_H_Low, S1_H_High = @S1_H_High, " +
                                             "S2_T_Low = @S2_T_Low, S2_T_High = @S2_T_High, S2_H_Low = @S2_H_Low, S2_H_High = @S2_H_High, " +
                                             "S3_T_Low = @S3_T_Low, S3_T_High = @S3_T_High, S3_H_Low = @S3_H_Low, S3_H_High = @S3_H_High, " +
                                             "S4_T_Low = @S4_T_Low, S4_T_High = @S4_T_High, S4_H_Low = @S4_H_Low, S4_H_High = @S4_H_High, " +
                                             "S1_T_Calibrate = @S1_T_Calibrate, S2_T_Calibrate = @S2_T_Calibrate, S3_T_Calibrate = @S3_T_Calibrate, S4_T_Calibrate = @S4_T_Calibrate, " +
                                             "S1_H_Calibrate = @S1_H_Calibrate, S2_H_Calibrate = @S2_H_Calibrate, S3_H_Calibrate = @S3_H_Calibrate, S4_H_Calibrate = @S4_H_Calibrate, Unit = @unit, Sync = @Sync " +
                                             "WHERE LoggerID = @LogID";

                                    using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                                    {
                                        updateCommand.Parameters.AddWithValue("@S1_Temp", string.IsNullOrEmpty(tb_S1_Temp.Text) ? DBNull.Value : (object)double.Parse(tb_S1_Temp.Text));
                                        updateCommand.Parameters.AddWithValue("@S2_Temp", string.IsNullOrEmpty(tb_S2_Temp.Text) ? DBNull.Value : (object)double.Parse(tb_S2_Temp.Text));
                                        updateCommand.Parameters.AddWithValue("@S3_Temp", string.IsNullOrEmpty(tb_S3_Temp.Text) ? DBNull.Value : (object)double.Parse(tb_S3_Temp.Text));
                                        updateCommand.Parameters.AddWithValue("@S4_Temp", string.IsNullOrEmpty(tb_S4_Temp.Text) ? DBNull.Value : (object)double.Parse(tb_S4_Temp.Text));
                                        updateCommand.Parameters.AddWithValue("@S1_Humi", string.IsNullOrEmpty(tb_S1_Humidity.Text) ? DBNull.Value : (object)double.Parse(tb_S1_Humidity.Text));
                                        updateCommand.Parameters.AddWithValue("@S2_Humi", string.IsNullOrEmpty(tb_S2_Humidity.Text) ? DBNull.Value : (object)double.Parse(tb_S2_Humidity.Text));
                                        updateCommand.Parameters.AddWithValue("@S3_Humi", string.IsNullOrEmpty(tb_S3_Humidity.Text) ? DBNull.Value : (object)double.Parse(tb_S3_Humidity.Text));
                                        updateCommand.Parameters.AddWithValue("@S4_Humi", string.IsNullOrEmpty(tb_S4_Humidity.Text) ? DBNull.Value : (object)double.Parse(tb_S4_Humidity.Text));
                                        updateCommand.Parameters.AddWithValue("@S1_T_Low", string.IsNullOrEmpty(tb_TS1_LL.Text) ? DBNull.Value : (object)double.Parse(tb_TS1_LL.Text));
                                        updateCommand.Parameters.AddWithValue("@S1_T_High", string.IsNullOrEmpty(tb_TS1_UL.Text) ? DBNull.Value : (object)double.Parse(tb_TS1_UL.Text));
                                        updateCommand.Parameters.AddWithValue("@S1_H_Low", string.IsNullOrEmpty(tb_HS1_LL.Text) ? DBNull.Value : (object)double.Parse(tb_HS1_LL.Text));
                                        updateCommand.Parameters.AddWithValue("@S1_H_High", string.IsNullOrEmpty(tb_HS1_UL.Text) ? DBNull.Value : (object)double.Parse(tb_HS1_UL.Text));
                                        updateCommand.Parameters.AddWithValue("@S2_T_Low", string.IsNullOrEmpty(tb_TS2_LL.Text) ? DBNull.Value : (object)double.Parse(tb_TS2_LL.Text));
                                        updateCommand.Parameters.AddWithValue("@S2_T_High", string.IsNullOrEmpty(tb_TS2_UL.Text) ? DBNull.Value : (object)double.Parse(tb_TS2_UL.Text));
                                        updateCommand.Parameters.AddWithValue("@S2_H_Low", string.IsNullOrEmpty(tb_HS2_LL.Text) ? DBNull.Value : (object)double.Parse(tb_HS2_LL.Text));
                                        updateCommand.Parameters.AddWithValue("@S2_H_High", string.IsNullOrEmpty(tb_HS2_UL.Text) ? DBNull.Value : (object)double.Parse(tb_HS2_UL.Text));
                                        updateCommand.Parameters.AddWithValue("@S3_T_Low", string.IsNullOrEmpty(tb_TS3_LL.Text) ? DBNull.Value : (object)double.Parse(tb_TS3_LL.Text));
                                        updateCommand.Parameters.AddWithValue("@S3_T_High", string.IsNullOrEmpty(tb_TS3_UL.Text) ? DBNull.Value : (object)double.Parse(tb_TS3_UL.Text));
                                        updateCommand.Parameters.AddWithValue("@S3_H_Low", string.IsNullOrEmpty(tb_HS3_LL.Text) ? DBNull.Value : (object)double.Parse(tb_HS3_LL.Text));
                                        updateCommand.Parameters.AddWithValue("@S3_H_High", string.IsNullOrEmpty(tb_HS3_UL.Text) ? DBNull.Value : (object)double.Parse(tb_HS3_UL.Text));
                                        updateCommand.Parameters.AddWithValue("@S4_T_Low", string.IsNullOrEmpty(tb_TS4_LL.Text) ? DBNull.Value : (object)double.Parse(tb_TS4_LL.Text));
                                        updateCommand.Parameters.AddWithValue("@S4_T_High", string.IsNullOrEmpty(tb_TS4_UL.Text) ? DBNull.Value : (object)double.Parse(tb_TS4_UL.Text));
                                        updateCommand.Parameters.AddWithValue("@S4_H_Low", string.IsNullOrEmpty(tb_HS4_LL.Text) ? DBNull.Value : (object)double.Parse(tb_HS4_LL.Text));
                                        updateCommand.Parameters.AddWithValue("@S4_H_High", string.IsNullOrEmpty(tb_HS4_UL.Text) ? DBNull.Value : (object)double.Parse(tb_HS4_UL.Text));
                                        updateCommand.Parameters.AddWithValue("@S1_T_Calibrate", string.IsNullOrEmpty(tb_TS1_Calibrate.Text) ? DBNull.Value : (object)double.Parse(tb_TS1_Calibrate.Text));
                                        updateCommand.Parameters.AddWithValue("@S2_T_Calibrate", string.IsNullOrEmpty(tb_TS2_Calibrate.Text) ? DBNull.Value : (object)double.Parse(tb_TS2_Calibrate.Text));
                                        updateCommand.Parameters.AddWithValue("@S3_T_Calibrate", string.IsNullOrEmpty(tb_TS3_Calibrate.Text) ? DBNull.Value : (object)double.Parse(tb_TS3_Calibrate.Text));
                                        updateCommand.Parameters.AddWithValue("@S4_T_Calibrate", string.IsNullOrEmpty(tb_TS4_Calibrate.Text) ? DBNull.Value : (object)double.Parse(tb_TS4_Calibrate.Text));
                                        updateCommand.Parameters.AddWithValue("@S1_H_Calibrate", string.IsNullOrEmpty(tb_HS1_Calibrate.Text) ? DBNull.Value : (object)double.Parse(tb_HS1_Calibrate.Text));
                                        updateCommand.Parameters.AddWithValue("@S2_H_Calibrate", string.IsNullOrEmpty(tb_HS2_Calibrate.Text) ? DBNull.Value : (object)double.Parse(tb_HS2_Calibrate.Text));
                                        updateCommand.Parameters.AddWithValue("@S3_H_Calibrate", string.IsNullOrEmpty(tb_HS3_Calibrate.Text) ? DBNull.Value : (object)double.Parse(tb_HS3_Calibrate.Text));
                                        updateCommand.Parameters.AddWithValue("@S4_H_Calibrate", string.IsNullOrEmpty(tb_HS4_Calibrate.Text) ? DBNull.Value : (object)double.Parse(tb_HS4_Calibrate.Text));
                                        updateCommand.Parameters.AddWithValue("@LogID", int.Parse(tb_LogID.Text));
                                        updateCommand.Parameters.AddWithValue("@Unit", unit_u);
                                        updateCommand.Parameters.AddWithValue("@Sync", comAvailable);

                                        int rowsAffected = updateCommand.ExecuteNonQuery();

                                        if (rowsAffected > 0)
                                        {
                                            MessageBox.Show("Record updated successfully.", "Success");
                                        }
                                        else
                                        {
                                            MessageBox.Show("Record not updated. Check your input or try again later.", "Error");
                                        }
                                    }
                                    RefreshData();
                                    Clear();
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("An error occurred: " + ex.Message, "Error");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error");
            }
        }
        private void bt_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                string logID = tb_LogID.Text;
                if (string.IsNullOrEmpty(logID)) { MessageBox.Show("Select the Data which you want to Delete from the Data Grid View.", "Prompt"); }
                else
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        using (SqlTransaction transaction = connection.BeginTransaction())
                        {
                            try
                            {
                                string deleteQuery = "DELETE FROM LoggerConfig WHERE LoggerID = @LogID";
                                using (SqlCommand deleteCommand = new SqlCommand(deleteQuery, connection, transaction))
                                {
                                    deleteCommand.Parameters.AddWithValue("@LogID", logID);
                                    int rowsAffected = deleteCommand.ExecuteNonQuery();
                                    if (rowsAffected > 0)
                                    {
                                        MessageBox.Show("Record Deleted successfully.", "Success");
                                    }
                                    else
                                    {
                                        MessageBox.Show("Record not updated. Check your input or try again later.", "Error");
                                    }
                                }
                                string updateQuery = "UPDATE LoggerMaster SET IsConfig = @IsConfig WHERE LoggerId = @LogID";
                                using (SqlCommand updateDConfig = new SqlCommand(updateQuery, connection, transaction))
                                {
                                    updateDConfig.Parameters.AddWithValue("@IsConfig", "False");
                                    updateDConfig.Parameters.AddWithValue("@LogID", tb_LogID.Text);
                                    updateDConfig.ExecuteNonQuery();
                                }
                                transaction.Commit();
                                RefreshData();
                                Clear();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("An error occurred: " + ex.Message, "Error");
                                transaction.Rollback();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error");
            }
        }
        private void tb_Search_TextChanged(object sender, EventArgs e)
        {
            if (dataTable != null)
            {
                string searchQuery = tb_Search.Text.Trim();
                DataView dva = dataTable.DefaultView;
                dva.RowFilter = $"LoggerName LIKE '%{searchQuery}%' OR AssignTo LIKE '%{searchQuery}%'";
                dgv_LoggerConfig.DataSource = dva.ToTable();
            }
        }
        private void SerialWrite(string unit)
        {
            if (serialPort != null && serialPort.IsOpen)
            {
                try
                {
                    if (tb_LogType.Text == "Temperature")
                    {
                        if (tb_NoOfSensors.Text == "1")
                        {
                            string data_t1 = cmb_LoggerName.Text + "_Config_" + tb_LogType.Text + " " + tb_NoOfSensors.Text + " " + unit + " " + tb_S1_Temp.Text + " " + tb_TS1_UL.Text + " " + tb_TS1_LL.Text + " " + tb_TS1_Calibrate.Text;
                            serialPort.Write(data_t1);
                        }
                        else if (tb_NoOfSensors.Text == "2")
                        {
                            string data_t2 = cmb_LoggerName.Text + "_Config_" + tb_LogType.Text + " " + tb_NoOfSensors.Text + " " + unit + " " + tb_S1_Temp.Text + " " + tb_TS1_UL.Text + " " + tb_TS1_LL.Text + " " + tb_TS1_Calibrate.Text + " " + tb_S2_Temp.Text + " " + tb_TS2_UL.Text + " " + tb_TS2_LL.Text + " " + tb_TS2_Calibrate.Text;
                            serialPort.Write(data_t2);
                        }
                        else if (tb_NoOfSensors.Text == "3")
                        {
                            string data_t3 = cmb_LoggerName.Text + "_Config_" + tb_LogType.Text + " " + tb_NoOfSensors.Text + " " + unit + " " + tb_S1_Temp.Text + " " + tb_TS1_UL.Text + " " + tb_TS1_LL.Text + " " + tb_TS1_Calibrate.Text + " " + tb_S2_Temp.Text + " " + tb_TS2_UL.Text + " " + tb_TS2_LL.Text + " " + tb_TS2_Calibrate.Text + " " + tb_S3_Temp.Text + " " + tb_TS3_UL.Text + " " + tb_TS3_LL.Text + " " + tb_TS3_Calibrate.Text;
                            serialPort.Write(data_t3);
                        }
                        else if (tb_NoOfSensors.Text == "4")
                        {
                            string data_t4 = cmb_LoggerName.Text + "_Config_" + tb_LogType.Text + " " + tb_NoOfSensors.Text + " " + unit + " " + tb_S1_Temp.Text + " " + tb_TS1_UL.Text + " " + tb_TS1_LL.Text + " " + tb_TS1_Calibrate.Text + " " + tb_S2_Temp.Text + " " + tb_TS2_UL.Text + " " + tb_TS2_LL.Text + " " + tb_TS2_Calibrate.Text + " " + tb_S3_Temp.Text + " " + tb_TS3_UL.Text + " " + tb_TS3_LL.Text + " " + tb_TS3_Calibrate.Text + " " + tb_S4_Temp.Text + " " + tb_TS4_UL.Text + " " + tb_TS4_LL.Text + " " + tb_TS4_Calibrate.Text;
                            serialPort.Write(data_t4);
                        }
                    }
                    else if (tb_LogType.Text == "Humidity")
                    {
                        if (tb_NoOfSensors.Text == "1")
                        {
                            string data_h1 = cmb_LoggerName.Text + "_Config_" + tb_LogType.Text + " " + tb_NoOfSensors.Text + " " + tb_S1_Humidity.Text + " " + tb_HS1_UL.Text + " " + tb_HS1_LL.Text + " " + tb_HS1_Calibrate.Text;
                            serialPort.Write(data_h1);
                        }
                        else if (tb_NoOfSensors.Text == "2")
                        {
                            string data_h2 = cmb_LoggerName.Text + "_Config_" + tb_LogType.Text + " " + tb_NoOfSensors.Text + " " + tb_S1_Humidity.Text + " " + tb_HS1_UL.Text + " " + tb_HS1_LL.Text + " " + tb_HS1_Calibrate.Text + " " + tb_S2_Humidity.Text + " " + tb_HS2_UL.Text + " " + tb_HS2_LL.Text + " " + tb_HS2_Calibrate.Text;
                            serialPort.Write(data_h2);
                        }
                        else if (tb_NoOfSensors.Text == "3")
                        {
                            string data_h3 = cmb_LoggerName.Text + "_Config_" + tb_LogType.Text + " " + tb_NoOfSensors.Text + " " + tb_S1_Humidity.Text + " " + tb_HS1_UL.Text + " " + tb_HS1_LL.Text + " " + tb_HS1_Calibrate.Text + " " + tb_S2_Humidity.Text + " " + tb_HS2_UL.Text + " " + tb_HS2_LL.Text + " " + tb_HS2_Calibrate.Text + " " + tb_S3_Humidity.Text + " " + tb_HS3_UL.Text + " " + tb_HS3_LL.Text + " " + tb_HS3_Calibrate.Text;
                            serialPort.Write(data_h3);
                        }
                        else if (tb_NoOfSensors.Text == "4")
                        {
                            string data_h4 = cmb_LoggerName.Text + "_Config_" + tb_LogType.Text + " " + tb_NoOfSensors.Text + " " + tb_S1_Humidity.Text + " " + tb_HS1_UL.Text + " " + tb_HS1_LL.Text + " " + tb_HS1_Calibrate.Text + " " + tb_S2_Humidity.Text + " " + tb_HS2_UL.Text + " " + tb_HS2_LL.Text + " " + tb_HS2_Calibrate.Text + " " + tb_S3_Humidity.Text + " " + tb_HS3_UL.Text + " " + tb_HS3_LL.Text + " " + tb_HS3_Calibrate.Text + " " + tb_S4_Humidity.Text + " " + tb_HS4_UL.Text + " " + tb_HS4_LL.Text + " " + tb_HS4_Calibrate.Text;
                            serialPort.Write(data_h4);
                        }
                    }
                    else if (tb_LogType.Text == "Both")
                    {
                        if (tb_NoOfSensors.Text == "1")
                        {
                            string data_b1 = cmb_LoggerName.Text + "_Config_" + tb_LogType.Text + " " + tb_NoOfSensors.Text + " " + unit + " " + tb_S1_Temp.Text + " " + tb_TS1_UL.Text + " " + tb_TS1_LL.Text + " " + tb_TS1_Calibrate.Text + " " + tb_S1_Humidity.Text + " " + tb_HS1_UL.Text + " " + tb_HS1_LL.Text + " " + tb_HS1_Calibrate.Text;
                            serialPort.Write(data_b1);
                        }
                        else if (tb_NoOfSensors.Text == "2")
                        {
                            string data_b2 = cmb_LoggerName.Text + "_Config_" + tb_LogType.Text + " " + tb_NoOfSensors.Text + " " + unit + " " + tb_S1_Temp.Text + " " + tb_TS1_UL.Text + " " + tb_TS1_LL.Text + " " + tb_TS1_Calibrate.Text + " " + tb_S2_Temp.Text + " " + tb_TS2_UL.Text + " " + tb_TS2_LL.Text + " " + tb_TS2_Calibrate.Text + " " + tb_S1_Humidity.Text + " " + tb_HS1_UL.Text + " " + tb_HS1_LL.Text + " " + tb_HS1_Calibrate.Text + " " + tb_S2_Humidity.Text + " " + tb_HS2_UL.Text + " " + tb_HS2_LL.Text + " " + tb_HS2_Calibrate.Text;
                            serialPort.Write(data_b2);
                        }
                        else if (tb_NoOfSensors.Text == "3")
                        {
                            string data_b3 = cmb_LoggerName.Text + "_Config_" + tb_LogType.Text + " " + tb_NoOfSensors.Text + " " + unit + " " + tb_S1_Temp.Text + " " + tb_TS1_UL.Text + " " + tb_TS1_LL.Text + " " + tb_TS1_Calibrate.Text + " " + tb_S2_Temp.Text + " " + tb_TS2_UL.Text + " " + tb_TS2_LL.Text + " " + tb_TS2_Calibrate.Text + " " + tb_S3_Temp.Text + " " + tb_TS3_UL.Text + " " + tb_TS3_LL.Text + " " + tb_TS3_Calibrate.Text + " " + tb_S1_Humidity.Text + " " + tb_HS1_UL.Text + " " + tb_HS1_LL.Text + " " + tb_HS1_Calibrate.Text + " " + tb_S2_Humidity.Text + " " + tb_HS2_UL.Text + " " + tb_HS2_LL.Text + " " + tb_HS2_Calibrate.Text + " " + tb_S3_Humidity.Text + " " + tb_HS3_UL.Text + " " + tb_HS3_LL.Text + " " + tb_HS3_Calibrate.Text;
                            serialPort.Write(data_b3);
                        }
                        else if (tb_NoOfSensors.Text == "4")
                        {
                            string data_b4 = cmb_LoggerName.Text + "_Config_" + tb_LogType.Text + " " + tb_NoOfSensors.Text + " " + unit + " " + tb_S1_Temp.Text + " " + tb_TS1_UL.Text + " " + tb_TS1_LL.Text + " " + tb_TS1_Calibrate.Text + " " + tb_S2_Temp.Text + " " + tb_TS2_UL.Text + " " + tb_TS2_LL.Text + " " + tb_TS2_Calibrate.Text + " " + tb_S3_Temp.Text + " " + tb_TS3_UL.Text + " " + tb_TS3_LL.Text + " " + tb_TS3_Calibrate.Text + " " + tb_S4_Temp.Text + " " + tb_TS4_UL.Text + " " + tb_TS4_LL.Text + " " + tb_TS4_Calibrate.Text + " " + tb_S1_Humidity.Text + " " + tb_HS1_UL.Text + " " + tb_HS1_LL.Text + " " + tb_HS1_Calibrate.Text + " " + tb_S2_Humidity.Text + " " + tb_HS2_UL.Text + " " + tb_HS2_LL.Text + " " + tb_HS2_Calibrate.Text + " " + tb_S3_Humidity.Text + " " + tb_HS3_UL.Text + " " + tb_HS3_LL.Text + " " + tb_HS3_Calibrate.Text + " " + tb_S4_Humidity.Text + " " + tb_HS4_UL.Text + " " + tb_HS4_LL.Text + " " + tb_HS4_Calibrate.Text;
                            serialPort.Write(data_b4);
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error writing to serial port: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Serial port is not open.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            if (serialPort != null && serialPort.IsOpen)
            {
                serialPort.Close();
            }
        }

        private void bt_SyncNow_Click(object sender, EventArgs e)
        {
            bool comAvailable = false;
            string unit = "C";
            if (rb_farenheit.Checked)
            {
                unit = "F";
            }
            if (selectedComPort != null)
            {
                DialogResult result = MessageBox.Show("Do you want to Sync this data to Logger Now?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    comAvailable = true;
                    SerialWrite(unit);
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        {
                            try
                            {
                                string updateQuery = "UPDATE LoggerConfig SET Sync = @Sync WHERE LoggerID = @LogID";

                                using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                                {
                                    updateCommand.Parameters.AddWithValue("@LogID", int.Parse(tb_LogID.Text));
                                    updateCommand.Parameters.AddWithValue("@Sync", comAvailable);
                                    int rowsAffected = updateCommand.ExecuteNonQuery();

                                    if (rowsAffected > 0)
                                    {
                                        MessageBox.Show("Record updated successfully.", "Success");
                                    }
                                    else
                                    {
                                        MessageBox.Show("Record not updated. Check your input or try again later.", "Error");
                                    }
                                }
                                RefreshData();
                                Clear();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("An error occurred: " + ex.Message, "Error");
                            }
                        }
                    }
                }
            }
        }

        private void LoggerConfig_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (selectedComPort != null)
            {
                if (serialPort.IsOpen)
                {
                    serialPort.Close();
                }
            }
        }
    }
}
