using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Med_Preserve.Forms
{
    public partial class DeletedUser : Form
    {
        public DeletedUser()
        {
            InitializeComponent();
        }
        private void Clear()
        {
            cb_Name.Text = "";
            tb_Email.Text = "";
            tb_Mobile.Text = "";
            tb_R_UName.Text = "";
            tb_UID.Text = "";
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

                tb_UID.Text = dg_UserID;
                cb_Name.Text = dg_Name;
                tb_Email.Text = dg_Email;
                tb_Mobile.Text = dg_Mobile;
                tb_R_UName.Text = dg_UserName;
            }
        }

        private void bt_Recover_Click(object sender, EventArgs e)
        {

        }
    }
}
