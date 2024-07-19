using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace SolbegAPI.Pages;

public class Index_Tests : SolbegAPIWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
