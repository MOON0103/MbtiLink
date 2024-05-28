using Microsoft.Maui.Maps;
using System.Diagnostics;

namespace MbtiLink.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnShowLocationClicked(object sender, EventArgs e)
        {
            var location = await GetCurrentLocationAsync();
            if (location != null)
            {
                MyMap.MoveToRegion(MapSpan.FromCenterAndRadius(
                    new Position(location.Latitude, location.Longitude),
                    Distance.FromMiles(1)));
            }
        }

        private async Task<Location> GetCurrentLocationAsync()
        {
            try
            {
                var location = await Geolocation.GetLastKnownLocationAsync();
                if (location == null)
                {
                    location = await Geolocation.GetLocationAsync(new GeolocationRequest
                    {
                        DesiredAccuracy = GeolocationAccuracy.Medium,
                        Timeout = TimeSpan.FromSeconds(30)
                    });
                }
                return location;
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"위치 정보를 가져오는 중 오류 발생: {ex.Message}");
                return null;
            }
        }

        private async void OnChatClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ChatPage());
        }

        private async void OnFriendsClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FriendPage());
        }
    }
}
