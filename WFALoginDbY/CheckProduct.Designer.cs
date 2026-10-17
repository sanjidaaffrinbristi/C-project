namespace WFALoginDbY
{
    partial class CheckProduct
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
            this.dgvCheckProduct = new System.Windows.Forms.DataGridView();
            this.pnlCheckroduct = new System.Windows.Forms.Panel();
            this.lblCheckInfo = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnShowInfo = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.txtProductId = new System.Windows.Forms.TextBox();
            this.lblProductId = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpiryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckProduct)).BeginInit();
            this.pnlCheckroduct.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCheckProduct
            // 
            this.dgvCheckProduct.AllowUserToAddRows = false;
            this.dgvCheckProduct.AllowUserToDeleteRows = false;
            this.dgvCheckProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCheckProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Cname,
            this.Price,
            this.Stock,
            this.ExpiryDate});
            this.dgvCheckProduct.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvCheckProduct.Location = new System.Drawing.Point(0, 292);
            this.dgvCheckProduct.Name = "dgvCheckProduct";
            this.dgvCheckProduct.ReadOnly = true;
            this.dgvCheckProduct.RowHeadersWidth = 51;
            this.dgvCheckProduct.RowTemplate.Height = 24;
            this.dgvCheckProduct.Size = new System.Drawing.Size(800, 158);
            this.dgvCheckProduct.TabIndex = 0;
            // 
            // pnlCheckroduct
            // 
            this.pnlCheckroduct.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pnlCheckroduct.Controls.Add(this.lblCheckInfo);
            this.pnlCheckroduct.Controls.Add(this.btnBack);
            this.pnlCheckroduct.Controls.Add(this.btnShowInfo);
            this.pnlCheckroduct.Controls.Add(this.btnCheck);
            this.pnlCheckroduct.Controls.Add(this.txtProductId);
            this.pnlCheckroduct.Controls.Add(this.lblProductId);
            this.pnlCheckroduct.Location = new System.Drawing.Point(4, 12);
            this.pnlCheckroduct.Name = "pnlCheckroduct";
            this.pnlCheckroduct.Size = new System.Drawing.Size(796, 279);
            this.pnlCheckroduct.TabIndex = 1;
            // 
            // lblCheckInfo
            // 
            this.lblCheckInfo.AutoSize = true;
            this.lblCheckInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckInfo.Location = new System.Drawing.Point(292, 34);
            this.lblCheckInfo.Name = "lblCheckInfo";
            this.lblCheckInfo.Size = new System.Drawing.Size(136, 29);
            this.lblCheckInfo.TabIndex = 12;
            this.lblCheckInfo.Text = "Check Info";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(8, 245);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(98, 34);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnShowInfo
            // 
            this.btnShowInfo.Location = new System.Drawing.Point(686, 245);
            this.btnShowInfo.Name = "btnShowInfo";
            this.btnShowInfo.Size = new System.Drawing.Size(98, 34);
            this.btnShowInfo.TabIndex = 10;
            this.btnShowInfo.Text = "Show Info";
            this.btnShowInfo.UseVisualStyleBackColor = true;
            this.btnShowInfo.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.Linen;
            this.btnCheck.Location = new System.Drawing.Point(310, 211);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(98, 34);
            this.btnCheck.TabIndex = 9;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // txtProductId
            // 
            this.txtProductId.Location = new System.Drawing.Point(310, 104);
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.Size = new System.Drawing.Size(183, 22);
            this.txtProductId.TabIndex = 4;
            // 
            // lblProductId
            // 
            this.lblProductId.AutoSize = true;
            this.lblProductId.Location = new System.Drawing.Point(216, 110);
            this.lblProductId.Name = "lblProductId";
            this.lblProductId.Size = new System.Drawing.Size(69, 16);
            this.lblProductId.TabIndex = 0;
            this.lblProductId.Text = "Product ID";
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Product Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Cname
            // 
            this.Cname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Cname.DataPropertyName = "Name";
            this.Cname.HeaderText = "Name";
            this.Cname.MinimumWidth = 6;
            this.Cname.Name = "Cname";
            this.Cname.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Stock
            // 
            this.Stock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Stock.DataPropertyName = "Stock";
            this.Stock.HeaderText = "Available";
            this.Stock.MinimumWidth = 6;
            this.Stock.Name = "Stock";
            this.Stock.ReadOnly = true;
            // 
            // ExpiryDate
            // 
            this.ExpiryDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ExpiryDate.DataPropertyName = "ExpiryDate";
            this.ExpiryDate.HeaderText = "Expiry Date";
            this.ExpiryDate.MinimumWidth = 6;
            this.ExpiryDate.Name = "ExpiryDate";
            this.ExpiryDate.ReadOnly = true;
            // 
            // CheckProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlCheckroduct);
            this.Controls.Add(this.dgvCheckProduct);
            this.Name = "CheckProduct";
            this.Text = "CheckProduct";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckProduct)).EndInit();
            this.pnlCheckroduct.ResumeLayout(false);
            this.pnlCheckroduct.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCheckProduct;
        private System.Windows.Forms.Panel pnlCheckroduct;
        private System.Windows.Forms.TextBox txtProductId;
        private System.Windows.Forms.Label lblProductId;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnShowInfo;
        private System.Windows.Forms.Label lblCheckInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpiryDate;
    }
}