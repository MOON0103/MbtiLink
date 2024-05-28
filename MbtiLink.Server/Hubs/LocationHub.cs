using Microsoft.AspNetCore.SignalR;

namespace MbtiLink.Server.Hubs
{
    public class LocationHub : Hub
    {
        public async Task SendLocation(string user, double latitude, double longitude)
        {
            await Clients.All.SendAsync("ReceiveLocation", user, latitude, longitude);
        }
    }
}
