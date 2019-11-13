using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WordsLearner.Helpers
{
    public class ObservableObject : INotifyPropertyChanged
    {
        /// <summary>
        /// Event, który uruchamia się, gdy następuje zmiana w property
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        // CallerMemberName to nazwa (w stringu) tego property które, wywołało <see cref="OnPropertyChanged"/>
        // Jeżeli property to CurrentPage { get {...} set {..}) to CallerMemberName = "CurrentPage"
        /// <summary>
        /// Zaawansowana funkcja zmieniająca wartość property i wywołująca na nim event <see cref="PropertyChanged"/>
        /// 
        /// </summary>
        /// <typeparam name="T">Typ generyczny</typeparam>
        /// <param name="property">Referencja do prywatnej wrtości property</param>
        /// <param name="value">Nowa wartość</param>
        /// <param name="propertyName">Nazwa property</param>
        /// <returns></returns>
        protected virtual bool OnPropertyChanged<T>(ref T property, T value, [CallerMemberName] string propertyName = "")
        {
            if (EqualityComparer<T>.Default.Equals(property, value))
                return false;

            property = value;

            OnPropertyChanged(propertyName);

            return true;
        }
    }
}
