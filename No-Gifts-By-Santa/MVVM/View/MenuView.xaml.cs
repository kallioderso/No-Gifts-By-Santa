using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Maui.Layouts;
using No_Gifts_By_Santa.MVVM.ViewModel;

namespace No_Gifts_By_Santa.MVVM.View;

public partial class MenuView : ContentPage
{
    //Variables
    private MenuViewModel? _viewModel;
    private double _startX = 0;
    private double _startY = 0;
    
    //Constructor
    public MenuView()
    {
        InitializeComponent();
        _viewModel = BindingContext as MenuViewModel;
        this.SizeChanged += SizeChangedEvent;
        AbsoluteLayout.SetLayoutFlags(PopupFrame, AbsoluteLayoutFlags.None);
    }

    //Methods
    void SizeChangedEvent(object? sender, EventArgs eventArgs) => _viewModel?.ChangeSize(this.Width, this.Height);

    void PopUpDragUpdate(object sender, PanUpdatedEventArgs e)
    {
        if (!PopupFrame.IsVisible)
            return;
        
        switch (e.StatusType)
        {
            case GestureStatus.Started:
                var bounds = AbsoluteLayout.GetLayoutBounds(PopupFrame);
                _startX = bounds.X;
                _startY = bounds.Y;
                break;
            
            case GestureStatus.Running:
                double newX = _startX + e.TotalX;
                double newY = _startY + e.TotalY;

                var currentBounds = AbsoluteLayout.GetLayoutBounds(PopupFrame);
                double w = currentBounds.Width > 0 ? currentBounds.Width : (PopupFrame.Width > 0 ? PopupFrame.Width : 500);
                double h = currentBounds.Height > 0 ? currentBounds.Height : (PopupFrame.Height > 0 ? PopupFrame.Height : 300);

                AbsoluteLayout.SetLayoutBounds(PopupFrame, new Rect(newX, newY, w, h));
                break;

            case GestureStatus.Completed:
            case GestureStatus.Canceled:
                break;
        }
    }
}