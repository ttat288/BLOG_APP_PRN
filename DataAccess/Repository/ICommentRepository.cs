using BlogObject;
using BlogObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface ICommentRepository
    {
        public bool AddComment(CommentTbl comment);
        public List<CommentTbl> GetAllComments();
        public string CountCommentsByPostID(string postID);
    }
}
