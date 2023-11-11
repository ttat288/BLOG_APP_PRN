using Assignment_PRN_Team;
using BlogObject;
using BlogObject.Models;
using DataAccess.Repository;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Interop;

namespace BlogWinApp
{
    public partial class frmPost : Form
    {
        private List<PostTbl> posts = new List<PostTbl>();
        private List<LikeTbl> likes = new List<LikeTbl>();
        IPostRepository repository = new PostRepository();
        ILikeRepository likeRepository = new LikeRepository();
        ICommentRepository commentRepository = new CommentRepository();
        IUserRepository userRepository = new UserRepository();
        private frmUser ParentForm { get; set; }
        string msg;
        public frmPost(frmUser parentForm,string Msg)
        {
            InitializeComponent();
            msg = Msg;
            ParentForm = parentForm;
            if(msg == "allpost")
            {
                posts.AddRange(repository.GetApprovedPosts());
            }else if(msg == "approve")
            {
                posts.AddRange(repository.GetWaitingPosts());
            }
            else posts.AddRange(repository.GetPostsByUserIdPrefix(msg));

        }
        public void reload(string msg)
        {
                ParentForm.showPost(msg);
        }


        private void frmPost_Load(object sender, EventArgs e)
        {
            loadPost();
        }
        public void loadPost()
        {
            pnlPost.Controls.Clear();
            post[] listItems = new post[posts.Count];

            for (int i = 0; i < listItems.Length; i++)
            {
                listItems[i] = new post(posts[i].PostId, posts[i].CoverImg, this,msg);
                listItems[i].Avatar = userRepository.user(posts[i].UserId).Avatar;
                listItems[i].Title = $"{posts[i].Subject} / {posts[i].Title}";
                listItems[i].Major = $"{posts[i].Major}";
                listItems[i].Content = $"{posts[i].Description}";
                listItems[i].Img = $"{posts[i].CoverImg}";

                likes = likeRepository.GetLikes(posts[i].PostId);
                double like = likes.Count;
                listItems[i].Likes = like.ToString();

                listItems[i].Comments = commentRepository.CountCommentsByPostID(posts[i].PostId);

                pnlPost.Controls.Add(listItems[i]);
            }
        }
        private void postform_sizechanged(object sender, EventArgs e)
        {

        }

        

    }
}
