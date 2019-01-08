using System.Security;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PokeCatcher.Core
{
    /// <summary>
    /// View Model for a login screen
    /// </summary>
    public class LoginViewModel : BaseWindowViewModel
    {
        #region Dependencies

        #endregion

        #region Private Members



        #endregion

        #region Constructor

        /// <summary>
        /// Main constructor
        /// </summary>
        public LoginViewModel()
        {
            LoginCommand = new RelayParameterizedCommand(async (parameter) => await Login(parameter));
            RegisterCommand = new RelayParameterizedCommand(async (parameter) => await RegisterAsync());
        }

        #endregion

        #region Commands

        /// <summary>
        /// Command to open the system menu
        /// </summary>
        public ICommand LoginCommand { get; set; }


        /// <summary>
        /// Command to open the system menu
        /// </summary>
        public ICommand RegisterCommand { get; set; }

        #endregion

        #region Public Properties

        /// <summary>
        /// The email of the user
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Flag to determine if user is still logging in
        /// </summary>
        public bool LoginIsRunning { get; set; }
        public bool Enabled { get { return !LoginIsRunning; } }
        #endregion

        #region Private Helpers

        #endregion

        #region Methods

        /// <summary>
        /// Attempts to log user in
        /// </summary>
        /// <param name="parameter">The <see cref="SecureString"/> passed in from the view for the users passwored</param>
        /// <returns></returns>
        public async Task Login(object parameter)
        {
            await RunCommand(() => this.LoginIsRunning, async () =>
            {
                //OnPropertyChanged("LoginIsRunning");
                await Task.Delay(5000);

                var email = this.Email;

                // IMPORTANT: Never store unsecure password in variable like this
                var pass = (parameter as IHavePassword).SecurePassword.Unsecure();
                
            });
            //OnPropertyChanged("LoginIsRunning");
        }


        /// <summary>
        /// Takes the user to the register page
        /// </summary>
        /// <returns></returns>
        public async Task RegisterAsync()
        {
            await Task.Delay(1);
            IoC.Get<ApplicationViewModel>().CurrentPage = ApplicationPage.Register;
        }
        #endregion
    }
}
