using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;

namespace Example_01
{
    // LƯU Ý: Đã XÓA class InfoWindows ở đây vì nó đã nằm bên file InfoWindows.cs

    public partial class Form1 : Form // Hoặc Form3 tùy tên bạn đặt
    {
        // Sử dụng StartupPath để lưu file ngay tại thư mục chạy chương trình (tránh lỗi ổ D)
        string path = Application.StartupPath + "\\config.xml";

        public Form1()
        {
            InitializeComponent();
            this.Text = "Example 03: Save Config & Location";

            // Tự động gắn sự kiện (Code này rất tốt, không cần chỉnh Designer)
            this.Load += new EventHandler(Form1_Load);
            this.ResizeEnd += new EventHandler(Form1_ResizeEnd);
            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);
        }

        // --- CÁC HÀM XỬ LÝ ĐỌC/GHI ---
        public void Write(InfoWindows iw)
        {
            try
            {
                XmlSerializer writer = new XmlSerializer(typeof(InfoWindows));
                // Dùng khối 'using' để file tự động đóng sau khi ghi xong -> Rất chuẩn
                using (StreamWriter file = new StreamWriter(path))
                {
                    writer.Serialize(file, iw);
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi lưu file: " + ex.Message); }
        }

        public InfoWindows Read()
        {
            if (!File.Exists(path)) return null;
            try
            {
                XmlSerializer reader = new XmlSerializer(typeof(InfoWindows));
                using (StreamReader file = new StreamReader(path))
                {
                    return (InfoWindows)reader.Deserialize(file);
                }
            }
            catch { return null; }
        }

        // --- CÁC SỰ KIỆN ---

        private void Form1_Load(object sender, EventArgs e)
        {
            InfoWindows iw = Read();
            if (iw != null)
            {
                this.Width = iw.Width;
                this.Height = iw.Height;

                // Kiểm tra tọa độ để tránh form bay ra khỏi màn hình
                if (iw.Location.X >= 0 && iw.Location.Y >= 0)
                {
                    this.StartPosition = FormStartPosition.Manual;
                    this.Location = iw.Location;
                }
            }
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            // Lưu trạng thái ngay khi kéo thả xong
            SaveCurrentState();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Lưu trạng thái lần cuối khi tắt
            SaveCurrentState();
        }

        // Hàm phụ trợ để tránh viết lặp lại code lưu
        private void SaveCurrentState()
        {
            InfoWindows iw = new InfoWindows();

            if (this.WindowState == FormWindowState.Normal)
            {
                iw.Width = this.Size.Width;
                iw.Height = this.Size.Height;
                iw.Location = this.Location;
            }
            else
            {
                // Nếu form đang Maximize (phóng to), lưu kích thước lúc chưa phóng to
                iw.Width = this.RestoreBounds.Width;
                iw.Height = this.RestoreBounds.Height;
                iw.Location = this.RestoreBounds.Location;
            }

            Write(iw);
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}