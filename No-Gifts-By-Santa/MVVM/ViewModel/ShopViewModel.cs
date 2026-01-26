using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Storage;

namespace No_Gifts_By_Santa.MVVM.ViewModel
{
    public class ShopViewModel : INotifyPropertyChanged
    {
        private string _gingerbreads;
        private string _candy1;
        private string _candy2;
        private string _gingerbread;
        private string _orange;
        private string _apple;
        private string _cherry;
        private string _heyhat;
        private string _hayhayhay;
        private string _carrot;

        public ICommand BuyCandy1 { get; }
        public ICommand BuyCandy2 { get; }
        public ICommand BuyGingerbread { get; }
        public ICommand BuyOrange { get; }
        public ICommand BuyApple { get; }
        public ICommand BuyCherry { get; }
        public ICommand BuyHeyhat { get; }
        public ICommand BuyHayhayhay { get; }
        public ICommand BuyCarrot { get; }

        // Item images
        public string Candy1
        {
            get => _candy1;
            private set => SetField(ref _candy1, value);
        }

        public string Candy2
        {
            get => _candy2;
            private set => SetField(ref _candy2, value);
        }

        public string Gingerbread
        {
            get => _gingerbread;
            private set => SetField(ref _gingerbread, value);
        }

        public string Orange
        {
            get => _orange;
            private set => SetField(ref _orange, value);
        }

        public string Apple
        {
            get => _apple;
            private set => SetField(ref _apple, value);
        }

        public string Cherry
        {
            get => _cherry;
            private set => SetField(ref _cherry, value);
        }

        public string Heyhat
        {
            get => _heyhat;
            private set => SetField(ref _heyhat, value);
        }

        public string Hayhayhay
        {
            get => _hayhayhay;
            private set => SetField(ref _hayhayhay, value);
        }

        public string Carrot
        {
            get => _carrot;
            private set => SetField(ref _carrot, value);
        }

        public string Gingerbreads
        {
            get => _gingerbreads;
            private set => SetField(ref _gingerbreads, value);
        }

        public ShopViewModel()
        {
            BuyCandy1 = new Command(BuyCandy1Execute);
            BuyCandy2 = new Command(BuyCandy2Execute);
            BuyGingerbread = new Command(BuyGingerbreadExecute);
            BuyOrange = new Command(BuyOrangeExecute);
            BuyApple = new Command(BuyAppleExecute);
            BuyCherry = new Command(BuyCherryExecute);
            BuyHeyhat = new Command(BuyHeyhatExecute);
            BuyHayhayhay = new Command(BuyHayhayhayExecute);
            BuyCarrot = new Command(BuyCarrotExecute);

            RefreshGingerbreads();
            RefreshImages();
        }

        private void RefreshGingerbreads()
        {
            Gingerbreads = Preferences.Get("Lebkuchen", 0).ToString();
        }

        private void RefreshImages()
        {
            Candy1 = $"candy_1{(Preferences.Get("Candy1", false) ? "" : "_off")}.png";
            Candy2 = $"candy_2{(Preferences.Get("Candy2", false) ? "" : "_off")}.png";
            Gingerbread = $"gingerbread{(Preferences.Get("Candy3", false) ? "" : "_off")}.png";
            Orange = $"orange{(Preferences.Get("Orange", false) ? "" : "_off")}.png";
            Apple = $"apple{(Preferences.Get("Apple", false) ? "" : "_off")}.png";
            Cherry = $"cherry{(Preferences.Get("Cherry", false) ? "" : "_off")}.png";
            Heyhat = $"hat_2{(Preferences.Get("Hayhat", false) ? "" : "_off")}.png";
            Hayhayhay = $"heyheyhey{(Preferences.Get("Heyheyhey", false) ? "" : "_off")}.png";
            Carrot = $"carrot{(Preferences.Get("Carrot", false) ? "" : "_off")}.png";
        }

        private void BuyCandy1Execute() => TryBuy("Candy1", 50);
        private void BuyCandy2Execute() => TryBuy("Candy2", 50);
        private void BuyGingerbreadExecute() => TryBuy("Candy3", 50);
        private void BuyOrangeExecute() => TryBuy("Orange", 100);
        private void BuyAppleExecute() => TryBuy("Apple", 100);
        private void BuyCherryExecute() => TryBuy("Cherry", 100);
        private void BuyHeyhatExecute() => TryBuy("Hayhat", 200);
        private void BuyHayhayhayExecute() => TryBuy("Heyheyhey", 200);
        private void BuyCarrotExecute() => TryBuy("Carrot", 200);

        private void TryBuy(string preferenceKey, int cost)
        {
            if (Preferences.Get(preferenceKey, false))
                return;

            var balance = Preferences.Get("Lebkuchen", 0);
            if (balance < cost)
                return;

            var updatedBalance = balance - cost;
            Preferences.Set("Lebkuchen", updatedBalance);
            Preferences.Set(preferenceKey, true);

            RefreshImages();
            RefreshGingerbreads();
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