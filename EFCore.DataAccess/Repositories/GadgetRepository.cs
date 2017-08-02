using EFCore.DataAccess.Contracts;
using EFCore.DataAccess.Infrastructure;
using EFCore.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace EFCore.DataAccess.Repositories
{
    public class GadgetRepository : RepositoryBase<Gadget>, IGadgetRepository
    {
        public GadgetRepository(DbContext context) : base(context) { }
    }
}
