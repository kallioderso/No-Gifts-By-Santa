using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Button = Microsoft.Maui.Controls.Button;

namespace No_Gifts_By_Santa.MVVM.ViewModel
{
    public class SettingsViewModel : INotifyPropertyChanged
    {
        //Variables Basic
        private int SettingsPage = 1;

        //Variables Visibility
        private bool _isSoundsPageVisible = true;
        private bool _isGraphicsPageVisible = false;
        private bool _isIdkPageVisible = false;

        public bool IsSoundsPageVisible
        {
            get => _isSoundsPageVisible;
            set => SetField(ref _isSoundsPageVisible, value);
        }

        public bool IsGraphicsPageVisible
        {
            get => _isGraphicsPageVisible;
            set => SetField(ref _isGraphicsPageVisible, value);
        }

        public bool IsIdkPageVisible
        {
            get => _isIdkPageVisible;
            set => SetField(ref _isIdkPageVisible, value);
        }

        //Variables Buttons
        public ICommand _LeftPagCommand { get; }
        public ICommand _RightPageCommand { get; }
        public ICommand _SavePageSettingsCommand { get; }

        //Constructor
        public SettingsViewModel()
        {
            _LeftPagCommand = new Command<Button>(PreviousPage);
            _RightPageCommand = new Command<Button>(NextPage);
            _SavePageSettingsCommand = new Command<Button>(SavePage);
            UpdatePageVisibility();
        }

        //Methods
        private void PreviousPage(Button button)
        {
            if (SettingsPage > 1)
                SettingsPage--;
            UpdatePageVisibility();
        }

        private void NextPage(Button button)
        {
            if (SettingsPage < 3)
                SettingsPage++;
            UpdatePageVisibility();
        }

        private void SavePage(Button button)
        {
            
        }

        private void UpdatePageVisibility()
        {
            IsSoundsPageVisible = SettingsPage == 1;
            IsGraphicsPageVisible = SettingsPage == 2;
            IsIdkPageVisible = SettingsPage == 3;
        }

        //Basic Methods and Variables for ViewModel
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