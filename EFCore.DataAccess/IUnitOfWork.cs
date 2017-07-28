using EFCore.Models;
using System.Threading.Tasks;

namespace EFCore.DataAccess
{
    public interface IUnitOfWork
    {
        IRepository<Blog> BlogRepository { get; }
        IRepository<Post> PostRepository { get; }
        Task SaveAsync();
    }
}
