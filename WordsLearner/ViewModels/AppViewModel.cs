using WordsLearner.Data;
using WordsLearner.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordsLearner.ViewModels
{
    public class AppViewModel : ObservableObject
    {
        #region Private variables
        private ApplicationPage _currentPage;
        private static AppViewModel _instance;
        private string _appName = "Words Learner";
        private string _appTitle;
        #endregion private variables

        #region Public variables

        /// <summary>
        /// Actual application page
        /// </summary>
        public ApplicationPage CurrentPage
        {
            get { return _currentPage; }
            set { OnPropertyChanged(ref _currentPage, value); }
        }

        /// <summary>
        /// <see cref="AppViewModel"/> instance
        /// </summary>
        public static AppViewModel Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new AppViewModel();

                return _instance;
            }
        }

        /// <summary>
        /// Nazwa aplikacji w nagłówku okna
        /// </summary>
        public string AppTitle
        {
            get { return (_appTitle != null) ? string.Format("{0} - {1}", _appName, _appTitle) : _appName; }
            set { OnPropertyChanged(ref _appTitle, value); }
        }

        #endregion public variables


        #region Constructor
        public AppViewModel()
        {
            GoToPage(ApplicationPage.Content);
        }
        #endregion Constructor


        #region Methods
        /// <summary>
        /// Zmienia obecnie wybraną stronę na tę podaną w parametrze
        /// </summary>
        /// <param name="page"></param>
        public void GoToPage(ApplicationPage page)
        {
            CurrentPage = page;
        }
        #endregion methods

    }
}
