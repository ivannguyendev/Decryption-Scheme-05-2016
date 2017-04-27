namespace WindowsFormsApplication1
{
    partial class frmChoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChoice));
            this.btnNPQ = new System.Windows.Forms.Button();
            this.btnLDGM = new System.Windows.Forms.Button();
            this.pnl_header = new System.Windows.Forms.Panel();
            this.btn_about = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_mini = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnabout = new System.Windows.Forms.Button();
            this.pnl_footer = new System.Windows.Forms.Panel();
            this.pnl_header.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNPQ
            // 
            this.btnNPQ.BackColor = System.Drawing.Color.DarkOrange;
            this.btnNPQ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNPQ.FlatAppearance.BorderSize = 0;
            this.btnNPQ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNPQ.Font = new System.Drawing.Font("UTM Helve", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNPQ.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNPQ.Location = new System.Drawing.Point(296, 124);
            this.btnNPQ.Name = "btnNPQ";
            this.btnNPQ.Size = new System.Drawing.Size(140, 130);
            this.btnNPQ.TabIndex = 1;
            this.btnNPQ.Text = "Giải mã\r\nnguồn phổ quát";
            this.btnNPQ.UseVisualStyleBackColor = false;
            this.btnNPQ.Click += new System.EventHandler(this.btnNPQ_Click);
            // 
            // btnLDGM
            // 
            this.btnLDGM.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLDGM.BackColor = System.Drawing.Color.DarkOrange;
            this.btnLDGM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLDGM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLDGM.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnLDGM.FlatAppearance.BorderSize = 0;
            this.btnLDGM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLDGM.Font = new System.Drawing.Font("UTM Helve", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLDGM.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLDGM.Location = new System.Drawing.Point(97, 124);
            this.btnLDGM.Name = "btnLDGM";
            this.btnLDGM.Size = new System.Drawing.Size(140, 130);
            this.btnLDGM.TabIndex = 0;
            this.btnLDGM.Text = "Lược đồ\r\ngiải mã tối ưu";
            this.btnLDGM.UseVisualStyleBackColor = false;
            this.btnLDGM.Click += new System.EventHandler(this.btnLDGM_Click);
            // 
            // pnl_header
            // 
            this.pnl_header.BackColor = System.Drawing.Color.DimGray;
            this.pnl_header.Controls.Add(this.btn_about);
            this.pnl_header.Controls.Add(this.btn_exit);
            this.pnl_header.Controls.Add(this.btn_mini);
            this.pnl_header.Controls.Add(this.panel6);
            this.pnl_header.Location = new System.Drawing.Point(0, 0);
            this.pnl_header.Name = "pnl_header";
            this.pnl_header.Size = new System.Drawing.Size(720, 46);
            this.pnl_header.TabIndex = 3;
            this.pnl_header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_header_MouseDown);
            this.pnl_header.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_header_MouseMove);
            // 
            // btn_about
            // 
            this.btn_about.BackColor = System.Drawing.Color.Transparent;
            this.btn_about.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_about.FlatAppearance.BorderSize = 0;
            this.btn_about.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_about.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_about.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_about.Font = new System.Drawing.Font("UTM Helve", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_about.ForeColor = System.Drawing.Color.SeaShell;
            this.btn_about.Location = new System.Drawing.Point(330, 6);
            this.btn_about.Name = "btn_about";
            this.btn_about.Size = new System.Drawing.Size(73, 34);
            this.btn_about.TabIndex = 4;
            this.btn_about.TabStop = false;
            this.btn_about.Text = "Menu";
            this.btn_about.UseVisualStyleBackColor = false;
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
            // btnabout
            // 
            this.btnabout.BackColor = System.Drawing.Color.DarkOrange;
            this.btnabout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnabout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnabout.FlatAppearance.BorderSize = 0;
            this.btnabout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnabout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnabout.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnabout.Location = new System.Drawing.Point(488, 124);
            this.btnabout.Name = "btnabout";
            this.btnabout.Size = new System.Drawing.Size(140, 130);
            this.btnabout.TabIndex = 2;
            this.btnabout.Text = "Copyright";
            this.btnabout.UseVisualStyleBackColor = false;
            this.btnabout.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnl_footer
            // 
            this.pnl_footer.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.footer;
            this.pnl_footer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnl_footer.Location = new System.Drawing.Point(0, 369);
            this.pnl_footer.Name = "pnl_footer";
            this.pnl_footer.Size = new System.Drawing.Size(720, 31);
            this.pnl_footer.TabIndex = 5;
            this.pnl_footer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_footer_MouseDown);
            this.pnl_footer.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_footer_MouseMove);
            // 
            // frmChoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(720, 400);
            this.Controls.Add(this.pnl_footer);
            this.Controls.Add(this.btnabout);
            this.Controls.Add(this.pnl_header);
            this.Controls.Add(this.btnLDGM);
            this.Controls.Add(this.btnNPQ);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(720, 400);
            this.MinimumSize = new System.Drawing.Size(720, 400);
            this.Name = "frmChoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Choice";
            this.Load += new System.EventHandler(this.frmChoice_Load);
            this.pnl_header.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNPQ;
        private System.Windows.Forms.Button btnLDGM;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_mini;
        private System.Windows.Forms.Panel pnl_header;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btn_about;
        private System.Windows.Forms.Button btnabout;
        private System.Windows.Forms.Panel pnl_footer;

    }
}