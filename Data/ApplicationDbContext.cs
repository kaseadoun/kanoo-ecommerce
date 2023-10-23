using Microsoft.EntityFrameworkCore;
using Kanoo.Models;


namespace Kanoo.Models {

    public class ApplicationDbContext : DbContext {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Flight> Flights { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Stay> Stays { get; set; }
        public DbSet<Kanoo.Models.TravelService> TravelService { get; set; } = default!;
    }

}