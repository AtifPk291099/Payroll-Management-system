namespace WindowsFormsApp1
{
    partial class ApproveLeave
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApproveLeave));
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.Label();
            this.Approve = new System.Windows.Forms.Button();
            this.Decline = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Empty = new System.Windows.Forms.Label();
            this.data = new System.Windows.Forms.Panel();
            this.LeaveGridview = new System.Windows.Forms.DataGridView();
            this.search = new System.Windows.Forms.Panel();
            this.data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LeaveGridview)).BeginInit();
            this.search.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 37);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(230, 32);
            this.label4.TabIndex = 8;
            this.label4.Text = "Manage Leaves";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(47, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1823, 2);
            this.label1.TabIndex = 9;
            this.label1.UseCompatibleTextRendering = true;
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(208, 616);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(0, 17);
            this.status.TabIndex = 18;
            this.status.Visible = false;
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Location = new System.Drawing.Point(298, 616);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(0, 17);
            this.id.TabIndex = 19;
            this.id.Visible = false;
            // 
            // Approve
            // 
            this.Approve.BackColor = System.Drawing.Color.ForestGreen;
            this.Approve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Approve.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Approve.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Approve.Location = new System.Drawing.Point(467, 441);
            this.Approve.Name = "Approve";
            this.Approve.Size = new System.Drawing.Size(146, 41);
            this.Approve.TabIndex = 1;
            this.Approve.Text = "Approve";
            this.Approve.UseVisualStyleBackColor = false;
            this.Approve.Click += new System.EventHandler(this.Approve_Click);
            // 
            // Decline
            // 
            this.Decline.BackColor = System.Drawing.Color.IndianRed;
            this.Decline.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Decline.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Decline.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Decline.Location = new System.Drawing.Point(662, 441);
            this.Decline.Name = "Decline";
            this.Decline.Size = new System.Drawing.Size(128, 41);
            this.Decline.TabIndex = 2;
            this.Decline.Text = "Decline";
            this.Decline.UseVisualStyleBackColor = false;
            this.Decline.Click += new System.EventHandler(this.Decline_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 25);
            this.label2.TabIndex = 22;
            this.label2.Text = "Search By Name: ";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(233, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(264, 30);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBox1_KeyUp);
            // 
            // Empty
            // 
            this.Empty.AutoSize = true;
            this.Empty.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Empty.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Empty.Location = new System.Drawing.Point(790, 116);
            this.Empty.Name = "Empty";
            this.Empty.Size = new System.Drawing.Size(358, 36);
            this.Empty.TabIndex = 24;
            this.Empty.Text = "Nobody taken Leaves..!!";
            this.Empty.Visible = false;
            // 
            // data
            // 
            this.data.Controls.Add(this.LeaveGridview);
            this.data.Controls.Add(this.Approve);
            this.data.Controls.Add(this.Decline);
            this.data.Location = new System.Drawing.Point(223, 190);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(1297, 503);
            this.data.TabIndex = 25;
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
            this.LeaveGridview.Location = new System.Drawing.Point(20, 16);
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
            this.LeaveGridview.Size = new System.Drawing.Size(1260, 407);
            this.LeaveGridview.TabIndex = 17;
            this.LeaveGridview.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.LeaveGridview_DataBindingComplete);
            this.LeaveGridview.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.LeaveGridview_RowHeaderMouseClick);
            // 
            // search
            // 
            this.search.Controls.Add(this.label2);
            this.search.Controls.Add(this.textBox1);
            this.search.Location = new System.Drawing.Point(223, 101);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(510, 68);
            this.search.TabIndex = 26;
            // 
            // ApproveLeave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1906, 1037);
            this.Controls.Add(this.search);
            this.Controls.Add(this.data);
            this.Controls.Add(this.Empty);
            this.Controls.Add(this.id);
            this.Controls.Add(this.status);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ApproveLeave";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ApproveLeave";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.data.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LeaveGridview)).EndInit();
            this.search.ResumeLayout(false);
            this.search.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.Button Approve;
        private System.Windows.Forms.Button Decline;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Empty;
        private System.Windows.Forms.Panel data;
        private System.Windows.Forms.DataGridView LeaveGridview;
        private System.Windows.Forms.Panel search;
    }
}