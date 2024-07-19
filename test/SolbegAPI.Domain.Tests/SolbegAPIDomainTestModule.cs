using Volo.Abp.Modularity;

namespace SolbegAPI;

[DependsOn(
    typeof(SolbegAPIDomainModule),
    typeof(SolbegAPITestBaseModule)
)]
public class SolbegAPIDomainTestModule : AbpModule
{

}
