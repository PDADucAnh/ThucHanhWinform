namespace Example_01
{
    partial class Form10
    {
        private System.ComponentModel.IContainer components = null;

        // Khai báo các control
        private System.Windows.Forms.TextBox txtDisplay;

        // Khai báo nút bấm
        private System.Windows.Forms.Button btMC, btMR, btMS, btMPlus, btMMinus; // Hàng Memory
        private System.Windows.Forms.Button btBack, btCE, btC, btPlusMinus, btSqrt; // Hàng Edit
        private System.Windows.Forms.Button bt7, bt8, bt9, btDiv, btPercent; // Hàng 7-9
        private System.Windows.Forms.Button bt4, bt5, bt6, btMul, btRecip; // Hàng 4-6
        private System.Windows.Forms.Button bt1, bt2, bt3, btSub, btEqu; // Hàng 1-3
        private System.Windows.Forms.Button bt0, btDot, btPlus; // Hàng 0

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.txtDisplay = new System.Windows.Forms.TextBox();

            // Khởi tạo các nút
            this.btMC = new System.Windows.Forms.Button();
            this.btMR = new System.Windows.Forms.Button();
            this.btMS = new System.Windows.Forms.Button();
            this.btMPlus = new System.Windows.Forms.Button();
            this.btMMinus = new System.Windows.Forms.Button();

            this.btBack = new System.Windows.Forms.Button();
            this.btCE = new System.Windows.Forms.Button();
            this.btC = new System.Windows.Forms.Button();
            this.btPlusMinus = new System.Windows.Forms.Button();
            this.btSqrt = new System.Windows.Forms.Button();

            this.bt7 = new System.Windows.Forms.Button();
            this.bt8 = new System.Windows.Forms.Button();
            this.bt9 = new System.Windows.Forms.Button();
            this.btDiv = new System.Windows.Forms.Button();
            this.btPercent = new System.Windows.Forms.Button();

            this.bt4 = new System.Windows.Forms.Button();
            this.bt5 = new System.Windows.Forms.Button();
            this.bt6 = new System.Windows.Forms.Button();
            this.btMul = new System.Windows.Forms.Button();
            this.btRecip = new System.Windows.Forms.Button();

            this.bt1 = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.bt3 = new System.Windows.Forms.Button();
            this.btSub = new System.Windows.Forms.Button();
            this.btEqu = new System.Windows.Forms.Button();

            this.bt0 = new System.Windows.Forms.Button();
            this.btDot = new System.Windows.Forms.Button();
            this.btPlus = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // 
            // txtDisplay
            // 
            this.txtDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplay.Location = new System.Drawing.Point(12, 12);
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.ReadOnly = true;
            this.txtDisplay.Size = new System.Drawing.Size(294, 38);
            this.txtDisplay.TabIndex = 0;
            this.txtDisplay.Text = "0";
            this.txtDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;

            // Kích thước chung cho nút
            int btnWidth = 54;
            int btnHeight = 45;
            int startX = 12;
            int startY = 60;
            int gap = 6;

            // --- HÀNG 1: MEMORY (MC, MR, MS, M+, M-) ---
            SetupButton(this.btMC, "MC", startX, startY);
            SetupButton(this.btMR, "MR", startX + (btnWidth + gap) * 1, startY);
            SetupButton(this.btMS, "MS", startX + (btnWidth + gap) * 2, startY);
            SetupButton(this.btMPlus, "M+", startX + (btnWidth + gap) * 3, startY);
            SetupButton(this.btMMinus, "M-", startX + (btnWidth + gap) * 4, startY);

            // --- HÀNG 2: EDIT (←, CE, C, ±, √) ---
            int row2Y = startY + btnHeight + gap;
            SetupButton(this.btBack, "←", startX, row2Y);
            SetupButton(this.btCE, "CE", startX + (btnWidth + gap) * 1, row2Y);
            SetupButton(this.btC, "C", startX + (btnWidth + gap) * 2, row2Y);
            SetupButton(this.btPlusMinus, "±", startX + (btnWidth + gap) * 3, row2Y);
            SetupButton(this.btSqrt, "√", startX + (btnWidth + gap) * 4, row2Y);

            // --- HÀNG 3: 7, 8, 9, /, % ---
            int row3Y = row2Y + btnHeight + gap;
            SetupButton(this.bt7, "7", startX, row3Y);
            SetupButton(this.bt8, "8", startX + (btnWidth + gap) * 1, row3Y);
            SetupButton(this.bt9, "9", startX + (btnWidth + gap) * 2, row3Y);
            SetupButton(this.btDiv, "/", startX + (btnWidth + gap) * 3, row3Y);
            SetupButton(this.btPercent, "%", startX + (btnWidth + gap) * 4, row3Y);

            // --- HÀNG 4: 4, 5, 6, *, 1/x ---
            int row4Y = row3Y + btnHeight + gap;
            SetupButton(this.bt4, "4", startX, row4Y);
            SetupButton(this.bt5, "5", startX + (btnWidth + gap) * 1, row4Y);
            SetupButton(this.bt6, "6", startX + (btnWidth + gap) * 2, row4Y);
            SetupButton(this.btMul, "*", startX + (btnWidth + gap) * 3, row4Y);
            SetupButton(this.btRecip, "1/x", startX + (btnWidth + gap) * 4, row4Y);

            // --- HÀNG 5: 1, 2, 3, -, = ---
            int row5Y = row4Y + btnHeight + gap;
            SetupButton(this.bt1, "1", startX, row5Y);
            SetupButton(this.bt2, "2", startX + (btnWidth + gap) * 1, row5Y);
            SetupButton(this.bt3, "3", startX + (btnWidth + gap) * 2, row5Y);
            SetupButton(this.btSub, "-", startX + (btnWidth + gap) * 3, row5Y);

            // Nút Bằng (=) cao gấp đôi
            this.btEqu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btEqu.Location = new System.Drawing.Point(startX + (btnWidth + gap) * 4, row5Y);
            this.btEqu.Name = "btEqu";
            this.btEqu.Size = new System.Drawing.Size(btnWidth, btnHeight * 2 + gap);
            this.btEqu.TabIndex = 28;
            this.btEqu.Text = "=";
            this.btEqu.UseVisualStyleBackColor = true;
            this.btEqu.Click += new System.EventHandler(this.Button_Click);
            this.Controls.Add(this.btEqu);

            // --- HÀNG 6: 0, ., + ---
            int row6Y = row5Y + btnHeight + gap;
            // Nút 0 rộng gấp đôi
            this.bt0.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.bt0.Location = new System.Drawing.Point(startX, row6Y);
            this.bt0.Name = "bt0";
            this.bt0.Size = new System.Drawing.Size(btnWidth * 2 + gap, btnHeight);
            this.bt0.TabIndex = 26;
            this.bt0.Text = "0";
            this.bt0.UseVisualStyleBackColor = true;
            this.bt0.Click += new System.EventHandler(this.Button_Click);
            this.Controls.Add(this.bt0);

            SetupButton(this.btDot, ".", startX + (btnWidth + gap) * 2, row6Y);
            SetupButton(this.btPlus, "+", startX + (btnWidth + gap) * 3, row6Y);

            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 380);
            this.Controls.Add(this.txtDisplay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form10";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Advanced Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        // Hàm hỗ trợ thiết lập thuộc tính cho nút để giảm lặp code
        private void SetupButton(System.Windows.Forms.Button btn, string text, int x, int y)
        {
            btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            btn.Location = new System.Drawing.Point(x, y);
            btn.Name = "bt" + text.Replace("+", "Plus").Replace("-", "Minus").Replace("/", "Div").Replace("*", "Mul").Replace(".", "Dot").Replace("=", "Equ").Replace("1/x", "Recip").Replace("%", "Percent").Replace("√", "Sqrt").Replace("±", "PlusMinus").Replace("←", "Back");
            btn.Size = new System.Drawing.Size(54, 45);
            btn.TabIndex = 0;
            btn.Text = text;
            btn.UseVisualStyleBackColor = true;
            // GÁN SỰ KIỆN CLICK CHUNG (QUAN TRỌNG)
            btn.Click += new System.EventHandler(this.Button_Click);
            this.Controls.Add(btn);
        }

        #endregion
    }
}