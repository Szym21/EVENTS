using EventsAPI.DAL.Repositories;
using EventsAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace EventsAPI.DAL.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        readonly DbContext _context;
        public UnitOfWork(DbContext context)
        {
            _context = context;
            EventRepository = new EventRepository(_context);            
        }
        public IRepository<Event> EventRepository { get; private set; }

        public async Task<int> CompleteAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
