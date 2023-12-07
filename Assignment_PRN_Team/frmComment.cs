using BlogObject;
using BlogObject.Models;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlogWinApp
{
    public partial class frmComment : Form
    {
        ICommentRepository commentRepository = new CommentRepository();
        IUserRepository userRepository = new UserRepository();
        post ParentForm;
        IPostRepository postRepository = new PostRepository();
        List<CommentTbl> comments = new List<CommentTbl>();
        CommentTbl comment = new CommentTbl();
        Account account;
        string postID;
        UserTbl user;
        public frmComment(string postid, post parentForm)
        {
            InitializeComponent();
            this.Text = postRepository.GetPostTitleById(postid);
            postID = postid;
            comments.AddRange(commentRepository.GetAllComments());
            account = userRepository.remember();
            txtName.Text = userRepository.user(account.id).Name;
            avatar.ImageLocation = userRepository.user(account.id).Avatar;
            avatar.SizeMode = PictureBoxSizeMode.StretchImage;
            ParentForm = parentForm;
        }

        private void frmComment_Load(object sender, EventArgs e)
        {
            loadComment();
        }
        private void loadComment()
        {
            pnlComment.Controls.Clear();
            comments.Clear();
            comments = commentRepository.GetAllComments();
            comment[] listItems = new comment[comments.Count];

            for (int i = listItems.Length - 1; i >= 0; i--)
            {
                if (comments[i].PostId.Trim() == postID.Trim())
                {
                    listItems[i] = new comment(comments[i].UserId);
                    user = userRepository.user(comments[i].UserId);
                    listItems[i].Comment = comments[i].Comment;
                    listItems[i].Avatar = user.Avatar;
                    listItems[i].Name = user.Name;
                    pnlComment.Controls.Add(listItems[i]);
                }
            }

        }
        private async void btnComment_Click(object sender, EventArgs e)
        {
            if (txtComment.Text.Trim().Length > 0)
            {

                comment.CmtId = GenerateUniqueCommentID(account.id);
                comment.UserId = account.id;
                comment.Comment = txtComment.Text;
                comment.PostId = postID;
                if (commentRepository.AddComment(comment))
                {
                    loadComment();
                    txtComment.Text = "";
                    ParentForm.reload("increase");

                    btnComment.Enabled = false;
                    btnComment.Text = "3";
                    await Task.Delay(1000);

                    btnComment.Text = "2";
                    await Task.Delay(1000);

                    btnComment.Text = "1";
                    await Task.Delay(1000);
                    btnComment.Enabled = true;
                    btnComment.Text = "comment";
                }
                else MessageBox.Show("Lỗi!");
            }
            else MessageBox.Show("Hãy nhắn chút gì đó trước khi comment!");
        }

        private string GenerateUniqueCommentID(string userID)
        {
            string prefix = userID;
            string timestamp = DateTime.Now.ToString("yyyyMMddHHmmssfff");
            string randomPart = Guid.NewGuid().ToString("N").Substring(0, 4);

            return $"{prefix}_{timestamp}_{randomPart}";
        }

        private void txtComment_TextChanged(object sender, EventArgs e)
        {
            if (txtComment.Text.Length > 150)
            {
                MessageBox.Show("độ dài không vượt quá 150.");
                txtComment.Text = txtComment.Text.Substring(0, 150);

                txtComment.SelectionStart = txtComment.Text.Length;
                txtComment.SelectionLength = 0;
            }
        }
    }
}
