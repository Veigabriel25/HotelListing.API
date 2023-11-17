using Microsoft.EntityFrameworkCore;

namespace HotelListing.API.Data
{
    public class HoteListingDbContext : DbContext
    {
        public HoteListingDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Country> Countries { get; set; }
        public DbSet<Hotel> Hotels { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Country>().HasData(
                new Country
                {
                    Id = 1,
                    Name = "Jamaica",
                    ShortName = "JM"
                }, new Country
                {
                    Id = 2,
                    Name = "Brazil",
                    ShortName = "BR"
                },
                new Country
                {
                    Id = 3,
                    Name = "Paraguay",
                    ShortName = "PY"
                }
            );

            modelBuilder.Entity<Hotel>().HasData(
                new Hotel
                {
                    Id = 1,
                    Name = "Transilvania",
                    Address = "ALi",
                    CountryId = 1,
                    Rating = 10
                },
                new Hotel
                {
                    Id = 2,
                    Name = "Bladenosaur",
                    Address = "Nabogia",
                    CountryId = 2,
                    Rating = 7
                },
                new Hotel
                {
                    Id = 3,
                    Name = "Napoiti",
                    Address = "Tanulia",
                    CountryId = 3,
                    Rating = 3
                }
           );
        }
    }
}