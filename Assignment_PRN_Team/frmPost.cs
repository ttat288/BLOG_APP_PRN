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
        IPostRepository repository = new PostRepository();
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
        private void loadPost()
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

                if (int.Parse(posts[i].likes) >= 1000)
                {
                    double like_count = double.Parse(posts[i].likes) / 1000;
                    listItems[i].Likes = $"{like_count}k";
                }
                else listItems[i].Likes = $"{posts[i].likes}";

                if (int.Parse(posts[i].comments) >= 1000)
                {
                    double cmt_count = double.Parse(posts[i].comments) / 1000;
                    listItems[i].Comments = $"{cmt_count}k";
                }
                else listItems[i].Comments = $"{posts[i].comments}";

                pnlPost.Controls.Add(listItems[i]);
            }
        }
        private void postform_sizechanged(object sender, EventArgs e)
        {

        }

        

    }
}
