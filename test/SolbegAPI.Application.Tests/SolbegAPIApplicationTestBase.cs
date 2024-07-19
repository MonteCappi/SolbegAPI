using Volo.Abp.Modularity;

namespace SolbegAPI;

public abstract class SolbegAPIApplicationTestBase<TStartupModule> : SolbegAPITestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
