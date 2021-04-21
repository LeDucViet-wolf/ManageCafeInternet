using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace ManageCafeInternet
{
    public partial class AddFoodForm : Form
    {
        public int computerId;
        public AddFoodForm()
        {
            InitializeComponent();
        }

        public AddFoodForm(int computerId)
        {
            this.computerId = computerId;
            InitializeComponent();
        }

        private void dgvFoods_Click(object sender, EventArgs e)
        {
            loadFoodDetails();
        }

        private void DisplayFoods()
        {
            ManageCafeInternetDataContext mci = new ManageCafeInternetDataContext();
            dgvFoods.DataSource = mci.getAllFoods();
        }

        private void AddFoodForm_Load(object sender, EventArgs e)
        {
            AddHeaderCheckBox();
            hcb.MouseClick += new MouseEventHandler(HeaderCheckBox_MouseClick);
            DisplayFoods();
            loadFoodDetails();
            txtComputerId.Hide();
            txtComputerStatusId.Hide();
            loadSelectedFoods();
        }

        CheckBox hcb = null;

        bool IsHeaderCheckBoxClicked = false;

        private void AddHeaderCheckBox()
        {
            hcb = new CheckBox();
            hcb.Size = new Size(15, 15);
            this.dgvFoods.Controls.Add(hcb);
        }

        private void HeaderCheckBoxClick(CheckBox HCheckBox)
        {
            IsHeaderCheckBoxClicked = true;
            foreach (DataGridViewRow Row in dgvFoods.Rows)
                ((DataGridViewCheckBoxCell)Row.Cells["chk"]).Value = HCheckBox.Checked;
            dgvFoods.RefreshEdit();
            IsHeaderCheckBoxClicked = false;
        }

        private void HeaderCheckBox_MouseClick(object sender, MouseEventArgs e)
        {
            HeaderCheckBoxClick((CheckBox)sender);
        }

        private void btnAddFoods_Click(object sender, EventArgs e)
        {
            ManageCafeInternetDataContext mci = new ManageCafeInternetDataContext();
            var a = mci.getSelectedFoodsByComputerId(Convert.ToInt32(txtComputerId.Text), Convert.ToInt32(txtComputerStatusId.Text));
            try
            {
                for (int i = 0; i < dgvFoods.RowCount; i++)
                {
                    if (Convert.ToBoolean(dgvFoods.Rows[i].Cells["chk"].Value) == true)
                    {
                        mci.updateFoodQuantity(Convert.ToInt32(dgvFoods.Rows[i].Cells[2].Value.ToString()), Convert.ToInt32(dgvFoods.Rows[i].Cells[5].Value.ToString()) - Convert.ToInt32(dgvFoods.Rows[i].Cells[1].Value.ToString()));
                        if (a.Any((x => x.food_id == Convert.ToInt32(dgvFoods.Rows[i].Cells[2].Value.ToString()))))
                        {
                            mci.updateSelectedFoods(Convert.ToInt32(dgvFoods.Rows[i].Cells[2].Value), Convert.ToInt32(dgvFoods.Rows[i].Cells[1].Value.ToString()));
                        }
                        else
                        {
                            mci.addSelectedFoods(Convert.ToInt32(dgvFoods.Rows[i].Cells[2].Value), Convert.ToInt32(dgvFoods.Rows[i].Cells[1].Value), Convert.ToInt32(txtComputerId.Text), Convert.ToInt32(txtComputerStatusId.Text));
                        }
                    }

                }
                MessageBox.Show("Add selected foods to computer with id = " + txtComputerId.Text + " success");
                DisplayFoods();
                loadSelectedFoods();
            }
            catch (Exception)
            {
                MessageBox.Show("Some thing went wrong while add foods");
            }
        }

        private void loadFoodDetails()
        {
            if (dgvFoods.CurrentRow != null)
            {
                DataGridViewRow row = dgvFoods.CurrentRow;
            }
        }

        private void loadSelectedFoods()
        {
            ManageCafeInternetDataContext mci = new ManageCafeInternetDataContext();
            dgvSelectedFoods.DataSource = mci.getSelectedFoodsByComputerId(Convert.ToInt32(txtComputerId.Text), Convert.ToInt32(txtComputerStatusId.Text));
        }

    }
}
