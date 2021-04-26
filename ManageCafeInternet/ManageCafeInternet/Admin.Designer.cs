namespace ManageCafeInternet
{
    partial class Admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiFoods = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiComputers = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsiUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmlLogOut = new System.Windows.Forms.ToolStripMenuItem();
            this.pnAdmin = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFoods,
            this.tsmiComputers,
            this.tmsiUsers,
            this.tsmlLogOut});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1224, 56);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiFoods
            // 
            this.tsmiFoods.Image = global::ManageCafeInternet.Properties.Resources.admin_food;
            this.tsmiFoods.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiFoods.Name = "tsmiFoods";
            this.tsmiFoods.Size = new System.Drawing.Size(145, 52);
            this.tsmiFoods.Text = "Manage Foods";
            this.tsmiFoods.Click += new System.EventHandler(this.tsmiFoods_Click);
            // 
            // tsmiComputers
            // 
            this.tsmiComputers.Image = global::ManageCafeInternet.Properties.Resources.admin_computer;
            this.tsmiComputers.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiComputers.Name = "tsmiComputers";
            this.tsmiComputers.Size = new System.Drawing.Size(172, 52);
            this.tsmiComputers.Text = "Manage Computers";
            this.tsmiComputers.Click += new System.EventHandler(this.tsmiComputers_Click);
            // 
            // tmsiUsers
            // 
            this.tmsiUsers.Image = global::ManageCafeInternet.Properties.Resources.admin_user;
            this.tmsiUsers.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tmsiUsers.Name = "tmsiUsers";
            this.tmsiUsers.Size = new System.Drawing.Size(131, 52);
            this.tmsiUsers.Text = "Manage Users";
            this.tmsiUsers.Click += new System.EventHandler(this.tmsiUsers_Click);
            // 
            // tsmlLogOut
            // 
            this.tsmlLogOut.Image = global::ManageCafeInternet.Properties.Resources.loggin_button1;
            this.tsmlLogOut.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmlLogOut.Name = "tsmlLogOut";
            this.tsmlLogOut.Size = new System.Drawing.Size(94, 52);
            this.tsmlLogOut.Text = "Log Out";
            this.tsmlLogOut.Click += new System.EventHandler(this.tsmlLogOut_Click);
            // 
            // pnAdmin
            // 
            this.pnAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnAdmin.Location = new System.Drawing.Point(0, 56);
            this.pnAdmin.Name = "pnAdmin";
            this.pnAdmin.Size = new System.Drawing.Size(1224, 564);
            this.pnAdmin.TabIndex = 1;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 620);
            this.Controls.Add(this.pnAdmin);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiFoods;
        private System.Windows.Forms.ToolStripMenuItem tsmiComputers;
        private System.Windows.Forms.ToolStripMenuItem tmsiUsers;
        private System.Windows.Forms.Panel pnAdmin;
        private System.Windows.Forms.ToolStripMenuItem tsmlLogOut;
    }
}