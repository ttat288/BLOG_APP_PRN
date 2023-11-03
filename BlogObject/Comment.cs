using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogObject
{
    public class Comment
    {
        [Key]
        public string commentID { get; set; }

        public string userID { get; set; }
        public string postID { get; set; }
        public string comment { get; set; }
        public string avatar { get; set; }
    }
}
