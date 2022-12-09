using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HotelListing.API.Data;
using HotelListing.API.Contract;
using AutoMapper;
using HotelListing.API.Dto.Hotel;

namespace HotelListing.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelsController : ControllerBase
    {
       
        private readonly IHotelsRepository _repository;
        private readonly IMapper _mapper;

        public HotelsController(IHotelsRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        // GET: api/Hotels
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HotelDto>>> GetHotels()
        {
            var records = await _repository.GetAllAsync();
            var hotels = _mapper.Map<List<HotelDto>>(records);
            return Ok(hotels);
        }

        // GET: api/Hotels/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HotelDto>> GetHotel(int id)
        {
            var record = await _repository.GetByIdAsync(id);

            if (record == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<HotelDto>(record));
        }

        // PUT: api/Hotels/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHotel(int id, UpdateHotelDto updatehotelDto)
        {
            if (id != updatehotelDto.Id)
            {
                return BadRequest();
            }

            var hotel = await _repository.GetByIdAsync(id);
            if (hotel == null)
            {
                return NotFound();
            }
            
            _mapper.Map(updatehotelDto, hotel);

            try
            {
                await _repository.UpdateAsync(hotel);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (! await HotelExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Ok("Successfully updated!");
        }

        [HttpPost]
        public async Task<ActionResult<HotelDto>> PostHotel(CreateHotelDto hotelDto)
        {
            var record = _mapper.Map<Hotel>(hotelDto);
            await _repository.AddAsync(record);
            

            return Ok(_mapper.Map<HotelDto>(record));
        }

        // DELETE: api/Hotels/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Hotel>> DeleteHotel(int id)
        {
            var hotel = await _repository.GetByIdAsync(id);
            if (hotel == null)
            {
                return NotFound();
            }

            await _repository.DeleteAsync(id);

            return hotel;
        }

        private async Task<bool> HotelExists(int id)
        {
            return await _repository.IsExists(id);
        }
    }
}
