using SolbegAPI.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace SolbegAPI.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(SolbegAPIEntityFrameworkCoreModule),
    typeof(SolbegAPIApplicationContractsModule)
    )]
public class SolbegAPIDbMigratorModule : AbpModule
{
}
