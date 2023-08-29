using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RnzBlogging.Models
{
    public class PostComment
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public string CommentedOn { get; set; }
        public virtual Post post { get; set; }
        public int PostId { get; set; }
        public virtual User user { get; set; }
        public int UserId { get; set; }
    }
}
