using Megapix.Filters;
using Megapix.Interfaces.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Megapix.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController(ICountryService countryService) : ControllerBase
    {
        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync([FromRoute] int id, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            return Ok(await countryService.GetByIdAsync(id, cancellationToken));
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync([FromQuery] CountryFilter filter, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            return Ok(await countryService.GetAllAsync(filter, cancellationToken));
        }
    }
}
