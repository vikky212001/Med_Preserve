﻿using System.Configuration;
using System.Data.SqlClient;

namespace Med_Preserve.Class
{
    internal class Duplication
    {
        private string connectionString;
        public Duplication()
        {
            connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        }
        public bool IsUsernameDuplicate(string username)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM UserData WHERE UserName = @Username AND IsDeleted = 0";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        public bool IsEmailDuplicate(string email)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM UserData WHERE Email = @Email AND IsDeleted = 0";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Email", email);
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        public bool IsCompanyEmailDuplicate(string email)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM CompanyMaster WHERE Email = @Email";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Email", email);
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        public bool IscompanyNameDuplicate(string companyName)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM CompanyMaster WHERE CompanyName = @CompanyName";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CompanyName", companyName);
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }
        public bool IsLoggerName(string loggerName)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM LoggerMaster WHERE LoggerName = @LoggerName";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@LoggerName", loggerName);
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }
    }
}
