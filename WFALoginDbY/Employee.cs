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
    public partial class Billing : Form
    {
        public DataAccess da { get; set; }
        public Billing()
        {
            InitializeComponent();
                
            try
            {
                this.da = new DataAccess();
                this.PopulateGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening Billing form: " + ex.Message);
            }


        }
        private void PopulateGridView(string sql = "SELECT Id, name, price, stock FROM Product;")
        {
            try
            {
                var ds = this.da.ExecuteQuery(sql);
                this.dgvInventory.AutoGenerateColumns = false;
                this.dgvInventory.DataSource = ds.Tables[0];

                this.dgvInventory.Columns["Id"].DataPropertyName = "Id";
                this.dgvInventory.Columns["name"].DataPropertyName = "name";
                this.dgvInventory.Columns["price"].DataPropertyName = "price";
                this.dgvInventory.Columns["stock"].DataPropertyName = "stock";

                this.dgvInventory.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while loading data: " + ex.Message);
            }
        }
       

        private void Billing_Load(object sender, EventArgs e)
        {
            this.dgvInventory.ClearSelection();
        }

        private void lblEmployee_Click(object sender, EventArgs e)
        {

        }

        private void btnCheckProduct_Click(object sender, EventArgs e)
        {
            CheckProduct cproduct = new CheckProduct(this.Text,this);
            cproduct.Visible = true;
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new Login().Show();
        }

        private void dgvTotalBills_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblCustomerName_Click(object sender, EventArgs e)
        {

        }

        private void txtCustomerName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddBill_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvInventory.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Please select a product from the list.");
                    return;
                }

                var row = dgvInventory.SelectedRows[0];
                string prodId = row.Cells["Id"].Value.ToString();
                string prodName = row.Cells["name"].Value.ToString();
                decimal price = Convert.ToDecimal(row.Cells["price"].Value);
                int stock = Convert.ToInt32(row.Cells["stock"].Value);

                if (!int.TryParse(txtQuantity.Text, out int qty) || qty <= 0)
                {
                    MessageBox.Show("Invalid quantity.");
                    return;
                }

                if (qty > stock)
                {
                    MessageBox.Show("Not enough stock available.");
                    return;
                }
                decimal total = price * qty;
                dgvClientBill.Rows.Add(prodId, prodName, price, qty, total);

                int newStock = stock - qty;
                string updateSql = "UPDATE Product SET stock = " + newStock + " WHERE Id = '" + prodId + "'";
                this.da.ExecuteDMLQuery(updateSql);

                this.PopulateGridView(); 
                UpdateTotalAmount();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void UpdateTotalAmount()
        {
            decimal sum = 0;
            foreach (DataGridViewRow row in dgvClientBill.Rows)
            {
                if (row.Cells["Total"].Value != null)
                    sum += Convert.ToDecimal(row.Cells["Total"].Value);
            }
            lblTotalAmount.Text = sum.ToString("0.00");
        }
        private string GenerateBillId()
        {
            var dt = da.ExecuteQueryTable("SELECT MAX(BillId) FROM Bill;");
            if (dt.Rows[0][0] == DBNull.Value) return "b-001";
            string oldId = dt.Rows[0][0].ToString();
            int number = Convert.ToInt32(oldId.Split('-')[1]);
            return "b-" + (++number).ToString("D3");
        }

        private string GenerateCustomerId()
        {
            var dt = da.ExecuteQueryTable("SELECT [Customer Id] FROM CustomerTable;");
            int maxNumber = 0;
            foreach (DataRow row in dt.Rows)
            {
                string id = row["Customer Id"].ToString();
                if (id.StartsWith("cu-") && int.TryParse(id.Split('-')[1], out int num))
                {
                    if (num > maxNumber) maxNumber = num;
                }
            }
            return "cu-" + (maxNumber + 1).ToString("D3");
        }

        private bool IsValidCustomerPhone(string phone)
        {
            return !string.IsNullOrWhiteSpace(phone) &&
                   phone.Length == 11 &&
                   phone.StartsWith("01") &&
                   phone.All(char.IsDigit);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvClientBill.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvClientBill.SelectedRows)
                {
                    dgvClientBill.Rows.Remove(row);
                }
                UpdateTotalAmount();
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "No row selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtCustomerName.Clear();
            txtCustomerPhone.Clear();
            txtProductId.Clear();
            txtQuantity.Clear();
            dgvClientBill.Rows.Clear();
            lblTotalAmount.Text = "Total Bills: 0.00";
            this.PopulateGridView();
        }

        private void btnPrintBills_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvClientBill.Rows.Count == 0)
                {
                    MessageBox.Show("Bill is empty.");
                    return;
                }

                string phone = txtCustomerPhone.Text;
                string name = txtCustomerName.Text;

                string sqlCheck = "SELECT [Customer Id] FROM CustomerTable WHERE [Customer Phone] = '" + phone + "'";
                var dt = da.ExecuteQueryTable(sqlCheck);
                string cId;

                if (dt.Rows.Count == 0)
                {
                    cId = GenerateCustomerId();
                    string insertCustomer = "INSERT INTO CustomerTable ([Customer Id], [Customer Name], [Customer Phone]) VALUES ('" + cId + "', '" + name + "', '" + phone + "')";
                    da.ExecuteDMLQuery(insertCustomer);
                }
                else
                {
                    cId = dt.Rows[0][0].ToString();
                }

                string bId = GenerateBillId();
                decimal grandTotal = Convert.ToDecimal(lblTotalAmount.Text);
                string insertBill = "INSERT INTO Bill (BillId, CustomerId, CustomerName, CustomerPhone, TotalAmount) " +"VALUES ('" + bId + "', '" + cId + "', '" + name + "', '" + phone + "', " + grandTotal + ")";
                da.ExecuteDMLQuery(insertBill);

                string invoice = "Bill" + name + "\nPh ID: " + bId + "\nCustomer Phone: " + phone + "\nTotal: " + grandTotal + " TK";
                MessageBox.Show(invoice, "Invoice Generated");

                dgvClientBill.Rows.Clear();
                lblTotalAmount.Text = "0.00";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generating bill: " + ex.Message);
            }
        }

        private void btnShowDetails_Click(object sender, EventArgs e)
        {
            this.PopulateGridView();
        }
    }
}