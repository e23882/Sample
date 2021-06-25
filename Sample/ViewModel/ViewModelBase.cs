using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Sample
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        #region Declarations
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion

        #region Memberfunction
        public void OnPropertyChanged([CallerMemberName]string propertyName = "") 
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

    }
}
