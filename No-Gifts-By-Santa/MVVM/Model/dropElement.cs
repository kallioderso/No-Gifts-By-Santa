
namespace No_Gifts_By_Santa.MVVM.Model
{
    public class dropElement : dragElement
    {
        //Variables
        private AbsoluteLayout _canvas;
        private List<Item> _items = new List<Item>();
        private Border _itemBorder = new Border()
        {
            HeightRequest = 60
        };
        private StackLayout _itemStacker = new StackLayout()
        {
            Margin = 5,
            Spacing = 4,
            Orientation = StackOrientation.Horizontal
        };

        private bool _containment = false;

        public dropElement(AbsoluteLayout canvas) : base(canvas)
        {
            _canvas = canvas;
            _itemBorder.Content = _itemStacker;
            _canvas.Add(_itemBorder);
            _canvas.SetLayoutBounds(_itemBorder, new Rect(200, 440, 100, 100));
            TapGestureRecognizer _reco = new TapGestureRecognizer();
            _reco.Tapped += HoverGift;
            this.GestureRecognizers.Add(_reco);
            _itemBorder.IsVisible = false;
        }

        // Methods for Storing items
        public void CaptureItem(Item item) => TakeItem(item);

        private void TakeItem(Item item)
        {
            _items.Add(item);
        }

        public void ReleaseItem(Item item)
        {
            _items.Remove(item);
        }

        // Methods for Displaying stored items
        private void HoverGift(object? sender, TappedEventArgs tappedEventArgs)
        {
            if(_containment)
                _itemBorder.IsVisible = false;
            else
            {
                int itemsCount = 0;
                _itemStacker.Clear();
                foreach (var _item in _items)
                {
                    _item.WidthRequest = 50;
                    _item.HeightRequest = 50;
                    _itemStacker.Add(_item);
                    itemsCount++;
                }

                _itemBorder.WidthRequest = 60 * itemsCount;
                _itemBorder.IsVisible = true;
                var position = _canvas.GetLayoutBounds(this);
                _canvas.SetLayoutBounds(_itemBorder, new Rect(position.X, (position.Y-70), 100, 100));
            }
            _containment = !_containment;
        }
    }
}