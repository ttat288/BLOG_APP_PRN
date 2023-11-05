using BlogObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;

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

        public bool AddComment(CommentTbl comment)
        {
            using (var context = new BlogPrnContext())
            {
                try
                {
                    context.CommentTbls.Add(comment);
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

        public List<CommentTbl> GetAllComments()
        {
            using (var context = new BlogPrnContext())
            {
                try
                {
                    List<CommentTbl> comments = context.CommentTbls.ToList();
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
            using (var context = new BlogPrnContext())
            {
                try
                {
                    int count = context.CommentTbls.Count(comment => comment.PostId == postID);
                    return count.ToString();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error counting comments: {ex.Message}");
                    return null;
                }
            }
        }

        public void DeleteAllComments(string postID)
        {
            using (var context = new BlogPrnContext())
            {
                // Lấy tất cả các comment dựa trên postID
                var commentsToDelete = context.CommentTbls.Where(comment => comment.PostId == postID).ToList();

                // Xóa từng comment
                foreach (var comment in commentsToDelete)
                {
                    context.CommentTbls.Remove(comment);
                }
                // Lưu thay đổi vào cơ sở dữ liệu
                context.SaveChanges();
            }
        }



    }
}
