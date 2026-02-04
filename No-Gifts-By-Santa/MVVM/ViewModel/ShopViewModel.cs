using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using No_Gifts_By_Santa.MVVM.Model;

namespace No_Gifts_By_Santa.MVVM.ViewModel
{
    public class ShopViewModel : INotifyPropertyChanged
    {
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
            get;
            private set => SetField(ref field, value);
        }

        public string Candy2
        {
            get;
            private set => SetField(ref field, value);
        }

        public string Gingerbread
        {
            get;
            private set => SetField(ref field, value);
        }

        public string Orange
        {
            get;
            private set => SetField(ref field, value);
        }

        public string Apple
        {
            get;
            private set => SetField(ref field, value);
        }

        public string Cherry
        {
            get;
            private set => SetField(ref field, value);
        }

        public string Heyhat
        {
            get;
            private set => SetField(ref field, value);
        }

        public string Hayhayhay
        {
            get;
            private set => SetField(ref field, value);
        }

        public string Carrot
        {
            get;
            private set => SetField(ref field, value);
        }

        public string Vodka
        {
            get;
            private set => SetField(ref field, value);
        }

        public string Wine
        {
            get;
            private set => SetField(ref field, value);
        }

        public string Bear
        {
            get;
            private set => SetField(ref field, value);
        }

        public string Gingerbreads
        {
            get;
            private set => SetField(ref field, value);
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
            Candy1 = $"candy_1{(Preferences.Get("CandyCane", false) ? "" : "_off")}.png";
            Candy2 = $"candy_2{(Preferences.Get("BonBon", false) ? "" : "_off")}.png";
            Gingerbread = $"gingerbread{(Preferences.Get("GingerbreadMan", false) ? "" : "_off")}.png";
            Orange = $"orange{(Preferences.Get("Orange", false) ? "" : "_off")}.png";
            Apple = $"apple{(Preferences.Get("Apple", false) ? "" : "_off")}.png";
            Cherry = $"cherry{(Preferences.Get("Cherry", false) ? "" : "_off")}.png";
            Heyhat = $"hat_2{(Preferences.Get("Hayhat", false) ? "" : "_off")}.png";
            Hayhayhay = $"heyheyhey{(Preferences.Get("pitchfork", false) ? "" : "_off")}.png";
            Carrot = $"carrot{(Preferences.Get("Carrot", false) ? "" : "_off")}.png";
            Vodka = $"vodka{(Preferences.Get("Vodka", false) ? "" : "_off")}.png";
            Wine = $"wine{(Preferences.Get("Wine", false) ? "" : "_off")}.png";
            Bear = $"bear{(Preferences.Get("Bear", false) ? "" : "_off")}.png";
        }

        private void BuyCandy1Execute() => TryBuy("CandyCane", 50, allItems.Candy(null, null));
        private void BuyCandy2Execute() => TryBuy("BonBon", 50, allItems.Candy_2(null, null));
        private void BuyGingerbreadExecute() => TryBuy("GingerbreadMan", 50, allItems.gingerbread(null, null));
        private void BuyOrangeExecute() => TryBuy("Orange", 100, allItems.orange(null, null));
        private void BuyAppleExecute() => TryBuy("Apple", 100, allItems.apple(null, null));
        private void BuyCherryExecute() => TryBuy("Cherry", 100, allItems.cherry(null, null));
        private void BuyHeyhatExecute() => TryBuy("Hayhat", 200, allItems.hat2(null, null));
        private void BuyHayhayhayExecute() => TryBuy("pitchfork", 200, allItems.heyheyhey(null, null));
        private void BuyCarrotExecute() => TryBuy("Carrot", 200, allItems.carrot(null, null));
        private void BuyVodkaExecute() => TryBuy("Vodka", 250, allItems.vodca(null, null));
        private void BuyWineExecute() => TryBuy("Wine", 250, allItems.wine(null, null));
        private void BuyBearExecute() => TryBuy("Bear", 250, allItems.bear(null, null));

        private async void TryBuy(string preferenceKey, int cost, Item item)
        {
            if (Preferences.Get(preferenceKey, false))
            {
                await Application.Current!.MainPage!.DisplayAlert(preferenceKey, $"Properties:\n\nColor: {item.Color}\nCategory: {item.Category}\nAge-group: {item.AgeGroup}\nMaterial: {item.Material}\nUsage: {item.Usage}", "close");
                return;
            }

            var balance = Preferences.Get("Lebkuchen", 0);
            if (balance < cost)
            {
                await Application.Current!.MainPage!.DisplayAlert(preferenceKey, $"Properties:\n\nColor: {item.Color}\nCategory: {item.Category}\nAge-group: {item.AgeGroup}\nMaterial: {item.Material}\nUsage: {item.Usage}", "Not Enough Gingerbread");
                return;
            }

            var buy = await Application.Current.MainPage.DisplayAlert(preferenceKey,  $"Properties:\n\nColor: {item.Color}\nCategory: {item.Category}\nAge-group: {item.AgeGroup}\nMaterial: {item.Material}\nUsage: {item.Usage}", "Buy", "close");
            if(!buy)
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