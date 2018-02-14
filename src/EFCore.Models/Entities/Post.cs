
namespace EFCore.Models.Entities
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
