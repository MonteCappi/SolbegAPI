using SolbegAPI.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace SolbegAPI.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class SolbegAPIController : AbpControllerBase
{
    protected SolbegAPIController()
    {
        LocalizationResource = typeof(SolbegAPIResource);
    }
}
