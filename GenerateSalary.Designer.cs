namespace WindowsFormsApp1
{
    partial class GenerateSalary
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GenerateSalary));
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ename = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.month = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.generate = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ldeduc = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.earn = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.deduc = new System.Windows.Forms.Label();
            this.mdeduc = new System.Windows.Forms.Label();
            this.salary = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.depid = new System.Windows.Forms.Label();
            this.eid = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.time = new System.Windows.Forms.Label();
            this.department = new System.Windows.Forms.Label();
            this.designation = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.year = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.earnings = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.deductions = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.latededuction = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.leavededuction = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 30);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(298, 32);
            this.label4.TabIndex = 9;
            this.label4.Text = "Generate Salary Slip";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(41, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1823, 2);
            this.label1.TabIndex = 10;
            this.label1.UseCompatibleTextRendering = true;
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Employee Name:";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // ename
            // 
            this.ename.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ename.FormattingEnabled = true;
            this.ename.Location = new System.Drawing.Point(238, 25);
            this.ename.Name = "ename";
            this.ename.Size = new System.Drawing.Size(206, 33);
            this.ename.TabIndex = 0;
            this.ename.SelectedIndexChanged += new System.EventHandler(this.Ename_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Choose Month:";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // month
            // 
            this.month.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.month.FormattingEnabled = true;
            this.month.Location = new System.Drawing.Point(238, 90);
            this.month.Name = "month";
            this.month.Size = new System.Drawing.Size(206, 33);
            this.month.TabIndex = 1;
            this.month.SelectedIndexChanged += new System.EventHandler(this.Month_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 25);
            this.label5.TabIndex = 16;
            this.label5.Text = " Year:";
            this.label5.Click += new System.EventHandler(this.Label5_Click);
            // 
            // generate
            // 
            this.generate.BackColor = System.Drawing.SystemColors.Highlight;
            this.generate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.generate.Location = new System.Drawing.Point(170, 491);
            this.generate.Name = "generate";
            this.generate.Size = new System.Drawing.Size(156, 50);
            this.generate.TabIndex = 5;
            this.generate.Text = "Apply";
            this.generate.UseVisualStyleBackColor = false;
            this.generate.Click += new System.EventHandler(this.Generate_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.depid);
            this.panel1.Controls.Add(this.eid);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.time);
            this.panel1.Controls.Add(this.department);
            this.panel1.Controls.Add(this.designation);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.name);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(780, 139);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(936, 808);
            this.panel1.TabIndex = 18;
            this.panel1.Visible = false;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.ldeduc, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label22, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label12, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.earn, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label13, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.deduc, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.mdeduc, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.salary, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.label8, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.label23, 2, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(37, 336);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(840, 204);
            this.tableLayoutPanel1.TabIndex = 35;
            // 
            // ldeduc
            // 
            this.ldeduc.AutoSize = true;
            this.ldeduc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ldeduc.Location = new System.Drawing.Point(630, 54);
            this.ldeduc.Name = "ldeduc";
            this.ldeduc.Size = new System.Drawing.Size(22, 25);
            this.ldeduc.TabIndex = 36;
            this.ldeduc.Text = "s";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(423, 54);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(181, 25);
            this.label22.TabIndex = 36;
            this.label22.Text = "Leave Deduction:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(9, 6);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(104, 25);
            this.label12.TabIndex = 18;
            this.label12.Text = "Earnings:";
            this.label12.Click += new System.EventHandler(this.Label12_Click);
            // 
            // earn
            // 
            this.earn.AutoSize = true;
            this.earn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.earn.Location = new System.Drawing.Point(216, 6);
            this.earn.Name = "earn";
            this.earn.Size = new System.Drawing.Size(22, 25);
            this.earn.TabIndex = 27;
            this.earn.Text = "s";
            this.earn.Click += new System.EventHandler(this.Earn_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(423, 6);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(165, 25);
            this.label13.TabIndex = 19;
            this.label13.Text = "Provident Fund:";
            this.label13.Click += new System.EventHandler(this.Label13_Click);
            // 
            // deduc
            // 
            this.deduc.AutoSize = true;
            this.deduc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deduc.Location = new System.Drawing.Point(630, 6);
            this.deduc.Name = "deduc";
            this.deduc.Size = new System.Drawing.Size(22, 25);
            this.deduc.TabIndex = 28;
            this.deduc.Text = "s";
            this.deduc.Click += new System.EventHandler(this.Deduc_Click);
            // 
            // mdeduc
            // 
            this.mdeduc.AutoSize = true;
            this.mdeduc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mdeduc.Location = new System.Drawing.Point(630, 102);
            this.mdeduc.Name = "mdeduc";
            this.mdeduc.Size = new System.Drawing.Size(22, 25);
            this.mdeduc.TabIndex = 37;
            this.mdeduc.Text = "s";
            // 
            // salary
            // 
            this.salary.AutoSize = true;
            this.salary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salary.Location = new System.Drawing.Point(630, 150);
            this.salary.Name = "salary";
            this.salary.Size = new System.Drawing.Size(22, 25);
            this.salary.TabIndex = 26;
            this.salary.Text = "s";
            this.salary.Click += new System.EventHandler(this.Salary_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(423, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 25);
            this.label8.TabIndex = 25;
            this.label8.Text = "Net Salary:";
            this.label8.Click += new System.EventHandler(this.Label8_Click);
            // 
            // label23
            // 
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(423, 102);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(176, 47);
            this.label23.TabIndex = 37;
            this.label23.Text = "Income Tax Deduction:";
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label19.Location = new System.Drawing.Point(662, 654);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(158, 2);
            this.label19.TabIndex = 34;
            this.label19.UseCompatibleTextRendering = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(424, 134);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(86, 17);
            this.label18.TabIndex = 33;
            this.label18.Text = "Salary Slip";
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(689, 669);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(142, 55);
            this.label17.TabIndex = 32;
            this.label17.Text = "Signature and Stamp";
            this.label17.Click += new System.EventHandler(this.Label17_Click);
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(54, 59);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(854, 58);
            this.label16.TabIndex = 31;
            this.label16.Text = "Bandra (west) Mumbai -400050 Maharashtra";
            // 
            // depid
            // 
            this.depid.AutoSize = true;
            this.depid.Location = new System.Drawing.Point(108, 114);
            this.depid.Name = "depid";
            this.depid.Size = new System.Drawing.Size(54, 17);
            this.depid.TabIndex = 30;
            this.depid.Text = "label17";
            this.depid.Visible = false;
            this.depid.Click += new System.EventHandler(this.Depid_Click);
            // 
            // eid
            // 
            this.eid.AutoSize = true;
            this.eid.Location = new System.Drawing.Point(34, 114);
            this.eid.Name = "eid";
            this.eid.Size = new System.Drawing.Size(54, 17);
            this.eid.TabIndex = 29;
            this.eid.Text = "label16";
            this.eid.Visible = false;
            this.eid.Click += new System.EventHandler(this.Eid_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.ForestGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(369, 746);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(211, 47);
            this.button1.TabIndex = 6;
            this.button1.Text = "Generate Slip";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.Location = new System.Drawing.Point(229, 296);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(22, 25);
            this.time.TabIndex = 22;
            this.time.Text = "s";
            this.time.Click += new System.EventHandler(this.Time_Click);
            // 
            // department
            // 
            this.department.AutoSize = true;
            this.department.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.department.Location = new System.Drawing.Point(699, 253);
            this.department.Name = "department";
            this.department.Size = new System.Drawing.Size(22, 25);
            this.department.TabIndex = 21;
            this.department.Text = "s";
            this.department.Click += new System.EventHandler(this.Department_Click);
            // 
            // designation
            // 
            this.designation.AutoSize = true;
            this.designation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.designation.Location = new System.Drawing.Point(229, 254);
            this.designation.Name = "designation";
            this.designation.Size = new System.Drawing.Size(22, 25);
            this.designation.TabIndex = 20;
            this.designation.Text = "s";
            this.designation.Click += new System.EventHandler(this.Designation_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(33, 295);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(172, 25);
            this.label11.TabIndex = 17;
            this.label11.Text = "Month and Year:";
            this.label11.Click += new System.EventHandler(this.Label11_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(528, 253);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 25);
            this.label10.TabIndex = 16;
            this.label10.Text = "Department:";
            this.label10.Click += new System.EventHandler(this.Label10_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(33, 254);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 25);
            this.label9.TabIndex = 15;
            this.label9.Text = "Designation:";
            this.label9.Click += new System.EventHandler(this.Label9_Click);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(491, 176);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(22, 25);
            this.name.TabIndex = 14;
            this.name.Text = "s";
            this.name.Click += new System.EventHandler(this.Name_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(303, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(176, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "Employee Name:";
            this.label7.Click += new System.EventHandler(this.Label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(377, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(212, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "KHAN PVT LIMITED";
            this.label6.Click += new System.EventHandler(this.Label6_Click);
            // 
            // year
            // 
            this.year.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.year.Location = new System.Drawing.Point(240, 154);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(204, 30);
            this.year.TabIndex = 2;
            this.year.TextChanged += new System.EventHandler(this.Year_TextChanged);
            this.year.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox1_KeyPress);
            this.year.KeyUp += new System.Windows.Forms.KeyEventHandler(this.year_KeyUp);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(24, 217);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(104, 25);
            this.label14.TabIndex = 20;
            this.label14.Text = "Earnings:";
            this.label14.Click += new System.EventHandler(this.Label14_Click);
            // 
            // earnings
            // 
            this.earnings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.earnings.Location = new System.Drawing.Point(240, 217);
            this.earnings.Name = "earnings";
            this.earnings.Size = new System.Drawing.Size(204, 30);
            this.earnings.TabIndex = 3;
            this.earnings.TextChanged += new System.EventHandler(this.Earnings_TextChanged);
            this.earnings.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Earnings_KeyPress_1);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(24, 274);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(158, 25);
            this.label15.TabIndex = 29;
            this.label15.Text = "Provident Fund";
            this.label15.Click += new System.EventHandler(this.Label15_Click);
            // 
            // deductions
            // 
            this.deductions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deductions.Location = new System.Drawing.Point(238, 274);
            this.deductions.Name = "deductions";
            this.deductions.Size = new System.Drawing.Size(204, 30);
            this.deductions.TabIndex = 4;
            this.deductions.TextChanged += new System.EventHandler(this.Deductions_TextChanged);
            this.deductions.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Deductions_KeyPress_1);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.latededuction);
            this.panel2.Controls.Add(this.label21);
            this.panel2.Controls.Add(this.generate);
            this.panel2.Controls.Add(this.leavededuction);
            this.panel2.Controls.Add(this.label20);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.deductions);
            this.panel2.Controls.Add(this.ename);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.earnings);
            this.panel2.Controls.Add(this.month);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.year);
            this.panel2.Location = new System.Drawing.Point(126, 139);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(527, 577);
            this.panel2.TabIndex = 30;
            // 
            // latededuction
            // 
            this.latededuction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.latededuction.Location = new System.Drawing.Point(238, 413);
            this.latededuction.Name = "latededuction";
            this.latededuction.Size = new System.Drawing.Size(204, 30);
            this.latededuction.TabIndex = 33;
            this.latededuction.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Latededuction_KeyPress);
            // 
            // label21
            // 
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(24, 400);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(182, 55);
            this.label21.TabIndex = 32;
            this.label21.Text = "Income tax Deduction:";
            // 
            // leavededuction
            // 
            this.leavededuction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leavededuction.Location = new System.Drawing.Point(238, 336);
            this.leavededuction.Name = "leavededuction";
            this.leavededuction.Size = new System.Drawing.Size(204, 30);
            this.leavededuction.TabIndex = 31;
            this.leavededuction.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Leavededuction_KeyPress);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(24, 336);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(192, 25);
            this.label20.TabIndex = 30;
            this.label20.Text = "Leave Deductions:";
            // 
            // GenerateSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1888, 990);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GenerateSalary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GenerateSalary";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ename;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox month;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button generate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label designation;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Label department;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox year;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label salary;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox earnings;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox deductions;
        private System.Windows.Forms.Label deduc;
        private System.Windows.Forms.Label earn;
        private System.Windows.Forms.Label depid;
        private System.Windows.Forms.Label eid;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox leavededuction;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox latededuction;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label ldeduc;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label mdeduc;
        private System.Windows.Forms.Label label23;
    }
}