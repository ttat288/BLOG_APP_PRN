using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogObject
{
    public class Post
    {
        [Key]
        public string postID { get; set; }

        public string avatar { get; set; }
        public string subject { get; set; }
        public string title { get; set; }
        public string major { get; set; }
        public string description { get; set; }
        public string coverImg { get; set; }
        public string likes { get; set; }
        public string comments { get; set; }
    }
}
