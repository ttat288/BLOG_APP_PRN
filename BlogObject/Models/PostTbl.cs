using System;
using System.Collections.Generic;

#nullable disable

namespace BlogObject.Models
{
    public partial class PostTbl
    {
        public PostTbl()
        {
            CommentTbls = new HashSet<CommentTbl>();
            LikeTbls = new HashSet<LikeTbl>();
        }

        public string PostId { get; set; }
        public string UserId { get; set; }
        public string Subject { get; set; }
        public string Title { get; set; }
        public string Major { get; set; }
        public string Description { get; set; }
        public string CoverImg { get; set; }
        public string Status { get; set; }

        public virtual UserTbl User { get; set; }
        public virtual ICollection<CommentTbl> CommentTbls { get; set; }
        public virtual ICollection<LikeTbl> LikeTbls { get; set; }
    }
}
