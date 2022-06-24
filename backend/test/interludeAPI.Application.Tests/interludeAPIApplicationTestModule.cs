using Volo.Abp.Modularity;

namespace interludeAPI;

[DependsOn(
    typeof(interludeAPIApplicationModule),
    typeof(interludeAPIDomainTestModule)
    )]
public class interludeAPIApplicationTestModule : AbpModule
{

}
