using System;
using System.Collections.Generic;

#nullable disable

namespace BlogObject.Models
{
    public partial class UserTbl
    {
        public UserTbl()
        {
            CommentTbls = new HashSet<CommentTbl>();
            LikeTbls = new HashSet<LikeTbl>();
            PostTbls = new HashSet<PostTbl>();
        }

        public string UserId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string Name { get; set; }
        public string Avatar { get; set; }
        public string Major { get; set; }

        public virtual ICollection<CommentTbl> CommentTbls { get; set; }
        public virtual ICollection<LikeTbl> LikeTbls { get; set; }
        public virtual ICollection<PostTbl> PostTbls { get; set; }
    }
}
