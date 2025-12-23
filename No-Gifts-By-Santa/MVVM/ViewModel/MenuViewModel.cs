using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections.Generic;

namespace No_Gifts_By_Santa.MVVM.ViewModel
{
    public class MenuViewModel : INotifyPropertyChanged
    {
        private double _buttonWidth;
        public double ButtonWidth
        {
            get => _buttonWidth;
            set => SetField(ref _buttonWidth, value);
        }

        //Ba
        public void ChangeSize(double width, double height) => ResizingButtons(width, height);
        private void ResizingButtons(double width, double height)
        {
            Console.WriteLine(width);
            Console.WriteLine(height);
            ButtonWidth = width / 10;
            OnPropertyChanged(nameof(ButtonWidth));
        }
        
        //Basic Logics for the ViewModel functions.
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

