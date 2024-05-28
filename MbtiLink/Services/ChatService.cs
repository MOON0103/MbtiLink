namespace MbtiLink.Services
{
    public class ChatService
    {
        public async Task NavigateToChatPage(INavigation navigation)
        {
            await navigation.PushAsync(new ChatPage());
        }
    }
}
