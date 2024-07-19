using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace SolbegAPI.Web;

[Dependency(ReplaceServices = true)]
public class SolbegAPIBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "SolbegAPI";
}
