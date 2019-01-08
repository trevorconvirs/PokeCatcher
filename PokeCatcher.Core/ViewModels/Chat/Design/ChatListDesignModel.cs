
using System.Collections.Generic;

namespace PokeCatcher.Core
{
    public class ChatListDesignModel : ChatListViewModel
    {
        #region Singleton

        /// <summary>
        /// A single instance of the design model
        /// </summary>
        public static ChatListDesignModel Instance => new ChatListDesignModel();
        #endregion

        #region Constructor
        public ChatListDesignModel()
        {
            Item = new List<ChatListItemViewModel>
           {
               new ChatListItemViewModel
               {
                   Name = "Trevor",
                   Initials = "TC",
                   Message = "I am BatMan!",
                   ProfilePictureRGB = "3099c5",
                   NewContentAvail = true,
                   
               },
               new ChatListItemViewModel
               {
                   Initials = "HC",
                   Name = "Hollie",
                   Message = "This chat app is awesome! I bet it will be fast too.",
                   ProfilePictureRGB = "e60000"
                },
               new ChatListItemViewModel
               {
                   Initials = "CC",
                   Name = "Colson",
                   Message = "Hey dud, here is the new icon",
                   ProfilePictureRGB = "fe5403",
                   IsSelected = true
                },
               new ChatListItemViewModel
               {
                   Initials = "AT",
                   Name = "April",
                   Message = "The new server is up, go to 192.168.1.1 to check it out.",
                   ProfilePictureRGB = "ef5045"
                },
               new ChatListItemViewModel
               {
                   Initials = "ST",
                   Name = "Steven",
                   Message = "This chat app is awesome! I bet it will be fast too.",
                   ProfilePictureRGB = "fe4305"
                },
                new ChatListItemViewModel
               {
                   Name = "Trevor",
                   Initials = "TC",
                   Message = "I am BatMan!",
                   ProfilePictureRGB = "3099c5"
               },
               new ChatListItemViewModel
               {
                   Initials = "HC",
                   Name = "Hollie",
                   Message = "This chat app is awesome! I bet it will be fast too.",
                   ProfilePictureRGB = "e60000"
                },
               new ChatListItemViewModel
               {
                   Initials = "CC",
                   Name = "Colson",
                   Message = "Hey dud, here is the new icon",
                   ProfilePictureRGB = "fe5403"
                },
               new ChatListItemViewModel
               {
                   Initials = "AT",
                   Name = "April",
                   Message = "The new server is up, go to 192.168.1.1 to check it out.",
                   ProfilePictureRGB = "ef5045"
                },
               new ChatListItemViewModel
               {
                   Initials = "ST",
                   Name = "Steven",
                   Message = "This chat app is awesome! I bet it will be fast too.",
                   ProfilePictureRGB = "fe4305"
                },
            };
        }

        #endregion
    }
}
