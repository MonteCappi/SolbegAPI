using SolbegAPI.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace SolbegAPI.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class SolbegAPIPageModel : AbpPageModel
{
    protected SolbegAPIPageModel()
    {
        LocalizationResourceType = typeof(SolbegAPIResource);
    }
}
