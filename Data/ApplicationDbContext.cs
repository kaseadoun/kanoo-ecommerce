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
        public DbSet<FlightAndStay> FlightAndStays { get; set; }
        public DbSet<Airport> Airports { get; set; }
        public DbSet<Destination> Destinations { get; set; }
        public DbSet<Discount> Discounts { get; set; }
    }

}