using MbtiLink.Server.Models;

namespace MbtiLink.Server.Repositories
{
    public interface IFriendRepository
    {
        Task<IEnumerable<Friend>> GetAllAsync();
        Task AddAsync(Friend friend);
    }
}
