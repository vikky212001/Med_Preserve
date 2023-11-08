using Med_Preserve.Class;
using System;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Net.Mail;
using System.Windows.Forms;

namespace Med_Preserve.Forms
{
    public partial class CompanyMaster : Form
    {
        private DataTable dataTable = new DataTable();
        private string connectionString;
        private byte[] imageData;
        public CompanyMaster()
        {
            InitializeComponent();
            dgv_CompanyMaster.CellClick += dgv_CompanyMaster_CellClick;
            connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        }

        private void CompanyMaster_Load(object sender, EventArgs e)
        {
            try
            {
                dgv_CompanyMaster.Columns[0].Visible = false;
                this.companyMasterTableAdapter.Fill(this.med_PreserveDataSet.CompanyMaster);
                RefreshData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading data.", ex.Message);
            }

        }

        private void RefreshData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM CompanyMaster ";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    dataTable.Clear();
                    adapter.Fill(dataTable);

                    dgv_CompanyMaster.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while refreshing data.", ex.Message);
                }
            }
        }

        private void Clear()
        {
            tb_CompanyName.Text = "";
            tb_ContactNo.Text = "";
            tb_Email.Text = "";
            tb_SrNo.Text = "";
            rtb_Address.Text = "";
            pb_Logo.Image = null;
        }

        private void tb_Email_Validating(object sender, CancelEventArgs e)
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

        private void dgv_CompanyMaster_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgv_CompanyMaster.Rows[e.RowIndex];
                object selectImageDataObj = selectedRow.Cells[5].Value;
                if (selectImageDataObj != DBNull.Value)
                {
                    byte[] selectImageData = (byte[])selectImageDataObj;
                    if (selectImageData != null)
                    {
                        using (MemoryStream ms = new MemoryStream(selectImageData))
                        {
                            pb_Logo.Image = Image.FromStream(ms);
                        }
                    }
                    else
                    {
                        pb_Logo.Image = null;
                    }
                }
                else
                {
                    pb_Logo.Image = null;
                }
                tb_SrNo.Text = selectedRow.Cells[0].Value.ToString();
                tb_CompanyName.Text = selectedRow.Cells[1].Value.ToString();
                rtb_Address.Text = selectedRow.Cells[2].Value.ToString();
                tb_ContactNo.Text = selectedRow.Cells[3].Value.ToString();
                tb_Email.Text = selectedRow.Cells[4].Value.ToString();
            }
        }

        private void tb_ContactNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tb_Search_TextChanged(object sender, EventArgs e)
        {
            if (dataTable != null)
            {
                string searchQuery = tb_Search.Text.Trim();
                DataView dva = dataTable.DefaultView;
                dva.RowFilter = $"CompanyName LIKE '%{searchQuery}%' OR Email LIKE '%{searchQuery}%'";
                dgv_CompanyMaster.DataSource = dva.ToTable();
            }
        }

        private void bt_Add_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string companyName = tb_CompanyName.Text;
                    string emailValue = tb_Email.Text;
                    string contactValue = tb_ContactNo.Text;
                    string addressValue = rtb_Address.Text;
                    DateTime selectedDateTime = DateTime.Now;
                    string FDateTime = selectedDateTime.ToString("yyyy-MM-dd HH:mm");
                    Duplication duplication = new Duplication();
                    if (string.IsNullOrWhiteSpace(companyName) || string.IsNullOrWhiteSpace(emailValue) ||
                        string.IsNullOrWhiteSpace(contactValue) || string.IsNullOrWhiteSpace(addressValue))
                    {
                        MessageBox.Show("Fill in all required fields.", "Prompt");
                        return;
                    }

                    if (duplication.IscompanyNameDuplicate(companyName))
                    {
                        MessageBox.Show("Username is already taken. Please choose a different one.", "Prompt");
                        return;
                    }

                    if (duplication.IsCompanyEmailDuplicate(emailValue))
                    {
                        MessageBox.Show("Email address is already in use. Please use a different one.", "Prompt");
                        return;
                    }
                    string addQuery = "INSERT INTO CompanyMaster(CompanyName, Address, ContactNo, Email, Logo, CreatedDate) " +
                  "VALUES (@CompanyName, @Address, @ContactNo, @Email, @Logo, @CreatedDate);";
                    using (SqlCommand command = new SqlCommand(addQuery, connection))
                    {
                        command.Parameters.AddWithValue("@CompanyName", companyName);
                        command.Parameters.AddWithValue("@Email", emailValue);
                        command.Parameters.AddWithValue("@ContactNo", contactValue);
                        command.Parameters.AddWithValue("@Address", addressValue);
                        command.Parameters.AddWithValue("@Logo", imageData);
                        command.Parameters.AddWithValue("@CreatedDate", FDateTime);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Company Added successfully.", "Prompt");
                        RefreshData();
                        Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while refreshing data.", ex.Message);
            }
        }

        private void bt_Browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog.FileName;
                imageData = File.ReadAllBytes(imagePath);
                using (FileStream fs = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
                {
                    pb_Logo.SizeMode = PictureBoxSizeMode.Zoom;
                    pb_Logo.Image = Image.FromStream(fs);
                }
            }
        }

        private void bt_Clear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void bt_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_Delete_Click(object sender, EventArgs e)
        {
            if (dgv_CompanyMaster.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a company to delete.", "Prompt");
                return;
            }

            string selectedCompanyID = tb_SrNo.Text;
            DialogResult result = MessageBox.Show("Are you sure you want to delete this company?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string deleteQuery = "DELETE FROM CompanyMaster WHERE SrNo = @CompanyID";

                        using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                        {
                            command.Parameters.AddWithValue("@CompanyID", selectedCompanyID);
                            int rowsAffected = command.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Company deleted successfully.", "Success");
                                RefreshData();
                                Clear();
                            }
                            else
                            {
                                MessageBox.Show("Company not deleted. Please try again.", "Error");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while deleting the company." + ex.Message, "Error");
                }
            }
        }

        private void bt_Update_Click(object sender, EventArgs e)
        {
            string newCompanyName = tb_CompanyName.Text;
            string newEmail = tb_Email.Text;
            string newContact = tb_ContactNo.Text;
            string newAddress = rtb_Address.Text;
            string selectedCompanyID = tb_SrNo.Text;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    try
                    {
                        string selectQuery = "SELECT CompanyName, Address, ContactNo, Email, Logo FROM CompanyMaster WHERE SrNo = @CompanyID";

                        using (SqlCommand selectCommand = new SqlCommand(selectQuery, connection))
                        {
                            selectCommand.Parameters.AddWithValue("@CompanyID", selectedCompanyID);

                            using (SqlDataReader reader = selectCommand.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    string oldCompanyName = reader["CompanyName"].ToString();
                                    string oldEmail = reader["Email"].ToString();
                                    string oldContact = reader["ContactNo"].ToString();
                                    string oldAddress = reader["Address"].ToString();
                                    byte[] oldImageData = reader["Logo"] as byte[];

                                    if (oldCompanyName == newCompanyName && oldEmail == newEmail && oldContact == newContact && oldAddress == newAddress && imageData == null)
                                    {
                                        MessageBox.Show("No Changes Found.", "Prompt");
                                    }
                                    else
                                    {
                                        string updateQuery = "UPDATE CompanyMaster SET CompanyName = @CompanyName, Email = @Email, ContactNo = @ContactNo, Address = @Address, Logo = @Logo WHERE SrNo = @CompanyID";
                                        reader.Close();

                                        using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                                        {
                                            updateCommand.Parameters.AddWithValue("@CompanyID", selectedCompanyID);
                                            updateCommand.Parameters.AddWithValue("@CompanyName", newCompanyName);
                                            updateCommand.Parameters.AddWithValue("@Email", newEmail);
                                            updateCommand.Parameters.AddWithValue("@ContactNo", newContact);
                                            updateCommand.Parameters.AddWithValue("@Address", newAddress);
                                            if (imageData == null)
                                            {
                                                updateCommand.Parameters.Add(new SqlParameter("@Logo", SqlDbType.VarBinary, -1) { Value = DBNull.Value });
                                            }
                                            else
                                            {
                                                updateCommand.Parameters.Add(new SqlParameter("@Logo", SqlDbType.VarBinary, -1) { Value = imageData });
                                            }
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
    }
}