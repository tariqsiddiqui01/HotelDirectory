﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelListing.API.Dto.User
{
    public class AuthResponseDto
    {
        public string UserId { get; set; }
        public string Token { get; set; }
        public string RefreshToken { get;  set; }
    }
}
