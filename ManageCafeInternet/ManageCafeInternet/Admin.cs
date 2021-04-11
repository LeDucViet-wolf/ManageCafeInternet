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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void tsmiFoods_Click(object sender, EventArgs e)
        {
            FoodForm ff = new FoodForm();
            ff.Show();
        }

        private void tsmiComputers_Click(object sender, EventArgs e)
        {
            ComputerForm cf = new ComputerForm();
            cf.Show();
        }
    }
}
