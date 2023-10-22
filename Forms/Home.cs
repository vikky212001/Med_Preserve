using System;
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
            userMaster.ShowDialog();
        }

        private void deletedUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeletedUser deletedUser = new DeletedUser();
            deletedUser.ShowDialog();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void companyMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {

            CompanyMaster companyMaster = new CompanyMaster();
            companyMaster.ShowDialog();
        }

        private void loggerMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoggerMaster loggerMaster = new LoggerMaster();
            loggerMaster.ShowDialog();
        }

        private void loggerConfigToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoggerConfig loggerConfig = new LoggerConfig();
            loggerConfig.ShowDialog();
        }
    }
}
