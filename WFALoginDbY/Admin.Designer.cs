namespace WFALoginDbY
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
            this.dgvAdmin = new System.Windows.Forms.DataGridView();
            this.pnlAdminLeft = new System.Windows.Forms.Panel();
            this.btnAddMember = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnEmployeeInfo = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.btnDashBoard = new System.Windows.Forms.Button();
            this.lblControl = new System.Windows.Forms.Label();
            this.pnlAdminRight = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtRole = new System.Windows.Forms.TextBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.lblUserId = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Named = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmin)).BeginInit();
            this.pnlAdminLeft.SuspendLayout();
            this.pnlAdminRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAdmin
            // 
            this.dgvAdmin.AllowUserToAddRows = false;
            this.dgvAdmin.AllowUserToDeleteRows = false;
            this.dgvAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdmin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Named,
            this.Password,
            this.Role});
            this.dgvAdmin.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvAdmin.Location = new System.Drawing.Point(0, 210);
            this.dgvAdmin.Name = "dgvAdmin";
            this.dgvAdmin.ReadOnly = true;
            this.dgvAdmin.RowHeadersWidth = 51;
            this.dgvAdmin.RowTemplate.Height = 24;
            this.dgvAdmin.Size = new System.Drawing.Size(610, 150);
            this.dgvAdmin.TabIndex = 0;
            this.dgvAdmin.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAdmin_CellContentClick);
            // 
            // pnlAdminLeft
            // 
            this.pnlAdminLeft.BackColor = System.Drawing.Color.Bisque;
            this.pnlAdminLeft.Controls.Add(this.btnAddMember);
            this.pnlAdminLeft.Controls.Add(this.btnLogout);
            this.pnlAdminLeft.Controls.Add(this.btnEmployeeInfo);
            this.pnlAdminLeft.Controls.Add(this.btnProduct);
            this.pnlAdminLeft.Controls.Add(this.btnDashBoard);
            this.pnlAdminLeft.Controls.Add(this.lblControl);
            this.pnlAdminLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlAdminLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlAdminLeft.Name = "pnlAdminLeft";
            this.pnlAdminLeft.Size = new System.Drawing.Size(154, 210);
            this.pnlAdminLeft.TabIndex = 1;
            this.pnlAdminLeft.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlAdminLeft_Paint);
            // 
            // btnAddMember
            // 
            this.btnAddMember.AutoSize = true;
            this.btnAddMember.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddMember.Location = new System.Drawing.Point(32, 38);
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.Size = new System.Drawing.Size(95, 26);
            this.btnAddMember.TabIndex = 6;
            this.btnAddMember.Text = "Add member";
            this.btnAddMember.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            this.btnLogout.AutoSize = true;
            this.btnLogout.BackColor = System.Drawing.Color.Red;
            this.btnLogout.Location = new System.Drawing.Point(40, 173);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 34);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnEmployeeInfo
            // 
            this.btnEmployeeInfo.Location = new System.Drawing.Point(25, 135);
            this.btnEmployeeInfo.Name = "btnEmployeeInfo";
            this.btnEmployeeInfo.Size = new System.Drawing.Size(103, 23);
            this.btnEmployeeInfo.TabIndex = 3;
            this.btnEmployeeInfo.Text = "Employee Info";
            this.btnEmployeeInfo.UseVisualStyleBackColor = true;
            this.btnEmployeeInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.AutoSize = true;
            this.btnProduct.Location = new System.Drawing.Point(25, 103);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(103, 26);
            this.btnProduct.TabIndex = 2;
            this.btnProduct.Text = " Product";
            this.btnProduct.UseVisualStyleBackColor = true;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnDashBoard
            // 
            this.btnDashBoard.AutoSize = true;
            this.btnDashBoard.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDashBoard.Location = new System.Drawing.Point(32, 71);
            this.btnDashBoard.Name = "btnDashBoard";
            this.btnDashBoard.Size = new System.Drawing.Size(89, 26);
            this.btnDashBoard.TabIndex = 1;
            this.btnDashBoard.Text = "Dash Board";
            this.btnDashBoard.UseVisualStyleBackColor = true;
            this.btnDashBoard.Click += new System.EventHandler(this.btnDashBoard_Click);
            // 
            // lblControl
            // 
            this.lblControl.AutoSize = true;
            this.lblControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblControl.Location = new System.Drawing.Point(39, 5);
            this.lblControl.Name = "lblControl";
            this.lblControl.Size = new System.Drawing.Size(82, 25);
            this.lblControl.TabIndex = 0;
            this.lblControl.Text = "Control";
            // 
            // pnlAdminRight
            // 
            this.pnlAdminRight.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pnlAdminRight.Controls.Add(this.btnDelete);
            this.pnlAdminRight.Controls.Add(this.txtRole);
            this.pnlAdminRight.Controls.Add(this.lblRole);
            this.pnlAdminRight.Controls.Add(this.txtName);
            this.pnlAdminRight.Controls.Add(this.lblName);
            this.pnlAdminRight.Controls.Add(this.btnClear);
            this.pnlAdminRight.Controls.Add(this.btnShow);
            this.pnlAdminRight.Controls.Add(this.btnAdd);
            this.pnlAdminRight.Controls.Add(this.lblInfo);
            this.pnlAdminRight.Controls.Add(this.txtPassword);
            this.pnlAdminRight.Controls.Add(this.lblPass);
            this.pnlAdminRight.Controls.Add(this.txtUserId);
            this.pnlAdminRight.Controls.Add(this.lblUserId);
            this.pnlAdminRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlAdminRight.Location = new System.Drawing.Point(160, 0);
            this.pnlAdminRight.Name = "pnlAdminRight";
            this.pnlAdminRight.Size = new System.Drawing.Size(450, 210);
            this.pnlAdminRight.TabIndex = 2;
            this.pnlAdminRight.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlAdminRight_Paint);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(224, 173);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(68, 31);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtRole
            // 
            this.txtRole.Location = new System.Drawing.Point(224, 124);
            this.txtRole.Name = "txtRole";
            this.txtRole.Size = new System.Drawing.Size(144, 22);
            this.txtRole.TabIndex = 14;
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(103, 124);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(39, 16);
            this.lblRole.TabIndex = 13;
            this.lblRole.Text = " Role";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(224, 96);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(144, 22);
            this.txtName.TabIndex = 12;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(103, 96);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 16);
            this.lblName.TabIndex = 11;
            this.lblName.Text = "Name";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(3, 173);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(68, 31);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click_1);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(344, 173);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(103, 31);
            this.btnShow.TabIndex = 9;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(106, 173);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(89, 33);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(166, 9);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(46, 20);
            this.lblInfo.TabIndex = 4;
            this.lblInfo.Text = " Info";
            this.lblInfo.Click += new System.EventHandler(this.lblAdminInfo_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(224, 68);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(144, 22);
            this.txtPassword.TabIndex = 3;
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(103, 66);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(70, 16);
            this.lblPass.TabIndex = 2;
            this.lblPass.Text = " Password";
            // 
            // txtUserId
            // 
            this.txtUserId.Location = new System.Drawing.Point(224, 40);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(144, 22);
            this.txtUserId.TabIndex = 1;
            this.txtUserId.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblUserId
            // 
            this.lblUserId.AutoSize = true;
            this.lblUserId.Location = new System.Drawing.Point(103, 40);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(50, 16);
            this.lblUserId.TabIndex = 0;
            this.lblUserId.Text = "User Id";
            this.lblUserId.Click += new System.EventHandler(this.label1_Click);
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "User Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Named
            // 
            this.Named.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Named.DataPropertyName = "Name";
            this.Named.HeaderText = "Name";
            this.Named.MinimumWidth = 6;
            this.Named.Name = "Named";
            this.Named.ReadOnly = true;
            // 
            // Password
            // 
            this.Password.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Password.DataPropertyName = "Password";
            this.Password.HeaderText = "Password";
            this.Password.MinimumWidth = 6;
            this.Password.Name = "Password";
            this.Password.ReadOnly = true;
            // 
            // Role
            // 
            this.Role.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Role.DataPropertyName = "Role";
            this.Role.HeaderText = "Role";
            this.Role.MinimumWidth = 6;
            this.Role.Name = "Role";
            this.Role.ReadOnly = true;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 360);
            this.Controls.Add(this.pnlAdminRight);
            this.Controls.Add(this.pnlAdminLeft);
            this.Controls.Add(this.dgvAdmin);
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmin)).EndInit();
            this.pnlAdminLeft.ResumeLayout(false);
            this.pnlAdminLeft.PerformLayout();
            this.pnlAdminRight.ResumeLayout(false);
            this.pnlAdminRight.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAdmin;
        private System.Windows.Forms.Panel pnlAdminLeft;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnEmployeeInfo;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Button btnDashBoard;
        private System.Windows.Forms.Label lblControl;
        private System.Windows.Forms.Panel pnlAdminRight;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtRole;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAddMember;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Named;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn Role;
    }
}