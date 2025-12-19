using System;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Example_01
{
    public partial class Form15 : Form
    {
        // Biến đếm số lượng sinh viên
        int studentCount = 0;

        public Form15()
        {
            InitializeComponent();
        }

        // Sự kiện Form Load: Khởi tạo dữ liệu cho ComboBox
        private void Form15_Load(object sender, EventArgs e)
        {
            // Thêm danh sách khoa vào ComboBox (giống Slide 112)
            cbFaculty.Items.AddRange(new string[] {
                "Công nghệ thông tin",
                "Kế toán",
                "Cơ khí",
                "Điện",
                "Hóa"
            });
            // Chọn mặc định mục đầu tiên
            cbFaculty.SelectedIndex = 0;
            // Đặt mặc định ngày hiện tại
            dtpDob.Value = DateTime.Now;
        }

        // Sự kiện Click nút Thêm: Lấy thông tin và đưa vào ListBox
        private void btAdd_Click(object sender, EventArgs e)
        {
            // 1. Tăng biến đếm
            studentCount++;

            // 2. Lấy thông tin từ các điều khiển
            string name = tbName.Text;
            string dob = dtpDob.Value.ToString("dd/MM/yyyy"); // Định dạng ngày/tháng/năm
            string gender = rbMale.Checked ? "Nam" : "Nữ"; // Kiểm tra RadioButton
            string faculty = cbFaculty.SelectedItem.ToString();

            // 3. Thêm thông tin vào ListBox theo định dạng trong hình Slide 112
            // Dòng 1: Số thứ tự và Tên
            lbOutput.Items.Add(studentCount.ToString() + ". " + name);

            // Dòng 2: Giới tính (thụt đầu dòng)
            lbOutput.Items.Add("    -Giới tính: " + gender);

            // Dòng 3: Ngày sinh
            lbOutput.Items.Add("    -Ngày Sinh: " + dob);

            // Dòng 4: Khoa
            lbOutput.Items.Add("    -Khoa: " + faculty);

            // Tự động cuộn xuống dòng cuối cùng vừa thêm
            lbOutput.TopIndex = lbOutput.Items.Count - 1;
        }

        // Sự kiện Click nút Thoát
        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}