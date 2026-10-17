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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.lblError.Visible = false;
            DataAccess da = new DataAccess();

            string sql = "SELECT * FROM UserInfo WHERE Id = '" + this.txtUserId.Text.ToLower() + "' AND Password = '" + this.txtPassword.Text.ToLower() + "'";

            DataTable ds = da.ExecuteQueryTable(sql);

            if (ds.Rows.Count == 1)
            {
                if (ds.Rows[0][3].ToString() == "admin")
                {
                   
                    HomeAdmin home = new HomeAdmin(this.Text, this);
                    home.Visible = true;

                }
                else if (ds.Rows[0][3].ToString().Equals("employee"))
                {
                   
                    HomeEmployee hm = new HomeEmployee(this.Text ,this);
                    hm.Visible = true;
                }
                this.Hide();
                
            }
            else
            {
                this.lblError.Visible = true;
               
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUserId.Clear();
            txtPassword.Clear();
        }

        private void lblLogin_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
