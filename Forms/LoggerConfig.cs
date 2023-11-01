using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Med_Preserve.Forms
{
    public partial class LoggerConfig : Form
    {
        private DataTable dataTable = new DataTable();
        private string connectionString;
        public LoggerConfig()
        {
            InitializeComponent();
            dgv_LoggerConfig.CellClick += dgv_LoggerConfig_CellClick;
            connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        }
        private void LoggerConfig_Load(object sender, EventArgs e)
        {
            RefreshData();
            dgv_LoggerConfig.Columns[0].Visible = false;
            dgv_LoggerConfig.Columns[6].Visible = false;
            dgv_LoggerConfig.Columns[7].Visible = false;
            dgv_LoggerConfig.Columns[8].Visible = false;
            dgv_LoggerConfig.Columns[9].Visible = false;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT LoggerName FROM LoggerMaster WHERE IsActive = 1";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        cmb_LoggerName.DataSource = dataTable;
                        cmb_LoggerName.DisplayMember = "LoggerName";

                    }
                }
            }
            cmb_LoggerName.Text = "-SELECT-";
        }
        private void RefreshData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT LoggerMaster.LoggerID, LoggerMaster.LoggerName, LoggerMaster.LoggerType, LoggerMaster.NoOfSensors, LoggerMaster.AssignTo, LoggerMaster.Interval, LoggerMaster.S1Name, LoggerMaster.S2Name, LoggerMaster.S3Name, LoggerMaster.S4Name, LoggerConfig.S1_Temp, LoggerConfig.S2_Temp, LoggerConfig.S3_Temp, LoggerConfig.S4_Temp, LoggerConfig.S1_Humi,LoggerConfig.S2_Humi, LoggerConfig.S3_Humi, LoggerConfig.S4_Humi, LoggerConfig.S1_T_Low, LoggerConfig.S1_T_High, LoggerConfig.S1_H_Low, LoggerConfig.S1_H_High, LoggerConfig.S2_T_Low,LoggerConfig.S2_T_High, LoggerConfig.S2_H_Low, LoggerConfig.S2_H_High, LoggerConfig.S3_T_Low, LoggerConfig.S3_T_High, LoggerConfig.S3_H_Low, LoggerConfig.S3_H_High, LoggerConfig.S4_T_Low, LoggerConfig.S4_T_High, LoggerConfig.S4_H_Low, LoggerConfig.S4_H_High, LoggerConfig.S1_T_Calibrate, LoggerConfig.S2_T_Calibrate, LoggerConfig.S3_T_Calibrate, LoggerConfig.S4_T_Calibrate, LoggerConfig.S1_H_Calibrate, LoggerConfig.S2_H_Calibrate, LoggerConfig.S3_H_Calibrate, LoggerConfig.S4_H_Calibrate FROM LoggerMaster INNER JOIN LoggerConfig ON LoggerMaster.LoggerID = LoggerConfig.LoggerID WHERE (LoggerMaster.IsActive = 1)";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    dataTable.Clear();
                    adapter.Fill(dataTable);
                    dgv_LoggerConfig.DataSource = dataTable;
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

            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    TextBox textbox = (TextBox)control;
                    if (textbox.Enabled)
                    {
                        if (string.IsNullOrWhiteSpace(textbox.Text))
                        {
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
                        string configQuery = "INSERT INTO LoggerConfig (S1_Temp, S2_Temp, S3_Temp, S4_Temp, S1_Humi, S2_Humi, S3_Humi, S4_Humi, S1_T_Low, S1_T_High, S1_H_Low, S1_H_High, S2_T_Low, S2_T_High, S2_H_Low, S2_H_High, S3_T_Low, S3_T_High, S3_H_Low, S3_H_High, S4_T_Low, S4_T_High, S4_H_Low, S4_H_High, S1_T_Calibrate, S2_T_Calibrate, S3_T_Calibrate, S4_T_Calibrate, S1_H_Calibrate, S2_H_Calibrate, S3_H_Calibrate, S4_H_Calibrate, LoggerID) " +
                            "VALUES (@S1_Temp, @S2_Temp, @S3_Temp, @S4_Temp, @S1_Humi, @S2_Humi, @S3_Humi, @S4_Humi, @S1_T_Low, @S1_T_High, @S1_H_Low, @S1_H_High, @S2_T_Low, @S2_T_High, @S2_H_Low, @S2_H_High, @S3_T_Low, @S3_T_High, @S3_H_Low, @S3_H_High, @S4_T_Low, @S4_T_High, @S4_H_Low, @S4_H_High, @S1_T_Calibrate, @S2_T_Calibrate, @S3_T_Calibrate, @S4_T_Calibrate, @S1_H_Calibrate, @S2_H_Calibrate, @S3_H_Calibrate, @S4_H_Calibrate, @LogID);";

                        using (SqlCommand command = new SqlCommand(configQuery, connection))
                        {
                            for (int i = 0; i < parameterNames.Length; i++)
                            {
                                if (string.IsNullOrEmpty(textBoxValues[i]))
                                {
                                    command.Parameters.AddWithValue(parameterNames[i], DBNull.Value);
                                }
                                else
                                {
                                    // Attempt to convert the string to a numeric data type (e.g., int)
                                    if (int.TryParse(textBoxValues[i], out int numericValue))
                                    {
                                        command.Parameters.AddWithValue(parameterNames[i], numericValue);
                                    }
                                    else
                                    {
                                        // Handle the case where the string cannot be converted to a numeric value
                                        command.Parameters.AddWithValue(parameterNames[i], DBNull.Value);
                                    }
                                }
                            }

                            command.ExecuteNonQuery();
                            MessageBox.Show("Logger created successfully.", "Prompt");
                            RefreshData();
                            Clear();
                        }
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
                    string fillQuery = "SELECT LoggerMaster.LoggerID, LoggerMaster.LoggerName, LoggerMaster.LoggerType, LoggerMaster.NoOfSensors, LoggerMaster.AssignTo, LoggerMaster.Interval, LoggerMaster.S1Name, LoggerMaster.S2Name, LoggerMaster.S3Name, LoggerMaster.S4Name, LoggerMaster.IntervalType, LoggerConfig.S1_Temp, LoggerConfig.S2_Temp, LoggerConfig.S3_Temp, LoggerConfig.S4_Temp, LoggerConfig.S1_Humi,LoggerConfig.S2_Humi, LoggerConfig.S3_Humi, LoggerConfig.S4_Humi, LoggerConfig.S1_T_Low, LoggerConfig.S1_T_High, LoggerConfig.S1_H_Low, LoggerConfig.S1_H_High, LoggerConfig.S2_T_Low,LoggerConfig.S2_T_High, LoggerConfig.S2_H_Low, LoggerConfig.S2_H_High, LoggerConfig.S3_T_Low, LoggerConfig.S3_T_High, LoggerConfig.S3_H_Low, LoggerConfig.S3_H_High, LoggerConfig.S4_T_Low, LoggerConfig.S4_T_High, LoggerConfig.S4_H_Low, LoggerConfig.S4_H_High, LoggerConfig.S1_T_Calibrate, LoggerConfig.S2_T_Calibrate, LoggerConfig.S3_T_Calibrate, LoggerConfig.S4_T_Calibrate, LoggerConfig.S1_H_Calibrate, LoggerConfig.S2_H_Calibrate, LoggerConfig.S3_H_Calibrate, LoggerConfig.S4_H_Calibrate FROM LoggerMaster LEFT JOIN LoggerConfig ON LoggerMaster.LoggerID = LoggerConfig.LoggerID WHERE (LoggerMaster.LoggerName = @LogName)";
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
    }
}
