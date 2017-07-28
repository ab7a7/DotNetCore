using EFCore.Models;
using System;
using System.Threading.Tasks;

namespace EFCore.DataAccess
{
    public class SqlUnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly BloggingContext context;

        public SqlUnitOfWork(BloggingContext context)
        {
            this.context = context;
        }
        private IRepository<Blog> blogs;

        public IRepository<Blog> BlogRepository
        {
            get { return blogs ?? (blogs = new Repository<Blog>(context)); }
        }

        private IRepository<Post> posts;

        public IRepository<Post> PostRepository
        {
            get { return posts ?? (posts = new Repository<Post>(context)); }
        }
        public async Task SaveAsync()
        {
            await context.SaveChangesAsync();
        }

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if(!disposedValue)
            {
                if(disposing)
                {
                    // TODO: dispose managed state (managed objects).
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~SqlUnitOfWork() {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }
        #endregion
    }
}
