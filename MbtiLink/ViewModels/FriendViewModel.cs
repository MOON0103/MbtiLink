
/* 'MbtiLink (net8.0-ios)' 프로젝트에서 병합되지 않은 변경 내용
이전:
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using MbtiLink.Models;
이후:
using MbtiLink.Models;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
*/

/* 'MbtiLink (net8.0-maccatalyst)' 프로젝트에서 병합되지 않은 변경 내용
이전:
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using MbtiLink.Models;
이후:
using MbtiLink.Models;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
*/

/* 'MbtiLink (net8.0-windows10.0.19041.0)' 프로젝트에서 병합되지 않은 변경 내용
이전:
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using MbtiLink.Models;
이후:
using MbtiLink.Models;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
*/
using MbtiLink.Models;
using System.Collections.ObjectModel;

namespace MbtiLink.ViewModels
{
    public class FriendViewModel : BaseViewModel
    {
        private ObservableCollection<Friend> _friends;
        public ObservableCollection<Friend> Friends
        {
            get => _friends;
            set => SetProperty(ref _friends, value);
        }

        public FriendViewModel()
        {
            Friends = new ObservableCollection<Friend>();
        }

        public async Task LoadFriendsAsync()
        {
            // 여기에 친구 데이터를 로드하는 코드를 추가합니다.
            // 예시 데이터:
            await Task.Run(() =>
            {
                Friends.Add(new Friend { Name = "Alice" });
                Friends.Add(new Friend { Name = "Bob" });
                Friends.Add(new Friend { Name = "Charlie" });
            });
        }
    }
}
