﻿
namespace EFCore.Models.Entities
{
    public class Gadget : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal  Price { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
