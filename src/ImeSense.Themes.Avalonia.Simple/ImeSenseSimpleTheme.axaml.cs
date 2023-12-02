using Avalonia.Markup.Xaml;
using Avalonia.Styling;

namespace ImeSense.Themes.Avalonia.Simple;

public class ImeSenseSimpleTheme : Styles {
    /// <summary>
    /// Initializes new instance of <see cref="ImeSenseSimpleTheme"/> class
    /// </summary>
    /// <param name="sp">Parent's service provider</param>
    public ImeSenseSimpleTheme(IServiceProvider? serviceProvider = null) {
        AvaloniaXamlLoader.Load(serviceProvider, this);
    }
}
