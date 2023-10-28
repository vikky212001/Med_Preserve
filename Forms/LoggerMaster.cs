using Med_Preserve.Class;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Med_Preserve.Forms
{
    public partial class LoggerMaster : Form
    {
        private string connectionString;
        private DataTable dataTable = new DataTable();
        public LoggerMaster()
        {
            InitializeComponent();
            dgv_LoggerMaster.CellClick += dgv_LoggerMaster_CellClick;
            connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        }
        private void LoggerMaster_Load(object sender, EventArgs e)
        {
            RefreshData();
            dgv_LoggerMaster.Columns[0].Visible = false;
            dgv_LoggerMaster.Columns[10].Visible = false;
            dgv_LoggerMaster.Columns[12].Visible = false;
            cmb_NoOfSensors.Text = "-SELECT-";
            cmb_IntervalType.Text = "-SELECT-";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT CompanyName FROM CompanyMaster";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        cmb_AssignTo.DataSource = dataTable;
                        cmb_AssignTo.DisplayMember = "CompanyName";
                        cmb_AssignTo.Text = "-SELECT-";
                    }
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
            cmb_AssignTo.Text = "-SELECT-";
            cmb_NoOfSensors.Text = "-SELECT-";
            cmb_IntervalType.Text = "-SELECT-";
        }
        private void RefreshData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM LoggerMaster WHERE IsActive = 1";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    dataTable.Clear();
                    adapter.Fill(dataTable);
                    dgv_LoggerMaster.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while adding a new Logger.", ex.Message);
                }
            }
        }
        private void bt_Add_Click(object sender, EventArgs e)
        {
            string logName = tb_LogName.Text;
            string assign = cmb_AssignTo.Text;
            string interval = string.IsNullOrWhiteSpace(tb_Interval.Text) ? "300" : tb_Interval.Text;
            object sensor_1 = DBNull.Value;
            object sensor_2 = DBNull.Value;
            object sensor_3 = DBNull.Value;
            object sensor_4 = DBNull.Value;
            string logType = "Default";
            string intervalType = string.IsNullOrWhiteSpace(tb_Interval.Text) ? "sec" : cmb_IntervalType.Text;
            int noOfSensors;
            if (!int.TryParse(cmb_NoOfSensors.Text, out noOfSensors))
            {
                MessageBox.Show("Please select a valid number of sensors.", "Prompt");
                return;
            }
            if (cmb_IntervalType.Text == "min")
            {
                interval = $"{interval:D2}:{0:D2}";
            }
            if (noOfSensors >= 1)
            {
                sensor_1 = string.IsNullOrWhiteSpace(tb_S1_Name.Text) ? "Sensor 1" : tb_S1_Name.Text;
            }
            if (noOfSensors >= 2)
            {
                sensor_2 = string.IsNullOrWhiteSpace(tb_S2_Name.Text) ? "Sensor 2" : tb_S2_Name.Text;
            }
            if (noOfSensors >= 3)
            {
                sensor_3 = string.IsNullOrWhiteSpace(tb_S3_Name.Text) ? "Sensor 3" : tb_S3_Name.Text;
            }
            if (noOfSensors >= 4)
            {
                sensor_4 = string.IsNullOrWhiteSpace(tb_S4_Name.Text) ? "Sensor 4" : tb_S4_Name.Text;
            }
            if (rb_Temp.Checked)
            {
                logType = "Temperature";
            }
            else if (rb_humidity.Checked)
            {
                logType = "Humidity";
            }
            else if (rb_both.Checked)
            {
                logType = "Both";
            }
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    DateTime selectedDateTime = DateTime.Now;
                    string FDateTime = selectedDateTime.ToString("yyyy-MM-dd HH:mm");
                    Duplication duplication = new Duplication();
                    if (string.IsNullOrWhiteSpace(logName) || noOfSensors <= 0 || string.IsNullOrWhiteSpace(assign) || logType == "Default")
                    {
                        MessageBox.Show("Fill in all required fields.", "Prompt");
                        return;
                    }
                    if (duplication.IsLoggerName(logName))
                    {
                        MessageBox.Show("Logger Name is already taken. Please choose a different one.", "Prompt");
                        return;
                    }
                    string addQuery = "INSERT INTO LoggerMaster (LoggerName, LoggerType, NoOfSensors, AssignTo, Interval, S1Name, S2Name, S3Name, S4Name, IsActive, CreatedDate, IntervalType)" +
                    "VALUES (@LoggerName , @LoggerType , @NoOfSensors , @AssignTo , @Interval , @S1Name , @S2Name , @S3Name , @S4Name , @IsActive , @Date, @IntervalType);";
                    using (SqlCommand command = new SqlCommand(addQuery, connection))
                    {
                        command.Parameters.AddWithValue("@LoggerName", logName);
                        command.Parameters.AddWithValue("@LoggerType", logType);
                        command.Parameters.AddWithValue("@NoOfSensors", noOfSensors);
                        command.Parameters.AddWithValue("@AssignTo", assign);
                        command.Parameters.AddWithValue("@Interval", interval);
                        command.Parameters.AddWithValue("@S1Name", sensor_1);
                        command.Parameters.AddWithValue("@S2Name", sensor_2);
                        command.Parameters.AddWithValue("@S3Name", sensor_3);
                        command.Parameters.AddWithValue("@S4Name", sensor_4);
                        command.Parameters.AddWithValue("@IsActive", true);
                        command.Parameters.AddWithValue("@Date", FDateTime);
                        command.Parameters.AddWithValue("@IntervalType", intervalType);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Logger created successfully.", "Prompt");
                        RefreshData();
                        Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while adding a new Logger: " + ex.Message, "Error");
            }
        }
        private void bt_Clear_Click(object sender, EventArgs e)
        {
            Clear();
        }
        private void dgv_LoggerMaster_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgv_LoggerMaster.Rows[e.RowIndex];
                UpdateUserFields(selectedRow);
            }
        }
        private void UpdateUserFields(DataGridViewRow row)
        {
            tb_LogID.Text = row.Cells[0].Value.ToString();
            tb_LogName.Text = row.Cells[1].Value.ToString();
            string logType = row.Cells[2].Value.ToString();
            cmb_NoOfSensors.Text = row.Cells[3].Value.ToString();
            cmb_AssignTo.Text = row.Cells[4].Value.ToString();
            tb_Interval.Text = row.Cells[5].Value.ToString();
            tb_S1_Name.Text = row.Cells[6].Value.ToString();
            tb_S2_Name.Text = row.Cells[7].Value.ToString();
            tb_S3_Name.Text = row.Cells[8].Value.ToString();
            tb_S4_Name.Text = row.Cells[9].Value.ToString();
            tb_CreatedDate.Text = row.Cells[11].Value.ToString();
            cmb_IntervalType.Text = row.Cells[12].Value.ToString();
            switch (logType)
            {
                case "Temperature":
                    rb_Temp.Checked = true;
                    rb_humidity.Checked = false;
                    rb_both.Checked = false;
                    break;
                case "Humidity":
                    rb_Temp.Checked = false;
                    rb_humidity.Checked = true;
                    rb_both.Checked = false;
                    break;
                case "Both":
                    rb_Temp.Checked = false;
                    rb_humidity.Checked = false;
                    rb_both.Checked = true;
                    break;
                default:
                    rb_Temp.Checked = false;
                    rb_humidity.Checked = false;
                    rb_both.Checked = false;
                    break;
            }
        }
        private void bt_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void cmb_NoOfSensors_TextChanged(object sender, EventArgs e)
        {
            int selectedSensors;
            if (int.TryParse(cmb_NoOfSensors.Text, out selectedSensors) && selectedSensors >= 1 && selectedSensors <= 4)
            {
                tb_S1_Name.Enabled = true;
                tb_S2_Name.Enabled = selectedSensors >= 2;
                tb_S3_Name.Enabled = selectedSensors >= 3;
                tb_S4_Name.Enabled = selectedSensors == 4;
            }
        }
        private void bt_Update_Click(object sender, EventArgs e)
        {
            string logID = tb_LogID.Text;
            string newLogName = tb_LogName.Text;
            int newNoOfSensors;
            if (!int.TryParse(cmb_NoOfSensors.Text, out newNoOfSensors))
            {
                MessageBox.Show("Please select a Logger From Data Grid View to Update.", "Prompt");
                return;
            }
            string newLogType = "Default";
            string newAssign = cmb_AssignTo.Text;
            string newInterval = string.IsNullOrWhiteSpace(tb_Interval.Text) ? "300" : tb_Interval.Text;
            string newIntervalType = cmb_IntervalType.Text;
            object newSensor_1 = DBNull.Value;
            object newSensor_2 = DBNull.Value;
            object newSensor_3 = DBNull.Value;
            object newSensor_4 = DBNull.Value;
            if (newNoOfSensors >= 1)
            {
                newSensor_1 = string.IsNullOrWhiteSpace(tb_S1_Name.Text) ? "Sensor 1" : tb_S1_Name.Text;
                newSensor_2 = "";
                newSensor_3 = "";
                newSensor_4 = "";
            }
            if (newNoOfSensors >= 2)
            {
                newSensor_1 = string.IsNullOrWhiteSpace(tb_S1_Name.Text) ? "Sensor 1" : tb_S1_Name.Text;
                newSensor_2 = string.IsNullOrWhiteSpace(tb_S2_Name.Text) ? "Sensor 2" : tb_S2_Name.Text;
                newSensor_3 = "";
                newSensor_4 = "";
            }
            if (newNoOfSensors >= 3)
            {
                newSensor_1 = string.IsNullOrWhiteSpace(tb_S1_Name.Text) ? "Sensor 1" : tb_S1_Name.Text;
                newSensor_2 = string.IsNullOrWhiteSpace(tb_S2_Name.Text) ? "Sensor 2" : tb_S2_Name.Text;
                newSensor_3 = string.IsNullOrWhiteSpace(tb_S3_Name.Text) ? "Sensor 3" : tb_S3_Name.Text;
                newSensor_4 = "";
            }
            if (newNoOfSensors >= 4)
            {
                newSensor_1 = string.IsNullOrWhiteSpace(tb_S1_Name.Text) ? "Sensor 1" : tb_S1_Name.Text;
                newSensor_2 = string.IsNullOrWhiteSpace(tb_S2_Name.Text) ? "Sensor 2" : tb_S2_Name.Text;
                newSensor_3 = string.IsNullOrWhiteSpace(tb_S3_Name.Text) ? "Sensor 3" : tb_S3_Name.Text;
                newSensor_4 = string.IsNullOrWhiteSpace(tb_S4_Name.Text) ? "Sensor 4" : tb_S4_Name.Text;
            }
            if (rb_Temp.Checked)
            {
                newLogType = "Temperature";
            }
            else if (rb_humidity.Checked)
            {
                newLogType = "Humidity";
            }
            else if (rb_both.Checked)
            {
                newLogType = "Both";
            }
            if (string.IsNullOrWhiteSpace(newLogName) || newNoOfSensors <= 0 || string.IsNullOrWhiteSpace(newAssign) || newLogType == "Default")
            {
                MessageBox.Show("Select any Record from Datagrid View.", "Prompt");
                return;
            }
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string selectQuery = "SELECT LoggerName, LoggerType, NoOfSensors, AssignTo, Interval, S1Name, S2Name, S3Name, S4Name, IntervalType FROM LoggerMaster WHERE LoggerID = @LogID";
                    using (SqlCommand selectCommand = new SqlCommand(selectQuery, connection))
                    {
                        selectCommand.Parameters.AddWithValue("@LogID", logID);
                        using (SqlDataReader reader = selectCommand.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string oldLogName = reader["LoggerName"].ToString();
                                string oldLogType = reader["LoggerType"].ToString();
                                int oldNoOfSensors = Convert.ToInt32(reader["NoOfSensors"].ToString());
                                string oldAssign = reader["AssignTo"].ToString();
                                string oldInterval = reader["Interval"].ToString();
                                string oldS1Name = reader["S1Name"].ToString();
                                string oldS2Name = reader["S2Name"].ToString();
                                string oldS3Name = reader["S3Name"].ToString();
                                string oldS4Name = reader["S4Name"].ToString();
                                string oldIntervalType = reader["IntervalType"].ToString();
                                if (string.Equals(oldLogName, newLogName) && string.Equals(oldLogType, newLogType) && oldNoOfSensors == newNoOfSensors && string.Equals(oldAssign, newAssign) && string.Equals(oldInterval, newInterval) && string.Equals(oldS1Name, newSensor_1) && string.Equals(oldS2Name, newSensor_2) && string.Equals(oldS3Name, newSensor_3) && string.Equals(oldS4Name, newSensor_4) && string.Equals(oldIntervalType, newIntervalType))
                                {
                                    MessageBox.Show("No Changes Found.", "Prompt");
                                }
                                else
                                {
                                    string updateQuery = "UPDATE LoggerMaster SET LoggerName = @LoggerName , LoggerType = @LoggerType, NoOfSensors = @NoOfSensors, AssignTo = @AssignTo, Interval = @Interval, S1Name = @S1Name, S2Name = @S2Name, S3Name = @S3Name, S4Name = @S4Name, IntervalType = @IntervalType  WHERE LoggerID = @LogID";
                                    reader.Close();
                                    using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                                    {
                                        updateCommand.Parameters.AddWithValue("@LoggerName", newLogName);
                                        updateCommand.Parameters.AddWithValue("@LoggerType", newLogType);
                                        updateCommand.Parameters.AddWithValue("@NoOfSensors", newNoOfSensors);
                                        updateCommand.Parameters.AddWithValue("@AssignTo", newAssign);
                                        updateCommand.Parameters.AddWithValue("@Interval", newInterval);
                                        updateCommand.Parameters.AddWithValue("@S1Name", newSensor_1);
                                        updateCommand.Parameters.AddWithValue("@S2Name", newSensor_2);
                                        updateCommand.Parameters.AddWithValue("@S3Name", newSensor_3);
                                        updateCommand.Parameters.AddWithValue("@S4Name", newSensor_4);
                                        updateCommand.Parameters.AddWithValue("@IntervalType", newIntervalType);
                                        updateCommand.Parameters.AddWithValue("@LogID", logID);

                                        int rowsAffected = updateCommand.ExecuteNonQuery();
                                        if (rowsAffected > 0)
                                        {
                                            MessageBox.Show("Record updated successfully.", "Success");
                                            RefreshData();
                                            Clear();
                                        }
                                        else
                                        {
                                            MessageBox.Show("Record not updated. Check your input or try again later.", "Error");
                                        }
                                    }
                                }
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
                        string deleteQuery = "UPDATE LoggerMaster SET IsActive = 0 WHERE LoggerID = @LogID";
                        using (SqlCommand deleteCommand = new SqlCommand(deleteQuery, connection))
                        {
                            deleteCommand.Parameters.AddWithValue("@LogID", logID);
                            int rowsAffected = deleteCommand.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Record Deleted successfully.", "Success");
                                RefreshData();
                                Clear();
                            }
                            else
                            {
                                MessageBox.Show("Record not updated. Check your input or try again later.", "Error");
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

        private void cmb_IntervalType_TextChanged(object sender, EventArgs e)
        {
            if (tb_LogID.Text != "")
            {
                string interval = tb_Interval.Text;
                if (interval != "")
                {
                    if (cmb_IntervalType.Text == "sec")
                    {
                        string[] delay = interval.Split(':');
                        if (delay.Length == 2)
                        {
                            int min = Convert.ToInt32(delay[0]);
                            int sec = Convert.ToInt32(delay[1]);
                            tb_Interval.Text = Convert.ToString((min * 60) + sec);
                        }
                    }
                    if (cmb_IntervalType.Text == "min")
                    {
                        int min = 0;
                        if (interval.Contains(":"))
                        {
                            tb_Interval.Text = interval;
                        }
                        else
                        {
                            int time = Convert.ToInt32(interval);
                            while (time >= 60)
                            {
                                time -= 60;
                                min++;
                            }
                            string formatTime = $"{min:D2}:{time:D2}";
                            tb_Interval.Text = formatTime;
                        }
                    }
                }
            }
        }
    }
}