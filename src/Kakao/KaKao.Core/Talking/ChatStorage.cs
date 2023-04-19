using Kakao.Core.Models;
using System.Collections.Generic;

namespace Kakao.Core.Talking
{
    public class ChatStorage
    {
        private Dictionary<FriendsModel, List<MessageModel>> _chatHistory;

        public ChatStorage()
        {
            _chatHistory = new();
        }

        public void Add(FriendsModel _receiver, MessageModel message)
        {
            if (!_chatHistory.ContainsKey(_receiver))
            {
                _chatHistory.Add(_receiver, new());
            }
            _chatHistory[_receiver].Add(message);
        }

        public List<MessageModel> GetChatHistory(FriendsModel receiver)
        {
            if (!_chatHistory.ContainsKey(receiver))
            {
                _chatHistory.Add(receiver, new());
            }
            return _chatHistory[receiver];
        }
    }
}
