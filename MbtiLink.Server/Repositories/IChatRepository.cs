using MbtiLink.Server.Models;

namespace MbtiLink.Server.Repositories
{
    public interface IChatRepository
    {
        Task<IEnumerable<Message>> GetAllAsync();
        Task AddAsync(Message message);
    }
}
