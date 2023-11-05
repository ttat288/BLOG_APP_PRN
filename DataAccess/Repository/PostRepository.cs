using BlogObject;
using BlogObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class PostRepository : IPostRepository
    {
        public int CountPostsByIdPrefix(string idPrefix)
        {
            return PostDAO.Instance.CountPostsByIdPrefix(idPrefix);
        }

        public bool CreatePost(PostTbl post)
        {
            return PostDAO.Instance.CreatePost(post);
        }

        public bool DeletePost(string postID)
        {
            return PostDAO.Instance.DeletePost(postID);
        }

        public List<PostTbl> GetAllPosts()
        {
            return PostDAO.Instance.GetAllPosts();
        }

        public string GetPostTitleById(string postID)
        {
            return PostDAO.Instance.GetPostTitleById(postID);
        }
    }
}
