using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{

    public partial class frmLDGM_about : Form
    {
        public frmLDGM_about()
        {
            InitializeComponent();

        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
            pnl2.Hide();                                                // Ẩn thông tin mô tả
        }

        public void btn_next_Click(object sender, EventArgs e)
        {
            pnl2.Show();                                                // Hiện thông tin mô tả
        }               // Nút next

        private void btn_pre_Click(object sender, EventArgs e)
        {
            pnl2.Hide();
        }               // nút trở về

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }               // Gợi ý thoát
       
       // Tạo sự kiện kéo thả form
        Point click;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            click = e.Location;
        }  
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - click.X;
                this.Top += e.Y - click.Y;
            }
        }

        private void pnl_header_MouseDown(object sender, MouseEventArgs e)
        {
            click = e.Location;
        }
        private void pnl_header_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - click.X;
                this.Top += e.Y - click.Y;
            }
        }


    }
}
