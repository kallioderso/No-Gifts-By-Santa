using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections.Generic;
using System.Windows.Input;
using No_Gifts_By_Santa.MVVM.View;

namespace No_Gifts_By_Santa.MVVM.ViewModel
{
    public class MenuViewModel : INotifyPropertyChanged
    {
        //Variables - Basic
        private double _buttonWidth;
        public double ButtonWidth
        {
            get => _buttonWidth;
            set => SetField(ref _buttonWidth, value);
        }
        
        //Variables - ICommands
        public ICommand _levelView { get; }
        public ICommand _creditsView { get; }
        public ICommand _settingsView { get; }
        public ICommand _tutorialView { get; }

        public MenuViewModel()
        {
            _levelView = new Command<Button>(LevelButton);
            _creditsView = new Command<Button>(CreditsButton);
            _settingsView = new Command<Button>(SettingsButton);
            _tutorialView = new Command<Button>(TutorialButton);
        }
        
        //Basic Functions for Changing the Buttons Width
        public void ChangeSize(double width, double height) => ResizingButtons(width, height);
        private void ResizingButtons(double width, double height)
        {
            Console.WriteLine(width);
            Console.WriteLine(height);
            ButtonWidth = width / 10;
            OnPropertyChanged(nameof(ButtonWidth));
        }
        
        //Button Methods / ICommands
        private async void LevelButton(Button button)
        {
            try
            {
                if (Application.Current?.MainPage?.Navigation != null)
                    await Application.Current.MainPage.Navigation.PushAsync(new MVVM.View.LevelView(), true);
            }catch (Exception){/*inactive*/}
        }
        private async void CreditsButton(Button button)
        {
            try
            {
                if (Application.Current?.MainPage?.Navigation != null)
                    await Application.Current.MainPage.Navigation.PushAsync(new MVVM.View.CreditsView(), true);
            }catch (Exception){/*inactive*/}
        }
        private async void SettingsButton(Button button)
        {
            try
            {
                if (Application.Current?.MainPage?.Navigation != null)
                    await Application.Current.MainPage.Navigation.PushAsync(new MVVM.View.SettingsView(), true);
            }catch (Exception){/*inactive*/}
        }
        private async void TutorialButton(Button button)
        {
            try
            {
                if (Application.Current?.MainPage?.Navigation != null)
                    await Application.Current.MainPage.Navigation.PushAsync(new MVVM.View.TutorialView(), true);
            }catch (Exception){/*inactive*/}
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

