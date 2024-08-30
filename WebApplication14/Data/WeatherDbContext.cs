using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace WebApplication14.Data
{
    public class WeatherDbContext : DbContext
    {
        public DbSet<City> Cities { get; set; }
        public WeatherDbContext(DbContextOptions options) : base(options)
        {
            Database.EnsureCreated();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<City>();
        }
    }
}
