using HotelListing.API.Dto.Hotel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelListing.API.Dto.Country
{
    public class CountryDto : BaseCountryDto
    {
        public int Id { get; set; }
        
        public List<HotelDto> Hotels { get; set; }
    }
}
