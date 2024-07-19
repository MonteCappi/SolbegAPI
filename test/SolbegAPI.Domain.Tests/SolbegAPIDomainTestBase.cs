using Volo.Abp.Modularity;

namespace SolbegAPI;

/* Inherit from this class for your domain layer tests. */
public abstract class SolbegAPIDomainTestBase<TStartupModule> : SolbegAPITestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
