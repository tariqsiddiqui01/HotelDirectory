﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HotelListing.API.Dto.Hotel
{
    public class BaseHotelDto
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }
        public double? Rating { get; set; }
        [Required]
        [Range(1, int.MaxValue)]
        public int CountryId { get; set; }
    }
}
