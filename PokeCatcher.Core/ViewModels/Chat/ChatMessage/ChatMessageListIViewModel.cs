using System.Collections.Generic;

namespace PokeCatcher.Core
{
    /// <summary>
    /// A view Model for a chat message thread list
    /// </summary>
    public class ChatMessageListViewModel : BaseWindowViewModel
    {
        /// <summary>
        /// The displays all chat list items
        /// </summary>
        public List<ChatMessageListItemViewModel> Item { get; set; }

    }
}
