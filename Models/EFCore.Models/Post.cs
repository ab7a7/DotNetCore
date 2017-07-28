using System;
using System.Collections.Generic;
using System.Text;

namespace EFCore.Models
{
    public class Post : IEntity
    {
        public int Id { get; set; }
        public int BlogId { get; set; }
        public string Content { get; set; }
        public string Title { get; set; }
        public virtual Blog Blog { get; set; }

    }
}
