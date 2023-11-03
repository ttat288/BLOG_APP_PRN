using Assignment_PRN_Team;
using BlogObject;
using DataAccess.Repository;
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
        private List<Post> posts = new List<Post>();
        private List<Like> likes = new List<Like>();
        IPostRepository repository = new PostRepository();
        ILikeRepository likeRepository = new LikeRepository();
        ICommentRepository commentRepository = new CommentRepository();
        private frmUser ParentForm { get; set; }
        public frmPost(frmUser parentForm)
        {
            InitializeComponent();
            posts.AddRange(repository.GetAllPosts());
            ParentForm = parentForm;
        }
        public void deleted(string msg)
        {
            if(msg == "deleted")
            {
                ParentForm.deleted("deleted");
            }
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
                listItems[i] = new post(posts[i].postID, posts[i].coverImg, this);
                listItems[i].Avatar = $"{posts[i].avatar}";
                listItems[i].Title = $"{posts[i].subject} / {posts[i].title}";
                listItems[i].Major = $"{posts[i].major}";
                listItems[i].Content = $"{posts[i].description}";
                listItems[i].Img = $"{posts[i].coverImg}";

                likes = likeRepository.GetLikes(posts[i].postID);
                double like  = likes.Count;
                listItems[i].Likes = like.ToString();

                listItems[i].Comments = commentRepository.CountCommentsByPostID(posts[i].postID);

                pnlPost.Controls.Add(listItems[i]);
            }
        }
        private void postform_sizechanged(object sender, EventArgs e)
        {

        }

        

    }
}
