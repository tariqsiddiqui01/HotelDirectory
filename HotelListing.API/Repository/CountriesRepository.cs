using HotelListing.API.Contract;
using HotelListing.API.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelListing.API.Repository
{
    public class CountriesRepository : GenericRepository<Country>, ICountriesRepository
    {
        private readonly ApplicationDbContext _context;
        public CountriesRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Country> GetCountryDetails(int? id)
        {
           var record = await _context.Countries.Include(q => q.Hotels).FirstOrDefaultAsync(q => q.Id == id);
            return record;
        }
    }
 }
