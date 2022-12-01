using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HotelListing.API.Dto.Country
{
    public abstract class BaseCountryDto
    {
        [Required]
        public string CountryName { get; set; }
        public string ShortName { get; set; }
    }
}
