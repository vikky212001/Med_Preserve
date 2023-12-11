using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace Med_Preserve.Forms
{
    public partial class Home : Form
    {
        private Form currentForm;
        public Home()
        {
            InitializeComponent();
            PopulateComPort();
        }

        private void PopulateComPort()
        {
            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                cmb_COMPort.Items.Add(port);
            }
            if (cmb_COMPort.Items.Count > 0)
            {
                cmb_COMPort.SelectedIndex = 0;
            }
            else
            {
                cmb_COMPort.Text = "No COM ports found";
            }
        }

        private void userMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currentForm != null)
            {
                currentForm.Close();
            }
            UserMaster userMaster = new UserMaster();
            userMaster.TopLevel = false;
            userMaster.Parent = p_MainScreen;
            userMaster.Dock = DockStyle.Fill;
            currentForm = userMaster;
            userMaster.Show();
        }

        private void deletedUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currentForm != null)
            {
                currentForm.Close();
            }
            DeletedUser deletedUser = new DeletedUser();
            deletedUser.TopLevel = false;
            deletedUser.Parent = p_MainScreen;
            deletedUser.Dock = DockStyle.Fill;
            currentForm = deletedUser;
            deletedUser.Show();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePassword changePassword = new ChangePassword();
            changePassword.ShowDialog();
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
            LoggerConfig loggerConfig = new LoggerConfig(SelectedComPort);
            loggerConfig.ShowDialog();
        }

        private void liveReadingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LiveReading liveReading = new LiveReading(SelectedComPort);
            liveReading.ShowDialog();
        }

        public string SelectedComPort
        {
            get
            {
                return cmb_COMPort.SelectedItem?.ToString();
            }
        }
    }
}
