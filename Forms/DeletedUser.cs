using Med_Preserve.Class;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Med_Preserve.Forms
{
    public partial class DeletedUser : Form
    {
        private DataTable dataTable = new DataTable();
        private string connectionString;

        public DeletedUser()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        }

        private void Clear()
        {
            tb_Name.Text = "";
            tb_Search.Text = "";
            tb_Email.Text = "";
            tb_Mobile.Text = "";
            tb_R_UName.Text = "";
            tb_UID.Text = "";
            rtb_Reason.Text = "";
        }

        private void RefreshData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM UserData WHERE IsDeleted = 1";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    dataTable.Clear();
                    adapter.Fill(dataTable);

                    dgv_DeletedUser.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while Refreshing Data: " + ex.Message, "Error");
                }
            }
        }

        private void DeletedUser_Load(object sender, EventArgs e)
        {
            dgv_DeletedUser.Columns[0].Visible = false;
            userDataTableAdapter.Fill(med_PreserveDataSet.UserData);
            RefreshData();
        }

        private void dgv_DeletedUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgv_DeletedUser.Rows[e.RowIndex];
                tb_UID.Text = selectedRow.Cells[0].Value.ToString();
                tb_Name.Text = selectedRow.Cells[1].Value.ToString();
                tb_Email.Text = selectedRow.Cells[2].Value.ToString();
                tb_Mobile.Text = selectedRow.Cells[3].Value.ToString();
                tb_R_UName.Text = selectedRow.Cells[4].Value.ToString();
                rtb_Reason.Text = selectedRow.Cells[6].Value.ToString();
            }
        }

        private void bt_Recover_Click(object sender, EventArgs e)
        {
            try
            {
                Duplication duplication = new Duplication();
                string userNameValue = tb_R_UName.Text;
                string emailValue = tb_Email.Text;
                int primaryKeyValue;

                if (tb_UID.Text != "")
                {
                    if (duplication.IsUsernameDuplicate(userNameValue))
                    {
                        MessageBox.Show("Username is already taken. If you want to recover this User then please provide a different User Name. ", "Prompt");
                    }
                    else if (duplication.IsEmailDuplicate(emailValue))
                    {
                        MessageBox.Show("Email address is already in use. If you want to recover this User then please provide a different Email.", "Prompt");
                    }
                    else if (!duplication.IsUsernameDuplicate(userNameValue) && !duplication.IsEmailDuplicate(emailValue))
                    {
                        DialogResult result = MessageBox.Show("Are you sure you want to Recover this User?", "Recover Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            if (int.TryParse(tb_UID.Text, out primaryKeyValue))
                            {
                                using (SqlConnection connection = new SqlConnection(connectionString))
                                {
                                    connection.Open();
                                    string recoverQuery = "UPDATE UserData SET IsDeleted = 'False', Email = @Email, UserName = @UserName WHERE UserID = @PrimaryKeyValue";
                                    using (SqlCommand command = new SqlCommand(recoverQuery, connection))
                                    {
                                        command.Parameters.AddWithValue("@UserName", userNameValue);
                                        command.Parameters.AddWithValue("@Email", emailValue);
                                        command.Parameters.AddWithValue("@PrimaryKeyValue", primaryKeyValue);
                                        command.ExecuteNonQuery();
                                        MessageBox.Show("User Recovered Successfully.");
                                        RefreshData();
                                        Clear();
                                    }
                                }
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please Select any User.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error");
            }
        }

        private void bt_Clear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void bt_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tb_Search_TextChanged(object sender, EventArgs e)
        {
            if (dataTable != null)
            {
                string searchQuery = tb_Search.Text.Trim();
                DataView dv = dataTable.DefaultView;
                dv.RowFilter = $"Name LIKE '%{searchQuery}%'";
                dgv_DeletedUser.DataSource = dv.ToTable();
            }
        }

        private void dgv_DeletedUser_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                if (e.Value != null)
                {
                    e.Value = new string('●', 8);
                }
            }
        }

        private void bt_pDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_UID.Text != "")
                {
                    int primaryKeyValue;
                    DialogResult result = MessageBox.Show("Are you sure you want to Permanently Delete this User?", "Recover Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        if (int.TryParse(tb_UID.Text, out primaryKeyValue))
                        {
                            using (SqlConnection connection = new SqlConnection(connectionString))
                            {
                                connection.Open();
                                string deleteQuery = "DELETE FROM UserData WHERE UserID = @PrimaryKeyValue";
                                using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                                {
                                    command.Parameters.AddWithValue("@PrimaryKeyValue", primaryKeyValue);
                                    command.ExecuteNonQuery();
                                    MessageBox.Show("User Deleted Successfully.");
                                    RefreshData();
                                    Clear();
                                }
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please Select any User.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error");
            }
        }
    }
}
