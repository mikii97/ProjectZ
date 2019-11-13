using WordsLearner.Data;
using WordsLearner.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordsLearner.ViewModels
{
    class PopUpViewModel : ObservableObject
    {
        #region Private variables
        /// <summary>
        /// Current application PopUp
        /// </summary>
        private PopUpPage _currentPopUp;

        /// <summary>
        /// ViewModel instance
        /// </summary>
        private static PopUpViewModel _instance;
        #endregion Private variables

        #region Public variables
        /// <summary>
        /// Current application PopUp
        /// </summary>
        public PopUpPage CurrentPopUp
        {
            get { return _currentPopUp; }
            set { OnPropertyChanged(ref _currentPopUp, value); }
        }

        /// <summary>
        /// ViewModel instance
        /// </summary>
        public static PopUpViewModel Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new PopUpViewModel();

                return _instance;
            }
        }


        #endregion Public variables

        #region Constructor

        public PopUpViewModel()
        {
        }

        #endregion Constructor

        #region Methods

        /// <summary>
        /// Changes current page to <see cref="PopUpPage"/>
        /// </summary>
        /// <param name="page"></param>
        public void LoadPopUp(PopUpPage page)
        {
            CurrentPopUp = page;
        }

        #endregion Methods
    }
}
