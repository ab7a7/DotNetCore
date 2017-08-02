using EFCore.DataAccess.Contracts;
using EFCore.DataAccess.Infrastructure;
using EFCore.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace EFCore.DataAccess.Repositories
{
    public class BlogRepository : RepositoryBase<Blog>, IBlogRepository
    {
        public BlogRepository(DbContext context) : base(context)
        {
        }
    }
}
