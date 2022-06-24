using interludeAPI.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace interludeAPI;

[DependsOn(
    typeof(interludeAPIEntityFrameworkCoreTestModule)
    )]
public class interludeAPIDomainTestModule : AbpModule
{

}
