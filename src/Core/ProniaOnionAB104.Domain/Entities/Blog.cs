using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProniaOnionAB104.Domain.Entities
{
    public class Blog : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int ReplyCount { get; set; }

        public int AuthorId { get; set; }
        public Author Author { get; set; }

        public List<BlogTag> BlogTags { get; set; }
    }
}
