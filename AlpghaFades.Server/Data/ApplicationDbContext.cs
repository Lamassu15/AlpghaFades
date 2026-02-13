using AlpghaFades.Server.Models;
using Microsoft.EntityFrameworkCore;

namespace AlpghaFades.Server.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Barber> Barbers { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<WorkingHours> WorkingHours { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // här lägger vi Fluent API senare
            modelBuilder.Entity<Barber>()
                    .HasMany(b => b.Services)
                    .WithMany(s => s.Barbers);

            modelBuilder.Entity<Booking>()
                    .HasOne(b => b.Barber)
                    .WithMany(x => x.Bookings)
                    .HasForeignKey(b => b.BarberId);

            modelBuilder.Entity<Service>()
                    .Property(s => s.Price)
                    .HasPrecision(18, 2);
        }
    }
}
