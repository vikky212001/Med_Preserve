using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void bt_Add_Click(object sender, EventArgs e)
        {

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
    }
}
