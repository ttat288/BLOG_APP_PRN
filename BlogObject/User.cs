using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogObject
{
    public class User
    {
        [Key]
        public string id { get; set; }

        public string role { get; set; }
        public string name { get; set; }
        public string mail { get; set; }
        public string password { get; set; }
        public string avatar { get; set; }
        public string major { get; set; }
        public string bio { get; set; }
    }
}
