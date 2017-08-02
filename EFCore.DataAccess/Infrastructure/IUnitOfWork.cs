using EFCore.DataAccess.Contracts;
using EFCore.Models.Entities;
using System.Threading.Tasks;

namespace EFCore.DataAccess.Infrastructure
{
    public interface IUnitOfWork
    {
        IBlogRepository BlogRepository { get; }
        ICategoryRepository CategoryRepository { get; }
        IGadgetRepository GadgetRepository { get; }
        IPostRepository PostRepository { get; }
        Task SaveAsync();
    }
}
