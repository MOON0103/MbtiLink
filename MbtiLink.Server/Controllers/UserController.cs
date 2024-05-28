using MbtiLink.Server.Models;
using MbtiLink.Server.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace MbtiLink.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _repository;

        public UserController(IUserRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IEnumerable<User>> GetUsers()
        {
            return await _repository.GetAllAsync();
        }

        [HttpPost]
        public async Task<IActionResult> AddUser(User user)
        {
            await _repository.AddAsync(user);
            return CreatedAtAction(nameof(GetUsers), new { id = user.Id }, user);
        }
    }
}
