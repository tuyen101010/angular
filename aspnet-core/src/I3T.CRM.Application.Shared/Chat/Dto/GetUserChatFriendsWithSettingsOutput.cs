using System;
using System.Collections.Generic;
using Castle.Components.DictionaryAdapter;
using I3T.CRM.Friendships.Dto;

namespace I3T.CRM.Chat.Dto
{
    public class GetUserChatFriendsWithSettingsOutput
    {
        public DateTime ServerTime { get; set; }
        
        public List<FriendDto> Friends { get; set; }

        public GetUserChatFriendsWithSettingsOutput()
        {
            Friends = new EditableList<FriendDto>();
        }
    }
}