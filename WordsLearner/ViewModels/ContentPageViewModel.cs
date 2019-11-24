using WordsLearner.Data;
using WordsLearner.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordsLearner.ViewModels
{
    public class ContentPageViewModel : ObservableObject
    {
        #region Prywatne zmienne
        private AppView _currentView;
        private AppView _previousView;
        private static ContentPageViewModel _instance;
        #endregion Prywatne zmienne

        #region Public variables
        public AppView CurrentView
        {
            get { return _currentView; }
            set { OnPropertyChanged(ref _currentView, value); }
        }

        public AppView PreviousView
        {
            get { return _previousView; }
            set { _previousView = value; }
        }
        public static ContentPageViewModel Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ContentPageViewModel();
                return _instance;
            }
        }
        #endregion public variables

        public ContentPageViewModel()
        {
            ChangeView(AppView.Translator);
        }

        public void ChangeView(AppView view)
        {
            PreviousView = CurrentView;
            CurrentView = view;
        }
    }
}
