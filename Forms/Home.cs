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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void userMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserMaster userMaster = new UserMaster();
            userMaster.Show();
        }
    }
}
