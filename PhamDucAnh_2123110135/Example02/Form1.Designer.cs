namespace Example02
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

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
            components = new System.ComponentModel.Container();
            picChicken = new PictureBox();
            picEgg = new PictureBox();
            picBasket = new PictureBox();
            lblScore = new Label();
            lblLevel = new Label();
            gameTimer = new System.Windows.Forms.Timer(components);
            pnlMenu = new Panel();
            btnStart = new Button();
            lblResult = new Label();
            lblTitle = new Label();
            ((System.ComponentModel.ISupportInitialize)picChicken).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picEgg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBasket).BeginInit();
            pnlMenu.SuspendLayout();
            SuspendLayout();
            // 
            // picChicken
            // 
            picChicken.BackColor = Color.Transparent; // Đặt trong suốt
            picChicken.Image = Properties.Resources.chicken;
            picChicken.Location = new Point(450, 12);
            picChicken.Name = "picChicken";
            picChicken.Size = new Size(117, 123);
            picChicken.SizeMode = PictureBoxSizeMode.StretchImage;
            picChicken.TabIndex = 0;
            picChicken.TabStop = false;
            // 
            // picEgg
            // 
            picEgg.BackColor = Color.Transparent; // Đặt trong suốt
            picEgg.Image = Properties.Resources.egg;
            picEgg.Location = new Point(490, 169);
            picEgg.Name = "picEgg";
            picEgg.Size = new Size(35, 44);
            picEgg.SizeMode = PictureBoxSizeMode.StretchImage;
            picEgg.TabIndex = 1;
            picEgg.TabStop = false;
            // 
            // picBasket
            // 
            picBasket.BackColor = Color.Transparent; // Đặt trong suốt
            picBasket.Image = Properties.Resources.basket;
            picBasket.Location = new Point(395, 452);
            picBasket.Name = "picBasket";
            picBasket.Size = new Size(117, 96);
            picBasket.SizeMode = PictureBoxSizeMode.StretchImage;
            picBasket.TabIndex = 2;
            picBasket.TabStop = false;
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.BackColor = Color.Transparent; // Đặt trong suốt
            lblScore.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblScore.Location = new Point(129, 12);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(120, 29);
            lblScore.TabIndex = 3;
            lblScore.Text = "Score: 0";
            // 
            // lblLevel
            // 
            lblLevel.AutoSize = true;
            lblLevel.BackColor = Color.Transparent; // Đặt trong suốt
            lblLevel.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLevel.Location = new Point(14, 12);
            lblLevel.Name = "lblLevel";
            lblLevel.Size = new Size(109, 29);
            lblLevel.TabIndex = 4;
            lblLevel.Text = "Level: 1";
            // 
            // gameTimer
            // 
            gameTimer.Interval = 20;
            gameTimer.Tick += MainGameTimerEvent;
            // 
            // pnlMenu
            // 
            // CẤU HÌNH NỀN MENU BẰNG ẢNH
            pnlMenu.BackgroundImage = Properties.Resources.menu_bg;
            pnlMenu.BackgroundImageLayout = ImageLayout.Stretch;
            pnlMenu.Controls.Add(btnStart);
            pnlMenu.Controls.Add(lblResult);
            pnlMenu.Controls.Add(lblTitle);
            pnlMenu.Dock = DockStyle.Fill;
            pnlMenu.Location = new Point(0, 0);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(1102, 600);
            pnlMenu.TabIndex = 10;
            // 
            // btnStart
            // 
            // CẤU HÌNH NÚT BẮT ĐẦU BẰNG ẢNH
            btnStart.BackColor = Color.Transparent; // Nền trong suốt
            btnStart.BackgroundImage = Properties.Resources.btn_start;
            btnStart.BackgroundImageLayout = ImageLayout.Stretch; // Co giãn ảnh vừa nút
            btnStart.FlatAppearance.BorderSize = 0; // Xóa viền đen
            btnStart.FlatAppearance.MouseDownBackColor = Color.Transparent; // Xóa hiệu ứng nhấn
            btnStart.FlatAppearance.MouseOverBackColor = Color.Transparent; // Xóa hiệu ứng di chuột
            btnStart.FlatStyle = FlatStyle.Flat; // Chuyển sang phẳng
            btnStart.Font = new Font("Showcard Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnStart.ForeColor = Color.White;
            btnStart.Location = new Point(420, 300);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(260, 80); // Bạn có thể chỉnh lại size này cho vừa với ảnh nút của bạn
            btnStart.TabIndex = 2;
            btnStart.Text = ""; // Xóa chữ mặc định để hiện ảnh nút đẹp hơn
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;
            // 
            // lblResult
            // 
            lblResult.BackColor = Color.Transparent; // Nền trong suốt để hiện ảnh nền
            lblResult.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResult.ForeColor = Color.White; // Đổi màu chữ sang trắng cho dễ nhìn trên nền ảnh
            lblResult.Location = new Point(200, 220);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(700, 50);
            lblResult.TabIndex = 1;
            //lblResult.Text = "Chào mừng! Hãy bắt đầu chơi.";
            lblResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            //lblTitle.AutoSize = true;
            //lblTitle.BackColor = Color.Transparent; // Nền trong suốt
            //lblTitle.Font = new Font("Showcard Gothic", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            //lblTitle.ForeColor = Color.Yellow; // Đổi màu chữ sang Vàng cho nổi bật
            //lblTitle.Location = new Point(250, 100);
            //lblTitle.Name = "lblTitle";
            //lblTitle.Size = new Size(559, 98);
            //lblTitle.TabIndex = 0;
            //lblTitle.Text = "HỨNG TRỨNG";
            //lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1102, 600);
            Controls.Add(pnlMenu);
            Controls.Add(lblLevel);
            Controls.Add(lblScore);
            Controls.Add(picBasket);
            Controls.Add(picEgg);
            Controls.Add(picChicken);
            Name = "Form1";
            Text = "Game Hứng Trứng";
            KeyDown += KeyIsDown;
            KeyUp += KeyIsUp;
            ((System.ComponentModel.ISupportInitialize)picChicken).EndInit();
            ((System.ComponentModel.ISupportInitialize)picEgg).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBasket).EndInit();
            pnlMenu.ResumeLayout(false);
            pnlMenu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox picChicken;
        private System.Windows.Forms.PictureBox picEgg;
        private System.Windows.Forms.PictureBox picBasket;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnStart;
    }
}