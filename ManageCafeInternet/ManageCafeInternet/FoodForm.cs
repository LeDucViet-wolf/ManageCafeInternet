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
    public partial class FoodForm : Form
    {
        public FoodForm()
        {
            InitializeComponent();
        }

        private void FoodForm_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            DisplayFoodTypes();
            DisplayFoods();
        }

        private void DisplayFoodTypes()
        {
            ManageCafeInternetDataContext mci = new ManageCafeInternetDataContext();
            var foodTypes = mci.getAllFoodTypes();
            cbxFoodType.DataSource = foodTypes;
            cbxFoodType.DisplayMember = "food_type_name";
            cbxFoodType.ValueMember = "food_type_id";
        }

        private void DisplayFoods()
        {
            ManageCafeInternetDataContext mci = new ManageCafeInternetDataContext();
            dgvFoods.DataSource = mci.getAllFoods();
            DisplayFoodDetails();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (this.validate() == true)
            {
                ManageCafeInternetDataContext mci = new ManageCafeInternetDataContext();
                string name = txtName.Text;
                double price = Convert.ToDouble(txtPrice.Text);
                int quantity = Convert.ToInt32(txtQuantity.Text);
                int foodTypeId = Convert.ToInt32(cbxFoodType.SelectedValue.ToString());
                try
                {
                    mci.addFood(name, price, quantity, foodTypeId);
                    MessageBox.Show("Add food success");
                    loadData();
                }
                catch (Exception)
                {
                    MessageBox.Show("Something went wrong when add food");
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtName.Text = txtPrice.Text = txtQuantity.Text = "";
        }

        private void DisplayFoodDetails()
        {
            if (dgvFoods.CurrentRow != null)
            {
                DataGridViewRow row = dgvFoods.CurrentRow;
                txtId.Text = row.Cells[0].Value.ToString();
                txtName.Text = row.Cells[1].Value.ToString();
                txtPrice.Text = row.Cells[2].Value.ToString();
                txtQuantity.Text = row.Cells[3].Value.ToString();
                cbxFoodType.SelectedValue = Convert.ToInt32(row.Cells[4].Value.ToString());
            }
        }

        private void dgvFoods_Click(object sender, EventArgs e)
        {
            DisplayFoodDetails();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (this.validate() == true)
            {
                if (MessageBox.Show("Are you sure want to update?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ManageCafeInternetDataContext mci = new ManageCafeInternetDataContext();
                    var f = mci.foods.FirstOrDefault(x => x.entity_id == Convert.ToInt32(txtId.Text));
                    if (f != null)
                    {
                        try
                        {
                            int id = Convert.ToInt32(txtId.Text);
                            string name = txtName.Text;
                            double price = Convert.ToDouble(txtPrice.Text);
                            int quantity = Convert.ToInt32(txtQuantity.Text);
                            int foodTypeId = Convert.ToInt32(cbxFoodType.SelectedValue.ToString());
                            mci.updateFood(id, name, price, quantity, foodTypeId);
                            MessageBox.Show("Update food with id = " + txtId.Text + " success");
                            loadData();
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Something went wrong while update food have id equal = " + txtId.Text);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Can't find data with food have id equal = " + txtId.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvFoods.CurrentRow != null)
            {
                if (MessageBox.Show("Are you sure want to delete?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ManageCafeInternetDataContext mci = new ManageCafeInternetDataContext();
                    var f = mci.foods.FirstOrDefault(x => x.entity_id == Convert.ToInt32(txtId.Text));
                    if (f != null)
                    {
                        mci.deleteFood(Convert.ToInt32(txtId.Text));
                        MessageBox.Show("Delete food with id = " + txtId.Text + " success");
                        loadData();
                    }
                }
            }
            else
            {
                MessageBox.Show("Can't find data with food have id equal = " + txtId.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool validate()
        {
            int result;
            if (txtName.Text == "")
            {
                MessageBox.Show("Name can't be null");
            }
            else if (txtPrice.Text == "")
            {
                MessageBox.Show("Price can't be null");
            }
            else if (txtQuantity.Text == "")
            {
                MessageBox.Show("Quantity can't be null");
            }
            else if (!int.TryParse(txtPrice.Text, out result))
            {
                MessageBox.Show("Price can't be string");
            }
            else if (!int.TryParse(txtQuantity.Text, out result))
            {
                MessageBox.Show("Quantity can't be string");
            }
            else
            {
                return true;
            }
            return false;
        }
    }
}
