using System;
using System.IO; // Cần thiết cho StreamWriter (Slide 74)
using System.Windows.Forms;

namespace Example_01
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        // Sự kiện nút Cộng: Cộng chuỗi kết quả vào Textbox (Slide 74)
        private void btCong_Click(object sender, EventArgs e)
        {
            int x = int.Parse(tbSoX.Text);
            int y = int.Parse(tbSoY.Text);
            int kq = x + y;

            // Nối thêm dòng kết quả mới vào cuối Textbox (dùng \r\n để xuống dòng)
            tbKetQua.Text = tbKetQua.Text + x.ToString() + " + " + y.ToString() + " = " + kq.ToString() + "\r\n";
        }

        // Sự kiện nút Nhân: Cộng chuỗi kết quả vào Textbox (Slide 74)
        private void btNhan_Click(object sender, EventArgs e)
        {
            int x = int.Parse(tbSoX.Text);
            int y = int.Parse(tbSoY.Text);
            int kq = x * y;

            // Nối thêm dòng kết quả
            tbKetQua.Text = tbKetQua.Text + x.ToString() + " * " + y.ToString() + " = " + kq.ToString() + "\r\n";
        }

        // Sự kiện nút Lưu: Ghi nội dung Textbox xuống file (Slide 74)
        private void btLuu_Click(object sender, EventArgs e)
        {
            // Tạo StreamWriter với tham số true (append mode - ghi nối tiếp)
            // Tên file "Caculator.txt" giữ nguyên theo Slide 74
            StreamWriter sw = new StreamWriter("Caculator.txt", true);
            sw.Write(tbKetQua.Text);
            sw.Close();

            MessageBox.Show("Đã lưu vào file Caculator.txt");
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}