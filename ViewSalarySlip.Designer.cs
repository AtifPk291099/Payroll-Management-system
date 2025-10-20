namespace WindowsFormsApp1
{
    partial class ViewSalarySlip
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewSalarySlip));
            this.year = new System.Windows.Forms.TextBox();
            this.generate = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.depid = new System.Windows.Forms.Label();
            this.deduc = new System.Windows.Forms.Label();
            this.salary = new System.Windows.Forms.Label();
            this.earn = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.department = new System.Windows.Forms.Label();
            this.designation = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.Print = new System.Windows.Forms.Button();
            this.month = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ldeduc = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.mdeduc = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.eid = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.Empty = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // year
            // 
            this.year.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.year.Location = new System.Drawing.Point(386, 166);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(204, 30);
            this.year.TabIndex = 1;
            this.year.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Year_KeyPress_1);
            // 
            // generate
            // 
            this.generate.BackColor = System.Drawing.SystemColors.Highlight;
            this.generate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.generate.Location = new System.Drawing.Point(685, 160);
            this.generate.Name = "generate";
            this.generate.Size = new System.Drawing.Size(181, 33);
            this.generate.TabIndex = 2;
            this.generate.Text = "Generate Slip";
            this.generate.UseVisualStyleBackColor = false;
            this.generate.Click += new System.EventHandler(this.Generate_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(382, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 25);
            this.label5.TabIndex = 37;
            this.label5.Text = " Year:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(30, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1823, 2);
            this.label1.TabIndex = 32;
            this.label1.UseCompatibleTextRendering = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 42);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(298, 32);
            this.label4.TabIndex = 31;
            this.label4.Text = "Generate Salary Slip";
            // 
            // depid
            // 
            this.depid.AutoSize = true;
            this.depid.Location = new System.Drawing.Point(260, 117);
            this.depid.Name = "depid";
            this.depid.Size = new System.Drawing.Size(54, 17);
            this.depid.TabIndex = 30;
            this.depid.Text = "label17";
            this.depid.Visible = false;
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
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.Location = new System.Drawing.Point(286, 282);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(22, 25);
            this.time.TabIndex = 22;
            this.time.Text = "s";
            // 
            // department
            // 
            this.department.AutoSize = true;
            this.department.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.department.Location = new System.Drawing.Point(664, 230);
            this.department.Name = "department";
            this.department.Size = new System.Drawing.Size(22, 25);
            this.department.TabIndex = 21;
            this.department.Text = "s";
            // 
            // designation
            // 
            this.designation.AutoSize = true;
            this.designation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.designation.Location = new System.Drawing.Point(239, 230);
            this.designation.Name = "designation";
            this.designation.Size = new System.Drawing.Size(107, 25);
            this.designation.TabIndex = 20;
            this.designation.Text = "snbskdbkd";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(527, 166);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(22, 25);
            this.name.TabIndex = 14;
            this.name.Text = "s";
            // 
            // Print
            // 
            this.Print.BackColor = System.Drawing.Color.ForestGreen;
            this.Print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Print.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Print.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Print.Location = new System.Drawing.Point(351, 619);
            this.Print.Name = "Print";
            this.Print.Size = new System.Drawing.Size(95, 38);
            this.Print.TabIndex = 3;
            this.Print.Text = "Print";
            this.Print.UseVisualStyleBackColor = false;
            this.Print.Visible = false;
            this.Print.Click += new System.EventHandler(this.Print_Click);
            // 
            // month
            // 
            this.month.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.month.FormattingEnabled = true;
            this.month.Location = new System.Drawing.Point(81, 168);
            this.month.Name = "month";
            this.month.Size = new System.Drawing.Size(206, 33);
            this.month.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(77, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 25);
            this.label3.TabIndex = 35;
            this.label3.Text = "Choose Month:";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.depid);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.eid);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.time);
            this.panel1.Controls.Add(this.Print);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.department);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.designation);
            this.panel1.Controls.Add(this.name);
            this.panel1.Controls.Add(this.label28);
            this.panel1.Controls.Add(this.label29);
            this.panel1.Controls.Add(this.label30);
            this.panel1.Controls.Add(this.label32);
            this.panel1.Controls.Add(this.label33);
            this.panel1.Location = new System.Drawing.Point(12, 234);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(865, 660);
            this.panel1.TabIndex = 40;
            this.panel1.Visible = false;
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
            this.tableLayoutPanel1.Controls.Add(this.salary, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.deduc, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label12, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label13, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.earn, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.mdeduc, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.label9, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.label23, 2, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(18, 318);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(840, 204);
            this.tableLayoutPanel1.TabIndex = 36;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(423, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 25);
            this.label2.TabIndex = 36;
            this.label2.Text = "Leave Deduction:";
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
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(423, 150);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 25);
            this.label9.TabIndex = 25;
            this.label9.Text = "Net Salary:";
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
            this.label19.Location = new System.Drawing.Point(687, 581);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(158, 2);
            this.label19.TabIndex = 34;
            this.label19.UseCompatibleTextRendering = true;
            this.label19.Click += new System.EventHandler(this.Label19_Click);
            // 
            // eid
            // 
            this.eid.AutoSize = true;
            this.eid.Location = new System.Drawing.Point(159, 117);
            this.eid.Name = "eid";
            this.eid.Size = new System.Drawing.Size(54, 17);
            this.eid.TabIndex = 29;
            this.eid.Text = "label16";
            this.eid.Visible = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(380, 127);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(86, 17);
            this.label18.TabIndex = 33;
            this.label18.Text = "Salary Slip";
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(703, 583);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(142, 55);
            this.label17.TabIndex = 32;
            this.label17.Text = "Signature and Stamp";
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(18, 59);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(840, 58);
            this.label16.TabIndex = 31;
            this.label16.Text = "Bandra (West) Mumbai -400050 Maharashtra";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(108, 282);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(172, 25);
            this.label28.TabIndex = 17;
            this.label28.Text = "Month and Year:";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(528, 230);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(130, 25);
            this.label29.TabIndex = 16;
            this.label29.Text = "Department:";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(108, 230);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(133, 25);
            this.label30.TabIndex = 15;
            this.label30.Text = "Designation:";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(324, 165);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(176, 25);
            this.label32.TabIndex = 13;
            this.label32.Text = "Employee Name:";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(347, 17);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(212, 25);
            this.label33.TabIndex = 12;
            this.label33.Text = "KHAN PVT LIMITED";
            // 
            // Empty
            // 
            this.Empty.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Empty.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Empty.Location = new System.Drawing.Point(949, 126);
            this.Empty.Name = "Empty";
            this.Empty.Size = new System.Drawing.Size(532, 76);
            this.Empty.TabIndex = 41;
            this.Empty.Text = "Not Generated Slaary Slip of this month by Admin";
            this.Empty.Visible = false;
            // 
            // ViewSalarySlip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1870, 943);
            this.Controls.Add(this.Empty);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.year);
            this.Controls.Add(this.generate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.month);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewSalarySlip";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewSalarySlip";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox year;
        private System.Windows.Forms.Button generate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label depid;
        private System.Windows.Forms.Label deduc;
        private System.Windows.Forms.Label salary;
        private System.Windows.Forms.Label earn;
        private System.Windows.Forms.Button Print;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Label department;
        private System.Windows.Forms.Label designation;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.ComboBox month;
        private System.Windows.Forms.Label label3;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label eid;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label ldeduc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label mdeduc;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label Empty;
    }
}