using MbtiLink.Server.Data;
using MbtiLink.Server.Models;
using Microsoft.EntityFrameworkCore;

namespace MbtiLink.Server.Repositories
{
    public class FriendRepository : IFriendRepository
    {
        private readonly ApplicationDbContext _context;

        public FriendRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Friend>> GetAllAsync()
        {
            return await _context.Friends.ToListAsync();
        }

        public async Task AddAsync(Friend friend)
        {
            _context.Friends.Add(friend);
            await _context.SaveChangesAsync();
        }
    }
}
