using MbtiLink.Server.Models;
using MbtiLink.Server.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace MbtiLink.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LocationController : ControllerBase
    {
        private readonly ILocationRepository _repository;

        public LocationController(ILocationRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IEnumerable<Location>> GetLocations()
        {
            return await _repository.GetAllAsync();
        }

        [HttpPost]
        public async Task<IActionResult> AddLocation(Location location)
        {
            await _repository.AddAsync(location);
            return CreatedAtAction(nameof(GetLocations), new { id = location.Id }, location);
        }
    }
}
