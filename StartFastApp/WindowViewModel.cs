using StartFastApp.Base;
using StartFastApp.ViewModels.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace StartFastApp
{
    public class WindowViewModel: BaseViewModel
    {
        #region Private Member

        /// <summary>
        /// The current page
        /// </summary>
        private UserControl currentPage;

        /// <summary>
        /// The window this view model controls
        /// </summary>
        private Window mWindow;

        /// <summary>
        /// The margin around the window to allow for a drop shadow
        /// </summary>
        private int mOuterMarginSize = 10;

        #endregion

        #region Public Properties

        /// <summary>
        /// The size of the resize border around the window
        /// </summary>
        public int ResizeBorder { get; set; } = 6;

        /// <summary>
        /// The size of the resize border around the window, taking into account the outer margin
        /// </summary>
        public Thickness ResizeBorderThickness { get { return new Thickness(ResizeBorder + OuterMarginSize); } }

        /// <summary>
        /// The margin around the window to allow for a drop shadow
        /// </summary>
        public int OuterMarginSize
        {
            get
            {
                return mWindow.WindowState == WindowState.Maximized ? 0 : mOuterMarginSize;
            }
            set
            {
                mOuterMarginSize = value;
            }
        }

        public Thickness OuterMarginSizeThickness { get { return new Thickness(OuterMarginSize); } }

        //The height of the title bar / caption of the window
        public int TitleHeight { get; set; } = 30;

        public GridLength TitleHeightGridLength { get { return new GridLength(TitleHeight + ResizeBorder); } }

        public UserControl CurrentPage
        {
            get
            {
                return currentPage;
            }
            set
            {
                currentPage = value;
                OnPropertyChanged(nameof(CurrentPage));
            }
        }

        #endregion

        #region Commands

        /// <summary>
        /// The command to go to the Acceuil page
        /// </summary>
        public ICommand AcceuilCommand { get; set; }

        /// <summary>
        /// The command to go to the Competences page
        /// </summary>
        public ICommand Page1Command { get; set; }

        /// <summary>
        /// The command to go to the Connaissances page
        /// </summary>
        public ICommand Page2Command { get; set; }

        /// <summary>
        /// The command to go to the ParcoursProfessionnel page
        /// </summary>
        public ICommand Page3Command { get; set; }

        /// <summary>
        /// The command to go to the ParcoursScolaire page
        /// </summary>
        public ICommand Page4Command { get; set; }

        /// <summary>
        /// The command to go the Contact page
        /// </summary>
        public ICommand Page5Command { get; set; }

        /// <summary>
        /// The command to minimize the window 
        /// </summary>
        public ICommand MinimizeCommand { get; set; }


        /// <summary>
        /// The command to maximize the window
        /// </summary>
        public ICommand MaximizeCommand { get; set; }

        /// <summary>
        /// The command to close the window
        /// </summary>
        public ICommand CloseCommand { get; set; }

        //Teh command to show the menu
        public ICommand MenuCommand { get; set; }
        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="window"></param>
        public WindowViewModel(Window window)
        {
            mWindow = window;

            // Listen out for the window resizing
            mWindow.StateChanged += (sender, e) =>
            {
                //Fire off events for all properties that are affected by a resize
                OnPropertyChanged(nameof(ResizeBorderThickness));
                OnPropertyChanged(nameof(OuterMarginSize));
                OnPropertyChanged(nameof(OuterMarginSizeThickness));
            };

            //Create commands
            AcceuilCommand = new RelayCommand(AcceuilExecute);
            Page1Command = new RelayCommand(Page1Execute);
            Page2Command = new RelayCommand(Page2Execute);
            Page3Command = new RelayCommand(Page3Execute);
            Page4Command = new RelayCommand(Page4Execute);
            Page5Command = new RelayCommand(Page5Execute);
            MinimizeCommand = new RelayCommand(() => mWindow.WindowState = WindowState.Minimized);
            MaximizeCommand = new RelayCommand(() => mWindow.WindowState ^= WindowState.Maximized);
            CloseCommand = new RelayCommand(() => mWindow.Close());
            MenuCommand = new RelayCommand(() => SystemCommands.ShowSystemMenu(mWindow, GetMousePosition()));

            //Assign the content
            CurrentPage = new HomeView();            
        }

        #endregion

        #region Private Helper

        /// <summary>
        /// Get the current mouse position on the screen
        /// </summary>
        /// <returns></returns>
        private Point GetMousePosition()
        {
            return mWindow.PointToScreen(Mouse.GetPosition(mWindow));
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Set the CurrentPage to ParcoursProfessionnel
        /// </summary>
        private void Page1Execute()
        {
            //TODO
        }

        /// <summary>
        /// Set the CurrentPage to Connaissances
        /// </summary>
        private void Page2Execute()
        {
            //TODO
        }

        /// <summary>
        /// Set the CurrentPage to ParcoursScolaire
        /// </summary>
        private void Page3Execute()
        {
            //TODO
        }

        /// <summary>
        /// Set the CurrentPage to Competences
        /// </summary>
        private void Page4Execute()
        {
            //TODO
        }

        /// <summary>
        /// Set the CurrentPage to Acceuil
        /// </summary>
        private void AcceuilExecute()
        {
            //TODO
        }

        /// <summary>
        /// Set the CurrentPage to Contact
        /// </summary>
        private void Page5Execute()
        {
            //TODO
        }

        #endregion
    }
}
