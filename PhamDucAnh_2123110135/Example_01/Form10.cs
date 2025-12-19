using System;
using System.Windows.Forms;

namespace Example_01
{
    public partial class Form10 : Form
    {
        // Khai báo các biến lưu trữ trạng thái theo Slide 83
        decimal memory = 0;         // Biến nhớ (cho MC, MR, MS...)
        decimal workingMemory = 0;  // Biến lưu số hạng đầu tiên
        string opr = "";            // Biến lưu toán tử (+, -, *, /)

        public Form10()
        {
            InitializeComponent();
        }

        // SỰ KIỆN DUY NHẤT XỬ LÝ CHO TẤT CẢ CÁC NÚT (Slide 82)
        private void Button_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender; // Lấy nút vừa được bấm
            string text = bt.Text;      // Lấy ký tự trên nút

            // 1. NHÓM SỐ (0-9) VÀ DẤU CHẤM (.) - Slide 84
            if ((char.IsDigit(text, 0) && text.Length == 1) || text == ".")
            {
                // Nếu đang hiển thị 0 (và không phải bấm dấu chấm), thì thay thế số 0
                if (txtDisplay.Text == "0" && text != ".")
                {
                    txtDisplay.Text = text;
                }
                else
                {
                    // Ngăn chặn nhập nhiều dấu chấm
                    if (text == "." && txtDisplay.Text.Contains(".")) return;

                    txtDisplay.Text += text;
                }
            }

            // 2. NHÓM TOÁN TỬ CƠ BẢN (+, -, *, /) - Slide 86
            else if (text == "+" || text == "-" || text == "*" || text == "/")
            {
                opr = text;
                workingMemory = decimal.Parse(txtDisplay.Text);
                txtDisplay.Clear();
            }

            // 3. XỬ LÝ DẤU BẰNG (=) - Slide 87
            else if (text == "=")
            {
                decimal secondValue = decimal.Parse(txtDisplay.Text);
                switch (opr)
                {
                    case "+":
                        txtDisplay.Text = (workingMemory + secondValue).ToString();
                        break;
                    case "-":
                        txtDisplay.Text = (workingMemory - secondValue).ToString();
                        break;
                    case "*":
                        txtDisplay.Text = (workingMemory * secondValue).ToString();
                        break;
                    case "/":
                        if (secondValue != 0)
                            txtDisplay.Text = (workingMemory / secondValue).ToString();
                        else
                            MessageBox.Show("Cannot divide by zero");
                        break;
                }
                // Reset toán tử sau khi tính xong
                opr = "";
            }

            // 4. CÁC PHÉP TOÁN NÂNG CAO (±, √, %, 1/x) - Slide 88
            else if (text == "±")
            {
                decimal currVal = decimal.Parse(txtDisplay.Text);
                txtDisplay.Text = (-currVal).ToString();
            }
            else if (text == "√")
            {
                decimal currVal = decimal.Parse(txtDisplay.Text);
                if (currVal >= 0)
                    txtDisplay.Text = ((decimal)Math.Sqrt((double)currVal)).ToString();
                else
                    MessageBox.Show("Invalid input");
            }
            else if (text == "%")
            {
                decimal currVal = decimal.Parse(txtDisplay.Text);
                txtDisplay.Text = (currVal / 100).ToString();
            }
            else if (text == "1/x")
            {
                decimal currVal = decimal.Parse(txtDisplay.Text);
                if (currVal != 0)
                    txtDisplay.Text = (1 / currVal).ToString();
                else
                    MessageBox.Show("Cannot divide by zero");
            }

            // 5. NÚT BACKSPACE (←) - Slide 89
            else if (text == "←")
            {
                if (txtDisplay.TextLength > 0)
                {
                    txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.TextLength - 1);
                }
                // Nếu xóa hết thì để lại số 0
                if (txtDisplay.TextLength == 0) txtDisplay.Text = "0";
            }

            // 6. NHÓM BỘ NHỚ (MC, MR, MS, M+, M-) - Slide 89, 90
            else if (text == "MC") memory = 0;
            else if (text == "MR") txtDisplay.Text = memory.ToString();
            else if (text == "MS")
            {
                memory = decimal.Parse(txtDisplay.Text);
                txtDisplay.Clear();
            }
            else if (text == "M+") memory += decimal.Parse(txtDisplay.Text);
            else if (text == "M-") memory -= decimal.Parse(txtDisplay.Text);

            // 7. NHÓM XÓA (C, CE) - Slide 90
            else if (text == "C")
            {
                workingMemory = 0;
                opr = "";
                txtDisplay.Text = "0";
            }
            else if (text == "CE")
            {
                txtDisplay.Text = "0";
            }
        }
    }
}