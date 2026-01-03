namespace No_Gifts_By_Santa.MVVM.Model
{
    public class TutorialGift : dropElement
    {
        public TutorialGift(AbsoluteLayout canvas) : base(canvas, null, "orange", "food", "all", "fruit", "hunger")
        {
            this.HeightRequest = 150;
            this.WidthRequest = 150;
        }
    }
}