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
            loadComputerDetail();
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
            loadComputerDetail();
        }

        private void loadComputerDetail()
        {
            if (dgvComputers.CurrentRow != null)
            {
                DataGridViewRow row = dgvComputers.CurrentRow;
                txtComputerId.Text = row.Cells[0].Value.ToString();
                txtComputerId.ReadOnly = true;
                txtComputerName.Text = row.Cells[1].Value.ToString();
            }
        }

        private void dgvComputers_Click(object sender, EventArgs e)
        {
            loadComputerDetail();
        }

        private void loadData()
        {
            ManageCafeInternetDataContext mci = new ManageCafeInternetDataContext();
            int selectedAreaId = cbxArea.SelectedIndex;
            dgvComputers.DataSource = mci.getAllComputersFromArea(selectedAreaId + 1);
            loadComputerDetail();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ManageCafeInternetDataContext mci = new ManageCafeInternetDataContext();
            string name = txtComputerName.Text;
            int areaId = Convert.ToInt32(cbxArea.SelectedValue.ToString());
            try
            {
                mci.addComputer(name, areaId);
                MessageBox.Show("Add computer success");
                loadData();
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong when add computer");
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to update?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ManageCafeInternetDataContext mci = new ManageCafeInternetDataContext();
                var f = mci.computers.FirstOrDefault(x => x.entity_id == Convert.ToInt32(txtComputerId.Text));
                if (f != null)
                {
                    try
                    {
                        int id = Convert.ToInt32(txtComputerId.Text);
                        string name = txtComputerName.Text;
                        int areaId = Convert.ToInt32(cbxArea.SelectedValue.ToString());
                        mci.updateComputer(id, name, areaId);
                        MessageBox.Show("Update food with id = " + txtComputerId.Text + " success");
                        loadData();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Something went wrong while update computer have id equal = " + txtComputerId.Text);
                    }
                }
                else
                {
                    MessageBox.Show("Can't find data with computer have id equal = " + txtComputerId.Text, "Notifications", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvComputers.CurrentRow != null)
            {
                if (MessageBox.Show("Are you sure want to delete?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ManageCafeInternetDataContext mci = new ManageCafeInternetDataContext();
                    var f = mci.computers.FirstOrDefault(x => x.entity_id == Convert.ToInt32(txtComputerId.Text));
                    if (f != null)
                    {
                        mci.deleteComputer(Convert.ToInt32(txtComputerId.Text));
                        MessageBox.Show("Delete computer with id = " + txtComputerId.Text + " success");
                        loadData();
                    }
                }
            }
            else
            {
                MessageBox.Show("Can't find data with computer have id equal = " + txtComputerId.Text, "Notifications", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
