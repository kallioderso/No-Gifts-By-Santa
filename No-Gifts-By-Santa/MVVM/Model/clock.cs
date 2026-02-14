using Task = System.Threading.Tasks.Task;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace No_Gifts_By_Santa.MVVM.Model
{
    public class clock : INotifyPropertyChanged
    {
        public int _hours;
        public int _minutes;
        private bool _isPaused;
        public bool _finished;

        public clock()
        {
            _hours = 9;
            _minutes = 00;
        }

        public void StartClock()
        {
            _isPaused = false;
            _ = TimeLoop();
        }
        public void PauseClock() { _isPaused = true; }
        public void ResumeClock() { _isPaused = false; }

        private async Task TimeLoop()
        {
            while (_hours < 20)
            {
                await Task.Delay(1000+(Preferences.Get("Slowing", 0)*10));
                if (!_isPaused)
                {
                    if (_minutes == 45)
                    {
                        _hours++;
                        _minutes = 0;
                    }
                    else
                        _minutes += 15;

                    OnPropertyChanged(nameof(_hours));
                    OnPropertyChanged(nameof(_minutes));
                }
            }
            _finished = true;
            OnPropertyChanged(nameof(_finished));
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