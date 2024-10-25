using EventsAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace EventsAPI.DAL.Repositories
{
    public class EventRepository : BaseRepository<Event>
    {
        public EventRepository(DbContext context) : base(context) { }
    }
}
