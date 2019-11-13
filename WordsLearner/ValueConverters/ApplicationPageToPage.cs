using WordsLearner.Data;
using WordsLearner.Views.Pages;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace WordsLearner.ValueConverters
{
    /// <summary>
    /// Changes value of <see cref="ApplicationPage"/> to corresponding View
    /// </summary>
    class ApplicationPageToPage : IValueConverter
    {
        /// <summary>
        /// Converts value <see cref="ApplicationPage"/> to page
        /// </summary>
        /// <param name="value"></param>
        /// <param name="targetType"></param>
        /// <param name="parameter"></param>
        /// <param name="culture"></param>
        /// <returns></returns>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            switch ((ApplicationPage)value)
            {
                case ApplicationPage.Content:
                    return ContentPage.Instance;

                default:
                    return null;
            }
        }

        /// <summary>
        /// Converts page to <see cref="ApplicationPage"/>
        /// </summary>
        /// <param name="value"></param>
        /// <param name="targetType"></param>
        /// <param name="parameter"></param>
        /// <param name="culture"></param>
        /// <returns></returns>
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
