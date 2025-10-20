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
    public partial class ApplyLeaves : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Payroll"].ConnectionString);
        public ApplyLeaves()
        {
            InitializeComponent();
            fromDate.Format = DateTimePickerFormat.Short;
            fromDate.Value = DateTime.Today;
            fromDate.MinDate = DateTime.Today;
            todate.Value = DateTime.Today;
            todate.Format = DateTimePickerFormat.Short;
            todate.MinDate = DateTime.Today;
            gridview();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string FromDate = fromDate.Text;
            //string EndDate = todate.Text;
            string EndDate = "";
            string leavetype = "";
            if (half.Checked)
            {
                if(first.Checked)
                {
                    leavetype = "First Half";
                }
                else
                {
                    leavetype = "Second Half";
                }
                EndDate = fromDate.Text;
            }
            else if (full.Checked)
            {
                leavetype = "1";
                EndDate = fromDate.Text;
            }
            else if (multiple.Checked)
            {
                EndDate = todate.Text;
                TimeSpan tp = Convert.ToDateTime(EndDate) - Convert.ToDateTime(FromDate);
                double days = tp.TotalDays + 1;
                leavetype = days.ToString(); ;
                
            }
            string Reason = reason.Text;
            if(FromDate != "" && EndDate != "" && Reason != "")
            {
                if(Convert.ToDateTime(EndDate) >= Convert.ToDateTime(FromDate))
                {
                    SqlCommand cmd = new SqlCommand("LeaveApply", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter eid = cmd.Parameters.Add("@eid", SqlDbType.VarChar, 50);
                    eid.Value = Employeelogin.UserID;
                    SqlParameter fromdate = cmd.Parameters.Add("@fromdate", SqlDbType.DateTime, 50);
                    fromdate.Value = Convert.ToDateTime(FromDate);
                    SqlParameter enddate = cmd.Parameters.Add("@enddate", SqlDbType.DateTime, 50);
                    enddate.Value = Convert.ToDateTime(EndDate);
                    SqlParameter reason = cmd.Parameters.Add("@reason", SqlDbType.NVarChar, -1);
                    reason.Value = Reason;
                    SqlParameter leavetypes = cmd.Parameters.Add("@leavetype", SqlDbType.VarChar, 50);
                    leavetypes.Value = leavetype;
                    SqlParameter op = cmd.Parameters.Add("@op", SqlDbType.Int, 50);
                    op.Direction = ParameterDirection.Output;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    string data = op.Value.ToString();
                    if (data != "0")
                    {
                        MessageBox.Show("You have already apply leave for those days..!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        MessageBox.Show("Successfully Apply Leave  ..!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cleardata();
                        gridview();
                    }
                }
                else
                {
                    MessageBox.Show("Last Date should be greater then start Date..!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Kindly Provide Details..!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void gridview()
        {
            SqlCommand cmd = new SqlCommand("select * from Leave where eid = '" + Employeelogin.UserID + "' order by leave_id desc", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("From Date");
                dt.Columns.Add("To Date");
                dt.Columns.Add("Reason");
                dt.Columns.Add("Total Days");
                dt.Columns.Add("Status");
                while (dr.Read())
                {
                    DateTime date = Convert.ToDateTime(dr["from_date"].ToString());
                    string from = date.ToString("dd/MM/yyyy");
                    date = Convert.ToDateTime(dr["to_date"].ToString());
                    string to = date.ToString("dd/MM/yyyy");
                    dt.Rows.Add(from, to, dr["reason"].ToString(), dr["leave_type"].ToString(), dr["status"].ToString().ToUpper());
                }
                LeaveGridview.DataSource = dt;
                LeaveGridview.Visible = true;
            }
            else
            {
                LeaveGridview.Visible = false;
            }
            con.Close();
        }

        private void cleardata()
        {
            reason.Text = "";
        }

        private void LeaveGridview_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            LeaveGridview.ClearSelection();
            foreach (DataGridViewBand band in LeaveGridview.Columns)
            {
                band.ReadOnly = true;
            }
        }

        private void Half_CheckedChanged(object sender, EventArgs e)
        {
            toform.Visible = false;
            halftype.Visible = true;
        }

        private void Full_CheckedChanged(object sender, EventArgs e)
        {
            toform.Visible = false;
            halftype.Visible = false;
        }

        private void Multiple_CheckedChanged(object sender, EventArgs e)
        {
            toform.Visible = true;
            halftype.Visible = false;
        }
    }
}
