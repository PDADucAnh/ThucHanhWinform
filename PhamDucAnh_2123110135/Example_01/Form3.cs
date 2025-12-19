using System;
using System.Windows.Forms;
using System.IO;                // Thư viện đọc ghi file
using System.Xml.Serialization; // Thư viện XML
using System.Drawing;           // Thư viện xử lý tọa độ Point

namespace Example_01
{
    public partial class Form3 : Form
    {
        // Đường dẫn file lưu cấu hình (Slide 39)
        string path = @"D:\form.xml";

        public Form3()
        {
            InitializeComponent();
        }

        // Hàm GHI dữ liệu ra file
        public void Write(InfoWindows iw)
        {
            try
            {
                XmlSerializer writer = new XmlSerializer(typeof(InfoWindows));
                StreamWriter file = new StreamWriter(path);
                writer.Serialize(file, iw);
                file.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi file: " + ex.Message);
            }
        }

        // Hàm ĐỌC dữ liệu từ file
        public InfoWindows Read()
        {
            try
            {
                if (!File.Exists(path)) return null;

                XmlSerializer reader = new XmlSerializer(typeof(InfoWindows));
                StreamReader file = new StreamReader(path);
                InfoWindows iw = (InfoWindows)reader.Deserialize(file);
                file.Close();
                return iw;
            }
            catch (Exception)
            {
                return null;
            }
        }

        // Sự kiện 1: Khi Form bắt đầu chạy (Load) -> Khôi phục kích thước và vị trí
        private void Form3_Load(object sender, EventArgs e)
        {
            InfoWindows iw = Read();
            if (iw != null)
            {
                this.Width = iw.Width;
                this.Height = iw.Height;
                this.Location = iw.Location; // Khôi phục vị trí (Slide 39)
            }
        }

        // Sự kiện 2: Khi Form đang đóng (FormClosing) -> Lưu lại thông tin
        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            InfoWindows iw = new InfoWindows();
            iw.Width = this.Size.Width;
            iw.Height = this.Size.Height;
            iw.Location = this.Location; // Lưu vị trí hiện tại (Slide 39)

            Write(iw);
        }
    }
}