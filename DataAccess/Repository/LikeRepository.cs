using BlogObject;
using BlogObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class LikeRepository : ILikeRepository
    {
        public bool AddLike(LikeTbl like)
        {
            return LikeDAO.Instance.AddLike(like);
        }

        public List<LikeTbl> GetLikes(string postID)
        {
            return LikeDAO.Instance.GetLikes(postID);
        }
    }
}
