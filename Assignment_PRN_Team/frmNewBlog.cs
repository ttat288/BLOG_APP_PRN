using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_PRN_Team
{
    public partial class frmNewBlog : Form
    {
        public frmNewBlog()
        {
            InitializeComponent();
        }

        private void txtContent_Enter(object sender, EventArgs e)
        {
            if (txtContent.Text == "Enter Content Here")
            {
                txtContent.Text = "";
            }
        }

        private void txtTitle_Enter(object sender, EventArgs e)
        {
            if (txtTitle.Text == "Enter Title Here")
            {
                txtTitle.Text = "";
            }
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Thiết lập các thuộc tính của OpenFileDialog
            openFileDialog.Title = "Select Image";
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog.Multiselect = false;

            // Hiển thị hộp thoại chọn tệp và xử lý kết quả
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog.FileName;

                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                string fileExtension = Path.GetExtension(imagePath);

                // Kiểm tra nếu tệp không có phần mở rộng, hoặc nếu nó không thuộc các định dạng cho phép
                if (string.IsNullOrEmpty(fileExtension) || !IsValidImageExtension(fileExtension))
                {
                    MessageBox.Show("Vui lòng chọn một tệp hình ảnh hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Đặt tên mới cho tệp với phần mở rộng
                string savePath = Path.Combine("../../../../SECRET/coverImg", "se123" + fileExtension);

                // Hiển thị hình ảnh trong PictureBox
                pictureBox.ImageLocation = imagePath;

                // Lưu hình ảnh vào đường dẫn mới
                File.Copy(imagePath, savePath, true);

            }
        }
        private bool IsValidImageExtension(string extension)
        {
            string[] validExtensions = { ".jpg", ".jpeg", ".png", ".bmp" };
            return validExtensions.Contains(extension.ToLower());
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            Process.Start("../../../../RichTextEditor/bin/Debug/RichTextEditor.exe");
        }
    }
}
