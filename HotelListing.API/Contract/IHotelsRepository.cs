using HotelListing.API.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelListing.API.Contract
{
    public interface IHotelsRepository : IGenericRepository<Hotel>
    {
    }
}
