using System.Diagnostics;
using System.Xml.Linq;
namespace MauiApp2;

public partial class TextControlSDemo : ContentPage
{
    public TextControlSDemo()
    {
        InitializeComponent();
    }

    private void Entry_TextChanged(object sender, TextChangedEventArgs e)
    {
      
    }

    private void Entry_Completed(object sender, EventArgs e)
    {
        Debug.WriteLine(txtName.Text);
    }
}