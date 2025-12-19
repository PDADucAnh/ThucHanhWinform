using Microsoft.VisualBasic;
using System;
using System.Windows.Forms;

namespace Example_01
{
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }

        // Sự kiện khi nhấn nút OK
        // Chức năng: Đặt tiêu đề Form thành ngày dạng đầy đủ (Ví dụ: Saturday, September 30, 2017)
        private void btOK_Click(object sender, EventArgs e)
        {
            this.Text = dtpDate.Value.ToLongDateString();
        }

        // Sự kiện khi thay đổi giá trị trên DateTimePicker
        // Chức năng: Đặt tiêu đề Form thành ngày dạng ngắn (Ví dụ: 30/09/2017)
        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            this.Text = dtpDate.Value.ToShortDateString();
        }
    }
}