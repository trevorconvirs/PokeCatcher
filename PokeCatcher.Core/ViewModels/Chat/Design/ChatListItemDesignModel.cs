
namespace PokeCatcher.Core
{
    public class ChatListItemDesignModel : ChatListItemViewModel
    {
        #region Singleton

        /// <summary>
        /// A single instance of the design model
        /// </summary>
        public static ChatListItemDesignModel Instance => new ChatListItemDesignModel(); 
        #endregion

        #region Constructor
        public ChatListItemDesignModel()
        {
            Initials = "AA";
            Name = "Trevor";
            Message = "This chat app is awesome! I bet it will be fast too.";
            ProfilePictureRGB = "e60000";
        }

        #endregion
    }
}
