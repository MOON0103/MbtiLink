using MbtiLink.Services;
/* 'MbtiLink (net8.0-ios)' 프로젝트에서 병합되지 않은 변경 내용
이전:
using System.Threading.Tasks;
using Microsoft.Maui.Controls;
이후:
using System.Collections.ObjectModel;
using System.Threading.Tasks;
*/

/* 'MbtiLink (net8.0-maccatalyst)' 프로젝트에서 병합되지 않은 변경 내용
이전:
using System.Threading.Tasks;
using Microsoft.Maui.Controls;
이후:
using System.Collections.ObjectModel;
using System.Threading.Tasks;
*/

/* 'MbtiLink (net8.0-windows10.0.19041.0)' 프로젝트에서 병합되지 않은 변경 내용
이전:
using System.Threading.Tasks;
using Microsoft.Maui.Controls;
이후:
using System.Collections.ObjectModel;
using System.Threading.Tasks;
*/


namespace MbtiLink.ViewModels
{
    public class ChatViewModel : BaseViewModel
    {
        private readonly ChatService _chatService;

        public ChatViewModel()
        {
            _chatService = new ChatService();
            _chatService.OnMessageReceived += (sender, args) =>
            {
                Messages.Add($"{args.User}: {args.Message}");
            };

            SendMessageCommand = new Command(async () => await SendMessageAsync());
        }

        public ObservableCollection<string> Messages { get; } = new ObservableCollection<string>();

        private string _message;
        public string Message
        {
            get => _message;
            set => SetProperty(ref _message, value);
        }

        public Command SendMessageCommand { get; }

        private async Task SendMessageAsync()
        {
            if (!string.IsNullOrEmpty(Message))
            {
                await _chatService.SendMessageAsync("User", Message);
                Message = string.Empty;
            }
        }

        public async Task StartAsync()
        {
            await _chatService.StartAsync();
        }

        public async Task StopAsync()
        {
            await _chatService.StopAsync();
        }
    }
}
