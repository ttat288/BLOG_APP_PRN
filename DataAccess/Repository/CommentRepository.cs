using BlogObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class CommentRepository : ICommentRepository
    {
        public bool AddComment(Comment comment)
        {
            return CommentDAO.Instance.AddComment(comment);
        }

        public string CountCommentsByPostID(string postID)
        {
            return CommentDAO.Instance.CountCommentsByPostID(postID);
        }

        public List<Comment> GetAllComments()
        {
            return CommentDAO.Instance.GetAllComments();
        }
    }
}
