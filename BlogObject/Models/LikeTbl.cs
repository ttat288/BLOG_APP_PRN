using System;
using System.Collections.Generic;

#nullable disable

namespace BlogObject.Models
{
    public partial class LikeTbl
    {
        public string UserId { get; set; }
        public string PostId { get; set; }

        public virtual PostTbl Post { get; set; }
        public virtual UserTbl User { get; set; }
    }
}
