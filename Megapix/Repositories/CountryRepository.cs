using AuthSystem.Commons.Helpers;
using AutoMapper;
using Megapix.Data;
using Megapix.Exceptions;
using Megapix.Filters;
using Megapix.Interfaces.IRepositories;
using Megapix.Models;
using Microsoft.EntityFrameworkCore;

namespace Megapix.Repositories
{
    public class CountryRepository(SystemContext context, IMapper mapper) : ICountryRepository
    {
        public async Task<Country> GetByIdAsync(int id, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            return await context.Countries.FirstOrDefaultAsync(p => p.Id == id, cancellationToken) ?? throw new NotFoundException("País no encontrado");
        }

        public async Task<(List<Country> data, int count)> GetAllAsync(CountryFilter filter, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            var query = GetQueryable(filter);
            var count = await query.CountAsync(cancellationToken);
            if (filter.PageSize.HasValue)
            {
                query = query.Paginate(filter);
            }
            return (await query.ToListAsync(cancellationToken), count);
        }

        public async Task<Country> CreateOrUpdateAsync(Country country, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            var entity = await context.Countries.FirstOrDefaultAsync(p => p.Name == country.Name, cancellationToken);

            if (entity is not null)
            {
                mapper.Map(country, entity);
                context.Countries.Update(entity);
            }
            else
            {
                await context.Countries.AddAsync(country, cancellationToken);
            }

            await context.SaveChangesAsync(cancellationToken);
            return country;
        }


        private IQueryable<Country> GetQueryable(CountryFilter filter)
        {
            var query = context.Countries.AsQueryable();
            if (!string.IsNullOrEmpty(filter.Name))
            {
                query = query.Where(p => p.Name.ToLower().Trim().Contains(filter.Name.ToLower().Trim()));
            }
            if (!string.IsNullOrEmpty(filter.CapitalName))
            {
                query = query.Where(p => p.CapitalName.ToLower().Trim().Contains(filter.CapitalName.ToLower().Trim()));
            }
            if (filter.Area.HasValue)
            {
                query = query.Where(p => p.Area == filter.Area);
            }
            if (filter.PopulationCount.HasValue)
            {
                query = query.Where(p => p.PopulationCount == filter.PopulationCount);
            }
            if (!string.IsNullOrEmpty(filter.AllTimezones))
            {
                query = query.Where(p => p.AllTimezones.ToLower().Trim().Contains(filter.AllTimezones.ToLower().Trim()));
            }
            if (!string.IsNullOrEmpty(filter.ContinentName))
            {
                query = query.Where(p => p.ContinentName.ToLower().Trim().Contains(filter.ContinentName.ToLower().Trim()));
            }
            if (filter.Latitude.HasValue)
            {
                query = query.Where(p => p.Latitude == filter.Latitude);
            }
            if (filter.Longitude.HasValue)
            {
                query = query.Where(p => p.Longitude == filter.Longitude);
            }
            return query;
        }
    }
}
