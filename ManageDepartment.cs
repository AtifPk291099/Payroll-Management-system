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
    public partial class ManageDepartment : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Payroll"].ConnectionString);
        public ManageDepartment()
        {
            InitializeComponent();
            gridview();
        }
        
        private void Button4_Click(object sender, EventArgs e)
        {
            try
            {
                string depname = name.Text.Trim();
                if (depname != "")
                {
                    SqlCommand cmd = new SqlCommand("DepartmentDb", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter name = cmd.Parameters.Add("@name", SqlDbType.VarChar, 50);
                    name.Value = depname.ToUpper();
                    SqlParameter querytype = cmd.Parameters.Add("@querytype", SqlDbType.Int, 50);
                    querytype.Value = 0;
                    SqlParameter op = cmd.Parameters.Add("@op", SqlDbType.Int, 50);
                    op.Direction = ParameterDirection.Output;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    string data = op.Value.ToString();
                    if (data != "0")
                    {
                        MessageBox.Show("This Name is Already exist..!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        MessageBox.Show("Successfully Added  ..!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cleardata();
                        gridview();
                    }
                }
                else
                {
                    MessageBox.Show("Please Provide Details..!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch(Exception ex)
            {
                throw (ex);
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            try
            {
                string depname = name.Text.Trim();
                string depid = id.Text.Trim();
                if (depname != "" && depid != "")
                {
                    SqlCommand cmd = new SqlCommand("DepartmentDb", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter name = cmd.Parameters.Add("@name", SqlDbType.VarChar, 50);
                    name.Value = depname.ToUpper();
                    SqlParameter querytype = cmd.Parameters.Add("@querytype", SqlDbType.Int, 50);
                    querytype.Value = depid;
                    SqlParameter op = cmd.Parameters.Add("@op", SqlDbType.Int, 50);
                    op.Direction = ParameterDirection.Output;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    string data = op.Value.ToString();
                    if (data != "0")
                    {
                        MessageBox.Show("This Name is Already exist..!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        MessageBox.Show("Successfully Updated  ..!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cleardata();
                        gridview();
                    }
                    cleardata();
                }
                else
                {
                    MessageBox.Show("Please Select Record To Update..!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                string depname = name.Text.Trim();
                string depid = id.Text.Trim();
                if (depname != "" && depid != "")
                {
                    SqlCommand cmd = new SqlCommand("delete from Department where dep_id = '" + depid + "'", con);
                    con.Open();
                    int count = cmd.ExecuteNonQuery();
                    con.Close();
                    if (count > 0)
                    {
                        MessageBox.Show("Successfully Delete Data..!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        gridview();
                    }
                    else
                    {
                        MessageBox.Show("Some Issues are Here..!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    cleardata();
                }
                else
                {
                    MessageBox.Show("Please Select Record To Delete..!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        private void gridview()
        {
            string searchData = textBox1.Text;
            string sel = "select * from Department ";
            if (searchData != "")
            {
                sel += "where dep_name like '%" + searchData + "%' ";
            }
            sel += "order by dep_id desc";
            SqlCommand cmd = new SqlCommand(sel, con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("Department Name");
                dt.Columns.Add("id");
                while (dr.Read())
                {
                    string depname = dr["dep_name"].ToString();
                    string id = dr["dep_id"].ToString();
                    dt.Rows.Add(depname, id);
                }
                DepartmentData.DataSource = dt;
                DepartmentData.Visible = true;
                Empty.Visible = false;
                search.Visible = true;
            }
            else
            {
                DepartmentData.Visible = false;
                Empty.Visible = true;
                if (searchData != "")
                {
                    search.Visible = true;
                    Empty.Text = "No such Department is Added..!!";
                }
                else
                {
                    search.Visible = false;
                    Empty.Text = "Department List is Empty..!!";
                }
            }
            con.Close();
        }

        private void cleardata()
        {
            name.Text = "";
            id.Text = "";
        }

        private void DepartmentData_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            name.Text = DepartmentData.Rows[e.RowIndex].Cells[0].Value.ToString();
            name.Focus();
            id.Text = DepartmentData.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void DepartmentData_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DepartmentData.ClearSelection();
            foreach (DataGridViewBand band in DepartmentData.Columns)
            {
                band.ReadOnly = true;
            }
            DepartmentData.Columns[1].Visible = false;
        }

        private void TextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            gridview();
        }
    }
}
