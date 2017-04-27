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
    public partial class frmflashscreen : Form
    {
        public frmflashscreen()
        {
            InitializeComponent();
        }

        public frmflashscreen(bool check)
        {
            InitializeComponent();
            if(check==false)            // Không được thoát form khi chưa cho phép
            {
                this.AcceptButton = null;
                button1.Hide();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }       // Nút gợi ý thoát Esc

        // Tạo khả năng di chuyển form
        Point click;
        private void frmflashscreen_MouseDown(object sender, MouseEventArgs e)
        {
            click = e.Location;
        }
        private void frmflashscreen_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - click.X;
                this.Top += e.Y - click.Y;
            }
        }
        
    }
}
