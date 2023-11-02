using BlogObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class PostRepository : IPostRepository
    {
        public bool CreatePost(Post post)
        {
            return PostDAO.Instance.CreatePost(post);
        }

        public List<Post> GetAllPosts()
        {
            return PostDAO.Instance.GetAllPosts();
        }
    }
}
