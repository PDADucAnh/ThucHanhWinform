using System;
using System.Drawing; // Bắt buộc có để dùng Point

namespace Example_01 // Phải trùng namespace với Form của bạn
{
    // Class chứa dữ liệu cấu hình
    // Đặt ở đây để dùng chung cho Form1, Form2, Form3...
    public class InfoWindows
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public Point Location { get; set; }
    }
}