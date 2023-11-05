using BlogObject.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

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




        public List<PostTbl> GetAllPosts()
        {
            using (var context = new BlogPrnContext())
            {
                return context.PostTbls.ToList();
            }
        }

        public bool CreatePost(PostTbl post)
        {
            try
            {
                using (var context = new BlogPrnContext())
                {
                    var existingPost = context.PostTbls.FirstOrDefault(p => p.PostId == post.PostId);

                    if (existingPost == null)
                    {
                        context.PostTbls.Add(post);
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
                using (var context = new BlogPrnContext())
                {
                    var postToRemove = context.PostTbls.FirstOrDefault(p => p.PostId == postID);

                    if (postToRemove != null)
                    {
                        LikeDAO.Instance.DeleteAllLikes(postID);
                        CommentDAO.Instance.DeleteAllComments(postID);
                        context.PostTbls.Remove(postToRemove);
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
            using (var context = new BlogPrnContext())
            {
                // Đếm số lượng bài post dựa vào idPrefix
                var count = context.PostTbls.Count(p => p.PostId.StartsWith(idPrefix));

                return count;
            }
        }


        public string GetPostTitleById(string postID)
        {
            using (var context = new BlogPrnContext())
            {
                // Lấy title của post dựa vào postID
                var post = context.PostTbls.FirstOrDefault(p => p.PostId == postID);

                // Kiểm tra xem post có tồn tại không
                if (post != null)
                {
                    return post.Title;
                }
                else
                {
                    Debug.WriteLine($"Không tìm thấy bài viết với postID {postID}");
                    return null; // hoặc throw một exception nếu bạn muốn xử lý ngoại lệ
                }
            }
        }

    }
}
