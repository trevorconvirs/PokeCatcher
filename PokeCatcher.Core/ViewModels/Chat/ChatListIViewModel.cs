using System.Collections.Generic;

namespace PokeCatcher.Core
{
    /// <summary>
    /// A view Model for the overview chat list
    /// </summary>
    public class ChatListViewModel : BaseWindowViewModel
    {
        /// <summary>
        /// The displays all chat list items
        /// </summary>
        public List<ChatListItemViewModel> Item { get; set; }

    }
}
