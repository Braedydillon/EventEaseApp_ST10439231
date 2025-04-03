using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EventEase_WebApplication.Models;

namespace EventEaseApp5.Data
{
    public class EventEaseApp5Context : DbContext
    {
        public EventEaseApp5Context (DbContextOptions<EventEaseApp5Context> options)
            : base(options)
        {
        }

        public DbSet<EventEase_WebApplication.Models.Event> Event { get; set; } = default!;
        public DbSet<EventEase_WebApplication.Models.Venue> Venue { get; set; } = default!;
        public DbSet<EventEase_WebApplication.Models.Booking> Booking { get; set; } = default!;
    }
}
