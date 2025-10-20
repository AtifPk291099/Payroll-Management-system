using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace WindowsFormsApp1
{
    public partial class ViewSalarySlip : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Payroll"].ConnectionString);

        public ViewSalarySlip()
        {
            InitializeComponent();
            string[] installs = new string[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            month.Text = "Choose Month";
            month.Items.AddRange(installs);
        }

        private void Year_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar != (char)8) && (!Char.IsDigit(e.KeyChar)))
            {
                MessageBox.Show("Digits expected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        private void Generate_Click(object sender, EventArgs e)
        {
            string empname = Employeelogin.UserID;
            string empmonth = month.Text.Trim();
            string empyear = year.Text.Trim();

            if (empmonth != "Choose Month" && empyear != "")
            {
                SqlCommand da = new SqlCommand("select s.*, e.name, d.dep_name from salary s inner join employee e on e.eid = s.eid inner join Department d on d.dep_id = e.depid  where s.eid = '" + empname + "' and s.month = '"+empmonth+"' and s.year = '"+empyear+"'", con);
                con.Open();
                SqlDataReader dr = da.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    panel1.Visible = true;
                    Print.Visible = true;
                    name.Text = dr["name"].ToString();
                    designation.Text = dr["designation"].ToString();
                    department.Text = dr["dep_name"].ToString();
                    time.Text = dr["month"].ToString() + "-" + dr["year"].ToString();
                    earn.Text = dr["earning"].ToString();
                    deduc.Text = dr["providentfund"].ToString();
                    salary.Text = dr["salary"].ToString();
                    eid.Text = dr["eid"].ToString();
                    depid.Text = dr["dep_id"].ToString();
                    ldeduc.Text = dr["leavededuction"].ToString();
                    mdeduc.Text = dr["latemarkdeduction"].ToString();
                    Empty.Visible = false;
                }
                else
                {
                    panel1.Visible = false;
                    Print.Visible = false;
                    Empty.Visible = true;
                }
                con.Close();
            }
            else
            {
                MessageBox.Show("Please Provide Details..!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Print_Click(object sender, EventArgs e)
        {
            this.Controls.Add(panel1);
            Graphics grp = panel1.CreateGraphics();
            Size formSize = this.ClientSize;
            bitmap = new Bitmap(formSize.Width, formSize.Height, grp);
            grp = Graphics.FromImage(bitmap);
            Point panelLocation = PointToScreen(panel1.Location);
            grp.CopyFromScreen(panelLocation.X, panelLocation.Y, 0, 0, formSize);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();
        }
        Bitmap bitmap;
        private void CaptureScreen()
        {
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            bitmap = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(bitmap);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);
        }

        private void PrintDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }

        private void Label19_Click(object sender, EventArgs e)
        {

        }
    }
}
