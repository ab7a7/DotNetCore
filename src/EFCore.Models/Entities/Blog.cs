using System.Collections.Generic;

namespace EFCore.Models.Entities
{
    public class Blog : IEntity
    {
        public int Id { get; set; }
        public string Url { get; set; }

        public virtual ICollection<Post> Post { get; set; }
    }
}
