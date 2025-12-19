using System;
using System.Collections; // Cần thiết để dùng ArrayList
using System.Windows.Forms;

namespace Example_01
{
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        // Hàm tạo dữ liệu mẫu theo Slide 100
        public ArrayList GetData()
        {
            ArrayList lst = new ArrayList();

            Faculty f = new Faculty();
            f.Id = "K01";
            f.Name = "Công nghệ thông tin";
            f.Quantity = 1200;
            lst.Add(f);

            f = new Faculty();
            f.Id = "K02";
            f.Name = "Quản trị kinh doanh";
            f.Quantity = 4200;
            lst.Add(f);

            f = new Faculty();
            f.Id = "K03";
            f.Name = "Kế toán tài chính";
            f.Quantity = 5200;
            lst.Add(f);

            return lst;
        }

        // Sự kiện Load Form: Gán dữ liệu vào ComboBox
        private void Form12_Load(object sender, EventArgs e)
        {
            ArrayList lst = GetData();
            cb_Faculty.DataSource = lst;
            cb_Faculty.DisplayMember = "Name"; // Hiển thị Tên khoa lên ComboBox
        }

        // Sự kiện khi thay đổi lựa chọn: Hiển thị Mã Khoa (Id)
        private void cb_Faculty_SelectedValueChanged(object sender, EventArgs e)
        {
            // Kiểm tra SelectedValue khác null để tránh lỗi khi mới khởi chạy
            if (cb_Faculty.SelectedValue != null)
            {
                // Mẹo: Đặt ValueMember thành "Id" để lấy mã khoa
                cb_Faculty.ValueMember = "Id";
                string id = cb_Faculty.SelectedValue.ToString();
                tbDisplay.Text = "Bạn đã chọn khoa có mã : " + id;
            }
        }

        // Sự kiện nhấn nút OK: Hiển thị Tên Khoa (Name)
        private void btOK_Click(object sender, EventArgs e)
        {
            if (cb_Faculty.SelectedValue != null)
            {
                // Mẹo: Đổi ValueMember thành "Name" để lấy tên khoa
                cb_Faculty.ValueMember = "Name";
                string name = cb_Faculty.SelectedValue.ToString();
                tbDisplay.Text = "Bạn đã chọn khoa có tên : " + name;
            }
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            tbDisplay.Clear();
        }
    }
}