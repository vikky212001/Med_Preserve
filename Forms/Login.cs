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

        // Constructor for the Login form
        public Login()
        {
            InitializeComponent();

            // Load the database connection string from the app.config file
            connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        }

        // Event handler for the "Login" button
        private void bt_Login_Click(object sender, EventArgs e)
        {
            // Check if the login is successful, and if it is, open the Home form
            if (IsLoginSuccessful())
            {
                this.Hide(); // Hide the Login form
                Home home = new Home(); // Create an instance of the Home form
                home.ShowDialog(); // Show the Home form
                Application.Exit(); // Exit the application
            }
        }

        // Event handler for the "Cancel" button
        private void bt_Cancel_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Exit the application
        }

        // Method to check if the login is successful
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

                    // SQL query to retrieve user data
                    string query = "Select UserData.Password, UserData.UserID, Role.RoleType " +
                        "From UserData " +
                        "INNER JOIN Role ON UserData.RoleID = Role.RoleID " +
                        "WHERE UserData.UserName = @Username";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", UserName);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string hashedPassword = reader["Password"].ToString();
                                string role = Convert.ToString(reader["RoleType"]);
                                int uid = Convert.ToInt32(reader["UserID"]);

                                if (role == "Admin")
                                {
                                    // Check the password for an Admin user
                                    if (Password == hashedPassword)
                                    {
                                        MessageBox.Show("Admin Login Successful!", "Success");
                                        Global.UserRole = "Admin";
                                        Global.UserId = uid;
                                        Global.UserName = UserName;
                                        return true;
                                    }
                                    else
                                    {
                                        MessageBox.Show("Invalid admin password. Please try again.", "Error");
                                    }
                                }
                                else if (role == "Manager")
                                {
                                    // Check the password for a Manager user
                                    bool passwordMatches = passwordHasher.VerifyPassword(Password, hashedPassword);

                                    if (passwordMatches)
                                    {
                                        Global.UserRole = "Manager";
                                        Global.UserId = uid;
                                        Global.UserName = UserName;
                                        MessageBox.Show("Manager Login Successful!", "Success");
                                        return true;
                                    }
                                    else
                                    {
                                        MessageBox.Show("Invalid username or password. Please try again.", "Error");
                                    }
                                }
                                else
                                {
                                    // Check the password for other user roles
                                    bool passwordMatches = passwordHasher.VerifyPassword(Password, hashedPassword);

                                    if (passwordMatches)
                                    {
                                        MessageBox.Show("User Login Successful!", "Success");
                                        Global.UserRole = role;
                                        Global.UserId = uid;
                                        Global.UserName = UserName;
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

        // Event handler for the form's Load event
        private void Login_Load(object sender, EventArgs e)
        {
            tb_Pass.PasswordChar = '●'; // Set the PasswordChar to display password characters as dots (●)
        }
    }
}
