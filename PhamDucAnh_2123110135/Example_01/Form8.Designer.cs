namespace Example_01
{
    partial class Form8
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // Khai báo Controls theo danh sách Slide 73
        private System.Windows.Forms.TextBox tbSoX;
        private System.Windows.Forms.TextBox tbSoY;
        private System.Windows.Forms.TextBox tbKetQua;
        private System.Windows.Forms.Button btCong;
        private System.Windows.Forms.Button btNhan;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btLuu;

        // Labels
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
            this.lblSoX = new System.Windows.Forms.Label();
            this.tbSoX = new System.Windows.Forms.TextBox();
            this.lblSoY = new System.Windows.Forms.Label();
            this.tbSoY = new System.Windows.Forms.TextBox();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.tbKetQua = new System.Windows.Forms.TextBox();
            this.btCong = new System.Windows.Forms.Button();
            this.btNhan = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.btLuu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSoX
            // 
            this.lblSoX.AutoSize = true;
            this.lblSoX.Location = new System.Drawing.Point(20, 20);
            this.lblSoX.Name = "lblSoX";
            this.lblSoX.Size = new System.Drawing.Size(29, 13);
            this.lblSoX.TabIndex = 0;
            this.lblSoX.Text = "Số x";
            // 
            // tbSoX
            // 
            // Anchor Top|Left|Right để giãn chiều ngang
            this.tbSoX.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSoX.Location = new System.Drawing.Point(80, 17);
            this.tbSoX.Name = "tbSoX";
            this.tbSoX.Size = new System.Drawing.Size(480, 20);
            this.tbSoX.TabIndex = 1;
            // 
            // lblSoY
            // 
            this.lblSoY.AutoSize = true;
            this.lblSoY.Location = new System.Drawing.Point(20, 50);
            this.lblSoY.Name = "lblSoY";
            this.lblSoY.Size = new System.Drawing.Size(29, 13);
            this.lblSoY.TabIndex = 2;
            this.lblSoY.Text = "Số y";
            // 
            // tbSoY
            // 
            this.tbSoY.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSoY.Location = new System.Drawing.Point(80, 47);
            this.tbSoY.Name = "tbSoY";
            this.tbSoY.Size = new System.Drawing.Size(480, 20);
            this.tbSoY.TabIndex = 3;
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Location = new System.Drawing.Point(20, 80);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(44, 13);
            this.lblKetQua.TabIndex = 4;
            this.lblKetQua.Text = "Kết quả";
            // 
            // tbKetQua
            // 
            // QUAN TRỌNG: Multiline = true để hiển thị nhiều dòng (Slide 71)
            this.tbKetQua.Multiline = true;
            this.tbKetQua.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            // QUAN TRỌNG: Anchor cả 4 phía để giãn theo form (Slide 73)
            this.tbKetQua.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbKetQua.Location = new System.Drawing.Point(80, 80);
            this.tbKetQua.Name = "tbKetQua";
            this.tbKetQua.Size = new System.Drawing.Size(480, 200);
            this.tbKetQua.TabIndex = 5;
            // 
            // btLuu
            // 
            // Anchor Bottom|Left (Slide 73)
            this.btLuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btLuu.Location = new System.Drawing.Point(80, 300);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(75, 30);
            this.btLuu.TabIndex = 9;
            this.btLuu.Text = "Lưu";
            this.btLuu.UseVisualStyleBackColor = true;
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
            // 
            // btCong
            // 
            this.btCong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btCong.Location = new System.Drawing.Point(323, 300);
            this.btCong.Name = "btCong";
            this.btCong.Size = new System.Drawing.Size(75, 30);
            this.btCong.TabIndex = 6;
            this.btCong.Text = "Cộng";
            this.btCong.UseVisualStyleBackColor = true;
            this.btCong.Click += new System.EventHandler(this.btCong_Click);
            // 
            // btNhan
            // 
            this.btNhan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btNhan.Location = new System.Drawing.Point(404, 300);
            this.btNhan.Name = "btNhan";
            this.btNhan.Size = new System.Drawing.Size(75, 30);
            this.btNhan.TabIndex = 7;
            this.btNhan.Text = "Nhân";
            this.btNhan.UseVisualStyleBackColor = true;
            this.btNhan.Click += new System.EventHandler(this.btNhan_Click);
            // 
            // btThoat
            // 
            // Anchor Bottom|Right (Slide 73)
            this.btThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btThoat.Location = new System.Drawing.Point(485, 300);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(75, 30);
            this.btThoat.TabIndex = 8;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 350);
            this.Controls.Add(this.btLuu);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btNhan);
            this.Controls.Add(this.btCong);
            this.Controls.Add(this.tbKetQua);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.tbSoY);
            this.Controls.Add(this.lblSoY);
            this.Controls.Add(this.tbSoX);
            this.Controls.Add(this.lblSoX);
            this.Name = "Form8";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen; // Slide 73
            this.Text = "Caculator"; // Slide 73 (giữ nguyên typo theo slide)
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}