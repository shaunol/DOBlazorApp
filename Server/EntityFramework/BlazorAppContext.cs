using DOBlazorApp.Shared;
using Microsoft.EntityFrameworkCore;

namespace DOBlazorApp.Server.EntityFramework
{
    public class BlazorAppContext : DbContext
    {
        public DbSet<Company> Companies { get; set; }
        public DbSet<Person> People { get; set; }

        public BlazorAppContext(DbContextOptions<BlazorAppContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Company>()
                .HasKey(e => e.Id);

            modelBuilder.Entity<Person>()
                .HasKey(e => e.Id);
        }
    }
}
