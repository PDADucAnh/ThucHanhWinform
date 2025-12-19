namespace Example_01
{
    partial class Form5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // Khai báo nút bấm (Slide 55)
        private System.Windows.Forms.Button bt_OK;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bt_OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_OK
            // 
            // Thiết lập thuộc tính Anchor: Bottom, Right (Slide 55)
            // Giúp nút luôn bám ở góc dưới phải khi form thay đổi kích thước
            this.bt_OK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_OK.Location = new System.Drawing.Point(208, 302); // Vị trí mẫu theo slide
            this.bt_OK.Name = "bt_OK";
            this.bt_OK.Size = new System.Drawing.Size(80, 25);
            this.bt_OK.TabIndex = 0;
            this.bt_OK.Text = "OK";
            this.bt_OK.UseVisualStyleBackColor = true;
            // Gán sự kiện Click (Slide 55)
            this.bt_OK.Click += new System.EventHandler(this.bt_OK_Click);
            // 
            // FormExample06
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            // Kích thước ban đầu (nhỏ hơn kích thước sau khi click)
            this.ClientSize = new System.Drawing.Size(300, 350);
            this.Controls.Add(this.bt_OK);
            this.Name = "FormExample06";
            this.Text = "Form1"; // Tiêu đề ban đầu
            this.ResumeLayout(false);

        }

        #endregion
    }
}