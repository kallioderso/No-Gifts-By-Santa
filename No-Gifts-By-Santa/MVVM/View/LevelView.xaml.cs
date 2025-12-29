using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No_Gifts_By_Santa.MVVM.View;

public partial class LevelView : ContentView
{
    public LevelView()
    {
        InitializeComponent();
    }

    private async void Button_OnClicked(object? sender, EventArgs e)
    {
        var _button = sender as Button;
        try
        {
            if (Application.Current?.MainPage?.Navigation != null)
                await Application.Current.MainPage.Navigation.PushAsync(new GameView(Convert.ToInt32(_button.Text)), true);
        }
        catch (Exception){/*inactive*/}
    }
}