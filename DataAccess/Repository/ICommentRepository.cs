using BlogObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface ICommentRepository
    {
        public bool AddComment(Comment comment);
        public List<Comment> GetAllComments();
        public string CountCommentsByPostID(string postID);
    }
}
