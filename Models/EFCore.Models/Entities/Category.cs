using System;
using System.Collections.Generic;

namespace EFCore.Models.Entities
{
    public class Category : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }

        public virtual ICollection<Gadget> Gadgets { get; set; }

        public Category()
        {
            DateCreated = DateTime.UtcNow;
        }
    }
}
