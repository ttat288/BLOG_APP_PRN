using BlogObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface ILikeRepository
    {
        public bool AddLike(Like like);
        public List<Like> GetLikes(string postID);
    }
}
