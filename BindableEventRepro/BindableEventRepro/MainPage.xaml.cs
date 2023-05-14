using Uno.Extensions.Reactive.Config;

namespace BindableEventRepro;

public sealed partial class MainPage : Page
{
    public MainPage()
    {
        this.InitializeComponent();
    }

    BindableModel BindableModel { get; } = new();
}

[ImplicitCommands(false)]
public partial record Model
{
    public void HyperlinkButton_Click(object sender, RoutedEventArgs e)
    {

    }
}

public partial class BindableModel
{
    public void HyperlinkButton_Click(object sender, RoutedEventArgs e)
    {

    }

}