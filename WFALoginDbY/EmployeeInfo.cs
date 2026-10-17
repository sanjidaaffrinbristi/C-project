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
    public partial class EmployeeInfo : Form
    {
        public DataAccess da { get; set; }
        Admin ad;

        public EmployeeInfo(string name, Admin ad) : this()
        {
            this.ad = ad;
        }
        public EmployeeInfo()
        {
            InitializeComponent();
            this.da = new DataAccess();
           
        }
        private void PopulateGridView(string sql = "select * from UserInfo;")
        {
            var ds = this.da.ExecuteQuery(sql);
            this.dgvEmployeeInfo.DataSource = ds.Tables[0];
            this.dgvEmployeeInfo.ClearSelection();
            this.dgvEmployeeInfo.CurrentCell = null;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.ad.Show();
        }

        private void btnTotalEmployee_Click(object sender, EventArgs e)
        {
            string sql = "select count(Id) from UserInfo where Role = 'employee';";
            var ds = this.da.ExecuteQuery(sql);
            string total = ds.Tables[0].Rows[0][0].ToString();

            MessageBox.Show("Total registered employees: " + total, "Employee Count");
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            string sql = "select Id, Name,Password, Role from UserInfo where Role = 'employee';";
            this.PopulateGridView(sql);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtSearch.Text))
            {
                MessageBox.Show("Please enter an ID to search.");
                return;
            }
            string sql = "select Id, Name,Password, Role from UserInfo where Id = '" + this.txtSearch.Text + "' and Role = 'employee';";

            var ds = this.da.ExecuteQuery(sql);

            if (ds.Tables[0].Rows.Count > 0)
            {
                this.PopulateGridView(sql);
            }
            else
            {
                this.dgvEmployeeInfo.DataSource = null;
                MessageBox.Show("No employee found with this ID.");
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
        }
    }
}
