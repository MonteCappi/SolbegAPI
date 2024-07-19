using Volo.Abp.Modularity;

namespace SolbegAPI;

[DependsOn(
    typeof(SolbegAPIApplicationModule),
    typeof(SolbegAPIDomainTestModule)
)]
public class SolbegAPIApplicationTestModule : AbpModule
{

}
