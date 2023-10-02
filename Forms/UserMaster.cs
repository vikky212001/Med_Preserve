using Med_Preserve.Class;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Windows.Forms;

namespace Med_Preserve.Forms
{
    public partial class UserMaster : Form
    {
        private string connectionString;
        public UserMaster()
        {
            InitializeComponent();
            dgv_UserMaster.CellClick += dgv_UserMaster_CellClick;
            connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        }
        private void dgv_UserMaster_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgv_UserMaster.Rows[e.RowIndex];

                string dg_UserID = selectedRow.Cells[0].Value.ToString();
                string dg_Name = selectedRow.Cells[1].Value.ToString();
                string dg_Email = selectedRow.Cells[2].Value.ToString();
                string dg_Mobile = selectedRow.Cells[3].Value.ToString();
                string dg_UserName = selectedRow.Cells[4].Value.ToString();

                lb_UID.Text = dg_UserID;
                tb_Name.Text = dg_Name;
                tb_Email.Text = dg_Email;
                tb_Mobile.Text = dg_Mobile;
                tb_R_UName.Text = dg_UserName;
            }
        }
        private void RefreshData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM UserData";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dgv_UserMaster.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    HandleError("An error occurred while refreshing data.", ex);
                }
            }
        }
        private void Clear()
        {
            tb_Name.Text = "";
            tb_Email.Text = "";
            tb_Mobile.Text = "";
            tb_R_ConPass.Text = "";
            tb_R_Pass.Text = "";
            tb_R_UName.Text = "";
            lb_UID.Text = "";
        }
        private void HandleError(string message, Exception ex)
        {
            MessageBox.Show(message + "\nError Details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void UserMaster_Load(object sender, EventArgs e)
        {
            try
            {
                this.userDataTableAdapter.Fill(this.med_PreserveDataSet.UserData);
            }
            catch (Exception ex)
            {
                HandleError("An error occurred while loading data.", ex);
            }
            RefreshData();
        }
        private void bt_Add_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string nameValue = tb_Name.Text;
                    string emailValue = tb_Email.Text;
                    string mobileValue = tb_Mobile.Text;
                    string userNameValue = tb_R_UName.Text;
                    string passValue = tb_R_Pass.Text;

                    if (tb_Name.Text != "" && tb_Mobile.Text != "" && tb_Email.Text != "" && tb_R_UName.Text != "" && tb_R_Pass.Text != "" && tb_R_ConPass.Text != "")
                    {
                        if (tb_R_Pass.Text == tb_R_ConPass.Text)
                        {
                            PasswordHasher passwordHasher = new PasswordHasher();
                            string hashedPassword = passwordHasher.HashPassword(passValue);

                            string addQuery = "INSERT INTO UserData(Name, Email, Mobile, UserName, Password, IsDeleted, IsAdmin) VALUES (@Name, @Email, @Mobile, @UserName, @Password, @IsDeleted, @IsAdmin);";
                            using (SqlCommand command = new SqlCommand(addQuery, connection))
                            {
                                command.Parameters.AddWithValue("@Name", nameValue);
                                command.Parameters.AddWithValue("@Email", emailValue);
                                command.Parameters.AddWithValue("@Mobile", mobileValue);
                                command.Parameters.AddWithValue("@UserName", userNameValue);
                                command.Parameters.AddWithValue("@Password", hashedPassword);
                                command.Parameters.AddWithValue("@IsDeleted", "False");
                                command.Parameters.AddWithValue("@IsAdmin", "False");
                                command.ExecuteNonQuery();
                                MessageBox.Show("User created successfully.", "Prompt");
                                RefreshData();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Password and Confirm Password do not match.", "Prompt");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Fill in all required fields.", "Prompt");
                    }
                }

            }
            catch (Exception ex)
            {
                HandleError("An error occurred while adding a new user.", ex);
            }
        }
        private void bt_Clear_Click(object sender, EventArgs e)
        {
            Clear();
        }
        private void bt_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (lb_UID.Text != "")
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        int primaryKeyValue;
                        if (int.TryParse(lb_UID.Text, out primaryKeyValue))
                        {
                            using (SqlConnection connection = new SqlConnection(connectionString))
                            {
                                connection.Open();
                                string deleteQuery = "DELETE FROM UserData WHERE UserID = @PrimaryKeyValue";
                                using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                                {
                                    command.Parameters.AddWithValue("@PrimaryKeyValue", primaryKeyValue);
                                    command.ExecuteNonQuery();
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid UserID. Please select a valid record to delete.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select one or more rows to delete.");
                }
                Clear();
                RefreshData();
            }
            catch (Exception ex)
            {
                HandleError("An error occurred while deleting the record.", ex);
            }
        }
        private void tb_Mobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void tb_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }
        private void tb_Email_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string email = tb_Email.Text.Trim();

            try
            {
                MailAddress mailAddress = new MailAddress(email);
                errorProvider.SetError(tb_Email, "");
            }
            catch (FormatException)
            {
                e.Cancel = true;
                errorProvider.SetError(tb_Email, "Invalid email format");
            }
        }
    }
}
