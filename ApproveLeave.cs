using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class ApproveLeave : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Payroll"].ConnectionString);
        public ApproveLeave()
        {
            InitializeComponent();
            gridview();
        }

        private void LeaveGridview_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            status.Text = LeaveGridview.Rows[e.RowIndex].Cells[6].Value.ToString().ToUpper();
            id.Text = LeaveGridview.Rows[e.RowIndex].Cells[7].Value.ToString();
        }

        private void LeaveGridview_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            LeaveGridview.ClearSelection();
            foreach (DataGridViewBand band in LeaveGridview.Columns)
            {
                band.ReadOnly = true;
            }
            LeaveGridview.Columns[7].Visible = false;
        }

        private void Approve_Click(object sender, EventArgs e)
        {
            string empstatus = status.Text;
            string empid = id.Text;
            if(empstatus != "")
            {
                if (empstatus == "REQUESTED")
                {
                    SqlCommand cmd = new SqlCommand("update Leave set status = 'approve' where leave_id = '" + empid + "'", con);
                    con.Open();
                    int count = cmd.ExecuteNonQuery();
                    con.Close();
                    if (count > 0)
                    {
                        MessageBox.Show("Leave is approved..!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        gridview();
                    }
                    else
                    {
                        MessageBox.Show("Some Issues are Here..!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }
                else
                {
                    if (empstatus == "APPROVE")
                    {
                        MessageBox.Show("You have already approve this leave..!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (empstatus == "DECLINE")
                    {
                        MessageBox.Show("You have already Decline this leave..!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("Some Issues are Here..!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                cleardata();
            }
            else
            {
                MessageBox.Show("Please Select Record To Approve..!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Decline_Click(object sender, EventArgs e)
        {
            string empstatus = status.Text;
            string empid = id.Text;
            if (empstatus != "")
            {
                if (empstatus == "REQUESTED")
                {
                    SqlCommand cmd = new SqlCommand("update Leave set status = 'decline' where leave_id = '" + empid + "'", con);
                    con.Open();
                    int count = cmd.ExecuteNonQuery();
                    con.Close();
                    if (count > 0)
                    {
                        MessageBox.Show("Leave is declined..!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        gridview();
                    }
                    else
                    {
                        MessageBox.Show("Some Issues are Here..!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }
                else
                {
                    if (empstatus == "APPROVE")
                    {
                        MessageBox.Show("You have already approve this leave..!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (empstatus == "DECLINE")
                    {
                        MessageBox.Show("You have already Decline this leave..!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("Some Issues are Here..!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                cleardata();
            }
            else
            {
                MessageBox.Show("Please Select Record To Decline..!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void TextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            gridview();
        }

        private void gridview()
        {
            string searchData = textBox1.Text.Trim();
            string sql = "select l.*, e.name, e.designation from Leave l inner join Employee e on e.eid = l.eid ";
            if(searchData != "")
            {
                sql += "where e.name like '%"+ searchData + "%' ";
            }
            sql += "order by leave_id desc";
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("Employee Name");
                dt.Columns.Add("Designation");
                dt.Columns.Add("From Date");
                dt.Columns.Add("To Date");
                dt.Columns.Add("Reason");
                dt.Columns.Add("Total Days");
                dt.Columns.Add("Status");
                dt.Columns.Add("Leave id");
                while (dr.Read())
                {
                    DateTime date = Convert.ToDateTime(dr["from_date"].ToString());
                    string from = date.ToString("dd/MM/yyyy");
                    date = Convert.ToDateTime(dr["to_date"].ToString());
                    string to = date.ToString("dd/MM/yyyy");
                    dt.Rows.Add(dr["name"].ToString(), dr["designation"].ToString(), from, to, dr["reason"].ToString(), dr["leave_type"].ToString(), dr["status"].ToString().ToUpper(), dr["leave_id"].ToString());
                }
                LeaveGridview.DataSource = dt;
                data.Visible = true;
                Empty.Visible = false;
                search.Visible = true;
            }
            else
            {
                data.Visible = false;
                Empty.Visible = true;
                if (searchData != "")
                {
                    search.Visible = true;
                    Empty.Text = searchData + " did not apply for a leave..!!";
                }
                else
                {
                    search.Visible = false;
                    Empty.Text = "Nobody taken leaves..!!";
                }
            }
            con.Close();
        }

        private void cleardata()
        {
            status.Text = "";
            id.Text = "";
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Aplhabets expected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }
    }
}
