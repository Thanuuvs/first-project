namespace MauiApp2;

public partial class ContentPageDemo : ContentPage
{
	public ContentPageDemo()
	{
		InitializeComponent();
	}
	private void OnClick(object sender, EventArgs e)
	{
		Navigation.PushAsync(new Flyoutpage());
	}
}