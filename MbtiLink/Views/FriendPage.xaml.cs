/* 'MbtiLink (net8.0-ios)' 프로젝트에서 병합되지 않은 변경 내용
이전:
using Microsoft.Maui.Controls;
using MbtiLink.ViewModels;
이후:
using MbtiLink.ViewModels;
using Microsoft.Maui.ViewModels;
*/

/* 'MbtiLink (net8.0-maccatalyst)' 프로젝트에서 병합되지 않은 변경 내용
이전:
using Microsoft.Maui.Controls;
using MbtiLink.ViewModels;
이후:
using MbtiLink.ViewModels;
using Microsoft.Maui.ViewModels;
*/

/* 'MbtiLink (net8.0-windows10.0.19041.0)' 프로젝트에서 병합되지 않은 변경 내용
이전:
using Microsoft.Maui.Controls;
using MbtiLink.ViewModels;
이후:
using MbtiLink.ViewModels;
using Microsoft.Maui.ViewModels;
*/
namespace MbtiLink.Views
{
    public partial class FriendPage : ContentPage
    {
        private readonly FriendViewModel _viewModel;

        public FriendPage()
        {
            InitializeComponent();
            BindingContext = _viewModel = new FriendViewModel();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await _viewModel.LoadFriendsAsync();
        }
    }
}
