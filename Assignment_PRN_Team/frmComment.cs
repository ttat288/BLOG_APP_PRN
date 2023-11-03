using BlogObject;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
        List<Comment> comments = new List<Comment>();
        Comment comment = new Comment();
        Account account;
        string postID;
        User user;
        public frmComment(string postid, post parentForm)
        {
            InitializeComponent();
            this.Text = postRepository.GetPostTitleById(postid);
            postID = postid;
            comments.AddRange(commentRepository.GetAllComments());
            account = userRepository.remember();
            txtName.Text = userRepository.user(account.id).name;
            avatar.ImageLocation = userRepository.user(account.id).avatar;
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

            for (int i = 0; i < listItems.Length; i++)
            {
                if (comments[i].postID.Trim() == postID.Trim())
                {
                    listItems[i] = new comment();
                    user = userRepository.user(comments[i].userID);
                    listItems[i].Comment = comments[i].comment;
                    listItems[i].Avatar = comments[i].avatar;
                    listItems[i].Name = user.name;
                    pnlComment.Controls.Add(listItems[i]);
                }
            }

        }
        private void btnComment_Click(object sender, EventArgs e)
        {
            comment.avatar = account.avt;
            comment.commentID = GenerateUniqueCommentID(account.id);
            comment.userID = account.id;
            comment.comment = txtComment.Text;
            comment.postID = postID;
            if (commentRepository.AddComment(comment))
            {
                MessageBox.Show("Thành công!");
                loadComment();
                txtComment.Text = "";
                ParentForm.reload("increase");
            }
            else MessageBox.Show("Lỗi!");
            
        }

        private string GenerateUniqueCommentID(string userID)
        {
            string prefix = userID;
            string timestamp = DateTime.Now.ToString("yyyyMMddHHmmssfff");
            string randomPart = Guid.NewGuid().ToString("N").Substring(0, 4);

            return $"{prefix}_{timestamp}_{randomPart}";
        }
    }
}
