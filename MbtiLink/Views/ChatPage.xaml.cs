using MbtiLink.ViewModels;

namespace MbtiLink.Views
{
    public partial class ChatPage : ContentPage
    {
        private readonly ChatViewModel _viewModel;

        public ChatPage()
        {
            InitializeComponent();
            BindingContext = _viewModel = new ChatViewModel();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await _viewModel.StartAsync();
        }

        protected override async void OnDisappearing()
        {
            await _viewModel.StopAsync();
            base.OnDisappearing();
        }
    }
}
