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
using System.Windows.Documents;
using System.Windows.Forms;

namespace BlogWinApp
{
    public partial class frmPost : Form
    {
        private List<Post> posts = new List<Post>();
        IPostRepository repository = new PostRepository();
        public frmPost()
        {
            InitializeComponent();
            posts.AddRange(repository.GetAllPosts());
        }

        private void frmPost_Load(object sender, EventArgs e)
        {
            post[] listItems = new post[posts.Count];

            for (int i = 0; i < listItems.Length; i++)
            {
                listItems[i] = new post();

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
