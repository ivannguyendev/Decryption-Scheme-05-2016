﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.IO;


namespace WindowsFormsApplication1
{
    public partial class frmNPQ : Form
    {
        int Phi, Num;       // khai báo Biến Num là số người dùng nhập
        int n;
        string nl = Environment.NewLine;    // tạo biến new line để xuống dòng
        Thread t;

        public frmNPQ()
        {
            InitializeComponent();
        }
       
        private void getPhi() /*Hàm này dùng để tính Phi*/
        {
            if (CheckTextBox() == true)
            {
                Num = Convert.ToInt32(tbNum.Text);          // chuyển giá trị trong textbox  thành kiểu Int
                Num = int.Parse(tbNum.Text);                
                Phi = Num + 1;
            }
        }
        private void tbNum_KeyPress(object sender, KeyPressEventArgs e)   // Ngăn người dùng nhập ký tự ở TextBox
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        private void tbNum_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Int32.Parse(tbNum.Text) >= 12) MessageBox.Show("Độ dài từ mã không nên quá 12, vì chương trình sẽ xử lí rất chậm!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {

            }
        }       // bắt sự kiện khi textbox thay đổi
        private bool CheckTextBox()
        {  // kiểm tra người nhập 
            if (tbNum.Text == "")
            {
                MessageBox.Show("Text Rỗng ", "Lỗi Giá trị ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    
        private void Form4_Load(object sender, EventArgs e)
        {
            dgv1.Hide();                    // Làm trống không gian hiển thị kết quả
            btnExport.Enabled = false;      // Chưa có kêt quả thì không được xuất file
            label2.Hide();                  // Ẩn gợi ý
        }

        private string ShowQi(int i)
        { 
            return "(" + (Num - i) + "/" + Num + "," + i + "/" + Num + " ) ";

        }// hiển thị Qi  

        private int getBNN(int Num, int b)
        {  

            return Combine(Num, b);
        }// TÌM số Biến  Ngẫu nhiên : giá trị của cột 1

        private int Combine(int a, int b)
        { 
            if (b == 0 || b == a)
            {
                return 1;
            }
            else
            {
                return (Combine(a - 1, b) + Combine(a - 1, b - 1));  //đệ quy
            }
        }//  tổ hợp chỉnh b của a or aCb
        private string InitTuma(int h)
        { // khởi tạo từ mã đầu tiên để đảo BIT
            /*{
             *      trong quá trình tính toán kết quả thường xuyên có dạng   111 hay 1111 hay 111111
             *      hàm này chèn số 0 vào trước nó để đủ bit  =>            0111  hay 0001111 hay 00111111
             * 
             * } 
             */
            string A = "";
            string strAdd = "";
            if (h == 0)
            {
                for (int i = 0; i < Num; i++)
                {
                    A += '1';

                }
                return A;
            }
            else if (h == Num)
            {
                for (int i = 0; i < Num; i++)
                {
                    A += '0';

                }
                return A;
            }
            else
            {
                for (int i = 0; i < Num - h; i++)
                {
                    strAdd += '0';

                }
                A = strAdd.PadRight(h + (Num - h), '1');
                return replaceBit(ReverseString(A));

            }

            // add 0.... vào bên trái

        }
        private string GotoTail(int i)
        /*      Yêu cầu : nếu mã là 000111111 thì làm sao dịch chuyển mọi số 0 về đuôi của mã (gotoTail), mỗi lần mã thay đổi thì lưu lại 1 lần
         *      Thuật Toán : xét từ bên phải qua nếu bên phải > bên trái thì đổi chổ , lưu kết quả lại , ngay sau đó quay lại vị trí ban đầu và chạy tiếp
         *                      cứ như vậy cho đến khi dừng là khi mọi số 0 đều qua bên phải.
         */
        { // hàm  0 chạy tới đuôi 

            string S = "";
            string strA = InitTuma(i);  // tạo mã gốc (mã đầu tiên của 1 hàng)
            char[] strC;
            char[] arrB = strA.ToCharArray();   // Copy strA qua cho arrB sau khi đã chuyển từ string qua array

            reGo:   // xét lại mã 
            for (int j = 1; j < Num; j++)
            {

                if (arrB[Num - j - 1] < arrB[Num - j])
                {

                    //swap(arrB[Num - j - 1], arrB[Num - j ]);  // swap gián tiếp ko chạy dc !!
                    char temp;
                    temp = arrB[Num - j - 1];               // swap trực tiếp
                    arrB[Num - j - 1] = arrB[Num - j];      // 
                    arrB[Num - j] = temp;                   //
                    strC = arrB;
                    S += new string(strC) + nl;   // chuyển array qua string rồi + dồn vào S có nl(newline)
                    goto reGo;  // quay lại vị trí ban đầu
                }
            }

            return S;
        }

        public static string ReverseString(string s)   // đảo mã vidu : 00011111 => 11111000
        {
            char[] arr = s.ToCharArray();       //  khởi tạo 1 array mới có giá trị bằng array mà string s đã chuyển đổi qua
            Array.Reverse(arr);                 //  Đảo mã
            return new string(arr);             //  chuyển array về string 
        }
        public static string replaceBit(string A) /*Nếu bit là 0 thì thay = 1 nếu 1 thì thay = 0*/
        {   // thay thế Bit
            A = A.Replace('1', '2');
            A = A.Replace('0', '1');
            A = A.Replace('2', '0');
            return A;
        }
        private double XacSuat(int k, int h)
        {  //  tính xác suất 
            double K = (double)k;
            double H = (double)h;
            if (k == 0)
            {
                return (double)0.0000000000000;
            }
            else if (h == 0)
            {
                return (double)1.00000000000000;
            }
            else
            {
                return (-(K / Num) * Math.Log(K / Num, 2) - (H / Num) * Math.Log(H / Num, 2));
            }
        }
        private string ResTuma(int rev) /*Chyển đổi 1 số nguyên sang Nhị phân*/
        { // trả về của từ mã cột cuối cùng  , chuyển đổi từ int qua binary
            string tranBin;

            tranBin = (Convert.ToString(rev, 2));  // rev : số nguyên cần chuyển
            tranBin.PadRight(3, '0');

            return tranBin;
        }
        private string TumaSau(int i)
        { // từ mã cột 4 
            string A = "";
            string B = "";
            string C = "";

            B = ResTuma(i - 1);

            if (B.Length < ResTuma(Num).Length)
            {
                B = B.PadLeft(B.Length + (ResTuma(Num).Length - B.Length), '0');
            }

            for (int j = 0; j < getBNN(Num, i - 1); j++)
            {


                C = ResTuma(j).PadLeft(ResTuma(j).Length + (ResTuma(getBNN(Num, i - 1)).Length - ResTuma(j).Length), '0');  // add '0' vào đầu mỗi từ mã 



                A += B + "  " + C + nl;                             // add dồn lại lưu vào A

            }
            return A;
        }


        private void btnQuit_Click(object sender, EventArgs e)  // Nút THoát
        {
            this.Close();

        }
        private void btnStart_Click(object sender, EventArgs e)  // Nút thực hiện
        {
            dgv1.Show();
            dgv1.Rows.Clear();
            btnExport.Enabled = true;
            label2.Show();
            try
            {
                getPhi();
                string A = "";
                string B = "";
                A = A.PadLeft(ResTuma(Num).Length, '0');
                B = ResTuma(Num);
                for (int i = Num; i >= 0; i--)                                                              // add data lên từng Cells
                {                                                                                           //        
                    dgv1.Rows.Add(1);                                                              //
                    dgv1.Rows[Num - i].Cells[0].Value = ShowQi(i);                                 //            
                    dgv1.Rows[Num - i].Cells[1].Value = getBNN(Num, Num - i);                      //        
                    dgv1.Rows[Num - i].Cells[3].Value = XacSuat(Num - i, i).ToString();
                    dgv1.Rows[Num - i].Cells[4].Value = TumaSau(Num - i + 1);
                    dgv1.Rows[0].Cells[4].Value = A;

                }
                dgv1.Rows.Add();
                dgv1.Rows[Num].Cells[4].Value = B;  // vì nếu add cùng với vòng for có i (values = 0) => error (div 0)nên đặt ngoài

                for (int i = 0; i <= Num; i++)
                {  // Add data lên cột 2

                    dgv1.Rows.Add();
                    dgv1.Rows[i].Cells[2].Value = InitTuma(i) + nl + GotoTail(i);
                }

                //------------------------------------END MAIN-----------------------------------------

            }
            catch (Exception ex)
            {  // bắt Error
                MessageBox.Show("Lỗi : Sai kiểu dữ liệu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }  
        private void btnRefresh_Click(object sender, EventArgs e)  
        {
            dgv1.Rows.Clear();
        } // Nút Xóa
        private void btnExport_Click(object sender, System.EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Documents (*.xls)|*.xls";
            sfd.FileName = "BảngMãHóaNguồnPhổQuátm=" + Num;
            if (sfd.ShowDialog() == DialogResult.OK)
            {

                getData(dgv1, sfd.FileName);

            }
        } // Nút Export ra file Excell
        private void btn_about_Click(object sender, EventArgs e)
        {

            for (int i = 10; i > 1; i--)
            {
                Thread.Sleep(20);
                this.Opacity = i * 0.1;
            }
            Form frmg = new frmNPQ_about();
            frmg.ShowDialog();
            for (int i = 1; i <= 10; i++)
            {
                Thread.Sleep(20);
                this.Opacity = i * 0.1;

            } // Xử lí button about, khi tự tạo thêm button
        }   // NÚt xem thông tin Scrumgroup


        private void getData(DataGridView dGV, string filename) /*gan gia tri vao bien de chuan bi Print*/
        {
            string stOutput = "\n\nVi so luong day nguon va Tu Ma nhieu nen duoc ghi o duoi !!! \n\n\n";
            // Export titles:
            string sHeaders = "";
            string temp = "";
            string temp4 = "";
            for (int j = 0; j < dGV.Columns.Count; j++)
                sHeaders = sHeaders.ToString() + Convert.ToString(dGV.Columns[j].HeaderText) + "\t"; // tab title qua
            stOutput += sHeaders + "\n";
            // Export data. Vì cot 2 va 4 co so luong tu ma lon nen phai format lai bang sau khi Export
            for (int i = 0; i <= Num; i++)
            {
                string strDataToEx = "";
                for (int j = 0; j <= 4; j++)
                {
                    if (dgv1.Rows[i].Cells[j].Value == null)
                    {  // kiem tra Neu Null thi khong lam gi
                        // do nothing =))
                    }
                    else if (j == 2)
                    {
                        temp = "Si" + "\n";

                        for (int k = 0; k <= Num; k++)
                        {
                            temp += Convert.ToString(dgv1.Rows[k].Cells[0].Value) + "\n";
                            temp += Convert.ToString(dgv1.Rows[k].Cells[2].Value) + "\n";
                        }
                    }
                    else if (j == 1)
                    {
                        strDataToEx += Convert.ToString(dgv1.Rows[i].Cells[j].Value) + "\t\t";

                    }
                    else if (j == 4)
                    {
                        temp4 = "wi" + "\n";

                        for (int k = 0; k <= Num; k++)
                        {
                            temp4 += Convert.ToString(dgv1.Rows[k].Cells[0].Value) + "\n";
                            temp4 += Convert.ToString(dgv1.Rows[k].Cells[4].Value) + "\n";
                        }
                    }
                    else
                    {
                        strDataToEx += Convert.ToString(dgv1.Rows[i].Cells[j].Value) + "\t";
                    }

                }
                stOutput += strDataToEx + "\n";
            }
            stOutput += "\n\n\n\n" + temp + "\n\n\n\n" + temp4;
            Encoding utf16 = Encoding.GetEncoding(1254);
            byte[] output = utf16.GetBytes(stOutput);
            FileStream fs = new FileStream(filename, FileMode.Create);  // su dung Filestream 
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write(output, 0, output.Length);
            bw.Flush();
            bw.Close();
            fs.Close();
        }
        private void dgv1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)// Hiển thị values lên messageBox thay vì tooltip => get all values
        {
            try
            {
                if (dgv1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    MessageBox.Show(dgv1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(), "Cells Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không có gì để xem !!", "Cảnh Báo" + ex.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


 

        // Design lại boderstyles: với các button: minimize, close, khả năng di chuyển form trên cửa sổ windown
        Point click;
        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }       // Nút close X
        private void btn_mini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }       // Nút minimize -
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
       
        // Tạo form hướng dẫn
        public void createfrmhdnpq(object data)
        {
            Form frmg = new frmdhnpq();
            frmg.ShowDialog();

        }
        private void btnhelp_Click(object sender, EventArgs e)
        {
            try
            {
                t.Abort();
            }
            catch (Exception ex)
            {
                t = new Thread(createfrmhdnpq);
            }
            t = new Thread(createfrmhdnpq);
            t.Start();
        }       // Nút Helps
    }


}

