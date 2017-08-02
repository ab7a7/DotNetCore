using EFCore.DataAccess.Contracts;
using EFCore.DataAccess.Infrastructure;
using EFCore.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace EFCore.DataAccess.Repositories
{
    public class CategoryRepository : RepositoryBase<Category>, ICategoryRepository
    {
        public CategoryRepository(DbContext context) : base(context)
        {
        }
    }
}
