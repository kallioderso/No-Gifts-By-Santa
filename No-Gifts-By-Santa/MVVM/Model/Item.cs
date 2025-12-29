namespace No_Gifts_By_Santa.MVVM.Model
{
    public class Item : dragElement
    {
        //Base Item Properties
        private dropElement _giftBoxDropElement;
        private PanGestureRecognizer _dropGesture = new();
        private TapGestureRecognizer _tapGesture = new();
        private AbsoluteLayout _canvas;

        public string itemName { get; set; }
        public int itemID { get; set; }
        public string itemDescription { get; set; }
        
        //Variables fot Propertys of the Item
        public string Color { get; set; }
        public string Category { get; set; }
        public string AgeGroup { get; set; }
        public string Material { get; set; }
        public string Usage { get; set; }
        
        //Other Variables
        private bool _insidePackage = false;
        public Item(AbsoluteLayout canvas, dropElement dropElement) : base(canvas)
        {
            this.HeightRequest = 100;
            this.WidthRequest = 100;
            this.Focused += AttributeHover;
            _giftBoxDropElement = dropElement;
            _canvas = canvas;
            this.GestureRecognizers.Add(_dropGesture);
            _dropGesture.PanUpdated += Droping;
            this.GestureRecognizers.Add(_tapGesture);
            _tapGesture.Tapped += Taking;

        }


        private void AttributeHover(object? sender, FocusEventArgs e)
        {
            
        }

        private void Droping(object? sender, PanUpdatedEventArgs e)
        {
            var giftBoxRect = _canvas.GetLayoutBounds(_giftBoxDropElement);
            (double X, double Y) giftBoxPosition = (giftBoxRect.X, giftBoxRect.Y);
            var currentRect = _canvas.GetLayoutBounds(this);
            (double X, double Y) currentPosition = (currentRect.X, currentRect.Y);

            // Kollisionserkennung für 100x100 Objekte
            bool isColliding = currentPosition.X < giftBoxPosition.X + 100 &&
                               currentPosition.X + 100 > giftBoxPosition.X &&
                               currentPosition.Y < giftBoxPosition.Y + 100 &&
                               currentPosition.Y + 100 > giftBoxPosition.Y;
            
            if (isColliding)
            {
                _canvas.Children.Remove(this);
                _giftBoxDropElement.CaptureItem(this);
                _insidePackage = true;
            }
        }

        private void Taking(object? sender, TappedEventArgs tappedEventArgs)
        {
            if (_insidePackage)
            {
                _giftBoxDropElement.ReleaseItem(this);
                _canvas.Add(this);
                _insidePackage = false;
            }
        }
    }
}