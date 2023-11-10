using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Med_Preserve.Forms
{
    public partial class LiveReading : Form
    {
        public LiveReading()
        {
            InitializeComponent();
            PopulateComPort();
        }

        private void PopulateComPort()
        {
            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                cmb_SerialPort.Items.Add(port);
            }
            if (cmb_SerialPort.Items.Count > 0)
            {
                cmb_SerialPort.SelectedIndex = 0;
            }
            else
            {
                cmb_SerialPort.Text = "No COM ports found";
            }
        }
    }
}
