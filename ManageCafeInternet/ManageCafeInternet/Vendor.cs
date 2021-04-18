﻿using System;
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
    public partial class Vendor : Form
    {
        public Vendor()
        {
            InitializeComponent();
        }

        private void Vendor_Load(object sender, EventArgs e)
        {
            loadData();
            DisplayArea();
        }

        private void loadData()
        {
            ManageCafeInternetDataContext mci = new ManageCafeInternetDataContext();
            int selectedAreaId = cbxArea.SelectedIndex;
            dgvComputers.DataSource = mci.getAllComputersFromArea(selectedAreaId + 1);
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
            loadData();
        }

        private void dgvComputers_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (dgvComputers.CurrentRow != null)
                {
                    DataGridViewRow row = dgvComputers.CurrentRow;
                }
            }
        }

        private void btnTurnOnComputer_Click(object sender, EventArgs e)
        {
            if (dgvComputers.CurrentRow != null)
            {
                DataGridViewRow row = dgvComputers.CurrentRow;
                int computerId = Convert.ToInt32(txtComputerId.Text);
                DateTime now = DateTime.Now;
                if (row.Cells[4].Value.ToString() == "Using")
                {
                    MessageBox.Show("Computer with id = " + computerId + " is using");
                }
                else
                {
                    ManageCafeInternetDataContext mci = new ManageCafeInternetDataContext();
                    try
                    {
                        mci.updateComputerStatus(computerId);
                        mci.updateComputerStartTime(computerId, now);
                        MessageBox.Show("Turn on computer with id = " + computerId + " success");
                        loadData();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Some thing went wrong while turn on this computer");
                    }
                }
            }
        }

        private void loadComputerDetail()
        {
            if (dgvComputers.CurrentRow != null)
            {
                DataGridViewRow row = dgvComputers.CurrentRow;
                txtComputerId.Text = row.Cells[0].Value.ToString();
            }
        }

        private void dgvComputers_Click(object sender, EventArgs e)
        {
            loadComputerDetail();
        }

        private void btnAddFoods_Click(object sender, EventArgs e)
        {
            if (dgvComputers.CurrentRow != null)
            {
                DataGridViewRow row = dgvComputers.CurrentRow;
                if (row.Cells[4].Value.ToString() == "Using")
                {
                    AddFoodForm aff = new AddFoodForm();
                    aff.Show();
                    aff.txtComputerId.Text = this.txtComputerId.Text;
                }
                else
                {
                    MessageBox.Show("Computer with id = " + txtComputerId.Text + " is not using");
                }
            }
        }
    }
}
