using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelListing.API.Contract
{
    public interface IGenericRepository<T> where T:class
    {
        Task<T> AddAsync(T entity);
        Task<T> GetByIdAsync(int? id);
        Task<List<T>> GetAllAsync();
        Task UpdateAsync(T entity);
        Task DeleteAsync(int id);
        Task<bool> IsExists(int id);

    }
}
