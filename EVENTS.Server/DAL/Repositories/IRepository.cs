namespace EventsAPI.DAL.Repositories
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll(Func<T, bool>? predicate = null);
        T GetById(Func<T, bool> predicate);
        void Add(T entity);
        void Delete(T entity);
    }
}
