using MauiApp2.MVVM.Models;
using MauiApp2.MVVM.ViewModels;

namespace MauiApp2.MVVM.View;

public partial class PersonViewDemo : ContentPage
{
    public PersonViewDemo()
    {
        InitializeComponent();

        BindingContext = new PersonViewModel(); // Ensure this matches the ViewModel class
    }
}
