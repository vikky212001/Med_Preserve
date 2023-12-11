using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace Med_Preserve.Forms
{
    public partial class LiveReading : Form
    {
        private string selectedComPort;
        private string receivedDataBuffer = string.Empty;

        public LiveReading(string comPort)
        {
            InitializeComponent();
            selectedComPort = comPort;
            InitializeForm();
        }
        private void InitializeForm()
        {
            tb_SerialPort.Text = selectedComPort;
        }
    }
}
