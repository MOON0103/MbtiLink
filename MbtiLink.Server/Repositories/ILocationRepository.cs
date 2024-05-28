using MbtiLink.Server.Models;

namespace MbtiLink.Server.Repositories
{
    public interface ILocationRepository
    {
        Task<IEnumerable<Location>> GetAllAsync();
        Task AddAsync(Location location);
    }
}
