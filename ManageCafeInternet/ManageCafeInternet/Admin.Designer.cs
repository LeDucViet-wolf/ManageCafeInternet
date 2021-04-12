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
            this.tctMain = new System.Windows.Forms.TabControl();
            this.tpUsers = new System.Windows.Forms.TabPage();
            this.tpComputer = new System.Windows.Forms.TabPage();
            this.menuStrip1.SuspendLayout();
            this.tctMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFoods,
            this.tsmiComputers,
            this.tmsiUsers});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1924, 56);
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
            // tctMain
            // 
            this.tctMain.Controls.Add(this.tpUsers);
            this.tctMain.Controls.Add(this.tpComputer);
            this.tctMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tctMain.Location = new System.Drawing.Point(0, 59);
            this.tctMain.Name = "tctMain";
            this.tctMain.SelectedIndex = 0;
            this.tctMain.Size = new System.Drawing.Size(1164, 473);
            this.tctMain.TabIndex = 1;
            // 
            // tpUsers
            // 
            this.tpUsers.Location = new System.Drawing.Point(4, 29);
            this.tpUsers.Name = "tpUsers";
            this.tpUsers.Padding = new System.Windows.Forms.Padding(3);
            this.tpUsers.Size = new System.Drawing.Size(1156, 440);
            this.tpUsers.TabIndex = 0;
            this.tpUsers.Text = "User Form";
            this.tpUsers.UseVisualStyleBackColor = true;
            // 
            // tpComputer
            // 
            this.tpComputer.Location = new System.Drawing.Point(4, 29);
            this.tpComputer.Name = "tpComputer";
            this.tpComputer.Padding = new System.Windows.Forms.Padding(3);
            this.tpComputer.Size = new System.Drawing.Size(1156, 440);
            this.tpComputer.TabIndex = 1;
            this.tpComputer.Text = "Food Form";
            this.tpComputer.UseVisualStyleBackColor = true;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1041);
            this.Controls.Add(this.tctMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tctMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiFoods;
        private System.Windows.Forms.ToolStripMenuItem tsmiComputers;
        private System.Windows.Forms.ToolStripMenuItem tmsiUsers;
        private System.Windows.Forms.TabControl tctMain;
        private System.Windows.Forms.TabPage tpUsers;
        private System.Windows.Forms.TabPage tpComputer;
    }
}