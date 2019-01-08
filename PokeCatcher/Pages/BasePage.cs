using PokeCatcher.Core;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace PokeCatcher
{
    /// <summary>
    /// A base page for all pages to gain base functionality
    /// </summary>
    public class BasePage<VM> : Page
        where VM : BaseWindowViewModel, new()
    {

        #region Private Member

        /// <summary>
        /// The View Model associated with this page
        /// </summary>
        private VM mViewModel;

        #endregion

        #region Constructor
        /// <summary>
        /// default constructor
        /// </summary>
        public BasePage()
        {
            // if we are animating in, hide to begin with
            if (this.PageLoadAnimation != PageAnimation.None)
                this.Visibility = Visibility.Collapsed;

            // listen out for the page loading
            this.Loaded += BasePage_Loaded;

            // create a default view model
            this.ViewModel = new VM();
        }

        #endregion

        #region Animation load / unload
        /// <summary>
        /// once the page is loaded, perform any required animation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void BasePage_Loaded(object sender, RoutedEventArgs e)
        {
            // animate the page in
            await AnimateIn();
        }

        /// <summary>
        /// Animates in this page
        /// </summary>
        /// <returns></returns>
        public async Task AnimateIn()
        {
            // make sure we have something to do
            if (this.PageLoadAnimation == PageAnimation.None)
                return;

            switch (this.PageLoadAnimation)
            {
                case PageAnimation.SlideAndFadeInFromRight:
                    await this.SlideAndFadeInFromRight(this.SlideSeconds);
                    break;
            }
        }

        #endregion

        #region Public Properties
        /// <summary>
        /// the animation to play when page is first loaded
        /// </summary>
        public PageAnimation PageLoadAnimation { get; set; } = PageAnimation.SlideAndFadeInFromRight;

        /// <summary>
        /// the animation to play when page is unloaded
        /// </summary>
        public PageAnimation PageUnloadAnimation { get; set; } = PageAnimation.SlideAndFadeOutFromLeft;

        /// <summary>
        /// length of any slide animation
        /// </summary>
        public float SlideSeconds { get; set; } = 0.8f;

        /// <summary>
        /// ViewModel that is associated with this page
        /// </summary>
        public VM ViewModel
        {
            get { return mViewModel; }
            set
            {
                // if nothing has changed, return
                if (mViewModel == value)
                    return;

                // Update the value
                mViewModel = value;

                // Set the data context for this page
                this.DataContext = mViewModel;
            }
        }
        #endregion

      
    }
}
