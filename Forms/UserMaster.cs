using Med_Preserve.Class;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
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

                var selectedUserIDs = dgv_UserMaster.Tag as List<dynamic>;
                if (selectedUserIDs != null)
                {
                    int userID = selectedUserIDs.ElementAtOrDefault(e.RowIndex)?.UserID ?? -1; 
                    tb_UID.Text = userID.ToString();
                }
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
                    string query = "SELECT UserData.*, Role.RoleType FROM UserData " +
                       "INNER JOIN Role ON UserData.RoleID = Role.RoleID Where IsDeleted = 0";
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
            cmb_Role.Text = "-SELECT-";
        }

        private void HandleError(string message, Exception ex)
        {
            MessageBox.Show(message + "\nError Details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void UserMaster_Load(object sender, EventArgs e)
        {
            try
            {
                if (med_PreserveDataSet.UserData.Rows.Count == 0)
                {
                    this.userDataTableAdapter.Fill(this.med_PreserveDataSet.UserData);
                }
                tb_R_Pass.PasswordChar = '●';
                tb_R_ConPass.PasswordChar = '●';
                
                dgv_UserMaster.Columns[0].Visible = false;
                dgv_UserMaster.Columns[7].Visible = false;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT RoleType FROM Role";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            cmb_Role.Items.Insert(0, "-Select-");
                            cmb_Role.DataSource = dataTable;
                            cmb_Role.DisplayMember = "RoleType";
                            cmb_Role.Text = "-SELECT-";
                        }
                    }
                }
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
                    DateTime selectedDateTime = DateTime.Now;
                    string FDateTime = selectedDateTime.ToString("yyyy-MM-dd HH:mm");
                    int index = cmb_Role.SelectedIndex + 1;
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

                    string addQuery = "INSERT INTO UserData(Name, Email, Mobile, UserName, Password, IsDeleted, RoleID, CreatedDate) " +
                                      "VALUES (@Name, @Email, @Mobile, @UserName, @Password, @IsDeleted, @RoleID, @Date);";
                    using (SqlCommand command = new SqlCommand(addQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Name", nameValue);
                        command.Parameters.AddWithValue("@Email", emailValue);
                        command.Parameters.AddWithValue("@Mobile", mobileValue);
                        command.Parameters.AddWithValue("@UserName", userNameValue);
                        command.Parameters.AddWithValue("@Password", hashedPassword);
                        command.Parameters.AddWithValue("@IsDeleted", "False");
                        command.Parameters.AddWithValue("@RoleID", index);
                        command.Parameters.AddWithValue("@Date", FDateTime);
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

        private void bt_Update_Click(object sender, EventArgs e)
        {
            string primaryKeyValue = tb_UID.Text;
            string newName = tb_Name.Text;
            string newEmail = tb_Email.Text;
            string newMobile = tb_Mobile.Text;
            string newUserName = tb_R_UName.Text;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    try
                    {
                        string selectQuery = "SELECT Name, Email, Mobile, UserName FROM UserData WHERE UserID = @UID";
                        using (SqlCommand selectCommand = new SqlCommand(selectQuery, connection))
                        {
                            selectCommand.Parameters.AddWithValue("@UID", primaryKeyValue);
                            using (SqlDataReader reader = selectCommand.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    string vName = reader["Name"].ToString();
                                    string vEmail = reader["Email"].ToString();
                                    string vMobile = reader["Mobile"].ToString();
                                    string vUserName = reader["UserName"].ToString();
                                    if (vName == newName && vEmail == newEmail && vMobile == newMobile && vUserName == newUserName)
                                    {
                                        MessageBox.Show("No Changes Found.", "Prompt");
                                    }
                                    else
                                    {
                                        string updateQuery = "UPDATE UserData SET Name = @Name, Email = @Email, Mobile = @Mobile, UserName = @UserName WHERE UserId = @UID";
                                        reader.Close();
                                        using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                                        {
                                            updateCommand.Parameters.AddWithValue("@UID", primaryKeyValue);
                                            updateCommand.Parameters.AddWithValue("@Name", newName);
                                            updateCommand.Parameters.AddWithValue("@Email", newEmail);
                                            updateCommand.Parameters.AddWithValue("@Mobile", newMobile);
                                            updateCommand.Parameters.AddWithValue("@UserName", newUserName);

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
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message, "Error");
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error");
            }
        }


        private void bt_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tb_UID_TextChanged(object sender, EventArgs e)
        {
            if (tb_UID.Text != "")
            {
                tb_R_Pass.Visible = false;
                tb_R_ConPass.Visible = false;
                lb_R_Pass.Visible = false;
                lb_R_ConPass.Visible = false;
                cmb_Role.Visible = false;
                lb_Role.Visible = false;
            }
            else
            {
                tb_R_Pass.Visible = true;
                tb_R_ConPass.Visible = true;
                lb_R_Pass.Visible = true;
                lb_R_ConPass.Visible = true;
                cmb_Role.Visible = true;
                lb_Role.Visible = true;
            }
        }
    }
}