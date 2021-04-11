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
    public partial class ComputerForm : Form
    {
        public ComputerForm()
        {
            InitializeComponent();
        }

        private void ComputerForm_Load(object sender, EventArgs e)
        {
            DisplayArea();
        }

        private void DisplayArea()
        {
            ManageCafeInternetDataContext mci = new ManageCafeInternetDataContext();
            var areas = mci.getAllAreas();
            cbxArea.DataSource = areas;
            cbxArea.DisplayMember = "area_name";
            cbxArea.ValueMember = "area_id";
        }

        private void cbxArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            ManageCafeInternetDataContext mci = new ManageCafeInternetDataContext();
            int selectedAreaId = cbxArea.SelectedIndex;
            dgvComputers.DataSource = mci.getAllComputersFromArea(selectedAreaId + 1);
        }
    }
}
