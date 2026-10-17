using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFALoginDbY
{
    public partial class Admin : Form
    {
        public DataAccess da { get; set; }
        public Admin()
        {
            InitializeComponent();
            this.da = new DataAccess();
            this.AutoIdGenerate();
            //this.PopulateGridView();
        }
        private void PopulateGridView(string sql = "select * from UserInfo;")
        {
            var ds = this.da.ExecuteQuery(sql);
            this.dgvAdmin.DataSource = ds.Tables[0];
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            this.dgvAdmin.ClearSelection();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            EmployeeInfo ei = new EmployeeInfo(this.Text, this);
            ei.Visible = true;
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new Login().Show();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            Product pproduct = new Product(this.Text, this);
            pproduct.Visible = true;
            this.Hide();
        }

        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            DashBoard db = new DashBoard(this.Text, this);
            db.Visible = true;
            this.Hide();
        }

        private void lblAdminInfo_Click(object sender, EventArgs e)
        {

        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            this.PopulateGridView();
            dgvAdmin.ClearSelection();

        }
        private bool IsValidToSave()
        {
            if (string.IsNullOrEmpty(this.txtUserId.Text) || string.IsNullOrEmpty(this.txtPassword.Text))
                return false;
            else
                return true;
        }

        private void dgvAdmin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.IsValidToSave())
                {
                    MessageBox.Show("Please fill all the empty fields");
                    return;
                }

                var query = "select * from UserInfo Where Id = '" + this.txtUserId.Text + "';";
                var ds = this.da.ExecuteQuery(query);

                if (ds.Tables[0].Rows.Count == 0)
                {
                    var sql = "insert into UserInfo(Id, password,name, role) values('" + this.txtUserId.Text + "', '" + this.txtPassword.Text + "','" + this.txtName.Text + "','" + this.txtRole.Text + "'); ";
                    var count = this.da.ExecuteDMLQuery(sql);
                    if (count == 1)
                        MessageBox.Show("Data has been added in the list");
                    else
                        MessageBox.Show("Data hasn't been added in the list");
                }
                else
                {
                    var sql = @"update Userinfo
                                set Id = '" + this.txtUserId.Text + @"',
                                Password = '" + this.txtPassword.Text + @"',
                                Name = '" + this.txtName.Text + @"',
                                Role = '" + this.txtRole.Text + @"'
                                where Id = '" + this.txtUserId.Text + "'; ";
                    var count = this.da.ExecuteDMLQuery(sql);

                    if (count == 1)
                        MessageBox.Show("Data has been updated in the list");
                    else
                        MessageBox.Show("Data hasn't been updated in the list");

                    
                }
                txtUserId.Clear();
                txtPassword.Clear();
                txtName.Clear();
                txtRole.Clear();
            }
                catch (Exception exc)
         {
              MessageBox.Show("An error has occurred in the system, please try again.\n" + exc.Message);
          }

        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            txtUserId.Clear();
            txtPassword.Clear();
            txtName.Clear();
            txtRole.Clear();

            this.AutoIdGenerate();
            this.dgvAdmin.ClearSelection();
        }
        private void AutoIdGenerate()
        {
            var sql = "select max(Id) from UserInfo;";
            DataTable dt = this.da.ExecuteQueryTable(sql);
            var oldId = dt.Rows[0][0].ToString();
            var temp = oldId.Split('-');
            var num = Convert.ToInt32(temp[1]);
            var currentId = "u-" + (++num).ToString("d3");
            this.txtUserId.Text = currentId;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvAdmin.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Please select a row first to delete.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                var id = this.dgvAdmin.CurrentRow.Cells["Id"].Value.ToString();
                var name = this.dgvAdmin.CurrentRow.Cells["named"].Value.ToString();

                var result = MessageBox.Show("Are you sure to delete data?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (result == DialogResult.No)
                    return;

                var sql = "delete from Userinfo where Id = '" + id + "';";
                var count = this.da.ExecuteDMLQuery(sql);

                if (count == 1)
                    MessageBox.Show(name.ToUpper() + " has been removed from the list");
                else
                    MessageBox.Show("Data hasn't been deleted from the list");

                this.PopulateGridView();
                this.AutoIdGenerate();
                txtUserId.Clear();
                txtPassword.Clear();
                txtName.Clear();
                txtRole.Clear();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occurred in the system, please try again.\n" + exc.Message);
            }
        }

        private void pnlAdminRight_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void pnlAdminLeft_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
