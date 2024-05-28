using MbtiLink.Server.Models;
using MbtiLink.Server.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace MbtiLink.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ChatController : ControllerBase
    {
        private readonly IChatRepository _repository;

        public ChatController(IChatRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IEnumerable<Message>> GetMessages()
        {
            return await _repository.GetAllAsync();
        }

        [HttpPost]
        public async Task<IActionResult> AddMessage(Message message)
        {
            await _repository.AddAsync(message);
            return CreatedAtAction(nameof(GetMessages), new { id = message.Id }, message);
        }
    }
}
