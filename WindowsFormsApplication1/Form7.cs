using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmNPQ_about : Form
    {
        public frmNPQ_about()
        {
            InitializeComponent();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            pnl2.Show();
        }       // Nút >  hiện trang tiếp theo 
        private void btn_pre_Click(object sender, EventArgs e)
        {
            pnl2.Hide();
        }       // Nút <   hiện trang trước
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }        // Nút gợi ý thoát Esc

        private void frmNPQ_about_Load(object sender, EventArgs e)
        {
            pnl2.Hide();
        }


        // Tạo khả năng di chuyển form
        Point click;
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
       
    }
}
