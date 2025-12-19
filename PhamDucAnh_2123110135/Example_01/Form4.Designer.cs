namespace Example_01
{
    partial class Form4
    {
        private System.ComponentModel.IContainer components = null;

        // Khai báo nút bấm bt_OK (Slide 51)
        private System.Windows.Forms.Button bt_OK;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.bt_OK = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // 
            // bt_OK (Thiết lập thuộc tính theo Slide 51)
            // 
            this.bt_OK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_OK.Location = new System.Drawing.Point(208, 302); // Vị trí giả định giống slide
            this.bt_OK.Name = "bt_OK";
            this.bt_OK.Size = new System.Drawing.Size(80, 25);
            this.bt_OK.TabIndex = 0;
            this.bt_OK.Text = "OK";
            this.bt_OK.UseVisualStyleBackColor = true;
            // Đăng ký sự kiện Click cho nút (Slide 51)
            this.bt_OK.Click += new System.EventHandler(this.bt_OK_Click);

            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 350);
            this.Controls.Add(this.bt_OK); // Thêm nút vào Form
            this.Name = "Form4";
            this.Text = "Form4 - Key Logger";

            // --- QUAN TRỌNG NHẤT (Slide 45) ---
            // Phải bật cái này lên thì Form mới bắt được phím bấm
            this.KeyPreview = true;
            this.ShowInTaskbar = false; // Ẩn khỏi thanh Taskbar (Slide 45)

            // Đăng ký sự kiện KeyUp (Slide 45)
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form4_KeyUp);

            this.ResumeLayout(false);
        }

        #endregion
    }
}