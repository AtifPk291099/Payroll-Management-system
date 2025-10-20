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
    

    public partial class Employeelogin : Form
    {
        public static string UserID;

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Payroll"].ConnectionString);
        public Employeelogin()
        {
            InitializeComponent();
            this.BackColor = Color.LimeGreen;
            this.TransparencyKey = Color.LimeGreen;
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Home obj = new Home();
            obj.Show();
            this.Hide();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                string id = textBox1.Text.Trim();
                string password = textBox2.Text.Trim();
                if (id != "" && password != "")
                {
                    SqlCommand cmd = new SqlCommand("select * from employee where email = '" + id.ToUpper() + "' and password = '" + password + "'", con);
                    con.Open();
                    SqlDataReader sr = cmd.ExecuteReader();
                    if (sr.HasRows)
                    {
                        sr.Read();
                        UserID = sr["eid"].ToString();
                        EmployeeMaster obj = new EmployeeMaster();
                        obj.Show();
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("You are not Authorized..!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Kindly enter details..!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        
    }
}
