using Debug = System.Diagnostics.Debug;

namespace MauiApp1;

public partial class MainPage : ContentPage
{
    int count = 0;

    public MainPage()
    {
        InitializeComponent();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        this.CrashLabel.FormattedText = CreateFormattedString();
    }

    public FormattedString CreateFormattedString()
    {
        string upperText =
            "A culture of continuous learning isn't something you can ignore. 76% of employees are more inclined to stay when their workplace offers learning and development 🤔 Here's a few ways you can foster this:🧠 Create channels to encourage knowledge sharing between team members👏 Provide learning opportunities like job shadowing and rotation for hands-on experiences💬 Integrate routine feedback as a celebrated part of the workflow💻 Encourage your teams to dive into digital learning and live events Take a look at some more methods you can adopt from this recent article in Forbes 👇 🔗 ";

        var tapLinkGestureRecognizer = new TapGestureRecognizer
        {
            CommandParameter =
                "https://www.forbes.com/sites/forbeshumanresourcescouncil/2024/04/11/3-actionable-steps-for-managers-to-cultivate-a-learning-culture/",
            Command = new Command<string>(async (url) =>
            {
                Debug.WriteLine(url);
                await Launcher.OpenAsync(new Uri(url));
            })
        };

        return new FormattedString
        {
            Spans =
            {
                new Span { Text = upperText, FontFamily = "GilroyLight", FontSize = 14 },
                new Span
                {
                    GestureRecognizers = { tapLinkGestureRecognizer },
                    Text =
                        "https://www.forbes.com/sites/forbeshumanresourcescouncil/2024/04/11/3-actionable-steps-for-managers-to-cultivate-a-learning-culture/",
                    FontFamily = "GilroyLight", FontSize = 14, TextColor = Colors.LightSkyBlue,
                    TextDecorations = TextDecorations.Underline
                }
            }
        };
    }
}

public class MyClass
{
}