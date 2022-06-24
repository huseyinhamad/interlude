using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace interludeAPI.Data;

/* This is used if database provider does't define
 * IinterludeAPIDbSchemaMigrator implementation.
 */
public class NullinterludeAPIDbSchemaMigrator : IinterludeAPIDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
