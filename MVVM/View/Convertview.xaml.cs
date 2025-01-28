using MauiApp2.MVVM.View_Models;

namespace MauiApp2.MVVM.View;

public partial class Convertview : ContentPage
{
	public Convertview()
	{
		InitializeComponent();
		BindingContext = new ConvertModel();
	}
}