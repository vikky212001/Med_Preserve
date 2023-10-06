using Med_Preserve.Class;
using Med_Preserve.Forms;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Med_Preserve
{
    public partial class Login : Form
    {
        private string connectionString;
        public Login()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        }

        private void bt_Login_Click(object sender, EventArgs e)
        {
            if (IsLoginSuccessful())
            {
                this.Hide();
                Home home = new Home();
                home.ShowDialog();
                Application.Exit();
            }
        }

        private void bt_Cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public bool IsLoginSuccessful()
        {
            string UserName = tb_UName.Text;
            string Password = tb_Pass.Text;
            PasswordHasher passwordHasher = new PasswordHasher();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT Password, IsAdmin FROM UserData WHERE UserName = @Username";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", UserName);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string hashedPassword = reader["Password"].ToString();
                                bool isAdmin = Convert.ToBoolean(reader["IsAdmin"]);

                                if (isAdmin)
                                {
                                    if (Password == hashedPassword)
                                    {
                                        MessageBox.Show("Admin Login Successful!", "Success");
                                        return true;
                                    }
                                    else
                                    {
                                        MessageBox.Show("Invalid admin password. Please try again.", "Error");
                                    }
                                }
                                else
                                {
                                    bool passwordMatches = passwordHasher.VerifyPassword(Password, hashedPassword);

                                    if (passwordMatches)
                                    {
                                        MessageBox.Show("User Login Successful!", "Success");
                                        return true;
                                    }
                                    else
                                    {
                                        MessageBox.Show("Invalid username or password. Please try again.", "Error");
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("User not found.", "Error");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error");
            }

            return false;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            tb_Pass.PasswordChar = '*';
        }
    }
}