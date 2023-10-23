using Microsoft.EntityFrameworkCore;
using Kanoo.Models;


namespace Kanoo.Models
{

    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Flight> Flights { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Stay> Stays { get; set; }
        public DbSet<FlightAndHotel> FlightAndHotels { get; set; }
        public DbSet<TravelService> TravelService { get; set; } = default!;
        public DbSet<Api> Api { get; set; }
        public DbSet<TravelAdvisor> TravelAdvisor { get; set; }
        public DbSet<Airport> Airport { get; set; }

        // https://learn.microsoft.com/en-us/ef/core/modeling/relationships
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // modelBuilder.Entity<Category>()
            //     .HasOne(s => s.Parent)
            //     .WithMany(m => m.Children)
            //     .HasForeignKey(e => e.ParentId);

        }
    }
}