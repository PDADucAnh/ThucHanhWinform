using System;
using System.Windows.Forms;

namespace Example_01
{
    public partial class Form16 : Form
    {
        public Form16()
        {
            InitializeComponent();
        }

        // 1. Nút [>] : Chuyển 1 bài hát từ trái sang phải
        private void btSelect_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có mục nào đang được chọn không
            if (lbSong.SelectedIndex != -1)
            {
                string song = lbSong.SelectedItem.ToString();
                lbFavorite.Items.Add(song);                 // Thêm vào danh sách yêu thích
                lbSong.Items.RemoveAt(lbSong.SelectedIndex); // Xóa khỏi danh sách gốc
            }
        }

        // 2. Nút [<] : Chuyển 1 bài hát từ phải về trái (Ngược lại logic trên)
        private void btDeselect_Click(object sender, EventArgs e)
        {
            if (lbFavorite.SelectedIndex != -1)
            {
                string song = lbFavorite.SelectedItem.ToString();
                lbSong.Items.Add(song);
                lbFavorite.Items.RemoveAt(lbFavorite.SelectedIndex);
            }
        }

        // 3. Nút [>>] : Chuyển TẤT CẢ từ trái sang phải
        private void btSelectAll_Click(object sender, EventArgs e)
        {
            // Duyệt từ cuối danh sách về đầu để tránh lỗi index khi xóa
            int count = lbSong.Items.Count;
            for (int i = count - 1; i >= 0; i--)
            {
                string song = lbSong.Items[i].ToString();
                lbFavorite.Items.Add(song);
                lbSong.Items.RemoveAt(i);
            }
        }

        // 4. Nút [<<] : Chuyển TẤT CẢ từ phải về trái
        private void btDeselectAll_Click(object sender, EventArgs e)
        {
            int count = lbFavorite.Items.Count;
            for (int i = count - 1; i >= 0; i--)
            {
                string song = lbFavorite.Items[i].ToString();
                lbSong.Items.Add(song);
                lbFavorite.Items.RemoveAt(i);
            }
        }

        // 5. Sự kiện DoubleClick cho ListBox Trái
        private void lbSong_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // Lấy vị trí index dựa trên tọa độ chuột (Cách xử lý nâng cao trong Slide 119)
            int index = this.lbSong.IndexFromPoint(e.Location);

            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                string song = lbSong.Items[index].ToString();
                lbFavorite.Items.Add(song);
                lbSong.Items.RemoveAt(index);
            }
        }

        // 6. Sự kiện DoubleClick cho ListBox Phải (Chức năng tương tự ngược lại)
        private void lbFavorite_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.lbFavorite.IndexFromPoint(e.Location);

            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                string song = lbFavorite.Items[index].ToString();
                lbSong.Items.Add(song);
                lbFavorite.Items.RemoveAt(index);
            }
        }
    }
}