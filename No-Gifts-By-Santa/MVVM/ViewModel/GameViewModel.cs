using System.ComponentModel;
using System.Runtime.CompilerServices;
using No_Gifts_By_Santa.MVVM.Model;

namespace No_Gifts_By_Santa.MVVM.ViewModel
{
    public class GameViewModel : INotifyPropertyChanged
    {
        //Variables - Basic
        private int _level;
        private int _preparedGifts;

        //Clock Variables
        private readonly clock _clock = new clock();
        private string _clockTime;
        public string ClockTime
        {
            get => _clockTime;
            set => _clockTime = value;
        }

        //Progressbar Variables
        public double Progress
        {
            get => _progressBar;
            set => _progressBar = value;
        }

        private double _progressBar;

        public string RemainingGifts
        {
            get => $"Remaining Gifts: {_remainingGifts}";
            private set;
        }
        private int _remainingGifts;

        //Displaying Lebkuchen Variables
        public string Lebkuchen
        {
            get => _lebkuchen;
            set => _lebkuchen = value;
        }

        private string _lebkuchen;

        //Variables for transfering the Elements to the View
        public List<Item> items
        {
            get => _items;
            private set => _items = value;
        }

        private List<Item> _items = new List<Item>();

        public dropElement GiftBox
        {
            get => _giftBox;
            private set => _giftBox = value;
        }

        private dropElement _giftBox;

        public string WishText
        {
            get => _wishText;
            private set => _wishText = value;
        }

        private string _wishText;

        //Constructor
        public GameViewModel()
        {
            Preferences.Set("earnings", 0);
            Preferences.Set("preparedItem", 0);
            Preferences.Set("preparedGifts", 0);
            Preferences.Set("Worse", 0);
            Preferences.Set("Bad", 0);
            Preferences.Set("usable", 0);
            Preferences.Set("Normal", 0);
            Preferences.Set("Good", 0);
            Preferences.Set("Perfekt", 0);
            _clock.PropertyChanged += (s, e) =>
            {
                if (e.PropertyName == nameof(_clock._hours) || e.PropertyName == nameof(_clock._minutes))
                {
                    ClockTime = $"clock_{_clock._hours}_{_clock._minutes:D2}.png";
                    OnPropertyChanged(nameof(ClockTime));
                }
                if (e.PropertyName == nameof(_clock._finished))
                    CheckforWonGame();
            };
            ClockTime = $"clock_{_clock._hours}_{_clock._minutes:D2}.png";
            OnPropertyChanged(nameof(ClockTime));
            _clock.StartClock();
        }

        //Method for picking items and the Gift box
        public void GenerateRound(AbsoluteLayout Canvas, double scaleX, double scaleY) => _GeneratePlayRound(Canvas, scaleX, scaleY);
        public void InputLevel(int _level) => this._level = _level;
        public void ClearRound()
        {
            _items.Clear();
            _giftBox = null;
            _wishText = string.Empty;
            OnPropertyChanged(nameof(WishText));
        }

        public void UpdateGiftBoxPosition(AbsoluteLayout canvas, double scaleX, double scaleY)
        {
            if (_giftBox != null)
            {
                double x = 280 * scaleX;
                double y = 700 * scaleY;
                double size = 120 * Math.Min(scaleX, scaleY);
                AbsoluteLayout.SetLayoutBounds(_giftBox, new Rect(x, y, size, size));
            }
        }

        public void UpdateItemsPositions(AbsoluteLayout canvas, double scaleX, double scaleY)
        {
            if (_items.Count == 0) return;
            
            double size = 80 * Math.Min(scaleX, scaleY);
            
            foreach (var t in _items)
            {
                double x = new Random().Next(700, 1500) * scaleX;
                double y = new Random().Next(400, 800) * scaleY;
                AbsoluteLayout.SetLayoutBounds(t, new Rect(x, y, size, size));
            }
        }

        private void _GeneratePlayRound(AbsoluteLayout _canvas, double scaleX, double scaleY)
        {
            // Clear old items first
            _items.Clear();

            //Set progressbar
            _preparedGifts = Preferences.Get("preparedGifts", 0);
            _remainingGifts = _progressBar >= 1 ? 0 : _level - _preparedGifts;
            OnPropertyChanged(nameof(RemainingGifts));
            _progressBar = ((double)_preparedGifts / _level);
            OnPropertyChanged(nameof(Progress));
            

            _lebkuchen = Preferences.Get("Lebkuchen", 0).ToString();
            OnPropertyChanged(nameof(Lebkuchen));
            
            var _wish = allwishes.random(_canvas, this);
            _giftBox = _wish.drop;
            _wishText = _wish.wish;
            OnPropertyChanged(nameof(WishText));
            
            _items.Add(allItems.Bee(_canvas, _giftBox));
            if (Preferences.Get("CandyCane", false))
                _items.Add(allItems.Candy(_canvas, _giftBox));
            _items.Add(allItems.mug1(_canvas, _giftBox));
            _items.Add(allItems.mug2(_canvas, _giftBox));
            if (Preferences.Get("Orange", false))
                _items.Add(allItems.orange(_canvas, _giftBox));
            if (Preferences.Get("GingerbreadMan", false))
                _items.Add(allItems.gingerbread(_canvas, _giftBox));
            if (Preferences.Get("BonBon", false))
                _items.Add(allItems.Candy_2(_canvas, _giftBox));
            _items.Add(allItems.ring1(_canvas, _giftBox));
            //_items.Add(allItems.Dildo(_canvas, _giftBox));
            _items.Add(allItems.Axe(_canvas, _giftBox));
            _items.Add(allItems.Hat(_canvas, _giftBox));
            _items.Add(allItems.jar(_canvas, _giftBox));
            if (Preferences.Get("Hayhat", false))
                _items.Add(allItems.hat2(_canvas, _giftBox));
            _items.Add(allItems.money1(_canvas, _giftBox));
            _items.Add(allItems.money2(_canvas, _giftBox));
            if (Preferences.Get("pitchfork", false))
                _items.Add(allItems.heyheyhey(_canvas, _giftBox));
            _items.Add(allItems.ring2(_canvas, _giftBox));
            if (Preferences.Get("Carrot", false))
                _items.Add(allItems.carrot(_canvas, _giftBox));
            if (Preferences.Get("Apple", false))
                _items.Add(allItems.apple(_canvas, _giftBox));
            if (Preferences.Get("Cherry", false))
                _items.Add(allItems.cherry(_canvas, _giftBox));
            
            // Add gift box to the canvas - left bottom table area
            _canvas.Add(_giftBox);
            AbsoluteLayout.SetLayoutBounds(_giftBox, new Rect(280*scaleX, 720*scaleY, 200*scaleX, 200*scaleX));
        
            foreach (var t in _items)
            {
                _canvas.Add(t);
                AbsoluteLayout.SetLayoutBounds(t, new Rect(new Random().Next(700, 1600)*scaleX, new Random().Next(400, 800)*scaleY, 80*scaleX, 80*scaleX));
            }
        }

        private void CheckforWonGame()
        {
            if (!_clock._finished)
                return;
            MainThread.BeginInvokeOnMainThread(async () =>
            {
                if (_preparedGifts >= _level && !(Preferences.Get("Worse", 0) + Preferences.Get("Bad", 0) >= _level/2))
                {
                    if(Preferences.Get("level", 1) == _level)
                        Preferences.Set("level", Preferences.Get("level", 1) +1);
                    Preferences.Set("complete", true);
                }
                else
                    Preferences.Set("complete", false);

                await Application.Current!.MainPage!.DisplayAlert(
                    Preferences.Get("complete", false) ? $"Day {_level} commpleted" : $"Day {_level} failed",
                    $"Prepared Items: {Preferences.Get("preparedItem", 0)} \nPrepared Gifts: {Preferences.Get("preparedGifts", 0)}\nEarned gingerbread: {Preferences.Get("earnings", 0)}\n\nGifts:\nWorse: {Preferences.Get("Worse", 0)} \nBad: {Preferences.Get("Bad", 0)} \nusable: {Preferences.Get("usable", 0)}\nNormal: {Preferences.Get("Normal", 0)}\nGood: {Preferences.Get("Good", 0)}\nPerfekt: {Preferences.Get("Perfekt", 0)}{(Preferences.Get("complete", false) ? "" : ((Preferences.Get("Worse", 0) + Preferences.Get("Bad", 0) >= _level/2) ? "\n\nFailed: To Bad Presents" : "\n\nFailed: To less Presents"))}",
                    "continue");
                await Application.Current.MainPage.Navigation.PopAsync();
            });
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