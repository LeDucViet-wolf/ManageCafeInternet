namespace ManageCafeInternet
{
    partial class AddFoodForm
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
            this.dgvFoods = new System.Windows.Forms.DataGridView();
            this.chk = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.QuantityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddFoods = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtComputerId = new System.Windows.Forms.TextBox();
            this.dgvSelectedFoods = new System.Windows.Forms.DataGridView();
            this.lblSelectedFoods = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoods)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectedFoods)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFoods
            // 
            this.dgvFoods.AllowUserToAddRows = false;
            this.dgvFoods.AllowUserToDeleteRows = false;
            this.dgvFoods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFoods.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chk,
            this.QuantityColumn});
            this.dgvFoods.Location = new System.Drawing.Point(12, 12);
            this.dgvFoods.Name = "dgvFoods";
            this.dgvFoods.Size = new System.Drawing.Size(1145, 198);
            this.dgvFoods.TabIndex = 0;
            this.dgvFoods.Click += new System.EventHandler(this.dgvFoods_Click);
            // 
            // chk
            // 
            this.chk.HeaderText = "";
            this.chk.Name = "chk";
            this.chk.Width = 50;
            // 
            // QuantityColumn
            // 
            this.QuantityColumn.HeaderText = "Quantity";
            this.QuantityColumn.Name = "QuantityColumn";
            // 
            // btnAddFoods
            // 
            this.btnAddFoods.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFoods.Location = new System.Drawing.Point(1002, 216);
            this.btnAddFoods.Name = "btnAddFoods";
            this.btnAddFoods.Size = new System.Drawing.Size(155, 59);
            this.btnAddFoods.TabIndex = 1;
            this.btnAddFoods.Text = "Add Selected";
            this.btnAddFoods.UseVisualStyleBackColor = true;
            this.btnAddFoods.Click += new System.EventHandler(this.btnAddFoods_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(788, 216);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 59);
            this.button1.TabIndex = 10;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtComputerId
            // 
            this.txtComputerId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComputerId.Location = new System.Drawing.Point(12, 216);
            this.txtComputerId.Name = "txtComputerId";
            this.txtComputerId.ReadOnly = true;
            this.txtComputerId.Size = new System.Drawing.Size(207, 31);
            this.txtComputerId.TabIndex = 12;
            // 
            // dgvSelectedFoods
            // 
            this.dgvSelectedFoods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelectedFoods.Location = new System.Drawing.Point(12, 331);
            this.dgvSelectedFoods.Name = "dgvSelectedFoods";
            this.dgvSelectedFoods.Size = new System.Drawing.Size(1145, 190);
            this.dgvSelectedFoods.TabIndex = 13;
            // 
            // lblSelectedFoods
            // 
            this.lblSelectedFoods.AutoSize = true;
            this.lblSelectedFoods.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedFoods.Location = new System.Drawing.Point(502, 303);
            this.lblSelectedFoods.Name = "lblSelectedFoods";
            this.lblSelectedFoods.Size = new System.Drawing.Size(174, 25);
            this.lblSelectedFoods.TabIndex = 14;
            this.lblSelectedFoods.Text = "Seleteced Foods";
            // 
            // AddFoodForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 533);
            this.Controls.Add(this.lblSelectedFoods);
            this.Controls.Add(this.dgvSelectedFoods);
            this.Controls.Add(this.txtComputerId);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAddFoods);
            this.Controls.Add(this.dgvFoods);
            this.Name = "AddFoodForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddFoodForm";
            this.Load += new System.EventHandler(this.AddFoodForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoods)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectedFoods)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFoods;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chk;
        private System.Windows.Forms.Button btnAddFoods;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox txtComputerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityColumn;
        private System.Windows.Forms.DataGridView dgvSelectedFoods;
        private System.Windows.Forms.Label lblSelectedFoods;
    }
}