using SolbegAPI.Localization;
using Volo.Abp.AspNetCore.Components;

namespace SolbegAPI.Blazor.WebApp.Client;

public abstract class SolbegAPIComponentBase : AbpComponentBase
{
    protected SolbegAPIComponentBase()
    {
        LocalizationResource = typeof(SolbegAPIResource);
    }
}
