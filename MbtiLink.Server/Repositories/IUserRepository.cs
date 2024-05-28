using MbtiLink.Server.Models;

namespace MbtiLink.Server.Repositories
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> GetAllAsync();
        Task AddAsync(User user);
    }
}
