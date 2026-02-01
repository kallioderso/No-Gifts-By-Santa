
using System.ComponentModel;
using No_Gifts_By_Santa.MVVM.ViewModel;

namespace No_Gifts_By_Santa.MVVM.Model
{
    public class dropElement : dragElement, INotifyPropertyChanged
    {
        //Variables
        private AbsoluteLayout _canvas;
        private GameViewModel _viewModel;
        private List<Item> _items = new List<Item>();
        private int _itemAmount = 0;
        private int _itemsPossible = 0;

        //Properties
        private string Color { get; set; }
        private string Category { get; set; }
        private string AgeGroup { get; set; }
        private string Material { get; set; }
        private string Usage { get; set; }

        public dropElement(AbsoluteLayout canvas, GameViewModel _gameview, int itemsAmount, string color, string category, string ageGroup, string material, string usage) : base(canvas)
        {
            _canvas = canvas;
            _viewModel = _gameview;
            _itemsPossible = itemsAmount;
            Color = color;
            Category = category;
            AgeGroup = ageGroup;
            Material = material;
            Usage = usage;
        }

        // Methods for Storing items
        public void CaptureItem(Item item) => TakeItemAsync(item);

        private async Task TakeItemAsync(Item _item)
        {
            _items.Add(_item);
            _itemAmount++;
            if(_itemAmount == _itemsPossible)
            {
                foreach (var item in _items)
                {
                    int perfektCounter = 0;
                    if(item.Color == Color)
                    {
                        Preferences.Set("Lebkuchen", Preferences.Get("Lebkuchen", 0) + 1);
                        Preferences.Set("earnings", Preferences.Get("earnings", 0)+1);
                        perfektCounter++;
                    }

                    if (item.Category == Category)
                    {
                        Preferences.Set("Lebkuchen", Preferences.Get("Lebkuchen", 0) + 1);
                        Preferences.Set("earnings", Preferences.Get("earnings", 0)+1);
                        perfektCounter++;
                    }
                    if(item.AgeGroup == AgeGroup || item.AgeGroup == "all")
                    {
                        Preferences.Set("Lebkuchen", Preferences.Get("Lebkuchen", 0) + 1);
                        Preferences.Set("earnings", Preferences.Get("earnings", 0)+1);
                        perfektCounter++;
                    }
                    if(item.Material == Material)
                    {
                        Preferences.Set("Lebkuchen", Preferences.Get("Lebkuchen", 0) + 1);
                        Preferences.Set("earnings", Preferences.Get("earnings", 0)+1);
                        perfektCounter++;
                    }

                    if (item.Usage == Usage)
                    {
                        Preferences.Set("Lebkuchen", Preferences.Get("Lebkuchen", 0) + 1);
                        Preferences.Set("earnings", Preferences.Get("earnings", 0)+1);
                        perfektCounter++;
                    }

                    switch (perfektCounter)
                    {
                        case 0:
                            Preferences.Set("Lebkuchen", Preferences.Get("Lebkuchen", 0) + 0); Preferences.Set("Worse", Preferences.Get("Worse", 0) + 1); Preferences.Set("earnings", Preferences.Get("earnings", 0)+0); break;
                        case 1:
                            Preferences.Set("Lebkuchen", Preferences.Get("Lebkuchen", 0) + 0); Preferences.Set("Bad", Preferences.Get("Bad", 0) + 1); Preferences.Set("earnings", Preferences.Get("earnings", 0)+0); break;
                        case 2:
                            Preferences.Set("Lebkuchen", Preferences.Get("Lebkuchen", 0) + 0); Preferences.Set("usable", Preferences.Get("usable", 0) + 1); Preferences.Set("earnings", Preferences.Get("earnings", 0)+0); break;
                        case 3:
                            Preferences.Set("Lebkuchen", Preferences.Get("Lebkuchen", 0) + 1); Preferences.Set("Normal", Preferences.Get("Normal", 0) + 1); Preferences.Set("earnings", Preferences.Get("earnings", 0)+1); break;
                        case 4:
                            Preferences.Set("Lebkuchen", Preferences.Get("Lebkuchen", 0) + 2); Preferences.Set("Good", Preferences.Get("Good", 0) + 1); Preferences.Set("earnings", Preferences.Get("earnings", 0)+2); break;
                        case 5:
                            Preferences.Set("Lebkuchen", Preferences.Get("Lebkuchen", 0) + 3); Preferences.Set("Perfekt", Preferences.Get("Perfekt", 0) + 1); Preferences.Set("earnings", Preferences.Get("earnings", 0)+3); break;
                    }

                    Preferences.Set("preparedItem", Preferences.Get("preparedItem", 0) + 1);
                }
                _canvas.Clear();
                Preferences.Set("preparedGifts", Preferences.Get("preparedGifts", 0)+1);
                if(_viewModel != null)
                    _viewModel.GenerateRound(_canvas, _canvas.Width / 1920, _canvas.Height / 1080);
                else
                {
                    await Application.Current.MainPage.DisplayAlert("Finished",
                    "You got how it works, so start safing Christmas, Your shift will take from 9 AM to 8 PM, so huryy up!",
                    "continue");
                    await Application.Current.MainPage.Navigation.PopAsync();
                }
            }
        }
    }
}