namespace WindowsFormsApplication1
{
    partial class frmNPQ_about
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNPQ_about));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnl2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pnl3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pnl_header = new System.Windows.Forms.Panel();
            this.btn_pre = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.pnl2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnl3.SuspendLayout();
            this.pnl_header.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.about_NPQ;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.pnl2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.pnl_header);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(736, 400);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // pnl2
            // 
            this.pnl2.BackColor = System.Drawing.Color.White;
            this.pnl2.Controls.Add(this.groupBox1);
            this.pnl2.Location = new System.Drawing.Point(1, 40);
            this.pnl2.Name = "pnl2";
            this.pnl2.Size = new System.Drawing.Size(726, 330);
            this.pnl2.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pnl3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox1.Location = new System.Drawing.Point(12, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(705, 357);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mô tả";
            // 
            // pnl3
            // 
            this.pnl3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnl3.AutoScroll = true;
            this.pnl3.AutoScrollMargin = new System.Drawing.Size(0, 15);
            this.pnl3.BackColor = System.Drawing.Color.Transparent;
            this.pnl3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnl3.Controls.Add(this.label4);
            this.pnl3.Controls.Add(this.label1);
            this.pnl3.Controls.Add(this.label3);
            this.pnl3.Controls.Add(this.label2);
            this.pnl3.Location = new System.Drawing.Point(12, 26);
            this.pnl3.Name = "pnl3";
            this.pnl3.Size = new System.Drawing.Size(694, 280);
            this.pnl3.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(657, 48);
            this.label4.TabIndex = 3;
            this.label4.Text = resources.GetString("label4.Text");
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(646, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vấn đề này không được khởi xướng bởi Shannon mà bởi B. M. Fitingof.";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(657, 39);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã hoá nguồn phổ quát tiếp cận theo cách khác bằng việc lợi dụng cấu trúc của các" +
    " dãy và cũng đi đến được cùng kết quả tối ưu.";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(646, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lý thuyết của Shannon dựa trên kiến thức về các hàm phân bố xác suất và chứng min" +
    "h tồn tại phép mã hoá tối ưu.";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DimGray;
            this.button1.Location = new System.Drawing.Point(26, 371);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 25);
            this.button1.TabIndex = 11;
            this.button1.Text = "Press Esc to close";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnl_header
            // 
            this.pnl_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnl_header.Controls.Add(this.btn_pre);
            this.pnl_header.Controls.Add(this.btn_next);
            this.pnl_header.Location = new System.Drawing.Point(-1, 0);
            this.pnl_header.Name = "pnl_header";
            this.pnl_header.Size = new System.Drawing.Size(733, 40);
            this.pnl_header.TabIndex = 10;
            this.pnl_header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_header_MouseDown);
            this.pnl_header.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_header_MouseMove);
            // 
            // btn_pre
            // 
            this.btn_pre.BackColor = System.Drawing.Color.Transparent;
            this.btn_pre.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.pre;
            this.btn_pre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_pre.FlatAppearance.BorderSize = 0;
            this.btn_pre.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_pre.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn_pre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pre.Location = new System.Drawing.Point(624, 2);
            this.btn_pre.Name = "btn_pre";
            this.btn_pre.Size = new System.Drawing.Size(34, 34);
            this.btn_pre.TabIndex = 1;
            this.btn_pre.UseVisualStyleBackColor = false;
            this.btn_pre.Click += new System.EventHandler(this.btn_pre_Click);
            // 
            // btn_next
            // 
            this.btn_next.BackColor = System.Drawing.Color.Transparent;
            this.btn_next.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.next;
            this.btn_next.FlatAppearance.BorderSize = 0;
            this.btn_next.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_next.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_next.Location = new System.Drawing.Point(674, 2);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(34, 34);
            this.btn_next.TabIndex = 0;
            this.btn_next.UseVisualStyleBackColor = false;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // frmNPQ_about
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(730, 400);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmNPQ_about";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmNPQ_about_Load);
            this.panel1.ResumeLayout(false);
            this.pnl2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.pnl3.ResumeLayout(false);
            this.pnl_header.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnl_header;
        private System.Windows.Forms.Button btn_pre;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pnl2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel pnl3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}