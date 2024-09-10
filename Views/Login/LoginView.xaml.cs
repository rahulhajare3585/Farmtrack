using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FarmTrack.Views.Main;

namespace FarmTrack.Views.Login;

public partial class LoginView : ContentPage
{
    public LoginView()
    {
        InitializeComponent();
    }

    private void Button_OnClicked(object? sender, EventArgs e)
    {
        try
        {
            Application.Current.MainPage.Navigation.PushAsync(new HomePage());
        }
        catch (Exception exception)
        {
            Console.WriteLine(exception);
        }
    }

    private void TapGestureRecognizer_OnTapped(object? sender, TappedEventArgs e)
    {
        Application.Current.MainPage.Navigation.PushAsync(new RegisterView());
    }
}