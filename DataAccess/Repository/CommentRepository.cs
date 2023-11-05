using BlogObject;
using BlogObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class CommentRepository : ICommentRepository
    {
        public bool AddComment(CommentTbl comment)
        {
            return CommentDAO.Instance.AddComment(comment);
        }

        public string CountCommentsByPostID(string postID)
        {
            return CommentDAO.Instance.CountCommentsByPostID(postID);
        }

        public List<CommentTbl> GetAllComments()
        {
            return CommentDAO.Instance.GetAllComments();
        }
    }
}
