using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class GenerateSalary : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Payroll"].ConnectionString);
        public GenerateSalary()
        {
            InitializeComponent();
            SqlDataAdapter da = new SqlDataAdapter("select eid, name from Employee", con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            int count = dt.Rows.Count;
            if (count > 0)
            {
                //Insert the Default Item to DataTable.
                DataRow row = dt.NewRow();
                row[0] = 0;
                row[1] = "Please select";
                dt.Rows.InsertAt(row, 0);
                ename.DataSource = dt;
                ename.DisplayMember = "name";
                ename.ValueMember = "eid";
                con.Close();
            }
            else
            {
                //Empty.Visible = true;
                //Empty.Text = "Kindly Add Department..!!";
                //panel1.Visible = false;
            }
            string[] installs = new string[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"};
            month.Text = "Choose Month";
            month.Items.AddRange(installs);
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar != (char)8) && (!Char.IsDigit(e.KeyChar)))
            {
                MessageBox.Show("Digits expected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        private void Generate_Click(object sender, EventArgs e)
        {
            string empname = ename.Text;
            string empmonth = month.Text.Trim();
            string empyear = year.Text.Trim();
            string empearning = earnings.Text.Trim();
            string providentfund = deductions.Text.Trim();
            string leavededuc = leavededuction.Text.Trim();
            string latededuc = latededuction.Text.Trim();

            if(empname != "Please select" && empmonth != "" && empyear != "" && empearning != "" && providentfund != "" && leavededuc != "" && latededuc != "")
            {
                SqlDataAdapter cmd = new SqlDataAdapter("select s.*, e.name from salary s inner join employee e on e.eid = s.eid where name = '"+empname+"' and month = '"+empmonth+"' and year = '"+empyear+"'", con);
                DataSet drr = new DataSet();
                cmd.Fill(drr);
                int count = drr.Tables[0].Rows.Count;
                if (count > 0)
                {
                    MessageBox.Show("You have already generated salary slip for this userof this year-month..!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    int net = Convert.ToInt32(empearning) - (Convert.ToInt32(providentfund) + Convert.ToInt32(leavededuc) + Convert.ToInt32(latededuc));
                    SqlCommand da = new SqlCommand("select e.eid, e.name, e.contact, e.email, e.gender, e.address, d.dep_name, e.salary, e.designation, e.depid from Employee e inner join Department d on d.dep_id  = e.depid where name = '" + empname + "'", con);
                    con.Open();
                    SqlDataReader dr = da.ExecuteReader();
                    if (dr.HasRows)
                    {
                        dr.Read();
                        panel1.Visible = true;
                        name.Text = dr["name"].ToString();
                        designation.Text = dr["designation"].ToString();
                        department.Text = dr["dep_name"].ToString();
                        time.Text = empmonth + "-" + empyear;
                        earn.Text = empearning;
                        deduc.Text = providentfund;
                        ldeduc.Text = leavededuc;
                        mdeduc.Text = latededuc;
                        salary.Text = net.ToString();
                        eid.Text = dr["eid"].ToString();
                        depid.Text = dr["depid"].ToString();
                    }
                    else
                    {
                        panel1.Visible = false;
                    }
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("Please Provide Details..!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string[] period = time.Text.Split('-');
            SqlCommand cmd = new SqlCommand("insert into salary (dep_id, eid, month, year, earning, providentfund, salary, designation, leavededuction, latemarkdeduction) values ('" + depid.Text + "', '" + eid.Text + "', '" + period[0] + "', '" + period[1] + "', '"+earn.Text+"', '"+deduc.Text+"', '" + salary.Text + "', '" + designation.Text + "', '"+ldeduc.Text+ "', '" + mdeduc.Text + "')", con);
            con.Open();
            int count = cmd.ExecuteNonQuery();
            con.Close();
            if (count > 0)
            {
                MessageBox.Show("Generated Slip..!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cleardata();
            }
            else
            {
                MessageBox.Show("Some Issues are Here..!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Earnings_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar != (char)8) && (!Char.IsDigit(e.KeyChar)))
            {
                MessageBox.Show("Digits expected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        private void Deductions_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar != (char)8) && (!Char.IsDigit(e.KeyChar)))
            {
                MessageBox.Show("Digits expected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        private void cleardata()
        {
            ename.Text = "Please select";
            month.Text = "Choose Month";
            year.Text = "";
            earnings.Text = "";
            deductions.Text = "";
            panel1.Visible = false;
        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void Name_Click(object sender, EventArgs e)
        {

        }

        private void Label9_Click(object sender, EventArgs e)
        {

        }

        private void Label10_Click(object sender, EventArgs e)
        {

        }

        private void Label11_Click(object sender, EventArgs e)
        {

        }

        private void Label12_Click(object sender, EventArgs e)
        {

        }

        private void Label13_Click(object sender, EventArgs e)
        {

        }

        private void Designation_Click(object sender, EventArgs e)
        {

        }

        private void Department_Click(object sender, EventArgs e)
        {

        }

        private void Time_Click(object sender, EventArgs e)
        {

        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Salary_Click(object sender, EventArgs e)
        {

        }

        private void Earn_Click(object sender, EventArgs e)
        {

        }

        private void Deduc_Click(object sender, EventArgs e)
        {

        }

        private void Eid_Click(object sender, EventArgs e)
        {

        }

        private void Depid_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Ename_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Month_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Year_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label14_Click(object sender, EventArgs e)
        {

        }

        private void Earnings_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label15_Click(object sender, EventArgs e)
        {

        }

        private void Deductions_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label17_Click(object sender, EventArgs e)
        {

        }

        private void Leavededuction_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar != (char)8) && (!Char.IsDigit(e.KeyChar)))
            {
                MessageBox.Show("Digits expected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        private void Latededuction_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar != (char)8) && (!Char.IsDigit(e.KeyChar)))
            {
                MessageBox.Show("Digits expected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        private void year_KeyUp(object sender, KeyEventArgs e)
        {

        }
    }
}
