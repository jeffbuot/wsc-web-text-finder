using System.Windows.Markup;

namespace WSC.WebTextFinder.Core;

public class ServiceProvider : MarkupExtension {
    public required Type Type { get; set; }

    public override object ProvideValue(IServiceProvider serviceProvider) {
        return ServiceLocator.Resolve(Type);
    }
}