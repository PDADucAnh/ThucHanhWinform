using System;
using System.Drawing;
using System.Media;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace Example02
{
    public partial class Form1 : Form
    {
        // --- KHAI BÁO BIẾN ---
        bool goLeft, goRight;
        int speedBasket = 12;
        int speedEgg = 5;
        int score = 0;
        int level = 1;
        int speedChicken = 5;

        Random rand = new Random();
        int eggDrift = 0;

        // --- CẤU HÌNH ÂM THANH ---
        [DllImport("winmm.dll")]
        private static extern long mciSendString(string strCommand, StringBuilder strReturn, int iReturnLength, IntPtr hwndCallback);

        SoundPlayer sndCatch;
        SoundPlayer sndLevelUp;
        SoundPlayer sndGameOver;

        public Form1()
        {
            InitializeComponent();

            this.DoubleBuffered = true;
            this.BackgroundImageLayout = ImageLayout.Stretch;

            // Làm trong suốt các thành phần game
            picChicken.BackColor = Color.Transparent;
            picEgg.BackColor = Color.Transparent;
            picBasket.BackColor = Color.Transparent;
            lblScore.BackColor = Color.Transparent;
            lblLevel.BackColor = Color.Transparent;

            // --- KHỞI TẠO ÂM THANH ---
            try
            {
                sndCatch = new SoundPlayer(Properties.Resources.sound_catch);
                sndLevelUp = new SoundPlayer(Properties.Resources.levelup);
                sndGameOver = new SoundPlayer(Properties.Resources.gameover);
            }
            catch { }

            SetupMenuVisuals();
            ShowMenu();
        }

        // --- HÀM CHƠI NHẠC NỀN ---
        private void PlayBackgroundMusic()
        {
            try
            {
                string command = "open \"music.mp3\" type mpegvideo alias BgMusic";
                mciSendString(command, null, 0, IntPtr.Zero);
                mciSendString("play BgMusic repeat", null, 0, IntPtr.Zero);
            }
            catch { }
        }

        private void StopBackgroundMusic()
        {
            try
            {
                mciSendString("stop BgMusic", null, 0, IntPtr.Zero);
                mciSendString("close BgMusic", null, 0, IntPtr.Zero);
            }
            catch { }
        }

        // --------------------------

        private void SetupMenuVisuals()
        {
            // 1. Cấu hình Nền và Nút
            try
            {
                pnlMenu.BackgroundImage = Properties.Resources.menu_bg;
                pnlMenu.BackgroundImageLayout = ImageLayout.Stretch;

                btnStart.BackgroundImage = Properties.Resources.btn_start;
                btnStart.BackgroundImageLayout = ImageLayout.Stretch;
                btnStart.Text = "";
                btnStart.FlatStyle = FlatStyle.Flat;
                btnStart.FlatAppearance.BorderSize = 0;
                btnStart.BackColor = Color.Transparent;
                btnStart.FlatAppearance.MouseDownBackColor = Color.Transparent;
                btnStart.FlatAppearance.MouseOverBackColor = Color.Transparent;
            }
            catch { }

            // 2. Cấu hình Tiêu đề (Game Title)
            lblTitle.BackColor = Color.Transparent;
            lblTitle.ForeColor = Color.Yellow; // Màu vàng nổi bật
            // Tạo viền bóng đổ giả bằng cách vẽ chồng (ở mức đơn giản ta chọn màu sáng)

            // 3. CẤU HÌNH BẢNG KẾT QUẢ (SỬA LẠI ĐỂ DỄ NHÌN HƠN)
            // Thay vì Transparent hoàn toàn, ta dùng màu Đen Mờ (Alpha = 150)
            // Điều này giúp chữ luôn đọc được bất kể hình nền là gì
            lblResult.BackColor = Color.FromArgb(180, 0, 0, 0); // Đen mờ 70%
            lblResult.ForeColor = Color.White; // Chữ trắng
            lblResult.Font = new Font("Arial", 16F, FontStyle.Bold);
            lblResult.TextAlign = ContentAlignment.MiddleCenter; // Căn giữa

            // Chỉnh lại kích thước label chứa kết quả cho rộng rãi
            lblResult.AutoSize = false;
            lblResult.Size = new Size(600, 100);
        }

        private Bitmap MakeImageTransparent(Image originalImage)
        {
            Bitmap bmp = new Bitmap(originalImage);
            bmp.MakeTransparent(Color.White);
            return bmp;
        }

        private void ShowMenu()
        {
            StopBackgroundMusic();
            gameTimer.Stop();
            pnlMenu.Visible = true;
            pnlMenu.BringToFront();

            // CĂN CHỈNH VỊ TRÍ CÁC THÀNH PHẦN TRÊN MENU
            int centerX = this.ClientSize.Width / 2;
            int centerY = this.ClientSize.Height / 2;

            // Tiêu đề nằm trên cao
            lblTitle.Left = centerX - (lblTitle.Width / 2);
            lblTitle.Top = 50;

            // Kết quả nằm giữa
            lblResult.Left = centerX - (lblResult.Width / 2);
            lblResult.Top = lblTitle.Bottom + 20; // Cách tiêu đề 20px

            // Nút chơi nằm dưới cùng
            btnStart.Left = centerX - (btnStart.Width / 2);
            btnStart.Top = lblResult.Bottom + 30; // Cách bảng điểm 30px
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            pnlMenu.Visible = false;
            ResetGame();
            this.Focus();
        }

        private void UpdateLevelVisuals()
        {
            lblLevel.Text = "Level: " + level;
            Image currentChickenImage = null;

            switch (level)
            {
                case 1:
                    try { this.BackgroundImage = Properties.Resources.bg1; } catch { }
                    try { currentChickenImage = Properties.Resources.chicken; } catch { }
                    break;
                default:
                    try { this.BackgroundImage = Properties.Resources.bg2; } catch { }
                    try { currentChickenImage = Properties.Resources.chicken2; } catch { }
                    break;
            }

            if (currentChickenImage != null)
            {
                picChicken.Image = MakeImageTransparent(currentChickenImage);
            }
        }

        private void MainGameTimerEvent(object sender, EventArgs e)
        {
            // 1. GIỎ
            if (goLeft && picBasket.Left > 0) picBasket.Left -= speedBasket;
            if (goRight && picBasket.Left + picBasket.Width < this.ClientSize.Width) picBasket.Left += speedBasket;

            // 2. GÀ
            picChicken.Left += speedChicken;
            if (picChicken.Left < 0 || picChicken.Left + picChicken.Width > this.ClientSize.Width)
            {
                speedChicken = -speedChicken;
            }
            else
            {
                if (rand.Next(0, 100) < 5) speedChicken = rand.Next(-10, 11);
            }

            // 3. TRỨNG
            picEgg.Top += speedEgg;
            picEgg.Left += eggDrift;

            if (picEgg.Left < 0) { picEgg.Left = 0; eggDrift = -eggDrift; }
            if (picEgg.Left + picEgg.Width > this.ClientSize.Width) { picEgg.Left = this.ClientSize.Width - picEgg.Width; eggDrift = -eggDrift; }

            // 4. THUA (GAMEOVER)
            if (picEgg.Top + picEgg.Height > this.ClientSize.Height)
            {
                GameOver();
            }

            // 5. ĂN ĐIỂM (HỨNG TRỨNG)
            if (picBasket.Bounds.IntersectsWith(picEgg.Bounds))
            {
                try { if (sndCatch != null) sndCatch.Play(); } catch { }

                score += 1;
                lblScore.Text = "Score: " + score;
                ResetEggPosition();
                CheckLevelUp();
            }
        }

        private void ResetEggPosition()
        {
            picEgg.Top = picChicken.Top + picChicken.Height;
            picEgg.Left = picChicken.Left + (picChicken.Width / 2) - (picEgg.Width / 2);
            eggDrift = rand.Next(-5, 6);
        }

        private void GameOver()
        {
            gameTimer.Stop();
            StopBackgroundMusic();
            try { if (sndGameOver != null) sndGameOver.Play(); } catch { }

            // Sửa nội dung hiển thị cho đẹp
            // Xuống dòng (\n) để tách chữ THUA RỒI và Điểm số
            lblResult.Text = "GAME OVER!\nĐiểm: " + score + "   |   Cấp độ: " + level;

            ShowMenu();
        }

        private void CheckLevelUp()
        {
            if (score % 10 == 0 && score > 0)
            {
                try { if (sndLevelUp != null) sndLevelUp.Play(); } catch { }

                level++;
                if (level > 5) level = 5;
                UpdateLevelVisuals();
                speedEgg += 2;
            }
        }

        private void ResetGame()
        {
            score = 0;
            level = 1;
            speedEgg = 5;
            speedChicken = 5;
            eggDrift = 0;
            goLeft = false;
            goRight = false;

            lblScore.Text = "Score: 0";

            try
            {
                picBasket.Image = MakeImageTransparent(Properties.Resources.basket);
                picEgg.Image = MakeImageTransparent(Properties.Resources.egg);
            }
            catch { }

            UpdateLevelVisuals();

            picChicken.Left = this.ClientSize.Width / 2;
            picBasket.Left = (this.ClientSize.Width - picBasket.Width) / 2;

            ResetEggPosition();
            PlayBackgroundMusic();
            gameTimer.Start();
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (pnlMenu.Visible == true) return;
            if (e.KeyCode == Keys.Left) goLeft = true;
            if (e.KeyCode == Keys.Right) goRight = true;
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) goLeft = false;
            if (e.KeyCode == Keys.Right) goRight = false;
        }
    }
}