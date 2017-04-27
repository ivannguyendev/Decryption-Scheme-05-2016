namespace WindowsFormsApplication1
{
    partial class frmNPQ
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNPQ));
            this.btnExport = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnQuit = new System.Windows.Forms.Button();
            this.tbNum = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.Vector = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BienNgauNhien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DayNguon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Entropy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnl_footer = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pnl_header = new System.Windows.Forms.Panel();
            this.btnhelp = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_mini = new System.Windows.Forms.Button();
            this.btn_about = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.panel5.SuspendLayout();
            this.pnl_header.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.Transparent;
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Font = new System.Drawing.Font("UTM Helve", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.ForeColor = System.Drawing.Color.DimGray;
            this.btnExport.Location = new System.Drawing.Point(0, 213);
            this.btnExport.MaximumSize = new System.Drawing.Size(705, 455);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(155, 50);
            this.btnExport.TabIndex = 4;
            this.btnExport.Text = "Xuất";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Transparent;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("UTM Helve", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.DimGray;
            this.btnRefresh.Location = new System.Drawing.Point(0, 157);
            this.btnRefresh.MaximumSize = new System.Drawing.Size(705, 455);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(155, 50);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Xóa";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.MaximumSize = new System.Drawing.Size(705, 455);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Nhập Số:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Transparent;
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("UTM Helve", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.DimGray;
            this.btnStart.Location = new System.Drawing.Point(0, 101);
            this.btnStart.MaximumSize = new System.Drawing.Size(705, 455);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(155, 50);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Thực Hiện ";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel1.Controls.Add(this.btnQuit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnExport);
            this.panel1.Controls.Add(this.tbNum);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.btnStart);
            this.panel1.Location = new System.Drawing.Point(0, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(165, 375);
            this.panel1.TabIndex = 24;
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.Transparent;
            this.btnQuit.FlatAppearance.BorderSize = 0;
            this.btnQuit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuit.Font = new System.Drawing.Font("UTM Helve", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.ForeColor = System.Drawing.Color.DimGray;
            this.btnQuit.Location = new System.Drawing.Point(0, 269);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(155, 50);
            this.btnQuit.TabIndex = 5;
            this.btnQuit.Text = "Thoát";
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // tbNum
            // 
            this.tbNum.Location = new System.Drawing.Point(72, 42);
            this.tbNum.MaximumSize = new System.Drawing.Size(705, 455);
            this.tbNum.Name = "tbNum";
            this.tbNum.Size = new System.Drawing.Size(70, 20);
            this.tbNum.TabIndex = 1;
            this.tbNum.TextChanged += new System.EventHandler(this.tbNum_TextChanged);
            this.tbNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNum_KeyPress);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel2.Controls.Add(this.dgv1);
            this.panel2.Location = new System.Drawing.Point(166, 105);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(558, 352);
            this.panel2.TabIndex = 25;
            // 
            // dgv1
            // 
            this.dgv1.AllowUserToAddRows = false;
            this.dgv1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv1.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dgv1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Vector,
            this.BienNgauNhien,
            this.DayNguon,
            this.Entropy,
            this.ma});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgv1.GridColor = System.Drawing.SystemColors.HighlightText;
            this.dgv1.Location = new System.Drawing.Point(4, 3);
            this.dgv1.Name = "dgv1";
            this.dgv1.ReadOnly = true;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv1.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv1.Size = new System.Drawing.Size(545, 372);
            this.dgv1.TabIndex = 15;
            this.dgv1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv1_CellDoubleClick);
            // 
            // Vector
            // 
            this.Vector.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Vector.FillWeight = 150F;
            this.Vector.HeaderText = "Qi";
            this.Vector.Name = "Vector";
            this.Vector.ReadOnly = true;
            this.Vector.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Vector.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Vector.ToolTipText = "Vector Tần Suất";
            // 
            // BienNgauNhien
            // 
            this.BienNgauNhien.HeaderText = "ω(Qi )";
            this.BienNgauNhien.Name = "BienNgauNhien";
            this.BienNgauNhien.ReadOnly = true;
            this.BienNgauNhien.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.BienNgauNhien.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.BienNgauNhien.ToolTipText = "số các dãy Si mà có cùng vectơ tần suất Q";
            this.BienNgauNhien.Width = 50;
            // 
            // DayNguon
            // 
            this.DayNguon.HeaderText = "Si";
            this.DayNguon.Name = "DayNguon";
            this.DayNguon.ReadOnly = true;
            this.DayNguon.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DayNguon.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.DayNguon.ToolTipText = "Dãy nguồn Si ";
            this.DayNguon.Width = 120;
            // 
            // Entropy
            // 
            dataGridViewCellStyle3.Format = "N6";
            dataGridViewCellStyle3.NullValue = null;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Entropy.DefaultCellStyle = dataGridViewCellStyle3;
            this.Entropy.HeaderText = "ψ(S i )";
            this.Entropy.Name = "Entropy";
            this.Entropy.ReadOnly = true;
            this.Entropy.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Entropy.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Entropy.ToolTipText = "Tựa–entropy";
            this.Entropy.Width = 80;
            // 
            // ma
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ma.DefaultCellStyle = dataGridViewCellStyle4;
            this.ma.HeaderText = "w i";
            this.ma.MaxInputLength = 7;
            this.ma.Name = "ma";
            this.ma.ReadOnly = true;
            this.ma.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ma.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ma.ToolTipText = "Từ Mã";
            this.ma.Width = 150;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.Location = new System.Drawing.Point(36, 67);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(650, 2);
            this.panel3.TabIndex = 26;
            // 
            // pnl_footer
            // 
            this.pnl_footer.BackColor = System.Drawing.Color.DimGray;
            this.pnl_footer.Location = new System.Drawing.Point(-2, 474);
            this.pnl_footer.Name = "pnl_footer";
            this.pnl_footer.Size = new System.Drawing.Size(726, 26);
            this.pnl_footer.TabIndex = 27;
            this.pnl_footer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_footer_MouseDown);
            this.pnl_footer.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_footer_MouseMove);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.pnl_header);
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(720, 50);
            this.panel5.TabIndex = 28;
            // 
            // pnl_header
            // 
            this.pnl_header.BackColor = System.Drawing.Color.DimGray;
            this.pnl_header.Controls.Add(this.btnhelp);
            this.pnl_header.Controls.Add(this.btn_exit);
            this.pnl_header.Controls.Add(this.flowLayoutPanel1);
            this.pnl_header.Controls.Add(this.btn_mini);
            this.pnl_header.Controls.Add(this.btn_about);
            this.pnl_header.Controls.Add(this.panel6);
            this.pnl_header.Location = new System.Drawing.Point(0, 3);
            this.pnl_header.Name = "pnl_header";
            this.pnl_header.Size = new System.Drawing.Size(720, 46);
            this.pnl_header.TabIndex = 2;
            this.pnl_header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_header_MouseDown);
            this.pnl_header.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_header_MouseMove);
            // 
            // btnhelp
            // 
            this.btnhelp.BackColor = System.Drawing.Color.Transparent;
            this.btnhelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnhelp.FlatAppearance.BorderSize = 0;
            this.btnhelp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnhelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnhelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnhelp.ForeColor = System.Drawing.Color.White;
            this.btnhelp.Location = new System.Drawing.Point(596, -1);
            this.btnhelp.Name = "btnhelp";
            this.btnhelp.Size = new System.Drawing.Size(38, 48);
            this.btnhelp.TabIndex = 7;
            this.btnhelp.TabStop = false;
            this.btnhelp.Text = "Help";
            this.btnhelp.UseVisualStyleBackColor = false;
            this.btnhelp.Click += new System.EventHandler(this.btnhelp_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.Transparent;
            this.btn_exit.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.icon_exit;
            this.btn_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Location = new System.Drawing.Point(680, 9);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(25, 23);
            this.btn_exit.TabIndex = 4;
            this.btn_exit.TabStop = false;
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(170, 1);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(196, 46);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("UTM Helve", 10F);
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 46);
            this.label3.TabIndex = 0;
            this.label3.Text = "Giải mã nguồn phổ quát";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_mini
            // 
            this.btn_mini.BackColor = System.Drawing.Color.Transparent;
            this.btn_mini.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.icon_mini;
            this.btn_mini.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_mini.FlatAppearance.BorderSize = 0;
            this.btn_mini.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_mini.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn_mini.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mini.Location = new System.Drawing.Point(640, 9);
            this.btn_mini.Name = "btn_mini";
            this.btn_mini.Size = new System.Drawing.Size(28, 23);
            this.btn_mini.TabIndex = 3;
            this.btn_mini.TabStop = false;
            this.btn_mini.UseVisualStyleBackColor = false;
            this.btn_mini.Click += new System.EventHandler(this.btn_mini_Click);
            // 
            // btn_about
            // 
            this.btn_about.BackColor = System.Drawing.Color.Transparent;
            this.btn_about.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_about.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_about.FlatAppearance.BorderSize = 0;
            this.btn_about.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_about.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_about.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_about.Font = new System.Drawing.Font("UTM Helve", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_about.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_about.Location = new System.Drawing.Point(59, 6);
            this.btn_about.Name = "btn_about";
            this.btn_about.Size = new System.Drawing.Size(105, 34);
            this.btn_about.TabIndex = 2;
            this.btn_about.TabStop = false;
            this.btn_about.Text = "Scrumgroup";
            this.btn_about.UseVisualStyleBackColor = false;
            this.btn_about.Click += new System.EventHandler(this.btn_about_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.icon32;
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel6.Location = new System.Drawing.Point(5, 6);
            this.panel6.Name = "panel6";
            this.panel6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel6.Size = new System.Drawing.Size(48, 34);
            this.panel6.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(180, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Note: Click đúp chuột vào ô bảng để xem full";
            // 
            // frmNPQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(720, 500);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.pnl_footer);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(705, 455);
            this.Name = "frmNPQ";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nguồn phổ quát";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.pnl_header.ResumeLayout(false);
            this.pnl_header.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vector;
        private System.Windows.Forms.DataGridViewTextBoxColumn BienNgauNhien;
        private System.Windows.Forms.DataGridViewTextBoxColumn DayNguon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Entropy;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma;
        private System.Windows.Forms.Panel pnl_footer;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel pnl_header;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_mini;
        private System.Windows.Forms.Button btn_about;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox tbNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnhelp;

    }
}