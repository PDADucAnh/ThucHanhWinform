using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example_01
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        // Sự kiện khi click vào nút bt_OK (tương ứng Slide 56)
        private void bt_OK_Click(object sender, EventArgs e)
        {
            // Thay đổi tiêu đề của Form
            this.Text = "Article for Button";

            // Thay đổi kích thước của Form thành 500x500
            this.Size = new Size(500, 500);
        }
    }
}
