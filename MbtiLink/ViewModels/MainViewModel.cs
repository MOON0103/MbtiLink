/* 'MbtiLink (net8.0-ios)' 프로젝트에서 병합되지 않은 변경 내용
이전:
using System.Threading.Tasks;
using MbtiLink.Services;
using Microsoft.Maui.Controls;
이후:
using MbtiLink.Services;
using Microsoft.Maui.Services;
using System.Threading.Tasks;
*/

/* 'MbtiLink (net8.0-maccatalyst)' 프로젝트에서 병합되지 않은 변경 내용
이전:
using System.Threading.Tasks;
using MbtiLink.Services;
using Microsoft.Maui.Controls;
이후:
using MbtiLink.Services;
using Microsoft.Maui.Services;
using System.Threading.Tasks;
*/

/* 'MbtiLink (net8.0-windows10.0.19041.0)' 프로젝트에서 병합되지 않은 변경 내용
이전:
using System.Threading.Tasks;
using MbtiLink.Services;
using Microsoft.Maui.Controls;
이후:
using MbtiLink.Services;
using Microsoft.Maui.Services;
using System.Threading.Tasks;
*/
namespace MbtiLink.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        private readonly LocationService _locationService;

        public MainViewModel()
        {
            _locationService = new LocationService();
        }

        private string _locationText;
        public string LocationText
        {
            get => _locationText;
            set => SetProperty(ref _locationText, value);
        }

        public Command GetLocationCommand => new Command(async () => await GetLocationAsync());

        private async Task GetLocationAsync()
        {
            var location = await _locationService.GetCurrentLocationAsync();
            if (location != null)
            {
                LocationText = $"위도: {location.Latitude}, 경도: {location.Longitude}";
            }
            else
            {
                LocationText = "위치 정보를 가져올 수 없습니다.";
            }
        }
    }
}
