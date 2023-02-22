using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelListing.API.Data.Configuration
{
    public class CountryConfiguration : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.HasData(
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
        }
    }
}
