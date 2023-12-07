using BlogObject.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace DataAccess
{
    public class LikeDAO
    {
        //-----instance
        private static LikeDAO instance = null; private static readonly object instanceLock = new object();
        private LikeDAO() { }
        public static LikeDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new LikeDAO();
                    }
                    return instance;
                }
            }
        }
        //============================================

        public bool AddLike(LikeTbl like)
        {
            using (var context = new BlogPrnContext())
            {
                var existingLike = context.LikeTbls
                    .Where(l => l.PostId == like.PostId && l.UserId == like.UserId)
                    .FirstOrDefault();

                try
                {
                    if (existingLike == null)
                    {
                        context.LikeTbls.Add(like);
                        context.SaveChanges();
                        return true;
                    }
                    else
                    {
                        context.LikeTbls.Remove(existingLike);
                        context.SaveChanges();
                        return false;
                    }
                }
                catch (DbUpdateConcurrencyException ex)
                {
                    Debug.WriteLine($"Concurrency Exception: {ex.Message}");
                    return false;
                }
            }
        }


        public List<LikeTbl> GetLikes(string postID)
        {
            using (var context = new BlogPrnContext())
            {
                // Sử dụng LINQ để truy vấn các Like dựa trên postID
                var likes = context.LikeTbls.Where(l => l.PostId == postID).ToList();

                return likes;
            }
        }

        public void DeleteAllLikes(string postID)
        {
            using (var context = new BlogPrnContext())
            {
                // Lấy tất cả các like dựa trên postID
                var likesToDelete = context.LikeTbls.Where(l => l.PostId == postID).ToList();

                // Xóa từng like
                foreach (var like in likesToDelete)
                {
                    context.LikeTbls.Remove(like);
                }
                // Lưu thay đổi vào cơ sở dữ liệu
                context.SaveChanges();
            }
        }
        public void DeleteLikeByUserID(string userID)
        {
            using (var context = new BlogPrnContext())
            {
                var likesToDelete = context.LikeTbls.Where(u => u.UserId == userID).ToList();
                foreach (var like in likesToDelete)
                {
                    context.LikeTbls.Remove(like);
                }
                context.SaveChanges();
            }
        }
    }
}
