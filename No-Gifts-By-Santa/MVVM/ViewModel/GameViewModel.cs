using System.ComponentModel;
using System.Runtime.CompilerServices;
using No_Gifts_By_Santa.MVVM.Model;

namespace No_Gifts_By_Santa.MVVM.ViewModel
{
    public class GameViewModel : INotifyPropertyChanged
    {
        //Variables - Basic
        private clock _clock = new clock();
        private string _clockTime;
        public string clockTime
        {
            get => _clockTime;
            set => _clockTime = value;
        }
        public GameViewModel()
        {
            _clock.PropertyChanged += (s, e) =>
            {
                if (e.PropertyName == nameof(_clock._hours) || e.PropertyName == nameof(_clock._minutes))
                {
                    clockTime = $"clock_{_clock._hours}_{_clock._minutes:D2}.png";
                    OnPropertyChanged(nameof(clockTime));
                }
            };
            clockTime = $"clock_{_clock._hours}_{_clock._minutes:D2}.png";
            OnPropertyChanged(nameof(clockTime));
            _clock.StartClock();
        }
        
        //Basic Methods for INotifyPropertyChanged
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