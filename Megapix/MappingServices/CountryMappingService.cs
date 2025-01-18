using AutoMapper;
using Megapix.Models;
using Megapix.Responses;

namespace Megapix.MappingServices
{
    public class CountryMappingService : Profile
    {
        public CountryMappingService()
        {
            CreateMap<Country, CountryResponse>();
        }
    }
}
