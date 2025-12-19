using System;
using System.ComponentModel; // Cần cho CancelEventArgs
using System.Windows.Forms;

namespace Example_01
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        // Sự kiện KeyPress: Chỉ cho phép nhập số và phím điều khiển (như Backspace)
        // Logic dựa trên Slide 65 (Khắc phục lỗi không xóa được ở Slide 64)
        private void tbYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Nếu không phải phím điều khiển (như Backspace) VÀ không phải là số
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Ngăn không cho nhập (Handled = true)
                e.Handled = true;
            }
        }

        // Sự kiện Validating: Kiểm tra giá trị sau khi người dùng nhập xong và rời đi
        // Logic dựa trên Slide 66
        private void tbYear_Validating(object sender, CancelEventArgs e)
        {
            // Lưu ý: Cần kiểm tra chuỗi rỗng để tránh lỗi khi Parse nếu textbox trống
            if (string.IsNullOrEmpty(tbYear.Text)) return;

            int year = int.Parse(tbYear.Text);

            // Nếu năm lớn hơn 2000 thì báo lỗi (Cancel = true giữ focus tại textbox)
            if (year > 2000)
            {
                e.Cancel = true;
                MessageBox.Show("Year must be <= 2000 (Example Validation)"); // Thông báo thêm để dễ hiểu
            }
        }
    }
}