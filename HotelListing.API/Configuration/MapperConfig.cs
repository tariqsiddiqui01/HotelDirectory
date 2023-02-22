using AutoMapper;
using HotelListing.API.Data;
using HotelListing.API.Dto.Country;
using HotelListing.API.Dto.Hotel;
using HotelListing.API.Dto.User;

namespace HotelListing.API.Configuration
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<Country, CreateCountryDto>().ReverseMap();
            CreateMap<Country, GetCountryDto>().ReverseMap();
            CreateMap<Country, CountryDto>().ReverseMap();
            CreateMap<Hotel, HotelDto>().ReverseMap();
            CreateMap<Country, UpdateCountryDto>().ReverseMap();
            CreateMap<Hotel, CreateHotelDto>().ReverseMap();
            CreateMap<Hotel, UpdateHotelDto>().ReverseMap();
            CreateMap<APIUser, ApiUserDto>().ReverseMap();
        }
    }
}
