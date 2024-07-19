using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SolbegAPI.Data;
using Volo.Abp.DependencyInjection;

namespace SolbegAPI.EntityFrameworkCore;

public class EntityFrameworkCoreSolbegAPIDbSchemaMigrator
    : ISolbegAPIDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreSolbegAPIDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the SolbegAPIDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<SolbegAPIDbContext>()
            .Database
            .MigrateAsync();
    }
}
