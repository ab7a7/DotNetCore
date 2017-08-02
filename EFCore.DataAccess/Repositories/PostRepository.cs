using EFCore.DataAccess.Contracts;
using EFCore.DataAccess.Infrastructure;
using EFCore.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace EFCore.DataAccess.Repositories
{
    public class PostRepository : RepositoryBase<Post>, IPostRepository
    {
        public PostRepository(DbContext context) : base(context)
        {
        }
    }
}
