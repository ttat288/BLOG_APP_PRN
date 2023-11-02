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
        
    }
}
