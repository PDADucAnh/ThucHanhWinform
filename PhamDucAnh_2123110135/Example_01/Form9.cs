using System;
using System.Windows.Forms;

namespace Example_01
{
    public partial class Form9 : Form
    {
        // Khai báo biến lưu trữ giá trị và toán tử theo Slide 78
        decimal workingMemory = 0;
        string opr = "";

        public Form9()
        {
            InitializeComponent();
        }

        // Sự kiện click cho các nút số (0, 1, 2, 3) - Logic theo Slide 78
        // Nối thêm text của nút vào màn hình hiển thị
        private void bt0_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += bt0.Text;
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += bt1.Text;
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += bt2.Text;
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += bt3.Text;
        }

        // Sự kiện click nút Chấm (.) - Dựa trên giao diện Slide 76
        private void btDot_Click(object sender, EventArgs e)
        {
            // Kiểm tra để tránh nhập nhiều dấu chấm
            if (!tbDisplay.Text.Contains("."))
            {
                tbDisplay.Text += ".";
            }
        }

        // Sự kiện click nút Cộng (+) - Logic theo Slide 79
        private void btPlus_Click(object sender, EventArgs e)
        {
            opr = btPlus.Text; // Lưu toán tử "+"
            workingMemory = decimal.Parse(tbDisplay.Text); // Lưu giá trị hiện tại vào bộ nhớ
            tbDisplay.Clear(); // Xóa màn hình để nhập số thứ 2
        }

        // Sự kiện click nút Nhân (*) - Logic tương tự nút Cộng (được nhắc đến trong Slide 79)
        private void btMul_Click(object sender, EventArgs e)
        {
            opr = btMul.Text; // Lưu toán tử "*"
            workingMemory = decimal.Parse(tbDisplay.Text);
            tbDisplay.Clear();
        }

        // Sự kiện click nút Bằng (=) - Logic theo Slide 79
        private void btEquals_Click(object sender, EventArgs e)
        {
            decimal secondValue = decimal.Parse(tbDisplay.Text); // Lấy số thứ 2

            if (opr == "+")
            {
                tbDisplay.Text = (workingMemory + secondValue).ToString();
            }

            if (opr == "*")
            {
                tbDisplay.Text = (workingMemory * secondValue).ToString();
            }
        }
    }
}