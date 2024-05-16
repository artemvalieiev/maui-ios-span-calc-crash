namespace MauiApp1;

public partial class MainPage : ContentPage
{
    int count = 0;

    public MainPage()
    {
        InitializeComponent();
    }

    private void OnSpanTap(object? sender, TappedEventArgs e)
    {
        var random = new Random();
        byte[] color = new byte[3];
        random.NextBytes(color);
        LinkSpan.BackgroundColor = new Color(color[0], color[1], color[2]);
    }
}