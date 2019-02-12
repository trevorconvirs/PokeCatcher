
using System;

namespace PokeCatcher.Core
{
    public class ChatMessageListItemDesignModel : ChatMessageListItemViewModel
    {
        #region Singleton

        /// <summary>
        /// A single instance of the design model
        /// </summary>
        public static ChatMessageListItemDesignModel Instance => new ChatMessageListItemDesignModel(); 
        #endregion

        #region Constructor
        public ChatMessageListItemDesignModel()
        {
            Initials = "TC";
            SenderName = "Trevor";
            Message = "This chat app is awesome! I bet it will be fast too.";
            ProfilePictureRGB = "e60000";
            SentByMe = true;
            MessageSentTime = DateTimeOffset.UtcNow;
            MessageReadTime = DateTimeOffset.UtcNow.Subtract(TimeSpan.FromDays(1.3));
        }

        #endregion
    }
}
