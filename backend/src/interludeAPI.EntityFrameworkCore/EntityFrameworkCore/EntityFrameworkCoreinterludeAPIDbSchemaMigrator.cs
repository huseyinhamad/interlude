using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using interludeAPI.Data;
using Volo.Abp.DependencyInjection;

namespace interludeAPI.EntityFrameworkCore;

public class EntityFrameworkCoreinterludeAPIDbSchemaMigrator
    : IinterludeAPIDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreinterludeAPIDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the interludeAPIDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<interludeAPIDbContext>()
            .Database
            .MigrateAsync();
    }
}
