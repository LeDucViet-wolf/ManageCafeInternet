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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        ManageCafeInternetDataContext mci = new ManageCafeInternetDataContext();
        private void btnLogin_Click(object sender, EventArgs e)
        {
            var a = mci.getUser(txtAccount.Text, txtPassword.Text).FirstOrDefault();
            if (a != null)
            {
                if (a.role_id == 1)
                {
                    MessageBox.Show("Hello Admin " + a.firstName.ToString() + " " + a.lastName.ToString());
                    Admin admin = new Admin();
                    this.Hide();
                    admin.Show();
                }
                else
                {
                    MessageBox.Show("Hello Vendor " + a.firstName.ToString() + " " + a.lastName.ToString());
                }
            }
            else
            {
                MessageBox.Show("Account or password is not valid");
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
