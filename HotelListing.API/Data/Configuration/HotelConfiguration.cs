using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelListing.API.Data.Configuration
{
    public class HotelConfiguration : IEntityTypeConfiguration<Hotel>
    {
        public void Configure(EntityTypeBuilder<Hotel> builder)
        {
            builder.HasData(
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
