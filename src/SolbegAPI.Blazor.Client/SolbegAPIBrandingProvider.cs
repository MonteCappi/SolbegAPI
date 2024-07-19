using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace SolbegAPI.Blazor.Client;

[Dependency(ReplaceServices = true)]
public class SolbegAPIBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "SolbegAPI";
}
