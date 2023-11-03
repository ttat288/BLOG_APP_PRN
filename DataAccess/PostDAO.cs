using BlogObject;
using DataAccess.DBContext;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class PostDAO
    {
        //-----instance
        private static PostDAO instance = null; private static readonly object instanceLock = new object();
        private PostDAO() { }
        public static PostDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new PostDAO();
                    }
                    return instance;
                }
            }
        }
        //============================================

        //List<Post> posts = new List<Post>();




        public List<Post> GetAllPosts()
        {
            using (var context = new MyDbContext())
            {
                return context.PostTb.ToList();
            }
        }

        public bool CreatePost(Post post)
        {
            try
            {
                using (var context = new MyDbContext())
                {
                    var existingPost = context.PostTb.FirstOrDefault(p => p.postID == post.postID);

                    if (existingPost == null)
                    {
                        context.PostTb.Add(post);
                        context.SaveChanges();
                        return true;
                    }
                    else
                    {
                        Debug.WriteLine("đã tồn tại postID");
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error creating post: {ex.ToString()}");
                return false;
            }
        }

        public bool DeletePost(string postID)
        {
            try
            {
                using (var context = new MyDbContext())
                {
                    var postToRemove = context.PostTb.FirstOrDefault(p => p.postID == postID);

                    if (postToRemove != null)
                    {
                        context.PostTb.Remove(postToRemove);
                        context.SaveChanges();
                        return true;
                    }
                    else
                    {
                        Debug.WriteLine("Không tìm thấy bài viết để xóa.");
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Lỗi khi xóa bài viết: {ex.ToString()}");
                return false;
            }
        }
        public int CountPostsByIdPrefix(string idPrefix)
        {
            using (var context = new MyDbContext())
            {
                // Đếm số lượng bài post dựa vào idPrefix
                var count = context.PostTb.Count(p => p.postID.StartsWith(idPrefix));

                return count;
            }
        }


    }
}
