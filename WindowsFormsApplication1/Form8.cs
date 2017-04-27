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
    public partial class frmdhnpq : Form
    {
        public frmdhnpq()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }        // Nút close X
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }           //Nút gợi ý thoát Esc


        // Lựa chọn
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                tbc.SelectedTab = tbp1;
            }
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                tbc.SelectedTab = tbp2;
            }
        }
        // Bắt sự kiện khi người dùng chọn từ bàn phím
        private void tbc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbc.SelectedTab == tbp1) radioButton1.Checked = true;
            else
                if (tbc.SelectedTab == tbp2) radioButton2.Checked = true;
        }

        // Tạo khả năng di chuyển form
        Point click;
        private void frmdhnpq_MouseDown(object sender, MouseEventArgs e)
        {
            click = e.Location;
        }
        private void frmdhnpq_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - click.X;
                this.Top += e.Y - click.Y;
            }
        }
        
    }
}
