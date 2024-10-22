using EventsAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace EventsAPI.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
    {
        public DbSet<Event> Events { get; set; }
        public DbSet<EventType> EventTypes { get; set; }
        public DbSet<EventUser> EventUsers { get; set; }
        public DbSet<User> Users { get; set; }
        
    }
}
