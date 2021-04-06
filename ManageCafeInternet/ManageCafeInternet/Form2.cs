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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        ManageCafeInternetDataContext mci = new ManageCafeInternetDataContext();
        private void btnLogin_Click(object sender, EventArgs e)
        {
            var a = mci.getUser(txtAccount.Text, txtPassword.Text);
            if (a.ToArray().Length > 1)
            {
                MessageBox.Show(a.ToArray()[0].role_id.ToString());
            } else
            {
                MessageBox.Show("Account or password is not valid");
            }
           
        }
    }
}
