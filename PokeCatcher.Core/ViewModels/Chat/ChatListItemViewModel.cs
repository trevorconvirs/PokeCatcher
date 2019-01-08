namespace PokeCatcher.Core
{
    /// <summary>
    /// A view Model for each chat list item in the overview chat list
    /// </summary>
    public class ChatListItemViewModel : BaseWindowViewModel
    {
        /// <summary>
        /// The display name of this chat list
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The latest message from this chat
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// The initials to show for the profile picture background
        /// </summary>
        public string Initials { get; set; }

        /// <summary>
        /// The RGB values (in hex) for the backgeround color of the profile picture
        /// </summary>
        public string ProfilePictureRGB { get; set; }

        /// <summary>
        /// true if there are unread messages in this chat
        /// </summary>
        public bool NewContentAvail { get; set; }

        /// <summary>
        /// True if this itme is currently selectd
        /// </summary>
        public bool IsSelected { get; set; }
    }
}
