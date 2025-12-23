using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using No_Gifts_By_Santa.MVVM.ViewModel;

namespace No_Gifts_By_Santa.MVVM.View;

public partial class MenuView : ContentPage
{
    private MenuViewModel? _viewModel;
    public MenuView()
    {
        InitializeComponent();
        _viewModel = BindingContext as MenuViewModel;
        this.SizeChanged += SizeChangedEvent;
    }

    void SizeChangedEvent(object? sender, EventArgs eventArgs) => _viewModel?.ChangeSize(this.Width, this.Height);
}