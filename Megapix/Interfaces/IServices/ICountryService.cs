using Megapix.Filters;
using Megapix.Responses;

namespace Megapix.Interfaces.IServices
{
    public interface ICountryService
    {
        Task<CountryResponse> GetByIdAsync(int id, CancellationToken cancellationToken = default);
        Task<BasePaginatedResponse<CountryResponse>> GetAllAsync(CountryFilter filter, CancellationToken cancellationToken = default);
        Task GetAndAddAsync(CancellationToken cancellationToken = default);
    }
}
