using MauiApp2.MVVM.View_Models;

namespace MauiApp2.MVVM.View;

public partial class Commandviewxaml : ContentPage
{
	public Commandviewxaml()
	{
		InitializeComponent();
		BindingContext = new Commandmodel();
	}
}