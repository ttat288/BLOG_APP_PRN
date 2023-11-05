using BlogObject;
using BlogObject.Models;
using BlogWinApp;
using DataAccess.Repository;
using Krypton.Toolkit;
using Microsoft.VisualBasic.ApplicationServices;
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
using System.Windows.Threading;

namespace Assignment_PRN_Team
{
    public partial class frmNewBlog : Form
    {
        IUserRepository userRepository = new UserRepository();
        IPostRepository postRepository = new PostRepository();
        Account account;
        PostTbl post = new PostTbl();

        public frmNewBlog()
        {
            InitializeComponent();
            account = userRepository.remember();
            majorSelector.SelectedIndex = 0;
        }

        private void txtContent_Enter(object sender, EventArgs e)
        {
            if (txtContent.Text == "Enter Content Here")
            {
                txtContent.Text = "";
            }
        }

        private bool IsValidImageExtension(string extension)
        {
            string[] validExtensions = { ".jpg", ".jpeg", ".png", ".bmp" };
            return validExtensions.Contains(extension.ToLower());
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {


        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {
        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtContent_TextChanged(object sender, EventArgs e)
        {
        }

        private void lblContent_Click(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        string cover_image;
        private void pictureBox_Click_1(object sender, EventArgs e)
        {
            post = new PostTbl();
            post.PostId = GenerateUniquePostId(account.id);

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
                string savePath = Path.Combine("../../../../SECRET/coverImg", $"{post.PostId}" + fileExtension);
                cover_image = savePath;

                // Hiển thị hình ảnh trong PictureBox
                pictureBox.ImageLocation = imagePath;

                // Lưu hình ảnh vào đường dẫn mới
                File.Copy(imagePath, savePath, true);


            }
        }

        private string GenerateUniquePostId(string userID)
        {
            string prefix = userID;
            string timestamp = DateTime.Now.ToString("yyyyMMddHHmmssfff");
            string randomPart = Guid.NewGuid().ToString("N").Substring(0, 4);

            return $"{prefix}_{timestamp}_{randomPart}";
        }


        public void createPost()
        {
            post.Subject = txtSubject.Text;
            post.Title = txtTitle.Text;
            post.Major = majorSelector.SelectedItem?.ToString();
            post.Description = txtContent.Text;
            post.CoverImg = cover_image;
            post.UserId = account.id;
            post.Status = "waiting";
        }

        private bool chkForm()
        {
            if(txtSubject.Text == "" ||
            txtTitle.Text == "" ||
            txtContent.Text == "")
            {
                return false;
            }
            return true;
            
        }

        bool crPost = false;
        private void kryptonButton1_Click_1(object sender, EventArgs e)
        {
            if (chkForm())
            {
                if (pictureBox.ImageLocation == null)
                {
                    MessageBox.Show("Bạn chưa chọn hình ảnh.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Vô hiệu hóa các điều khiển trước khi khởi động tiến trình
                    txtSubject.Enabled = false;
                    txtTitle.Enabled = false;
                    txtContent.Enabled = false;
                    pictureBox.Enabled = false;
                    majorSelector.Enabled = false;
                    kryptonButton1.Enabled = false;

                    createPost();

                    crPost = postRepository.CreatePost(post);

                    // Mở hoặc kích hoạt MainWindow
                    OpenOrActivateMainWindow(post.PostId);
                }
            }else MessageBox.Show("Bạn chưa hoàn thành thông tin bài post.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void OpenOrActivateMainWindow(string postID)
        {
            RichTextEditor.MainWindow mainWindow = Application.OpenForms.OfType<RichTextEditor.MainWindow>().FirstOrDefault();

            if (mainWindow == null)
            {
                mainWindow = new RichTextEditor.MainWindow(postID);

                // Đăng ký sự kiện Closed để biết khi MainWindow đóng
                mainWindow.Closed += (sender, e) =>
                {
                    // Kích hoạt lại các điều khiển khi MainWindow đóng
                    this.Invoke((MethodInvoker)delegate
                    {
                        txtSubject.Enabled = true;
                        txtTitle.Enabled = true;
                        txtContent.Enabled = true;
                        pictureBox.Enabled = true;
                        majorSelector.Enabled = true;
                        kryptonButton1.Enabled = true;
                        if (crPost)
                        {
                            MessageBox.Show("Bài viết đã thêm vào database");
                            ResetFormControls();
                        }
                        else MessageBox.Show("Bài viết chưa hoàn thành");
                    });
                };

                mainWindow.ShowDialog();
            }
            else
            {
                // Nếu đã mở, đưa MainWindow lên phía trước
                mainWindow.Activate();
            }
        }
        private void ResetFormControls()
        {
            pictureBox.ImageLocation = null;
            txtSubject.Text = "";
            txtTitle.Text = "";
            txtContent.Text = "";
        }


        private void txtContent_TextChanged_1(object sender, EventArgs e)
        {
            //if (txtContent.Text.Length > 0)
            //{
            //    txtContent.Text = "";
            //}
        }
    }
}
