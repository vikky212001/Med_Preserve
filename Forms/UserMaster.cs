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
        private DataTable dataTable = new DataTable();
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
                UpdateUserFields(selectedRow);
            }
        }

        private void UpdateUserFields(DataGridViewRow row)
        {
            tb_UID.Text = row.Cells[0].Value.ToString();
            tb_Name.Text = row.Cells[1].Value.ToString();
            tb_Email.Text = row.Cells[2].Value.ToString();
            tb_Mobile.Text = row.Cells[3].Value.ToString();
            tb_R_UName.Text = row.Cells[4].Value.ToString();
        }

        private void RefreshData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM UserData WHERE IsDeleted = 0";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    dataTable.Clear(); 
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
            foreach (Control control in Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Text = string.Empty;
                }
            }
            tb_UID.Text = string.Empty;
        }

        private void HandleError(string message, Exception ex)
        {
            MessageBox.Show(message + "\nError Details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void UserMaster_Load(object sender, EventArgs e)
        {
            tb_R_Pass.PasswordChar = '●';
            tb_R_ConPass.PasswordChar = '●';
            try
            {
                this.userDataTableAdapter.Fill(this.med_PreserveDataSet.UserData);
                RefreshData();
            }
            catch (Exception ex)
            {
                HandleError("An error occurred while loading data.", ex);
            }
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
                    Duplication duplication = new Duplication();

                    if (string.IsNullOrWhiteSpace(nameValue) || string.IsNullOrWhiteSpace(emailValue) ||
                        string.IsNullOrWhiteSpace(mobileValue) || string.IsNullOrWhiteSpace(userNameValue) ||
                        string.IsNullOrWhiteSpace(passValue) || string.IsNullOrWhiteSpace(tb_R_ConPass.Text))
                    {
                        MessageBox.Show("Fill in all required fields.", "Prompt");
                        return;
                    }

                    if (duplication.IsUsernameDuplicate(userNameValue))
                    {
                        MessageBox.Show("Username is already taken. Please choose a different one.", "Prompt");
                        return;
                    }

                    if (duplication.IsEmailDuplicate(emailValue))
                    {
                        MessageBox.Show("Email address is already in use. Please use a different one.", "Prompt");
                        return;
                    }

                    if (passValue != tb_R_ConPass.Text)
                    {
                        MessageBox.Show("Password and Confirm Password do not match.", "Prompt");
                        return;
                    }

                    PasswordHasher passwordHasher = new PasswordHasher();
                    string hashedPassword = passwordHasher.HashPassword(passValue);

                    string addQuery = "INSERT INTO UserData(Name, Email, Mobile, UserName, Password, IsDeleted, IsAdmin) " +
                                      "VALUES (@Name, @Email, @Mobile, @UserName, @Password, @IsDeleted, @IsAdmin);";
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
                        Clear();
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
                if (tb_UID.Text != "")
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        int primaryKeyValue;
                        if (int.TryParse(tb_UID.Text, out primaryKeyValue))
                        {
                            Audit audit = new Audit(primaryKeyValue);
                            DialogResult dialogResult = audit.ShowDialog();
                            if (dialogResult == DialogResult.OK)
                            {
                                using (SqlConnection connection = new SqlConnection(connectionString))
                                {
                                    connection.Open();
                                    string deleteQuery = "UPDATE UserData SET IsDeleted = 'True' WHERE UserID = @PrimaryKeyValue";
                                    using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                                    {
                                        command.Parameters.AddWithValue("@PrimaryKeyValue", primaryKeyValue);
                                        command.ExecuteNonQuery();
                                        MessageBox.Show("User Deleted Successfully.");
                                    }
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

        private void dgv_UserMaster_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 5) 
            {
                if (e.Value != null)
                {
                    e.Value = new string('●', 8); 
                }
            }
        }

        private void tb_Search_TextChanged(object sender, EventArgs e)
        {
            if (dataTable != null)
            {
                string searchQuery = tb_Search.Text.Trim();
                DataView dva = dataTable.DefaultView;
                dva.RowFilter = $"Name LIKE '%{searchQuery}%' OR Email LIKE '%{searchQuery}%'"; // Update the filter to search in multiple columns
                dgv_UserMaster.DataSource = dva.ToTable();
            }
        }
    }
}
