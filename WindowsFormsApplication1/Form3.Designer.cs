namespace WindowsFormsApplication1
{
    partial class frmMatrix
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMatrix));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnTHien = new System.Windows.Forms.Button();
            this.btnTHienLai = new System.Windows.Forms.Button();
            this.btnMake = new System.Windows.Forms.Button();
            this.num2 = new System.Windows.Forms.NumericUpDown();
            this.num1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlMatrix = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pnl7 = new System.Windows.Forms.Panel();
            this.btnhelp = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_mini = new System.Windows.Forms.Button();
            this.btn_about = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.pnl7.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Controls.Add(this.btnTHien);
            this.panel1.Controls.Add(this.btnTHienLai);
            this.panel1.Controls.Add(this.btnMake);
            this.panel1.Controls.Add(this.num2);
            this.panel1.Controls.Add(this.num1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-2, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(166, 357);
            this.panel1.TabIndex = 0;
            // 
            // btnThoat
            // 
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("UTM Helve", 9.75F);
            this.btnThoat.ForeColor = System.Drawing.Color.DimGray;
            this.btnThoat.Location = new System.Drawing.Point(0, 243);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(155, 50);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnTHien
            // 
            this.btnTHien.FlatAppearance.BorderSize = 0;
            this.btnTHien.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnTHien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTHien.Font = new System.Drawing.Font("UTM Helve", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTHien.ForeColor = System.Drawing.Color.DimGray;
            this.btnTHien.Location = new System.Drawing.Point(0, 132);
            this.btnTHien.Name = "btnTHien";
            this.btnTHien.Size = new System.Drawing.Size(155, 50);
            this.btnTHien.TabIndex = 5;
            this.btnTHien.Text = "Thực hiện";
            this.btnTHien.UseVisualStyleBackColor = true;
            this.btnTHien.Click += new System.EventHandler(this.btnTHien_Click);
            // 
            // btnTHienLai
            // 
            this.btnTHienLai.FlatAppearance.BorderSize = 0;
            this.btnTHienLai.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnTHienLai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTHienLai.Font = new System.Drawing.Font("UTM Helve", 9.75F);
            this.btnTHienLai.ForeColor = System.Drawing.Color.DimGray;
            this.btnTHienLai.Location = new System.Drawing.Point(0, 188);
            this.btnTHienLai.Name = "btnTHienLai";
            this.btnTHienLai.Size = new System.Drawing.Size(155, 50);
            this.btnTHienLai.TabIndex = 6;
            this.btnTHienLai.Text = "Xóa";
            this.btnTHienLai.UseVisualStyleBackColor = true;
            this.btnTHienLai.Click += new System.EventHandler(this.btnTHienLai_Click);
            // 
            // btnMake
            // 
            this.btnMake.BackColor = System.Drawing.Color.Transparent;
            this.btnMake.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnMake.FlatAppearance.BorderSize = 0;
            this.btnMake.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnMake.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMake.Font = new System.Drawing.Font("UTM Helve", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(1)), true);
            this.btnMake.ForeColor = System.Drawing.Color.DimGray;
            this.btnMake.Location = new System.Drawing.Point(0, 77);
            this.btnMake.Name = "btnMake";
            this.btnMake.Size = new System.Drawing.Size(155, 50);
            this.btnMake.TabIndex = 3;
            this.btnMake.Text = "Tạo ma trận";
            this.btnMake.UseVisualStyleBackColor = false;
            this.btnMake.Click += new System.EventHandler(this.btnMake_Click);
            // 
            // num2
            // 
            this.num2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.num2.Location = new System.Drawing.Point(70, 36);
            this.num2.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(69, 20);
            this.num2.TabIndex = 2;
            // 
            // num1
            // 
            this.num1.AccessibleName = "";
            this.num1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.num1.Location = new System.Drawing.Point(70, 4);
            this.num1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(69, 20);
            this.num1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("UTM Helve", 9.75F);
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(18, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cột   :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("UTM Helve", 9.75F);
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(17, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hàng:";
            // 
            // pnlMatrix
            // 
            this.pnlMatrix.BackColor = System.Drawing.Color.Transparent;
            this.pnlMatrix.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMatrix.Location = new System.Drawing.Point(0, 0);
            this.pnlMatrix.Name = "pnlMatrix";
            this.pnlMatrix.Size = new System.Drawing.Size(552, 374);
            this.pnlMatrix.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.pnlMatrix);
            this.panel3.Location = new System.Drawing.Point(170, 90);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(552, 374);
            this.panel3.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Location = new System.Drawing.Point(20, 66);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(680, 2);
            this.panel2.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DimGray;
            this.panel4.Location = new System.Drawing.Point(-2, 473);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(726, 26);
            this.panel4.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.pnl7);
            this.panel5.Location = new System.Drawing.Point(0, -1);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(720, 50);
            this.panel5.TabIndex = 6;
            // 
            // pnl7
            // 
            this.pnl7.BackColor = System.Drawing.Color.DimGray;
            this.pnl7.Controls.Add(this.btnhelp);
            this.pnl7.Controls.Add(this.btn_exit);
            this.pnl7.Controls.Add(this.flowLayoutPanel1);
            this.pnl7.Controls.Add(this.btn_mini);
            this.pnl7.Controls.Add(this.btn_about);
            this.pnl7.Controls.Add(this.panel6);
            this.pnl7.Location = new System.Drawing.Point(0, 4);
            this.pnl7.Name = "pnl7";
            this.pnl7.Size = new System.Drawing.Size(720, 46);
            this.pnl7.TabIndex = 2;
            this.pnl7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl7_MouseDown);
            this.pnl7.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl7_MouseMove);
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
            this.btnhelp.TabIndex = 5;
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
            this.flowLayoutPanel1.Size = new System.Drawing.Size(168, 46);
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
            this.label3.Size = new System.Drawing.Size(156, 46);
            this.label3.TabIndex = 0;
            this.label3.Text = "Lược đồ giải mã tối ưu";
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
            // frmMatrix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(720, 498);
            this.ControlBox = false;
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(705, 455);
            this.Name = "frmMatrix";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin ma trận";
            this.Load += new System.EventHandler(this.frmMatrix_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.pnl7.ResumeLayout(false);
            this.pnl7.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnTHien;
        private System.Windows.Forms.Panel pnlMatrix;
        private System.Windows.Forms.Button btnTHienLai;
        private System.Windows.Forms.Button btnMake;
        private System.Windows.Forms.NumericUpDown num2;
        private System.Windows.Forms.NumericUpDown num1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel pnl7;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_mini;
        private System.Windows.Forms.Button btn_about;
        private System.Windows.Forms.Button btnhelp;

    }
}