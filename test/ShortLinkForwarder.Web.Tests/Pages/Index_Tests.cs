using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace ShortLinkForwarder.Pages
{
    public class Index_Tests : ShortLinkForwarderWebTestBase
    {
        [Fact]
        public async Task Welcome_Page()
        {
            var response = await GetResponseAsStringAsync("/");
            response.ShouldNotBeNull();
        }
    }
}
