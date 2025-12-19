namespace Example_01
{
    partial class Form7
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // Khai báo các biến Control (Theo Slide 69)
        private System.Windows.Forms.TextBox tbSoX;
        private System.Windows.Forms.TextBox tbSoY;
        private System.Windows.Forms.TextBox tbKetQua;
        private System.Windows.Forms.Button btCong;
        private System.Windows.Forms.Button btNhan;
        private System.Windows.Forms.Button btThoat;

        // Khai báo thêm Label để hiển thị chữ (giống hình Slide 68)
        private System.Windows.Forms.Label lblSoX;
        private System.Windows.Forms.Label lblSoY;
        private System.Windows.Forms.Label lblKetQua;

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
            this.tbSoX = new System.Windows.Forms.TextBox();
            this.tbSoY = new System.Windows.Forms.TextBox();
            this.tbKetQua = new System.Windows.Forms.TextBox();
            this.btCong = new System.Windows.Forms.Button();
            this.btNhan = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.lblSoX = new System.Windows.Forms.Label();
            this.lblSoY = new System.Windows.Forms.Label();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // 
            // lblSoX
            // 
            this.lblSoX.AutoSize = true;
            this.lblSoX.Location = new System.Drawing.Point(30, 30);
            this.lblSoX.Name = "lblSoX";
            this.lblSoX.Size = new System.Drawing.Size(29, 13);
            this.lblSoX.TabIndex = 0;
            this.lblSoX.Text = "Số x";

            // 
            // tbSoX
            // 
            this.tbSoX.Location = new System.Drawing.Point(100, 27);
            this.tbSoX.Name = "tbSoX";
            this.tbSoX.Size = new System.Drawing.Size(250, 20);
            this.tbSoX.TabIndex = 1;

            // 
            // lblSoY
            // 
            this.lblSoY.AutoSize = true;
            this.lblSoY.Location = new System.Drawing.Point(30, 70);
            this.lblSoY.Name = "lblSoY";
            this.lblSoY.Size = new System.Drawing.Size(29, 13);
            this.lblSoY.TabIndex = 2;
            this.lblSoY.Text = "Số y";

            // 
            // tbSoY
            // 
            this.tbSoY.Location = new System.Drawing.Point(100, 67);
            this.tbSoY.Name = "tbSoY";
            this.tbSoY.Size = new System.Drawing.Size(250, 20);
            this.tbSoY.TabIndex = 3;

            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Location = new System.Drawing.Point(30, 110);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(44, 13);
            this.lblKetQua.TabIndex = 4;
            this.lblKetQua.Text = "Kết quả";

            // 
            // tbKetQua
            // 
            this.tbKetQua.Location = new System.Drawing.Point(100, 107);
            this.tbKetQua.Name = "tbKetQua";
            this.tbKetQua.Size = new System.Drawing.Size(250, 20);
            this.tbKetQua.TabIndex = 5;
            this.tbKetQua.ReadOnly = true; // Kết quả thường không cho người dùng sửa

            // 
            // btCong
            // 
            this.btCong.Location = new System.Drawing.Point(40, 150);
            this.btCong.Name = "btCong";
            this.btCong.Size = new System.Drawing.Size(75, 30);
            this.btCong.TabIndex = 6;
            this.btCong.Text = "Cộng";
            this.btCong.UseVisualStyleBackColor = true;
            this.btCong.Click += new System.EventHandler(this.btCong_Click);

            // 
            // btNhan
            // 
            this.btNhan.Location = new System.Drawing.Point(140, 150);
            this.btNhan.Name = "btNhan";
            this.btNhan.Size = new System.Drawing.Size(75, 30);
            this.btNhan.TabIndex = 7;
            this.btNhan.Text = "Nhân";
            this.btNhan.UseVisualStyleBackColor = true;
            this.btNhan.Click += new System.EventHandler(this.btNhan_Click);

            // 
            // btThoat
            // 
            this.btThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btThoat.Location = new System.Drawing.Point(275, 150);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(75, 30);
            this.btThoat.TabIndex = 8;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);

            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 211);

            // Cấu hình thuộc tính Form theo Slide 69
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog; // Slide 69
            this.MaximizeBox = false; // Slide 69
            this.MinimizeBox = false; // Slide 69
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen; // Slide 69
            this.Text = "Caculator"; // Slide 69 (Giữ nguyên typo "Caculator" theo slide)

            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btNhan);
            this.Controls.Add(this.btCong);
            this.Controls.Add(this.tbKetQua);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.tbSoY);
            this.Controls.Add(this.lblSoY);
            this.Controls.Add(this.tbSoX);
            this.Controls.Add(this.lblSoX);
            this.Name = "Form7";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}