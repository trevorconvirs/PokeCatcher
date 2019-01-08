using PokeCatcher.Core;
using Prism.Commands;
using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Input;

namespace PokeCatcher
{
    public class WindowViewModel : BaseWindowViewModel
    {
        #region Dependencies
        // dependencies
        private Window window;
        #endregion

        #region Private Properties
        /// <summary>
        /// Margin around window to allow drop shadow
        /// </summary>
        private int mOuterMarginSize = 10;

        /// <summary>
        /// radius of window curves
        /// </summary>
        private int mWindowRadius = 10;
        #endregion

        #region Constructor

        /// <summary>
        /// Main constructor
        /// </summary>
        /// <param name="window"></param>
        public WindowViewModel(Window window)
        {
            this.window = window;

            // listen for the window resizing
            window.StateChanged += (sender, e) => 
            {
                // Fire off events for all properties that are affected by a resize
                OnPropertyChanged(nameof(ResizeBorderThinkness));
                OnPropertyChanged(nameof(OuterMarginSize));
                OnPropertyChanged(nameof(WindowRadius));
                OnPropertyChanged(nameof(WindowCornerRadius));
            };

            MinimizeCommand = new DelegateCommand(() => window.WindowState = WindowState.Minimized);
            MaximizeCommand = new DelegateCommand(() => window.WindowState ^= WindowState.Maximized);
            CloseCommand = new DelegateCommand(() => window.Close());
            MenuCommand = new DelegateCommand(() => SystemCommands.ShowSystemMenu(window, GetMousePosisiton()));
        }
        #endregion

        #region Commands
        /// <summary>
        /// Command to minimize the window
        /// </summary>
        public ICommand MinimizeCommand { get; set; }

        /// <summary>
        /// Command to maximize the window
        /// </summary>
        public ICommand MaximizeCommand { get; set; }

        /// <summary>
        /// Command to close the window
        /// </summary>
        public ICommand CloseCommand { get; set; }

        /// <summary>
        /// Command to open the system menu
        /// </summary>
        public ICommand MenuCommand { get; set; }

        #endregion

        #region Public Properties

        /// <summary>
        /// The size of the resize around the window
        /// </summary>
        public int ResizeBorder { get ; set; } = 6;

        /// <summary>
        /// Size of border around window taking account of the outer margin
        /// </summary>
        public Thickness ResizeBorderThinkness { get { return new Thickness(ResizeBorder + OuterMarginSize); } }

        /// <summary>
        /// Bindable outer margin size
        /// </summary>
        public Thickness OuterMarginSizeThicknes { get { return new Thickness(OuterMarginSize); } }

        /// <summary>
        /// Bindable Window Corner Radius
        /// </summary>
        public CornerRadius WindowCornerRadius { get { return new CornerRadius(WindowRadius); } }

        /// <summary>
        /// Outer margin size for the window
        /// </summary>
        public int OuterMarginSize
        {
            get { return window.WindowState == WindowState.Maximized ? 0 : mOuterMarginSize; }
            set { mOuterMarginSize = value; }
        }

        /// <summary>
        /// Window Radius for main window
        /// </summary>
        public int WindowRadius
        {
            get { return window.WindowState == WindowState.Maximized ? 0 : mWindowRadius; }
            set { mWindowRadius = value; }
        }


        /// <summary>
        /// The height of the title bar
        /// </summary>
        public int TitleHeight { get; set; } = 42; 

        /// <summary>
        /// Bindable title height grid length
        /// </summary>
        public GridLength TitleHeightGridLength { get { return new GridLength(TitleHeight + ResizeBorder); } }

        /// <summary>
        /// Smallest width window can go
        /// </summary>
        public double WindowMinWidth { get; set; } = 800;

        /// <summary>
        /// Smallest heigth window can go
        /// </summary>
        public double WindowMinHeigth { get; set; } = 500;

        /// <summary>
        /// content padding within main window
        /// </summary>
        public int InnerContentSize { get; set; } = 0;

        /// <summary>
        /// bindable inner content padding
        /// </summary>
        public Thickness InnerContentPadding { get { return new Thickness(InnerContentSize); } }

        #endregion

        #region Private Helpers

        /// <summary>
        /// Keeps track of properties that are dependent on other properties
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PropigatePropertyChangedNotifications(object sender, PropertyChangedEventArgs e)
        {
            //switch (e.PropertyName)
            //{
            //    case "RateSpreadResult":
            //        SetResultFields();
            //        break;
            //}
        }

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool GetCursorPos(ref Win32Point pt);

        [StructLayout(LayoutKind.Sequential)]
        internal struct Win32Point
        {
            public Int32 X;
            public Int32 Y;
        };

        /// <summary>
        /// Gets the current mouse posistion on the screen
        /// </summary>
        /// <returns></returns>
        private static Point GetMousePosisiton()
        {
            Win32Point w32Mouse = new Win32Point();
            GetCursorPos(ref w32Mouse);
            return new Point(w32Mouse.X, w32Mouse.Y);
        }


        #endregion
    }
}
