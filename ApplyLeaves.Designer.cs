namespace WindowsFormsApp1
{
    partial class ApplyLeaves
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApplyLeaves));
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.reason = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.LeaveGridview = new System.Windows.Forms.DataGridView();
            this.fromDate = new System.Windows.Forms.DateTimePicker();
            this.todate = new System.Windows.Forms.DateTimePicker();
            this.search = new System.Windows.Forms.Panel();
            this.half = new System.Windows.Forms.RadioButton();
            this.full = new System.Windows.Forms.RadioButton();
            this.multiple = new System.Windows.Forms.RadioButton();
            this.toform = new System.Windows.Forms.Panel();
            this.first = new System.Windows.Forms.RadioButton();
            this.second = new System.Windows.Forms.RadioButton();
            this.halftype = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.LeaveGridview)).BeginInit();
            this.search.SuspendLayout();
            this.toform.SuspendLayout();
            this.halftype.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 48);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 32);
            this.label4.TabIndex = 7;
            this.label4.Text = "Apply Leaves";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(50, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1823, 2);
            this.label1.TabIndex = 8;
            this.label1.UseCompatibleTextRendering = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(504, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "From Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "To Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(793, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Reason:";
            // 
            // reason
            // 
            this.reason.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reason.Location = new System.Drawing.Point(797, 243);
            this.reason.Multiline = true;
            this.reason.Name = "reason";
            this.reason.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.reason.Size = new System.Drawing.Size(395, 89);
            this.reason.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(1102, 346);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 45);
            this.button1.TabIndex = 3;
            this.button1.Text = "Apply";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // LeaveGridview
            // 
            this.LeaveGridview.AllowUserToAddRows = false;
            this.LeaveGridview.AllowUserToDeleteRows = false;
            this.LeaveGridview.AllowUserToResizeColumns = false;
            this.LeaveGridview.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.LeaveGridview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.LeaveGridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.LeaveGridview.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.LeaveGridview.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LeaveGridview.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.LeaveGridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.LeaveGridview.ColumnHeadersHeight = 35;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.LeaveGridview.DefaultCellStyle = dataGridViewCellStyle3;
            this.LeaveGridview.EnableHeadersVisualStyles = false;
            this.LeaveGridview.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LeaveGridview.Location = new System.Drawing.Point(20, 43);
            this.LeaveGridview.Name = "LeaveGridview";
            this.LeaveGridview.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.LeaveGridview.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.LeaveGridview.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.LeaveGridview.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.LeaveGridview.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.LeaveGridview.RowTemplate.Height = 24;
            this.LeaveGridview.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.LeaveGridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.LeaveGridview.Size = new System.Drawing.Size(1033, 392);
            this.LeaveGridview.TabIndex = 16;
            this.LeaveGridview.Visible = false;
            this.LeaveGridview.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.LeaveGridview_DataBindingComplete);
            // 
            // fromDate
            // 
            this.fromDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromDate.Location = new System.Drawing.Point(508, 243);
            this.fromDate.Name = "fromDate";
            this.fromDate.Size = new System.Drawing.Size(200, 30);
            this.fromDate.TabIndex = 0;
            // 
            // todate
            // 
            this.todate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todate.Location = new System.Drawing.Point(12, 48);
            this.todate.Name = "todate";
            this.todate.Size = new System.Drawing.Size(200, 30);
            this.todate.TabIndex = 1;
            // 
            // search
            // 
            this.search.Controls.Add(this.LeaveGridview);
            this.search.Location = new System.Drawing.Point(497, 406);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(1070, 462);
            this.search.TabIndex = 19;
            // 
            // half
            // 
            this.half.AutoSize = true;
            this.half.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.half.Location = new System.Drawing.Point(501, 120);
            this.half.Name = "half";
            this.half.Size = new System.Drawing.Size(115, 29);
            this.half.TabIndex = 20;
            this.half.Text = "Half Day";
            this.half.UseVisualStyleBackColor = true;
            this.half.CheckedChanged += new System.EventHandler(this.Half_CheckedChanged);
            // 
            // full
            // 
            this.full.AutoSize = true;
            this.full.Checked = true;
            this.full.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.full.Location = new System.Drawing.Point(700, 120);
            this.full.Name = "full";
            this.full.Size = new System.Drawing.Size(112, 29);
            this.full.TabIndex = 23;
            this.full.TabStop = true;
            this.full.Text = "Full Day";
            this.full.UseVisualStyleBackColor = true;
            this.full.CheckedChanged += new System.EventHandler(this.Full_CheckedChanged);
            // 
            // multiple
            // 
            this.multiple.AutoSize = true;
            this.multiple.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiple.Location = new System.Drawing.Point(911, 120);
            this.multiple.Name = "multiple";
            this.multiple.Size = new System.Drawing.Size(152, 29);
            this.multiple.TabIndex = 24;
            this.multiple.Text = "Multiple Day";
            this.multiple.UseVisualStyleBackColor = true;
            this.multiple.CheckedChanged += new System.EventHandler(this.Multiple_CheckedChanged);
            // 
            // toform
            // 
            this.toform.Controls.Add(this.label3);
            this.toform.Controls.Add(this.todate);
            this.toform.Location = new System.Drawing.Point(508, 291);
            this.toform.Name = "toform";
            this.toform.Size = new System.Drawing.Size(217, 100);
            this.toform.TabIndex = 25;
            this.toform.Visible = false;
            // 
            // first
            // 
            this.first.AutoSize = true;
            this.first.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.first.Location = new System.Drawing.Point(3, 3);
            this.first.Name = "first";
            this.first.Size = new System.Drawing.Size(119, 29);
            this.first.TabIndex = 26;
            this.first.Text = "First Half";
            this.first.UseVisualStyleBackColor = true;
            // 
            // second
            // 
            this.second.AutoSize = true;
            this.second.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.second.Location = new System.Drawing.Point(152, 3);
            this.second.Name = "second";
            this.second.Size = new System.Drawing.Size(151, 29);
            this.second.TabIndex = 27;
            this.second.Text = "Second Half";
            this.second.UseVisualStyleBackColor = true;
            // 
            // halftype
            // 
            this.halftype.Controls.Add(this.first);
            this.halftype.Controls.Add(this.second);
            this.halftype.Location = new System.Drawing.Point(578, 163);
            this.halftype.Name = "halftype";
            this.halftype.Size = new System.Drawing.Size(322, 38);
            this.halftype.TabIndex = 28;
            this.halftype.Visible = false;
            // 
            // ApplyLeaves
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1906, 1037);
            this.Controls.Add(this.halftype);
            this.Controls.Add(this.toform);
            this.Controls.Add(this.multiple);
            this.Controls.Add(this.full);
            this.Controls.Add(this.half);
            this.Controls.Add(this.search);
            this.Controls.Add(this.fromDate);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.reason);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ApplyLeaves";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ApplyLeaves";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.LeaveGridview)).EndInit();
            this.search.ResumeLayout(false);
            this.toform.ResumeLayout(false);
            this.toform.PerformLayout();
            this.halftype.ResumeLayout(false);
            this.halftype.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox reason;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView LeaveGridview;
        private System.Windows.Forms.DateTimePicker fromDate;
        private System.Windows.Forms.DateTimePicker todate;
        private System.Windows.Forms.Panel search;
        private System.Windows.Forms.RadioButton half;
        private System.Windows.Forms.RadioButton full;
        private System.Windows.Forms.RadioButton multiple;
        private System.Windows.Forms.Panel toform;
        private System.Windows.Forms.RadioButton first;
        private System.Windows.Forms.RadioButton second;
        private System.Windows.Forms.Panel halftype;
    }
}