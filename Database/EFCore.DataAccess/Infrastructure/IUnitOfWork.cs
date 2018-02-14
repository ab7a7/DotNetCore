using System.Threading.Tasks;
using EFCore.DataAccess.Contracts;

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
