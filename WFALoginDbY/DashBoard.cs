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
    public partial class DashBoard : Form
    {
        Admin AD;
        
        public DashBoard(string name, Admin AD) : this()
        {
            this.AD = AD;
        }
        public DataAccess da { get; set; }
        public DashBoard()
        {
            InitializeComponent();
            this.da = new DataAccess();
        }
        private void PopulateGridView(string sql = "select * from UserInfo;")
        {
            var ds = this.da.ExecuteQuery(sql);
            this.dgvDashBoard.DataSource = ds.Tables[0];
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUserId.Clear();
            txtOldPass.Clear();
            txtNewPass.Clear();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.AD.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "select * from UserInfo where Id = '" + this.txtUserId.Text + "' and Password = '" + this.txtOldPass.Text + "';";
                var ds = this.da.ExecuteQuery(query);

                if (ds.Tables[0].Rows.Count == 1)
                {
                    string sql = "update UserInfo set Password = '" + this.txtNewPass.Text + "' where Id = '" + this.txtUserId.Text + "';";
                    int count = this.da.ExecuteDMLQuery(sql);

                    if (count == 1)
                    {
                        MessageBox.Show("Password updated successfully!");
                        this.txtOldPass.Clear();
                        this.txtNewPass.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Password update failed!");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid User ID or Old Password. Please try again.");
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
            dgvDashBoard.ClearSelection();
        }

        private void dgvDashBoard_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.dgvDashBoard.ClearSelection();
            this.dgvDashBoard.CurrentCell = null;
        }
    }
}
