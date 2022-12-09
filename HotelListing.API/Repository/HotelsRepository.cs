using HotelListing.API.Contract;
using HotelListing.API.Data;

namespace HotelListing.API.Repository
{
    public class HotelsRepository: GenericRepository<Hotel>, IHotelsRepository
    {
        private readonly ApplicationDbContext _db;

        public HotelsRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
