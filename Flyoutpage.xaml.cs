namespace MauiApp2
{
    public partial class Flyoutpage : FlyoutPage
    {
        public Flyoutpage()
        {
            InitializeComponent();
        }

        private void OnEvent(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TabbedPageDemo());
        }
    }
}
