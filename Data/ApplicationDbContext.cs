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

        public DbSet<Contact> Contact { get; set; }
        public DbSet<Data> Data { get; set; }
        public DbSet<Details> Details { get; set; }
        public DbSet<DetailsV2> DetailsV2 { get; set; }
        public DbSet<Geocode> Geocode { get; set; }
        public DbSet<Image> Image { get; set; }
        public DbSet<Names> Names { get; set; }
        public DbSet<ParentGeoDetails> ParentGeoDetails { get; set; }
        public DbSet<Photo> Photo { get; set; }
        public DbSet<PhotoSize> PhotoSize { get; set; }
        public DbSet<PhotoSizeDynamic> PhotoSizeDynamic { get; set; }
        public DbSet<Root> Root { get; set; }
        public DbSet<Route> Route { get; set; }
        public DbSet<SocialStatistics> SocialStatistics { get; set; }
        public DbSet<StreetAddress> StreetAddress { get; set; }
        public DbSet<TypeaheadAutocomplete> TypeaheadAutocomplete { get; set; }
        public DbSet<TypedParams> TypedParams { get; set; }

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