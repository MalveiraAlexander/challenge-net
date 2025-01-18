using Megapix.Filters;
using Megapix.Models;

namespace Megapix.Interfaces.IRepositories
{
    public interface ICountryRepository
    {
        Task<Country> GetByIdAsync(int id, CancellationToken cancellationToken = default);
        Task<(List<Country> data, int count)> GetAllAsync(CountryFilter filter, CancellationToken cancellationToken = default);
        Task<Country> CreateOrUpdateAsync(Country country, CancellationToken cancellationToken = default);
    }
}
