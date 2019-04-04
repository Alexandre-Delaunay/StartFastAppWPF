using StartFastApp.Base;
using StartFastApp.ViewModels.Popup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using StartFastApp.Traductions;

namespace StartFastApp.ViewModels.Home
{
    public class HomeViewModel: BaseViewModel
    {
        #region Members

        #endregion

        #region Properties

        public ICommand OpenPopupCommand { get; set; }

        #endregion

        #region Constructor

        public HomeViewModel()
        {
            Initialize();
        }

        #endregion

        #region Private Methods
        private void OpenPopupExecute()
        {
            var homeview = new HomeView();
            Window popup = new PopupView(homeview, ResGeneral.Home);
            popup.ShowDialog();
        }

        #endregion

        #region Public Methods
        public void Initialize()
        {
            OpenPopupCommand = new RelayCommand(OpenPopupExecute);
        }

        #endregion

    }
}
