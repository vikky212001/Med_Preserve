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
    public partial class LoggerConfig : Form
    {
        public LoggerConfig()
        {
            InitializeComponent();
        }

        private void LoggerConfig_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'med_PreserveDataSet.LoggerMaster' table. You can move, or remove it, as needed.
            this.loggerMasterTableAdapter.Fill(this.med_PreserveDataSet.LoggerMaster);
            // TODO: This line of code loads data into the 'med_PreserveDataSet.LoggerMaster' table. You can move, or remove it, as needed.
            this.loggerMasterTableAdapter.Fill(this.med_PreserveDataSet.LoggerMaster);

        }
    }
}
