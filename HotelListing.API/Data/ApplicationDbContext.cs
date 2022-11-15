using Microsoft.EntityFrameworkCore;

namespace HotelListing.API.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Country> Countries { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Country>().HasData(
                new Country
                {
                    Id = 1,
                    CountryName = "India",
                    ShortName = "IN",

                },
                new Country
                {
                    Id = 2,
                    CountryName = "USA",
                    ShortName = "US",

                },
                new Country
                {
                    Id = 3,
                    CountryName = "China",
                    ShortName = "CH",

                });
            builder.Entity<Hotel>().HasData(
                new Hotel
                {
                    Id = 1,
                    Name = "Baccarat Hotel",
                    Address = "New York",
                    Rating = 5.0,
                    CountryId = 2
                },
                new Hotel
                {
                    Id = 2,
                    Name = "MayFlower Resorts",
                    Address = "Washington",
                    Rating = 4.0,
                    CountryId = 2
                },
                new Hotel
                {
                    Id = 3,
                    Name = "Montage Palmetto",
                    Address = "Bluffton",
                    Rating = 3.5,
                    CountryId = 2
                },
                new Hotel
                {
                    Id = 4,
                    Name = "Fairmont Beijing",
                    Address = "Beijing",
                    Rating = 3.0,
                    CountryId = 3
                },
                new Hotel
                {
                    Id = 5,
                    Name = "Guilin Sapphire",
                    Address = "Guilin",
                    Rating = 1.0,
                    CountryId = 3
                },
                new Hotel
                {
                    Id = 6,
                    Name = "Grand Park Hotel Wuxi",
                    Address = "Jiangsu",
                    Rating = 3.7,
                    CountryId = 3
                },
                new Hotel
                {
                    Id = 7,
                    Name = "Leela Palace",
                    Address = "New Delhi",
                    Rating = 4.1,
                    CountryId = 1
                },
                new Hotel
                {
                    Id = 8,
                    Name = "Fateh Collection",
                    Address = "Udaipur",
                    Rating = 3.7,
                    CountryId = 1
                });
        }
    }
}
