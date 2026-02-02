using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Microsoft.Maui.Controls;
using No_Gifts_By_Santa.MVVM.View;


namespace No_Gifts_By_Santa.MVVM.ViewModel
{
    public class LevelViewModel : INotifyPropertyChanged
    {
        //ICommands
        public ICommand Day1 { get; }
        public ICommand Day2 { get; }
        public ICommand Day3 { get; }
        public ICommand Day4 { get; }
        public ICommand Day5 { get; }
        public ICommand Day6 { get; }
        public ICommand Day7 { get; }
        public ICommand Day8 { get; }
        public ICommand Day9 { get; }
        public ICommand Day10 { get; }
        public ICommand Day11 { get; }
        public ICommand Day12 { get; }
        public ICommand Day13 { get; }
        public ICommand Day14 { get; }
        public ICommand Day15 { get; }
        public ICommand Day16 { get; }
        public ICommand Day17 { get; }
        public ICommand Day18 { get; }
        public ICommand Day19 { get; }
        public ICommand Day20 { get; }
        public ICommand Day21 { get; }
        public ICommand Day22 { get; }
        public ICommand Day23 { get; }
        public ICommand Day24 { get; }

        //Variables for Level Images
        public string Level1 { get; }
        public string Level2 { get; }
        public string Level3 { get; }
        public string Level4 { get; }
        public string Level5 { get; }
        public string Level6 { get; }
        public string Level7 { get; }
        public string Level8 { get; }
        public string Level9 { get; }
        public string Level10 { get; }
        public string Level11 { get; }
        public string Level12 { get; }
        public string Level13 { get; }
        public string Level14 { get; }
        public string Level15 { get; }
        public string Level16 { get; }
        public string Level17 { get; }
        public string Level18 { get; }
        public string Level19 { get; }
        public string Level20 { get; }
        public string Level21 { get; }
        public string Level22 { get; }
        public string Level23 { get; }
        public string Level24 { get; }

        //Constructor
        public LevelViewModel()
        {
            Day1 = new Command<ImageButton>(SelectLevel1);
            Day2 = new Command<ImageButton>(SelectLevel2);
            Day3 = new Command<ImageButton>(SelectLevel3);
            Day4 = new Command<ImageButton>(SelectLevel4);
            Day5 = new Command<ImageButton>(SelectLevel5);
            Day6 = new Command<ImageButton>(SelectLevel6);
            Day7 = new Command<ImageButton>(SelectLevel7);
            Day8 = new Command<ImageButton>(SelectLevel8);
            Day9 = new Command<ImageButton>(SelectLevel9);
            Day10 = new Command<ImageButton>(SelectLevel10);
            Day11 = new Command<ImageButton>(SelectLevel11);
            Day12 = new Command<ImageButton>(SelectLevel12);
            Day13 = new Command<ImageButton>(SelectLevel13);
            Day14 = new Command<ImageButton>(SelectLevel14);
            Day15 = new Command<ImageButton>(SelectLevel15);
            Day16 = new Command<ImageButton>(SelectLevel16);
            Day17 = new Command<ImageButton>(SelectLevel17);
            Day18 = new Command<ImageButton>(SelectLevel18);
            Day19 = new Command<ImageButton>(SelectLevel19);
            Day20 = new Command<ImageButton>(SelectLevel20);
            Day21 = new Command<ImageButton>(SelectLevel21);
            Day22 = new Command<ImageButton>(SelectLevel22);
            Day23 = new Command<ImageButton>(SelectLevel23);
            Day24 = new Command<ImageButton>(SelectLevel24);
            Level1 = $"level_calender_1{(Preferences.Get("level", 1) >= 1 ? "" : "_off")}.png";
            Level2 = $"level_calender_2{(Preferences.Get("level", 1) >= 2 ? "" : "_off")}.png";
            Level3 = $"level_calender_3{(Preferences.Get("level", 1) >= 3 ? "" : "_off")}.png";
            Level4 = $"level_calender_4{(Preferences.Get("level", 1) >= 4 ? "" : "_off")}.png";
            Level5 = $"level_calender_5{(Preferences.Get("level", 1) >= 5 ? "" : "_off")}.png";
            Level6 = $"level_calender_6{(Preferences.Get("level", 1) >= 6 ? "" : "_off")}.png";
            Level7 = $"level_calender_7{(Preferences.Get("level", 1) >= 7 ? "" : "_off")}.png";
            Level8 = $"level_calender_8{(Preferences.Get("level", 1) >= 8 ? "" : "_off")}.png";
            Level9 = $"level_calender_9{(Preferences.Get("level", 1) >= 9 ? "" : "_off")}.png";
            Level10 = $"level_calender_10{(Preferences.Get("level", 1) >= 10 ? "" : "_off")}.png";
            Level11 = $"level_calender_11{(Preferences.Get("level", 1) >= 11 ? "" : "_off")}.png";
            Level12 = $"level_calender_12{(Preferences.Get("level", 1) >= 12 ? "" : "_off")}.png";
            Level13 = $"level_calender_13{(Preferences.Get("level", 1) >= 13 ? "" : "_off")}.png";
            Level14 = $"level_calender_14{(Preferences.Get("level", 1) >= 14 ? "" : "_off")}.png";
            Level15 = $"level_calender_15{(Preferences.Get("level", 1) >= 15 ? "" : "_off")}.png";
            Level16 = $"level_calender_16{(Preferences.Get("level", 1) >= 16 ? "" : "_off")}.png";
            Level17 = $"level_calender_17{(Preferences.Get("level", 1) >= 17 ? "" : "_off")}.png";
            Level18 = $"level_calender_18{(Preferences.Get("level", 1) >= 18 ? "" : "_off")}.png";
            Level19 = $"level_calender_19{(Preferences.Get("level", 1) >= 19 ? "" : "_off")}.png";
            Level20 = $"level_calender_20{(Preferences.Get("level", 1) >= 20 ? "" : "_off")}.png";
            Level21 = $"level_calender_21{(Preferences.Get("level", 1) >= 21 ? "" : "_off")}.png";
            Level22 = $"level_calender_22{(Preferences.Get("level", 1) >= 22 ? "" : "_off")}.png";
            Level23 = $"level_calender_23{(Preferences.Get("level", 1) >= 23 ? "" : "_off")}.png";
            Level24 = $"level_calender_24{(Preferences.Get("level", 1) >= 24 ? "" : "_off")}.png";
        }


        //Method for Level Selection
        private void SelectLevel1(ImageButton obj) => OpenLevelAsync(1);
        private void SelectLevel2(ImageButton obj) => OpenLevelAsync(2);
        private void SelectLevel3(ImageButton obj) => OpenLevelAsync(3);
        private void SelectLevel4(ImageButton obj) => OpenLevelAsync(4);
        private void SelectLevel5(ImageButton obj) => OpenLevelAsync(5);
        private void SelectLevel6(ImageButton obj) => OpenLevelAsync(6);
        private void SelectLevel7(ImageButton obj) => OpenLevelAsync(7);
        private void SelectLevel8(ImageButton obj) => OpenLevelAsync(8);
        private void SelectLevel9(ImageButton obj) => OpenLevelAsync(9);
        private void SelectLevel10(ImageButton obj) => OpenLevelAsync(10);
        private void SelectLevel11(ImageButton obj) => OpenLevelAsync(11);
        private void SelectLevel12(ImageButton obj) => OpenLevelAsync(12);
        private void SelectLevel13(ImageButton obj) => OpenLevelAsync(13);
        private void SelectLevel14(ImageButton obj) => OpenLevelAsync(14);
        private void SelectLevel15(ImageButton obj) => OpenLevelAsync(15);
        private void SelectLevel16(ImageButton obj) => OpenLevelAsync(16);
        private void SelectLevel17(ImageButton obj) => OpenLevelAsync(17);
        private void SelectLevel18(ImageButton obj) => OpenLevelAsync(18);
        private void SelectLevel19(ImageButton obj) => OpenLevelAsync(19);
        private void SelectLevel20(ImageButton obj) => OpenLevelAsync(20);
        private void SelectLevel21(ImageButton obj) => OpenLevelAsync(21);
        private void SelectLevel22(ImageButton obj) => OpenLevelAsync(22);
        private void SelectLevel23(ImageButton obj) => OpenLevelAsync(23);
        private void SelectLevel24(ImageButton obj) => OpenLevelAsync(24);

        private async Task OpenLevelAsync(int level)
        {
            if (!(Preferences.Get("level", 1) >= level))
                Application.Current!.MainPage!.DisplayAlert("it isnt the time yet!", $"pls finish first Day {Preferences.Get("level", 1)}, before attempting this one", "ok");
            else
            {
                try
                {
                    if (Application.Current?.MainPage?.Navigation != null)
                        await Application.Current.MainPage.Navigation.PushAsync(new GameView(level), true);
                }
                catch (Exception)
                {
                    /*inactive*/
                }
            }
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