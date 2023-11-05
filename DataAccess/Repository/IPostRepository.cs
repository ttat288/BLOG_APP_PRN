using BlogObject;
using BlogObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IPostRepository
    {
        public List<PostTbl> GetAllPosts();
        public bool CreatePost(PostTbl post);
        public bool DeletePost(string postID);
        public int CountPostsByIdPrefix(string idPrefix);
        public string GetPostTitleById(string postID);
    }
}
