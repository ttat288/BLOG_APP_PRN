using BlogObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IPostRepository
    {
        public List<Post> GetAllPosts();
        public bool CreatePost(Post post);
        public bool DeletePost(string postID);
        public int CountPostsByIdPrefix(string idPrefix);
    }
}
