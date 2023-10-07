using Med_Preserve.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Med_Preserve.Forms
{
    public partial class DeletedUser : Form
    {
        private string connectionString;
        public DeletedUser()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        }
        private void Clear()
        {
            cb_Name.Text = "";
            tb_Email.Text = "";
            tb_Mobile.Text = "";
            tb_R_UName.Text = "";
            tb_UID.Text = "";
            rtb_Reason.Text = "";
        }

        private void DeletedUser_Load(object sender, EventArgs e)
        {
            this.userDataTableAdapter.Fill(this.med_PreserveDataSet.UserData);
        }

        private void dgv_DeletedUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgv_DeletedUser.Rows[e.RowIndex];

                string dg_UserID = selectedRow.Cells[0].Value.ToString();
                string dg_Name = selectedRow.Cells[1].Value.ToString();
                string dg_Email = selectedRow.Cells[2].Value.ToString();
                string dg_Mobile = selectedRow.Cells[3].Value.ToString();
                string dg_UserName = selectedRow.Cells[4].Value.ToString();
                string dg_Reason = selectedRow.Cells[6].Value.ToString();

                tb_UID.Text = dg_UserID;
                cb_Name.Text = dg_Name;
                tb_Email.Text = dg_Email;
                tb_Mobile.Text = dg_Mobile;
                tb_R_UName.Text = dg_UserName;
                rtb_Reason.Text = dg_Reason;
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
                                    string deleteQuery = "UPDATE UserData SET IsDeleted = 'False', Email = @Email, UserName = @UserName WHERE UserID = @PrimaryKeyValue";
                                    using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                                    {
                                        command.Parameters.AddWithValue("@UserName", userNameValue);
                                        command.Parameters.AddWithValue("@Email", emailValue);
                                        command.Parameters.AddWithValue("@PrimaryKeyValue", primaryKeyValue);
                                        command.ExecuteNonQuery();
                                        MessageBox.Show("User Recovered Successfully.");
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch
            {

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
    }
}
