using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApplication1
{
    public partial class frmChoice : Form
    {
        public frmChoice()
        {
            InitializeComponent();
        }

        private void btnLDGM_Click(object sender, EventArgs e)
        {
            for (int i = 10; i >= 0; i--)
            {
                Thread.Sleep(20);
                this.Opacity = i * 0.1;         // Làm trong suốt form sau mỗi 20 milisecond
            }
            this.ShowInTaskbar = false;         // Ẩn icon ở thanh taskbar
            Form frm = new frmMatrix();         // Tọa form Lược đồ giải mã tối ưu
            frm.ShowDialog();                   // Hiện form
            this.ShowInTaskbar = true;          // Hiện icon ở thanh taskbar
            for (int i = 0; i <= 10; i++)
            {
                Thread.Sleep(20);
                this.Opacity = i * 0.1;
            } 
        }       // Lựa chọn Lược đồ giải mã
        private void btnNPQ_Click(object sender, EventArgs e)
        {
            for (int i = 10; i >= 0; i--)
            {
                Thread.Sleep(20);
                this.Opacity = i * 0.1;
            }
            this.ShowInTaskbar = false;
            Form frm = new frmNPQ();                // Tạo form Giải mã nguồn phổ quát
            frm.ShowDialog();
            this.ShowInTaskbar = true;
            for (int i = 0; i <= 10; i++)
            {
                Thread.Sleep(20);
                this.Opacity = i * 0.1;
            }           
        }       // Lựa chọn Giải mã Nguồn phổ quát
        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 10; i >= 0; i--)
            {
                Thread.Sleep(20);
                this.Opacity = i * 0.1;
            }
            Form frmg = new frmflashscreen(true);                  // Tọa form Thông tin Copyright
            frmg.ShowDialog();
            for (int i = 0; i <= 10; i++)
            {
                Thread.Sleep(20);
                this.Opacity = i * 0.1;
            }
        }       // Lựa chọn xem thông tin Copyright

        public void createfrmg(object e)
        {
            bool chk_about = (bool)e;
            Form frmg = new frmflashscreen(false);
            frmg.ShowDialog();
        }                   // Tạo 1 flashscreen
        public void Abort(Thread t)
        {
            t.Abort();
        }                       // Hàm ngắt 1 thread bất kì
        private void frmChoice_Load(object sender, EventArgs e)
        {
            Thread t = new Thread(createfrmg);
            t.Start(false);
            Thread.Sleep(4000);
            Abort(t);
        }

       // Design lại boderstyles: với các button: minimize, close, khả năng di chuyển form trên cửa sổ windown
        Point click;
        private void btn_mini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }               // Nút minimize -
        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }               // Nút Close X
        private void pnl_header_MouseDown(object sender, MouseEventArgs e)
        {
            click = e.Location;
        }      // lấy tọa độ hiện tại của chuột khi click + giữ chuột trong phạm vi của pnl_header
        private void pnl_header_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - click.X;
                this.Top += e.Y - click.Y;
            }
        }       // Thay đổi tọa độ của form theo tọa độ chuột
        private void pnl_footer_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - click.X;
                this.Top += e.Y - click.Y;
            }
        }
        private void pnl_footer_MouseDown(object sender, MouseEventArgs e)
        {
            click = e.Location;
        }

    }
}
