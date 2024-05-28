using MbtiLink.Server.Models;
using MbtiLink.Server.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace MbtiLink.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FriendController : ControllerBase
    {
        private readonly IFriendRepository _repository;

        public FriendController(IFriendRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IEnumerable<Friend>> GetFriends()
        {
            return await _repository.GetAllAsync();
        }

        [HttpPost]
        public async Task<IActionResult> AddFriend(Friend friend)
        {
            await _repository.AddAsync(friend);
            return CreatedAtAction(nameof(GetFriends), new { id = friend.Id }, friend);
        }
    }
}
