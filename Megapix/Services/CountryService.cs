using AutoMapper;
using Megapix.Filters;
using Megapix.Helpers;
using Megapix.Interfaces.IRepositories;
using Megapix.Interfaces.IServices;
using Megapix.Models;
using Megapix.Responses;
using System.Net;

namespace Megapix.Services
{
    public class CountryService(ICountryRepository countryRepository,
                                HttpClient httpClient,
                                IMapper mapper) : ICountryService
    {
        private readonly string url = "https://restcountries.com/v3.1/all?fields=name,flags,capital,population,continents,timezones,area,latlng";
        public async Task<CountryResponse> GetByIdAsync(int id, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            return mapper.Map<CountryResponse>(await countryRepository.GetByIdAsync(id, cancellationToken));
        }

        public async Task<BasePaginatedResponse<CountryResponse>> GetAllAsync(CountryFilter filter, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            var (data, count) = await countryRepository.GetAllAsync(filter, cancellationToken);
            return new BasePaginatedResponse<CountryResponse>
            {
                Data = mapper.Map<List<CountryResponse>>(data),
                Count = count
            };
        }


        public async Task GetAndAddAsync(CancellationToken cancellationToken = default)
        {
            try
            {
                cancellationToken.ThrowIfCancellationRequested();
                var response = await httpClient.GetAsync(url, cancellationToken);
                var countries = await HttpResponseHelper<List<CountryInternalResponse>>.GetResponse(response);
                foreach (var country in countries!)
                {
                    await countryRepository.CreateOrUpdateAsync(new Country
                    {
                        Name = country.name.common,
                        CapitalName = country.capital != null ? string.Join(", ", country.capital) : null,
                        ContinentName = country.continents != null ? string.Join(", ", country.continents) : null,
                        PopulationCount = country.population,
                        AllTimezones = country.timezones != null ? string.Join(", ", country.timezones) : null,
                        Area = country.area,
                        FlagImg = country.flags.svg,
                        Latitude = country.latlng?[0],
                        Longitude = country.latlng?[1]
                    }, cancellationToken);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error {e.Message}");
            }
            
        }
    }
}
