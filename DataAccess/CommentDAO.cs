using BlogObject;
using DataAccess.DBContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class CommentDAO
    {
        //-----instance
        private static CommentDAO instance = null; private static readonly object instanceLock = new object();
        private CommentDAO() { }
        public static CommentDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new CommentDAO();
                    }
                    return instance;
                }
            }
        }
        //============================================

        public bool AddComment(Comment comment)
        {
            using (var context = new MyDbContext())
            {
                try
                {
                    context.CommentTb.Add(comment);
                    context.SaveChanges();
                    return true; 
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error adding comment: {ex.Message}");
                    return false;
                }
            }
        }

        public List<Comment> GetAllComments()
        {
            using (var context = new MyDbContext())
            {
                try
                {
                    List<Comment> comments = context.CommentTb.ToList();
                    return comments;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error getting comments: {ex.Message}");
                    return null;
                }
            }
        }

        public string CountCommentsByPostID(string postID)
        {
            using (var context = new MyDbContext())
            {
                try
                {
                    int count = context.CommentTb.Count(comment => comment.postID == postID);
                    return count.ToString();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error counting comments: {ex.Message}");
                    return null;
                }
            }
        }


    }
}
