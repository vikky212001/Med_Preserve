using Med_Preserve.Class;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Med_Preserve.Forms
{
    public partial class ChangePassword : Form
    {
        private string connectionString;

        public ChangePassword()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        }

        private void bt_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
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
        }

        private void bt_ChangePass_Click(object sender, EventArgs e)
        {
            PasswordHasher passwordHasher = new PasswordHasher();
            string uid = Convert.ToString(Global.UserId);
            string role = Global.UserRole;
            string currPass = tb_CurrPass.Text;
            string newPass = tb_NewPass.Text;
            string conPass = tb_ConPass.Text;
            if (currPass != "" && newPass != "" && conPass != "")
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string selectQuery = "SELECT UserName, Password FROM UserData WHERE UserID = @UID";
                    using (SqlCommand selectCommand = new SqlCommand(selectQuery, connection))
                    {
                        selectCommand.Parameters.AddWithValue("@UID", uid);

                        using (SqlDataReader reader = selectCommand.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string username = reader["UserName"].ToString();
                                string hashedPassword = reader["Password"].ToString();

                                if (role == "Admin")
                                {
                                    if (currPass == hashedPassword)
                                    {
                                        if (newPass == conPass)
                                        {
                                            reader.Close();
                                            string updateQuery = "UPDATE UserData SET Password = @Password WHERE UserID = @UID";
                                            using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                                            {
                                                updateCommand.Parameters.AddWithValue("@Password", conPass);
                                                updateCommand.Parameters.AddWithValue("@UID", uid);
                                                int rowsAffected = updateCommand.ExecuteNonQuery();

                                                if (rowsAffected > 0)
                                                {
                                                    MessageBox.Show("Password updated successfully for user " + username + ".", "Success");
                                                    Clear();
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Password not updated. Check your input or try again later.", "Error");
                                                }
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("New Password and Confirm Password didn't match.", "Error");
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Incorrect Current Password", "Error");
                                    }
                                }
                                else
                                {
                                    bool isPasswordCorrect = passwordHasher.VerifyPassword(currPass, hashedPassword);

                                    if (isPasswordCorrect)
                                    {
                                        if (newPass == conPass)
                                        {
                                            string newHashedPassword = passwordHasher.HashPassword(tb_ConPass.Text);
                                            string updateQuery = "UPDATE UserData SET Password = @Password WHERE UserID = @UID";
                                            using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                                            {
                                                updateCommand.Parameters.AddWithValue("@Password", newHashedPassword);
                                                updateCommand.Parameters.AddWithValue("@UID", uid);
                                                int rowsAffected = updateCommand.ExecuteNonQuery();

                                                if (rowsAffected > 0)
                                                {
                                                    MessageBox.Show("Password updated successfully for user " + username + ".", "Success");
                                                    Clear();
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Password not updated. Check your input or try again later.", "Error");
                                                }
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("New Password and Confirm Password didn't match.", "Error");
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Incorrect Current Password", "Error");
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Fill in all required fields.", "Prompt"); //Suggestion
            }
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {
            tb_ConPass.PasswordChar = '●';
            tb_CurrPass.PasswordChar = '●';
            tb_NewPass.PasswordChar = '●';
        }
    }
}