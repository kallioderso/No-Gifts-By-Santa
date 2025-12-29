using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using No_Gifts_By_Santa.MVVM.Model;

namespace No_Gifts_By_Santa.MVVM.View;

public partial class GameView : ContentPage
{
    public GameView(int _level)
    {
        InitializeComponent();
        test.Text = $"Tag: {_level}";
        var _clock = new clock(Canvas)
        {
            HorizontalOptions = LayoutOptions.End,
            VerticalOptions = LayoutOptions.Start
        };
        Canvas.Add(_clock);
        AbsoluteLayout.SetLayoutBounds(_clock, new Rect(1000, 0, 100, 100));
        _clock.StartClock();
        var giftBox = new Model.dropElement(Canvas);
        giftBox.Source = "tilecoins_shop.png";
        Canvas.Add(giftBox);
        AbsoluteLayout.SetLayoutBounds(giftBox, new Rect(200, 500, 100, 100));

        var salbe = new Model.Item(Canvas, giftBox);
        salbe.Source = "salbe.png";
        Canvas.Add(salbe);
        
        var tee = new Model.Item(Canvas, giftBox);
        tee.Source = "tee.png";
        Canvas.Add(tee);
        
        var kekse = new Model.Item(Canvas, giftBox);
        kekse.Source = "kekse.png";
        Canvas.Add(kekse);
        
        var biene = new Model.Item(Canvas, giftBox);
        biene.Source = "biene.png";
        Canvas.Add(biene);
    }
}