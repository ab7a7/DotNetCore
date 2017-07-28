using EFCore.Models;
using System.Linq;

namespace EFCore.DataAccess
{
    public interface IRepository<T> where T: class, IEntity
    {
        IQueryable<T> Get { get; }

        T Add(T entity);
        T Update(T entity);
        T Delete(int id);
    }
}
