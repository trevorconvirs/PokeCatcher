using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeCatcher.Core
{
    public class ApplicationViewModel : BaseWindowViewModel
    {

        /// <summary>
        /// The current page user is on
        /// </summary>
        public ApplicationPage CurrentPage { get; set; } = ApplicationPage.Login;
    }
}
