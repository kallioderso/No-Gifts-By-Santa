using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace No_Gifts_By_Santa.MVVM.ViewModel
{
    public class ShopViewModel : INotifyPropertyChanged
    {
        public string _gingerBread { get; }
        public ShopViewModel()
        {
            _gingerBread = Preferences.Get("Lebkuchen", 0).ToString();
            OnPropertyChanged(nameof(_gingerBread));
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string? propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value)) return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }

    }
}