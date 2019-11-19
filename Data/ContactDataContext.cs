using aywevents.Models;
using Microsoft.EntityFrameworkCore;

namespace aywevents.Data
{
    public class EventContext : DbContext
    {
        public EventContext( DbContextOptions<EventContext> options) : base(options)
        {
        }

        public DbSet<EventRequest> EventRequest { get; set; }
        public DbSet<Service> Service { get; set; }

    }
}