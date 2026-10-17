using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WFALoginDbY
{
    public partial class CheckProduct : Form
    {
        Billing ep;

        public CheckProduct(string name, Billing ep) : this()
        {
            this.ep = ep;
        }
        public DataAccess da { get; set; }
        public CheckProduct()
        {
            InitializeComponent();
            this.da = new DataAccess();
       
        }
        private void PopulateGridView(string sql = "select * from Product;")
        {
            var ds = this.da.ExecuteQuery(sql);
            this.dgvCheckProduct.DataSource = ds.Tables[0];
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.ep.Show();
        }

        private void btnCheck_Click(object sender, EventArgs e)
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
                    
                    this.dgvCheckProduct.DataSource = ds.Tables[0];

                    MessageBox.Show("Product is Available.");
                }
                else
                {
                    this.dgvCheckProduct.DataSource = null;
                    MessageBox.Show("Product Not Found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {

            this.PopulateGridView();
            
        }
    }
    }

