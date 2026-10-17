using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFALoginDbY
{
    public partial class HomeAdmin : Form
    {
        Login fl;
       
        public HomeAdmin(string name, Login fl) : this()
        {
            this.fl = fl;
        }
        public HomeAdmin()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.fl.Show();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Visible = true;
            this.Hide();
        }
    }
}
