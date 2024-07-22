using System;
using System.Collections.Generic;
using System.Text;
using System.Web.Mvc;
using SolbegAPI.Localization;
using Volo.Abp.Application.Services;

namespace SolbegAPI;

/* Inherit your application services from this class.
 */

[AllowAnonymous]
public abstract class SolbegAPIAppService : ApplicationService
{
    protected SolbegAPIAppService()
    {
        LocalizationResource = typeof(SolbegAPIResource);
    }
}
