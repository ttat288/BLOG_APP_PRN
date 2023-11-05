using BlogObject;
using BlogObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface ILikeRepository
    {
        public bool AddLike(LikeTbl like);
        public List<LikeTbl> GetLikes(string postID);
    }
}
