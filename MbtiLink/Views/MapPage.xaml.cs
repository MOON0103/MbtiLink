
/* 'MbtiLink (net8.0-ios)' 프로젝트에서 병합되지 않은 변경 내용
이전:
using Microsoft.Maui.Controls;
이후:
using MbtiLink.Services;
using Microsoft.Maui.Controls;
*/

/* 'MbtiLink (net8.0-maccatalyst)' 프로젝트에서 병합되지 않은 변경 내용
이전:
using Microsoft.Maui.Controls;
이후:
using MbtiLink.Services;
using Microsoft.Maui.Controls;
*/

/* 'MbtiLink (net8.0-windows10.0.19041.0)' 프로젝트에서 병합되지 않은 변경 내용
이전:
using Microsoft.Maui.Controls;
이후:
using MbtiLink.Services;
using Microsoft.Maui.Controls;
*/
using MbtiLink.Services;
using Microsoft.Maui.Controls.Maps;
using Microsoft.Maui.Maps;
/* 'MbtiLink (net8.0-ios)' 프로젝트에서 병합되지 않은 변경 내용
이전:
using MbtiLink.Services;
using System;
이후:
using System;
*/

/* 'MbtiLink (net8.0-maccatalyst)' 프로젝트에서 병합되지 않은 변경 내용
이전:
using MbtiLink.Services;
using System;
이후:
using System;
*/

/* 'MbtiLink (net8.0-windows10.0.19041.0)' 프로젝트에서 병합되지 않은 변경 내용
이전:
using MbtiLink.Services;
using System;
이후:
using System;
*/


namespace MbtiLink.Views
{
    public partial class MainPage : ContentPage
    {
        private Map MyMap;
        private readonly ChatService _chatService;
        private readonly FriendService _friendService;
        private readonly LocationService _locationService;

        public MainPage()
        {
            InitializeComponent();
            _chatService = new ChatService();
            _friendService = new FriendService();
            _locationService = new LocationService();
        }

        private async void OnShowLocationClicked(object sender, EventArgs e)
        {
            var location = await _locationService.GetCurrentLocationAsync();
            if (location != null)
            {
                MyMap.MoveToRegion(MapSpan.FromCenterAndRadius(
                    new Position(location.Latitude, location.Longitude),
                    Distance.FromMiles(1)));
            }
        }

        private async void OnChatClicked(object sender, EventArgs e)
        {
            await _chatService.NavigateToChatPage(Navigation);
        }

        private async void OnFriendsClicked(object sender, EventArgs e)
        {
            await _friendService.NavigateToFriendPage(Navigation);
        }
    }
}
