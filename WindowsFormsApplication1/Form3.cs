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

    public partial class frmMatrix : Form
    {
        TextBox[,] txt;
        TextBox[] txtpx;
        int Hang, Cot;
        Thread t;

        public frmMatrix()
        {
            InitializeComponent();
        }
        public int countchar(string c,char t)
        {
            int dem = 0;
            for (int i = 0; i < c.Length; i++)
            {
                if (c[i] == t) dem++;
            }
                return dem;
        }            // Hàm xác định số lần xuất hiện kí tự bất kì có trong 1 chuỗi
        public bool checkmatrix(ref float[,] matrix)
        {
            bool check = true;                                              // Biến kiểm tra lỗi của mỗi textbox
            bool checki = true;                                             // Biến trả về khi 1 trong các textbox chứa kí tự lỗi
            for (int i = 0; i < Hang; i++)
                for (int j = 0; j < Cot; j++)
                {
                    try
                    {
                        int dem = countchar(txt[i,j].Text, '/');            // Xác định số lần xuất hiện kí tự '/'
                        string[] temp = txt[i, j].Text.Split('/');         // Tách chuỗi từ các textbox
                        matrix[i, j] = float.Parse(temp[0]);               
                        if (matrix[i, j] != 0.0F && dem != 0)               // Thực hiện tính toán khi người dùng nhập X/Y/Z hoặc x.y
                            for (int t = 1; t <= dem; t++ )
                            {
                                matrix[i, j] /= float.Parse(temp[t]);
                            }

                        if (matrix[i, j] < 0.0F || matrix[i, j] > 1.0F) throw new Exception();
                        check = true;
                    }                                                     // Bắt lỗi, và xử lí
                    catch (Exception ex)
                    {

                        check = false;
                        checki = false;
                    }
                   
                    if (check == false)                                                   // Đánh dấu textbox chứa kí tự lỗi
                    {
                        txt[i, j].BackColor = System.Drawing.Color.RosyBrown;
                        txt[i, j].ForeColor = System.Drawing.Color.White;
                    }
                    else
                    {
                        if (txt[i, j].BackColor == System.Drawing.Color.RosyBrown)
                        {
                            txt[i, j].BackColor = System.Drawing.SystemColors.Window;
                            txt[i, j].ForeColor = System.Drawing.Color.Black;
                        }
                    }
                }
            return checki;
        }       // Ham nhap va xu li mang 2 chieu
        public bool checkmang(ref float[] X)
        {
            bool check = false;                                                  // Biến kiểm tra lỗi của mỗi textbox
            bool checki = true;                                                  // Biến trả về khi 1 trong các textbox chứa kí tự lỗi
            for (int i = 0; i < Hang; i++)
            {
                try
                {
                    int dem = countchar(txtpx[i].Text, '/');
                    string[] temp = txtpx[i].Text.Split('/');                      // Tách chuỗi từ các textbox
                    X[i] = float.Parse(temp[0]);                                   // Thực hiện tính toán khi người dùng nhập X/Y/Z hoặc x.y
                    if (X[i] != 0.0F && dem != 0 )
                        for (int t = 1; t <= dem; t++ )
                        {
                            X[i] /= float.Parse(temp[t]);
                        }
                    
                    if (X[i] < 0.0f || X[i] > 1.0f) throw new Exception();
                    check = true;
                }                                                                           // Bắt lỗi, và xử lí
                catch (Exception ex)
                {

                    check = false;
                    checki = false;
                }
                if (check == false)                                                     // Đánh dấu textbox chứa kí tự lỗi
                {
                    txtpx[i].BackColor = System.Drawing.Color.RosyBrown;
                    txtpx[i].ForeColor = System.Drawing.Color.White;
                }
                else
                {
                    if (txtpx[i].BackColor == System.Drawing.Color.RosyBrown)
                    {
                        txtpx[i].BackColor = System.Drawing.SystemColors.Window;
                        txtpx[i].ForeColor = System.Drawing.Color.Black;
                    }
                }
            }
            return checki;
        }               // Ham nhap va xu li mang 1 chieu
        public void CreateArrayTextBox(ref TextBox[] txtpx, ref TextBox[,] txt)
        {
            int Top = 0;
            int Leftpx = 40;
            pnlMatrix.Controls.Clear();
            for (int i = 0; i < Hang; i++)
            {
                Label lblx = new Label();                       //tạo label x1, x2, x3,...xi
                lblx.Top = Top;                                 // cài đặt vị trí phía trên, khoảng cách và kích thước label
                lblx.Left = 5;
                lblx.Text = string.Format("x{0}", i);
                lblx.Size = new Size(25, 13);
                pnlMatrix.Controls.Add(lblx);                   // Add control của label vào pnlMatrix

                Label lblpx = new Label();
                lblpx.Top = (Hang + 2) * 25;                     //tạo label P(x1), P(x2), P(x3),... P(xi)
                lblpx.Left = Leftpx;                             // cài đặt vị trí phía trên, khoảng cách và kích thước label
                lblpx.Text = string.Format("P(x{0}): ", i);
                lblpx.Size = new Size(39, 13);
                pnlMatrix.Controls.Add(lblpx);                   // Add control của label vào pnlMatrix

                Leftpx += 50;
                Left = 40;
                for (int j = 0; j < Cot; j++)
                {
                    txt[i, j] = new TextBox();                   //tạo TextBox để nhập ma trận  
                    txt[i, j].Top = Top;                        // cài đặt vị trí phía trên, khoảng cách và kích thước label
                    txt[i, j].Left = Left;
                    txt[i, j].Size = new Size(40, 10);
                    pnlMatrix.Controls.Add(txt[i, j]);           // Add control của textbox vào pnlMatrix

                    Left += 45;
                }
                Top += 25;
            }

            Left = 50;
            for (int j = 0; j < Cot; j++)
            {
                Label lbly = new Label();                         //tạo label y1, y2, y3,...,yj
                lbly.Top = Hang * 25;                             // cài đặt vị trí phía trên, khoảng cách và kích thước label
                lbly.Left = Left;
                Left += 45;
                lbly.Text = string.Format("y{0}", j);
                lbly.Size = new Size(25, 13);
                pnlMatrix.Controls.Add(lbly);
            }
            Leftpx = 40;
            for (int k = 0; k < Hang; k++)
            {
                txtpx[k] = new TextBox();                          //tạo textbox để nhập p(x).
                txtpx[k].Name = string.Format("txtpx{0}", k);
                txtpx[k].Top = (Hang + 3) * 25;
                txtpx[k].Left = Leftpx;
                txtpx[k].Size = new Size(30, 10);
                pnlMatrix.Controls.Add(txtpx[k]);                   // Add control của mỗi txtpx vào pnlMatrix
                Leftpx += 50;
            }
            Label lblSx = new Label();
            lblSx.Text = string.Format("Nhập xác suất của truyền tin");
            lblSx.Top = (Hang + 1) * 25;
            lblSx.Left = 40;
            lblSx.Size = new Size(150, 13);
            pnlMatrix.Controls.Add(lblSx);
            txt[0, 0].Focus();                  // Sau khi tạo xong tất cả textbox mà người dùng cần, sẽ trỏ chuột về ô textbox đầu tiên.
        } // Hàm tạo ma trận textbox

        public void btnMake_Click(object sender, EventArgs e)
        {
            Hang = (int)num1.Value;                                  // Gán số hàng vào biến 
            Cot = (int)num2.Value;                                   // Gán số cột vào biến 
            txtpx = new TextBox[Hang];                               // Tạo mảng 1 chiều trỏ đến các textbox
            txt = new TextBox[Hang, Cot];                            // Tạo mảng 2 chiều trỏ đến các textbox
            System.Threading.Thread.Sleep(50);                       // Xử lí UX (trải nghiệm người dùng), tránh gây khó chịu cho người dùng
            this.Opacity = 0.0;
            if (Hang * Cot != 0) CreateArrayTextBox(ref txtpx, ref txt);// Không tồn tại ma trận 0 phần tử
            this.CenterToScreen();                                   // Đưa form vào giữa màn hình
            for (int i = 0; i <= 10000; i++) this.Opacity = i * 0.0001;
        }   // button "Tạo ma trận"
        private void btnTHienLai_Click(object sender, EventArgs e) 
        {
            pnlMatrix.Controls.Clear();
        } // Nút xóa
        private void btnTHien_Click(object sender, EventArgs e)
        {
            float[,] matrix = new float[Hang, Cot];              // Tạo mảng 2 chiều với số hàng x, số cột y
            float[] X = new float[Hang];                         // Tạo mảng 1 chiều lưu xác suất p(x)
            if ((checkmatrix(ref matrix) & checkmang(ref X)) == false)
                MessageBox.Show("Đã có lỗi xảy ra! Hãy kiểm tra lại dữ liệu đã nhập!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                int[,] B = new int[Hang, Cot];                 //Thực hiện phân hoạch vào mảng B
                for (int j = 0; j < Cot; j++)
                {
                    float max = 0;                              //Giá trị max
                    int maxi = 0;                               //Chỉ số vị trí max
                    for (int i = 0; i < Hang; i++)              // Tìm max va maxi
                        if (X[i] * matrix[i, j] > max)
                        {
                            max = X[i] * matrix[i, j];
                            maxi = i;
                        }
                    for (int i = 0; i < Cot; i++)                 //Lưu các giá trị vào mảng phân hoạch
                        if (B[maxi, i] == 0)
                        {
                            B[maxi, i] = j + 1;
                            break;
                        }
                }


                // Xử lí xuất lược đồ giải mã tối ưu
                string temp = "";
                for (int i = 0; i < Hang; i++)
                    if (B[i, 0] != 0)                           // Kiểm tra nếu phần tử đầu tiên là 0 thì không cần xuất dữ liệu
                    {
                        for (int j = 0; j < Cot; j++)
                            if (B[i, j] != 0) temp += "y" + Convert.ToSingle(B[i, j] - 1) + "  ";
                            else
                                temp += ("     ");
                        temp += ("Giai ma ve X" + i + "\n");
                    }
                MessageBox.Show(temp, "Lược đồ giải mã", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        } // Nút thực hiện
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        } // button thoát

        public void createfrmhdldgm(object data)
        {    
            Form frmg = new frmhd_ldgm();
            frmg.ShowDialog();

        }        // Hàm tạo frmhd_ldgm form hướng dẫn lược đồ giải mã

        private void frmMatrix_Load(object sender, EventArgs e)
        {
         
        }

        
        
        // Phía dưới là các hàm xử lí sự kiện khi từ bỏ border form mặc định
        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        } // Xử lí button Close

        private void btn_mini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        } // Xử lí button minimize

        private void btn_about_Click(object sender, EventArgs e)
        {
            for (int i = 10; i > 1; i--)
            {
                Thread.Sleep(20);
                this.Opacity = i * 0.1;
            }
            Form frmg = new frmLDGM_about();
            frmg.ShowDialog();
            for (int i = 1; i <= 10; i++)
            {
                Thread.Sleep(20);
                this.Opacity = i * 0.1;
            }
        } // Xử lí button about, Nút Scrumgroup

        // Xử lí sự kiện kéo thả và di chuyển form
        Point click;
        private void pnl7_MouseDown(object sender, MouseEventArgs e)
        {
            click = e.Location;
        }   // Lấy tọa độ chuột khi nhấn + giữ form, trong phạm vi pnl7
        private void pnl7_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - click.X;
                this.Top += e.Y - click.Y;
            }
        }   // Thay đổi tọa độ form khi di chuyển chuột
        private void btnhelp_Click(object sender, EventArgs e)
        {
            try
            {
                t.Abort();
            }
            catch(Exception ex)
            {
                t = new Thread(createfrmhdldgm);
            }
            t = new Thread(createfrmhdldgm);
            t.Start();
        }   // Nút tạo from hướng dẫn


    }
}
