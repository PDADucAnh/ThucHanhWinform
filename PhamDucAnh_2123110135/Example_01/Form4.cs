using System;
using System.Windows.Forms;
using System.IO; // Bắt buộc để dùng StreamWriter

namespace Example_01
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        // Sự kiện ghi lại phím bấm (Slide 46)
        private void Form4_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                // Mở file để ghi (Slide 46)
                // Tham số 'true' nghĩa là ghi nối tiếp (append), không xóa nội dung cũ
                // Bạn có thể đổi đường dẫn "D:\\..." thành "Key_Logger.txt" để lưu cạnh file exe
                StreamWriter sw = new StreamWriter(@"D:\Key_Logger.txt", true);

                // Ghi mã phím vào file
                sw.Write(e.KeyCode + " "); // Cộng thêm khoảng trắng để dễ nhìn

                // Đóng file ngay sau khi ghi (Slide 46)
                sw.Close();
            }
            catch (Exception ex)
            {
                // Bỏ qua lỗi hoặc hiện thông báo nếu cần
                // MessageBox.Show("Lỗi ghi file: " + ex.Message);
            }
        }

        // Sự kiện khi bấm nút OK (Slide 52)
        private void bt_OK_Click(object sender, EventArgs e)
        {
            // Slide 52 để trống hàm này, nhưng ta có thể thêm lệnh đóng Form
            // MessageBox.Show("Đã lưu log!");
            this.Close();
        }
    }
}