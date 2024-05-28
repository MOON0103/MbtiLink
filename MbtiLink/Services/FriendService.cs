namespace MbtiLink.Services
{
    public class FriendService
    {
        public async Task NavigateToFriendPage(INavigation navigation)
        {
            await navigation.PushAsync(new FriendPage());
        }
    }
}
