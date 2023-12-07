using BlogObject;
using BlogObject.Models;
using DataAccess.Repository;
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlogWinApp
{
    public partial class post : UserControl
    {
        IPostRepository postRepository = new PostRepository();
        IUserRepository userRepository = new UserRepository();
        ILikeRepository likeRepository = new LikeRepository();
        LikeTbl like = new LikeTbl();
        string postid, coverImgPath;
        string UserID;
        private frmPost ParentForm { get; set; }
        Account account;
        string msg;
        public post(string postID, string coverImg, frmPost parentForm, string Msg)
        {
            InitializeComponent();
            account = userRepository.remember();
            postid = postID.Trim();
            UserID = postid.Substring(0, 8);
            coverImgPath = coverImg;
            ParentForm = parentForm;
            if (account.id != UserID) deletePost.Visible = false;
            msg = Msg;
            if (msg == "approve")
            {
                btnApprove.Visible = true;
            }
        }




        private void post_enter(object sender, EventArgs e)
        {
            this.BackColor = Color.Gainsboro;
        }

        private void post_leave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void delete_enter(object sender, EventArgs e)
        {
            deletePost.ForeColor = Color.Red;
        }

        private void delete_leave(object sender, EventArgs e)
        {
            deletePost.ForeColor = Color.Black;
        }

        //========================DELETE FILE=============================
        private void deletePost_Click(object sender, EventArgs e)
        {
            string filePath = $"../../../../SECRET/Posts/{postid}.doc";

            DialogResult result = MessageBox.Show("Do you to delete this post?", "Delete post", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (File.Exists(filePath) && File.Exists(coverImgPath))
                {
                    DeleteFile(filePath, coverImgPath);
                    postRepository.DeletePost(postid);
                    MessageBox.Show("Delete Successful!");

                    // Gọi phương thức trực tiếp từ đối tượng frmPost
                    ParentForm.reload("allpost");
                }
                else
                {
                    MessageBox.Show($"File {filePath} or {coverImgPath} not exist.");
                }
            }
        }
        static void DeleteFile(string filePath, string coverImgPath)
        {
            try
            {
                File.Delete(filePath);
                File.Delete(coverImgPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xóa file: {ex.Message}");
            }
        }

        //================================================================
        private void post_click(object sender, EventArgs e)
        {
            frmReadDoc read = new frmReadDoc(postid);
            read.FormClosed += (s, args) => read.Dispose();
            read.ShowDialog();
        }

        private void avatar_Click(object sender, EventArgs e)
        {

            frmProfileAnotherPerson frm = new frmProfileAnotherPerson(UserID);
            frm.Show();
        }

        private async void likeBtn_Click(object sender, EventArgs e)
        {
            like.PostId = postid;
            like.UserId = account.id;

            // Kiểm tra Likes trước khi cập nhật
            int currentLikes = int.Parse(Likes);

            // Vô hiệu hóa nút like
            likeBtn.Enabled = false;

            if (likeRepository.AddLike(like))
            {
                currentLikes++;
                Likes = currentLikes.ToString();
            }
            else
            {
                currentLikes--;
                Likes = currentLikes.ToString();
            }

            // Đợi 1 giây trước khi kích hoạt lại nút like
            await Task.Delay(1000);

            // Kích hoạt lại nút like
            likeBtn.Enabled = true;
        }
        private void commentBtn_Click(object sender, EventArgs e)
        {
            frmComment formComment = new frmComment(postid, this);
            formComment.ShowDialog();

        }
        public void reload(string msg)
        {
            if (msg == "increase")
            {
                int cmt = int.Parse(Comments);
                Comments = (cmt += 1).ToString();
            }
        }
        private void btnApprove_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Bạn có muốn duyệt bài này ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                postRepository.UpdatePostStatus(postid, "approve");
                MessageBox.Show("Duyệt thành công!");
                ParentForm.reload("approve");
            }
        }

        #region Properties
        private string _title;
        private string _major;
        private string _content;
        private string _img;
        private string _avt;
        private string _likes;
        private string _comments;



        [Category("Custom Props")]
        public string Title
        {
            get { return _title; }
            set { _title = value; lblTitle.Text = value; }
        }
        [Category("Custom Props")]
        public string Major
        {
            get { return _major; }
            set { _major = value; lblMajor.Text = value; }
        }

        [Category("Custom Props")]
        public string Content
        {
            get { return _content; }
            set { _content = value; lblContent.Text = value; }
        }

        [Category("Custom Props")]
        public string Avatar
        {
            get { return _avt; }
            set
            {
                _avt = value;
                avatar.ImageLocation = value;
                avatar.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        [Category("Custom Props")]
        public string Img
        {
            get { return _img; }
            set
            {
                _img = value;
                img.ImageLocation = value;
                img.SizeMode = PictureBoxSizeMode.StretchImage; // Đặt chế độ là StretchImage
            }
        }

        [Category("Custom Props")]
        public string Likes
        {
            get { return _likes; }
            set { _likes = value; likeBtn.Text = "👍 " + value; }
        }

        [Category("Custom Props")]
        public string Comments
        {
            get { return _comments; }
            set { _comments = value; commentBtn.Text = "💬 " + value; }
        }



        #endregion
    }
}
