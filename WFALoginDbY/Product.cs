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
    public partial class Product : Form
    {
        public DataAccess da { get; set; }
        Admin ad;

        public Product(string name, Admin ad) : this()
        {
            this.ad = ad;
        }
        public Product()
        {
            InitializeComponent();
            this.da = new DataAccess();
            this.AutoIdGenerate();
        }
        private void PopulateGridView(string sql = "select * from Product;")
        {
            var ds = this.da.ExecuteQuery(sql);
            this.dgvProduct.DataSource = ds.Tables[0];
        }
        private bool IsValidToSave()
        {
            if (string.IsNullOrEmpty(this.txtProductId.Text) || string.IsNullOrEmpty(this.txtName.Text) || string.IsNullOrEmpty(this.txtPrice.Text) || string.IsNullOrEmpty(this.txtStock.Text) || string.IsNullOrEmpty(this.dtpExpiryDate.Text))
                return false;
            else
                return true;
        }

        private void pnlProduct_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.ad.Show();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtProductId.Clear();
            txtName.Clear();
            
            txtPrice.Clear();
            txtStock.Clear();

            this.AutoIdGenerate();
            this.dgvProduct.ClearSelection();
        }
        private void AutoIdGenerate()
        {
            var sql = "select max(Id) from Product;";
            DataTable dt = this.da.ExecuteQueryTable(sql);
            var oldId = dt.Rows[0][0].ToString();
            var temp = oldId.Split('-');
            var num = Convert.ToInt32(temp[1]);
            var currentId = "p-" + (++num).ToString("d3");
            this.txtProductId.Text = currentId;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            this.PopulateGridView();
            dgvProduct.ClearSelection();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvProduct.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Please select a row first to delete.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                var id = this.dgvProduct.CurrentRow.Cells["Id"].Value.ToString();
                var name = this.dgvProduct.CurrentRow.Cells["colName"].Value.ToString();

                var result = MessageBox.Show("Are you sure to delete data?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (result == DialogResult.No)
                    return;
                var sql = "delete from Product where Id = '" + id + "';";
                var count = this.da.ExecuteDMLQuery(sql);

                if (count == 1)
                    MessageBox.Show(name.ToUpper() + " has been removed from the list");
                else
                    MessageBox.Show("Data hasn't been deleted from the list");

                this.PopulateGridView();
                this.AutoIdGenerate();
                txtProductId.Clear();
                txtName.Clear();
                
                txtPrice.Clear();
                txtStock.Clear();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occurred in the system, please try again.\n" + exc.Message);
            }

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

                var query = "select * from Product Where Id = '" + this.txtProductId.Text + "';";
                var ds = this.da.ExecuteQuery(query);
                if (ds.Tables[0].Rows.Count == 0)
                {
                    var sql = "insert into Product values('" + this.txtProductId.Text + "', '" + this.txtName.Text + "'," + this.txtPrice.Text + "," + this.txtStock.Text + ",'" + this.dtpExpiryDate.Value + "'); ";
                    var count = this.da.ExecuteDMLQuery(sql);
                    if (count == 1)
                        MessageBox.Show("Data has been added in the list");
                    else
                        MessageBox.Show("Data hasn't been added in the list");
                }
                else
                {
                    var sql = @"update Product
                                set Id = '" + this.txtProductId.Text + @"',
                                Name = '" + this.txtName.Text + @"',
                                Price = " + this.txtPrice.Text + @",
                                Stock = " + this.txtStock.Text + @",
                                ExpiryDate = '" + this.dtpExpiryDate.Value + @"',
                                where Id = '" + this.txtProductId.Text + "'; ";
                    var count = this.da.ExecuteDMLQuery(sql);
                    if (count == 1)
                        MessageBox.Show("Data has been updated in the list");
                    else
                        MessageBox.Show("Data hasn't been updated in the list");
                    txtProductId.Clear();
                    txtName.Clear();
                    txtPrice.Clear();
                    txtStock.Clear();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occurred in the system, please try again.\n" + exc.Message);
            }
 


        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrEmpty(this.txtProductId.Text))
                {
                    MessageBox.Show("Please enter a Product ID.");
                    return;
                }
                string query = "select Id, name, Price,stock, ExpiryDate from Product where Id = '" + this.txtProductId.Text + "';";

                var ds = this.da.ExecuteQuery(query);

                if (ds.Tables[0].Rows.Count > 0)
                {

                    this.dgvProduct.DataSource = ds.Tables[0];

                    MessageBox.Show("Product is Available.");
                }
                else
                {
                    this.dgvProduct.DataSource = null;
                    MessageBox.Show("Product Not Found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dtpExpiryDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtProductId_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

