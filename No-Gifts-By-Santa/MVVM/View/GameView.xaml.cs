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
        var salbe = new Model.Item(Canvas);
        salbe.Source = "salbe.png";
        Canvas.Add(salbe);
        
        var tee = new Model.Item(Canvas);
        tee.Source = "tee.png";
        Canvas.Add(tee);
        
        var kekse = new Model.Item(Canvas);
        kekse.Source = "kekse.png";
        Canvas.Add(kekse);
        
        var biene = new Model.Item(Canvas);
        biene.Source = "biene.png";
        Canvas.Add(biene);
    }
}