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
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (this.validate() == true)
            {
                ManageCafeInternetDataContext mci = new ManageCafeInternetDataContext();
                string account = txtAccount.Text;
                string password = txtPassword.Text;
                string firstName = txtFirstName.Text;
                string lastName = txtLastName.Text;
                int areaId = Convert.ToInt32(cbxRoles.SelectedValue.ToString());
                try
                {
                    mci.addUser(account, password, firstName, lastName, areaId);
                    MessageBox.Show("Add user success");
                    loadData();
                }
                catch (Exception)
                {
                    MessageBox.Show("Something went wrong when add user");
                }
            }
        }

        private void DisplayArea()
        {
            ManageCafeInternetDataContext mci = new ManageCafeInternetDataContext();
            var roles = mci.getAllRoles();
            cbxRoles.DataSource = roles;
            cbxRoles.DisplayMember = "role_name";
            cbxRoles.ValueMember = "role_id";
        }

        private void loadUserDetail()
        {
            if (dgvUsers.CurrentRow != null)
            {
                DataGridViewRow row = dgvUsers.CurrentRow;
                txtUserId.Text = row.Cells[0].Value.ToString();
                txtAccount.Text = row.Cells[1].Value.ToString();
                txtPassword.Text = row.Cells[2].Value.ToString();
                txtFirstName.Text = row.Cells[3].Value.ToString();
                txtLastName.Text = row.Cells[4].Value.ToString();
            }
        }

        private void loadData()
        {
            DisplayArea();
            loadUserDetail();
        }

        private void cbxRoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            ManageCafeInternetDataContext mci = new ManageCafeInternetDataContext();
            int selectedAreaId = cbxRoles.SelectedIndex;
            dgvUsers.DataSource = mci.getAllUsersFromRole(selectedAreaId + 1);
            loadUserDetail();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (this.validate() == true)
            {
                if (MessageBox.Show("Are you sure want to update?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ManageCafeInternetDataContext mci = new ManageCafeInternetDataContext();
                    var f = mci.users.FirstOrDefault(x => x.entity_id == Convert.ToInt32(txtUserId.Text));
                    if (f != null)
                    {
                        try
                        {
                            int id = Convert.ToInt32(txtUserId.Text);
                            string account = txtAccount.Text;
                            string password = txtPassword.Text;
                            string firstName = txtFirstName.Text;
                            string lastName = txtLastName.Text;
                            int roleId = Convert.ToInt32(cbxRoles.SelectedValue.ToString());
                            mci.updateUser(id, account, password, firstName, lastName, roleId);
                            MessageBox.Show("Update user with id = " + txtUserId.Text + " success");
                            loadData();
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Something went wrong while update user have id equal = " + txtUserId.Text);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Can't find data with user have id equal = " + txtUserId.Text, "Notifications", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvUsers.CurrentRow != null)
            {
                if (MessageBox.Show("Are you sure want to delete?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ManageCafeInternetDataContext mci = new ManageCafeInternetDataContext();
                    var f = mci.users.FirstOrDefault(x => x.entity_id == Convert.ToInt32(txtUserId.Text));
                    if (f != null)
                    {
                        mci.deleteUser(Convert.ToInt32(txtUserId.Text));
                        MessageBox.Show("Delete user with id = " + txtUserId.Text + " success");
                        loadData();
                    }
                }
            }
            else
            {
                MessageBox.Show("Can't find data with computer have id equal = " + txtUserId.Text, "Notifications", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvUsers_Click(object sender, EventArgs e)
        {
            loadUserDetail();
        }

        private bool validate()
        {
            if (txtAccount.Text == "")
            {
                MessageBox.Show("Account can't be null");
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("Pass can't be null");
            }
            else if (txtFirstName.Text == "")
            {
                MessageBox.Show("First Name turn on can't be null");
            }
            else if (txtLastName.Text == "")
            {
                MessageBox.Show("Last Name turn on can't be null");
            }
            else
            {
                return true;
            }
            return false;
        }
    }
}
