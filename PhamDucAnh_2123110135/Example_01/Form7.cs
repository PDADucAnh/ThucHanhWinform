using System;
using System.Windows.Forms;

namespace Example_01
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        // Sự kiện nút Cộng (theo Slide 70)
        private void btCong_Click(object sender, EventArgs e)
        {
            // Lấy giá trị từ Textbox và ép kiểu sang int
            int x = int.Parse(tbSoX.Text);
            int y = int.Parse(tbSoY.Text);

            // Tính toán
            int kq = x + y;

            // Hiển thị kết quả ngược lại Textbox (phải chuyển sang String)
            tbKetQua.Text = kq.ToString();
        }

        // Sự kiện nút Nhân (theo Slide 70)
        private void btNhan_Click(object sender, EventArgs e)
        {
            int x = int.Parse(tbSoX.Text);
            int y = int.Parse(tbSoY.Text);
            int kq = x * y;
            tbKetQua.Text = kq.ToString();
        }

        // Sự kiện nút Thoát (theo Slide 70)
        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}