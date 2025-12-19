using System;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Example_01
{
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        // Sự kiện Click nút Tính tiền: Xử lý logic chuỗi và hiển thị kết quả
        private void btRun_Click(object sender, EventArgs e)
        {
            string msg = null;
            int disc = 0;

            // Kiểm tra RadioButton Nam
            if (rbMale.Checked == true)
                msg += "Ông ";

            // Kiểm tra RadioButton Nữ
            if (rbFemale.Checked == true)
                msg += "Bà ";

            // Kiểm tra CheckBox Giảm giá
            if (ckDiscount.Checked == true)
            {
                // Trong Slide 106 code mẫu gán cứng disc = 5. 
                // Tuy nhiên để đúng thực tế UI, ta lấy giá trị từ TextBox
                int.TryParse(tbDiscount.Text, out disc);
            }

            // Hiển thị kết quả ra Textbox lớn
            tbResult.Text = msg + tbName.Text + " được giảm " + disc.ToString() + "%" + "\r\n";
        }

        // Sự kiện CheckedChanged: Bật/Tắt TextBox giảm giá dựa trên CheckBox
        private void ckDiscount_CheckedChanged(object sender, EventArgs e)
        {
            if (ckDiscount.Checked == true)
                tbDiscount.Enabled = true;
            else
                tbDiscount.Enabled = false;
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}