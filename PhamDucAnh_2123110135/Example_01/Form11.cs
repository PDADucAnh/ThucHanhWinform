using System;
using System.Windows.Forms;

namespace Example_01
{
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        // Sự kiện Form Load: Thiết lập giá trị mặc định khi mở form
        private void Form11_Load(object sender, EventArgs e)
        {
            // Chọn mục thứ 3 (index = 2) trong danh sách ("Quản trị kinh doanh")
            cb_Faculty.SelectedIndex = 2;
        }

        // Sự kiện SelectedIndexChanged: Xảy ra ngay khi người dùng đổi lựa chọn trên ComboBox
        private void cb_Faculty_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cb_Faculty.SelectedIndex;
            // Hiển thị chỉ số (index) của mục được chọn
            tbDisplay.Text = "Bạn đã chọn khoa thứ: " + index.ToString();
        }

        // Sự kiện Click nút OK: Lấy giá trị text của mục được chọn
        private void btOK_Click(object sender, EventArgs e)
        {
            // Kiểm tra null để tránh lỗi nếu chưa có mục nào được chọn
            if (cb_Faculty.SelectedItem != null)
            {
                string item = cb_Faculty.SelectedItem.ToString();
                tbDisplay.Text = "Bạn là sinh viên khoa : " + item;
            }
        }

        // Nút Clear (dựa trên giao diện Slide 95)
        private void btClear_Click(object sender, EventArgs e)
        {
            tbDisplay.Clear();
        }
    }
}