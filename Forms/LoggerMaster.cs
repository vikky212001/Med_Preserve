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
            this.loggerMasterTableAdapter.Fill(this.med_PreserveDataSet.LoggerMaster);
            dgv_LoggerMaster.Columns[0].Visible = false;
            dgv_LoggerMaster.Columns[10].Visible = false;
            cmb_NoOfSensors.Text = "-SELECT-";
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
        }
        private void RefreshData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM LoggerMaster Where IsActive = 1";
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
            int noOfSensors;
            if (!int.TryParse(cmb_NoOfSensors.Text, out noOfSensors))
            {
                MessageBox.Show("Please select a valid number of sensors.", "Prompt");
                return;
            }
            string assign = cmb_AssignTo.Text;
            string interval = string.IsNullOrWhiteSpace(tb_Interval.Text) ? "300000" : tb_Interval.Text;
            object sensor_1 = DBNull.Value;
            object sensor_2 = DBNull.Value;
            object sensor_3 = DBNull.Value;
            object sensor_4 = DBNull.Value;
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
            string logType = "Default";
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
                    string addQuery = "INSERT INTO LoggerMaster (LoggerName, LoggerType, NoOfSensors, AssignTo, Interval, S1Name, S2Name, S3Name, S4Name, IsActive, CreatedDate)" +
                    "VALUES (@LoggerName , @LoggerType , @NoOfSensors , @AssignTo , @Interval , @S1Name , @S2Name , @S3Name , @S4Name , @IsActive , @Date );";
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
    }
}
