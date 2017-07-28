using System;
using System.Collections.Generic;
using System.Text;

namespace EFCore.Models
{
    public class Blog : IEntity
    {
        public int Id { get; set; }
        public string Url { get; set; }

        public virtual ICollection<Post> Post { get; set; }
    }
}
