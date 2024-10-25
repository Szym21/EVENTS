using Microsoft.EntityFrameworkCore;

namespace EventsAPI.DAL.Repositories
{
    public class BaseRepository<T> : IDisposable, IRepository<T> where T : class
    {
        protected readonly DbContext _context;
        public BaseRepository(DbContext context)
        {
            _context = context;
        }

        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);
        }

        public void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

        public IEnumerable<T> GetAll(Func<T, bool>? predicate = null)
        {
            return _context.Set<T>().Where(predicate);
        }

        public T GetById(Func<T, bool> predicate)
        {
            return _context.Set<T>().Find(predicate);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

    }
}
