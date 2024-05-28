namespace MbtiLink.Services
{
    public class FriendService
    {
        private readonly List<Friend> _friends = new List<Friend>();

        public Task<List<Friend>> GetFriendsAsync()
        {
            // 실제로는 서버에서 친구 목록을 가져오는 코드가 필요합니다.
            return Task.FromResult(_friends);
        }

        public Task AddFriendAsync(Friend friend)
        {
            // 실제로는 서버에 친구를 추가하는 코드가 필요합니다.
            _friends.Add(friend);
            return Task.CompletedTask;
        }

        public Task RemoveFriendAsync(Friend friend)
        {
            // 실제로는 서버에서 친구를 삭제하는 코드가 필요합니다.
            _friends.Remove(friend);
            return Task.CompletedTask;
        }
    }

    public class Friend
    {
        public string Name { get; set; }
        public string Id { get; set; }
    }
}
