using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageCafeInternet
{
    public partial class Order : Form
    {
        public Order()
        {
            InitializeComponent();
        }

        private void loadSelectedFoods()
        {
            ManageCafeInternetDataContext mci = new ManageCafeInternetDataContext();
            dgvFoods.DataSource = mci.getSelectedFoodsByComputerId(Convert.ToInt32(txtComputerId.Text), Convert.ToInt32(txtComputerStatusId.Text));
        }

        private void loadTime()
        {
            ManageCafeInternetDataContext mci = new ManageCafeInternetDataContext();
            dgvTime.DataSource = mci.useTime(Convert.ToInt32(txtComputerId.Text));
        }

        private void Order_Load(object sender, EventArgs e)
        {
            loadSelectedFoods();
            loadTime();
            txtComputerId.Hide();
            txtComputerStatusId.Hide();
        }
    }
}
