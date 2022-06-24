using System.Threading.Tasks;

namespace interludeAPI.Data;

public interface IinterludeAPIDbSchemaMigrator
{
    Task MigrateAsync();
}
