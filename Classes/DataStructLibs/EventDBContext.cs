using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructLib
{
    public class EventDBContext : DbContext
    {
        public DbSet<Event> Events { get; set; }

        public DbSet<Venue> Venues { get; set; }

        public EventDBContext()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=.;database=HoundDB;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
        protected  override void OnModelCreating(ModelBuilder mb)
        {

        }

    }
}
