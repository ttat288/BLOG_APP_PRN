using System;
using System.Collections.Generic;

#nullable disable

namespace BlogObject.Models
{
    public partial class CommentTbl
    {
        public string CmtId { get; set; }
        public string UserId { get; set; }
        public string PostId { get; set; }
        public string Comment { get; set; }

        public virtual PostTbl Post { get; set; }
        public virtual UserTbl User { get; set; }
    }
}
