using System;
using System.Collections.Generic;
using System.Text;
using SolbegAPI.Localization;
using Volo.Abp.Application.Services;

namespace SolbegAPI;

/* Inherit your application services from this class.
 */
public abstract class SolbegAPIAppService : ApplicationService
{
    protected SolbegAPIAppService()
    {
        LocalizationResource = typeof(SolbegAPIResource);
    }
}
