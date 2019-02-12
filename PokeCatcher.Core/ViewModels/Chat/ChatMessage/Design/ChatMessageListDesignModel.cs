
using System;
using System.Collections.Generic;

namespace PokeCatcher.Core
{
    public class ChatMessageListDesignModel : ChatMessageListViewModel
    {
        #region Singleton

        /// <summary>
        /// A single instance of the design model
        /// </summary>
        public static ChatMessageListDesignModel Instance => new ChatMessageListDesignModel();
        #endregion

        #region Constructor
        public ChatMessageListDesignModel()
        {
            Item = new List<ChatMessageListItemViewModel>
           {
               new ChatMessageListItemViewModel
               {
                   SenderName = "Colton",
                   Initials = "CF",
                   Message = "I'm about to wipe the old server. We need to update the old server to Windows 2020",
                   ProfilePictureRGB = "3099c5",
                   MessageSentTime = DateTimeOffset.UtcNow,
                   SentByMe = false,

               },new ChatMessageListItemViewModel
               {
                   SenderName = "Trevor",
                   Initials = "TC",
                   Message = "Let me know when you have spun up the new server",
                   ProfilePictureRGB = "3099c5",
                   MessageSentTime = DateTimeOffset.UtcNow,
                   MessageReadTime = DateTimeOffset.UtcNow.Subtract(TimeSpan.FromDays(1.3)),
                   SentByMe = true,

               },new ChatMessageListItemViewModel
               {
                   SenderName = "Colton",
                   Initials = "CF",
                   Message = "The new server is up. Go to 192.168.1.1. \r\n  Username is admin, password is password",
                   ProfilePictureRGB = "3099c5",
                   MessageSentTime = DateTimeOffset.UtcNow,
                   SentByMe = false,

               },

            };
        }

        #endregion
    }
}
