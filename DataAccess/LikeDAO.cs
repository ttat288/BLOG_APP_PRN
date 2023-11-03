using BlogObject;
using DataAccess.DBContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public bool AddLike(Like like)
        {
            using (var context = new MyDbContext())
            {
                var existingLike = context.LikeTb
                    .Where(l => l.postID == like.postID && l.userID == like.userID)
                    .FirstOrDefault();

                try
                {
                    if (existingLike == null)
                    {
                        context.LikeTb.Add(like);
                        context.SaveChanges();
                        return true;
                    }
                    else
                    {
                        context.LikeTb.Remove(existingLike);
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


        public List<Like> GetLikes(string postID)
        {
            using (var context = new MyDbContext())
            {
                // Sử dụng LINQ để truy vấn các Like dựa trên postID
                var likes = context.LikeTb.Where(l => l.postID == postID).ToList();

                return likes;
            }
        }

    }
}
