using System.Linq;
using Microsoft.EntityFrameworkCore;
using EFCore.Models;

namespace EFCore.DataAccess.Infrastructure
{
    public class RepositoryBase<T> : IRepository<T> where T : class, IEntity
    {
        internal DbContext DbContext;
        internal DbSet<T> DbSet;
        public RepositoryBase(DbContext context)
        {
            DbContext = context;
            DbSet = context.Set<T>();
        }
        public IQueryable<T> Get => DbSet;

        public virtual T Add(T entity)
        {
            return DbSet.Add(entity).Entity;
        }

        public virtual T Delete(int id)
        {
            T entity = Find(id);
            return entity == null ? null : DbSet.Remove(entity).Entity;
        }

        private T Find(int id)
        {
            return DbSet.Find(id);
        }

        public virtual T Update(T entity)
        {
            DbContext.Entry(entity).State = EntityState.Modified;
            return entity;
        }
    }
}
