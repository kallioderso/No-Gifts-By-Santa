namespace No_Gifts_By_Santa.MVVM.Model
{
    public class dragElement : Image
    {
        //Basic Variables and Components
        private AbsoluteLayout _canvas;
        private PanGestureRecognizer _dragGesture = new();
        
        //Draging Variables
        private double _startPointX;
        private double _startPointY;
        
        public dragElement(AbsoluteLayout canvas)
        {
            _canvas = canvas;
            this.GestureRecognizers.Add(_dragGesture);
            _dragGesture.PanUpdated += Draging;
        }

        private void Draging(object? sender, PanUpdatedEventArgs e)
        {
            switch (e.StatusType)
            {
                case GestureStatus.Started:
                    var binds = _canvas.GetLayoutBounds(this);
                    _startPointX = binds.X;
                    _startPointY = binds.Y;
                    break;
                
                case GestureStatus.Running:
                    var currentX = _startPointX + e.TotalX;
                    var currentY = _startPointY + e.TotalY;
                    
                    var currentBounds = _canvas.GetLayoutBounds(this);
                    double w = currentBounds.Width > 0 ? currentBounds.Width : (this.Width > 0 ? this.Width : 100);
                    double h = currentBounds.Height > 0 ? currentBounds.Height : (this.Height > 0 ? this.Height : 100);
                    
                    _canvas.SetLayoutBounds(this, new Rect(currentX, currentY, w, h));
                    break;
                
                case GestureStatus.Canceled:
                case GestureStatus.Completed:
                    break;
            }
        }
    }
}