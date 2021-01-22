using Microsoft.EntityFrameworkCore;

namespace NationalParkApi.Models
{
    public class NationalParkApiContext : DbContext
    {
        public NationalParkApiContext(DbContextOptions<NationalParkApiContext> options)
            : base(options)
        {
        }
    
        public DbSet<NationalPark> NationalParks { get; set; }
        public DbSet<StatePark> StateParks { get; set;}
        protected override void OnModelCreating(ModelBuilder builder)
        {
        builder.Entity<NationalPark>()
            .HasData(
                new NationalPark { NationalParkId = 1, Name = "YellowStone", Region = "Mid-West" },
                new NationalPark { NationalParkId = 2, Name = "Zion", Region = "Mid-West" },
                new NationalPark { NationalParkId = 3, Name = "Blue Ridge", Region = "East-Coast" },
                new NationalPark { NationalParkId = 4, Name = "Patrick's Park", Region = "East-Coast" }
            );
        builder.Entity<StatePark>()
            .HasData(
                new StatePark { StateParkId = 1, Name = "Hammock", Free = true },
                new StatePark { StateParkId = 2, Name = "Fort Pierce", Free = false },
                new StatePark { StateParkId = 3, Name = "Bear Creek", Free = false },
                new StatePark { StateParkId = 4, Name = "Patrick's Other Park", Free = false }
            );
        }
    }
}