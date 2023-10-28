﻿using System;
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
                string query = "SELECT LoggerName FROM LoggerMaster";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        cmb_LoggerName.DataSource = dataTable;
                        cmb_LoggerName.DisplayMember = "LoggerName";
                        cmb_LoggerName.Text = "-SELECT-";
                    }
                }
            }
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
            try
            {
                string s1Temp = tb_S1_Temp.Text;
                string s2Temp = tb_S2_Temp.Text;
                string s3Temp = tb_S3_Temp.Text;
                string s4Temp = tb_S4_Temp.Text;
                string s1Humi = tb_S1_Humidity.Text;
                string s2Humi = tb_S2_Humidity.Text;
                string s3Humi = tb_S3_Humidity.Text;
                string s4Humi = tb_S4_Humidity.Text;
                string s1_T_UL = tb_TS1_UL.Text;
                string s2_T_UL = tb_TS2_UL.Text;
                string s3_T_UL = tb_TS3_UL.Text;
                string s4_T_UL = tb_TS4_UL.Text;
                string s1_T_LL = tb_TS1_LL.Text;
                string s2_T_LL = tb_TS2_LL.Text;
                string s3_T_LL = tb_TS3_LL.Text;
                string s4_T_LL = tb_TS4_LL.Text;
                string s1_H_UL = tb_HS1_UL.Text;
                string s2_H_UL = tb_HS2_UL.Text;
                string s3_H_UL = tb_HS3_UL.Text;
                string s4_H_UL = tb_HS4_UL.Text;
                string s1_H_LL = tb_HS1_LL.Text;
                string s2_H_LL = tb_HS2_LL.Text;
                string s3_H_LL = tb_HS3_LL.Text;
                string s4_H_LL = tb_HS4_LL.Text;
                string s1_T_Cali = tb_TS1_Calibrate.Text;
                string s2_T_Cali = tb_TS2_Calibrate.Text;
                string s3_T_Cali = tb_TS3_Calibrate.Text;
                string s4_T_Cali = tb_TS4_Calibrate.Text;
                string s1_H_Cali = tb_HS1_Calibrate.Text;
                string s2_H_Cali = tb_HS2_Calibrate.Text;
                string s3_H_Cali = tb_HS3_Calibrate.Text;
                string s4_H_Cali = tb_HS4_Calibrate.Text;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string configQuery = "INSERT INTO LoggerConfig (S1_Temp, S2_Temp, S3_Temp, S4_Temp, S1_Humi, S2_Humi, S3_Humi, S4_Humi, S1_T_Low, S1_T_High, S1_H_Low, S1_H_High, S2_T_Low, S2_T_High, S2_H_Low, S2_H_High, S3_T_Low, S3_T_High, S3_H_Low, S3_H_High, S4_T_Low, S4_T_High, S4_H_Low, S4_H_High, S1_T_Calibrate, S2_T_Calibrate, S3_T_Calibrate, S4_T_Calibrate, S1_H_Calibrate, S2_H_Calibrate, S3_H_Calibrate, S4_H_Calibrate)" +
    "VALUES (@S1_Temp, @S2_Temp, @S3_Temp, @S4_Temp, @S1_Humi, @S2_Humi, @S3_Humi, @S4_Humi, @S1_T_Low, @S1_T_High, @S1_H_Low, @S1_H_High, @S2_T_Low, @S2_T_High, @S2_H_Low, @S2_H_High, @S3_T_Low, @S3_T_High, @S3_H_Low, @S3_H_High, @S4_T_Low, @S4_T_High, @S4_H_Low, @S4_H_High, @S1_T_Calibrate, @S2_T_Calibrate, @S3_T_Calibrate, @S4_T_Calibrate, @S1_H_Calibrate, @S2_H_Calibrate, @S3_H_Calibrate, @S4_H_Calibrate);";
                    using (SqlCommand command = new SqlCommand(configQuery, connection))
                    {
                        command.Parameters.AddWithValue("@S1_Temp", s1Temp);
                        command.Parameters.AddWithValue("@S2_Temp", s2Temp);
                        command.Parameters.AddWithValue("@S3_Temp", s3Temp);
                        command.Parameters.AddWithValue("@S4_Temp", s4Temp);
                        command.Parameters.AddWithValue("@S1_Humi", s1Humi);
                        command.Parameters.AddWithValue("@S2_Humi", s2Humi);
                        command.Parameters.AddWithValue("@S3_Humi", s3Humi);
                        command.Parameters.AddWithValue("@S4_Humi", s4Humi);
                        command.Parameters.AddWithValue("@S1_T_Low", s1_T_LL);
                        command.Parameters.AddWithValue("@S1_T_High", s1_T_UL);
                        command.Parameters.AddWithValue("@S1_H_Low", s1_H_LL);
                        command.Parameters.AddWithValue("@S1_H_High", s1_H_UL);
                        command.Parameters.AddWithValue("@S2_T_Low", s2_T_LL);
                        command.Parameters.AddWithValue("@S2_T_High", s2_T_UL);
                        command.Parameters.AddWithValue("@S2_H_Low", s2_H_LL);
                        command.Parameters.AddWithValue("@S2_H_High", s2_H_UL);
                        command.Parameters.AddWithValue("@S3_T_Low", s3_T_LL);
                        command.Parameters.AddWithValue("@S3_T_High", s3_T_UL);
                        command.Parameters.AddWithValue("@S3_H_Low", s3_H_LL);
                        command.Parameters.AddWithValue("@S3_H_High", s3_H_UL);
                        command.Parameters.AddWithValue("@S4_T_Low", s4_T_LL);
                        command.Parameters.AddWithValue("@S4_T_High", s4_T_UL);
                        command.Parameters.AddWithValue("@S4_H_Low", s4_H_LL);
                        command.Parameters.AddWithValue("@S4_H_High", s4_H_UL);
                        command.Parameters.AddWithValue("@S1_T_Calibrate", s1_T_Cali);
                        command.Parameters.AddWithValue("@S2_T_Calibrate", s2_T_Cali);
                        command.Parameters.AddWithValue("@S3_T_Calibrate", s3_T_Cali);
                        command.Parameters.AddWithValue("@S4_T_Calibrate", s4_T_Cali);
                        command.Parameters.AddWithValue("@S1_H_Calibrate", s1_H_Cali);
                        command.Parameters.AddWithValue("@S2_H_Calibrate", s2_H_Cali);
                        command.Parameters.AddWithValue("@S3_H_Calibrate", s3_H_Cali);
                        command.Parameters.AddWithValue("@S4_H_Calibrate", s4_H_Cali);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Logger created successfully.", "Prompt");
                        RefreshData();
                        Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while Configuring a new Logger: " + ex.Message, "Error");
            }
        }
        private void tb_NoOfSensors_TextChanged(object sender, EventArgs e)
        {
            int selectedSensors;
            if (int.TryParse(tb_NoOfSensors.Text, out selectedSensors) && selectedSensors >= 1 && selectedSensors <= 4)
            {
                tb_S1_Name.Enabled = true;
                tb_S2_Name.Enabled = selectedSensors >= 2;
                tb_S3_Name.Enabled = selectedSensors >= 3;
                tb_S4_Name.Enabled = selectedSensors == 4;
                tb_S1_Temp.Enabled = true;
                tb_S2_Temp.Enabled = selectedSensors >= 2;
                tb_S3_Temp.Enabled = selectedSensors >= 3;
                tb_S4_Temp.Enabled = selectedSensors == 4;
                tb_S1_Humidity.Enabled = true;
                tb_S2_Humidity.Enabled = selectedSensors >= 2;
                tb_S3_Humidity.Enabled = selectedSensors >= 3;
                tb_S4_Humidity.Enabled = selectedSensors == 4;
                tb_TS1_UL.Enabled = true;
                tb_TS2_UL.Enabled = selectedSensors >= 2;
                tb_TS3_UL.Enabled = selectedSensors >= 3;
                tb_TS4_UL.Enabled = selectedSensors == 4;
                tb_TS1_LL.Enabled = true;
                tb_TS2_LL.Enabled = selectedSensors >= 2;
                tb_TS3_LL.Enabled = selectedSensors >= 3;
                tb_TS4_LL.Enabled = selectedSensors == 4;
                tb_HS1_UL.Enabled = true;
                tb_HS2_UL.Enabled = selectedSensors >= 2;
                tb_HS3_UL.Enabled = selectedSensors >= 3;
                tb_HS4_UL.Enabled = selectedSensors == 4;
                tb_HS1_LL.Enabled = true;
                tb_HS2_LL.Enabled = selectedSensors >= 2;
                tb_HS3_LL.Enabled = selectedSensors >= 3;
                tb_HS4_LL.Enabled = selectedSensors == 4;
                tb_TS1_Calibrate.Enabled = true;
                tb_TS2_Calibrate.Enabled = selectedSensors >= 2;
                tb_TS3_Calibrate.Enabled = selectedSensors >= 3;
                tb_TS4_Calibrate.Enabled = selectedSensors == 4;
                tb_HS1_Calibrate.Enabled = true;
                tb_HS2_Calibrate.Enabled = selectedSensors >= 2;
                tb_HS3_Calibrate.Enabled = selectedSensors >= 3;
                tb_HS4_Calibrate.Enabled = selectedSensors == 4;
            }
        }
    }
}
