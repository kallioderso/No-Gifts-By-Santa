using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No_Gifts_By_Santa.MVVM.View;

public partial class GameView : ContentPage
{
    public GameView()
    {
        InitializeComponent();
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