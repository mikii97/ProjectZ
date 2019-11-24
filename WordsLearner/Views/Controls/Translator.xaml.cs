using WordsLearner.Data;
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

namespace WordsLearner.Views.Controls
{
    /// <summary>
    /// Interaction logic for Translator.xaml
    /// </summary>
    public partial class Translator : UserControl
    {
        public AppViewModel App { get; set; } = AppViewModel.Instance;
        public ContentPageViewModel View { get; set; } = ContentPageViewModel.Instance;
                      
        public Translator()
        {
            App.AppTitle = "Translator";
            InitializeComponent();
            DataContext = this;
        }

        /// <summary>
        /// Submit button click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            // Not developed yet.
            new NotImplementedException();
        }
    }
}
