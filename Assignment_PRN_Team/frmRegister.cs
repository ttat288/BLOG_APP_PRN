using Assignment_PRN_Team;
using BlogObject;
using DataAccess.Repository;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace BlogWinApp
{
    public partial class frmRegister : Form
    {
        IUserRepository userRepository = new UserRepository();
        User user = new User();
        string fileExtension;
        string imagePath;
        public frmRegister()
        {
            InitializeComponent();
            selectMajor.SelectedIndex = 0;
        }
        public bool chkForm()
        {
            if (txtID.Text == "" ||
           txtFullname.Text == "" ||
            txtEmail.Text == "" ||
           txtPassword.Text == "")
            {
                return false;
            }
            return true;

        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (chkForm())
            {
                if (avatar.ImageLocation != null)
                {
                    string savePath = Path.Combine($"../../../../SECRET/userImg/{txtID.Text}" + fileExtension);
                    user.avatar = savePath;
                    // Lưu hình ảnh vào đường dẫn mới
                    File.Copy(imagePath, savePath, true);
                }
                else
                {
                    DialogResult result = MessageBox.Show("Bạn có chắc chắn không chọn avatar không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        user.avatar = "../../../../SECRET/userImg/joe.jpeg";
                    }
                }
                user.id = txtID.Text;
                user.role = "student";
                user.name = txtFullname.Text;
                user.mail = txtEmail.Text;
                user.password = txtPassword.Text;
                user.major = selectMajor.SelectedItem?.ToString();
                user.bio = "Hello";
                if (userRepository.CreateUser(user))
                {
                    DialogResult changeForm = MessageBox.Show("Tạo thành công, đăng nhập ngay?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (changeForm == DialogResult.Yes)
                    {
                        frmLogin frmLogin = new frmLogin();
                        frmLogin.Show();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("ID hoặc email đã tồn tại!");
                }
            }
            else MessageBox.Show("Vui lòng nhập đủ thông tin");
        }

        private void lblChangeAvatar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Thiết lập các thuộc tính của OpenFileDialog
            openFileDialog.Title = "Select Image";
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog.Multiselect = false;

            // Hiển thị hộp thoại chọn tệp và xử lý kết quả
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                imagePath = openFileDialog.FileName;

                avatar.SizeMode = PictureBoxSizeMode.StretchImage;
                fileExtension = Path.GetExtension(imagePath);

                // Kiểm tra nếu tệp không có phần mở rộng, hoặc nếu nó không thuộc các định dạng cho phép
                if (string.IsNullOrEmpty(fileExtension) || !IsValidImageExtension(fileExtension))
                {
                    MessageBox.Show("Vui lòng chọn một tệp hình ảnh hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                // Hiển thị hình ảnh trong PictureBox
                avatar.ImageLocation = imagePath;
                lblChangeAvatar.Visible = false;


            }
        }
        private bool IsValidImageExtension(string extension)
        {
            string[] validExtensions = { ".jpg", ".jpeg", ".png", ".bmp" };
            return validExtensions.Contains(extension.ToLower());
        }

        private void registerBtn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
            this.Close();
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
