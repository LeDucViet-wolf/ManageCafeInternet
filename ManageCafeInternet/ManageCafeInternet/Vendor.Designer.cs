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
            this.dgvComputers = new System.Windows.Forms.DataGridView();
            this.cbxArea = new System.Windows.Forms.ComboBox();
            this.btnTurnOnComputer = new System.Windows.Forms.Button();
            this.txtComputerId = new System.Windows.Forms.TextBox();
            this.btnAddFoods = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComputers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvComputers
            // 
            this.dgvComputers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComputers.Location = new System.Drawing.Point(12, 39);
            this.dgvComputers.Name = "dgvComputers";
            this.dgvComputers.Size = new System.Drawing.Size(1432, 550);
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
            // btnTurnOnComputer
            // 
            this.btnTurnOnComputer.Location = new System.Drawing.Point(1482, 114);
            this.btnTurnOnComputer.Name = "btnTurnOnComputer";
            this.btnTurnOnComputer.Size = new System.Drawing.Size(75, 23);
            this.btnTurnOnComputer.TabIndex = 2;
            this.btnTurnOnComputer.Text = "Turn on";
            this.btnTurnOnComputer.UseVisualStyleBackColor = true;
            this.btnTurnOnComputer.Click += new System.EventHandler(this.btnTurnOnComputer_Click);
            // 
            // txtComputerId
            // 
            this.txtComputerId.Location = new System.Drawing.Point(1493, 53);
            this.txtComputerId.Name = "txtComputerId";
            this.txtComputerId.ReadOnly = true;
            this.txtComputerId.Size = new System.Drawing.Size(100, 20);
            this.txtComputerId.TabIndex = 3;
            // 
            // btnAddFoods
            // 
            this.btnAddFoods.Location = new System.Drawing.Point(1563, 114);
            this.btnAddFoods.Name = "btnAddFoods";
            this.btnAddFoods.Size = new System.Drawing.Size(75, 23);
            this.btnAddFoods.TabIndex = 4;
            this.btnAddFoods.Text = "Add foods";
            this.btnAddFoods.UseVisualStyleBackColor = true;
            this.btnAddFoods.Click += new System.EventHandler(this.btnAddFoods_Click);
            // 
            // Vendor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1041);
            this.Controls.Add(this.btnAddFoods);
            this.Controls.Add(this.txtComputerId);
            this.Controls.Add(this.btnTurnOnComputer);
            this.Controls.Add(this.cbxArea);
            this.Controls.Add(this.dgvComputers);
            this.Name = "Vendor";
            this.Text = "Vendor";
            this.Load += new System.EventHandler(this.Vendor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComputers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvComputers;
        private System.Windows.Forms.ComboBox cbxArea;
        private System.Windows.Forms.Button btnTurnOnComputer;
        private System.Windows.Forms.TextBox txtComputerId;
        private System.Windows.Forms.Button btnAddFoods;
    }
}