
namespace No_Gifts_By_Santa.MVVM.Model
{
    public class dropElement : Image
    {
        //Variables
        private AbsoluteLayout _canvas;

        public dropElement(AbsoluteLayout canvas)
        {
            _canvas = canvas;
        }

        public void CaptureItem(Item item) => TakeItem(item);

        private void TakeItem(Item item)
        {
            
        }
    }
}