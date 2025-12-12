using System;
using System.Drawing; // Để dùng Point, Size
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;

namespace Example_01
{
    // --- KHẮC PHỤC LỖI Ở ĐÂY ---
    // Bạn phải định nghĩa class InfoWindows nằm TRONG namespace nhưng NGOÀI class Form1
    public class InfoWindows
    {
        public int Width { get; set; }
        public int Height { get; set; }
        // Lưu ý: Slide 28 chưa có Location, nhưng Slide 38 sẽ cần. 
        // Ta cứ để tạm Width/Height theo đúng bài Slide 28.
    }
    // ---------------------------

    public partial class Form1 : Form
    {
        // Đường dẫn file lưu cấu hình
        string path = Application.StartupPath + "\\form.xml";

        public Form1()
        {
            InitializeComponent();
        }

        // Hàm Ghi
        public void Write(InfoWindows iw)
        {
            try
            {
                XmlSerializer writer = new XmlSerializer(typeof(InfoWindows));
                using (StreamWriter file = new StreamWriter(path))
                {
                    writer.Serialize(file, iw);
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi ghi: " + ex.Message); }
        }

        // Hàm Đọc
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

        // Sự kiện ResizeEnd (Slide 22-29)
        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            // 1. Lấy kích thước
            int width = this.Size.Width;
            int height = this.Size.Height;

            // 2. Hiện lên tiêu đề
            this.Text = width.ToString() + " - " + height.ToString();

            // 3. Lưu xuống file
            InfoWindows iw = new InfoWindows(); // Máy tính sẽ tìm thấy class này ở phía trên
            iw.Width = width;
            iw.Height = height;
            Write(iw);
        }

        // Sự kiện Load (Slide 34)
        private void Form1_Load(object sender, EventArgs e)
        {
            InfoWindows iw = Read();
            if (iw != null)
            {
                this.Width = iw.Width;
                this.Height = iw.Height;
                this.Text = iw.Width.ToString() + " - " + iw.Height.ToString();
            }
        }
    }
}