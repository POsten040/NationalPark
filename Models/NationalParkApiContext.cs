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
    }
}