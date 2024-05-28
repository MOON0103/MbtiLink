using System;

namespace MbtiLink.Shared.Models
{
    public class Message
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string Content { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
