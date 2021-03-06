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
            this.pnAdmin.BackColor = System.Drawing.Color.White;
            
            FoodForm ff = new FoodForm();
            ff.TopLevel = false;
            ff.Size = pnAdmin.Size;
            pnAdmin.Controls.Clear();
            ff.Dock = DockStyle.Fill;
            ff.Show();
            pnAdmin.Controls.Add(ff);
        }

        private void tsmiComputers_Click(object sender, EventArgs e)
        {
            this.pnAdmin.BackColor = System.Drawing.Color.White;
            ComputerForm cf = new ComputerForm();
            cf.TopLevel = false;
            cf.Size = pnAdmin.Size;
            pnAdmin.Controls.Clear();
            cf.Dock = DockStyle.Fill;
            cf.Show();
            pnAdmin.Controls.Add(cf);
        }

        private void tmsiUsers_Click(object sender, EventArgs e)
        {
            this.pnAdmin.BackColor = System.Drawing.Color.White;
            UserForm uf = new UserForm();
            uf.TopLevel = false;
            uf.Size = pnAdmin.Size;
            pnAdmin.Controls.Clear();
            uf.Dock = DockStyle.Fill;
            uf.Show();
            pnAdmin.Controls.Add(uf);
        }

        private void tsmlLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmiArea_Click(object sender, EventArgs e)
        {
            this.pnAdmin.BackColor = System.Drawing.Color.White;
            AreaForm af = new AreaForm();
            af.TopLevel = false;
            af.Size = pnAdmin.Size;
            pnAdmin.Controls.Clear();
            af.Dock = DockStyle.Fill;
            af.Show();
            pnAdmin.Controls.Add(af);
        }

        private void tsmiReport_Click(object sender, EventArgs e)
        {
            this.pnAdmin.BackColor = System.Drawing.Color.White;
            Report r = new Report();
            r.TopLevel = false;
            r.Size = pnAdmin.Size;
            pnAdmin.Controls.Clear();
            r.Dock = DockStyle.Fill;
            r.Show();
            pnAdmin.Controls.Add(r);
        }
    }
}
