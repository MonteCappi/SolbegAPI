using SolbegAPI.Localization;
using Volo.Abp.AspNetCore.Components;

namespace SolbegAPI.Blazor.Client;

public abstract class SolbegAPIComponentBase : AbpComponentBase
{
    protected SolbegAPIComponentBase()
    {
        LocalizationResource = typeof(SolbegAPIResource);
    }
}
