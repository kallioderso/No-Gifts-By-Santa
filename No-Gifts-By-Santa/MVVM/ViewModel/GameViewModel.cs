using System.ComponentModel;
using System.Runtime.CompilerServices;
using No_Gifts_By_Santa.MVVM.Model;

namespace No_Gifts_By_Santa.MVVM.ViewModel
{
    public class GameViewModel : INotifyPropertyChanged
    {
        //Variables - Basic
        private int level;
        private int _preparedGifts;

        //Clock Variables
        private clock _clock = new clock();
        private string _clockTime;
        public string clockTime
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
            get => $"Remaining Gifs: {_remainingGifts}";
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
            Preferences.Set("preparedGifts", 0);
            Preferences.Set("Normal", 0);
            Preferences.Set("Good", 0);
            Preferences.Set("Perfekt", 0);
            _clock.PropertyChanged += (s, e) =>
            {
                if (e.PropertyName == nameof(_clock._hours) || e.PropertyName == nameof(_clock._minutes))
                {
                    clockTime = $"clock_{_clock._hours}_{_clock._minutes:D2}.png";
                    OnPropertyChanged(nameof(clockTime));
                    if(_clock._hours == 20)
                        CheckforWonGame();
                }
            };
            clockTime = $"clock_{_clock._hours}_{_clock._minutes:D2}.png";
            OnPropertyChanged(nameof(clockTime));
            _clock.StartClock();
        }

        //Method for picking items and the Gift box
        public void GenerateRound(AbsoluteLayout Canvas) => _GeneratePlayRound(Canvas);
        public void InputLevel(int _level) => level = _level;
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
            
            for (int i = 0; i < _items.Count; i++)
            {
                double x = new Random().Next(700, 1500) * scaleX;
                double y = new Random().Next(400, 800) * scaleY;
                AbsoluteLayout.SetLayoutBounds(_items[i], new Rect(x, y, size, size));
            }
        }

        private void _GeneratePlayRound(AbsoluteLayout _canvas)
        {
            // Clear old items first
            _items.Clear();

            //Set progressbar
            _preparedGifts = Preferences.Get("preparedGifts", 0);
            _remainingGifts = _progressBar >= 1 ? 0 : level - _preparedGifts;
            OnPropertyChanged(nameof(RemainingGifts));
            _progressBar = ((double)_preparedGifts / level);
            OnPropertyChanged(nameof(Progress));
            

            _lebkuchen = Preferences.Get("Lebkuchen", 0).ToString();
            OnPropertyChanged(nameof(Lebkuchen));
            
            var _wish = allwishes.random(_canvas, this);
            _giftBox = _wish.drop;
            _wishText = _wish.wish;
            OnPropertyChanged(nameof(WishText));
            
            _items.Add(allItems.Bee(_canvas, _giftBox));
            _items.Add(allItems.Candy(_canvas, _giftBox));
            _items.Add(allItems.mug1(_canvas, _giftBox));
            _items.Add(allItems.mug2(_canvas, _giftBox));
            _items.Add(allItems.orange(_canvas, _giftBox));
            _items.Add(allItems.gingerbread(_canvas, _giftBox));
            _items.Add(allItems.Candy_2(_canvas, _giftBox));
            _items.Add(allItems.ring1(_canvas, _giftBox));
            _items.Add(allItems.Dildo(_canvas, _giftBox));
            _items.Add(allItems.Axe(_canvas, _giftBox));
            _items.Add(allItems.Hat(_canvas, _giftBox));
            _items.Add(allItems.jar(_canvas, _giftBox));
            _items.Add(allItems.hat2(_canvas, _giftBox));
            _items.Add(allItems.money1(_canvas, _giftBox));
            _items.Add(allItems.money2(_canvas, _giftBox));
            _items.Add(allItems.heyheyhey(_canvas, _giftBox));
            _items.Add(allItems.ring2(_canvas, _giftBox));
            _items.Add(allItems.carrot(_canvas, _giftBox));
            
            // Add gift box to the canvas - left bottom table area
            _canvas.Add(_giftBox);
            AbsoluteLayout.SetLayoutBounds(_giftBox, new Rect(280, 600, 120, 120));
        
            for (int i = 0; i < _items.Count; i++)
            {
                _canvas.Add(_items[i]);
                AbsoluteLayout.SetLayoutBounds(_items[i], new Rect(new Random().Next(700, 1600), new Random().Next(400, 800), 80, 80));
            }
        }

        private void CheckforWonGame()
        {
            MainThread.BeginInvokeOnMainThread(async () =>
            {
                if (_preparedGifts >= level)
                {
                    if(Preferences.Get("level", 1) == level)
                        Preferences.Set("level", Preferences.Get("level", 1) +1);
                    Preferences.Set("complete", true);
                }
                else
                    Preferences.Set("complete", false);

                await Application.Current!.MainPage!.DisplayAlert(
                    Preferences.Get("complete", false) == true ? $"Day {level} commpleted" : $"Day {level} failed",
                    $"Earned: {Preferences.Get("earnings", 0)}\n\nGifts:\nNormal: {Preferences.Get("Normal", 0)}\nGood: {Preferences.Get("Good", 0)}\nPerfekt: {Preferences.Get("Perfekt", 0)}",
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