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
            tctMain.TabPages.Remove(tpUsers);
            tctMain.TabPages.Remove(tpComputer);
        }

        private void tsmiFoods_Click(object sender, EventArgs e)
        {
            FoodForm ff = new FoodForm();
            ff.Show();
        }

        private void tsmiComputers_Click(object sender, EventArgs e)
        {
            //ComputerForm cf = new ComputerForm();
            //cf.Show();
            if (tctMain.TabPages.Count == 0)
            {
                tctMain.TabPages.Add(tpComputer);
            }
            else
            {
                foreach (TabPage t in tctMain.TabPages)
                {
                    if (t.Created && tpComputer.Parent == t)
                    {
                        tctMain.TabPages.Add(tpComputer);
                    }
                }
            }
        }

        private void tmsiUsers_Click(object sender, EventArgs e)
        {
            if (tctMain.TabPages.Count == 0)
            {
                tctMain.TabPages.Add(tpUsers);
            }
            else
            {
                foreach (TabPage t in tctMain.TabPages)
                {
                    if (t.Created && tpUsers.Parent == t)
                    {
                        tctMain.TabPages.Add(tpUsers);
                    }
                }
            }
        }
    }
}
