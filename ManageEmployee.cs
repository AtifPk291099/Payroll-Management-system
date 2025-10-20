using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ManageEmployee : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Payroll"].ConnectionString);
        public ManageEmployee()
        {
            InitializeComponent();
            SqlCommand das = new SqlCommand("select top 1 cast(eid as int) as id from Employee order by eid desc", con);
            con.Open();
            SqlDataReader dr = das.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();
                int id = Convert.ToInt32(dr["id"].ToString()) + 1;
                textBox3.Text = id.ToString();
            }
            else
            {
                textBox3.Text = "1";
            }
            con.Close();
            SqlDataAdapter da = new SqlDataAdapter("select * from Department", con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            int count = dt.Rows.Count;
            if(count> 0)
            {
                //Insert the Default Item to DataTable.
                DataRow row = dt.NewRow();
                row[0] = 0;
                row[1] = "Please select";
                dt.Rows.InsertAt(row, 0);
                department.DataSource = dt;
                department.DisplayMember = "dep_name";
                department.ValueMember = "dep_id";
                con.Close();
                gridview();
            }
            else
            {
                Empty.Visible = true;
                Empty.Text = "Kindly Add Department..!!";
                panel1.Visible = false;
            }
            
        }

        private void Contact_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar != (char)8) && (!Char.IsDigit(e.KeyChar)))
            {
                MessageBox.Show("Digits expected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        private void Salary_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar != (char)8) && (!Char.IsDigit(e.KeyChar)))
            {
                MessageBox.Show("Digits expected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            try
            {
                string empname = name.Text.Trim();
                string empcontact = contact.Text.Trim();
                string empemail = email.Text.Trim();
                string empgender = "";
                if (radioButton1.Checked)
                {
                    empgender = radioButton1.Text;
                }
                else if (radioButton2.Checked)
                {
                    empgender = radioButton2.Text;
                }
                string empaddress = address.Text.Trim();
                string emppassword = password.Text.Trim();
                string empsalary = salary.Text.Trim();
                string empdepartment = department.SelectedValue.ToString();
                string empdesignation = designation.Text.Trim();
                string empage = age.Text.Trim();
                string emppancard = pancard.Text.Trim();

                if (empname != "" && empcontact != "" && empemail != "" && empgender != "" && empaddress != "" && emppassword != "" && empsalary != "" && empdepartment != "0" && empdesignation != "" && empage != "" && emppancard != "")
                {
                    System.Text.RegularExpressions.Regex rEMail = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
                    if (!rEMail.IsMatch(empemail))
                    {
                        MessageBox.Show("E-Mail expected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        email.SelectAll();
                    }
                    else
                    {
                        Regex validator = new Regex("(3|4|5|6|7|8|9){1}[0-9]{9}");
                        string match = validator.Match(empcontact).Value.ToString();
                        if (match.Length != 10)
                        {
                            MessageBox.Show("10 digits are expected..!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            SqlCommand cmd = new SqlCommand("EmployeeDb", con);
                            cmd.CommandType = CommandType.StoredProcedure;
                            SqlParameter name = cmd.Parameters.Add("@name", SqlDbType.VarChar, 50);
                            name.Value = empname;
                            SqlParameter contact = cmd.Parameters.Add("@contact", SqlDbType.VarChar, 50);
                            contact.Value = empcontact;
                            SqlParameter email = cmd.Parameters.Add("@email", SqlDbType.VarChar, 50);
                            email.Value = empemail.ToUpper();
                            SqlParameter gender = cmd.Parameters.Add("@gender", SqlDbType.VarChar, 50);
                            gender.Value = empgender;
                            SqlParameter address = cmd.Parameters.Add("@address", SqlDbType.VarChar, 50);
                            address.Value = empaddress;
                            SqlParameter password = cmd.Parameters.Add("@password", SqlDbType.VarChar, 50);
                            password.Value = emppassword;
                            SqlParameter salary = cmd.Parameters.Add("@salary", SqlDbType.VarChar, 50);
                            salary.Value = empsalary;
                            SqlParameter designation = cmd.Parameters.Add("@designation", SqlDbType.VarChar, 50);
                            designation.Value = empdesignation;
                            SqlParameter department = cmd.Parameters.Add("@department", SqlDbType.VarChar, 50);
                            department.Value = empdepartment;
                            SqlParameter querytype = cmd.Parameters.Add("@querytype", SqlDbType.Int, 50);
                            querytype.Value = 0;
                            SqlParameter age = cmd.Parameters.Add("@age", SqlDbType.VarChar, 50);
                            age.Value = empage;
                            SqlParameter pancard = cmd.Parameters.Add("@pancard", SqlDbType.VarChar, 50);
                            pancard.Value = emppancard;
                            SqlParameter op = cmd.Parameters.Add("@op", SqlDbType.Int, 50);
                            op.Direction = ParameterDirection.Output;
                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();
                            string data = op.Value.ToString();
                            if (data != "0")
                            {
                                MessageBox.Show("This Employee is Already exist..!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                            else
                            {
                                MessageBox.Show("Successfully Added  ..!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                cleardata();
                                gridview();
                            }
                        }

                    }
                }
                else
                {
                    MessageBox.Show("Please Provide Details..!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            
        }

        private void EmployeeData_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            name.Text = EmployeeData.Rows[e.RowIndex].Cells[1].Value.ToString();
            email.Text = EmployeeData.Rows[e.RowIndex].Cells[2].Value.ToString();
            contact.Text = EmployeeData.Rows[e.RowIndex].Cells[3].Value.ToString();
            address.Text = EmployeeData.Rows[e.RowIndex].Cells[5].Value.ToString();
            department.Text = EmployeeData.Rows[e.RowIndex].Cells[6].Value.ToString();
            salary.Text = EmployeeData.Rows[e.RowIndex].Cells[7].Value.ToString();
            designation.Text = EmployeeData.Rows[e.RowIndex].Cells[8].Value.ToString();
            age.Text = EmployeeData.Rows[e.RowIndex].Cells[9].Value.ToString();
            pancard.Text = EmployeeData.Rows[e.RowIndex].Cells[10].Value.ToString();
            id.Text = EmployeeData.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox3.Text = EmployeeData.Rows[e.RowIndex].Cells[0].Value.ToString();

            string gender = EmployeeData.Rows[e.RowIndex].Cells[4].Value.ToString();
            if(radioButton1.Text == gender)
            {
                radioButton1.Checked = true;
            }
            else if (radioButton2.Text == gender)
            {
                radioButton2.Checked = true;
            }
            password.Visible = false;
            label8.Visible = false;
            name.Focus();
        }

        private void EmployeeData_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            EmployeeData.ClearSelection();
            foreach (DataGridViewBand band in EmployeeData.Columns)
            {
                band.ReadOnly = true;
            }
            EmployeeData.Columns[8].Visible = false;
        }

        private void Button2_Click(object sender, EventArgs e)
        {

            try
            {
                string empname = name.Text.Trim();
                string empcontact = contact.Text.Trim();
                string empemail = email.Text.Trim();
                string empgender = "";
                if (radioButton1.Checked)
                {
                    empgender = radioButton1.Text;
                }
                else if (radioButton2.Checked)
                {
                    empgender = radioButton2.Text;
                }
                string empaddress = address.Text.Trim();
                string empsalary = salary.Text.Trim();
                string empdepartment = department.SelectedValue.ToString();
                string empdesignation = designation.Text.Trim();
                string empage = age.Text.Trim();
                string emppancard = pancard.Text.Trim();

                if (empname != "" && empcontact != "" && empemail != "" && empgender != "" && empaddress != "" && empsalary != "" && empdepartment != "0" && empdesignation != "" && empage != "" && emppancard != "")
                {
                    System.Text.RegularExpressions.Regex rEMail = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
                    if (!rEMail.IsMatch(empemail))
                    {
                        MessageBox.Show("E-Mail expected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        email.SelectAll();
                    }
                    else
                    {
                        SqlCommand cmd = new SqlCommand("EmployeeDb", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        SqlParameter name = cmd.Parameters.Add("@name", SqlDbType.VarChar, 50);
                        name.Value = empname;
                        SqlParameter contact = cmd.Parameters.Add("@contact", SqlDbType.VarChar, 50);
                        contact.Value = empcontact;
                        SqlParameter email = cmd.Parameters.Add("@email", SqlDbType.VarChar, 50);
                        email.Value = empemail.ToUpper();
                        SqlParameter gender = cmd.Parameters.Add("@gender", SqlDbType.VarChar, 50);
                        gender.Value = empgender;
                        SqlParameter address = cmd.Parameters.Add("@address", SqlDbType.VarChar, 50);
                        address.Value = empaddress;
                        SqlParameter password = cmd.Parameters.Add("@password", SqlDbType.VarChar, 50);
                        password.Value = "0";
                        SqlParameter salary = cmd.Parameters.Add("@salary", SqlDbType.VarChar, 50);
                        salary.Value = empsalary;
                        SqlParameter designation = cmd.Parameters.Add("@designation", SqlDbType.VarChar, 50);
                        designation.Value = empdesignation;
                        SqlParameter department = cmd.Parameters.Add("@department", SqlDbType.VarChar, 50);
                        department.Value = empdepartment;
                        SqlParameter querytype = cmd.Parameters.Add("@querytype", SqlDbType.Int, 50);
                        querytype.Value = id.Text;
                        SqlParameter age = cmd.Parameters.Add("@age", SqlDbType.VarChar, 50);
                        age.Value = empage;
                        SqlParameter pancard = cmd.Parameters.Add("@pancard", SqlDbType.VarChar, 50);
                        pancard.Value = emppancard;
                        SqlParameter op = cmd.Parameters.Add("@op", SqlDbType.Int, 50);
                        op.Direction = ParameterDirection.Output;
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        string data = op.Value.ToString();
                        if (data != "0")
                        {
                            MessageBox.Show("This Employee is Already exist..!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            MessageBox.Show("Successfully Updated  ..!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            cleardata();
                            gridview();
                        }
                        cleardata();
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

        private void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                string empname = name.Text.Trim();
                string empcontact = contact.Text.Trim();
                string empemail = email.Text.Trim();
                string empgender = "";
                if (radioButton1.Checked)
                {
                    empgender = radioButton1.Text;
                }
                else if (radioButton2.Checked)
                {
                    empgender = radioButton2.Text;
                }
                string empaddress = address.Text.Trim();
                string empsalary = salary.Text.Trim();
                string empdepartment = department.SelectedValue.ToString();
                string empdesignation = designation.Text.Trim();
                string empage = age.Text.Trim();
                string emppancard = pancard.Text.Trim();

                if (empname != "" && empcontact != "" && empemail != "" && empgender != "" && empaddress != "" && empsalary != "" && empdepartment != "0" && empdesignation != "" && empage != "" && emppancard != "")
                {
                    SqlCommand cmd = new SqlCommand("delete from Employee where email = '" + empemail.ToUpper() + "'", con);
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
                    MessageBox.Show("Please Select Record To Delete..!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        private void gridview()
        {
            SqlCommand das = new SqlCommand("select top 1 cast(eid as int) as id from Employee order by eid desc", con);
            con.Open();
            SqlDataReader drs = das.ExecuteReader();
            if (drs.HasRows)
            {
                drs.Read();
                int id = Convert.ToInt32(drs["id"].ToString()) + 1;
                textBox3.Text = id.ToString();
            }
            else
            {
                textBox3.Text = "1";
            }
            con.Close();
            string searchData = textBox1.Text;
            string sid = textBox2.Text;
            string sel = "select e.eid, e.name, e.contact, e.email, e.gender, e.address, d.dep_name, e.salary, e.designation, e.age, e.pancard from Employee e inner join Department d on d.dep_id  = e.depid where e.depid != '' ";
            if(searchData != "")
            {
                sel += "and e.name like '%"+ searchData + "%' ";
            }
            if(sid != "")
            {
                sel += "and e.eid like '%"+sid+"%' ";
            }
            sel += "order by e.eid desc";
            SqlCommand cmd = new SqlCommand(sel, con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("id");
                dt.Columns.Add("Name");
                dt.Columns.Add("Email Id");
                dt.Columns.Add("Contact");
                dt.Columns.Add("Gender");
                dt.Columns.Add("Address");
                dt.Columns.Add("Department");
                dt.Columns.Add("Salary");
                dt.Columns.Add("Designation");
                dt.Columns.Add("Age");
                dt.Columns.Add("Pan Card No");

                while (dr.Read())
                {
                    dt.Rows.Add(dr["eid"].ToString(), dr["name"].ToString(), dr["email"].ToString().ToLower(), dr["contact"].ToString(), dr["gender"].ToString(), dr["address"].ToString(), dr["dep_name"].ToString(), dr["salary"].ToString(), dr["designation"].ToString(), dr["age"].ToString(), dr["pancard"].ToString());
                }
                EmployeeData.DataSource = dt;
                EmployeeData.Visible = true;
                Empty.Visible = false;
                search.Visible = true;
            }
            else
            {
                EmployeeData.Visible = false;
                Empty.Visible = true;
                if (searchData != "")
                {
                    search.Visible = true;
                    Empty.Text = "No such Employee is Registered..!!";
                }
                else
                {
                    search.Visible = false;
                    Empty.Text = "Employee List is Empty..!!";
                }
            }
            con.Close();

        }

        private void cleardata()
        {
            name.Text = "";
            contact.Text = "";
            email.Text = "";
            address.Text = "";
            password.Text = "";
            salary.Text = "";
            department.Text = "Please select";
            designation.Text = "";
            id.Text = "";
        }
        private void Department_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            gridview();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            cleardata();
            gridview();
            password.Visible = true;
            label8.Visible = true;
        }

        private void name_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Aplhabets expected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        private void contact_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {
            gridview();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar != (char)8) && (!Char.IsDigit(e.KeyChar)))
            {
                MessageBox.Show("Digits expected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        private void Id(object sender, EventArgs e)
        {

        }

        private void age_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar != (char)8) && (!Char.IsDigit(e.KeyChar)))
            {
                MessageBox.Show("Digits expected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        private void pancard_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar != (char)8) && (!Char.IsDigit(e.KeyChar)) && (!Char.IsLetter(e.KeyChar)))
            {
                //MessageBox.Show("Only alphabets and digits are expected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }
    }
}
