using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using No_Gifts_By_Santa.MVVM.Model;

namespace No_Gifts_By_Santa.MVVM.View;

public partial class TutorialView : ContentView
{
    private readonly dropElement _giftBoxDropElement;
    private readonly List<Item> _items = new List<Item>();
    public TutorialView()
    {
        InitializeComponent();
        wishes.Text =
            "Hello, my name is mad,\n i want a orange colored thing,\n to give it to me,\n drag and drop it\n into the gift-package";
        _giftBoxDropElement = new TutorialGift(Canvas);
        _giftBoxDropElement.Source = "gift_1.png";
        Canvas.Add(_giftBoxDropElement);
        AbsoluteLayout.SetLayoutBounds(_giftBoxDropElement, new Rect(80, 220, 60, 60));

        _items.Add(allItems.Bee(Canvas, _giftBoxDropElement));
        _items.Add(allItems.Candy(Canvas, _giftBoxDropElement));
        _items.Add(allItems.mug1(Canvas, _giftBoxDropElement));
        _items.Add(allItems.mug2(Canvas, _giftBoxDropElement));
        _items.Add(allItems.orange(Canvas, _giftBoxDropElement));
        _items.Add(allItems.gingerbread(Canvas, _giftBoxDropElement));
        _items.Add(allItems.Candy_2(Canvas, _giftBoxDropElement));
        _items.Add(allItems.ring1(Canvas, _giftBoxDropElement));
        //_items.Add(allItems.Dildo(Canvas, _giftBoxDropElement));
        _items.Add(allItems.Axe(Canvas, _giftBoxDropElement));
        _items.Add(allItems.Hat(Canvas, _giftBoxDropElement));
        _items.Add(allItems.jar(Canvas, _giftBoxDropElement));
        foreach (var item in _items)
        {
            Canvas.Add(item);
            AbsoluteLayout.SetLayoutBounds(item, new Rect(300, 200, 60, 60));
        }
    }
}