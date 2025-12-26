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
            // Thay Button bằng PictureBox
            picBtnStart = new PictureBox();
            lblResult = new Label();
            lblTitle = new Label();
            // Thêm 2 label mới cho giá trị điểm và level
            lblScoreValue = new Label();
            lblLevelValue = new Label();
            ((System.ComponentModel.ISupportInitialize)picChicken).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picEgg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBasket).BeginInit();
            pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBtnStart).BeginInit();
            SuspendLayout();
            // 
            // picChicken
            // 
            picChicken.BackColor = Color.Transparent;
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
            picEgg.BackColor = Color.Transparent;
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
            picBasket.BackColor = Color.Transparent;
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
            lblScore.BackColor = Color.Transparent;
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
            lblLevel.BackColor = Color.Transparent;
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
            pnlMenu.BackgroundImage = Properties.Resources.menu_bg;
            pnlMenu.BackgroundImageLayout = ImageLayout.Stretch;
            // Thêm các control mới vào panel
            pnlMenu.Controls.Add(lblLevelValue);
            pnlMenu.Controls.Add(lblScoreValue);
            pnlMenu.Controls.Add(picBtnStart);
            pnlMenu.Controls.Add(lblResult);
            pnlMenu.Controls.Add(lblTitle);
            pnlMenu.Dock = DockStyle.Fill;
            pnlMenu.Location = new Point(0, 0);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(1102, 600);
            pnlMenu.TabIndex = 10;
            // 
            // picBtnStart (Thay thế cho btnStart)
            // 
            picBtnStart.BackColor = Color.Transparent;
            picBtnStart.Image = Properties.Resources.btn_start;
            picBtnStart.Location = new Point(420, 300);
            picBtnStart.Name = "picBtnStart";
            picBtnStart.Size = new Size(260, 80);
            picBtnStart.SizeMode = PictureBoxSizeMode.StretchImage;
            picBtnStart.TabIndex = 2;
            picBtnStart.TabStop = false;
            // Gán sự kiện click
            picBtnStart.Click += picBtnStart_Click;
            // 
            // lblResult
            // 
            lblResult.BackColor = Color.Transparent;
            lblResult.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResult.ForeColor = Color.White;
            lblResult.Location = new Point(200, 220);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(700, 50);
            lblResult.TabIndex = 1;
            lblResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            lblScoreValue.AutoSize = true;
            lblScoreValue.BackColor = Color.Transparent;
            lblScoreValue.Font = new Font("Showcard Gothic", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblScoreValue.ForeColor = Color.White;
            lblScoreValue.Location = new Point(800, 250); // Vị trí tạm, sẽ được set lại trong code
            lblScoreValue.Name = "lblScoreValue";
            lblScoreValue.Size = new Size(43, 46);
            lblScoreValue.TabIndex = 5;
            lblScoreValue.Text = "0";
            // 
            // lblLevelValue (Label mới cho level)
            // 
            lblLevelValue.AutoSize = true;
            lblLevelValue.BackColor = Color.Transparent;
            lblLevelValue.Font = new Font("Showcard Gothic", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLevelValue.ForeColor = Color.White;
            lblLevelValue.Location = new Point(800, 300); // Vị trí tạm, sẽ được set lại trong code
            lblLevelValue.Name = "lblLevelValue";
            lblLevelValue.Size = new Size(43, 46);
            lblLevelValue.TabIndex = 6;
            lblLevelValue.Text = "1";
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
            ((System.ComponentModel.ISupportInitialize)picBtnStart).EndInit();
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
        // Đã xóa Button btnStart
        private System.Windows.Forms.PictureBox picBtnStart; // Thêm PictureBox mới
        private System.Windows.Forms.Label lblScoreValue; // Thêm Label điểm
        private System.Windows.Forms.Label lblLevelValue; // Thêm Label level
    }
}