using interludeAPI.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace interludeAPI.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(interludeAPIEntityFrameworkCoreModule),
    typeof(interludeAPIApplicationContractsModule)
    )]
public class interludeAPIDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
