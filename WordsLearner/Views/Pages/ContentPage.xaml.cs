using WordsLearner.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WordsLearner.Views.Pages
{
    /// <summary>
    /// Interaction logic for ContentPage.xaml
    /// </summary>
    public partial class ContentPage : Page
    {
        /// <summary>
        /// <see cref="ContentPage"/> instance
        /// </summary>
        private static ContentPage _instance;


        /// <summary>
        /// <see cref="AppViewModel"/> instance
        /// </summary>
        public AppViewModel App { get; set; } = AppViewModel.Instance;

        /// <summary>
        /// <see cref="ContentPageViewModel"/> instance
        /// </summary>
        public ContentPageViewModel View { get; set; } = ContentPageViewModel.Instance;


        /// <summary>
        /// <see cref="ContentPage"/> instance
        /// </summary>
        public static ContentPage Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ContentPage();
                else
                    _instance.Refresh();
                return _instance;
            }
        }
        public ContentPage()
        {
            App.AppTitle = "Content";
            InitializeComponent();
            DataContext = this;
        }

        public void Refresh()
        {
            DataContext = null;
            DataContext = this;
        }
    }
}
