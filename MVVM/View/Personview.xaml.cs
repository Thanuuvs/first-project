using MauiApp2.MVVM.View_Models;

namespace MauiApp2.MVVM.View;

public partial class Personview : ContentPage
{
	public Personview()
	{
		InitializeComponent();
		BindingContext = new Peopleviewmodel();
	}
}