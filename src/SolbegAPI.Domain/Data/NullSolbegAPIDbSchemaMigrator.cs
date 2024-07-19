using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace SolbegAPI.Data;

/* This is used if database provider does't define
 * ISolbegAPIDbSchemaMigrator implementation.
 */
public class NullSolbegAPIDbSchemaMigrator : ISolbegAPIDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
