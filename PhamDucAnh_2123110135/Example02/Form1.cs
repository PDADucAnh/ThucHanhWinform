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

        // Biến trạng thái để biết đang ở màn hình nào (0: Start, 1: Game Over, 2: Victory)
        int menuState = 0;

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

            // Làm trong suốt các label điểm số trên bảng
            lblScoreValue.BackColor = Color.Transparent;
            lblLevelValue.BackColor = Color.Transparent;

            // --- KHỞI TẠO ÂM THANH ---
            try
            {
                sndCatch = new SoundPlayer(Properties.Resources.sound_catch);
                sndLevelUp = new SoundPlayer(Properties.Resources.levelup);
                sndGameOver = new SoundPlayer(Properties.Resources.gameover);
            }
            catch { }

            // Cài đặt màn hình Bắt đầu (Start Menu)
            SetupStartMenuVisuals();
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
        // --- CÁC HÀM THIẾT LẬP GIAO DIỆN MENU ---

        // 1. Màn hình Bắt Đầu (Lúc mới mở game)
        private void SetupStartMenuVisuals()
        {
            menuState = 0;
            try
            {
                pnlMenu.BackgroundImage = Properties.Resources.menu_bg;
                // Dùng PictureBox làm nút, không bị viền
                picBtnStart.Image = Properties.Resources.btn_start;
                // Ẩn các thành phần không cần thiết
                lblResult.Visible = false;
                lblScoreValue.Visible = false;
                lblLevelValue.Visible = false;
                lblTitle.Visible = true;
            }
            catch { }
        }

        // 2. Màn hình Thua Cuộc (Game Over)
        private void SetupGameOverVisuals()
        {
            menuState = 1;
            try
            {
                pnlMenu.BackgroundImage = Properties.Resources.thuagame;
                // Dùng nút chơi lại màu đỏ
                picBtnStart.Image = Properties.Resources.choilai1;

                // Hiện các label điểm số
                lblScoreValue.Visible = true;
                lblLevelValue.Visible = true;

                // Ẩn tiêu đề và label kết quả cũ
                lblTitle.Visible = false;
                lblResult.Visible = false;
            }
            catch { }
        }

        // 3. Màn hình Chiến Thắng (Victory)
        private void SetupVictoryMenuVisuals()
        {
            menuState = 2;
            try
            {
                pnlMenu.BackgroundImage = Properties.Resources.win;
                // Dùng nút chơi lại màu xanh
                picBtnStart.Image = Properties.Resources.choilai;

                // Ẩn hết các label
                lblResult.Visible = false;
                lblScoreValue.Visible = false;
                lblLevelValue.Visible = false;
                lblTitle.Visible = false;
            }
            catch { }
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

            int centerX = this.ClientSize.Width / 2;
            int h = this.ClientSize.Height;
            int w = this.ClientSize.Width;

            // --- CĂN CHỈNH VỊ TRÍ ---

            // Căn giữa nút chơi (PictureBox)
            picBtnStart.Left = centerX - (picBtnStart.Width / 2);
            // Đặt vị trí nút thấp xuống
            picBtnStart.Top = (int)(h * 0.6) - (picBtnStart.Height / 2);

            if (menuState == 1) // GAME OVER
            {
                // Cập nhật giá trị điểm và level
                lblScoreValue.Text = score.ToString();
                lblLevelValue.Text = level.ToString();

                // Căn chỉnh vị trí 2 label số liệu vào đúng dòng trên bảng gỗ
                // Các tỉ lệ này được ước lượng từ ảnh mẫu, bạn có thể tinh chỉnh thêm
                lblScoreValue.Left = (int)(w * 0.74); // Cách lề trái 74%
                lblScoreValue.Top = (int)(h * 0.41);  // Cách lề trên 41%

                lblLevelValue.Left = (int)(w * 0.74); // Cách lề trái 74%
                lblLevelValue.Top = (int)(h * 0.49);  // Cách lề trên 49%
            }
            else if (menuState == 0 && lblTitle.Visible) // START MENU
            {
                lblTitle.Left = centerX - (lblTitle.Width / 2);
                lblTitle.Top = 50;
            }
        }

        // Sự kiện Click cho PictureBox nút chơi
        private void picBtnStart_Click(object sender, EventArgs e)
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

            // GỌI GIAO DIỆN GAME OVER
            SetupGameOverVisuals();
            ShowMenu();
        }

        private void VictoryGame()
        {
            gameTimer.Stop();
            StopBackgroundMusic();

            // GỌI GIAO DIỆN CHIẾN THẮNG
            SetupVictoryMenuVisuals();
            ShowMenu();
        }

        private void CheckLevelUp()
        {
            if (score % 10 == 0 && score > 0)
            {
                try { if (sndLevelUp != null) sndLevelUp.Play(); } catch { }

                level++;
                if (level > 5)
                {
                    level = 5;
                    VictoryGame(); // Thắng game
                }
                else
                {
                    UpdateLevelVisuals();
                    speedEgg += 2;
                }
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