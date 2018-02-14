using EFCore.DataAccess.Infrastructure;
using EFCore.Models.Entities;

namespace EFCore.DataAccess.Contracts
{
    public interface IGadgetRepository : IRepository<Gadget>
    {
    }
}
