using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;

namespace Example_01
{
    public partial class Form2 : Form
    {
        // --- SỬA LỖI TẠI ĐÂY ---
        // Khai báo đường dẫn file lưu trữ (Theo Slide 34)
        string path = @"D:\form.xml";
        // -----------------------

        public Form2()
        {
            InitializeComponent();
        }

        public void Write(InfoWindows iw)
        {
            try
            {
                XmlSerializer writer = new XmlSerializer(typeof(InfoWindows));
                // Biến 'path' giờ đã được hiểu nhờ dòng khai báo trên
                StreamWriter file = new StreamWriter(path);
                writer.Serialize(file, iw);
                file.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi file: " + ex.Message);
            }
        }

        public InfoWindows Read()
        {
            try
            {
                // Kiểm tra file có tồn tại không trước khi đọc
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

        private void Example02_ResizeEnd(object sender, EventArgs e)
        {
            InfoWindows iw = new InfoWindows();
            iw.Width = this.Size.Width;
            iw.Height = this.Size.Height;

            Write(iw);
            this.Text = $"Saved: {iw.Width}x{iw.Height}";
        }

        private void Example02_Load(object sender, EventArgs e)
        {
            InfoWindows iw = Read();

            if (iw != null)
            {
                this.Width = iw.Width;
                this.Height = iw.Height;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Form2_ResizeEnd(object sender, EventArgs e)
        {

        }
    }
}