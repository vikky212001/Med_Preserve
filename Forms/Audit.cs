using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Med_Preserve.Forms
{
    public partial class Audit : Form { 
        private string connectionString;
        private int uid;
        public Audit(int uid)
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            this.uid = uid;
        }

        private void bt_Delete_Click(object sender, EventArgs e)
        {
            string reason = rtb_Reason.Text;
            if (reason != "")
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string deleteQuery = "UPDATE UserData SET Reason = @Reason WHERE UserID = @PrimaryKeyValue";
                    using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                    {
                        command.Parameters.AddWithValue("@PrimaryKeyValue", uid);
                        command.Parameters.AddWithValue("@Reason", reason);
                        command.ExecuteNonQuery();
                        DialogResult = DialogResult.OK;
                        Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Provide SOme Reason", "Error");
            }
        }

        private void bt_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
