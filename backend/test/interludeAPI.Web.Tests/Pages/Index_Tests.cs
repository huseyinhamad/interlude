using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace interludeAPI.Pages;

public class Index_Tests : interludeAPIWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
