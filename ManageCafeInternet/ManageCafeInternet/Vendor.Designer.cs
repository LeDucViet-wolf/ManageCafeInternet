namespace ManageCafeInternet
{
    partial class Vendor
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
            this.components = new System.ComponentModel.Container();
            this.dgvComputers = new System.Windows.Forms.DataGridView();
            this.cbxArea = new System.Windows.Forms.ComboBox();
            this.txtComputerId = new System.Windows.Forms.TextBox();
            this.cmsOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiTurnOn = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAddFoods = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCheckout = new System.Windows.Forms.ToolStripMenuItem();
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComputers)).BeginInit();
            this.cmsOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvComputers
            // 
            this.dgvComputers.AllowUserToAddRows = false;
            this.dgvComputers.AllowUserToDeleteRows = false;
            this.dgvComputers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComputers.Location = new System.Drawing.Point(12, 39);
            this.dgvComputers.Name = "dgvComputers";
            this.dgvComputers.ReadOnly = true;
            this.dgvComputers.Size = new System.Drawing.Size(719, 435);
            this.dgvComputers.TabIndex = 0;
            this.dgvComputers.Click += new System.EventHandler(this.dgvComputers_Click);
            this.dgvComputers.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvComputers_MouseDown);
            // 
            // cbxArea
            // 
            this.cbxArea.AllowDrop = true;
            this.cbxArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxArea.FormattingEnabled = true;
            this.cbxArea.Location = new System.Drawing.Point(12, 12);
            this.cbxArea.Name = "cbxArea";
            this.cbxArea.Size = new System.Drawing.Size(304, 21);
            this.cbxArea.TabIndex = 1;
            this.cbxArea.SelectedIndexChanged += new System.EventHandler(this.cbxArea_SelectedIndexChanged);
            // 
            // txtComputerId
            // 
            this.txtComputerId.Location = new System.Drawing.Point(322, 13);
            this.txtComputerId.Name = "txtComputerId";
            this.txtComputerId.ReadOnly = true;
            this.txtComputerId.Size = new System.Drawing.Size(26, 20);
            this.txtComputerId.TabIndex = 3;
            // 
            // cmsOptions
            // 
            this.cmsOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiTurnOn,
            this.tsmiAddFoods,
            this.tsmiCheckout});
            this.cmsOptions.Name = "cmsOptions";
            this.cmsOptions.Size = new System.Drawing.Size(132, 70);
            // 
            // tsmiTurnOn
            // 
            this.tsmiTurnOn.Name = "tsmiTurnOn";
            this.tsmiTurnOn.Size = new System.Drawing.Size(131, 22);
            this.tsmiTurnOn.Text = "Turn On";
            this.tsmiTurnOn.Click += new System.EventHandler(this.tsmiTurnOn_Click);
            // 
            // tsmiAddFoods
            // 
            this.tsmiAddFoods.Name = "tsmiAddFoods";
            this.tsmiAddFoods.Size = new System.Drawing.Size(131, 22);
            this.tsmiAddFoods.Text = "Add Foods";
            this.tsmiAddFoods.Click += new System.EventHandler(this.tsmiAddFoods_Click);
            // 
            // tsmiCheckout
            // 
            this.tsmiCheckout.Name = "tsmiCheckout";
            this.tsmiCheckout.Size = new System.Drawing.Size(131, 22);
            this.tsmiCheckout.Text = "Checkout";
            this.tsmiCheckout.Click += new System.EventHandler(this.tsmiCheckout_Click);
            // 
            // txtSearchName
            // 
            this.txtSearchName.Location = new System.Drawing.Point(411, 13);
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Size = new System.Drawing.Size(320, 20);
            this.txtSearchName.TabIndex = 4;
            this.txtSearchName.TextChanged += new System.EventHandler(this.txtSearchName_TextChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(595, 480);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(136, 59);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Vendor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 551);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtSearchName);
            this.Controls.Add(this.txtComputerId);
            this.Controls.Add(this.cbxArea);
            this.Controls.Add(this.dgvComputers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Vendor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendor";
            this.Load += new System.EventHandler(this.Vendor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComputers)).EndInit();
            this.cmsOptions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvComputers;
        private System.Windows.Forms.ComboBox cbxArea;
        public System.Windows.Forms.TextBox txtComputerId;
        private System.Windows.Forms.ContextMenuStrip cmsOptions;
        private System.Windows.Forms.ToolStripMenuItem tsmiTurnOn;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddFoods;
        private System.Windows.Forms.ToolStripMenuItem tsmiCheckout;
        private System.Windows.Forms.TextBox txtSearchName;
        private System.Windows.Forms.Button btnCancel;
    }
}