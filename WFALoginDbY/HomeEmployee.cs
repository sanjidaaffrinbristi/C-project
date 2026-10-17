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
    public partial class HomeEmployee : Form
    {
        Login fl;
        public HomeEmployee(string name, Login fl) : this()
        {
            this.fl = fl;
        }
        public HomeEmployee()
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
            Billing em = new Billing();
            em.Visible = true;
            this.Hide();
        }
    }
}
