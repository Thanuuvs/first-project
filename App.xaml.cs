using MauiApp2.MVVM.View;

namespace MauiApp2
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new NavigationPage(new MainPage());
            //MainPage = new FlexLayoutPageDemo();
            //MainPage=new CommandControlDemo();
            //MainPage = new InputControlDemo();  
            //MainPage=new TextControlSDemo();
            //MainPage=new CollectionControlsDemo(); 
            //MainPage = new perfectpay();
            //MainPage = new BindingDemo();
            //MainPage = new workingimage();
            //MainPage = new Personview();
            //MainPage = new Convertview();
            //MainPage = new AppShell();
           MainPage = new Commandviewxaml();
        }
    }
}
