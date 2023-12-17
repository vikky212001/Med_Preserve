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

        public string SelectedComPort
        {
            get
            {
                return cmb_COMPort.SelectedItem?.ToString();
            }
        }

        private void bt_UserMaster_Click(object sender, EventArgs e)
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

        private void bt_CompanyMaster_Click(object sender, EventArgs e)
        {
            if (currentForm != null)
            {
                currentForm.Close();
            }
            CompanyMaster companyMaster = new CompanyMaster();
            companyMaster.TopLevel = false;
            companyMaster.Parent = p_MainScreen;
            companyMaster.Dock = DockStyle.Fill;
            currentForm = companyMaster;
            companyMaster.Show();
        }

        private void bt_ChangePassword_Click(object sender, EventArgs e)
        {
            if (currentForm != null)
            {
                currentForm.Close();
            }
            ChangePassword changePassword = new ChangePassword();
            changePassword.TopLevel = false;
            changePassword.Parent = p_MainScreen;
            changePassword.Dock = DockStyle.Fill;
            currentForm = changePassword;
            changePassword.Show();
        }

        private void bt_LoggerMaster_Click(object sender, EventArgs e)
        {
            if (currentForm != null)
            {
                currentForm.Close();
            }
            LoggerMaster loggerMaster = new LoggerMaster();
            loggerMaster.TopLevel = false;  
            loggerMaster.Parent = p_MainScreen;
            loggerMaster.Dock = DockStyle.Fill;
            currentForm = loggerMaster;
            loggerMaster.Show();
        }

        private void bt_LoggerConfig_Click(object sender, EventArgs e)
        {
            if (currentForm != null)
            {
                currentForm.Close();
            }
            LoggerConfig loggerConfig = new LoggerConfig(SelectedComPort);
            loggerConfig.TopLevel = false;
            loggerConfig.Parent = p_MainScreen;
            loggerConfig.Dock = DockStyle.Fill;
            currentForm = loggerConfig;
            loggerConfig.Show();
        }

        private void bt_RealTimeData_Click(object sender, EventArgs e)
        {
            if (currentForm != null)
            {
                currentForm.Close();
            }
            RealTimeData liveReading = new RealTimeData(SelectedComPort);
            liveReading.TopLevel = false;
            liveReading.Parent = p_MainScreen;
            liveReading.Dock = DockStyle.Fill;
            currentForm = liveReading;
            liveReading.Show();
        }

        private void bt_UserManagement_Click(object sender, EventArgs e)
        {
            if (p_UserManagement.Visible)
            {
                p_UserManagement.Visible = false;
            }
            else if (!p_UserManagement.Visible)
            {
                p_UserManagement.Visible = true;
            }
        }

        private void bt_Devices_Click(object sender, EventArgs e)
        {
            if (p_Devices.Visible)
            {
                p_Devices.Visible = false;
            }
            else if (!p_Devices.Visible)
            {
                p_Devices.Visible = true;
            }
        }

        private void bt_DataManagement_Click(object sender, EventArgs e)
        {
            if (p_DataManagement.Visible)
            {
                p_DataManagement.Visible = false;
            }
            else if (!p_DataManagement.Visible)
            {
                p_DataManagement.Visible = true;
            }
        }

        private void bt_Reports_Click(object sender, EventArgs e)
        {
            if (p_Reports.Visible)
            {
                p_Reports.Visible = false;
            }
            else if (!p_Reports.Visible)
            {
                p_Reports.Visible = true;
            }
        }

        private void bt_DeletedUser_Click(object sender, EventArgs e)
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

        private void Home_Load(object sender, EventArgs e)
        {
            p_UserManagement.Visible = false;
            p_Reports.Visible = false;
            p_DataManagement.Visible = false;
            p_Devices.Visible = false;
        }

        private void bt_DownloadData_Click(object sender, EventArgs e)
        {
            if (currentForm != null)
            {
                currentForm.Close();
            }
            DownloadData downloadData = new DownloadData(SelectedComPort);
            downloadData.TopLevel = false;
            downloadData.Parent = p_MainScreen;
            downloadData.Dock = DockStyle.Fill;
            currentForm = downloadData;
            downloadData.Show();
        }

        private void bt_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
