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
    public partial class frmhd_ldgm : Form
    {
        public frmhd_ldgm()
        {
            InitializeComponent();
        }

        // Các nút lựa chọn 
        //Nút radiobutton1 được chọn thì chuyển sang tbp1
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
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                tbc.SelectedTab = tbp3;
            }
        }
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                tbc.SelectedTab = tbp4;
            }
        }
        // Bắt sự kiện khi người dùng nhấn nút từ bàn phím
        private void tbc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbc.SelectedTab == tbp1) radioButton1.Checked = true;
            else
                if (tbc.SelectedTab == tbp2) radioButton2.Checked = true;
                else
                    if (tbc.SelectedTab == tbp3) radioButton3.Checked = true;
                    else
                        radioButton4.Checked = true;
        }
        
        
        // Tạo khả năng di chuyển form
        Point click;
        private void frmhd_ldgm_MouseDown(object sender, MouseEventArgs e)
        {
            click = e.Location;
        }
        private void frmhd_ldgm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - click.X;
                this.Top += e.Y - click.Y;
            }
        }
        
     

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }   // Nút close X
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }   // Gợi ý thoát Esc

       
    }
}
