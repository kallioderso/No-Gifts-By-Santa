using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using No_Gifts_By_Santa.MVVM.Model;
namespace No_Gifts_By_Santa.MVVM.ViewModel
{
    public class UpgradeViewModel : INotifyPropertyChanged
    {
        // Commands
        public ICommand BuySlow1 { get; }
        public ICommand BuySlow2 { get; }
        public ICommand BuySlow3 { get; }
        public ICommand BuySlow4 { get; }

        // Strings
        public string Slow1
        {
            get;
            private set => SetField(ref field, value);
        }
        public string Slow2
        {
            get;
            private set => SetField(ref field, value);
        }
        public string Slow3
        {
            get;
            private set => SetField(ref field, value);
        }
        public string Slow4
        {
            get;
            private set => SetField(ref field, value);
        }

        public string Gingerbreads
        {
            get;
            private set => SetField(ref field, value);
        }

        public UpgradeViewModel()
        {
            BuySlow1 = new Command(() => TryBuy("Slow1", "Extends your work days by 30%!", 200, "", 30));
            BuySlow2 = new Command(() => TryBuy("Slow2", "Extends your work days by 55%!", 300, "Slow1", 55));
            BuySlow3 = new Command(() => TryBuy("Slow3", "Extends your work days by 75%!", 400, "Slow2", 75));
            BuySlow4 = new Command(() => TryBuy("Slow4", "Extends your work days by 90%!", 500, "Slow3", 90));
            
            RefreshImages();
            RefreshGingerbreads();
        }

        private void RefreshImages()
        {
            Slow1 = $"time_slow_1{(Preferences.Get("Slow1", false) ? "" : "_off")}.png";
            Slow2 = $"time_slow_2{(Preferences.Get("Slow2", false) ? "" : "_off")}.png";
            Slow3 = $"time_slow_3{(Preferences.Get("Slow3", false) ? "" : "_off")}.png";
            Slow4 = $"time_slow_4{(Preferences.Get("Slow4", false) ? "" : "_off")}.png";
        }

        private void RefreshGingerbreads()
        {
            Gingerbreads = Preferences.Get("Lebkuchen", 0).ToString();
        }

        private async Task TryBuy(string preferenceKey, string sDescription, int cost, string sDependency, int slowbonus)
        {
            // Prüfe ob Upgrade bereits gekauft wurde
            if (Preferences.Get(preferenceKey, false))
            {
                await Application.Current!.MainPage!.DisplayAlert(preferenceKey, "Dieses Upgrade wurde bereits gekauft!", "Schließen");
                return;
            }

            // Prüfe ob Voraussetzung erfüllt ist (nur wenn nicht null/leer)
            if (!string.IsNullOrEmpty(sDependency) && !Preferences.Get(sDependency, false))
            {
                await Application.Current!.MainPage!.DisplayAlert(preferenceKey, $"Du musst zuerst {sDependency} kaufen!", "Schließen");
                return;
            }

            // Prüfe Gingerbread-Balance
            var balance = Preferences.Get("Lebkuchen", 0);
            if (balance < cost)
            {
                await Application.Current!.MainPage!.DisplayAlert(preferenceKey, $"Nicht genug Lebkuchen! Du brauchst {cost}, hast aber nur {balance}.", "Schließen");
                return;
            }

            // Kaufdialog anzeigen
            var buy = await Application.Current.MainPage.DisplayAlert(preferenceKey, sDescription, "Kaufen", "Abbrechen");
            if (!buy)
                return;

            // Kauf abschließen
            var updatedBalance = balance - cost;
            Preferences.Set("Lebkuchen", updatedBalance);
            Preferences.Set(preferenceKey, true);
            Preferences.Set("Slowing", slowbonus);

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