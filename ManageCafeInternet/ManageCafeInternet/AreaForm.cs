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
    public partial class AreaForm : Form
    {
        public AreaForm()
        {
            InitializeComponent();
        }

        private void AreaForm_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadAreaDetail()
        {
            if (dgvAreas.CurrentRow != null)
            {
                DataGridViewRow row = dgvAreas.CurrentRow;
                txtAreaId.Text = row.Cells[0].Value.ToString();
                txtName.Text = row.Cells[1].Value.ToString();
                txtPrice.Text = row.Cells[2].Value.ToString();
                txtPriceTurnOn.Text = row.Cells[3].Value.ToString();
            }
        }

        private void dgvAreas_Click(object sender, EventArgs e)
        {
            loadAreaDetail();
        }

        private void loadData()
        {
            ManageCafeInternetDataContext mci = new ManageCafeInternetDataContext();
            dgvAreas.DataSource = mci.getAllAreasAdmin();
            loadAreaDetail();
        }

        private void btnAddArea_Click(object sender, EventArgs e)
        {
            if (this.validate() == true)
            {
                ManageCafeInternetDataContext mci = new ManageCafeInternetDataContext();
                string name = txtName.Text;
                double price = Convert.ToDouble(txtPrice.Text);
                double price_turn_on = Convert.ToDouble(txtPriceTurnOn.Text);
                try
                {
                    mci.addArea(name, price, price_turn_on);
                    MessageBox.Show("Add area success");
                    loadData();
                }
                catch (Exception)
                {
                    MessageBox.Show("Something went wrong when add area");
                }
            }
        }

        private void btnUpdateArea_Click(object sender, EventArgs e)
        {
            if (this.validate() == true)
            {
                if (MessageBox.Show("Are you sure want to update?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ManageCafeInternetDataContext mci = new ManageCafeInternetDataContext();
                    var f = mci.areas.FirstOrDefault(x => x.entity_id == Convert.ToInt32(txtAreaId.Text));
                    if (f != null)
                    {
                        try
                        {
                            int id = Convert.ToInt32(txtAreaId.Text);
                            string name = txtName.Text;
                            double price = Convert.ToDouble(txtPrice.Text);
                            double price_turn_on = Convert.ToDouble(txtPriceTurnOn.Text);
                            mci.updateArea(id, name, price, price_turn_on);
                            MessageBox.Show("Update area with id = " + txtAreaId.Text + " success");
                            loadData();
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Something went wrong while update area have id equal = " + txtAreaId.Text);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Can't find data with area have id equal = " + txtAreaId.Text, "Notifications", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private bool validate()
        {
            double result;
            if (txtName.Text == "")
            {
                MessageBox.Show("Name can't be null");
            }
            else if (txtPrice.Text == "")
            {
                MessageBox.Show("Price can't be null");
            }
            else if (txtPriceTurnOn.Text == "")
            {
                MessageBox.Show("Price turn on can't be null");
            }
            else if (!double.TryParse(txtPrice.Text, out result))
            {
                MessageBox.Show("Price can't be string");
            }
            else if (!double.TryParse(txtPriceTurnOn.Text, out result))
            {
                MessageBox.Show("Price turn on can't be string");
            }
            else
            {
                return true;
            }
            return false;
        }

        private void btnDeleteArea_Click(object sender, EventArgs e)
        {
            if (dgvAreas.CurrentRow != null)
            {
                if (MessageBox.Show("Are you sure want to delete? Computer with area id = " + txtAreaId.Text + " will lost???", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ManageCafeInternetDataContext mci = new ManageCafeInternetDataContext();
                    var f = mci.areas.FirstOrDefault(x => x.entity_id == Convert.ToInt32(txtAreaId.Text));
                    if (f != null)
                    {
                        mci.deleteComputerByArea(Convert.ToInt32(txtAreaId.Text));
                        mci.deleteArea(Convert.ToInt32(txtAreaId.Text));
                        MessageBox.Show("Delete area with id = " + txtAreaId.Text + " success");
                        loadData();
                    }
                }
            }
            else
            {
                MessageBox.Show("Can't find data with area have id equal = " + txtAreaId.Text, "Notifications", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
