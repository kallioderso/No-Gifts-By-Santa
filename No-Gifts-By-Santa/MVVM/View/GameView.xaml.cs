using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using No_Gifts_By_Santa.MVVM.Model;
using No_Gifts_By_Santa.MVVM.ViewModel;

namespace No_Gifts_By_Santa.MVVM.View;

public partial class GameView : ContentPage
{
    private GameViewModel _viewModel;
    public GameView(int _level)
    {
        InitializeComponent();
        _viewModel = BindingContext as GameViewModel;
        _viewModel.GenerateRound(Canvas);
    }

    protected override void OnSizeAllocated(double width, double height)
    {
        base.OnSizeAllocated(width, height);
        
        // Calculate scale based on screen size (reference: 1920x1080)
        double scaleX = width / 1920.0;
        double scaleY = height / 1080.0;
        double scale = Math.Min(scaleX, scaleY);
        
        // Update wish label position and size
        wishes.FontSize = 24 * scale;
        wishes.Margin = new Thickness(
            170 * scaleX,
            250 * scaleY,
            0,
            0
        );
        
        // Update gift box position
        _viewModel.UpdateGiftBoxPosition(Canvas, scaleX, scaleY);
        
        // Update items positions
        _viewModel.UpdateItemsPositions(Canvas, scaleX, scaleY);
    }

    public void RenewWish()
    {
        Canvas.Clear();
        _viewModel.ClearRound();
        _viewModel.GenerateRound(Canvas);
        
        // Trigger resize to reposition elements
        OnSizeAllocated(Width, Height);
    }
}