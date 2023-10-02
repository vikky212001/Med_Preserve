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
    public partial class UserMaster : Form
    {
        public UserMaster()
        {
            InitializeComponent();
        }

        private void UserMaster_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'med_PreserveDataSet.UserData' table. You can move, or remove it, as needed.
            this.userDataTableAdapter.Fill(this.med_PreserveDataSet.UserData);
            // TODO: This line of code loads data into the 'med_PreserveDataSet.SensorData' table. You can move, or remove it, as needed.
            this.sensorDataTableAdapter.Fill(this.med_PreserveDataSet.SensorData);

        }
    }
}
