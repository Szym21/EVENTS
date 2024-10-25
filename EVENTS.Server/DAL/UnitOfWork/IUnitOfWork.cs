using EventsAPI.DAL.Repositories;
using EventsAPI.Models;

namespace EventsAPI.DAL.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Event> EventRepository { get; }
        Task<int> CompleteAsync();
    }
}
