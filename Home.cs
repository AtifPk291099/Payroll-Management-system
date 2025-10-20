using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Adminlogin fo = new Adminlogin();
            fo.Show();
            Visible = false;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Employeelogin fo1 = new Employeelogin();
            fo1.Show();
            Visible = false;
        }
    }
}
