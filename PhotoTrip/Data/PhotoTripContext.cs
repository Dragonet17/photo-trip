using Microsoft.EntityFrameworkCore;
using PhotoTrip.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhotoTrip.Data
{
    public class PhotoTripContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Photo> Photos { get; set; }

        public PhotoTripContext(DbContextOptions<PhotoTripContext> options)
           : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasMany(x => x.Events)
                .WithOne(a => a.CreatedBy);
            modelBuilder.Entity<Event>()
               .HasMany(x => x.Photos)
               .WithOne(a => a.Event);
        }
    }
}
