using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RnzBlogging.Models
{
    public class PostReaction
    {
        public int Id { get; set; }
        public virtual ReactionType reactionType { get; set; }
        public int ReactionTypeId { get; set; }
        public virtual Post post { get; set; }
        public int PostId { get; set; }
        public virtual User user { get; set; }
        public int UserId { get; set; }
    }
}
