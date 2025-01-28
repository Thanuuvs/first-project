using Microsoft.Maui.Controls;
namespace MauiApp2;
public partial class InputControlDemo : ContentPage
{
    public InputControlDemo()
    {
        InitializeComponent();
    }

    private void slider_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        lbslider.Text = slider.Value.ToString();
    }

    private void stepper_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        if (stepper != null)
        {
            lbslider.Text = stepper.Value.ToString();
        }
    }
}