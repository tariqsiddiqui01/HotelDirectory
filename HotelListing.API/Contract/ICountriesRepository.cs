using HotelListing.API.Data;
using System.Threading.Tasks;

namespace HotelListing.API.Contract
{
    public interface ICountriesRepository : IGenericRepository<Country>
    {
        Task<Country> GetCountryDetails(int? id);
    }
}
