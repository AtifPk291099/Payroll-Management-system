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
    public partial class EmployeeMaster : Form
    {
        public EmployeeMaster()
        {
            InitializeComponent();
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            ViewSalarySlip vs = new ViewSalarySlip();
            vs.MdiParent = this;
            DisposeAllButThis(vs);
            vs.Show();
        }

        private void ContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Home hm = new Home();
            this.Hide();
            hm.Show();
        }
        public void DisposeAllButThis(Form form)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm != form)
                {
                    frm.Close();
                }
            }
            return;
        }

        private void HomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            ApplyLeaves emp = new ApplyLeaves();
            emp.MdiParent = this;
            DisposeAllButThis(emp);
            emp.Show();
        }
    }
}
