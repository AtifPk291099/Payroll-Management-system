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
    public partial class Masterpage : Form
    {
        public Masterpage()
        {
            InitializeComponent();
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
            ManageDepartment dep = new ManageDepartment();
            dep.MdiParent = this;
            DisposeAllButThis(dep);
            dep.Show();
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            ManageEmployee emp = new ManageEmployee();
            emp.MdiParent = this;
            DisposeAllButThis(emp);
            emp.Show();
        }

        private void ContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            ApproveLeave ap = new ApproveLeave();
            ap.MdiParent = this;
            DisposeAllButThis(ap);
            ap.Show();
        }

        private void MnageSalaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            GenerateSalary ap = new GenerateSalary();
            ap.MdiParent = this;
            DisposeAllButThis(ap);
            ap.Show();
        }

        private void LogoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Home hm = new Home();
            this.Hide();
            hm.Show();
        }
    }
}
